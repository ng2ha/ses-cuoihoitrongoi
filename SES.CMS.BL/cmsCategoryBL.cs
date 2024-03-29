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
/// Summary description for cmsCategoryBL
/// </summary>
namespace SES.CMS.BL 
{
    public class cmsCategoryBL 
    {
    	#region Private Variables
		cmsCategoryDAL objcmsCategoryDAL;
		#endregion
		
        #region Public Constructors
        public cmsCategoryBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsCategoryDAL=new cmsCategoryDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsCategoryDO objcmsCategoryDO)
        {
            return objcmsCategoryDAL.Insert(objcmsCategoryDO);
        }

        public int Update(cmsCategoryDO objcmsCategoryDO)
        {
             return objcmsCategoryDAL.Update(objcmsCategoryDO);

        }

        public int Delete(cmsCategoryDO objcmsCategoryDO)
        {
             return objcmsCategoryDAL.Delete(objcmsCategoryDO);

        }

         public int DeleteAll()
        {
             return objcmsCategoryDAL.DeleteAll();
        }

        public cmsCategoryDO Select(cmsCategoryDO objcmsCategoryDO)
        {
            return objcmsCategoryDAL.Select(objcmsCategoryDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsCategoryDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsCategoryDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectHomepage(int BlockNumber)
        {
            return objcmsCategoryDAL.SelectHomepage(BlockNumber);
        }

        public DataTable SelectByParent(int ParentID)
        {
            return objcmsCategoryDAL.SelectByParent(ParentID);
        }
        public DataTable SelectAllByParent(int ParentID)
        {
            return objcmsCategoryDAL.SelectAllByParent(ParentID);
        }

        public DataTable SelectOne(cmsCategoryDO objCat)
        {
            return objcmsCategoryDAL.SelectOne(objCat);
        }



        public DataTable SelectUnion()
        {
            return objcmsCategoryDAL.SelectUnion();
        }

        public DataTable SelectUnionByID(int ids)
        {
            return objcmsCategoryDAL.SelectUnionByID(ids);
        }

        public int GetParentID(int CategoryID)
        {
            return objcmsCategoryDAL.GetParentID(CategoryID);
        }

        public int GetCategoryIDByArtID(int ArticleID)
        {
            return objcmsCategoryDAL.GetCategoryIDByArtID(ArticleID);
        }

        public DataTable SelectParentID(int CategoryID)
        {
            return objcmsCategoryDAL.SelectParentID(CategoryID);
        }

    }

}
