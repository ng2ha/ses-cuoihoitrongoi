/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;

using SES.CMS.DAL;
using SES.CMS.DO;
/// <summary>
/// Summary description for ArticleCommentBL
/// </summary>
namespace SES.CMS.BL 
{
    public class ArticleCommentBL 
    {
    	#region Private Variables
		ArticleCommentDAL objArticleCommentDAL;
		#endregion
		
        #region Public Constructors
        public ArticleCommentBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objArticleCommentDAL=new ArticleCommentDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ArticleCommentDO objArticleCommentDO)
        {
            return objArticleCommentDAL.Insert(objArticleCommentDO);
        }

        public int Update(ArticleCommentDO objArticleCommentDO)
        {
             return objArticleCommentDAL.Update(objArticleCommentDO);

        }

        public int Delete(ArticleCommentDO objArticleCommentDO)
        {
             return objArticleCommentDAL.Delete(objArticleCommentDO);

        }

         public int DeleteAll()
        {
             return objArticleCommentDAL.DeleteAll();
        }

        public ArticleCommentDO Select(ArticleCommentDO objArticleCommentDO)
        {
            return objArticleCommentDAL.Select(objArticleCommentDO);
        }

        public ArrayList SelectAll1( )
        {
         return objArticleCommentDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objArticleCommentDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectByArticle(int id)
        {
            return objArticleCommentDAL.SelectByArticle(id);
        }
    }

}
