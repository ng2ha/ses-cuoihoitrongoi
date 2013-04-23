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
/// Summary description for cmsProductBL
/// </summary>
namespace SES.CMS.BL 
{
    public class cmsProductBL 
    {
    	#region Private Variables
		cmsProductDAL objcmsProductDAL;
		#endregion
		
        #region Public Constructors
        public cmsProductBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsProductDAL=new cmsProductDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsProductDO objcmsProductDO)
        {
            return objcmsProductDAL.Insert(objcmsProductDO);
        }

        public int Update(cmsProductDO objcmsProductDO)
        {
             return objcmsProductDAL.Update(objcmsProductDO);

        }

        public int Delete(cmsProductDO objcmsProductDO)
        {
             return objcmsProductDAL.Delete(objcmsProductDO);

        }

         public int DeleteAll()
        {
             return objcmsProductDAL.DeleteAll();
        }

        public cmsProductDO Select(cmsProductDO objcmsProductDO)
        {
            return objcmsProductDAL.Select(objcmsProductDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsProductDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsProductDAL.SelectAll();
        }
        public DataTable SelectOne(int i)
        {
            return objcmsProductDAL.SelectOne(i);
        }


     
#endregion          
    
    
        public DataTable SelectByHome()
        {
            return objcmsProductDAL.SelectByHome();
        }
    }

}
