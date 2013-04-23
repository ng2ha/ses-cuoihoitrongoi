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
    public partial class ucProduct : System.Web.UI.UserControl
    {
        cmsProductDO objArt = new cmsProductDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cboProductLine, cmsProductLineDO.PRODUCTLINEID_FIELD, cmsProductLineDO.TITLE_FIELD, new cmsProductLineBL().SelectAll());
            if (Request.QueryString["ProductID"] != null)
            {
                objArt.ProductID = int.Parse(Request.QueryString["ProductID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objArt = new cmsProductBL().Select(objArt);
            txtTitle.Text = objArt.Title;
            txtDescription.Text = objArt.Description;
            txtMetaTag.Text = objArt.MetaTag;
            chkIsHomePage.Checked = objArt.IsHompage;
            cboProductLine.SelectedValue = objArt.ProductLineID.ToString();
            if(!string.IsNullOrEmpty(objArt.ProductImg1))
                {
            hplImage.Visible = true;
            hplImage.NavigateUrl = "~/Media/" + objArt.ProductImg1;
                }
            if (!string.IsNullOrEmpty(objArt.ProductImg2))
            {
                hplImage1.Visible = true;
                hplImage1.NavigateUrl = "~/Media/" + objArt.ProductImg2;
            }
            if (!string.IsNullOrEmpty(objArt.ProductImg3))
            {
                hplImage2.Visible = true;
                hplImage2.NavigateUrl = "~/Media/" + objArt.ProductImg3;
            }
            if (!string.IsNullOrEmpty(objArt.ProductImg4))
            {
                hplImage3.Visible = true;
                hplImage3.NavigateUrl = "~/Media/" + objArt.ProductImg4;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objArt.ProductID <= 0)
            {
                new cmsProductBL().Insert(objArt);
            }
            else
            {
                new cmsProductBL().Update(objArt);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListProduct");
        }
        private void initObject()
        {
            objArt.Title = txtTitle.Text;
            objArt.Description = txtDescription.Text;
            objArt.MetaTag = txtMetaTag.Text;
            objArt.IsHompage = chkIsHomePage.Checked;
          
            
            objArt.ProductLineID = int.Parse(cboProductLine.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(fuImage.FileName))
                objArt.ProductImg1 = UploadFile(fuImage);
            if (!string.IsNullOrEmpty(fuImage1.FileName))
                objArt.ProductImg2 = UploadFile(fuImage1);
            if (!string.IsNullOrEmpty(fuImage2.FileName))
                objArt.ProductImg3 = UploadFile(fuImage2);
            if (!string.IsNullOrEmpty(fuImage3.FileName))
                objArt.ProductImg4 = UploadFile(fuImage3);
        }

        private string UploadFile(FileUpload fulImages)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = string.Format("{0}{1}", RandomNumber(1,10).ToString() + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
        private  int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}