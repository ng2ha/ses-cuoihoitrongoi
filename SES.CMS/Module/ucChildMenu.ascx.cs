﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.CMS.DO;
using SES.CMS.BL;
using System.Data;

namespace SES.CMS.Module
{
    public partial class ucChildMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int serviceID = int.Parse(Request.QueryString["ID"]);
                    if (serviceID == 32 || serviceID == 36 || serviceID == 39 || serviceID == 114 || serviceID == 41 || serviceID == 28)
                    {
                        rptServiceL1.Visible = false;
                    }
                    DataTable dt = new cmsCategoryBL().SelectByParent(serviceID);

                    rptServiceL1.DataSource = new DataView(dt, "", "OrderID ASC", DataViewRowState.CurrentRows);
                    rptServiceL1.DataBind();
                }
               
            }
        }
        protected string FriendlyUrl(string strTitle)
        {
            return Ultility.Change_AV(strTitle);
        }

       

        public string GetLinkByType(string id)
        {
            string url = "";
            int Catid = int.Parse(id);
            cmsCategoryDO objCat = new cmsCategoryDO();
            objCat.CategoryID = Catid;
            objCat = new cmsCategoryBL().Select(objCat);
            if (objCat.CategoryTypeID == 2)
                url = "/Thong-Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);
            else if (objCat.CategoryTypeID == 0)
                url = "/Dich-Vu-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);
            else if (objCat.CategoryTypeID == 1)
                url = "/Dich-Vu-Cuoi-Hoi-Chi-Tiet/" + id + "/" + FriendlyUrl(objCat.Title);
            else if (objCat.CategoryTypeID == 3)
                url = "/Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);

            if (objCat.CategoryID == 28)
                url = "/List-Dich-Vu-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);
            if (objCat.CategoryID == 42)
                url = "/List-Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);

            return url;

        }
        public string ReturnTopLink(string id)
        {
            string url = "";
            int Catid = int.Parse(id);
            cmsCategoryDO objCat = new cmsCategoryDO();
            objCat.CategoryID = Catid;
            objCat = new cmsCategoryBL().Select(objCat);

            if (objCat.CategoryTypeID == 2)
                url =  "<a href='/Thong-Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title) + "'>" + objCat.Title + "</a>";
            else if (objCat.CategoryTypeID == 0)
                url =  "<a href='/Dich-Vu-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title) + "'>" + objCat.Title + "</a>";
            else if (objCat.CategoryTypeID == 1)
                url =  "<a href='/Dich-Vu-Cuoi-Hoi-Chi-Tiet/" + id + "/" + FriendlyUrl(objCat.Title) + "'>" + objCat.Title + "</a>";
            else if (objCat.CategoryTypeID == 3)
                url = "<a  href='/Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title) + "'>" + objCat.Title + "</a>";
            return url;
        }
    }
}