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
    public partial class ucListImagealt : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) gvIMGDataSource();

        }
        protected void gvIMGDataSource()
        {
            gvAt.DataSource = new cmsImagesBL().SelectAll();
            gvAt.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            cmsImagesDO obj = new cmsImagesDO();
            int stt = gvAt.Rows.Count;
            int[] spid = new int[stt];
            string[] alt = new string[stt];

            for (int i = 0; i < gvAt.Rows.Count; i++)
            {
                TextBox txtRows = (TextBox)gvAt.Rows[i].FindControl("txtAlt");
                txtRows.Visible = true;

                spid[i] = Int32.Parse(gvAt.DataKeys[i].Value.ToString());
                alt[i] = txtRows.Text;
            }
            new cmsImagesBL().UpdateAlt(stt, spid, alt);
            gvIMGDataSource();
        }
        protected void gvAt_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAt.PageIndex = e.NewPageIndex;
            gvIMGDataSource();
        }
    }
}