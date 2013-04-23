﻿using System;
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
    public partial class ucListImage : System.Web.UI.UserControl
    {
        public int CurrentPage
        {
            get
            {
                // look for current page in ViewState
                object o = this.ViewState["_CurrentPage"];
                if (o == null)
                    return 0;	// default to showing the first page
                else
                    return (int)o;
            }

            set
            {
                this.ViewState["_CurrentPage"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Functions.ddlDatabinder(cboAlbum, cmsAlbumDO.ALBUMID_FIELD, cmsAlbumDO.TITLE_FIELD, new cmsAlbumBL().SelectAll());
                cboAlbum.Items.Insert(0, "Chọn tất cả -----------");
            }
                BindList();
        }

       

        protected void cboAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPage = 0;
            BindList();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=AddMultiImg");
        }

        
        protected void dlImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ImageID = int.Parse(dlImages.DataKeys[dlImages.SelectedIndex].ToString());
            Response.Redirect("Default.aspx?Page=Images&ImageID=" + ImageID.ToString());
        }

        protected void dlImages_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int PLID = int.Parse(dlImages.DataKeys[e.Item.ItemIndex].ToString());
            new cmsImagesBL().Delete(new cmsImagesDO { ImageID = PLID });

            Functions.Alert("Xóa thành công", "Default.aspx?Page=ListImage");
        }

       private void binddatalist(DataTable dt)
        {
        // use PageDatasource object for paging  purpose..

        PagedDataSource Page = new PagedDataSource();
        try
        {
         
         
         Page.AllowPaging = true;

        //page object store the datasource of datalist..
         Page.DataSource = dt.DefaultView; 
         Page.PageSize = 21;
             
         //"CurrentPage" is global variable that content the current page index..
         Page.CurrentPageIndex = CurrentPage;  

         dlImages.DataSource = Page;
         dlImages.DataBind();
         //now datalist only show the a images... 
         //due to "Page.PageSize = 8;" statement...

        //visible true or false of next and previous button
        //according to last and first page...
         lbNext.Enabled = !Page.IsLastPage;
         lbPrev.Enabled = !Page.IsFirstPage;
        }
            
        catch(Exception ex)
        {
         throw ex;
        }

        }
       
      

       private void BindList()
       {
           if (cboAlbum.SelectedIndex <= 0)
           {
               binddatalist( new cmsImagesBL().SelectAll());
               
           }
           else
           {
               binddatalist(new cmsImagesBL().SelectByAlbumID(int.Parse(cboAlbum.SelectedValue)));
           }
       }

       protected void lbNext_Click1(object sender, EventArgs e)
       {
           CurrentPage += 1;
           //"CurrentPage" is global variable that content the current page index..
           BindList();
       }

       protected void lbPrev_Click1(object sender, EventArgs e)
       {
           CurrentPage -= 1;
           //"CurrentPage" is global variable that content the current page index..
           BindList();
       }
    }
}