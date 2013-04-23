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
using System.IO;

namespace SES.CMS.Module
{
    public partial class ucConnectUs : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string faceQD = "https://www.facebook.com/CuoiHoiTronGoi.QuangDung";
            abc.Attributes.Add("src", "//www.facebook.com/plugins/like.php?href=" + faceQD + "&send=false&layout=button_count&width=450&show_faces=false&action=like&colorscheme=light&font&height=21&appId=379138395463852");
            //onclick="this.value='';" onblur="clickSearch(this)"
            txtMailinglist.Attributes.Add("onclick", "clickSearch(this)");
            txtMailinglist.Attributes.Add("onblur", "clickSearch(this)");
        }

        protected void btnMaillist_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(Server.MapPath("/AdminCP/") + "MailList.txt", true))
            {
                file.WriteLine(txtMailinglist.Text.Trim() + ",");
            }
            txtMailinglist.Text = String.Empty;
            Ultility.Alert("Cảm ơn bạn đã quan tâm đến dịch vụ của chúng tôi!");
        }
    }
}