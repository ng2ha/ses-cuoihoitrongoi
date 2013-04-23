using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.CMS.BL;
using SES.CMS.DO;
using System.Net.Mail;
using DevExpress.Web.ASPxTreeList;
using System.Collections;
using System.Diagnostics;

namespace SES.CMS
{
    public partial class WeddingRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Liên hệ tư vấn & xây dựng kịch bản cưới";
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Text", typeof(string));
            string scriptCheck = "<script type='text/javascript'> function toggle() { if(document.getElementById('"+ rdoAll.ClientID +"').checked) { document.getElementById('divtrongoi').style.display = 'block'; document.getElementById('divluachon').style.display = 'none'; } else if(document.getElementById('"+ rdoSome.ClientID +"').checked) 	{	document.getElementById('divtrongoi').style.display = 'none'; document.getElementById('divluachon').style.display = 'block'; }} </script>";
            rdoSome.Attributes.Add("onclick", "toggle();");
            rdoAll.Attributes.Add("onclick", "toggle();");
            Label2.Text = scriptCheck;
            if (!IsPostBack)
            {
                
                for (int i = 1; i <= 24; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = i;
                    dr["Text"] = i + "h";
                    dt.Rows.Add(dr);
                }

                Ultility.ddlDatabinder(ddlHAnhoi, "ID", "Text", dt);
                Ultility.ddlDatabinder(ddlHDamNgo, "ID", "Text", dt);
                Ultility.ddlDatabinder(ddlHDondau, "ID", "Text", dt);
                Ultility.ddlDatabinder(ddlHTieccuoi, "ID", "Text", dt);

                DataTable dtp = new DataTable();
                dtp.Columns.Add("ID", typeof(int));
                dtp.Columns.Add("Text", typeof(string));


                for (int i = 0; i <= 59; i++)
                {
                    DataRow dr = dtp.NewRow();
                    dr["ID"] = i;
                    dr["Text"] = i + " phút";
                    dtp.Rows.Add(dr);
                }

                Ultility.ddlDatabinder(ddlPAnhoi, "ID", "Text", dtp);
                Ultility.ddlDatabinder(ddlPDamNgo, "ID", "Text", dtp);
                Ultility.ddlDatabinder(ddlPDondau, "ID", "Text", dtp);
                Ultility.ddlDatabinder(ddlPTieccuoi, "ID", "Text", dtp);
               
            }
            
            
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            //tlCategory.DataSource = new cmsCategoryBL().SelectAllByParent(28);
            //tlCategory.DataBind();
            //tlCategory.ExpandAll();
        }

        public string FindLink(string id)
        {
            int ids = int.Parse(id);
            //DataTable dtx = new cmsCategoryBL().SelectOne(ids);
            string url = "";
            //if (dtx.Rows[0]["Type"].ToString().Equals("Cat"))
            //{
                cmsCategoryDO objCat = new cmsCategoryDO();
                objCat.CategoryID = int.Parse(id);
                objCat = new cmsCategoryBL().Select(objCat);
                if (objCat.CategoryTypeID == 0)
                    url = "/Services/" + id + "/" + FriendlyUrl(objCat.Title);
                else if (objCat.CategoryTypeID == 1)
                    url = "/ServiceDetail/" + id + "/" + FriendlyUrl(objCat.Title);
                string fullurl = "<a target='_blank' href='" + url + "'>" + objCat.Title + "</a>";
                return fullurl;
            //}
            //else
            //{

            //    cmsImagesDO img = new cmsImagesBL().Select(new cmsImagesDO { ImageID = ids });
            //    string imgfile = "/Media/" + img.ImgFile;
            //    string fulllink = "<a class='fancyboxx' title='" + img.Title + "' href='" + imgfile + "'>" + img.Title + "</a>";
            //    return fulllink;   
            //}
        }
        protected string FriendlyUrl(string strTitle)
        {
            return Ultility.Change_AV(strTitle);
        }
        public string SendMail(string Name, string subject, string body, string to, bool isHtml, bool isSSL)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    string TitleKB = getTitle();
                    mail.From = new MailAddress(txtGroommail.Value, TitleKB);
                    mail.ReplyTo = new MailAddress(txtGroommail.Value, txtGroomName.Value);
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = isHtml;
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = isSSL;
                    client.Credentials = new System.Net.NetworkCredential("cuoihoitrongoimailsystem@gmail.com", "@@123vnn");
                    client.Send(mail);


                    mail.From = new MailAddress(new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, getTitle());
                    mail.ReplyTo = new MailAddress(new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, getTitle());
                    mail.To.Add(txtGroommail.Value);
                    mail.To.Add(txtBrideMail.Value);
                    mail.Subject = subject;
                    mail.Body = "Gửi mail thành công, cảm ơn bạn đã liên hệ! Chúng tôi sẽ trả lời các ý kiến của bạn sớm nhất.<br/>Công ty TNHH Nghệ Thuật Quang Dũng";
                    mail.IsBodyHtml = isHtml;
                    client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = isSSL;
                    client.Credentials = new System.Net.NetworkCredential("cuoihoitrongoimailsystem@gmail.com", "@@123vnn");
                    client.Send(mail);
                }

            }
            catch (SmtpException ex)
            {
                return " Lỗi gửi email " + ex.Message;
            }
            return "Gửi mail thành công, cảm ơn bạn đã liên hệ! Chúng tôi sẽ trả lời các ý kiến của bạn sớm nhất.";
        }

        private string getTitle()
        {
            string TitleKB = "Kịch bản Cưới hỏi:" + txtGroomName.Value + "-" + txtBrideName.Value;
        return TitleKB;
        }
        string svYC = "";
        public YeuCauKBDO init_obj()
        {
            //try
            {
                YeuCauKBDO obj = new YeuCauKBDO();
                obj.TenChuRe = txtGroomName.Value;
                obj.TenCoDau = txtBrideName.Value;
                obj.DiaChiNhaTrai = txtGroomAddress.Value;
                obj.DiaChiNhaGai = txtBrideAddress.Value;
                obj.SoDTChuRe = txtGroomTel.Value;
                obj.SoDTCoDau = txtBrideTel.Value;
                obj.MailChuRe = txtGroommail.Value;
                obj.MailCoDau = txtBrideMail.Value;
                obj.DiemTiecNT = txtGroomHall.Value;
                obj.DiemTiecNG = txtBrideHall.Value;
                obj.NgayDamNgo = txtDamngo.Text;
                obj.GioDamNgo = ddlHDamNgo.Text;
                obj.PhutDamNgo = ddlPDamNgo.Text;
                obj.NgayAnHoi = txtAnhoi.Text;
                obj.GioAnHoi = ddlHAnhoi.Text;
                obj.PhutAnHoi = ddlPAnhoi.Text;
                obj.NgayDonDau = txtDondau.Text;
                obj.GioDonDau = ddlHDondau.Text;
                obj.PhuDonDau = ddlPDondau.Text;
                obj.NgayTiecCuoi = txtTieccuoi.Text;
                obj.GioTiecCuoi = ddlHTieccuoi.Text;
                obj.PhutTiecCuoi = ddlPTieccuoi.Text;
                obj.YeuCauKhac = txtOther.Value;
                obj.TronGoi = rdoAll.Checked;
                if(rdoAll.Checked)
                    {
                int s = 0;
                if (rdoGoi1.Checked) s = 1;
                else if (rdoGoi2.Checked) s = 2;
                else if (rdoLucBao.Checked) s = 5;
                else if (rdoNgocBich.Checked) s = 6;
                else if (rdoHoangYen.Checked) s = 7;
                else if (rdoGoi3.Checked) s = 3;
                else s = 4;
                obj.SoDichVuTronGoi = s;
                    }
                svYC += "=================<br/><b>Dịch vụ Lễ ăn hỏi</b><br/> Lễ dạm ngõ:";
                if (rdLang.Checked)
                    obj.AHLoaiDamNgo = "Lẵng";
                else obj.AHLoaiDamNgo = "Tráp";
                svYC += obj.AHLoaiDamNgo + "<br/>";
                if (chkChupDN.Checked)
                    {
                        svYC += "Chụp ảnh Ngoài trời/Dã ngoại: Có<br/>";
                    obj.AHChupNgoaiTroi = "Chụp Dã ngoại";
                    }
                
                obj.AHTrapLeAnHoi = txt11.Text;
                svYC += "<b>Tráp lễ ăn hỏi</b>:" + obj.AHTrapLeAnHoi + "<br/>";
                if (anHD.Checked) obj.AHQuayPhim = "Full HD";
                else obj.AHQuayPhim = "Thường";
                svYC += "<b>Quay phim lễ ăn hỏi</b>:" + obj.AHQuayPhim + "<br/>";
                if (rdAlbum.Checked) obj.AHChupAnh = "Album";
                else obj.AHChupAnh = "Chụp Kiểu";
                svYC += "<b>Chụp ảnh Lễ ăn hỏi</b>:" + obj.AHChupAnh + "<br/>";
                obj.AHXe16Cho = txt2.Text;
                svYC += "<b>Xe 16 chỗ</b>:" + obj.AHXe16Cho + "<br/>";
                obj.AHXe29Cho = txt3.Text;
                svYC += "<b>Xe 29 chỗ</b>:" + obj.AHXe29Cho + "<br/>";
                obj.AHNamBeTrap = txt12.Text;
                svYC += "<b>Đội Nam bê tráp</b>:" + obj.AHNamBeTrap + "<br/>";
                obj.AHNuDoTrap = txt13.Text;
                svYC += "<b>Đội Nữ đỡ tráp</b>:" + obj.AHNuDoTrap + "<br/>";
                obj.AHPhongNhaGai = txt4.Text;
                svYC += "<b>Phông nhà Gái</b>:" + obj.AHPhongNhaGai + "<br/>";
                obj.AHBanGhe = txt6.Text;
                svYC += "<b>Bàn ghế</b>:" + obj.AHBanGhe + "<br/>";
                obj.AHNhaBat = txt7.Text;
                svYC += "<b>Nhà bạt</b>:" + obj.AHNhaBat + "<br/>";
                obj.AHPhaoGiay = txtPhaoGiay.Text;
                svYC += "<b>Pháo Giấy</b>:" + obj.AHPhaoGiay + "<br/>";
                obj.AHChuHy = txtChuHy.Text;
                svYC += "<b>Chữ hỷ</b>:" + obj.AHChuHy + "<br/>";
                if(chkAHCT.Checked) obj.AHHoaAnHoi = "Hoa trang trí Cầu thang.";
                if (chkAHTK.Checked) obj.AHHoaAnHoi = obj.AHHoaAnHoi + "<br/>Hoa bàn Tiếp khách";
                if (chkAHCH.Checked) obj.AHHoaAnHoi = obj.AHHoaAnHoi + "<br/>Cổng hoa";
                if (chkAHHKG.Checked) obj.AHHoaAnHoi = obj.AHHoaAnHoi + "<br/>Hoa Trang trí Nội thất Không gian";
                if (chkHPhong.Checked) obj.AHHoaAnHoi = obj.AHHoaAnHoi + "<br/>Hoa Trang trí Phông";
                svYC += "<b>Hoa ăn hỏi</b>:" + obj.AHHoaAnHoi + "<br/>";
                svYC += "<br/><br/><b>Dịch vụ ngày cưới</b><br/>";

                if (ckxindau.Checked)
                    {
                    obj.NCLeXinDau = true;
                    svYC += "<b>Lễ xin dâu:</b>: Có<br/>";
                    }
                else svYC += "<b>Lễ xin dâu:</b>: Không<br/>";

                if (rddcHD.Checked) obj.NCQuayPhim = "Full HD"; 
                else obj.NCQuayPhim = "Thường";
                svYC += "<b>Quay phim:</b>: " + obj.NCQuayPhim  + "<br/>";


                if (rddcAl.Checked) obj.NCChupAnh = "Album";
                else obj.NCChupAnh = "Chụp Kiểu";
                svYC += "<b>Quay phim:</b>: " + obj.NCChupAnh + "<br/>";

                obj.NCXe4Cho = txt14.Text;
                svYC += "<b>Xe 4 chỗ:</b>: " + obj.NCXe4Cho + "<br/>";

                obj.NCXe16Cho = txt15.Text;
                svYC += "<b>Xe 16 chỗ:</b>: " + obj.NCXe16Cho + "<br/>";

                obj.NCXe29Cho = txt16.Text;
                svYC += "<b>Xe 29 chỗ:</b>: " + obj.NCXe29Cho + "<br/>";

                obj.NCPhongDamCuoi = txt17.Text;

                svYC += "<b>Phông đám cưới :</b>: " + obj.NCPhongDamCuoi + "<br/>";


                obj.NCBanGhe = txt19.Text;

                svYC += "<b>Bàn ghế :</b>: " + obj.NCBanGhe + "<br/>";

                


                obj.NCNhaBat = txt20.Text;
                svYC += "<b>Nhà bạt :</b>: " + obj.NCNhaBat + "<br/>";

                obj.NCPhao = txt22.Text;
                svYC += "<b>Pháo giấy :</b>: " + obj.NCPhao + "<br/>";

                obj.NCChuHy = txt23.Text;

                svYC += "<b>Pháo giấy :</b>: " + obj.NCChuHy + "<br/>";

                //<asp:CheckBox ID="chkHX" Text="Hoa tay & hoa Xe" runat="server" /><br />
                //<asp:CheckBox ID="chkCT" Text="Hoa Trang trí cầu thang" runat="server" /><br />
                //<asp:CheckBox ID="chkTK" Text="Hoa bàn tiếp khách" runat="server" /><br />
                //<asp:CheckBox ID="chkCHC" Text="Cổng hoa" runat="server" />
                //<asp:CheckBox ID="chkHP" Text="Hoa phòng cô dâu chú rể" runat="server" /><br />
                //<asp:CheckBox ID="chkHKG" Text="Hoa Trang trí Không gian" runat="server" /><br />
                //<asp:CheckBox ID="CheckBox6" Text="Hoa Trang trí Phông" runat="server" /><br />

                obj.NCHoaCuoi = "Hoa Cưới tại nhà:";
                if (chkHX.Checked) obj.NCHoaCuoi = "<br/>Hoa tay, Hoa xe.";
                if (chkCT.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa Trang trí cầu thang";
                if (chkTK.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa bàn Tiếp khách";
                if (chkHP.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa Phòng Cô dâu-Chú Rể";
                if (chkCHC.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Cổng hoa";
                if (chkHKG.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa Trang trí Không gian";
                if (CheckBox6.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa Trang trí Phông";

                obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa cưới tại Điểm tiệc:";
                if (CheckBox1.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Cổng Hoa";
                if (CheckBox4.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa Bánh cưới";
                if (CheckBox3.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa sân khấu";
                if (CheckBox2.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa Trang trí đường dẫn";
                if (CheckBox5.Checked) obj.NCHoaCuoi = obj.NCHoaCuoi + "<br/>Hoa Trang trí tháp ly";
                /*
                 <asp:CheckBox ID="CheckBox1" Text="Cổng Hoa" runat="server" /><br />
                 <asp:CheckBox ID="CheckBox4" Text="Hoa Bánh cưới" runat="server" /><br />
                 <asp:CheckBox ID="CheckBox3" Text="Hoa sân khấu" runat="server" />
                 *  <asp:CheckBox ID="CheckBox2" Text="Hoa Trang trí đường dẫn" runat="server" /><br />
                    <asp:CheckBox ID="CheckBox5" Text="Hoa Trang trí tháp ly" runat="server" /><br />
                 *    
                 */
                svYC += "<b>Hoa cưới :</b>:</br> " + obj.NCHoaCuoi + "<br/><br/><br/>++++++++++++++++++++++++++++++";

                return obj;
            }
            //catch (Exception ee)
            //{
            //    lbl.Text = "Loi Khoi Tao doi tuong" + ee.ToString();
            //    return;
            //}
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            
            ccJoin.ValidateCaptcha(txtCaptcha.Value);
            if (!ccJoin.UserValidated)
            {
                Ultility.Alert("Bạn nhập không đúng mã bảo mật.");
                return;
            }
            else
            {
                string body = "";
                body = body + "<br/><b>-----------Thông tin nhà trai-----------</b>";
                body = body + "<br/>Họ tên chú rể: " + txtGroomName.Value;
                body = body + "<br/>Địa chỉ nhà trai: " + txtGroomAddress.Value;
                body = body + "<br/>Địa điểm tổ chức nhà trai: " + txtGroomHall.Value;
                body = body + "<br/>Email chú rể: " + txtGroommail.Value;
                body = body + "<br/>Số điện thoại liên hệ chú rể: " + txtGroomTel.Value;

                body = body + "<br/><b>-----------Thông tin nhà gái-----------</b>";
                body = body + "<br/>Họ tên cô dâu: " + txtBrideName.Value;
                body = body + "<br/>Địa chỉ nhà gái: " + txtBrideAddress.Value;
                body = body + "<br/>Địa điểm tổ chức nhà gái: " + txtBrideHall.Value;
                body = body + "<br/>Email cô dâu: " + txtBrideMail.Value;
                body = body + "<br/>Số điện thoại liên hệ cô dâu: " + txtBrideMail.Value;


                body = body + "<br/><b>-----------Thông tin khác-----------</b>";
                body = body + "<br/>Ngày giờ tổ chức lễ dạm ngõ: " + String.Format("{0:dd/MM/yyyy}", txtDamngo.Date) + "-" + ddlHDamNgo.Text + " giờ - " + ddlPDamNgo.Text + " phút";
                body = body + "<br/>Ngày giờ tổ chức lễ ăn hỏi: " + String.Format("{0:dd/MM/yyyy}", txtAnhoi.Date) + "-" + ddlHAnhoi.Text + " giờ - " + ddlPAnhoi.Text + " phút";
                body = body + "<br/>Ngày giờ tổ chức đón dâu: " + String.Format("{0:dd/MM/yyyy}", txtDondau.Date) + "-" + ddlHDondau.Text + " giờ - " + ddlPDondau.Text + " phút";
                body = body + "<br/>Ngày giờ tổ chức Tiệc cưới: " + String.Format("{0:dd/MM/yyyy}", txtTieccuoi.Date) + "-" + ddlHTieccuoi.Text + " giờ - " + ddlPTieccuoi.Text + " phút";

                body = body + "<br/>Các yêu cầu đặc biệt về ngày Cưới & Hỏi:<br/>====================<br/> " + txtOther.Value;
                body = body + "<br/><br/><b>Lựa chọn dịch vụ: </b>";
                string bodyYC = "";
                if (rdoAll.Checked)
                {
                    string s = "";
                    if (rdoGoi1.Checked) s = "Gói 1 - Kim Cương";
                    else if (rdoGoi2.Checked) s = "Gói 2 - Ruby";
                    else if (rdoGoi3.Checked) s = "Gói 3 - Sapphire";
                    else if (rdoGoi4.Checked) s = "Gói 4 - Ngọc trai";
                    else if (rdoNgocBich.Checked) s = "Gói 6 - Ngọc Bích";
                    else if (rdoLucBao.Checked) s = "Gói 5 - Lục bảo";
                    else s = "Gói 7 - Hoàng Yến";
                    
                    body = body + "<br/><b>---Dịch vụ trọn gói: " + s;
                }
                else
                {
                    body = body + "<br/><b>---Dịch vụ theo yêu cầu</b>:<br/><br/> ";
                    
                    //ICollection selectedNodes = tlCategory.GetAllNodes() as ICollection;
                    //foreach (TreeListNode nodeselect in selectedNodes)
                    //{
                    //    if(nodeselect.Selected) 
                    //        body = body + "<br/>----------->" + nodeselect["Title"].ToString();
                        
                    //}
                }
                try
                {
                    YeuCauKBDO objs = new YeuCauKBDO();
                    objs.YeuCauKBID = new YeuCauKBBL().Insert(init_obj());
                    objs= new YeuCauKBBL().Select(objs);
                    KichBanCuoiDO obj = new KichBanCuoiDO();
                    obj.YeuCauKBID = objs.YeuCauKBID;
                    if (!string.IsNullOrEmpty(objs.AHTrapLeAnHoi))  obj.DVLeAnHoi = "Đồ lễ ăn hỏi<br/>";
                    if (!string.IsNullOrEmpty(objs.AHXe16Cho)) obj.DVLeAnHoi += "Xe 16 chỗ<br/>";
                    if (!string.IsNullOrEmpty(objs.AHXe29Cho)) obj.DVLeAnHoi += "Xe 29 chỗ<br/>";
                    if (!string.IsNullOrEmpty(objs.AHNamBeTrap)) obj.DVLeAnHoi += "Nam bê tráp<br/>";
                    if (!string.IsNullOrEmpty(objs.AHNuDoTrap)) obj.DVLeAnHoi += "Nữ đỡ tráp<br/>";
                    if (!string.IsNullOrEmpty(objs.AHPhongNhaGai)) obj.DVLeAnHoi += "Phông nhà gái<br/>";
                    if (!string.IsNullOrEmpty(objs.AHBanGhe)) obj.DVLeAnHoi += "Bàn ghế<br/>";
                    if (!string.IsNullOrEmpty(objs.AHNhaBat)) obj.DVLeAnHoi += "Nhà bạt<br/>";
                    if (!string.IsNullOrEmpty(objs.AHPhaoGiay)) obj.DVLeAnHoi += "Pháo Giấy<br/>";
                    if (!string.IsNullOrEmpty(objs.AHChuHy)) obj.DVLeAnHoi += "Chữ hỷ<br/>";

                    if (!string.IsNullOrEmpty(objs.AHHoaAnHoi)) obj.DVLeAnHoi += objs.AHHoaAnHoi + "<br/>";

                    if (!string.IsNullOrEmpty(objs.NCXe4Cho)) obj.DVLeCuoi = "Xe 4 chỗ <br/>";
                    if (!string.IsNullOrEmpty(objs.NCXe16Cho)) obj.DVLeCuoi += "Xe 16 chỗ <br/>";
                    if (!string.IsNullOrEmpty(objs.NCXe29Cho)) obj.DVLeCuoi += "Xe 29 chỗ <br/>";
                    if (!string.IsNullOrEmpty(objs.NCPhongDamCuoi)) obj.DVLeCuoi += "Phông đám cưới <br/>";
                    if (!string.IsNullOrEmpty(objs.NCBanGhe)) obj.DVLeCuoi += "Bàn ghế <br/>";
                    if (!string.IsNullOrEmpty(objs.NCNhaBat)) obj.DVLeCuoi += "Nhà bạt <br/>";
                    if (!string.IsNullOrEmpty(objs.NCPhao)) obj.DVLeCuoi += "Pháo <br/>";
                    if (!string.IsNullOrEmpty(objs.NCChuHy)) obj.DVLeCuoi += "Chữ Hỷ <br/>";
                    obj.DVLeCuoi += objs.NCHoaCuoi + "<br/>";

                    obj.ExtCHTG1 = "Hoa Cưới tại nhà:";
                    if (chkCT.Checked) obj.ExtCHTG1 = obj.ExtCHTG1 + "<br/>Hoa Trang trí cầu thang";
                    if (chkTK.Checked) obj.ExtCHTG1 = obj.ExtCHTG1 + "<br/>Hoa bàn Tiếp khách";
                    if (chkHP.Checked) obj.ExtCHTG1 = obj.ExtCHTG1 + "<br/>Hoa Phòng Cô dâu-Chú Rể";
                    if (chkCHC.Checked) obj.ExtCHTG1 = obj.ExtCHTG1 + "<br/>Cổng hoa";
                    if (chkHKG.Checked) obj.ExtCHTG1 = obj.ExtCHTG1 + "<br/>Hoa Trang trí Không gian";
                    if (CheckBox6.Checked) obj.ExtCHTG1 = obj.ExtCHTG1 + "<br/>Hoa Trang trí Phông";
                    if (chkHX.Checked) obj.ExtCHTG2 = "<br/>Hoa tay, Hoa xe.";


                    obj.ExtCHTG3 = "<br/>Hoa cưới tại Điểm tiệc:";
                    if (CheckBox1.Checked) obj.ExtCHTG3 = obj.ExtCHTG3 + "<br/>Cổng Hoa";
                    if (CheckBox4.Checked) obj.ExtCHTG3 = obj.ExtCHTG3 + "<br/>Hoa Bánh cưới";
                    if (CheckBox3.Checked) obj.ExtCHTG3 = obj.ExtCHTG3 + "<br/>Hoa sân khấu";
                    if (CheckBox2.Checked) obj.ExtCHTG3 = obj.ExtCHTG3 + "<br/>Hoa Trang trí đường dẫn";
                    if (CheckBox5.Checked) obj.ExtCHTG3 = obj.ExtCHTG3 + "<br/>Hoa Trang trí tháp ly";

                        
                   
                    new KichBanCuoiBL().Insert(obj);
                    if (!rdoAll.Checked) body = body + svYC;
                    Ultility.Alert(SendMail(txtGroomName.Value, getTitle(), body, new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, true, true), "/Default.aspx");
                }
                catch (Exception ee)
                {
                    lbl.Text = ee.ToString();
                }
            }
        }

    }
    }
