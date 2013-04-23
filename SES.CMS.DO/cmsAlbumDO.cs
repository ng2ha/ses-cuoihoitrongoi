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
   public class cmsAlbumDO
    {

        /// <summary>
        /// Summary description for cmsAlbumDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ALBUMID_FIELD ="AlbumID";
		public const string TITLE_FIELD ="Title";
		public const string ORDERID_FIELD ="OrderID";
		public const string DESCRIPTION_FIELD ="Description";
        public const string CATEGORYID_FIELD = "CategoryID";
        public const string ANHKIEU_FIELD = "AnhKieu";
        public const string ANHALBUM = "AnhAlbum";

		#endregion
		
		#region Private Variables
					private Int32 _AlbumID;
		private String _Title;
		private Int32 _OrderID;
		private String _Description;
		private Int32 _CategoryID;
        private String _AnhKieu;
        private String _AnhAlbum;

		#endregion

		#region Public Properties
					public Int32 AlbumID
		{
			get
			{
				return _AlbumID;
			}
			set
			{
				_AlbumID = value;
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
		public Int32 OrderID
		{
			get
			{
				return _OrderID;
			}
			set
			{
				_OrderID = value;
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

        public String AnhKieu
        {
            get
            {
                return _AnhKieu;
            }
            set
            {
                _AnhKieu = value;
            }
        }

        public String AnhAlbum
        {
            get
            {
                return _AnhAlbum;
            }
            set
            {
                _AnhAlbum = value;
            }
        }
        #endregion

	}
}
