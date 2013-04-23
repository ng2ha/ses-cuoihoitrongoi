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

namespace SES.CMS
{
    public partial class ListNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 42;
            this.Page.Title = "Tin tức";
             if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                id = int.Parse(Request.QueryString["ID"]);
           
           
            }
             HtmlMeta meta = new HtmlMeta();
             meta.Name = "description";
             //meta.Content = "Hệ thống tin tức, sự kiện, tư vấn mùa cưới - cuoihoitrongoi.com.vn";
             meta.Content = Page.Title + "+ Công ty dịch vụ cưới hỏi trọn gói Quang Dũng đã từng phục vụ cho các đám cưới nổi tiếng ở Việt Nam";
             Page.Header.Controls.Add(meta);

             rptAlbums.DataSource = new DataView(new cmsCategoryBL().SelectByParent(id), "IsPublish<>0", "", DataViewRowState.CurrentRows);
             rptAlbums.DataBind();

             rptService.DataSource = new cmsCategoryBL().SelectHomepage(100);
             rptService.DataBind();
        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 140, new char[] { ' ', '.', ',', ';' }) + "...";
        }
    }
}
