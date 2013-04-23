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
    public partial class ucProductLine : System.Web.UI.UserControl
    {
        cmsProductLineDO objArt = new cmsProductLineDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ProductLineID"] != null)
            {
                objArt.ProductLineID = int.Parse(Request.QueryString["ProductLineID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            hplImage.Visible = true;
            objArt = new cmsProductLineBL().Select(objArt);
            txtTitle.Text = objArt.Title;
            txtDescription.Text = objArt.Description;
            txtMetaTag.Text = objArt.MetaTag;
            hplImage.NavigateUrl = "~/Media/" + objArt.ProducLineImg;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objArt.ProductLineID <= 0)
            {
                new cmsProductLineBL().Insert(objArt);
            }
            else
            {
                new cmsProductLineBL().Update(objArt);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListProductLine");
        }
        private void initObject()
        {
            objArt.Title = txtTitle.Text;
            objArt.Description = txtDescription.Text;
            objArt.MetaTag = txtMetaTag.Text;
            objArt.CategoryID = 29;
            if (!string.IsNullOrEmpty(fuImage.FileName))
                objArt.ProducLineImg = UploadFile(fuImage);
        }

        private string UploadFile(FileUpload fulImage)
        {
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}