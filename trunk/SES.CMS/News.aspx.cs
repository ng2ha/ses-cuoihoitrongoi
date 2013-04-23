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
    public partial class News : System.Web.UI.Page
    {
        cmsCategoryDO objCat = new cmsCategoryDO();
        protected void Page_Load(object sender, EventArgs e)
        {
             if(!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int id = int.Parse(Request.QueryString["ID"]);
                
                objCat.CategoryID = id;
                objCat = new cmsCategoryBL().Select(objCat);

                Page.Title = objCat.Title;

                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                //meta.Content = objCat.MetaKeyword;
                meta.Content = Page.Title + "+ Công ty dịch vụ cưới hỏi trọn gói Quang Dũng đã từng phục vụ cho các đám cưới nổi tiếng ở Việt Nam";
                Page.Header.Controls.Add(meta);

                hplTitle.NavigateUrl = "/News/" + objCat.CategoryID.ToString() + "/" + Change_AV(objCat.Title);
                lblTitle.Text = objCat.Title;
                loadNews();
                rptService.DataSource = new cmsCategoryBL().SelectHomepage(100);
                rptService.DataBind();
            }
        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 140, new char[] { ' ', '.', ',', ';' })+"...";
        }

        public int CurrentPage
        {
            get
            {
                // look for current page in ViewState
                object o = this.ViewState["_CurrentPage"];
                if (o == null)
                    return 0;	// default to showing the first page
                else
                    return (int)o;
            }

            set
            {
                this.ViewState["_CurrentPage"] = value;
            }
        }
        private void bindatalist(DataTable dt)
        {
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dt.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 15;
            objPds.CurrentPageIndex = CurrentPage;
            cmdPrev.Visible = !objPds.IsFirstPage;
            cmdNext.Visible = !objPds.IsLastPage;
            rptListNews.DataSource = objPds;
            rptListNews.DataBind();
        }

        protected void cmdPrev_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage -= 1;

            // Reload control
            loadNews();
        }

        private void loadNews()
        {
            DataView dv = new DataView(new cmsArticleBL().SelectByCategoryID(objCat.CategoryID), "IsPublish<>0", "ArticleID DESC", DataViewRowState.CurrentRows);
            bindatalist(dv.ToTable());
        }

        protected void cmdNext_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage += 1;
            loadNews();
        }

    }
}
