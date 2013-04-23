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
/// Summary description for cmsProductDAL
/// </summary>
namespace SES.CMS.DAL 
{
    
    public class cmsProductDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public cmsProductDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(cmsProductDO objcmsProductDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProduct_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsProductDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg1", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg1;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg2", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg2;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg3", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg3;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg4", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg4;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objcmsProductDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsHompage", SqlDbType.Bit);
Sqlparam.Value = objcmsProductDO.IsHompage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductLineID", SqlDbType.Int);
Sqlparam.Value = objcmsProductDO.ProductLineID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsProductDO objcmsProductDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProduct_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ProductID", SqlDbType.Int);
Sqlparam.Value = objcmsProductDO.ProductID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsProductDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg1", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg1;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg2", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg2;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg3", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg3;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductImg4", SqlDbType.NVarChar);
Sqlparam.Value = objcmsProductDO.ProductImg4;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objcmsProductDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsHompage", SqlDbType.Bit);
Sqlparam.Value = objcmsProductDO.IsHompage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ProductLineID", SqlDbType.Int);
Sqlparam.Value = objcmsProductDO.ProductLineID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(cmsProductDO objcmsProductDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProduct_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ProductID", SqlDbType.Int);
Sqlparam.Value = objcmsProductDO.ProductID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProduct_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsProductDO Select(cmsProductDO objcmsProductDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProduct_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ProductID", SqlDbType.Int);
Sqlparam.Value = objcmsProductDO.ProductID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ProductID"]))
objcmsProductDO.ProductID=Convert.ToInt32(dr["ProductID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsProductDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsProductDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ProductImg1"]))
objcmsProductDO.ProductImg1=Convert.ToString(dr["ProductImg1"]);
if(!Convert.IsDBNull(dr["ProductImg2"]))
objcmsProductDO.ProductImg2=Convert.ToString(dr["ProductImg2"]);
if(!Convert.IsDBNull(dr["ProductImg3"]))
objcmsProductDO.ProductImg3=Convert.ToString(dr["ProductImg3"]);
if(!Convert.IsDBNull(dr["ProductImg4"]))
objcmsProductDO.ProductImg4=Convert.ToString(dr["ProductImg4"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objcmsProductDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["IsHompage"]))
objcmsProductDO.IsHompage=Convert.ToBoolean(dr["IsHompage"]);
if(!Convert.IsDBNull(dr["ProductLineID"]))
objcmsProductDO.ProductLineID=Convert.ToInt32(dr["ProductLineID"]);

            }
             return objcmsProductDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProduct_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsProductDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
cmsProductDO objcmsProductDO= new cmsProductDO();
if(!Convert.IsDBNull(dr["ProductID"]))
objcmsProductDO.ProductID=Convert.ToInt32(dr["ProductID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsProductDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsProductDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ProductImg1"]))
objcmsProductDO.ProductImg1=Convert.ToString(dr["ProductImg1"]);
if(!Convert.IsDBNull(dr["ProductImg2"]))
objcmsProductDO.ProductImg2=Convert.ToString(dr["ProductImg2"]);
if(!Convert.IsDBNull(dr["ProductImg3"]))
objcmsProductDO.ProductImg3=Convert.ToString(dr["ProductImg3"]);
if(!Convert.IsDBNull(dr["ProductImg4"]))
objcmsProductDO.ProductImg4=Convert.ToString(dr["ProductImg4"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objcmsProductDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["IsHompage"]))
objcmsProductDO.IsHompage=Convert.ToBoolean(dr["IsHompage"]);
if(!Convert.IsDBNull(dr["ProductLineID"]))
objcmsProductDO.ProductLineID=Convert.ToInt32(dr["ProductLineID"]);
arrcmsProductDO.Add(objcmsProductDO);
}
            }
               return arrcmsProductDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsProduct_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectByHome()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsProduct_GetHome";

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
            Sqlcomm.CommandText = "spcmsProduct_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ProductID", SqlDbType.Int);
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
