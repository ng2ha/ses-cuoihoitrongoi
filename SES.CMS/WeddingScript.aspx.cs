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
    public partial class WeddingScript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Kịch Bản Cưới - CuoiHoiTronGoi.com.vn";
            //if (Request.QueryString["Option"] != null)
            //    if (Request.QueryString["Option"].ToString() == "Logout")
            //        Session.RemoveAll();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string username = txtName.Value.Trim();
            string password = txtPassword.Value.Trim();
            DataTable dtClient = new YeuCauKBBL().SelectLogin(username, password);
            if (dtClient.Rows.Count > 0)
            {
                Session["TenDangNhap"] = dtClient.Rows[0]["TenDangNhap"].ToString();
                Session["YeuCauKBID"] = dtClient.Rows[0]["YeuCauKBID"].ToString();
                Response.Redirect("/ViewScript.aspx");
            }
            else
            {
                Ultility.Alert("Sai tên đăng nhập", Request.Url.ToString());
            }
        }
    }
}
