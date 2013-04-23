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
/// Summary description for cmsThongTinKHBL
/// </summary>
namespace SES.CMS.BL 
{
    public class cmsThongTinKHBL 
    {
    	#region Private Variables
		cmsThongTinKHDAL objcmsThongTinKHDAL;
		#endregion
		
        #region Public Constructors
        public cmsThongTinKHBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsThongTinKHDAL=new cmsThongTinKHDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            return objcmsThongTinKHDAL.Insert(objcmsThongTinKHDO);
        }

        public int createKH(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            return objcmsThongTinKHDAL.createKH(objcmsThongTinKHDO);
        }

        public int Update(cmsThongTinKHDO objcmsThongTinKHDO)
        {
             return objcmsThongTinKHDAL.Update(objcmsThongTinKHDO);

        }

        public int Delete(cmsThongTinKHDO objcmsThongTinKHDO)
        {
             return objcmsThongTinKHDAL.Delete(objcmsThongTinKHDO);

        }

         public int DeleteAll()
        {
             return objcmsThongTinKHDAL.DeleteAll();
        }

        public cmsThongTinKHDO Select(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            return objcmsThongTinKHDAL.Select(objcmsThongTinKHDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsThongTinKHDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsThongTinKHDAL.SelectAll();
        }

        public DataTable SelectNonAll()
        {
            return objcmsThongTinKHDAL.SelectNonAll();
        }

        public int createUser(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            return objcmsThongTinKHDAL.createUser(objcmsThongTinKHDO);
        }

        public DataTable getNonServ()
        {
            return objcmsThongTinKHDAL.getNonServ();
        }

        public DataTable getServ()
        {
            return objcmsThongTinKHDAL.getServ();
        }

        public DataTable selectUser(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            return objcmsThongTinKHDAL.selectUser(objcmsThongTinKHDO);
        }
     
#endregion          
    
    }

}
