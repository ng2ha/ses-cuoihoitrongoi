/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Collections;

namespace SES.CMS.DO
{
   [Serializable ]
   public class cmsThongTinKHDO
    {

        /// <summary>
        /// Summary description for cmsThongTinKHDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ID_FIELD ="ID";
		public const string USERNAME_FIELD ="username";
		public const string PASS_FIELD ="pass";
		public const string TENRE_FIELD ="TenRe";
		public const string DCRE_FIELD ="DCRe";
		public const string TENDAU_FIELD ="TenDau";
		public const string DCDAU_FIELD ="DCDau";
		public const string TGDAMNGO_FIELD ="tgDamNgo";
		public const string TGANHOIDUKIEN_FIELD ="tgAnHoiDuKien";
		public const string TGANHOI_FIELD ="tgAnHoi";
		public const string TGTHANHHONDUKIEN_FIELD ="tgThanhHonDuKien";
		public const string TGTHANHHON_FIELD ="tgThanhHon";
		public const string DDTC_FIELD ="DDTC";
		public const string AHTRAP_FIELD ="AHTrap";
		public const string AHHD_FIELD ="AHHD";
		public const string AHALBUM_FIELD ="AHAlbum";
		public const string AHXE4_FIELD ="AHXe4";
		public const string AHXE16_FIELD ="AHXe16";
		public const string AHXE29_FIELD ="AHXe29";
		public const string AHPHONG_FIELD ="AHPhong";
		public const string AHBANANHOI_FIELD ="AHBanAnHoi";
		public const string AHBANGHE_FIELD ="AHBanGhe";
		public const string AHBAT_FIELD ="AHBat";
		public const string AHCONGHOA_FIELD ="AHCongHoa";
		public const string AHPHAO_FIELD ="AHPhao";
		public const string AHCHUHY_FIELD ="AHChuHy";
		public const string AHDOANHOI_FIELD ="AHDoAnHoi";
		public const string AHDOITRAP_FIELD ="AHDoiTrap";
		public const string AHDOITRAPNU_FIELD ="AHDoiTrapNu";
		public const string DCXINDAU_FIELD ="DCXinDau";
		public const string DCHD_FIELD ="DCHD";
		public const string DCALBUM_FIELD ="DCAlbum";
		public const string DCXE4_FIELD ="DCXe4";
		public const string DCXE16_FIELD ="DCXe16";
		public const string DCXE29_FIELD ="DCXe29";
		public const string DCPHONGGAI_FIELD ="DCPhongGai";
		public const string DCPHONGTRAI_FIELD ="DCPhongTrai";
		public const string DCBANGHE_FIELD ="DCBanGhe";
		public const string DCNHABAT_FIELD ="DCNhaBat";
		public const string DCCONGHOA_FIELD ="DCCongHoa";
		public const string DCPHAO_FIELD ="DCPhao";
		public const string DCCHUHY_FIELD ="DCChuHy";
		public const string DCHOATAY_FIELD ="DCHoaTay";
		public const string DCHOACAUTHANG_FIELD ="DCHoaCauThang";
		public const string DCHOABANTK_FIELD ="DCHoaBanTK";
		public const string DCHOAPC_FIELD ="DCHoaPC";

		#endregion
		
		#region Private Variables
					private Int32 _ID;
		private String _username;
		private String _pass;
		private String _TenRe;
		private String _DCRe;
		private String _TenDau;
		private String _DCDau;
		private String _tgDamNgo;
		private String _tgAnHoiDuKien;
		private String _tgAnHoi;
		private String _tgThanhHonDuKien;
		private String _tgThanhHon;
		private String _DDTC;
		private Boolean _AHTrap;
		private Boolean _AHHD;
		private Boolean _AHAlbum;
		private Int32 _AHXe4;
		private Int32 _AHXe16;
		private Int32 _AHXe29;
		private Int32 _AHPhong;
		private Int32 _AHBanAnHoi;
		private Int32 _AHBanGhe;
		private Int32 _AHBat;
		private Int32 _AHCongHoa;
		private Int32 _AHPhao;
		private Int32 _AHChuHy;
		private Int32 _AHDoAnHoi;
		private Int32 _AHDoiTrap;
		private Int32 _AHDoiTrapNu;
		private Boolean _DCXinDau;
		private Boolean _DCHD;
		private Boolean _DCAlbum;
		private Int32 _DCXe4;
		private Int32 _DCXe16;
		private Int32 _DCXe29;
		private Int32 _DCPhongGai;
		private Int32 _DCPhongTrai;
		private Int32 _DCBanGhe;
		private Int32 _DCNhaBat;
		private Int32 _DCCongHoa;
		private Int32 _DCPhao;
		private Int32 _DCChuHy;
		private Int32 _DCHoaTay;
		private Boolean _DCHoaCauThang;
		private Boolean _DCHoaBanTK;
		private Boolean _DCHoaPC;

		#endregion

