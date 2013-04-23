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
/// Summary description for YeuCauKBBL
/// </summary>
namespace SES.CMS.BL 
{
    public class YeuCauKBBL 
    {
    	#region Private Variables
		YeuCauKBDAL objYeuCauKBDAL;
		#endregion
		
        #region Public Constructors
        public YeuCauKBBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objYeuCauKBDAL=new YeuCauKBDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(YeuCauKBDO objYeuCauKBDO)
        {
            return objYeuCauKBDAL.Insert(objYeuCauKBDO);
        }

        public int Update(YeuCauKBDO objYeuCauKBDO)
        {
             return objYeuCauKBDAL.Update(objYeuCauKBDO);

        }

        public int Delete(YeuCauKBDO objYeuCauKBDO)
        {
             return objYeuCauKBDAL.Delete(objYeuCauKBDO);

        }

         public int DeleteAll()
        {
             return objYeuCauKBDAL.DeleteAll();
        }

        public YeuCauKBDO Select(YeuCauKBDO objYeuCauKBDO)
        {
            return objYeuCauKBDAL.Select(objYeuCauKBDO);
        }

        public ArrayList SelectAll1( )
        {
         return objYeuCauKBDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objYeuCauKBDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectByAccept(int accept)
        {
            return objYeuCauKBDAL.SelectByAccept(accept);
        }

        public DataTable SelectLogin(string username, string password)
        {
            return objYeuCauKBDAL.SelectLogin(username, password);
        }
    }

}
