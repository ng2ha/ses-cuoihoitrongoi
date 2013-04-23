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
    public partial class ucImages : System.Web.UI.UserControl
    {
        cmsImagesDO objArt = new cmsImagesDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cboAlbum, "AlbumID", "Title", new cmsAlbumBL().SelectAll());
            if (Request.QueryString["ImageID"] != null)
            {
                objArt.ImageID = int.Parse(Request.QueryString["ImageID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objArt = new cmsImagesBL().Select(objArt);
            txtTitle.Text = objArt.Title;
            txtDescription.Text = objArt.Description;
            txtAlt.Text = objArt.Description;
            if (objArt.StyleAlbum == true)
                rdAlbum.Checked = true;
            if (objArt.StyleAlbum == false)
                rdKieu.Checked = true;
            
            cboAlbum.SelectedValue = objArt.AlbumID.ToString();

            if (!string.IsNullOrEmpty(objArt.ImgFile))
            {
                hplImage.Visible = true;
                hplImage.NavigateUrl = "~/Media/" + objArt.ImgFile;
            }

            if (!string.IsNullOrEmpty(objArt.Thumbnail))
            {
                hplThumbnail.Visible = true;
                hplThumbnail.NavigateUrl = "~/Media/" + objArt.Thumbnail;
            }
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objArt.ImageID <= 0)
            {
                new cmsImagesBL().Insert(objArt);
            }
            else
            {
                new cmsImagesBL().Update(objArt);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListImage");
        }
        private void initObject()
        {
            objArt.Title = txtTitle.Text;
            objArt.Description = txtAlt.Text;
            objArt.AlbumID = int.Parse(cboAlbum.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(fuImage.FileName))
                objArt.ImgFile = UploadFile(fuImage);
            if (!string.IsNullOrEmpty(fuThumbnail.FileName))
                objArt.Thumbnail = UploadFile(fuThumbnail);
            if (rdAlbum.Checked == true)
                objArt.StyleAlbum = true;
            if (rdKieu.Checked == true)
                objArt.StyleAlbum = false;
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
        private string UploadThumbnail(FileUpload fuThumbnail, string title)
        {
            if (!string.IsNullOrEmpty(fuThumbnail.FileName))
            {
                string FileName = string.Format("{0}{1}", title.Substring(0, title.LastIndexOf(".")) + "-Thumbnail", fuThumbnail.FileName.Substring(fuThumbnail.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fuThumbnail.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}