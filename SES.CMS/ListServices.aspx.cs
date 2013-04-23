using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.CMS.BL;
using SES.CMS.DO;

namespace SES.CMS
{
    public partial class ListServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.Title = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = 28 }).WebTitle;

            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            //meta.Content = "+ Công ty dịch vụ cưới hỏi trọn gói Quang Dũng đã từng phục vụ cho các đám cưới nổi tiếng ở Việt Nam";
            meta.Content = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = 28 }).MetaKeyword;
            Page.Header.Controls.Add(meta);


            ltSv.Text = new cmsCategoryBL().Select(new cmsCategoryDO { CategoryID = 28 }).DetailContent;
            rptServiceL2.DataSource = new DataView(new cmsCategoryBL().SelectByParent(28),"IsPublish<>0","",DataViewRowState.CurrentRows);
            rptServiceL2.DataBind();
        }
        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }

    }
}
