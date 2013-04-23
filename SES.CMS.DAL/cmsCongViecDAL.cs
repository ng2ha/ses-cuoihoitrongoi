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
/// Summary description for cmsCongViecDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class cmsCongViecDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public cmsCongViecDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(cmsCongViecDO objcmsCongViecDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@IDFK", SqlDbType.Int);
            Sqlparam.Value = objcmsCongViecDO.IDFK;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td1", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td2", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td3", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td4", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td5", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td5;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td6", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td6;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td7", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td7;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td8", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td8;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td9", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td9;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td10", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td10;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td11", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td11;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td12", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td12;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td13", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td13;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td14", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td14;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td15", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td15;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td16", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td16;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td17", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td17;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td18", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td18;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td19", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td19;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td20", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td20;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td21", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td21;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td22", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td22;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td23", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td23;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td24", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td24;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td25", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td25;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td26", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td26;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td27", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td27;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td28", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td28;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td29", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td29;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td30", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td30;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td31", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td31;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td32", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td32;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td33", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td33;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td34", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td34;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td35", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td35;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td36", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td36;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td37", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td37;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td38", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td38;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td39", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td39;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td40", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td40;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td41", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td41;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td42", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td42;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td43", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td43;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td44", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td44;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td45", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td45;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td46", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td46;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsCongViecDO objcmsCongViecDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsCongViecDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IDFK", SqlDbType.Int);
            Sqlparam.Value = objcmsCongViecDO.IDFK;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td1", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td2", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td3", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td4", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td5", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td5;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td6", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td6;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td7", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td7;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td8", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td8;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td9", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td9;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td10", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td10;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td11", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td11;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td12", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td12;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td13", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td13;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td14", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td14;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td15", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td15;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td16", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td16;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td17", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td17;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td18", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td18;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td19", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td19;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td20", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td20;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td21", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td21;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td22", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td22;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td23", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td23;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td24", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td24;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td25", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td25;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td26", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td26;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td27", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td27;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td28", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td28;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td29", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td29;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td30", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td30;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td31", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td31;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td32", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td32;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td33", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td33;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td34", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td34;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td35", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td35;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td36", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td36;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td37", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td37;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td38", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td38;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td39", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td39;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td40", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td40;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td41", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td41;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td42", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td42;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td43", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td43;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td44", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td44;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td45", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td45;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@td46", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsCongViecDO.td46;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(cmsCongViecDO objcmsCongViecDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsCongViecDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsCongViecDO Select(cmsCongViecDO objcmsCongViecDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsCongViecDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ID"]))
                    objcmsCongViecDO.ID = Convert.ToInt32(dr["ID"]);
                if (!Convert.IsDBNull(dr["IDFK"]))
                    objcmsCongViecDO.IDFK = Convert.ToInt32(dr["IDFK"]);
                if (!Convert.IsDBNull(dr["td1"]))
                    objcmsCongViecDO.td1 = Convert.ToString(dr["td1"]);
                if (!Convert.IsDBNull(dr["td2"]))
                    objcmsCongViecDO.td2 = Convert.ToString(dr["td2"]);
                if (!Convert.IsDBNull(dr["td3"]))
                    objcmsCongViecDO.td3 = Convert.ToString(dr["td3"]);
                if (!Convert.IsDBNull(dr["td4"]))
                    objcmsCongViecDO.td4 = Convert.ToString(dr["td4"]);
                if (!Convert.IsDBNull(dr["td5"]))
                    objcmsCongViecDO.td5 = Convert.ToString(dr["td5"]);
                if (!Convert.IsDBNull(dr["td6"]))
                    objcmsCongViecDO.td6 = Convert.ToString(dr["td6"]);
                if (!Convert.IsDBNull(dr["td7"]))
                    objcmsCongViecDO.td7 = Convert.ToString(dr["td7"]);
                if (!Convert.IsDBNull(dr["td8"]))
                    objcmsCongViecDO.td8 = Convert.ToString(dr["td8"]);
                if (!Convert.IsDBNull(dr["td9"]))
                    objcmsCongViecDO.td9 = Convert.ToString(dr["td9"]);
                if (!Convert.IsDBNull(dr["td10"]))
                    objcmsCongViecDO.td10 = Convert.ToString(dr["td10"]);
                if (!Convert.IsDBNull(dr["td11"]))
                    objcmsCongViecDO.td11 = Convert.ToString(dr["td11"]);
                if (!Convert.IsDBNull(dr["td12"]))
                    objcmsCongViecDO.td12 = Convert.ToString(dr["td12"]);
                if (!Convert.IsDBNull(dr["td13"]))
                    objcmsCongViecDO.td13 = Convert.ToString(dr["td13"]);
                if (!Convert.IsDBNull(dr["td14"]))
                    objcmsCongViecDO.td14 = Convert.ToString(dr["td14"]);
                if (!Convert.IsDBNull(dr["td15"]))
                    objcmsCongViecDO.td15 = Convert.ToString(dr["td15"]);
                if (!Convert.IsDBNull(dr["td16"]))
                    objcmsCongViecDO.td16 = Convert.ToString(dr["td16"]);
                if (!Convert.IsDBNull(dr["td17"]))
                    objcmsCongViecDO.td17 = Convert.ToString(dr["td17"]);
                if (!Convert.IsDBNull(dr["td18"]))
                    objcmsCongViecDO.td18 = Convert.ToString(dr["td18"]);
                if (!Convert.IsDBNull(dr["td19"]))
                    objcmsCongViecDO.td19 = Convert.ToString(dr["td19"]);
                if (!Convert.IsDBNull(dr["td20"]))
                    objcmsCongViecDO.td20 = Convert.ToString(dr["td20"]);
                if (!Convert.IsDBNull(dr["td21"]))
                    objcmsCongViecDO.td21 = Convert.ToString(dr["td21"]);
                if (!Convert.IsDBNull(dr["td22"]))
                    objcmsCongViecDO.td22 = Convert.ToString(dr["td22"]);
                if (!Convert.IsDBNull(dr["td23"]))
                    objcmsCongViecDO.td23 = Convert.ToString(dr["td23"]);
                if (!Convert.IsDBNull(dr["td24"]))
                    objcmsCongViecDO.td24 = Convert.ToString(dr["td24"]);
                if (!Convert.IsDBNull(dr["td25"]))
                    objcmsCongViecDO.td25 = Convert.ToString(dr["td25"]);
                if (!Convert.IsDBNull(dr["td26"]))
                    objcmsCongViecDO.td26 = Convert.ToString(dr["td26"]);
                if (!Convert.IsDBNull(dr["td27"]))
                    objcmsCongViecDO.td27 = Convert.ToString(dr["td27"]);
                if (!Convert.IsDBNull(dr["td28"]))
                    objcmsCongViecDO.td28 = Convert.ToString(dr["td28"]);
                if (!Convert.IsDBNull(dr["td29"]))
                    objcmsCongViecDO.td29 = Convert.ToString(dr["td29"]);
                if (!Convert.IsDBNull(dr["td30"]))
                    objcmsCongViecDO.td30 = Convert.ToString(dr["td30"]);
                if (!Convert.IsDBNull(dr["td31"]))
                    objcmsCongViecDO.td31 = Convert.ToString(dr["td31"]);
                if (!Convert.IsDBNull(dr["td32"]))
                    objcmsCongViecDO.td32 = Convert.ToString(dr["td32"]);
                if (!Convert.IsDBNull(dr["td33"]))
                    objcmsCongViecDO.td33 = Convert.ToString(dr["td33"]);
                if (!Convert.IsDBNull(dr["td34"]))
                    objcmsCongViecDO.td34 = Convert.ToString(dr["td34"]);
                if (!Convert.IsDBNull(dr["td35"]))
                    objcmsCongViecDO.td35 = Convert.ToString(dr["td35"]);
                if (!Convert.IsDBNull(dr["td36"]))
                    objcmsCongViecDO.td36 = Convert.ToString(dr["td36"]);
                if (!Convert.IsDBNull(dr["td37"]))
                    objcmsCongViecDO.td37 = Convert.ToString(dr["td37"]);
                if (!Convert.IsDBNull(dr["td38"]))
                    objcmsCongViecDO.td38 = Convert.ToString(dr["td38"]);
                if (!Convert.IsDBNull(dr["td39"]))
                    objcmsCongViecDO.td39 = Convert.ToString(dr["td39"]);
                if (!Convert.IsDBNull(dr["td40"]))
                    objcmsCongViecDO.td40 = Convert.ToString(dr["td40"]);
                if (!Convert.IsDBNull(dr["td41"]))
                    objcmsCongViecDO.td41 = Convert.ToString(dr["td41"]);
                if (!Convert.IsDBNull(dr["td42"]))
                    objcmsCongViecDO.td42 = Convert.ToString(dr["td42"]);
                if (!Convert.IsDBNull(dr["td43"]))
                    objcmsCongViecDO.td43 = Convert.ToString(dr["td43"]);
                if (!Convert.IsDBNull(dr["td44"]))
                    objcmsCongViecDO.td44 = Convert.ToString(dr["td44"]);
                if (!Convert.IsDBNull(dr["td45"]))
                    objcmsCongViecDO.td45 = Convert.ToString(dr["td45"]);
                if (!Convert.IsDBNull(dr["td46"]))
                    objcmsCongViecDO.td46 = Convert.ToString(dr["td46"]);

            }
            return objcmsCongViecDO;
        }

        public cmsCongViecDO SelectByIDFK(cmsCongViecDO objcmsCongViecDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_GetByFK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsCongViecDO.IDFK;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ID"]))
                    objcmsCongViecDO.ID = Convert.ToInt32(dr["ID"]);
                if (!Convert.IsDBNull(dr["IDFK"]))
                    objcmsCongViecDO.IDFK = Convert.ToInt32(dr["IDFK"]);
                if (!Convert.IsDBNull(dr["td1"]))
                    objcmsCongViecDO.td1 = Convert.ToString(dr["td1"]);
                if (!Convert.IsDBNull(dr["td2"]))
                    objcmsCongViecDO.td2 = Convert.ToString(dr["td2"]);
                if (!Convert.IsDBNull(dr["td3"]))
                    objcmsCongViecDO.td3 = Convert.ToString(dr["td3"]);
                if (!Convert.IsDBNull(dr["td4"]))
                    objcmsCongViecDO.td4 = Convert.ToString(dr["td4"]);
                if (!Convert.IsDBNull(dr["td5"]))
                    objcmsCongViecDO.td5 = Convert.ToString(dr["td5"]);
                if (!Convert.IsDBNull(dr["td6"]))
                    objcmsCongViecDO.td6 = Convert.ToString(dr["td6"]);
                if (!Convert.IsDBNull(dr["td7"]))
                    objcmsCongViecDO.td7 = Convert.ToString(dr["td7"]);
                if (!Convert.IsDBNull(dr["td8"]))
                    objcmsCongViecDO.td8 = Convert.ToString(dr["td8"]);
                if (!Convert.IsDBNull(dr["td9"]))
                    objcmsCongViecDO.td9 = Convert.ToString(dr["td9"]);
                if (!Convert.IsDBNull(dr["td10"]))
                    objcmsCongViecDO.td10 = Convert.ToString(dr["td10"]);
                if (!Convert.IsDBNull(dr["td11"]))
                    objcmsCongViecDO.td11 = Convert.ToString(dr["td11"]);
                if (!Convert.IsDBNull(dr["td12"]))
                    objcmsCongViecDO.td12 = Convert.ToString(dr["td12"]);
                if (!Convert.IsDBNull(dr["td13"]))
                    objcmsCongViecDO.td13 = Convert.ToString(dr["td13"]);
                if (!Convert.IsDBNull(dr["td14"]))
                    objcmsCongViecDO.td14 = Convert.ToString(dr["td14"]);
                if (!Convert.IsDBNull(dr["td15"]))
                    objcmsCongViecDO.td15 = Convert.ToString(dr["td15"]);
                if (!Convert.IsDBNull(dr["td16"]))
                    objcmsCongViecDO.td16 = Convert.ToString(dr["td16"]);
                if (!Convert.IsDBNull(dr["td17"]))
                    objcmsCongViecDO.td17 = Convert.ToString(dr["td17"]);
                if (!Convert.IsDBNull(dr["td18"]))
                    objcmsCongViecDO.td18 = Convert.ToString(dr["td18"]);
                if (!Convert.IsDBNull(dr["td19"]))
                    objcmsCongViecDO.td19 = Convert.ToString(dr["td19"]);
                if (!Convert.IsDBNull(dr["td20"]))
                    objcmsCongViecDO.td20 = Convert.ToString(dr["td20"]);
                if (!Convert.IsDBNull(dr["td21"]))
                    objcmsCongViecDO.td21 = Convert.ToString(dr["td21"]);
                if (!Convert.IsDBNull(dr["td22"]))
                    objcmsCongViecDO.td22 = Convert.ToString(dr["td22"]);
                if (!Convert.IsDBNull(dr["td23"]))
                    objcmsCongViecDO.td23 = Convert.ToString(dr["td23"]);
                if (!Convert.IsDBNull(dr["td24"]))
                    objcmsCongViecDO.td24 = Convert.ToString(dr["td24"]);
                if (!Convert.IsDBNull(dr["td25"]))
                    objcmsCongViecDO.td25 = Convert.ToString(dr["td25"]);
                if (!Convert.IsDBNull(dr["td26"]))
                    objcmsCongViecDO.td26 = Convert.ToString(dr["td26"]);
                if (!Convert.IsDBNull(dr["td27"]))
                    objcmsCongViecDO.td27 = Convert.ToString(dr["td27"]);
                if (!Convert.IsDBNull(dr["td28"]))
                    objcmsCongViecDO.td28 = Convert.ToString(dr["td28"]);
                if (!Convert.IsDBNull(dr["td29"]))
                    objcmsCongViecDO.td29 = Convert.ToString(dr["td29"]);
                if (!Convert.IsDBNull(dr["td30"]))
                    objcmsCongViecDO.td30 = Convert.ToString(dr["td30"]);
                if (!Convert.IsDBNull(dr["td31"]))
                    objcmsCongViecDO.td31 = Convert.ToString(dr["td31"]);
                if (!Convert.IsDBNull(dr["td32"]))
                    objcmsCongViecDO.td32 = Convert.ToString(dr["td32"]);
                if (!Convert.IsDBNull(dr["td33"]))
                    objcmsCongViecDO.td33 = Convert.ToString(dr["td33"]);
                if (!Convert.IsDBNull(dr["td34"]))
                    objcmsCongViecDO.td34 = Convert.ToString(dr["td34"]);
                if (!Convert.IsDBNull(dr["td35"]))
                    objcmsCongViecDO.td35 = Convert.ToString(dr["td35"]);
                if (!Convert.IsDBNull(dr["td36"]))
                    objcmsCongViecDO.td36 = Convert.ToString(dr["td36"]);
                if (!Convert.IsDBNull(dr["td37"]))
                    objcmsCongViecDO.td37 = Convert.ToString(dr["td37"]);
                if (!Convert.IsDBNull(dr["td38"]))
                    objcmsCongViecDO.td38 = Convert.ToString(dr["td38"]);
                if (!Convert.IsDBNull(dr["td39"]))
                    objcmsCongViecDO.td39 = Convert.ToString(dr["td39"]);
                if (!Convert.IsDBNull(dr["td40"]))
                    objcmsCongViecDO.td40 = Convert.ToString(dr["td40"]);
                if (!Convert.IsDBNull(dr["td41"]))
                    objcmsCongViecDO.td41 = Convert.ToString(dr["td41"]);
                if (!Convert.IsDBNull(dr["td42"]))
                    objcmsCongViecDO.td42 = Convert.ToString(dr["td42"]);
                if (!Convert.IsDBNull(dr["td43"]))
                    objcmsCongViecDO.td43 = Convert.ToString(dr["td43"]);
                if (!Convert.IsDBNull(dr["td44"]))
                    objcmsCongViecDO.td44 = Convert.ToString(dr["td44"]);
                if (!Convert.IsDBNull(dr["td45"]))
                    objcmsCongViecDO.td45 = Convert.ToString(dr["td45"]);
                if (!Convert.IsDBNull(dr["td46"]))
                    objcmsCongViecDO.td46 = Convert.ToString(dr["td46"]);

            }
            return objcmsCongViecDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsCongViecDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    cmsCongViecDO objcmsCongViecDO = new cmsCongViecDO();
                    if (!Convert.IsDBNull(dr["ID"]))
                        objcmsCongViecDO.ID = Convert.ToInt32(dr["ID"]);
                    if (!Convert.IsDBNull(dr["IDFK"]))
                        objcmsCongViecDO.IDFK = Convert.ToInt32(dr["IDFK"]);
                    if (!Convert.IsDBNull(dr["td1"]))
                        objcmsCongViecDO.td1 = Convert.ToString(dr["td1"]);
                    if (!Convert.IsDBNull(dr["td2"]))
                        objcmsCongViecDO.td2 = Convert.ToString(dr["td2"]);
                    if (!Convert.IsDBNull(dr["td3"]))
                        objcmsCongViecDO.td3 = Convert.ToString(dr["td3"]);
                    if (!Convert.IsDBNull(dr["td4"]))
                        objcmsCongViecDO.td4 = Convert.ToString(dr["td4"]);
                    if (!Convert.IsDBNull(dr["td5"]))
                        objcmsCongViecDO.td5 = Convert.ToString(dr["td5"]);
                    if (!Convert.IsDBNull(dr["td6"]))
                        objcmsCongViecDO.td6 = Convert.ToString(dr["td6"]);
                    if (!Convert.IsDBNull(dr["td7"]))
                        objcmsCongViecDO.td7 = Convert.ToString(dr["td7"]);
                    if (!Convert.IsDBNull(dr["td8"]))
                        objcmsCongViecDO.td8 = Convert.ToString(dr["td8"]);
                    if (!Convert.IsDBNull(dr["td9"]))
                        objcmsCongViecDO.td9 = Convert.ToString(dr["td9"]);
                    if (!Convert.IsDBNull(dr["td10"]))
                        objcmsCongViecDO.td10 = Convert.ToString(dr["td10"]);
                    if (!Convert.IsDBNull(dr["td11"]))
                        objcmsCongViecDO.td11 = Convert.ToString(dr["td11"]);
                    if (!Convert.IsDBNull(dr["td12"]))
                        objcmsCongViecDO.td12 = Convert.ToString(dr["td12"]);
                    if (!Convert.IsDBNull(dr["td13"]))
                        objcmsCongViecDO.td13 = Convert.ToString(dr["td13"]);
                    if (!Convert.IsDBNull(dr["td14"]))
                        objcmsCongViecDO.td14 = Convert.ToString(dr["td14"]);
                    if (!Convert.IsDBNull(dr["td15"]))
                        objcmsCongViecDO.td15 = Convert.ToString(dr["td15"]);
                    if (!Convert.IsDBNull(dr["td16"]))
                        objcmsCongViecDO.td16 = Convert.ToString(dr["td16"]);
                    if (!Convert.IsDBNull(dr["td17"]))
                        objcmsCongViecDO.td17 = Convert.ToString(dr["td17"]);
                    if (!Convert.IsDBNull(dr["td18"]))
                        objcmsCongViecDO.td18 = Convert.ToString(dr["td18"]);
                    if (!Convert.IsDBNull(dr["td19"]))
                        objcmsCongViecDO.td19 = Convert.ToString(dr["td19"]);
                    if (!Convert.IsDBNull(dr["td20"]))
                        objcmsCongViecDO.td20 = Convert.ToString(dr["td20"]);
                    if (!Convert.IsDBNull(dr["td21"]))
                        objcmsCongViecDO.td21 = Convert.ToString(dr["td21"]);
                    if (!Convert.IsDBNull(dr["td22"]))
                        objcmsCongViecDO.td22 = Convert.ToString(dr["td22"]);
                    if (!Convert.IsDBNull(dr["td23"]))
                        objcmsCongViecDO.td23 = Convert.ToString(dr["td23"]);
                    if (!Convert.IsDBNull(dr["td24"]))
                        objcmsCongViecDO.td24 = Convert.ToString(dr["td24"]);
                    if (!Convert.IsDBNull(dr["td25"]))
                        objcmsCongViecDO.td25 = Convert.ToString(dr["td25"]);
                    if (!Convert.IsDBNull(dr["td26"]))
                        objcmsCongViecDO.td26 = Convert.ToString(dr["td26"]);
                    if (!Convert.IsDBNull(dr["td27"]))
                        objcmsCongViecDO.td27 = Convert.ToString(dr["td27"]);
                    if (!Convert.IsDBNull(dr["td28"]))
                        objcmsCongViecDO.td28 = Convert.ToString(dr["td28"]);
                    if (!Convert.IsDBNull(dr["td29"]))
                        objcmsCongViecDO.td29 = Convert.ToString(dr["td29"]);
                    if (!Convert.IsDBNull(dr["td30"]))
                        objcmsCongViecDO.td30 = Convert.ToString(dr["td30"]);
                    if (!Convert.IsDBNull(dr["td31"]))
                        objcmsCongViecDO.td31 = Convert.ToString(dr["td31"]);
                    if (!Convert.IsDBNull(dr["td32"]))
                        objcmsCongViecDO.td32 = Convert.ToString(dr["td32"]);
                    if (!Convert.IsDBNull(dr["td33"]))
                        objcmsCongViecDO.td33 = Convert.ToString(dr["td33"]);
                    if (!Convert.IsDBNull(dr["td34"]))
                        objcmsCongViecDO.td34 = Convert.ToString(dr["td34"]);
                    if (!Convert.IsDBNull(dr["td35"]))
                        objcmsCongViecDO.td35 = Convert.ToString(dr["td35"]);
                    if (!Convert.IsDBNull(dr["td36"]))
                        objcmsCongViecDO.td36 = Convert.ToString(dr["td36"]);
                    if (!Convert.IsDBNull(dr["td37"]))
                        objcmsCongViecDO.td37 = Convert.ToString(dr["td37"]);
                    if (!Convert.IsDBNull(dr["td38"]))
                        objcmsCongViecDO.td38 = Convert.ToString(dr["td38"]);
                    if (!Convert.IsDBNull(dr["td39"]))
                        objcmsCongViecDO.td39 = Convert.ToString(dr["td39"]);
                    if (!Convert.IsDBNull(dr["td40"]))
                        objcmsCongViecDO.td40 = Convert.ToString(dr["td40"]);
                    if (!Convert.IsDBNull(dr["td41"]))
                        objcmsCongViecDO.td41 = Convert.ToString(dr["td41"]);
                    if (!Convert.IsDBNull(dr["td42"]))
                        objcmsCongViecDO.td42 = Convert.ToString(dr["td42"]);
                    if (!Convert.IsDBNull(dr["td43"]))
                        objcmsCongViecDO.td43 = Convert.ToString(dr["td43"]);
                    if (!Convert.IsDBNull(dr["td44"]))
                        objcmsCongViecDO.td44 = Convert.ToString(dr["td44"]);
                    if (!Convert.IsDBNull(dr["td45"]))
                        objcmsCongViecDO.td45 = Convert.ToString(dr["td45"]);
                    if (!Convert.IsDBNull(dr["td46"]))
                        objcmsCongViecDO.td46 = Convert.ToString(dr["td46"]);
                    arrcmsCongViecDO.Add(objcmsCongViecDO);
                }
            }
            return arrcmsCongViecDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        #endregion

        public DataTable selectFK(cmsCongViecDO objcmsCongViecDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCongViec_GetByFK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsCongViecDO.IDFK;
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
