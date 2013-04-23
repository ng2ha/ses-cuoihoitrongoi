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
   public class cmsProductDO
    {

        /// <summary>
        /// Summary description for cmsProductDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string PRODUCTID_FIELD ="ProductID";
		public const string TITLE_FIELD ="Title";
		public const string DESCRIPTION_FIELD ="Description";
		public const string PRODUCTIMG1_FIELD ="ProductImg1";
		public const string PRODUCTIMG2_FIELD ="ProductImg2";
		public const string PRODUCTIMG3_FIELD ="ProductImg3";
		public const string PRODUCTIMG4_FIELD ="ProductImg4";
		public const string METATAG_FIELD ="MetaTag";
		public const string ISHOMPAGE_FIELD ="IsHompage";
		public const string PRODUCTLINEID_FIELD ="ProductLineID";

		#endregion
		
		#region Private Variables
					private Int32 _ProductID;
		private String _Title;
		private String _Description;
		private String _ProductImg1;
		private String _ProductImg2;
		private String _ProductImg3;
		private String _ProductImg4;
		private String _MetaTag;
		private Boolean _IsHompage;
		private Int32 _ProductLineID;

		#endregion

		#region Public Properties
					public Int32 ProductID
		{
			get
			{
				return _ProductID;
			}
			set
			{
				_ProductID = value;
			}
		}
		public String Title
		{
			get
			{
				return _Title;
			}
			set
			{
				_Title = value;
			}
		}
		public String Description
		{
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
			}
		}
		public String ProductImg1
		{
			get
			{
				return _ProductImg1;
			}
			set
			{
				_ProductImg1 = value;
			}
		}
		public String ProductImg2
		{
			get
			{
				return _ProductImg2;
			}
			set
			{
				_ProductImg2 = value;
			}
		}
		public String ProductImg3
		{
			get
			{
				return _ProductImg3;
			}
			set
			{
				_ProductImg3 = value;
			}
		}
		public String ProductImg4
		{
			get
			{
				return _ProductImg4;
			}
			set
			{
				_ProductImg4 = value;
			}
		}
		public String MetaTag
		{
			get
			{
				return _MetaTag;
			}
			set
			{
				_MetaTag = value;
			}
		}
		public Boolean IsHompage
		{
			get
			{
				return _IsHompage;
			}
			set
			{
				_IsHompage = value;
			}
		}
		public Int32 ProductLineID
		{
			get
			{
				return _ProductLineID;
			}
			set
			{
				_ProductLineID = value;
			}
		}

        #endregion

	}
}
