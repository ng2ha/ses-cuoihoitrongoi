using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    public partial class ucCustomer : System.Web.UI.UserControl
    {
        int ma = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LoadKH();

            }
        }

        private void LoadKH()
        {
            gvUser.DataSource = new cmsThongTinKHBL().SelectAll();
            gvUser.DataBind();
        }

        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUser.PageIndex = e.NewPageIndex;
            LoadKH();
        }

        //protected void gvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    try
        //    {
        //        new cmsThongTinKHBL().Delete(new cmsThongTinKHDO { ID = Convert.ToInt32(gvUser.DataKeys[e.RowIndex].Value) });
        //        Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
        //    }
        //    catch
        //    {
        //        Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
        //    }
        //}

        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(gvUser.DataKeys[gvUser.SelectedIndex].Value);
            Ultility.RedirectPage("Default.aspx?Page=Queue&UserID=" + ID.ToString());
        }

        protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            
            if (e.CommandName == "create")
            {
                if((new cmsChuanBiBL().selectFK(new cmsChuanBiDO {IDFK = id })).Rows.Count == 0)
                    new cmsChuanBiBL().Insert(new cmsChuanBiDO { IDFK = id });
                
                //Functions.Alert("Có lỗi xảy ra! '"+ id +"'", Request.Url.ToString());
                Ultility.RedirectPage("Default.aspx?Page=Queue&UserID=" + id.ToString());
            }
            if (e.CommandName == "editc")
            {
                pnAD.Visible = true;
                cmsThongTinKHDO dt = new cmsThongTinKHBL().Select(new cmsThongTinKHDO { ID = id });
                ma = id;
                txtGroomName.Value = dt.TenRe;
                txtGroomAddress.Value = dt.DCRe;
                txtBrideName.Value = dt.TenDau;
                txtBrideAddress.Value = dt.DCDau;
                txtUser.Value = dt.username;
                txtPw.Value = dt.pass;
            }
            if (e.CommandName == "delete")
            {
                try
                {
                    new cmsThongTinKHBL().Delete(new cmsThongTinKHDO { ID = id });
                    Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
                }
                catch
                {
                    Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
                }
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            cmsThongTinKHDO khDO = new cmsThongTinKHDO();
            khDO.ID = ma;
            khDO.TenRe = txtGroomName.Value;
            khDO.TenDau = txtBrideName.Value;
            khDO.DCDau = txtBrideAddress.Value;
            khDO.DCRe = txtGroomAddress.Value;
            cmsThongTinKHBL cmsBL = new cmsThongTinKHBL();
            if (cmsBL.selectUser(khDO).Rows.Count > 0)
            {
                Functions.Alert("Ten dang nhap da ton tai!", Request.Url.ToString());
                return;
            }
            else
            {
                cmsBL.Update(khDO);
                Functions.Alert("Cap Nhat thành công!", Request.Url.ToString());
            }
        }

        //protected void gvUser_RowEditing(object sender, GridViewEditEventArgs e)
        //{

        //}
    }
}