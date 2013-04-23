using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SES.CMS.BL;
using SES.CMS.DO;

namespace SES.CMS.AdminCP.PageUC
{
    public partial class ucConfig : System.Web.UI.UserControl
    {
        sysConfigDO objConfig = new sysConfigDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ConfigID"] != null)
            {
                objConfig.ConfigID = int.Parse(Request.QueryString["ConfigID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objConfig = new sysConfigBL().Select(objConfig);
            txtTitle.Text = objConfig.ConfigName;
            if (objConfig.ConfigID == 3)
            {
                txtCK.Text = objConfig.ConfigValue;
                trDes.Visible = false;
                trSupport.Visible = true;
            }
            else if (objConfig.ConfigID >= 8 && objConfig.ConfigID !=15)
            {
                txtCK.Text = objConfig.ConfigValue;
                trDes.Visible = false;
                trSupport.Visible = true;
            }
            else
                txtDescription.Text = objConfig.ConfigValue;
            chkActive.Checked = objConfig.IsActive;
            if (objConfig.ConfigID == 2 || objConfig.ConfigID == 6 || objConfig.ConfigID == 7)
            {
                trPopup.Visible = true;
                hplImage.NavigateUrl = "/Media/popupCHTG.jpg";

                if (objConfig.ConfigID == 6)
                    hplImage.NavigateUrl = "/Media/bannerleft.jpg";
                if (objConfig.ConfigID == 7)
                    hplImage.NavigateUrl = "/Media/bannerright.jpg";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objConfig.ConfigID <= 0)
            {
                new sysConfigBL().Insert(objConfig);
            }
            else
            {
                new sysConfigBL().Update(objConfig);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListConfig");
        }

        private void initObject()
        {
            objConfig.ConfigName = txtTitle.Text;
            if (objConfig.ConfigID == 3 || (objConfig.ConfigID >= 8 && objConfig.ConfigID!=15))
                objConfig.ConfigValue = txtCK.Text;
            else objConfig.ConfigValue = txtDescription.Text;
            objConfig.IsActive = chkActive.Checked;
            if (objConfig.ConfigID == 2 || objConfig.ConfigID == 6 || objConfig.ConfigID == 7)
            {
                UploadFile(fuImage);
            }

        }
        private string UploadFile(FileUpload fulImages)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = "popupCHTG.jpg";
                if (objConfig.ConfigID == 6)
                    FileName = "bannerleft.jpg";
                if (objConfig.ConfigID == 7)
                    FileName = "bannerright.jpg";

                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                if (System.IO.File.Exists(SaveLocation))
                    System.IO.File.Delete(SaveLocation);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}