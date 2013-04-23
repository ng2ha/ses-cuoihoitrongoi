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
    public class KichBanCuoiDO
    {

        /// <summary>
        /// Summary description for KichBanCuoiDO
        /// </summary>


        #region Public Constants (Fields name)
        public const string KICHBANCUOIID_FIELD = "KichBanCuoiID";
        public const string YEUCAUKBID_FIELD = "YeuCauKBID";
        public const string GIONTKHOIHANHAH_FIELD = "GioNTKhoiHanhAH";
        public const string GIONTKHOIHANHTH_FIELD = "GioNTKhoiHanhTH";
        public const string TGLEDAMNGO_FIELD = "TGLeDamNgo";
        public const string DVLEANHOI_FIELD = "DVLeAnHoi";
        public const string TGLEANHOI_FIELD = "TGLeAnHoi";
        public const string AHLOTRINHNTNG_FIELD = "AHLoTrinhNTNG";
        public const string AHLOTRINHNGNT_FIELD = "AHLoTrinhNGNT";
        public const string TGTRAPNAMCOMATNT_FIELD = "TGTrapNamCoMatNT";
        public const string TGTRAPNUCOMATNG_FIELD = "TGTrapNuCoMatNG";
        public const string DVLECUOI_FIELD = "DVLeCuoi";
        public const string TGLECUOI_FIELD = "TGLeCuoi";
        public const string XEGANHOA_FIELD = "XeGanHoa";
        public const string XECOMATNT_FIELD = "XeCoMatNT";
        public const string LCLOTRINHNTNG_FIELD = "LCLoTrinhNTNG";
        public const string LCLOTRINHNGNT_FIELD = "LCLoTrinhNGNT";
        public const string LCLOTRINHNGRADT_FIELD = "LCLoTrinhNGRaDT";
        public const string QTCHUPANHTRAPAH_FIELD = "QTChupAnhTrapAH";
        public const string QTKHOIHANHNHATRAIAH_FIELD = "QTKhoiHanhNhatraiAH";
        public const string QTDENNHAGAINGOIAH_FIELD = "QTDenNhaGaiNgoiAH";
        public const string QTTRAPNAMMANGLELQVEAH_FIELD = "QTTrapNamMangLeLQVeAH";
        public const string QTLAYLEXINDAUCUAHANGLC_FIELD = "QTLayLeXinDauCuaHangLC";
        public const string QTDOANXINDENNTLC_FIELD = "QTDoanXinDenNTLC";
        public const string QT2NGUOIVAONG_FIELD = "QT2NguoiVaoNG";
        public const string QTNGDONNT_FIELD = "QTNGDonNT";
        public const string QTNTONDINHCHO_FIELD = "QTNTOnDinhCho";
        public const string QTNTXINPHEPHOA_FIELD = "QTNTXinPhepHoa";
        public const string QTNGDICUNGNT_FIELD = "QTNGDiCungNT";
        public const string QT2HOONDINH_FIELD = "QT2HoOnDinh";
        public const string QT2NHARADIEMTIEC_FIELD = "QT2NhaRaDiemTiec";
        public const string CDCRDENTRUOCDON_FIELD = "CDCRDenTruocDon";
        public const string BOMEDONKHACH_FIELD = "BoMeDonKhach";
        public const string BOMECAMON_FIELD = "BoMeCamOn";
        public const string TGANHOIN1_FIELD = "TGAnHoiN1";
        public const string TGANHOIN2_FIELD = "TGAnHoiN2";
        public const string TGANHOIN3_FIELD = "TGAnHoiN3";
        public const string TGANHOIN4_FIELD = "TGAnHoiN4";
        public const string TGANHOIN5_FIELD = "TGAnHoiN5";
        public const string TGLECUOIN1_FIELD = "TGLeCuoiN1";
        public const string TGLECUOIN2_FIELD = "TGLeCuoiN2";
        public const string TGLECUOIN3_FIELD = "TGLeCuoiN3";
        public const string TGLECUOIN4_FIELD = "TGLeCuoiN4";
        public const string EXTCHTG1_FIELD = "ExtCHTG1";
        public const string EXTCHTG2_FIELD = "ExtCHTG2";
        public const string EXTCHTG3_FIELD = "ExtCHTG3";
        public const string EXTCHTG4_FIELD = "ExtCHTG4";
        public const string EXTCHTG5_FIELD = "ExtCHTG5";

        #endregion

        #region Private Variables
        private Int32 _KichBanCuoiID;
        private Int32 _YeuCauKBID;
        private String _GioNTKhoiHanhAH;
        private String _GioNTKhoiHanhTH;
        private String _TGLeDamNgo;
        private String _DVLeAnHoi;
        private String _TGLeAnHoi;
        private String _AHLoTrinhNTNG;
        private String _AHLoTrinhNGNT;
        private String _TGTrapNamCoMatNT;
        private String _TGTrapNuCoMatNG;
        private String _DVLeCuoi;
        private String _TGLeCuoi;
        private String _XeGanHoa;
        private String _XeCoMatNT;
        private String _LCLoTrinhNTNG;
        private String _LCLoTrinhNGNT;
        private String _LCLoTrinhNGRaDT;
        private String _QTChupAnhTrapAH;
        private String _QTKhoiHanhNhatraiAH;
        private String _QTDenNhaGaiNgoiAH;
        private String _QTTrapNamMangLeLQVeAH;
        private String _QTLayLeXinDauCuaHangLC;
        private String _QTDoanXinDenNTLC;
        private String _QT2NguoiVaoNG;
        private String _QTNGDonNT;
        private String _QTNTOnDinhCho;
        private String _QTNTXinPhepHoa;
        private String _QTNGDiCungNT;
        private String _QT2HoOnDinh;
        private String _QT2NhaRaDiemTiec;
        private String _CDCRDenTruocDon;
        private String _BoMeDonKhach;
        private String _BoMeCamOn;
        private String _TGAnHoiN1;
        private String _TGAnHoiN2;
        private String _TGAnHoiN3;
        private String _TGAnHoiN4;
        private String _TGAnHoiN5;
        private String _TGLeCuoiN1;
        private String _TGLeCuoiN2;
        private String _TGLeCuoiN3;
        private String _TGLeCuoiN4;
        private String _ExtCHTG1;
        private String _ExtCHTG2;
        private String _ExtCHTG3;
        private String _ExtCHTG4;
        private String _ExtCHTG5;

        #endregion

        #region Public Properties
        public Int32 KichBanCuoiID
        {
            get
            {
                return _KichBanCuoiID;
            }
            set
            {
                _KichBanCuoiID = value;
            }
        }
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
        public String GioNTKhoiHanhAH
        {
            get
            {
                return _GioNTKhoiHanhAH;
            }
            set
            {
                _GioNTKhoiHanhAH = value;
            }
        }
        public String GioNTKhoiHanhTH
        {
            get
            {
                return _GioNTKhoiHanhTH;
            }
            set
            {
                _GioNTKhoiHanhTH = value;
            }
        }
        public String TGLeDamNgo
        {
            get
            {
                return _TGLeDamNgo;
            }
            set
            {
                _TGLeDamNgo = value;
            }
        }
        public String DVLeAnHoi
        {
            get
            {
                return _DVLeAnHoi;
            }
            set
            {
                _DVLeAnHoi = value;
            }
        }
        public String TGLeAnHoi
        {
            get
            {
                return _TGLeAnHoi;
            }
            set
            {
                _TGLeAnHoi = value;
            }
        }
        public String AHLoTrinhNTNG
        {
            get
            {
                return _AHLoTrinhNTNG;
            }
            set
            {
                _AHLoTrinhNTNG = value;
            }
        }
        public String AHLoTrinhNGNT
        {
            get
            {
                return _AHLoTrinhNGNT;
            }
            set
            {
                _AHLoTrinhNGNT = value;
            }
        }
        public String TGTrapNamCoMatNT
        {
            get
            {
                return _TGTrapNamCoMatNT;
            }
            set
            {
                _TGTrapNamCoMatNT = value;
            }
        }
        public String TGTrapNuCoMatNG
        {
            get
            {
                return _TGTrapNuCoMatNG;
            }
            set
            {
                _TGTrapNuCoMatNG = value;
            }
        }
        public String DVLeCuoi
        {
            get
            {
                return _DVLeCuoi;
            }
            set
            {
                _DVLeCuoi = value;
            }
        }
        public String TGLeCuoi
        {
            get
            {
                return _TGLeCuoi;
            }
            set
            {
                _TGLeCuoi = value;
            }
        }
        public String XeGanHoa
        {
            get
            {
                return _XeGanHoa;
            }
            set
            {
                _XeGanHoa = value;
            }
        }
        public String XeCoMatNT
        {
            get
            {
                return _XeCoMatNT;
            }
            set
            {
                _XeCoMatNT = value;
            }
        }
        public String LCLoTrinhNTNG
        {
            get
            {
                return _LCLoTrinhNTNG;
            }
            set
            {
                _LCLoTrinhNTNG = value;
            }
        }
        public String LCLoTrinhNGNT
        {
            get
            {
                return _LCLoTrinhNGNT;
            }
            set
            {
                _LCLoTrinhNGNT = value;
            }
        }
        public String LCLoTrinhNGRaDT
        {
            get
            {
                return _LCLoTrinhNGRaDT;
            }
            set
            {
                _LCLoTrinhNGRaDT = value;
            }
        }
        public String QTChupAnhTrapAH
        {
            get
            {
                return _QTChupAnhTrapAH;
            }
            set
            {
                _QTChupAnhTrapAH = value;
            }
        }
        public String QTKhoiHanhNhatraiAH
        {
            get
            {
                return _QTKhoiHanhNhatraiAH;
            }
            set
            {
                _QTKhoiHanhNhatraiAH = value;
            }
        }
        public String QTDenNhaGaiNgoiAH
        {
            get
            {
                return _QTDenNhaGaiNgoiAH;
            }
            set
            {
                _QTDenNhaGaiNgoiAH = value;
            }
        }
        public String QTTrapNamMangLeLQVeAH
        {
            get
            {
                return _QTTrapNamMangLeLQVeAH;
            }
            set
            {
                _QTTrapNamMangLeLQVeAH = value;
            }
        }
        public String QTLayLeXinDauCuaHangLC
        {
            get
            {
                return _QTLayLeXinDauCuaHangLC;
            }
            set
            {
                _QTLayLeXinDauCuaHangLC = value;
            }
        }
        public String QTDoanXinDenNTLC
        {
            get
            {
                return _QTDoanXinDenNTLC;
            }
            set
            {
                _QTDoanXinDenNTLC = value;
            }
        }
        public String QT2NguoiVaoNG
        {
            get
            {
                return _QT2NguoiVaoNG;
            }
            set
            {
                _QT2NguoiVaoNG = value;
            }
        }
        public String QTNGDonNT
        {
            get
            {
                return _QTNGDonNT;
            }
            set
            {
                _QTNGDonNT = value;
            }
        }
        public String QTNTOnDinhCho
        {
            get
            {
                return _QTNTOnDinhCho;
            }
            set
            {
                _QTNTOnDinhCho = value;
            }
        }
        public String QTNTXinPhepHoa
        {
            get
            {
                return _QTNTXinPhepHoa;
            }
            set
            {
                _QTNTXinPhepHoa = value;
            }
        }
        public String QTNGDiCungNT
        {
            get
            {
                return _QTNGDiCungNT;
            }
            set
            {
                _QTNGDiCungNT = value;
            }
        }
        public String QT2HoOnDinh
        {
            get
            {
                return _QT2HoOnDinh;
            }
            set
            {
                _QT2HoOnDinh = value;
            }
        }
        public String QT2NhaRaDiemTiec
        {
            get
            {
                return _QT2NhaRaDiemTiec;
            }
            set
            {
                _QT2NhaRaDiemTiec = value;
            }
        }
        public String CDCRDenTruocDon
        {
            get
            {
                return _CDCRDenTruocDon;
            }
            set
            {
                _CDCRDenTruocDon = value;
            }
        }
        public String BoMeDonKhach
        {
            get
            {
                return _BoMeDonKhach;
            }
            set
            {
                _BoMeDonKhach = value;
            }
        }
        public String BoMeCamOn
        {
            get
            {
                return _BoMeCamOn;
            }
            set
            {
                _BoMeCamOn = value;
            }
        }
        public String TGAnHoiN1
        {
            get
            {
                return _TGAnHoiN1;
            }
            set
            {
                _TGAnHoiN1 = value;
            }
        }
        public String TGAnHoiN2
        {
            get
            {
                return _TGAnHoiN2;
            }
            set
            {
                _TGAnHoiN2 = value;
            }
        }
        public String TGAnHoiN3
        {
            get
            {
                return _TGAnHoiN3;
            }
            set
            {
                _TGAnHoiN3 = value;
            }
        }
        public String TGAnHoiN4
        {
            get
            {
                return _TGAnHoiN4;
            }
            set
            {
                _TGAnHoiN4 = value;
            }
        }
        public String TGAnHoiN5
        {
            get
            {
                return _TGAnHoiN5;
            }
            set
            {
                _TGAnHoiN5 = value;
            }
        }
        public String TGLeCuoiN1
        {
            get
            {
                return _TGLeCuoiN1;
            }
            set
            {
                _TGLeCuoiN1 = value;
            }
        }
        public String TGLeCuoiN2
        {
            get
            {
                return _TGLeCuoiN2;
            }
            set
            {
                _TGLeCuoiN2 = value;
            }
        }
        public String TGLeCuoiN3
        {
            get
            {
                return _TGLeCuoiN3;
            }
            set
            {
                _TGLeCuoiN3 = value;
            }
        }
        public String TGLeCuoiN4
        {
            get
            {
                return _TGLeCuoiN4;
            }
            set
            {
                _TGLeCuoiN4 = value;
            }
        }
        public String ExtCHTG1
        {
            get
            {
                return _ExtCHTG1;
            }
            set
            {
                _ExtCHTG1 = value;
            }
        }
        public String ExtCHTG2
        {
            get
            {
                return _ExtCHTG2;
            }
            set
            {
                _ExtCHTG2 = value;
            }
        }
        public String ExtCHTG3
        {
            get
            {
                return _ExtCHTG3;
            }
            set
            {
                _ExtCHTG3 = value;
            }
        }
        public String ExtCHTG4
        {
            get
            {
                return _ExtCHTG4;
            }
            set
            {
                _ExtCHTG4 = value;
            }
        }
        public String ExtCHTG5
        {
            get
            {
                return _ExtCHTG5;
            }
            set
            {
                _ExtCHTG5 = value;
            }
        }

        #endregion

    }
}
