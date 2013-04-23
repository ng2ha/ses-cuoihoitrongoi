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
   public class ClientLoginDO
    {

        /// <summary>
        /// Summary description for ClientLoginDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CLIENTLOGINID_FIELD ="ClientLoginID";
		public const string USERNAME_FIELD ="Username";
		public const string PASSWORD_FIELD ="Password";
		public const string CLIENTNAME_FIELD ="ClientName";
		public const string DETAILINFO_FIELD ="DetailInfo";
        public const string FTPSERVER_FIELD = "FTPServer";

		#endregion
		
		#region Private Variables
					private Int32 _ClientLoginID;
		private String _Username;
		private String _Password;
		private String _ClientName;
		private String _DetailInfo;
        private string _FTPServer;

		#endregion

		#region Public Properties
					public Int32 ClientLoginID
		{
			get
			{
				return _ClientLoginID;
			}
			set
			{
				_ClientLoginID = value;
			}
		}
		public String Username
		{
			get
			{
				return _Username;
			}
			set
			{
				_Username = value;
			}
		}

        public String FTPServer
        {
            get
            {
                return _FTPServer;
            }
            set
            {
                _FTPServer = value;
            }
        }
		public String Password
		{
			get
			{
				return _Password;
			}
			set
			{
				_Password = value;
			}
		}
		public String ClientName
		{
			get
			{
				return _ClientName;
			}
			set
			{
				_ClientName = value;
			}
		}
		public String DetailInfo
		{
			get
			{
				return _DetailInfo;
			}
			set
			{
				_DetailInfo = value;
			}
		}

        #endregion

	}
}
