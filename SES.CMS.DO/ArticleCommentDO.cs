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
   public class ArticleCommentDO
    {

        /// <summary>
        /// Summary description for ArticleCommentDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string COMMENTID_FIELD ="CommentID";
		public const string ARTICLEID_FIELD ="ArticleID";
		public const string COMMENTDETAIL_FIELD ="CommentDetail";
		public const string USEREMAIL_FIELD ="UserEmail";
		public const string ARTICLESTAR_FIELD ="ArticleStar";
		public const string ISACCEPT_FIELD ="IsAccept";

		#endregion
		
		#region Private Variables
					private Int32 _CommentID;
		private Int32 _ArticleID;
		private String _CommentDetail;
		private String _UserEmail;
		private Int32 _ArticleStar;
		private Boolean _IsAccept;

		#endregion

		#region Public Properties
					public Int32 CommentID
		{
			get
			{
				return _CommentID;
			}
			set
			{
				_CommentID = value;
			}
		}
		public Int32 ArticleID
		{
			get
			{
				return _ArticleID;
			}
			set
			{
				_ArticleID = value;
			}
		}
		public String CommentDetail
		{
			get
			{
				return _CommentDetail;
			}
			set
			{
				_CommentDetail = value;
			}
		}
		public String UserEmail
		{
			get
			{
				return _UserEmail;
			}
			set
			{
				_UserEmail = value;
			}
		}
		public Int32 ArticleStar
		{
			get
			{
				return _ArticleStar;
			}
			set
			{
				_ArticleStar = value;
			}
		}
		public Boolean IsAccept
		{
			get
			{
				return _IsAccept;
			}
			set
			{
				_IsAccept = value;
			}
		}

        #endregion

	}
}
