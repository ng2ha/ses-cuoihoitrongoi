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
using System.IO;

namespace SES.CMS.AdminCP.PageUC
{
    public partial class ucUpBG : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string UploadFile(FileUpload fulImages)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = "bg.png";
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                if (File.Exists(SaveLocation))
                {
                    File.Delete(SaveLocation);
                }
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }

        private string UploadFile2(FileUpload fulImages)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = "banner-top.png";
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                if (File.Exists(SaveLocation))
                {
                    File.Delete(SaveLocation);
                }
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }

        protected void btnXacNhan_Click(object sender, EventArgs e)
        {
            UploadFile(fuBG);
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=UpBG");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UploadFile2(FileUpload1);
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=UpBG");
        }
    }
}