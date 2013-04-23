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
using SES.CMS.BL;
using SES.CMS.DO;

namespace SES.CMS
{
    public partial class ClientLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Album ảnh của tôi - Cuoihoitrongoi.com.vn";
            if (Request.QueryString["Option"] != null)
                if (Request.QueryString["Option"].ToString() == "Logout")
                    Session.RemoveAll();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string username = txtName.Value.Trim();
            string password = txtPassword.Value.Trim();
            DataTable dtClient = new ClientLoginBL().SelectLogin(username, password);
            if (dtClient.Rows.Count > 0)
            {
                Session["Username"] = dtClient.Rows[0]["Username"].ToString();
                Session["Password"] = dtClient.Rows[0]["Password"].ToString();
                Session["ClientName"] = dtClient.Rows[0]["ClientName"].ToString();
                Session["ClientLoginID"] = dtClient.Rows[0]["ClientLoginID"].ToString();
                Response.Redirect("/AlbumClient.aspx");
            }
            else
            {
                Ultility.Alert("Sai tên đăng nhập", Request.Url.ToString());
            }
        }
    }
}
