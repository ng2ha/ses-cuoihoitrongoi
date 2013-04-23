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
/// Summary description for cmsProductLineDAL
/// </summary>
namespace SES.CMS.DAL 
{
    
    public class cmsProductLineDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public cmsProductLineDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(cmsProductLineDO objcmsProductLineDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProductLine_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductLineDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsProductLineDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProducLineImg", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductLineDO.ProducLineImg;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objcmsProductLineDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsProductLineDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsProductLineDO objcmsProductLineDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProductLine_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ProductLineID", SqlDbType.Int);
Sqlparam.Value = objcmsProductLineDO.ProductLineID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductLineDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsProductLineDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProducLineImg", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductLineDO.ProducLineImg;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objcmsProductLineDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsProductLineDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(cmsProductLineDO objcmsProductLineDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProductLine_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ProductLineID", SqlDbType.Int);
Sqlparam.Value = objcmsProductLineDO.ProductLineID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProductLine_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsProductLineDO Select(cmsProductLineDO objcmsProductLineDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProductLine_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ProductLineID", SqlDbType.Int);
Sqlparam.Value = objcmsProductLineDO.ProductLineID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ProductLineID"]))
objcmsProductLineDO.ProductLineID=Convert.ToInt32(dr["ProductLineID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsProductLineDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsProductLineDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ProducLineImg"]))
objcmsProductLineDO.ProducLineImg=Convert.ToString(dr["ProducLineImg"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objcmsProductLineDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objcmsProductLineDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);

            }
             return objcmsProductLineDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProductLine_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsProductLineDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
cmsProductLineDO objcmsProductLineDO= new cmsProductLineDO();
if(!Convert.IsDBNull(dr["ProductLineID"]))
objcmsProductLineDO.ProductLineID=Convert.ToInt32(dr["ProductLineID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsProductLineDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsProductLineDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ProducLineImg"]))
objcmsProductLineDO.ProducLineImg=Convert.ToString(dr["ProducLineImg"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objcmsProductLineDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objcmsProductLineDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);
arrcmsProductLineDO.Add(objcmsProductLineDO);
}
            }
               return arrcmsProductLineDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProductLine_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectByCategoryID(int CategoryID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsProductLine_GetByCategoryID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
            Sqlparam.Value = CategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectOne(int i)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsProductLine_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ProductLineID", SqlDbType.Int);
            Sqlparam.Value = i;
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
