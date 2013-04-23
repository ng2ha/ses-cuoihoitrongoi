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
/// Summary description for ClientLoginDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class ClientLoginDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public ClientLoginDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(ClientLoginDO objClientLoginDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Username", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.Username;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Password", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.Password;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ClientName", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.ClientName;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DetailInfo", SqlDbType.NText);
            Sqlparam.Value = objClientLoginDO.DetailInfo;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@FTPServer", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.FTPServer;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ClientLoginDO objClientLoginDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ClientLoginID", SqlDbType.Int);
            Sqlparam.Value = objClientLoginDO.ClientLoginID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Username", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.Username;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Password", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.Password;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ClientName", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.ClientName;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@DetailInfo", SqlDbType.NText);
            Sqlparam.Value = objClientLoginDO.DetailInfo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@FTPServer", SqlDbType.NVarChar);
            Sqlparam.Value = objClientLoginDO.FTPServer;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(ClientLoginDO objClientLoginDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ClientLoginID", SqlDbType.Int);
            Sqlparam.Value = objClientLoginDO.ClientLoginID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ClientLoginDO Select(ClientLoginDO objClientLoginDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ClientLoginID", SqlDbType.Int);
            Sqlparam.Value = objClientLoginDO.ClientLoginID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ClientLoginID"]))
                    objClientLoginDO.ClientLoginID = Convert.ToInt32(dr["ClientLoginID"]);
                if (!Convert.IsDBNull(dr["Username"]))
                    objClientLoginDO.Username = Convert.ToString(dr["Username"]);
                if (!Convert.IsDBNull(dr["Password"]))
                    objClientLoginDO.Password = Convert.ToString(dr["Password"]);
                if (!Convert.IsDBNull(dr["ClientName"]))
                    objClientLoginDO.ClientName = Convert.ToString(dr["ClientName"]);
                if (!Convert.IsDBNull(dr["DetailInfo"]))
                    objClientLoginDO.DetailInfo = Convert.ToString(dr["DetailInfo"]);

                if (!Convert.IsDBNull(dr["FTPServer"]))
                    objClientLoginDO.FTPServer = Convert.ToString(dr["FTPServer"]);

            }
            return objClientLoginDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrClientLoginDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    ClientLoginDO objClientLoginDO = new ClientLoginDO();
                    if (!Convert.IsDBNull(dr["ClientLoginID"]))
                        objClientLoginDO.ClientLoginID = Convert.ToInt32(dr["ClientLoginID"]);
                    if (!Convert.IsDBNull(dr["Username"]))
                        objClientLoginDO.Username = Convert.ToString(dr["Username"]);
                    if (!Convert.IsDBNull(dr["Password"]))
                        objClientLoginDO.Password = Convert.ToString(dr["Password"]);
                    if (!Convert.IsDBNull(dr["ClientName"]))
                        objClientLoginDO.ClientName = Convert.ToString(dr["ClientName"]);
                    if (!Convert.IsDBNull(dr["DetailInfo"]))
                        objClientLoginDO.DetailInfo = Convert.ToString(dr["DetailInfo"]);

                    if (!Convert.IsDBNull(dr["FTPServer"]))
                        objClientLoginDO.FTPServer = Convert.ToString(dr["FTPServer"]);
                    arrClientLoginDO.Add(objClientLoginDO);
                }
            }
            return arrClientLoginDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        #endregion


        public DataTable SelectLogin(string username, string password)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spClientLogin_GetLogin";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Username", SqlDbType.NVarChar);
            Sqlparam.Value = username;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Password", SqlDbType.NVarChar);
            Sqlparam.Value = password;
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
