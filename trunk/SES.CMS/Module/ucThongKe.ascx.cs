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


namespace SES.CMS.Module
{
    public partial class ucThongKe : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmsCounterBL counterBL = new cmsCounterBL();
            pnAll.Visible = true;
            pnOne.Visible = false;
            lblHomNayd.Text = counterBL.VisitorInCurrentDay().ToString();
            lblHomQuad.Text = counterBL.VisitorInTomorow().ToString();
            lblTatCad.Text = counterBL.GetAll().Count.ToString();
            lblTuanNayd.Text = counterBL.VisitorInCurrentWeek().ToString();
            lblTuanTruocd.Text = counterBL.VisitorInBeforeWeek().ToString();
            lblThangNayd.Text = counterBL.VisitorInCurrentMonth().ToString();
            lblThangTruocd.Text = counterBL.VisitorInBeforeMonth().ToString();
            //Literal1.Visible = true;

        }
    }
}