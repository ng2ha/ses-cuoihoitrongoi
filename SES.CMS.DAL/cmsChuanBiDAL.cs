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
/// Summary description for cmsChuanBiDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class cmsChuanBiDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public cmsChuanBiDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(cmsChuanBiDO objcmsChuanBiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@IDFK", SqlDbType.Int);
            Sqlparam.Value = objcmsChuanBiDO.IDFK;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td1", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td2", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td3", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td4", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td5", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td5;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td6", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td6;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td7", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td7;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td8", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td8;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td9", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td9;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td10", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td10;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td11", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td11;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td12", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td12;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsChuanBiDO objcmsChuanBiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsChuanBiDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IDFK", SqlDbType.Int);
            Sqlparam.Value = objcmsChuanBiDO.IDFK;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td1", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td2", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td3", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td4", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td5", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td5;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td6", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td6;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td7", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td7;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td8", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td8;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td9", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td9;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td10", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td10;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td11", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td11;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td12", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsChuanBiDO.td12;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public DataTable selectFK(cmsChuanBiDO objcmsChuanBiDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_GetByFK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsChuanBiDO.IDFK;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public cmsChuanBiDO selectFK1(cmsChuanBiDO objcmsChuanBiDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_GetByFK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsChuanBiDO.IDFK;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ID"]))
                    objcmsChuanBiDO.ID = Convert.ToInt32(dr["ID"]);
                if (!Convert.IsDBNull(dr["IDFK"]))
                    objcmsChuanBiDO.IDFK = Convert.ToInt32(dr["IDFK"]);
                if (!Convert.IsDBNull(dr["td1"]))
                    objcmsChuanBiDO.td1 = Convert.ToString(dr["td1"]);
                if (!Convert.IsDBNull(dr["td2"]))
                    objcmsChuanBiDO.td2 = Convert.ToString(dr["td2"]);
                if (!Convert.IsDBNull(dr["td3"]))
                    objcmsChuanBiDO.td3 = Convert.ToString(dr["td3"]);
                if (!Convert.IsDBNull(dr["td4"]))
                    objcmsChuanBiDO.td4 = Convert.ToString(dr["td4"]);
                if (!Convert.IsDBNull(dr["td5"]))
                    objcmsChuanBiDO.td5 = Convert.ToString(dr["td5"]);
                if (!Convert.IsDBNull(dr["td6"]))
                    objcmsChuanBiDO.td6 = Convert.ToString(dr["td6"]);
                if (!Convert.IsDBNull(dr["td7"]))
                    objcmsChuanBiDO.td7 = Convert.ToString(dr["td7"]);
                if (!Convert.IsDBNull(dr["td8"]))
                    objcmsChuanBiDO.td8 = Convert.ToString(dr["td8"]);
                if (!Convert.IsDBNull(dr["td9"]))
                    objcmsChuanBiDO.td9 = Convert.ToString(dr["td9"]);
                if (!Convert.IsDBNull(dr["td10"]))
                    objcmsChuanBiDO.td10 = Convert.ToString(dr["td10"]);
                if (!Convert.IsDBNull(dr["td11"]))
                    objcmsChuanBiDO.td11 = Convert.ToString(dr["td11"]);
                if (!Convert.IsDBNull(dr["td12"]))
                    objcmsChuanBiDO.td12 = Convert.ToString(dr["td12"]);
            }
            return objcmsChuanBiDO;
        }

        public int Delete(cmsChuanBiDO objcmsChuanBiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsChuanBiDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsChuanBiDO Select(cmsChuanBiDO objcmsChuanBiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsChuanBiDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ID"]))
                    objcmsChuanBiDO.ID = Convert.ToInt32(dr["ID"]);
                if (!Convert.IsDBNull(dr["IDFK"]))
                    objcmsChuanBiDO.IDFK = Convert.ToInt32(dr["IDFK"]);
                if (!Convert.IsDBNull(dr["td1"]))
                    objcmsChuanBiDO.td1 = Convert.ToString(dr["td1"]);
                if (!Convert.IsDBNull(dr["td2"]))
                    objcmsChuanBiDO.td2 = Convert.ToString(dr["td2"]);
                if (!Convert.IsDBNull(dr["td3"]))
                    objcmsChuanBiDO.td3 = Convert.ToString(dr["td3"]);
                if (!Convert.IsDBNull(dr["td4"]))
                    objcmsChuanBiDO.td4 = Convert.ToString(dr["td4"]);
                if (!Convert.IsDBNull(dr["td5"]))
                    objcmsChuanBiDO.td5 = Convert.ToString(dr["td5"]);
                if (!Convert.IsDBNull(dr["td6"]))
                    objcmsChuanBiDO.td6 = Convert.ToString(dr["td6"]);
                if (!Convert.IsDBNull(dr["td7"]))
                    objcmsChuanBiDO.td7 = Convert.ToString(dr["td7"]);
                if (!Convert.IsDBNull(dr["td8"]))
                    objcmsChuanBiDO.td8 = Convert.ToString(dr["td8"]);
                if (!Convert.IsDBNull(dr["td9"]))
                    objcmsChuanBiDO.td9 = Convert.ToString(dr["td9"]);
                if (!Convert.IsDBNull(dr["td10"]))
                    objcmsChuanBiDO.td10 = Convert.ToString(dr["td10"]);
                if (!Convert.IsDBNull(dr["td11"]))
                    objcmsChuanBiDO.td11 = Convert.ToString(dr["td11"]);
                if (!Convert.IsDBNull(dr["td12"]))
                    objcmsChuanBiDO.td12 = Convert.ToString(dr["td12"]);

            }
            return objcmsChuanBiDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsChuanBiDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    cmsChuanBiDO objcmsChuanBiDO = new cmsChuanBiDO();
                    if (!Convert.IsDBNull(dr["ID"]))
                        objcmsChuanBiDO.ID = Convert.ToInt32(dr["ID"]);
                    if (!Convert.IsDBNull(dr["IDFK"]))
                        objcmsChuanBiDO.IDFK = Convert.ToInt32(dr["IDFK"]);
                    if (!Convert.IsDBNull(dr["td1"]))
                        objcmsChuanBiDO.td1 = Convert.ToString(dr["td1"]);
                    if (!Convert.IsDBNull(dr["td2"]))
                        objcmsChuanBiDO.td2 = Convert.ToString(dr["td2"]);
                    if (!Convert.IsDBNull(dr["td3"]))
                        objcmsChuanBiDO.td3 = Convert.ToString(dr["td3"]);
                    if (!Convert.IsDBNull(dr["td4"]))
                        objcmsChuanBiDO.td4 = Convert.ToString(dr["td4"]);
                    if (!Convert.IsDBNull(dr["td5"]))
                        objcmsChuanBiDO.td5 = Convert.ToString(dr["td5"]);
                    if (!Convert.IsDBNull(dr["td6"]))
                        objcmsChuanBiDO.td6 = Convert.ToString(dr["td6"]);
                    if (!Convert.IsDBNull(dr["td7"]))
                        objcmsChuanBiDO.td7 = Convert.ToString(dr["td7"]);
                    if (!Convert.IsDBNull(dr["td8"]))
                        objcmsChuanBiDO.td8 = Convert.ToString(dr["td8"]);
                    if (!Convert.IsDBNull(dr["td9"]))
                        objcmsChuanBiDO.td9 = Convert.ToString(dr["td9"]);
                    if (!Convert.IsDBNull(dr["td10"]))
                        objcmsChuanBiDO.td10 = Convert.ToString(dr["td10"]);
                    if (!Convert.IsDBNull(dr["td11"]))
                        objcmsChuanBiDO.td11 = Convert.ToString(dr["td11"]);
                    if (!Convert.IsDBNull(dr["td12"]))
                        objcmsChuanBiDO.td12 = Convert.ToString(dr["td12"]);
                    arrcmsChuanBiDO.Add(objcmsChuanBiDO);
                }
            }
            return arrcmsChuanBiDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsChuanBi_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        #endregion

    }

}