		#region Public Properties
					public Int32 ID
		{
			get
			{
				return _ID;
			}
			set
			{
				_ID = value;
			}
		}
		public String username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
			}
		}
		public String pass
		{
			get
			{
				return _pass;
			}
			set
			{
				_pass = value;
			}
		}
		public String TenRe
		{
			get
			{
				return _TenRe;
			}
			set
			{
				_TenRe = value;
			}
		}
		public String DCRe
		{
			get
			{
				return _DCRe;
			}
			set
			{
				_DCRe = value;
			}
		}
		public String TenDau
		{
			get
			{
				return _TenDau;
			}
			set
			{
				_TenDau = value;
			}
		}
		public String DCDau
		{
			get
			{
				return _DCDau;
			}
			set
			{
				_DCDau = value;
			}
		}
		public String tgDamNgo
		{
			get
			{
				return _tgDamNgo;
			}
			set
			{
				_tgDamNgo = value;
			}
		}
		public String tgAnHoiDuKien
		{
			get
			{
				return _tgAnHoiDuKien;
			}
			set
			{
				_tgAnHoiDuKien = value;
			}
		}
		public String tgAnHoi
		{
			get
			{
				return _tgAnHoi;
			}
			set
			{
				_tgAnHoi = value;
			}
		}
		public String tgThanhHonDuKien
		{
			get
			{
				return _tgThanhHonDuKien;
			}
			set
			{
				_tgThanhHonDuKien = value;
			}
		}
		public String tgThanhHon
		{
			get
			{
				return _tgThanhHon;
			}
			set
			{
				_tgThanhHon = value;
			}
		}
		public String DDTC
		{
			get
			{
				return _DDTC;
			}
			set
			{
				_DDTC = value;
			}
		}
		public Boolean AHTrap
		{
			get
			{
				return _AHTrap;
			}
			set
			{
				_AHTrap = value;
			}
		}
		public Boolean AHHD
		{
			get
			{
				return _AHHD;
			}
			set
			{
				_AHHD = value;
			}
		}
		public Boolean AHAlbum
		{
			get
			{
				return _AHAlbum;
			}
			set
			{
				_AHAlbum = value;
			}
		}
		public Int32 AHXe4
		{
			get
			{
				return _AHXe4;
			}
			set
			{
				_AHXe4 = value;
			}
		}
		public Int32 AHXe16
		{
			get
			{
				return _AHXe16;
			}
			set
			{
				_AHXe16 = value;
			}
		}
		public Int32 AHXe29
		{
			get
			{
				return _AHXe29;
			}
			set
			{
				_AHXe29 = value;
			}
		}
		public Int32 AHPhong
		{
			get
			{
				return _AHPhong;
			}
			set
			{
				_AHPhong = value;
			}
		}
		public Int32 AHBanAnHoi
		{
			get
			{
				return _AHBanAnHoi;
			}
			set
			{
				_AHBanAnHoi = value;
			}
		}
		public Int32 AHBanGhe
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
		public Int32 AHBat
		{
			get
			{
				return _AHBat;
			}
			set
			{
				_AHBat = value;
			}
		}
		public Int32 AHCongHoa
		{
			get
			{
				return _AHCongHoa;
			}
			set
			{
				_AHCongHoa = value;
			}
		}
		public Int32 AHPhao
		{
			get
			{
				return _AHPhao;
			}
			set
			{
				_AHPhao = value;
			}
		}
		public Int32 AHChuHy
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
		public Int32 AHDoAnHoi
		{
			get
			{
				return _AHDoAnHoi;
			}
			set
			{
				_AHDoAnHoi = value;
			}
		}
		public Int32 AHDoiTrap
		{
			get
			{
				return _AHDoiTrap;
			}
			set
			{
				_AHDoiTrap = value;
			}
		}
		public Int32 AHDoiTrapNu
		{
			get
			{
				return _AHDoiTrapNu;
			}
			set
			{
				_AHDoiTrapNu = value;
			}
		}
		public Boolean DCXinDau
		{
			get
			{
				return _DCXinDau;
			}
			set
			{
				_DCXinDau = value;
			}
		}
		public Boolean DCHD
		{
			get
			{
				return _DCHD;
			}
			set
			{
				_DCHD = value;
			}
		}
		public Boolean DCAlbum
		{
			get
			{
				return _DCAlbum;
			}
			set
			{
				_DCAlbum = value;
			}
		}
		public Int32 DCXe4
		{
			get
			{
				return _DCXe4;
			}
			set
			{
				_DCXe4 = value;
			}
		}
		public Int32 DCXe16
		{
			get
			{
				return _DCXe16;
			}
			set
			{
				_DCXe16 = value;
			}
		}
		public Int32 DCXe29
		{
			get
			{
				return _DCXe29;
			}
			set
			{
				_DCXe29 = value;
			}
		}
		public Int32 DCPhongGai
		{
			get
			{
				return _DCPhongGai;
			}
			set
			{
				_DCPhongGai = value;
			}
		}
		public Int32 DCPhongTrai
		{
			get
			{
				return _DCPhongTrai;
			}
			set
			{
				_DCPhongTrai = value;
			}
		}
		public Int32 DCBanGhe
		{
			get
			{
				return _DCBanGhe;
			}
			set
			{
				_DCBanGhe = value;
			}
		}
		public Int32 DCNhaBat
		{
			get
			{
				return _DCNhaBat;
			}
			set
			{
				_DCNhaBat = value;
			}
		}
		public Int32 DCCongHoa
		{
			get
			{
				return _DCCongHoa;
			}
			set
			{
				_DCCongHoa = value;
			}
		}
		public Int32 DCPhao
		{
			get
			{
				return _DCPhao;
			}
			set
			{
				_DCPhao = value;
			}
		}
		public Int32 DCChuHy
		{
			get
			{
				return _DCChuHy;
			}
			set
			{
				_DCChuHy = value;
			}
		}
		public Int32 DCHoaTay
		{
			get
			{
				return _DCHoaTay;
			}
			set
			{
				_DCHoaTay = value;
			}
		}
		public Boolean DCHoaCauThang
		{
			get
			{
				return _DCHoaCauThang;
			}
			set
			{
				_DCHoaCauThang = value;
			}
		}
		public Boolean DCHoaBanTK
		{
			get
			{
				return _DCHoaBanTK;
			}
			set
			{
				_DCHoaBanTK = value;
			}
		}
		public Boolean DCHoaPC
		{
			get
			{
				return _DCHoaPC;
			}
			set
			{
				_DCHoaPC = value;
			}
		}

        #endregion

	}
}
