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
    public partial class ucSupportOnline : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sysConfigDO objCf = new sysConfigDO();
            objCf.ConfigID = 3;
            objCf = new sysConfigBL().Select(objCf);
            lblScr.Text = objCf.ConfigValue;
        }
    }
}