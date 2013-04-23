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
    public partial class Content1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int id = int.Parse(Request.QueryString["ID"]);
                cmsCategoryDO objCat = new cmsCategoryDO();
                objCat.CategoryID = id;
                objCat = new cmsCategoryBL().Select(objCat);
                Page.Title = objCat.WebTitle;

                lblContentTitle.Text = objCat.Title.ToUpper();
                lblDescription.Text = objCat.DetailContent;
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                meta.Content = Page.Title + "+ Công ty dịch vụ cưới hỏi trọn gói Quang Dũng đã từng phục vụ cho các đám cưới nổi tiếng ở Việt Nam";
                Page.Header.Controls.Add(meta);
                imgContent.ImageUrl = "/Media/" + objCat.ImageURL;
            }
        }
    }
}
