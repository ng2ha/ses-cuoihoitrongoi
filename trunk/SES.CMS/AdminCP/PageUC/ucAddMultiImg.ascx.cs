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
using SES.CMS.DO;
using SES.CMS.BL;

namespace SES.CMS.AdminCP.PageUC
{
    public partial class ucAddMultiImg : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cboAlbum, "AlbumID", "Title", new cmsAlbumBL().SelectAll());
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject(fuImage1, txtTitle1.Text, txtAlt1.Text, rdAlbum1.Checked,fuThumbnail1);
            initObject(fuImage2, txtTitle2.Text, txtAlt2.Text, rdAlbum2.Checked,fuThumbnail2);
            initObject(fuImage3, txtTitle3.Text, txtAlt3.Text, rdAlbum3.Checked,fuThumbnail3);
            initObject(fuImage4, txtTitle4.Text, txtAlt4.Text, rdAlbum4.Checked,fuThumbnail4);
            initObject(fuImage5, txtTitle5.Text, txtAlt5.Text, rdAlbum5.Checked,fuThumbnail5);
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListImage");
        }

        private void initObject(FileUpload fulImage, string title,string Alt,bool style,FileUpload fuThumbnail)
        {
            if (string.IsNullOrEmpty(title)) return;
            cmsImagesDO objArt = new cmsImagesDO();
            objArt.Title = title;
            objArt.Description = Alt;
            objArt.AlbumID = int.Parse(cboAlbum.SelectedValue.ToString());
            string titleAlbum = new cmsAlbumBL().Select(new cmsAlbumDO { AlbumID = objArt.AlbumID }).Title;
            if (!string.IsNullOrEmpty(fulImage.FileName))
                objArt.ImgFile = UploadFile(fulImage, titleAlbum + " - " + title);
            objArt.StyleAlbum = style;
            if(!string.IsNullOrEmpty(fuThumbnail.FileName))
                objArt.Thumbnail = UploadThumbnail(fuThumbnail,objArt.ImgFile);
            new cmsImagesBL().Insert(objArt);
        }
        private string UploadFile(FileUpload fulImages, string title)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(title) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
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
                string FileName = string.Format("{0}{1}", title.Substring(0,title.LastIndexOf(".")) + "-Thumbnail", fuThumbnail.FileName.Substring(fuThumbnail.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fuThumbnail.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}
