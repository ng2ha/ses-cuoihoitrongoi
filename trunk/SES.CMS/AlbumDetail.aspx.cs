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
    public partial class AlbumDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                string s = Convert.ToString(Request.QueryString["ID"]);
                int id = int.Parse(s.Substring(0, s.IndexOf("=")));
                int style = Convert.ToInt32(s.Substring(s.IndexOf("=") + 1));
                if (style == 1) Label1.Text = "ẢNH ALBUM:";
                else Label1.Text = "ẢNH KIỂU:";

                cmsAlbumDO obja = new cmsAlbumDO();
                obja.AlbumID = id;
                obja = new cmsAlbumBL().Select(obja);
                lblTitle.Text = obja.Title.ToUpper();
                Page.Title = obja.Title;
                lblDescription.Text = obja.Description;
                //rptAlbums.DataSource = new cmsImagesBL().SelectByAlbumID(id);
                rptAlbums.DataSource = new cmsImagesBL().SelectAlbumbyStyle(id, style);
                rptAlbums.DataBind();
            }
        }
    }
}
