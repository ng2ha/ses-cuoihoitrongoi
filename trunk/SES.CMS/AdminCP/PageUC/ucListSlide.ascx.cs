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
    public partial class ucListSlide : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvSlide.DataSource = new SlideBL().SelectAll();
            gvSlide.DataBind();
            Functions.ddlDatabinder(cboCategory, cmsCategoryDO.CATEGORYID_FIELD, cmsCategoryDO.TITLE_FIELD, new cmsCategoryBL().SelectAll());
            cboCategory.Items.Insert(0, "Chọn tất cả -----------");


        }

        protected void gvSlide_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SlideID = int.Parse(gvSlide.DataKeys[gvSlide.SelectedIndex].Value.ToString());
            Response.Redirect("Default.aspx?Page=Slide&SlideID=" + SlideID.ToString());
        }

        protected void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex <= 0)
            {
                gvSlide.DataSource = new SlideBL().SelectAll();
                gvSlide.DataBind();
            }
            else
            {
                Functions.GvDatabinder(gvSlide, new SlideBL().SelectByCategoryID(int.Parse(cboCategory.SelectedValue)));
            }
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=Slide");
        }

        protected void gvSlide_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            new SlideBL().Delete(new SlideDO { SlideID = Convert.ToInt32(gvSlide.DataKeys[e.RowIndex].Value) });
            Functions.Alert("Xóa thành công", "Default.aspx?Page=ListSlide");
        }
    
    }
}