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
    public partial class ucPollResult : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int id = int.Parse(Request.QueryString["ID"]);
                DataTable dt = new ArticleCommentBL().SelectByArticle(id);
                DataTable dt5 = new DataView(dt, "IsAccept<>0 AND ArticleStar=5", "", DataViewRowState.CurrentRows).ToTable();
                DataTable dt4 = new DataView(dt, "IsAccept<>0 AND ArticleStar=4", "", DataViewRowState.CurrentRows).ToTable();
                DataTable dt3 = new DataView(dt, "IsAccept<>0 AND ArticleStar=3", "", DataViewRowState.CurrentRows).ToTable();
                DataTable dt2 = new DataView(dt, "IsAccept<>0 AND ArticleStar=2", "", DataViewRowState.CurrentRows).ToTable();
                DataTable dt1 = new DataView(dt, "IsAccept<>0 AND ArticleStar=1", "", DataViewRowState.CurrentRows).ToTable();
                
                
                int star5 = dt5.Rows.Count;
                int star4 = dt4.Rows.Count;
                int star3 = dt3.Rows.Count;
                int star2 = dt2.Rows.Count;
                int star1 = dt1.Rows.Count;
                int allstar = star1 + star2 + star3 + star4 + star5;
                double pstar5 = (double)star5 / (double)allstar;
                double pstar4 = (double)star4 / (double)allstar;
                double pstar3 = (double)star3 / (double)allstar;
                double pstar2 = (double)star2 / (double)allstar;
                double pstar1 = (double)star1 / (double)allstar;

                if (pstar1 <= 0) pstar1 = 0.0133;
                if (pstar2 <= 0) pstar2 = 0.0133;
                if (pstar3 <= 0) pstar3 = 0.0133;
                if (pstar4 <= 0) pstar4 = 0.0133;
                if (pstar5 <= 0) pstar5 = 0.0133;

                imgFive.Width = Unit.Percentage(pstar5 * 75);
                imgFour.Width = Unit.Percentage(pstar4 * 75);
                imgThree.Width = Unit.Percentage(pstar3 * 75);
                imgTwo.Width = Unit.Percentage(pstar2 * 75);
                imgOne.Width = Unit.Percentage(pstar1 * 75);

                Label1.Text = " " + star1 + " Phiếu";
                Label2.Text = " " + star2 + " Phiếu";
                Label3.Text = " " + star3 + " Phiếu";
                Label4.Text = " " + star4 + " Phiếu";
                Label5.Text = " " + star5 + " Phiếu";

            }
        }
    }
}