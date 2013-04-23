/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using SES.CMS.DO;
/// <summary>
/// Summary description for ArticleCommentDAL
/// </summary>
namespace SES.CMS.DAL 
{
    
    public class ArticleCommentDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public ArticleCommentDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(ArticleCommentDO objArticleCommentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spArticleComment_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objArticleCommentDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CommentDetail", SqlDbType.NText);
Sqlparam.Value = objArticleCommentDO.CommentDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@UserEmail", SqlDbType.NVarChar);
Sqlparam.Value = objArticleCommentDO.UserEmail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArticleStar", SqlDbType.Int);
Sqlparam.Value = objArticleCommentDO.ArticleStar;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsAccept", SqlDbType.Bit);
Sqlparam.Value = objArticleCommentDO.IsAccept;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ArticleCommentDO objArticleCommentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spArticleComment_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CommentID", SqlDbType.Int);
Sqlparam.Value = objArticleCommentDO.CommentID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objArticleCommentDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CommentDetail", SqlDbType.NText);
Sqlparam.Value = objArticleCommentDO.CommentDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@UserEmail", SqlDbType.NVarChar);
Sqlparam.Value = objArticleCommentDO.UserEmail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArticleStar", SqlDbType.Int);
Sqlparam.Value = objArticleCommentDO.ArticleStar;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsAccept", SqlDbType.Bit);
Sqlparam.Value = objArticleCommentDO.IsAccept;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(ArticleCommentDO objArticleCommentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spArticleComment_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CommentID", SqlDbType.Int);
Sqlparam.Value = objArticleCommentDO.CommentID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spArticleComment_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ArticleCommentDO Select(ArticleCommentDO objArticleCommentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spArticleComment_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@CommentID", SqlDbType.Int);
Sqlparam.Value = objArticleCommentDO.CommentID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["CommentID"]))
objArticleCommentDO.CommentID=Convert.ToInt32(dr["CommentID"]);
if(!Convert.IsDBNull(dr["ArticleID"]))
objArticleCommentDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["CommentDetail"]))
objArticleCommentDO.CommentDetail=Convert.ToString(dr["CommentDetail"]);
if(!Convert.IsDBNull(dr["UserEmail"]))
objArticleCommentDO.UserEmail=Convert.ToString(dr["UserEmail"]);
if(!Convert.IsDBNull(dr["ArticleStar"]))
objArticleCommentDO.ArticleStar=Convert.ToInt32(dr["ArticleStar"]);
if(!Convert.IsDBNull(dr["IsAccept"]))
objArticleCommentDO.IsAccept=Convert.ToBoolean(dr["IsAccept"]);

            }
             return objArticleCommentDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spArticleComment_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrArticleCommentDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
ArticleCommentDO objArticleCommentDO= new ArticleCommentDO();
if(!Convert.IsDBNull(dr["CommentID"]))
objArticleCommentDO.CommentID=Convert.ToInt32(dr["CommentID"]);
if(!Convert.IsDBNull(dr["ArticleID"]))
objArticleCommentDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["CommentDetail"]))
objArticleCommentDO.CommentDetail=Convert.ToString(dr["CommentDetail"]);
if(!Convert.IsDBNull(dr["UserEmail"]))
objArticleCommentDO.UserEmail=Convert.ToString(dr["UserEmail"]);
if(!Convert.IsDBNull(dr["ArticleStar"]))
objArticleCommentDO.ArticleStar=Convert.ToInt32(dr["ArticleStar"]);
if(!Convert.IsDBNull(dr["IsAccept"]))
objArticleCommentDO.IsAccept=Convert.ToBoolean(dr["IsAccept"]);
arrArticleCommentDO.Add(objArticleCommentDO);
}
            }
               return arrArticleCommentDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spArticleComment_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectByArticle(int id)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spArticleComment_GetByArticle";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
            Sqlparam.Value = id;
            Sqlcomm.Parameters.Add(Sqlparam);


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
    }

}
