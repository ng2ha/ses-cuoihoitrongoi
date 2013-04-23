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
/// Summary description for cmsAlbumDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class cmsAlbumDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public cmsAlbumDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(cmsAlbumDO objcmsAlbumDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbum_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objcmsAlbumDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDO.CategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AnhKieu", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDO.AnhKieu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AnhAlbum", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDO.AnhAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsAlbumDO objcmsAlbumDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbum_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDO.AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objcmsAlbumDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDO.CategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AnhKieu", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDO.AnhKieu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AnhAlbum", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDO.AnhAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(cmsAlbumDO objcmsAlbumDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbum_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDO.AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbum_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsAlbumDO Select(cmsAlbumDO objcmsAlbumDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbum_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDO.AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["AlbumID"]))
                    objcmsAlbumDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objcmsAlbumDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objcmsAlbumDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objcmsAlbumDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["CategoryID"]))
                    objcmsAlbumDO.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                if (!Convert.IsDBNull(dr["AnhKieu"]))
                    objcmsAlbumDO.AnhKieu = Convert.ToString(dr["AnhKieu"]);
                if (!Convert.IsDBNull(dr["AnhAlbum"]))
                    objcmsAlbumDO.AnhAlbum = Convert.ToString(dr["AnhAlbum"]);

            }
            return objcmsAlbumDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbum_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsAlbumDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    cmsAlbumDO objcmsAlbumDO = new cmsAlbumDO();
                    if (!Convert.IsDBNull(dr["AlbumID"]))
                        objcmsAlbumDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objcmsAlbumDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["OrderID"]))
                        objcmsAlbumDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objcmsAlbumDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["CategoryID"]))
                        objcmsAlbumDO.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                    if (!Convert.IsDBNull(dr["AnhKieu"]))
                        objcmsAlbumDO.AnhKieu = Convert.ToString(dr["AnhKieu"]);
                    if (!Convert.IsDBNull(dr["AnhAlbum"]))
                        objcmsAlbumDO.AnhAlbum = Convert.ToString(dr["AnhAlbum"]);
                    arrcmsAlbumDO.Add(objcmsAlbumDO);

                }
            }
            return arrcmsAlbumDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbum_GetAll";

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
