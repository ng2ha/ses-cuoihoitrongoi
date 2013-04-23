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

namespace SES.CMS.AdminCP.PageUC
{
    public partial class ucMailList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(Server.MapPath("/AdminCP/") + "MailList.txt");
            txtMail.Text = text;
        }
    }
}