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
using SES.CMS.DO;
using SES.CMS.BL;

namespace SES.CMS
{
    public partial class AlbumCover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label0.Text = loadTitle(0);
            Label1.Text = loadTitle(1);
        }

        public string loadTitle(int i)
        {

            int id = int.Parse(Request.QueryString["ID"].ToString());
            cmsAlbumDO obj1 = new cmsAlbumBL().Select(new cmsAlbumDO { AlbumID = id });


            
            lblTitle.Text = obj1.Title;
            Page.Title = obj1.Title;
            lblDescription.Text = obj1.Description;
            //rptAlbums.DataSource = new cmsImagesBL().SelectByAlbumID(id);

            string ima = obj1.AnhAlbum;
            string im = obj1.AnhKieu;
            string s="";
            if (i == 1)
                s = "<div class=\"serviceimgl2-detail-pic\">" + "<a href='/Album-Cuoi-Hoi-Chi-Tiet/" + id + "=" + i + "/" + Change_AV(obj1.Title) + "'>" + "<img width='200px' src='/Media/" + ima + "'/></a> </div> <div class=\"serviceimgl2-detail-titlex\"><h1 class=\"h1style\"><a href='/AlbumDetail/" + id + "-" + i + "/" + Change_AV(obj1.Title) + "'>ẢNH ALBUM</a></h1></div> ";
            else
                s = "<div class=\"serviceimgl2-detail-pic\">" + "<a href='/Album-Cuoi-Hoi-Chi-Tiet/" + id + "=" + i + "/" + Change_AV(obj1.Title) + "'>" + "<img width='200px' src='/Media/" + im + "'/></a> </div> <div class=\"serviceimgl2-detail-titlex\"><h1 class=\"h1style\"><a href='/AlbumDetail/" + id + "-" + i + "/" + Change_AV(obj1.Title) + "'>ẢNH KIỂU</a></h1></div> ";
            return s;
            
        }

        public string Change_AV(string ip_str_change)
        {
            return Ultility.Change_AV(ip_str_change);
        }
    }
}
