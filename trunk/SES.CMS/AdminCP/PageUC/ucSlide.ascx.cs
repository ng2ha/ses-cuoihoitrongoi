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
    public partial class ucSlide : System.Web.UI.UserControl
    {
        SlideDO objSlide = new SlideDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.DevCboDatabinder(cboParent, new cmsCategoryBL().SelectAll(), cmsCategoryDO.TITLE_FIELD, cmsCategoryDO.CATEGORYID_FIELD);
            if (Request.QueryString["SlideID"] != null)
            {
                objSlide.SlideID = int.Parse(Request.QueryString["SlideID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objSlide = new SlideBL().Select(objSlide);
            txtTitle.Text = objSlide.Title;
            txtDescription.Text = objSlide.Description;
            txtSlideURL.Text = objSlide.SlideURL;
            if (!string.IsNullOrEmpty(objSlide.SlideImg))
            {
                hplImage.Visible = true;
                hplImage.NavigateUrl = "~/Media/" + objSlide.SlideImg;
            }
            if(objSlide.CategoryID>0)
                cboParent.Value = objSlide.CategoryID.ToString();
            else
            { 
                if(objSlide.CategoryID==0)
                    {
                chkHome.Checked = true;
                cboParent.Text = "Trang chủ"; 
                }
                else if(objSlide.CategoryID==-1)
                {
                    chkHappyWedding.Checked = true;
                    cboParent.Text = "Hạnh phúc - Trang chủ"; 
                }
                else if(objSlide.CategoryID==-2)
                {
                    chkAlbumAnh.Checked = true;
                    cboParent.Text = "Album ảnh"; 
                }

            }
            txtOrder.Text = objSlide.OrderID.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objSlide.SlideID <= 0)
            {
                new SlideBL().Insert(objSlide);
            }
            else
            {
                new SlideBL().Update(objSlide);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListSlide");
        }

        private void initObject()
        {
            objSlide.Title = txtTitle.Text;
            objSlide.Description = txtDescription.Text;

            if (cboParent.Value != null && !cboParent.Value.ToString().Equals("Trang chủ") && !cboParent.Value.ToString().Equals("Hạnh phúc - Trang chủ") && !cboParent.Value.ToString().Equals("Album ảnh"))
                objSlide.CategoryID = int.Parse(cboParent.Value.ToString());
            else if (chkHome.Checked)
                objSlide.CategoryID = 0;
            else if (chkHappyWedding.Checked)
                objSlide.CategoryID = -1;
            else if (chkAlbumAnh.Checked)
                objSlide.CategoryID = -2;
            if (!string.IsNullOrEmpty(fuImage.FileName))
                objSlide.SlideImg = UploadFile(fuImage);
            objSlide.OrderID = int.Parse(txtOrder.Text);
            objSlide.SlideURL = txtSlideURL.Text;

        }
        private string UploadFile(FileUpload fulImages)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}