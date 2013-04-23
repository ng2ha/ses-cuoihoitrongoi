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
/// Summary description for cmsProductLineBL
/// </summary>
namespace SES.CMS.BL 
{
    public class cmsProductLineBL 
    {
    	#region Private Variables
		cmsProductLineDAL objcmsProductLineDAL;
		#endregion
		
        #region Public Constructors
        public cmsProductLineBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsProductLineDAL=new cmsProductLineDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsProductLineDO objcmsProductLineDO)
        {
            return objcmsProductLineDAL.Insert(objcmsProductLineDO);
        }

        public int Update(cmsProductLineDO objcmsProductLineDO)
        {
             return objcmsProductLineDAL.Update(objcmsProductLineDO);

        }

        public int Delete(cmsProductLineDO objcmsProductLineDO)
        {
             return objcmsProductLineDAL.Delete(objcmsProductLineDO);

        }

         public int DeleteAll()
        {
             return objcmsProductLineDAL.DeleteAll();
        }

        public cmsProductLineDO Select(cmsProductLineDO objcmsProductLineDO)
        {
            return objcmsProductLineDAL.Select(objcmsProductLineDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsProductLineDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsProductLineDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectByCategoryID(int CategoryID)
        {
            return objcmsProductLineDAL.SelectByCategoryID(CategoryID);
        }

        public DataTable SelectOne(int i)
        {
            return objcmsProductLineDAL.SelectOne(i);
        }
    }

}
