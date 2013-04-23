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
   public class cmsChuanBiDO
    {

        /// <summary>
        /// Summary description for cmsChuanBiDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ID_FIELD ="ID";
		public const string IDFK_FIELD ="IDFK";
		public const string TD1_FIELD ="td1";
		public const string TD2_FIELD ="td2";
		public const string TD3_FIELD ="td3";
		public const string TD4_FIELD ="td4";
		public const string TD5_FIELD ="td5";
		public const string TD6_FIELD ="td6";
		public const string TD7_FIELD ="td7";
		public const string TD8_FIELD ="td8";
		public const string TD9_FIELD ="td9";
		public const string TD10_FIELD ="td10";
		public const string TD11_FIELD ="td11";
		public const string TD12_FIELD ="td12";

		#endregion
		
		#region Private Variables
					private Int32 _ID;
		private Int32 _IDFK;
		private String _td1;
		private String _td2;
		private String _td3;
		private String _td4;
		private String _td5;
		private String _td6;
		private String _td7;
		private String _td8;
		private String _td9;
		private String _td10;
		private String _td11;
		private String _td12;

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
		public Int32 IDFK
		{
			get
			{
				return _IDFK;
			}
			set
			{
				_IDFK = value;
			}
		}
		public String td1
		{
			get
			{
				return _td1;
			}
			set
			{
				_td1 = value;
			}
		}
		public String td2
		{
			get
			{
				return _td2;
			}
			set
			{
				_td2 = value;
			}
		}
		public String td3
		{
			get
			{
				return _td3;
			}
			set
			{
				_td3 = value;
			}
		}
		public String td4
		{
			get
			{
				return _td4;
			}
			set
			{
				_td4 = value;
			}
		}
		public String td5
		{
			get
			{
				return _td5;
			}
			set
			{
				_td5 = value;
			}
		}
		public String td6
		{
			get
			{
				return _td6;
			}
			set
			{
				_td6 = value;
			}
		}
		public String td7
		{
			get
			{
				return _td7;
			}
			set
			{
				_td7 = value;
			}
		}
		public String td8
		{
			get
			{
				return _td8;
			}
			set
			{
				_td8 = value;
			}
		}
		public String td9
		{
			get
			{
				return _td9;
			}
			set
			{
				_td9 = value;
			}
		}
		public String td10
		{
			get
			{
				return _td10;
			}
			set
			{
				_td10 = value;
			}
		}
		public String td11
		{
			get
			{
				return _td11;
			}
			set
			{
				_td11 = value;
			}
		}
		public String td12
		{
			get
			{
				return _td12;
			}
			set
			{
				_td12 = value;
			}
		}

        #endregion

	}
}
