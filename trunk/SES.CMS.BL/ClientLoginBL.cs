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
/// Summary description for ClientLoginBL
/// </summary>
namespace SES.CMS.BL 
{
    public class ClientLoginBL 
    {
    	#region Private Variables
		ClientLoginDAL objClientLoginDAL;
		#endregion
		
        #region Public Constructors
        public ClientLoginBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objClientLoginDAL=new ClientLoginDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ClientLoginDO objClientLoginDO)
        {
            return objClientLoginDAL.Insert(objClientLoginDO);
        }

        public int Update(ClientLoginDO objClientLoginDO)
        {
             return objClientLoginDAL.Update(objClientLoginDO);

        }

        public int Delete(ClientLoginDO objClientLoginDO)
        {
             return objClientLoginDAL.Delete(objClientLoginDO);

        }

         public int DeleteAll()
        {
             return objClientLoginDAL.DeleteAll();
        }

        public ClientLoginDO Select(ClientLoginDO objClientLoginDO)
        {
            return objClientLoginDAL.Select(objClientLoginDO);
        }

        public ArrayList SelectAll1( )
        {
         return objClientLoginDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objClientLoginDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectLogin(string username, string password)
        {
            return objClientLoginDAL.SelectLogin(username, password);
        }
    }

}
