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
using System.Web.Caching;
using System.Text;
using System.Drawing;

namespace SES.CMS
{
    public partial class NewsDetail : System.Web.UI.Page
    {
        cmsArticleDO objCat = new cmsArticleDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int id = int.Parse(Request.QueryString["ID"]);
               
                objCat.ArticleID = id;
                objCat = new cmsArticleBL().Select(objCat);

                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                //meta.Content = new cmsCategoryBL().Select(new cmsCategoryDO{CategoryID = objCat.CategoryID}).MetaKeyword;
                meta.Content = "Công ty dịch vụ cưới hỏi trọn gói Quang Dũng đã từng phục vụ cho các đám cưới nổi tiếng ở Việt Nam";
                Page.Header.Controls.Add(meta);


                DataTable dta = new cmsArticleBL().SelectOne(objCat);
                Page.Title = objCat.Title;
                cmsCategoryDO objc = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = objCat.CategoryID });
                lblTitle.Text = objc.Title;
                if (objCat.AllowVote||objCat.AllowComment)
                    {
                        votesystem.Visible = true;
                    }
                if (objCat.AllowComment)
                    {
                    articlecomment.Visible = true;
                    othercomment.Visible = true;
                    }
                if (objCat.AllowVote) votecontrol.Visible = true;

                if (objCat.AllowVote&&objCat.AllowComment) lblBLDG.Text = "BÌNH LUẬN & ĐÁNH GIÁ";
                else if(objCat.AllowVote) lblBLDG.Text = "ĐÁNH GIÁ";
                else if (objCat.AllowComment) lblBLDG.Text = "BÌNH LUẬN";

                if (!objCat.AllowVote) voteresultlink.Visible = false;


                hplTop.NavigateUrl = "/Tin-Cuoi-Hoi/" + objc.CategoryID.ToString() + "/" + Change_AV(objc.Title);
                rptListNews.DataSource = dta;
                rptListNews.DataBind();

                rptService.DataSource = new cmsCategoryBL().SelectHomepage(100);
                rptService.DataBind();
                rptOther.DataSource = new DataView(new cmsArticleBL().SelectByCatNum(objc.CategoryID, 10), "ArticleID<>" + objCat.ArticleID.ToString(), "", DataViewRowState.CurrentRows);
                rptOther.DataBind();

                rptComment.DataSource = new DataView(new ArticleCommentBL().SelectByArticle(id),"IsAccept<>0","CommentID DESC",DataViewRowState.CurrentRows);
                rptComment.DataBind();


                

            }
        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }

        public string GetStar(string id)
        {
            int CommentIDs = int.Parse(id);
            ArticleCommentDO objCM = new ArticleCommentDO { CommentID = CommentIDs };
            objCM = new ArticleCommentBL().Select(objCM);
            if (objCM.ArticleStar > 0)
            {
                string img="";
                for (int i = 1; i <= objCM.ArticleStar; i++ )
                {
                    img += "<img src='/images/star.png' style='float:left'/>";
                }
                return img;
            }
            return string.Empty;
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 140, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        static string idcheck = "";
        public static string getCaptchaImage(int height, int width)
        {
            MSCaptcha.CaptchaImage image = new MSCaptcha.CaptchaImage
            {
                Height = height,
                Width = width,
                BackColor = Color.FromArgb(120,0,0),
                FontColor = Color.White,
            };
            idcheck = image.Text;
            HttpRuntime.Cache.Add(
               image.UniqueId,
               image,
               null,
                // adiciona 20 segundos
               DateTime.Now.AddSeconds(20),
               Cache.NoSlidingExpiration,
               CacheItemPriority.NotRemovable,
               null);

            StringBuilder stringBuilder = new StringBuilder(256);
            stringBuilder.Append("<input type=\"hidden\" name=\"captcha-guid\" value=\"");
            stringBuilder.Append(image.UniqueId);
            stringBuilder.Append("\" />");
            stringBuilder.AppendLine();
            stringBuilder.Append("<img src=\"");
            stringBuilder.Append("/CaptchaImage.axd?guid=" + image.UniqueId);
            stringBuilder.Append("\" alt=\"CAPTCHA\" width=\"");
            stringBuilder.Append(width);
            stringBuilder.Append("\" height=\"");
            stringBuilder.Append(height);
            stringBuilder.Append("\" />");

            return stringBuilder.ToString();
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Value.ToUpper().Equals(idcheck.ToUpper()))
            {
                ArticleCommentDO objCM = new ArticleCommentDO();
                objCM.ArticleID = objCat.ArticleID;
                objCM.CommentDetail = txtOther.Value;
                objCM.UserEmail = txtEmail.Value;
                objCM.IsAccept = false;
                int star = 0;
                if (rdo1.Checked) star = 1;
                else if (rdo2.Checked) star = 2;
                else if (rdo3.Checked) star = 3;
                else if (rdo4.Checked) star = 4;
                else if (rdo5.Checked) star = 5;


                objCM.ArticleStar = star;
                new ArticleCommentBL().Insert(objCM);
                string url = Request.Url.AbsolutePath;
                url = url.Substring(1, url.Length - 1);
                Ultility.Alert("Gửi đánh giá thành công", "/"+url);
            }
            else
            {
                Ultility.Alert("Bạn nhập không đúng mã bảo mật.");
                return;
            }
        }
    }
}
