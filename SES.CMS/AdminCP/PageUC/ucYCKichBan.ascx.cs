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

namespace SES.CMS.AdminCP.PageUC
{
    public partial class ucYCKichBan : System.Web.UI.UserControl
    {
        YeuCauKBDO objYC = new YeuCauKBDO();
        KichBanCuoiDO objKB = new KichBanCuoiDO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["YeuCauKBID"] != null)
            {
                objYC.YeuCauKBID = int.Parse(Request.QueryString["YeuCauKBID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objYC = new YeuCauKBBL().Select(objYC);
            objKB = new KichBanCuoiBL().SelectByYC(objYC.YeuCauKBID);

            chkChapNhan.Checked = objYC.ChapNhan;
            txtUserName.Text = objYC.TenDangNhap;
            txtMatKhau.Text = objYC.MatKhai;


            lblTenChuRe.Text = objYC.TenChuRe;
            lblTenCoDau.Text = objYC.TenCoDau;
            lblNhaChuRe.Text = objYC.DiaChiNhaTrai;
            lblNhaCoDau.Text = objYC.DiaChiNhaGai;
            lblHDamNgo.Text = objYC.GioDamNgo + "H" + objYC.PhutDamNgo + "p";
            lblNgayDamNgo.Text = objYC.NgayDamNgo;
            lblNgayAnHoi.Text = objYC.NgayAnHoi;
            lblGioDenNG.Text = objYC.GioAnHoi + "H" + objYC.PhutAnHoi + "p";
            lblGioDenNGTH.Text = objYC.GioDonDau + "H" + objYC.PhuDonDau + "p";
            lblNgayThanhHon.Text = objYC.NgayDonDau;
            lblNTKhoiHanh.Text = objKB.GioNTKhoiHanhAH;
            lblNTKhoiHanhTH.Text = objKB.GioNTKhoiHanhTH;
            lblChoDatTiecCuoi.Text = objYC.DiemTiecNT;
            lblChoDatTiecCuoiNG.Text = objYC.DiemTiecNG;
            lblTGToChucTiec.Text = objYC.NgayTiecCuoi;
            lblHTiecCuoi.Text = objYC.GioTiecCuoi + "H" + objYC.PhutTiecCuoi + "p";
            //lblDichVuAH.Text = objKB.DVLeAnHoi;
            
            //Nhóm -	Phông-	Bàn ghế-	Nhà bạt-	Pháo-	Chữ hỷ

            if (!string.IsNullOrEmpty(objYC.AHPhongNhaGai)) lblDichVuAH.Text += "Phông nhà gái<br/>";
            if (!string.IsNullOrEmpty(objYC.AHBanGhe)) lblDichVuAH.Text += "Bàn ghế<br/>";
            if (!string.IsNullOrEmpty(objYC.AHNhaBat)) lblDichVuAH.Text += "Nhà bạt<br/>";
            if (!string.IsNullOrEmpty(objYC.AHPhaoGiay)) lblDichVuAH.Text += "Pháo giấy<br/>";
            if (!string.IsNullOrEmpty(objYC.AHChuHy)) lblDichVuAH.Text += "Chữ Hỷ<br/>";
            //N1
            if (!string.IsNullOrEmpty(objYC.AHTrapLeAnHoi)) lblDichVuAHN1.Text = "Đồ lễ ăn hỏi<br/>";
            //N2
            lblDichVuAHN2.Text = "Chụp ảnh<br/>";
            lblDichVuAHN2.Text += "Quay Phim<br/>";
            if (!string.IsNullOrEmpty(objYC.AHXe16Cho)) lblDichVuAHN2.Text += "Xe 16 chỗ<br/>";
            if (!string.IsNullOrEmpty(objYC.AHXe29Cho)) lblDichVuAHN2.Text += "Xe 29 chỗ<br/>";
            //N3
            if (!string.IsNullOrEmpty(objYC.AHNamBeTrap)) lblDichVuAHN3.Text = "Đội Nam bê Tráp<br/>";
            //N4
            if (!string.IsNullOrEmpty(objYC.AHNuDoTrap)) lblDichVuAHN4.Text = "Đội Nữ đỡ Tráp<br/>";
            //N5
            if (!string.IsNullOrEmpty(objYC.AHHoaAnHoi)) lblDichVuAHN5.Text = objYC.AHHoaAnHoi + "<br/>";

            /*********** Le Cuoi ************/

            if (!string.IsNullOrEmpty(objYC.NCPhongDamCuoi)) lblDichVuNC.Text = "Phông đám cưới <br/>";
            if (!string.IsNullOrEmpty(objYC.NCBanGhe)) lblDichVuNC.Text += "Bàn ghế <br/>";
            if (!string.IsNullOrEmpty(objYC.NCNhaBat)) lblDichVuNC.Text += "Nhà bạt <br/>";
            lblDichVuNC.Text += objKB.ExtCHTG1;
            //N1
            if (objYC.NCLeXinDau) lblDichVuNCN1.Text = "Lễ xin dâu" + "<br/>";
            if (!string.IsNullOrEmpty(objYC.NCPhao)) lblDichVuNCN1.Text += "Pháo <br/>";
            if (!string.IsNullOrEmpty(objYC.NCChuHy)) lblDichVuNCN1.Text += "Chữ Hỷ";
            //N2
            if (!string.IsNullOrEmpty(objKB.ExtCHTG2)) lblDichVuNCN2.Text = objKB.ExtCHTG2 + "<br/>";
            //N3
            if (!string.IsNullOrEmpty(objYC.NCQuayPhim)) lblDichVuNCN3.Text = "Quay phim <br/>";
            if (!string.IsNullOrEmpty(objYC.NCChupAnh)) lblDichVuNCN3.Text += "Chụp ảnh <br/>";
            if (!string.IsNullOrEmpty(objYC.NCXe4Cho)) lblDichVuNCN3.Text += "Xe 4 chỗ <br/>";
            if (!string.IsNullOrEmpty(objYC.NCXe16Cho)) lblDichVuNCN3.Text += "Xe 16 chỗ <br/>";
            if (!string.IsNullOrEmpty(objYC.NCXe29Cho)) lblDichVuNCN3.Text += "Xe 29 chỗ <br/>";
            //N4
            if (!string.IsNullOrEmpty(objKB.ExtCHTG3)) lblDichVuNCN4.Text = objKB.ExtCHTG3 + "<br/>";

           



            txt1.Text = objKB.TGLeDamNgo;
            txt2.Text = objKB.TGLeAnHoi;
            //999999999999999999999
            txtTGAnHoiN1.Text = objKB.TGAnHoiN1;
            txtTGAnHoiN2.Text = objKB.TGAnHoiN2;
            txtTGAnHoiN3.Text = objKB.TGAnHoiN3;
            txtTGAnHoiN4.Text = objKB.TGAnHoiN4;
            txtTGAnHoiN5.Text = objKB.TGAnHoiN5;
            txtTGLeCuoiN1.Text = objKB.TGLeCuoiN1;
            txtTGLeCuoiN2.Text = objKB.TGLeCuoiN2;
            txtTGLeCuoiN3.Text = objKB.TGLeCuoiN3;
            txtTGLeCuoiN4.Text = objKB.TGLeCuoiN4;
            //999999999999999999999
            txt3.Text = objKB.LCLoTrinhNTNG;
            txt4.Text = objKB.LCLoTrinhNGNT;
            txtNTDT.Text = objKB.LCLoTrinhNGRaDT;
            //txt6.Text = objKB.TGTrapNamCoMatNT;
            //txt6.Text = objKB.TGTrapNuCoMatNG;
            txt7.Text = objKB.TGLeCuoi;
           
        
            //txt8.Text = objKB.XeGanHoa;
            //txt9.Text = objKB.XeCoMatNT;
            //txt10.Text = objKB.LCLoTrinhNTNG;
            //txt11.Text = objKB.LCLoTrinhNGNT;
            //txt12.Text = objKB.LCLoTrinhNGRaDT;
            tt4.Text = objKB.QTChupAnhTrapAH;
            tt5.Text = objKB.QTKhoiHanhNhatraiAH;
            tt6.Text = objKB.QTDenNhaGaiNgoiAH;
            tt23.Text = objKB.QTTrapNamMangLeLQVeAH;
            tt24.Text = objKB.QTLayLeXinDauCuaHangLC;
            txt25.Text = objKB.QTDoanXinDenNTLC;
            txt26.Text = objKB.QT2NguoiVaoNG;
            txt27.Text = objKB.QTNGDonNT;
            txt28.Text = objKB.QTNTOnDinhCho;
            txt35.Text = objKB.QTNGDiCungNT;
            txt31.Text = objKB.QTNTXinPhepHoa;
            txt36.Text = objKB.QT2HoOnDinh;
            txt42.Text = objKB.QT2NhaRaDiemTiec;
            txt43.Text = objKB.CDCRDenTruocDon;
            txt44.Text = objKB.BoMeDonKhach;
            txt46.Text = objKB.BoMeCamOn;
            

        }

        protected void btnCapNhat2_Click(object sender, EventArgs e)
        {
            initKBYC();

        }

        private void initKBYC()
        {
            objYC.ChapNhan = chkChapNhan.Checked;
            objYC.TenDangNhap = txtUserName.Text;
            objYC.MatKhai = txtMatKhau.Text;
            new YeuCauKBBL().Update(objYC);

            objKB.TGLeDamNgo = txt1.Text;
            objKB.TGLeAnHoi = txt2.Text;
            objKB.TGAnHoiN1 = txtTGAnHoiN1.Text;
            objKB.TGAnHoiN2 = txtTGAnHoiN2.Text;
            objKB.TGAnHoiN3 = txtTGAnHoiN3.Text;
            objKB.TGAnHoiN4 = txtTGAnHoiN4.Text;
            objKB.TGAnHoiN5 = txtTGAnHoiN5.Text;
            objKB.LCLoTrinhNTNG = txt3.Text;
            objKB.LCLoTrinhNGNT = txt4.Text;
            objKB.LCLoTrinhNGRaDT = txtNTDT.Text;
             
            //objKB.TGTrapNamCoMatNT = txt5.Text;
            //objKB.TGTrapNamCoMatNT = txt6.Text;
            //objKB.TGTrapNuCoMatNG = txt6.Text;
            objKB.TGLeCuoi = txt7.Text;

            objKB.TGLeCuoiN1 = txtTGLeCuoiN1.Text;
            objKB.TGLeCuoiN2 = txtTGLeCuoiN2.Text;
            objKB.TGLeCuoiN3 = txtTGLeCuoiN3.Text;
            objKB.TGLeCuoiN4 = txtTGLeCuoiN4.Text;
            

            //objKB.XeGanHoa = txt8.Text;
            //objKB.XeCoMatNT = txt9.Text;
            //objKB.LCLoTrinhNTNG = txt10.Text;
            //objKB.LCLoTrinhNGNT = txt11.Text;
            //objKB.LCLoTrinhNGRaDT = txt12.Text;
            objKB.QTChupAnhTrapAH = tt4.Text;
            objKB.QTKhoiHanhNhatraiAH = tt5.Text;
            objKB.QTDenNhaGaiNgoiAH = tt6.Text;
            objKB.QTTrapNamMangLeLQVeAH = tt23.Text;
            objKB.QTLayLeXinDauCuaHangLC = tt24.Text;
            objKB.QTDoanXinDenNTLC = txt25.Text;
            objKB.QT2NguoiVaoNG = txt26.Text;
            objKB.QTNGDonNT = txt27.Text;
            objKB.QTNTOnDinhCho = txt28.Text;
            objKB.QTNGDiCungNT = txt35.Text;
            objKB.QTNTXinPhepHoa = txt31.Text;
            objKB.QT2HoOnDinh = txt36.Text;
            objKB.QT2NhaRaDiemTiec = txt42.Text;
            objKB.CDCRDenTruocDon = txt43.Text;
            objKB.BoMeDonKhach = txt44.Text;
            objKB.BoMeCamOn = txt46.Text;
            objKB.GioNTKhoiHanhAH = lblNTKhoiHanh.Text;
            objKB.GioNTKhoiHanhTH = lblNTKhoiHanhTH.Text;
            new KichBanCuoiBL().Update(objKB);
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            initKBYC();
        }
    }
}