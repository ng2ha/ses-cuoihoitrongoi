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

namespace SES.CMS.Module
{
    public partial class ucBreadcrumb : System.Web.UI.UserControl
    {
        cmsCategoryDO objCat = new cmsCategoryDO();
        cmsArticleDO objArt = new cmsArticleDO();
        cmsCategoryBL catBL = new cmsCategoryBL();
        cmsAlbumDO albumDO = new cmsAlbumDO();
        cmsAlbumBL albumBL = new cmsAlbumBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.Url.AbsolutePath;
            url = url.Substring(1, url.Length - 1);
            string url1 = url.Replace(".", "/");
            string Module = url1.Substring(0, url1.IndexOf("/"));
            if (Module == "Album-Cuoi-Hoi")
                lblTitle.Text = "";
            else if (Module == "List-Tin-Cuoi-Hoi")
            {
                lblTitle.Text = "";
            }
            else if (Module == "Tin-Cuoi-Hoi")
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    objCat.CategoryID = catBL.GetParentID(int.Parse(Request.QueryString["ID"]));
                    DataTable dt = catBL.SelectOne(objCat);

                    lblTitle.Text = " » <a href='/List-Tin-Cuoi-Hoi/" + dt.Rows[0]["CategoryID"].ToString() + "/" + FriendlyUrl(dt.Rows[0]["Title"].ToString()) + "'>" + dt.Rows[0]["Title"].ToString() + "</a>";
                }
            }
            else if (Module == "Tin-Cuoi-Hoi-Chi-Tiet")
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                    {
                    int CategoryID = catBL.GetCategoryIDByArtID(int.Parse(Request.QueryString["ID"]));
                    int ParentId = catBL.GetParentID(CategoryID);

                    int Parent = 0;
                    if (ParentId > 0)
                    {
                        Parent = catBL.GetParentID(ParentId);
                        if (Parent == 0)
                        {
                            Parent = ParentId;
                        }
                    }

                    objCat.CategoryID = CategoryID;
                    DataTable dtCat = catBL.SelectOne(objCat);

                    objCat.CategoryID = Parent;
                    DataTable dtParent = catBL.SelectOne(objCat);


                    lblTitle.Text = " » <a href='/List-Tin-Cuoi-Hoi/" + dtParent.Rows[0]["CategoryID"].ToString() + "/" + FriendlyUrl(dtParent.Rows[0]["Title"].ToString()) + "'>" + dtParent.Rows[0]["Title"].ToString() + "</a>";
                    lblTitle.Text += " » <a href='/Tin-Cuoi-Hoi/" + dtCat.Rows[0]["CategoryID"] + "/" + FriendlyUrl(dtCat.Rows[0]["Title"].ToString()) + "'>" + dtCat.Rows[0]["Title"].ToString() + "</a>";
                    }
            }
            else if (Module == "Anh-Bia-Album-Cuoi-Hoi")
            {
                lblTitle.Text = " » <a href='/Album-Cuoi-Hoi.aspx'> Album </a>";
            }
            else if (Module == "Album-Cuoi-Hoi-Chi-Tiet")
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    string s = Convert.ToString(Request.QueryString["ID"]);
                    albumDO.AlbumID = int.Parse(s.Substring(0, s.IndexOf("-")));

                    albumDO = albumBL.Select(albumDO);
                    lblTitle.Text = " » <a href='/Album-Cuoi-Hoi.aspx'> Album </a>" + " » <a href='/Anh-Bia-Album-Cuoi-Hoi/" + albumDO.AlbumID + "/" + FriendlyUrl(albumDO.Title.ToString()) + "'>" + albumDO.Title + "</a>";
                }
            }
            else if (Module == "Dich-Vu-Cuoi-Hoi")
            {
                int CategoryID = int.Parse(Request.QueryString["ID"]);
                if (CategoryID == 1)
                {
                    lblTitle.Text = GetBreadcrumb(CategoryID);
                }
                else
                    lblTitle.Text = " » <a href='/Dich-Vu-Cuoi-Hoi/28/Dich-vu.aspx'> Cưới Hỏi Trọn Gói </a>" + GetBreadcrumb(CategoryID);
            }
            else if (Module == "Dich-Vu-Cuoi-Hoi-Chi-Tiet") 
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int CategoryID = int.Parse(Request.QueryString["ID"]);
                    if (CategoryID == 1)
                    {
                        lblTitle.Text = GetBreadcrumb(CategoryID);
                    }
                }
            }
            else if (Module == "Lien-He-Dich-Vu-Cuoi-Hoi")
            {
                //lblTitle.Text = " » <a href='ContacUs.aspx'> Liên hệ </a>";
                lblTitle.Text = " » ";
            }
            else if (Module == "Kich-Ban-Cuoi-Hoi")
            {
                lblTitle.Text = " » ";
                //lblTitle.Text = " » <a href='WeddingRequest.aspx'> Kịch bản cưới hỏi </a>";
            }
            else if (Module == "List-Dich-Vu-Cuoi-Hoi")
            {
                lblTitle.Text = " » ";
                //lblTitle.Text = " » <a href='ListServices.aspx'> Hệ thống dịch vụ </a>";
            }
            else if (Module == "Thong-Tin-Cuoi-Hoi")
            {
                lblTitle.Text = " » ";
                //lblTitle.Text = " » <a href='/Content/53/Bao-gia.aspx'> Báo giá </a>";
            }
        }

        protected string GetBreadcrumb(int CategoryID)
        {
            DataTable dtParentID = catBL.SelectParentID(CategoryID);

            string[] a = new string[dtParentID.Rows.Count];

            string sBreadcrumb = "";

            for (int i = 0; i < dtParentID.Rows.Count - 1; i++)
            {
                objCat.CategoryID =int.Parse(dtParentID.Rows[i]["ParentID"].ToString());

                DataTable dtParent = catBL.SelectOne(objCat);
                if (objCat.CategoryID != 28)
                    a[i] = " » <a href='/Dich-Vu-Cuoi-Hoi/" + dtParentID.Rows[i]["ParentID"] + "/" + FriendlyUrl(dtParent.Rows[0]["Title"].ToString()) + "'>" + dtParent.Rows[0]["Title"].ToString() + "</a>";              
            }

            for (int i = a.Length - 1; i >= 0; i--)
            {
                sBreadcrumb += a[i];
            }

            return sBreadcrumb;

        }

        protected string FriendlyUrl(string strTitle)
        {
            return Ultility.Change_AV(strTitle);
        }

        protected int GetParentID(int CategoryID)
        {
            if (CategoryID == 0)
                return CategoryID;
            else 
                return catBL.GetParentID(CategoryID);
        }
    }
}