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
using System.Collections.Generic;

namespace SES.CMS.DAL
{
    public class cmsCounterDAL : BaseDAL
    {
        public  List<cmsCounterDO> GetAll()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCounter_Get";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
           // DataRow dr = null;
            List<cmsCounterDO> cmsCounterLst = new List<cmsCounterDO>();
            foreach (DataRow dr in dt.Rows)
            {
                cmsCounterDO CounterDO = new cmsCounterDO();
                if (!Convert.IsDBNull(dr["Pk_iCounterId"]))
                    CounterDO.PK_iCounterID = Convert.ToInt32(dr["Pk_iCounterId"]);
                if (!Convert.IsDBNull(dr["sIp"]))
                    CounterDO.sIP = Convert.ToString(dr["sIp"]);
                if (!Convert.IsDBNull(dr["tDate"]))
                    CounterDO.tDate = Convert.ToDateTime(dr["tDate"]);
                cmsCounterLst.Add(CounterDO);
            }

            return cmsCounterLst;
        }

        public void Insert(cmsCounterDO counterDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCounter_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@sIP", SqlDbType.NVarChar);
            Sqlparam.Value = counterDO.sIP;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tDate", SqlDbType.DateTime);
            Sqlparam.Value = counterDO.tDate;
            Sqlcomm.Parameters.Add(Sqlparam);
            base.ExecuteNoneQuery(Sqlcomm);
        }

        public DateTime getTimeNow()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsCounter_GetTime";
            SqlParameter Sqlparam;
            DateTime datenow = DateTime.Now;
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["DateNow"]))
                    datenow = Convert.ToDateTime(dr["DateNow"]);
               

            }
            return datenow;

            
        }
    }
}
