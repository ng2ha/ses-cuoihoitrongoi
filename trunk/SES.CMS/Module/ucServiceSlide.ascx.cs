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

namespace SES.CMS.Module
{
    public partial class ucServiceSlide : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          ltrSlogan.Text = new sysConfigBL().Select(new sysConfigDO() { ConfigID = 16}).ConfigValue;
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int ID = 0;
                string url = Request.Url.AbsolutePath;
                url = url.Substring(1, url.Length - 1);
                string Module = url.Substring(0, url.IndexOf("/"));
                if (Module.Equals("Album-Cuoi-Hoi-Chi-Tiet"))
                {
                    string s = Convert.ToString(Request.QueryString["ID"]);
                    ID = int.Parse(s.Substring(0, s.IndexOf("=")));
                    //int style = Convert.ToInt32(s.Substring(s.IndexOf("-") + 1));
                }
                else
                    ID = int.Parse(Request.QueryString["ID"]);
                
                ///Content/1/Gioi-Thieu.html
                
                DataTable dtHome = new DataView(new SlideBL().SelectByCategoryID(0), "", "OrderID ASC", DataViewRowState.CurrentRows).ToTable();
                DataTable dtService = new DataView(new SlideBL().SelectByCategoryID(ID), "", "OrderID ASC", DataViewRowState.CurrentRows).ToTable();
                DataTable dtAlbum = new DataView(new SlideBL().SelectByCategoryID(-2), "", "OrderID ASC", DataViewRowState.CurrentRows).ToTable();


                if (Module.Equals("Tin-Cuoi-Hoi-Chi-Tiet") || Module.Equals("Tin-Cuoi-Hoi"))
                {
                    rptSlide.DataSource = dtHome;
                    if (dtHome.Rows.Count == 1) addHeaderOne();
                    else addHeaderAll();
                        
                }
                else if (Module.Equals("Album-Cuoi-Hoi-Chi-Tiet") || Module.Equals("Album-Cuoi-Hoi"))
                {
                    
                    rptSlide.DataSource = dtAlbum;
                    if (dtAlbum.Rows.Count == 1) addHeaderOne();
                    else addHeaderAll();
                }
                else
                {
                    DataTable dt = new SlideBL().SelectByCategoryID(ID);
                    if (dt.Rows.Count > 0)
                        {
                        rptSlide.DataSource = dtService;
                        if (dtService.Rows.Count == 1) addHeaderOne();
                        else addHeaderAll();

                        }
                    else
                        {
                        rptSlide.DataSource = rptSlide.DataSource = dtHome;
                        if (dtHome.Rows.Count == 1) addHeaderOne();
                        else addHeaderAll();
                        }
                }
            }
            else if (Request.Url.ToString().Contains("Album.aspx") || Request.Url.ToString().Contains("Album-Cuoi-Hoi.aspx"))
            {
             DataTable dtAlbum = new DataView(new SlideBL().SelectByCategoryID(-2), "", "OrderID ASC", DataViewRowState.CurrentRows).ToTable();
                    rptSlide.DataSource = dtAlbum;
                    if (dtAlbum.Rows.Count == 1) addHeaderOne();
                    else addHeaderAll();
            } 
            else
                {
               DataTable tx = new DataView(new SlideBL().SelectByCategoryID(0), "", "OrderID ASC", DataViewRowState.CurrentRows).ToTable();
               rptSlide.DataSource = tx;
               if (tx.Rows.Count == 1) addHeaderOne();
               else addHeaderAll();


                }
            rptSlide.DataBind();
        }

        private void addHeaderOne()
        {
            HtmlHead head = Page.Header;

            LiteralControl lctl = new LiteralControl("<script type=\"text/javascript\" src=\"/js/previewOne.js\"></script>");

            head.Controls.Add(lctl);
        }

        private void addHeaderAll()
        {
            HtmlHead head = Page.Header;

            LiteralControl lctl = new LiteralControl("<script type=\"text/javascript\" src=\"/js/preview.js\"></script>");

            head.Controls.Add(lctl);
        }
    }
}