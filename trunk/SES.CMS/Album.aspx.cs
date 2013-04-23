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
    public partial class Album : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new cmsAlbumBL().SelectAll();
            DataView dv = new DataView(dt, "CategoryID=0", "", DataViewRowState.CurrentRows);
            rptAlbums.DataSource = dv; 
                rptAlbums.DataBind();
                Page.Title = "Album hình ảnh";
                
                rptService.DataSource = new cmsCategoryBL().SelectHomepage(5);
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
