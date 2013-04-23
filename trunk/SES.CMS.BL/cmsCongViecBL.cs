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
/// Summary description for cmsCongViecBL
/// </summary>
namespace SES.CMS.BL 
{
    public class cmsCongViecBL 
    {
    	#region Private Variables
		cmsCongViecDAL objcmsCongViecDAL;
		#endregion
		
        #region Public Constructors
        public cmsCongViecBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsCongViecDAL=new cmsCongViecDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsCongViecDO objcmsCongViecDO)
        {
            return objcmsCongViecDAL.Insert(objcmsCongViecDO);
        }

        public DataTable selectFK(cmsCongViecDO objcmsCongViecDO)
        {
            return objcmsCongViecDAL.selectFK(objcmsCongViecDO);
        }

        public int Update(cmsCongViecDO objcmsCongViecDO)
        {
             return objcmsCongViecDAL.Update(objcmsCongViecDO);

        }

        public int Delete(cmsCongViecDO objcmsCongViecDO)
        {
             return objcmsCongViecDAL.Delete(objcmsCongViecDO);

        }

         public int DeleteAll()
        {
             return objcmsCongViecDAL.DeleteAll();
        }

        public cmsCongViecDO Select(cmsCongViecDO objcmsCongViecDO)
        {
            return objcmsCongViecDAL.Select(objcmsCongViecDO);
        }

        public cmsCongViecDO SelectByIDFK(cmsCongViecDO objcmsCongViecDO)
        {
            return objcmsCongViecDAL.SelectByIDFK(objcmsCongViecDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsCongViecDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsCongViecDAL.SelectAll();
        }


     
#endregion          
    
    }

}
