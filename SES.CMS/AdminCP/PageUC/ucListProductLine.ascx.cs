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
    public partial class ucListProductLine : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvProductLine.DataSource = new cmsProductLineBL().SelectAll();
            gvProductLine.DataBind();


           
        }

        protected void gvProductLine_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {
            int ProductLineID = int.Parse(e.EditingKeyValue.ToString());
            Response.Redirect("Default.aspx?Page=ProductLine&ProductLineID=" + ProductLineID.ToString());
        }

        

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=ProductLine");
        }

        protected void gvProductLine_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            int PLID = int.Parse(e.Keys["ProductLineID"].ToString());
            new cmsProductLineBL().Delete(new cmsProductLineDO { ProductLineID = PLID });
            Functions.Alert("Default.aspx?Page=ListProductLine", "Xóa thành công");
        }
    }
}