/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Collections;

namespace SES.CMS.DO
{
    [Serializable]
    public class YeuCauKBDO
    {

        /// <summary>
        /// Summary description for YeuCauKBDO
        /// </summary>


        #region Public Constants (Fields name)
        public const string YEUCAUKBID_FIELD = "YeuCauKBID";
        public const string CHAPNHAN_FIELD = "ChapNhan";
        public const string TENDANGNHAP_FIELD = "TenDangNhap";
        public const string MATKHAI_FIELD = "MatKhai";
        public const string TENCHURE_FIELD = "TenChuRe";
        public const string TENCODAU_FIELD = "TenCoDau";
        public const string DIACHINHATRAI_FIELD = "DiaChiNhaTrai";
        public const string DIACHINHAGAI_FIELD = "DiaChiNhaGai";
        public const string SODTCHURE_FIELD = "SoDTChuRe";
        public const string SODTCODAU_FIELD = "SoDTCoDau";
        public const string MAILCHURE_FIELD = "MailChuRe";
        public const string MAILCODAU_FIELD = "MailCoDau";
        public const string DIEMTIECNT_FIELD = "DiemTiecNT";
        public const string DIEMTIECNG_FIELD = "DiemTiecNG";
        public const string NGAYDAMNGO_FIELD = "NgayDamNgo";
        public const string GIODAMNGO_FIELD = "GioDamNgo";
        public const string PHUTDAMNGO_FIELD = "PhutDamNgo";
        public const string NGAYANHOI_FIELD = "NgayAnHoi";
        public const string GIOANHOI_FIELD = "GioAnHoi";
        public const string PHUTANHOI_FIELD = "PhutAnHoi";
        public const string NGAYDONDAU_FIELD = "NgayDonDau";
        public const string GIODONDAU_FIELD = "GioDonDau";
        public const string PHUDONDAU_FIELD = "PhuDonDau";
        public const string NGAYTIECCUOI_FIELD = "NgayTiecCuoi";
        public const string GIOTIECCUOI_FIELD = "GioTiecCuoi";
        public const string PHUTTIECCUOI_FIELD = "PhutTiecCuoi";
        public const string YEUCAUKHAC_FIELD = "YeuCauKhac";
        public const string TRONGOI_FIELD = "TronGoi";
        public const string SODICHVUTRONGOI_FIELD = "SoDichVuTronGoi";
        public const string AHLOAIDAMNGO_FIELD = "AHLoaiDamNgo";
        public const string AHCHUPNGOAITROI_FIELD = "AHChupNgoaiTroi";
        public const string AHTRAPLEANHOI_FIELD = "AHTrapLeAnHoi";
        public const string AHQUAYPHIM_FIELD = "AHQuayPhim";
        public const string AHCHUPANH_FIELD = "AHChupAnh";
        public const string AHXE16CHO_FIELD = "AHXe16Cho";
        public const string AHXE29CHO_FIELD = "AHXe29Cho";
        public const string AHNAMBETRAP_FIELD = "AHNamBeTrap";
        public const string AHNUDOTRAP_FIELD = "AHNuDoTrap";
        public const string AHPHONGNHAGAI_FIELD = "AHPhongNhaGai";
        public const string AHBANGHE_FIELD = "AHBanGhe";
        public const string AHNHABAT_FIELD = "AHNhaBat";
        public const string AHHOAANHOI_FIELD = "AHHoaAnHoi";
        public const string NCLEXINDAU_FIELD = "NCLeXinDau";
        public const string NCQUAYPHIM_FIELD = "NCQuayPhim";
        public const string NCCHUPANH_FIELD = "NCChupAnh";
        public const string NCXE4CHO_FIELD = "NCXe4Cho";
        public const string NCXE16CHO_FIELD = "NCXe16Cho";
        public const string NCXE29CHO_FIELD = "NCXe29Cho";
        public const string NCPHONGDAMCUOI_FIELD = "NCPhongDamCuoi";
        public const string NCBANGHE_FIELD = "NCBanGhe";
        public const string NCNHABAT_FIELD = "NCNhaBat";
        public const string NCPHAO_FIELD = "NCPhao";
        public const string NCCHUHY_FIELD = "NCChuHy";
        public const string NCHOACUOI_FIELD = "NCHoaCuoi";
        public const string AHPHAOGIAY_FIELD = "AHPhaoGiay";
        public const string AHCHUHY_FIELD = "AHChuHy";

        #endregion

