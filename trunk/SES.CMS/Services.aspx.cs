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
    public partial class Services1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if(!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int id = int.Parse(Request.QueryString["ID"]);
                cmsCategoryDO objCat = new cmsCategoryDO();
                objCat.CategoryID = id;
                objCat = new cmsCategoryBL().Select(objCat);
                lblContentTitle.Text = objCat.Title.ToUpper();
                if (!string.IsNullOrEmpty(objCat.WebTitle))
                    Page.Title = objCat.WebTitle;
                else Page.Title = objCat.Title;
                
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                //meta.Content = "+ Công ty dịch vụ cưới hỏi trọn gói Quang Dũng đã từng phục vụ cho các đám cưới nổi tiếng ở Việt Nam";
                meta.Content = Page.Title;
                Page.Header.Controls.Add(meta);


                lblDescription.Text = objCat.DetailContent;
                imgContent.ImageUrl = "/Media/"+objCat.ImageURL;
                hplLight.NavigateUrl = "/Media/" + objCat.ImageURL;
                hplLight.Attributes.Add("title", objCat.Title);
                //lblScr.Text = "<script type=\"text/javascript\">$(function() { $('#" + divimg.ClientID +" a').lightBox(); });</script>";
                DataTable dtchild = new cmsCategoryBL().SelectByParent(objCat.CategoryID);
                if (dtchild.Rows.Count != 0)
                {
                    divimg.Visible = false;
                    rptServiceL2.DataSource = dtchild;
                    rptServiceL2.DataBind();
                }
                else
                {
                    divimg.Visible = false;
                    DataTable dtchilds = new cmsImagesBL().SelectByCategoryID(objCat.CategoryID);
                    if (dtchilds.Rows.Count != 0)
                    {
                        if(objCat.CategoryID!=76)
                        { 
                        rptServiceL2.Visible = false;
                        rptServiceLs.Visible = true;
                        rptServiceLs.DataSource = dtchilds;
                        rptServiceLs.DataBind();
                        }
                        else
                        {
                            rptServiceL2.Visible = false;
                            rptServiceLs.Visible = false;
                            rptKH.Visible = true;
                            rptKH.DataSource = dtchilds;
                            rptKH.DataBind();
                        }
                    }
                }
                
            }
        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }
        public string SelectPage(string id)
        {
            int ids = int.Parse(id);
            if (ids == 68) return "Tin-Cuoi-Hoi";
            DataTable dt = new cmsCategoryBL().SelectByParent(ids);
            if (dt.Rows.Count > 0)
                return "Dich-Vu-Cuoi-Hoi";
            return "Dich-Vu-Cuoi-Hoi-Chi-Tiet";
        }
        
    }
}
