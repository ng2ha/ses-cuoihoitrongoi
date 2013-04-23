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
    public partial class ucPopup : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sysConfigDO objCf = new sysConfigDO();
            objCf.ConfigID = 2;
            objCf = new sysConfigBL().Select(objCf);

            string scr = "<script type=\"text/javascript\">";
            scr = scr + "var popup_area1 = \"\";";
            scr = scr + "popup_area1 += '<div id=\"backgroundPopup1\" sylte=\"display:none;\">&nbsp;</div>';";
            scr = scr + "popup_area1 += '<div id=\"popupContact1\" style=\"height:432px;width:800px;display:none;\">';";
            scr = scr + "popup_area1 += ' <div id=\"popupContent1\">';";
            scr = scr + "popup_area1 += '<div id=\"popupInner1\"><a href=\""+ objCf.ConfigValue +"\"><img src=\"/Media/popupCHTG.jpg\" border=\"0\"></a></div>';";
            scr = scr + "popup_area1 += '<a id=\"popupContactClose1\" href=\"\">&nbsp;</a></div></div>';";
            scr = scr + "document.write(popup_area1);</script>";

            lblScr.Text = scr;
        }
    }
}