        #region Private Variables
        private Int32 _YeuCauKBID;
        private Boolean _ChapNhan;
        private String _TenDangNhap;
        private String _MatKhai;
        private String _TenChuRe;
        private String _TenCoDau;
        private String _DiaChiNhaTrai;
        private String _DiaChiNhaGai;
        private String _SoDTChuRe;
        private String _SoDTCoDau;
        private String _MailChuRe;
        private String _MailCoDau;
        private String _DiemTiecNT;
        private String _DiemTiecNG;
        private String _NgayDamNgo;
        private String _GioDamNgo;
        private String _PhutDamNgo;
        private String _NgayAnHoi;
        private String _GioAnHoi;
        private String _PhutAnHoi;
        private String _NgayDonDau;
        private String _GioDonDau;
        private String _PhuDonDau;
        private String _NgayTiecCuoi;
        private String _GioTiecCuoi;
        private String _PhutTiecCuoi;
        private String _YeuCauKhac;
        private Boolean _TronGoi;
        private Int32 _SoDichVuTronGoi;
        private String _AHLoaiDamNgo;
        private String _AHChupNgoaiTroi;
        private String _AHTrapLeAnHoi;
        private String _AHQuayPhim;
        private String _AHChupAnh;
        private String _AHXe16Cho;
        private String _AHXe29Cho;
        private String _AHNamBeTrap;
        private String _AHNuDoTrap;
        private String _AHPhongNhaGai;
        private String _AHBanGhe;
        private String _AHNhaBat;
        private String _AHHoaAnHoi;
        private Boolean _NCLeXinDau;
        private String _NCQuayPhim;
        private String _NCChupAnh;
        private String _NCXe4Cho;
        private String _NCXe16Cho;
        private String _NCXe29Cho;
        private String _NCPhongDamCuoi;
        private String _NCBanGhe;
        private String _NCNhaBat;
        private String _NCPhao;
        private String _NCChuHy;
        private String _NCHoaCuoi;
        private String _AHPhaoGiay;
        private String _AHChuHy;

        #endregion

