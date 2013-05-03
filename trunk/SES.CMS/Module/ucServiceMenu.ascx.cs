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

namespace SES.CMS.Module
{
    public partial class ucServiceMenu : System.Web.UI.UserControl
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new cmsCategoryBL().SelectByParent(28);
            //DataRow dr = dt.NewRow();
            //dr["CategoryID"] = 76;
            //dr["Title"] = "Khách hàng tiêu biểu";
            //dr["OrderID"] = 0;
            //dt.Rows.Add(dr);
            rptServiceL1.DataSource = new DataView(dt,"","OrderID ASC",DataViewRowState.CurrentRows);
            rptServiceL1.DataBind();

            //ucThongKe();
            
        }
        //protected void ucThongKe()
        //{
        //    cmsCounterBL counterBL = new cmsCounterBL();
        //    lblHomNayd.Text = counterBL.VisitorInCurrentDay().ToString();
        //    lblHomQuad.Text = counterBL.VisitorInTomorow().ToString();
        //    lblTatCad.Text = counterBL.GetAll().Count.ToString();
        //    lblTuanNayd.Text = counterBL.VisitorInCurrentWeek().ToString();
        //    lblTuanTruocd.Text = counterBL.VisitorInBeforeWeek().ToString();
        //    lblThangNayd.Text = counterBL.VisitorInCurrentMonth().ToString();
        //    lblThangTruocd.Text = counterBL.VisitorInBeforeMonth().ToString();
        //}
        protected void rptServiceL1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;

            if ((item.ItemType == ListItemType.Item) ||
                (item.ItemType == ListItemType.AlternatingItem))
            {
                DataRowView row = e.Item.DataItem as DataRowView;
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int id = int.Parse(Request.QueryString["ID"]);
                    int ids = int.Parse(row["CategoryID"].ToString());
                    string urls = Request.Url.AbsolutePath;
                    urls = urls.Substring(1, urls.Length - 1);
                    ///Content/1/Gioi-Thieu.html
                    string Modules = urls.Substring(0, urls.IndexOf("/"));


                    if (Modules.Equals("Dich-Vu-Cuoi-Hoi"))
                    {
                        if (ids == id)
                        {
                            Repeater childRepeater = (Repeater)item.FindControl("rptServiceL2");
                            childRepeater.DataSource = new cmsCategoryBL().SelectByParent(id);
                            childRepeater.DataBind();
                        }
                    }
                    if (Modules.Equals("Dich-Vu-Cuoi-Hoi-Chi-Tiet"))
                    {
                        cmsCategoryDO obj = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = id });
                        if (obj.ParentID == ids)
                        {
                            Repeater childRepeater = (Repeater)item.FindControl("rptServiceL2");
                            childRepeater.DataSource = new cmsCategoryBL().SelectByParent(ids);
                            childRepeater.DataBind();
                        }
                    }
                }
                
            }
        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }
        public string ReturnDetailLink(string id)
        {

            //<a href="/Dich-Vu-Cuoi-Hoi-Chi-Tiet/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>"><%#Eval("Title") %></a>
            int idd = int.Parse(id);
            cmsCategoryDO obj = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = idd });
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                int ids = int.Parse(Request.QueryString["ID"]);
                if(ids==idd)
                    return "<a class='leftmenu-item-text-l2-b' href='/" + SelectPage(obj.CategoryID) + "/" + obj.CategoryID + "/" + Change_AV(obj.Title) + "'>" + obj.Title + "</a>";
            }
            return "<a href='/" + SelectPage(obj.CategoryID) + "/" + obj.CategoryID + "/" + Change_AV(obj.Title) + "'>" + obj.Title + "</a>";
            
        }
        private string SelectPage(int id)
        {
            DataTable dt = new cmsCategoryBL().SelectByParent(id);
            if (dt.Rows.Count > 0)
                return "Dich-Vu-Cuoi-Hoi";
            return "Dich-Vu-Cuoi-Hoi-Chi-Tiet";
        }
        public string ReturnTopLink(string id)
        {
            string url = Request.Url.AbsolutePath;
            url = url.Substring(1, url.Length - 1);
            ///Content/1/Gioi-Thieu.html
            string Module = "";
            if (url.Contains("/"))
                Module = url.Substring(0, url.IndexOf("/"));

            //<a href="/Dich-Vu-Cuoi-Hoi-Chi-Tiet/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>"><%#Eval("Title") %></a>
            int idd = int.Parse(id);
            cmsCategoryDO obj = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = idd });
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int ids = int.Parse(Request.QueryString["ID"]);
                if (Module.Equals("ServiceDetail"))
                {
                    
                    cmsCategoryDO objx = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = ids });
                    if (objx.ParentID == idd)
                        return "<a class='leftmenu-item-text-l2-b' href='/Dich-Vu-Cuoi-Hoi/" + obj.CategoryID + "/" + Change_AV(obj.Title) + "'>" + obj.Title + "</a>";
                }
                if (Module.Equals("Services"))
                {
                    if (ids == idd)
                        return "<a class='leftmenu-item-text-l2-a' href='/Dich-Vu-Cuoi-Hoi/" + obj.CategoryID + "/" + Change_AV(obj.Title) + "'>" + obj.Title + "</a>";
                }
            }
            return "<a href='/Dich-Vu-Cuoi-Hoi/" + obj.CategoryID + "/" + Change_AV(obj.Title) + "'>" + obj.Title + "</a>";

        }

        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Search1.aspx?Keyword=" + txtSearch.Text);
        }


        
    }
}