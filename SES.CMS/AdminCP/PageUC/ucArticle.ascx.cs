﻿using System;
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
    public partial class ucArticle : System.Web.UI.UserControl
    {
        cmsArticleDO objArt = new cmsArticleDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.DevCboDatabinder(cboCategory, new cmsCategoryBL().SelectAll(), cmsCategoryDO.TITLE_FIELD, cmsCategoryDO.CATEGORYID_FIELD);
            if (Request.QueryString["ArticleID"] != null)
            {
                objArt.ArticleID = int.Parse(Request.QueryString["ArticleID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            hplImage.Visible = true;
            objArt = new cmsArticleBL().Select(objArt);
            txtTitle.Text = objArt.Title;
            txtDescription.Text = objArt.Description;
            txtArticleDetail.Text = objArt.ArticleDetail;
            chkIsHomePage.Checked = objArt.IsHompage;
            chkIsPublish.Checked = !objArt.IsPublish;
            txtOrderID.Text = objArt.OrderID.ToString();
            cboCategory.Value = objArt.CategoryID.ToString();
            hplImage.NavigateUrl = "~/Media/" + objArt.ImageUrl;
            chkVote.Checked = objArt.AllowVote;
            chkComment.Checked = objArt.AllowComment;
         
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objArt.ArticleID <= 0)
            {
                objArt.CreateDate = DateTime.Now;
                objArt.UserCreate = int.Parse(Session["UserID"].ToString());
                new cmsArticleBL().Insert(objArt);
            }
            else
            {
                new cmsArticleBL().Update(objArt);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListArticle");
        }
        private void initObject()
        {
            objArt.Title = txtTitle.Text;
            objArt.Description = txtDescription.Text;
            objArt.ArticleDetail = txtArticleDetail.Text;
            objArt.IsHompage = chkIsHomePage.Checked;
            objArt.IsPublish = !chkIsPublish.Checked;
            objArt.OrderID = int.Parse(txtOrderID.Text);
            objArt.CategoryID = int.Parse(cboCategory.Value.ToString());
            objArt.AllowVote = chkVote.Checked;
            objArt.AllowComment = chkComment.Checked;
         
            if(!string.IsNullOrEmpty(fuImage.FileName))
                objArt.ImageUrl = UploadFile(fuImage);
        }

        private string UploadFile(FileUpload fulImage)
        {
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}