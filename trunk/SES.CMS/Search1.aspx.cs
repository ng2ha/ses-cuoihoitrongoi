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
    public partial class Search1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Keyword"]))
            {
                rptSearch.DataSource = new cmsArticleBL().Search(Request.QueryString["Keyword"]);
                rptSearch.DataBind();

                DataTable dt = new cmsArticleBL().Search(Request.QueryString["Keyword"]);
                lblresult.Text = dt.Rows.Count.ToString();
                Page.Title = "Tìm kiếm " + Request.QueryString["Keyword"].ToString() + " - CƯỚI HỎI TRỌN GÓI - CUOIHOITRONGOI.COM.VN";
            }
            if(!IsPostBack)
            txtSearch.Text = Request.QueryString["Keyword"];
        }

        public string ReturnDetailLink(string id, int SearchType)
        {
            int idd = int.Parse(id);
            if (SearchType == 0)
            {
                return "/Tin-Cuoi-Hoi-Chi-Tiet";
            }
            else
            {
                return "/" + SelectPage(idd);
            }
        }
        private string SelectPage(int id)
        {
            cmsCategoryDO obj = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = id });
            int TypeID = obj.CategoryTypeID;
            string s = "";
            if (TypeID == 0)
                s = "Dich-Vu-Cuoi-Hoi";
            else if (TypeID == 1)
                s =  "Dich-Vu-Cuoi-Hoi-Chi-Tiet";
            else if (TypeID == 2)
                s = "Thong-Tin-Cuoi-Hoi";
            else if (TypeID == 3)
                s =  "Tin-Cuoi-Hoi";
            else if (TypeID == 28)
                s = "List-Dich-Vu-Cuoi-Hoi";
            else if (TypeID == 42)
                s = "List-Tin-Cuoi-Hoi";
            return s;
            
        }

        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 210, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search1.aspx?Keyword=" + txtSearch.Text);
        }
    }
}
