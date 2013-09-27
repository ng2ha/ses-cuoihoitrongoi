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
    public partial class ServiceDetail1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            cmsCategoryDO objCat = new cmsCategoryDO();
            objCat.CategoryID = id;
            objCat = new cmsCategoryBL().Select(objCat);
            if (!string.IsNullOrEmpty(objCat.WebTitle))
            {
                if(objCat.WebTitle.Length<=50){
                    string title = objCat.WebTitle.Replace("-", " ");
                    Page.Title = title;
                }
                else
                Page.Title = objCat.Title;
            }
            else Page.Title = objCat.Title;
            
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            //meta.Content = objCat.MetaKeyword;
            meta.Content = objCat.Description;
            Page.Header.Controls.Add(meta);

            lblContentTitle.Text = objCat.Title.ToUpper();
            lblDescription.Text = objCat.DetailContent;
            if (id == 68)
            { 
               
            }
            DataTable dtchild = new cmsImagesBL().SelectByCategoryID(objCat.CategoryID);
            if (dtchild.Rows.Count != 0)
            {
                rptServiceL2.DataSource = dtchild;
                rptServiceL2.DataBind();
            }
        }
        public string ReturnLink(string id)
        {
            int ids = int.Parse(id);
            cmsImagesDO obj = new cmsImagesBL().Select(new cmsImagesDO { ImageID = ids });
            if (int.Parse(Request.QueryString["ID"]) == 68)
            { 
                return "<a target='_blank' title='" + obj.Title + "' href='/Media/"+ obj.ImgFile + "'>";
                    //<a class="fancyboxx" rel="group1"  Title="<%#(Eval("Title").ToString().ToUpper())%>" href="/Media/<%#Eval("ImgFile") %>">
            }
            //return "<a class='fancybox' " + obj.Title + "' href='/PhotoStream/" + obj.ImageID.ToString() +"/Default.aspx'>";
            return "<a class='fancyboxx' href='/Media/" + obj.ImgFile + "' rel='gallery'>";
        }

       
    }
}
//<asp:HyperLink id="alink" runat="server" CssClass="fancyboxx" rel="group1"  Title="<%#(Eval("Title").ToString().ToUpper())%>" NavigateUrl="/Media/<%#Eval("ImgFile") %>">