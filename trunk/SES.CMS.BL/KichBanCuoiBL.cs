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
/// Summary description for KichBanCuoiBL
/// </summary>
namespace SES.CMS.BL 
{
    public class KichBanCuoiBL 
    {
    	#region Private Variables
		KichBanCuoiDAL objKichBanCuoiDAL;
		#endregion
		
        #region Public Constructors
        public KichBanCuoiBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objKichBanCuoiDAL=new KichBanCuoiDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(KichBanCuoiDO objKichBanCuoiDO)
        {
            return objKichBanCuoiDAL.Insert(objKichBanCuoiDO);
        }

        public int Update(KichBanCuoiDO objKichBanCuoiDO)
        {
             return objKichBanCuoiDAL.Update(objKichBanCuoiDO);

        }

        public int Delete(KichBanCuoiDO objKichBanCuoiDO)
        {
             return objKichBanCuoiDAL.Delete(objKichBanCuoiDO);

        }

         public int DeleteAll()
        {
             return objKichBanCuoiDAL.DeleteAll();
        }

        public KichBanCuoiDO Select(KichBanCuoiDO objKichBanCuoiDO)
        {
            return objKichBanCuoiDAL.Select(objKichBanCuoiDO);
        }

        public ArrayList SelectAll1( )
        {
         return objKichBanCuoiDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objKichBanCuoiDAL.SelectAll();
        }


     
#endregion          
    
    
        public KichBanCuoiDO SelectByYC(int p)
        {
            return objKichBanCuoiDAL.SelectByYC(p);
        }
    }

}
