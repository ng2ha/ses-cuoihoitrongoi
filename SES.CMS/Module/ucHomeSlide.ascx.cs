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
using System.IO;

namespace SES.CMS.Module
{
    public partial class ucHomeSlide : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int ID = int.Parse(Request.QueryString["ID"]);
                    string url = Request.Url.AbsolutePath;
                    url = url.Substring(1,url.Length-1);
                    ///Content/1/Gioi-Thieu.html
                    string Module = url.Substring(0, url.IndexOf("/"));
                    DataView dtHome = new DataView(new SlideBL().SelectByCategoryID(0), "", "OrderID ASC", DataViewRowState.CurrentRows);
                    DataView dtService = new DataView(new SlideBL().SelectByCategoryID(ID), "", "OrderID ASC", DataViewRowState.CurrentRows);

                    if (Module.Equals("ListServices") || Module.Equals("Services") || Module.Equals("Content") || Module.Equals("ServiceDetail") || Module.Equals("News") || Module.Equals("ListNews"))
                    {
                        DataTable dt = new SlideBL().SelectByCategoryID(ID);
                        if (dt.Rows.Count > 0)
                            rptSlide.DataSource = dtService;
                        else rptSlide.DataSource = rptSlide.DataSource = dtHome; 
                    }
                    else
                    {
                        rptSlide.DataSource = dtHome; 
                    }
                }
            else rptSlide.DataSource = new DataView(new SlideBL().SelectByCategoryID(0), "", "OrderID ASC", DataViewRowState.CurrentRows);
            rptSlide.DataBind();
        }
    }
}