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

namespace SES.CMS.AdminCP.PageUC
{
    public partial class ucnonCustomer : System.Web.UI.UserControl
    {
        int ma;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadKH();
            }
        }

        private void LoadKH()
        {
            gvUser.DataSource = new cmsThongTinKHBL().SelectNonAll();
            gvUser.DataBind();
        }

        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUser.PageIndex = e.NewPageIndex;
            LoadKH();
        }

        protected void gvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new cmsThongTinKHBL().Delete(new cmsThongTinKHDO { ID = Convert.ToInt32(gvUser.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(gvUser.DataKeys[gvUser.SelectedIndex].Value);
            Ultility.RedirectPage("Default.aspx?Page=Queue&UserID=" + ID.ToString());

        }


        protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            ma = id;
            if(e.CommandName == "create")
            {
                pnAdvance.Visible = true;
                pnedit.Visible = false;
            }
            if (e.CommandName == "editdc")
            {
                pnedit.Visible = true;
                pnAdvance.Visible = false;
            }
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cmsThongTinKHDO khDO = new cmsThongTinKHDO { ID = ma};
                khDO.username = txtUser.Text;
                khDO.pass = txtmk.Text;
                cmsThongTinKHBL cmsBL = new cmsThongTinKHBL();
                if (cmsBL.selectUser(khDO).Rows.Count > 0)
                {
                    Functions.Alert("Da ton tai tai khoan!", "Default.aspx?Page=ListQueue?UserID=" + ma);
                    return;
                }
                else
                {
                    cmsBL.createUser(khDO);
                    Functions.Alert("Tao tai khoan thanh cong!", "Default.aspx?Page=ListQueue?UserID=" + ma);
                }
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvUser_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            cmsThongTinKHDO khDO = new cmsThongTinKHDO();
            khDO.ID = ma;
            khDO.TenRe = txtGroomName.Value;
            khDO.TenDau = txtBrideName.Value;
            khDO.DCDau = txtBrideAddress.Value;
            khDO.DCRe = txtGroomAddress.Value;
            new cmsThongTinKHBL().Update(khDO);
            Functions.Alert("Cap Nhat thành công!", Request.Url.ToString());
        }
    }
}