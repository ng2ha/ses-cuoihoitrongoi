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
    public partial class ucListYCKichBan : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                gvUser.DataSource = new YeuCauKBBL().SelectAll();

                gvUser.DataBind();
            }
        }

        private void LoadKH()
        {
            if (drp.SelectedValue == "1")
            {
                gvUser.DataSource = new YeuCauKBBL().SelectByAccept(1);
            }
            else if (drp.SelectedValue == "0")
            {
                gvUser.DataSource = new YeuCauKBBL().SelectByAccept(0);
            }
            else if (drp.SelectedValue == "-1") gvUser.DataSource = new YeuCauKBBL().SelectAll();
            gvUser.DataBind();
        }

        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUser.PageIndex = e.NewPageIndex;
            LoadKH();
        }

        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(gvUser.DataKeys[gvUser.SelectedIndex].Value);
            Ultility.RedirectPage("Default.aspx?Page=YCKichBan&YeuCauKBID=" + ID.ToString());
        }

        protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            //ma = id;
            if (e.CommandName == "detailYC")
            {
                Ultility.RedirectPage("Default.aspx?Page=YCKichBan&YeuCauKBID=" + id.ToString());
            }
            if (e.CommandName == "Delete1")
            {
                new YeuCauKBBL().Delete(new YeuCauKBDO { YeuCauKBID = id });
                new KichBanCuoiBL().Delete(new KichBanCuoiBL().SelectByYC(id));
                Ultility.RedirectPage("Default.aspx?Page=ListYCKichBan");
            }
        }

        protected void drp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKH();
        }

       
    }
}