using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.CMS.BL;
using System.Data;
using SES.CMS.DO;

namespace SES.CMS.Module
{
    public partial class ucAlbumDaThucHien : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dtchilds = new cmsImagesBL().SelectByCategoryID(76);
                rptKH.DataSource = dtchilds;
                rptKH.DataBind();
            }
        }
    }
}