        #region Public Properties
        public Int32 YeuCauKBID
        {
            get
            {
                return _YeuCauKBID;
            }
            set
            {
                _YeuCauKBID = value;
            }
        }
        public Boolean ChapNhan
        {
            get
            {
                return _ChapNhan;
            }
            set
            {
                _ChapNhan = value;
            }
        }
        public String TenDangNhap
        {
            get
            {
                return _TenDangNhap;
            }
            set
            {
                _TenDangNhap = value;
            }
        }
        public String MatKhai
        {
            get
            {
                return _MatKhai;
            }
            set
            {
                _MatKhai = value;
            }
        }
        public String TenChuRe
        {
            get
            {
                return _TenChuRe;
            }
            set
            {
                _TenChuRe = value;
            }
        }
        public String TenCoDau
        {
            get
            {
                return _TenCoDau;
            }
            set
            {
                _TenCoDau = value;
            }
        }
        public String DiaChiNhaTrai
        {
            get
            {
                return _DiaChiNhaTrai;
            }
            set
            {
                _DiaChiNhaTrai = value;
            }
        }
        public String DiaChiNhaGai
        {
            get
            {
                return _DiaChiNhaGai;
            }
            set
            {
                _DiaChiNhaGai = value;
            }
        }
        public String SoDTChuRe
        {
            get
            {
                return _SoDTChuRe;
            }
            set
            {
                _SoDTChuRe = value;
            }
        }
        public String SoDTCoDau
        {
            get
            {
                return _SoDTCoDau;
            }
            set
            {
                _SoDTCoDau = value;
            }
        }
        public String MailChuRe
        {
            get
            {
                return _MailChuRe;
            }
            set
            {
                _MailChuRe = value;
            }
        }
        public String MailCoDau
        {
            get
            {
                return _MailCoDau;
            }
            set
            {
                _MailCoDau = value;
            }
        }
        public String DiemTiecNT
        {
            get
            {
                return _DiemTiecNT;
            }
            set
            {
                _DiemTiecNT = value;
            }
        }
        public String DiemTiecNG
        {
            get
            {
                return _DiemTiecNG;
            }
            set
            {
                _DiemTiecNG = value;
            }
        }
        public String NgayDamNgo
        {
            get
            {
                return _NgayDamNgo;
            }
            set
            {
                _NgayDamNgo = value;
            }
        }
        public String GioDamNgo
        {
            get
            {
                return _GioDamNgo;
            }
            set
            {
                _GioDamNgo = value;
            }
        }
        public String PhutDamNgo
        {
            get
            {
                return _PhutDamNgo;
            }
            set
            {
                _PhutDamNgo = value;
            }
        }
        public String NgayAnHoi
        {
            get
            {
                return _NgayAnHoi;
            }
            set
            {
                _NgayAnHoi = value;
            }
        }
        public String GioAnHoi
        {
            get
            {
                return _GioAnHoi;
            }
            set
            {
                _GioAnHoi = value;
            }
        }
        public String PhutAnHoi
        {
            get
            {
                return _PhutAnHoi;
            }
            set
            {
                _PhutAnHoi = value;
            }
        }
        public String NgayDonDau
        {
            get
            {
                return _NgayDonDau;
            }
            set
            {
                _NgayDonDau = value;
            }
        }
        public String GioDonDau
        {
            get
            {
                return _GioDonDau;
            }
            set
            {
                _GioDonDau = value;
            }
        }
        public String PhuDonDau
        {
            get
            {
                return _PhuDonDau;
            }
            set
            {
                _PhuDonDau = value;
            }
        }
        public String NgayTiecCuoi
        {
            get
            {
                return _NgayTiecCuoi;
            }
            set
            {
                _NgayTiecCuoi = value;
            }
        }
        public String GioTiecCuoi
        {
            get
            {
                return _GioTiecCuoi;
            }
            set
            {
                _GioTiecCuoi = value;
            }
        }
        public String PhutTiecCuoi
        {
            get
            {
                return _PhutTiecCuoi;
            }
            set
            {
                _PhutTiecCuoi = value;
            }
        }
        public String YeuCauKhac
        {
            get
            {
                return _YeuCauKhac;
            }
            set
            {
                _YeuCauKhac = value;
            }
        }
        public Boolean TronGoi
        {
            get
            {
                return _TronGoi;
            }
            set
            {
                _TronGoi = value;
            }
        }
        public Int32 SoDichVuTronGoi
        {
            get
            {
                return _SoDichVuTronGoi;
            }
            set
            {
                _SoDichVuTronGoi = value;
            }
        }
        public String AHLoaiDamNgo
        {
            get
            {
                return _AHLoaiDamNgo;
            }
            set
            {
                _AHLoaiDamNgo = value;
            }
        }
        public String AHChupNgoaiTroi
        {
            get
            {
                return _AHChupNgoaiTroi;
            }
            set
            {
                _AHChupNgoaiTroi = value;
            }
        }
        public String AHTrapLeAnHoi
        {
            get
            {
                return _AHTrapLeAnHoi;
            }
            set
            {
                _AHTrapLeAnHoi = value;
            }
        }
        public String AHQuayPhim
        {
            get
            {
                return _AHQuayPhim;
            }
            set
            {
                _AHQuayPhim = value;
            }
        }
        public String AHChupAnh
        {
            get
            {
                return _AHChupAnh;
            }
            set
            {
                _AHChupAnh = value;
            }
        }
        public String AHXe16Cho
        {
            get
            {
                return _AHXe16Cho;
            }
            set
            {
                _AHXe16Cho = value;
            }
        }
        public String AHXe29Cho
        {
            get
            {
                return _AHXe29Cho;
            }
            set
            {
                _AHXe29Cho = value;
            }
        }
        public String AHNamBeTrap
        {
            get
            {
                return _AHNamBeTrap;
            }
            set
            {
                _AHNamBeTrap = value;
            }
        }
        public String AHNuDoTrap
        {
            get
            {
                return _AHNuDoTrap;
            }
            set
            {
                _AHNuDoTrap = value;
            }
        }
        public String AHPhongNhaGai
        {
            get
            {
                return _AHPhongNhaGai;
            }
            set
            {
                _AHPhongNhaGai = value;
            }
        }
        public String AHBanGhe
        {
            get
            {
                return _AHBanGhe;
            }
            set
            {
                _AHBanGhe = value;
            }
        }
        public String AHNhaBat
        {
            get
            {
                return _AHNhaBat;
            }
            set
            {
                _AHNhaBat = value;
            }
        }
        public String AHHoaAnHoi
        {
            get
            {
                return _AHHoaAnHoi;
            }
            set
            {
                _AHHoaAnHoi = value;
            }
        }
        public Boolean NCLeXinDau
        {
            get
            {
                return _NCLeXinDau;
            }
            set
            {
                _NCLeXinDau = value;
            }
        }
        public String NCQuayPhim
        {
            get
            {
                return _NCQuayPhim;
            }
            set
            {
                _NCQuayPhim = value;
            }
        }
        public String NCChupAnh
        {
            get
            {
                return _NCChupAnh;
            }
            set
            {
                _NCChupAnh = value;
            }
        }
        public String NCXe4Cho
        {
            get
            {
                return _NCXe4Cho;
            }
            set
            {
                _NCXe4Cho = value;
            }
        }
        public String NCXe16Cho
        {
            get
            {
                return _NCXe16Cho;
            }
            set
            {
                _NCXe16Cho = value;
            }
        }
        public String NCXe29Cho
        {
            get
            {
                return _NCXe29Cho;
            }
            set
            {
                _NCXe29Cho = value;
            }
        }
        public String NCPhongDamCuoi
        {
            get
            {
                return _NCPhongDamCuoi;
            }
            set
            {
                _NCPhongDamCuoi = value;
            }
        }
        public String NCBanGhe
        {
            get
            {
                return _NCBanGhe;
            }
            set
            {
                _NCBanGhe = value;
            }
        }
        public String NCNhaBat
        {
            get
            {
                return _NCNhaBat;
            }
            set
            {
                _NCNhaBat = value;
            }
        }
        public String NCPhao
        {
            get
            {
                return _NCPhao;
            }
            set
            {
                _NCPhao = value;
            }
        }
        public String NCChuHy
        {
            get
            {
                return _NCChuHy;
            }
            set
            {
                _NCChuHy = value;
            }
        }
        public String NCHoaCuoi
        {
            get
            {
                return _NCHoaCuoi;
            }
            set
            {
                _NCHoaCuoi = value;
            }
        }
        public String AHPhaoGiay
        {
            get
            {
                return _AHPhaoGiay;
            }
            set
            {
                _AHPhaoGiay = value;
            }
        }
        public String AHChuHy
        {
            get
            {
                return _AHChuHy;
            }
            set
            {
                _AHChuHy = value;
            }
        }

        #endregion

    }
}
