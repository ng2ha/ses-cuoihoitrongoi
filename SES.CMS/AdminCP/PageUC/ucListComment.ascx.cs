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

namespace SES.CMS.AdminCP.PageUC
{
    public partial class ucListComment : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            LoadComment();

            Functions.ddlDatabinder(cboArticle, cmsArticleDO.ARTICLEID_FIELD, cmsArticleDO.TITLE_FIELD, new DataView(new cmsArticleBL().SelectAll(),"AllowComment=1 OR AllowVote=1","",DataViewRowState.CurrentRows));
            cboArticle.Items.Insert(0, "Chọn tất cả -----------");
        }
        private void LoadComment()
        {
            gvComment.DataSource = new ArticleCommentBL().SelectAll();
            gvComment.DataBind();
        }
        protected void gvComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CommentIDs = Convert.ToInt32(gvComment.DataKeys[gvComment.SelectedIndex].Value);
            ArticleCommentDO objCM = new ArticleCommentDO { CommentID = CommentIDs };
            objCM = new ArticleCommentBL().Select(objCM);
            objCM.IsAccept = true;
            new ArticleCommentBL().Update(objCM);
            Response.Redirect(Request.Url.ToString());
        }
        protected void cboArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArticle.SelectedIndex <= 0)
            {
                gvComment.DataSource = new ArticleCommentBL().SelectAll();
                gvComment.DataBind();
            }
            else
            {
                Functions.GvDatabinder(gvComment, new ArticleCommentBL().SelectByArticle(int.Parse(cboArticle.SelectedValue)));
            }
        }

        protected void gvComment_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new ArticleCommentBL().Delete(new ArticleCommentDO { CommentID = Convert.ToInt32(gvComment.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvComment_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvComment.PageIndex = e.NewPageIndex;
            LoadComment();
        }
        public string getlink(string id)
        {
            int CommentIDs = int.Parse(id);
            ArticleCommentDO objCM = new ArticleCommentDO { CommentID = CommentIDs };
            objCM = new ArticleCommentBL().Select(objCM);
            return "<a href=\"javascript:alert('" + objCM.CommentDetail + "')\">Xem ý kiến</a>";
        }
    }
}