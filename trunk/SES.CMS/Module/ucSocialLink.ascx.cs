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

namespace SES.CMS.Module
{
    public partial class ucSocialLink : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CurrentUrl = "http://" + Request.Url.Host + Request.RawUrl;
            hplFacebook.NavigateUrl = hplFacebook.NavigateUrl + CurrentUrl;
            hplGoogle.NavigateUrl = hplGoogle.NavigateUrl + CurrentUrl;
            hplTwitter.NavigateUrl = hplTwitter.NavigateUrl + CurrentUrl;
            string faceQD = CurrentUrl;
            abc.Attributes.Add("src", "//www.facebook.com/plugins/like.php?href=" + faceQD + "&send=false&layout=button_count&width=450&show_faces=false&action=like&colorscheme=light&font&height=21&appId=379138395463852");
            
        }
    }
}