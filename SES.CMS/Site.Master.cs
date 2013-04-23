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
using System.Web.UI.MobileControls;
using System.Collections.Generic;

namespace SES.CMS
{
    public partial class Site : System.Web.UI.MasterPage
    {
        List<Category> lstCt = new List<Category>();
        string s = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"]==null)
                Session["UID"] = "StartMyCounter";
          

            foreach (DataRow dr in new cmsCategoryBL().SelectAll().Rows)
            {
                Category objcat = new Category();
                objcat.CategoryID = int.Parse(dr["CategoryID"].ToString());
                objcat.Title = dr["Title"].ToString();
                objcat.ParentID = int.Parse(dr["ParentID"].ToString());
                if(Convert.ToBoolean(dr["IsPublish"]))
                    lstCt.Add(objcat);
            }

            BuildChildMenus(ConvertCategoryListToTree(lstCt), s);
            lblCat.Text = s;
            
            sysConfigDO objCf = new sysConfigDO();
            objCf.ConfigID = 3;
            objCf = new sysConfigBL().Select(objCf);
            lblScr.Text = objCf.ConfigValue;
            objCf = null;
            objCf = new sysConfigDO { ConfigID = 8 };
            objCf = new sysConfigBL().Select(objCf);
            lbThongTin.Text = objCf.ConfigValue;
            lblFT1.Text = new sysConfigBL().Select(new sysConfigDO { ConfigID = 9 }).ConfigValue;
            lblFT2.Text = new sysConfigBL().Select(new sysConfigDO { ConfigID = 10 }).ConfigValue;
            lblFT3.Text = new sysConfigBL().Select(new sysConfigDO { ConfigID = 11 }).ConfigValue;
            lblFT1Title.Text = new sysConfigBL().Select(new sysConfigDO { ConfigID = 9 }).ConfigName;
            lblFT2Title.Text = new sysConfigBL().Select(new sysConfigDO { ConfigID = 10 }).ConfigName;
            lblFT3Title.Text = new sysConfigBL().Select(new sysConfigDO { ConfigID = 11 }).ConfigName;
            lblCompanyName.Text = new sysConfigBL().Select(new sysConfigDO { ConfigID = 13 }).ConfigName;
           
        }

        
        public string GetLinkByType(string id)
        {
            string url = "";
            int Catid = int.Parse(id);
            cmsCategoryDO objCat = new cmsCategoryDO();
            objCat.CategoryID = Catid;
            objCat = new cmsCategoryBL().Select(objCat);
            if (objCat.CategoryTypeID==2)
                url = "/Thong-Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);
            else if (objCat.CategoryTypeID == 0)
                url = "/Dich-Vu-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);
            else if (objCat.CategoryTypeID == 1)
                url = "/Dich-Vu-Cuoi-Hoi-Chi-Tiet/" + id + "/" + FriendlyUrl(objCat.Title);
            else if (objCat.CategoryTypeID == 3)
                url = "/Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);
            
            if(objCat.CategoryID==28)
                url = "/List-Dich-Vu-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);
            if (objCat.CategoryID == 42)
                url = "/List-Tin-Cuoi-Hoi/" + id + "/" + FriendlyUrl(objCat.Title);

            return url;

        }
        private List<Category> ConvertCategoryListToTree(List<Category> flatList)
        {
            List<Category> rootNodes = new List<Category>();
            foreach (Category node in flatList)
            {
                //The parent of this node in the flat list (if there is one).
                Category parent = flatList.Find(i => i.CategoryID == node.ParentID);
                if (parent == null)
                {
                    //Collect the root nodes to return later...
                    rootNodes.Add(node);
                }
                else
                {
                    //Ignore orphans (should never happen, but just in case)...
                    if (!flatList.Exists(i => i.CategoryID == node.CategoryID))
                        continue;

                    //add this node to the child list of its parent.
                    if (parent.ChildCategory == null)
                        parent.ChildCategory = new List<Category>();
                    parent.ChildCategory.Add(node);
                }
            }
            return rootNodes;
        }

        private void BuildChildMenus(List<Category> Categorys, string sub)
        {
            foreach (Category childCategory in Categorys)
            {
                string rwurl = GetLinkByType(childCategory.CategoryID.ToString());
                s = s + "<li><a href='" + rwurl + "'><span>" + childCategory.Title + "</span></a>";
                if (childCategory.ChildCategory.Count == 0)
                {
                    s = s + "</li>";
                    continue;
                }
                else
                {
                    s = s + "<ul>";
         //           BuildChildMenus(childCategory.ChildCategory, sub);
                    s = s + "</ul></li>";

                }

            }
        }

        protected string FriendlyUrl(string strTitle)
        {
            return Ultility.Change_AV(strTitle);
        }
    }
    public partial class Category
    {
        public Int32 CategoryID;
        public String Title;
        public String Description;
        public Int32 OrderID;
        public Boolean IsPublish;
        public Boolean IsHompage;
        public Int32 UserCreate;
        public DateTime CreateDate;
        public Int32 CategoryTypeID;
        public Int32 ParentID;
        public Boolean IsContent;
        public List<Category> ChildCategory = new List<Category>();
    }

}
