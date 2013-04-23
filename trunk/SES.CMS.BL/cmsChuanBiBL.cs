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
/// Summary description for cmsChuanBiBL
/// </summary>
namespace SES.CMS.BL 
{
    public class cmsChuanBiBL 
    {
    	#region Private Variables
		cmsChuanBiDAL objcmsChuanBiDAL;
		#endregion
		
        #region Public Constructors
        public cmsChuanBiBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsChuanBiDAL=new cmsChuanBiDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsChuanBiDO objcmsChuanBiDO)
        {
            return objcmsChuanBiDAL.Insert(objcmsChuanBiDO);
        }

        public int Update(cmsChuanBiDO objcmsChuanBiDO)
        {
             return objcmsChuanBiDAL.Update(objcmsChuanBiDO);

        }

        public int Delete(cmsChuanBiDO objcmsChuanBiDO)
        {
             return objcmsChuanBiDAL.Delete(objcmsChuanBiDO);

        }

        public cmsChuanBiDO selectFK1(cmsChuanBiDO cmsDO)
        {
            return objcmsChuanBiDAL.selectFK1(cmsDO);
        }

        public DataTable selectFK(cmsChuanBiDO cmsDO)
        {
            return objcmsChuanBiDAL.selectFK(cmsDO);
        }

         public int DeleteAll()
        {
             return objcmsChuanBiDAL.DeleteAll();
        }

        public cmsChuanBiDO Select(cmsChuanBiDO objcmsChuanBiDO)
        {
            return objcmsChuanBiDAL.Select(objcmsChuanBiDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsChuanBiDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsChuanBiDAL.SelectAll();
        }


     
#endregion          
    
    }

}
