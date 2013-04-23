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
    public partial class ucBannerLeftRight : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sysConfigDO objleft = new sysConfigDO();
            objleft.ConfigID = 6;
            objleft = new sysConfigBL().Select(objleft);

            sysConfigDO objright = new sysConfigDO();
            objright.ConfigID = 7;
            objright = new sysConfigBL().Select(objright);

            if (objleft.IsActive && objright.IsActive)
                this.Visible = true;
            else this.Visible = false;

            hplLeft.NavigateUrl = objleft.ConfigValue;
            hplRight.NavigateUrl = objright.ConfigValue;
        }
    }
}