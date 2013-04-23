using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.CMS.DO;
using SES.CMS.BL;

namespace SES.CMS
{
    public partial class AlbumClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Album ảnh của tôi - Cuoihoitrongoi.com.vn";
            if (Session["ClientLoginID"] == null)
            {
                Response.Redirect("/ClientLogin.aspx");
            }
            else
            {
                lblName.Text = "Album ảnh khách hàng:" + Session["ClientName"].ToString();
                int CLID = int.Parse(Session["ClientLoginID"].ToString());
                ClientLoginDO objCL = new ClientLoginBL().Select(new ClientLoginDO { ClientLoginID = CLID });
                lblDetailInfo.Text = objCL.DetailInfo;
                rptFile.DataSource = Ultility.getFileList(objCL.FTPServer, objCL.Username, objCL.Password);
                rptFile.DataBind();
            }
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            Ultility.Alert("Bạn đã đăng xuất thành công", "/ClientLogin.aspx?Option=Logout");
        }
    }
}
