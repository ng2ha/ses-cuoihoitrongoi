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
   public class cmsProductLineDO
    {

        /// <summary>
        /// Summary description for cmsProductLineDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string PRODUCTLINEID_FIELD ="ProductLineID";
		public const string TITLE_FIELD ="Title";
		public const string DESCRIPTION_FIELD ="Description";
		public const string PRODUCLINEIMG_FIELD ="ProducLineImg";
		public const string METATAG_FIELD ="MetaTag";
		public const string CATEGORYID_FIELD ="CategoryID";

		#endregion
		
		#region Private Variables
					private Int32 _ProductLineID;
		private String _Title;
		private String _Description;
		private String _ProducLineImg;
		private String _MetaTag;
		private Int32 _CategoryID;

		#endregion

		#region Public Properties
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
		public String ProducLineImg
		{
			get
			{
				return _ProducLineImg;
			}
			set
			{
				_ProducLineImg = value;
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
		public Int32 CategoryID
		{
			get
			{
				return _CategoryID;
			}
			set
			{
				_CategoryID = value;
			}
		}

        #endregion

	}
}
