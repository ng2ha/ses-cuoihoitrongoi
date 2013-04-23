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
    public partial class ucListProduct : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvProduct.DataSource = new cmsProductBL().SelectAll();
            gvProduct.DataBind();
        }

        protected void gvProduct_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {
            int ProductID = int.Parse(e.EditingKeyValue.ToString());
            Response.Redirect("Default.aspx?Page=Product&ProductID=" + ProductID.ToString());
        }



        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=Product");
        }

        protected void gvProduct_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            int PLID = int.Parse(e.Keys["ProductID"].ToString());
            new cmsProductBL().Delete(new cmsProductDO { ProductID = PLID });
            Functions.Alert("Default.aspx?Page=ListProduct", "Xóa thành công");
        }
    }
}