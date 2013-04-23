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
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = new sysConfigBL().Select(new sysConfigDO { ConfigID = 1 }).ConfigValue;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = new sysConfigBL().Select(new sysConfigDO { ConfigID = 5 }).ConfigValue;
            Page.Header.Controls.Add(meta);

            rptTopSV.DataSource = new cmsCategoryBL().SelectHomepage(4);
            rptTopSV.DataBind();
            rptConsult.DataSource = new cmsArticleBL().SelectFrontpage();
            rptConsult.DataBind();

            sysConfigDO objCf = new sysConfigDO();
            objCf.ConfigID = 2;
            objCf = new sysConfigBL().Select(objCf);
            if (objCf.IsActive) ucPopup1.Visible = true;
            else ucPopup1.Visible = false;

            objCf.ConfigID = 14;
            objCf = new sysConfigBL().Select(objCf);
            lblCuocThiAnh.Text = objCf.ConfigValue;
            if (objCf.IsActive) lblCuocThiAnh.Visible = true;
            else lblCuocThiAnh.Visible = false;

        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 110, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        public string WordCut2(string text)
        {
            return Ultility.WordCut(text, 250, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
        //    Response.Redirect("Search1.aspx?Keyword=" + txtSearch.Text);
        }
    }
}
