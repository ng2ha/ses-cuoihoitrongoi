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

namespace SES.CMS
{
    public partial class PhotoStream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                string s = Convert.ToString(Request.QueryString["ID"]);
                cmsImagesDO obj = new cmsImagesBL().Select(new cmsImagesDO { ImageID = int.Parse(s) });
                Page.Title = obj.Title + "-" + obj.Description;

                string sURL = getPageClick(obj);
                
               
                imgSho.ImageUrl = "/Media/" + obj.ImgFile;


                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                meta.Content = obj.Description;
                Page.Header.Controls.Add(meta);

                imgSho.Attributes.Add("onload", "vertAlign(this)");

                cmsAlbumDO objA = new cmsAlbumDO();
                objA.AlbumID = obj.AlbumID;
                objA = new cmsAlbumBL().Select(objA);
                Label1.Text = obj.Title;
                string CurrentUrl = "http://" + Request.Url.Host + Request.RawUrl;
                fblike.Attributes.Add("data-href", CurrentUrl);
                fbcm.Attributes.Add("data-href", CurrentUrl);
                /*
                
                */
                if (Request.UrlReferrer != null)
                {
                    if (!Request.UrlReferrer.Host.Equals(Request.Url.Host))
                    {
                        Response.Redirect(sURL);
                    }
                }
                else
                {
                    Response.Redirect(sURL);
                }
            }
        }

        private string getPageClick(cmsImagesDO objIMG)
        {
            string sUML = "";
            cmsAlbumDO objA = new cmsAlbumDO();
            objA.AlbumID = objIMG.AlbumID;
            objA = new cmsAlbumBL().Select(objA);

            if (objA.CategoryID > 0) // Trag dich vu
            {
                cmsCategoryDO objCat = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = objA.CategoryID });
                if (objCat.CategoryID == 76) // KHTB
                {
                    sUML = "http://" + Request.Url.Host + "/Services/" + objCat.CategoryID.ToString() + "/" + Change_AV(objCat.Title);
                }
                else
                    sUML = "http://" + Request.Url.Host + "/ServiceDetail/" + objCat.CategoryID.ToString() + "/" + Change_AV(objCat.Title);
            }
            else // Trag album anh
            {
                if (objIMG.StyleAlbum) // anh album
                    sUML = "http://" + Request.Url.Host + "/AlbumDetail/" + objA.AlbumID.ToString() + "-1/" + Change_AV(objA.Title);
                else
                    sUML = "http://" + Request.Url.Host + "/AlbumDetail/" + objA.AlbumID.ToString() + "-0/" + Change_AV(objA.Title);
            }
            return sUML;
        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }
    }
}
