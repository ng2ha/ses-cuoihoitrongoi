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

namespace SES.CMS
{
    public partial class RSS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewsRSS rss = new NewsRSS();

            NewsRSS.RssChannel channel = new NewsRSS.RssChannel();

            channel.Title = "Cưới Hỏi Trọn Gói";

            channel.Link = "http://cuoihoitrongoi.com.vn";

            channel.Description = "Cưới hỏi, dịch vụ cưới hỏi, lễ ăn hỏi, lễ cưới, tư vấn cưới, cuoi hoi tron goi, đám cưới, dam cuoi, ăn hỏi, an hoi, cưới hỏi trọn gói, Quang Dũng.";

            rss.AddRssChannel(channel);


            DataTable dtnew = new cmsArticleBL().SelectLastest(20);

            foreach (DataRow dr in dtnew.Rows)
            {

                NewsRSS.RssItem item6 = new NewsRSS.RssItem();

                item6.Title = dr[cmsArticleDO.TITLE_FIELD].ToString();

                item6.Link = "http://" + Request.Url.Host + "/Tin-Cuoi-Hoi-Chi-Tiet/" + dr[cmsArticleDO.ARTICLEID_FIELD].ToString() + "/" + Change_AV(dr[cmsArticleDO.TITLE_FIELD].ToString());

                item6.Description = dr[cmsArticleDO.DESCRIPTION_FIELD].ToString();

                rss.AddRssItem(item6);
            }


            Response.Clear();

            Response.ContentType = "text/xml";

            Response.Write(rss.RssDocument);

            Response.End();

        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }
    }
}
