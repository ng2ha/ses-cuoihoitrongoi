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
/// Summary description for cmsImagesDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class cmsImagesDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public cmsImagesDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(cmsImagesDO objcmsImagesDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = objcmsImagesDO.AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsImagesDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objcmsImagesDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ImgFile", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsImagesDO.ImgFile;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@StyleAlbum", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsImagesDO.StyleAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Thumbnail", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsImagesDO.Thumbnail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsImagesDO objcmsImagesDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ImageID", SqlDbType.Int);
            Sqlparam.Value = objcmsImagesDO.ImageID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = objcmsImagesDO.AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsImagesDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objcmsImagesDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ImgFile", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsImagesDO.ImgFile;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@StyleAlbum", SqlDbType.Bit);
            Sqlparam.Value = objcmsImagesDO.StyleAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Thumbnail", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsImagesDO.Thumbnail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(cmsImagesDO objcmsImagesDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ImageID", SqlDbType.Int);
            Sqlparam.Value = objcmsImagesDO.ImageID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }


        public DataTable SelectAlbumbyStyle(int id,int style)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "sp_selectcmsImagesByStyle";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@id", SqlDbType.Int);
            Sqlparam.Value = id;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@style", SqlDbType.Int);
            Sqlparam.Value = style;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsImagesDO Select(cmsImagesDO objcmsImagesDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ImageID", SqlDbType.Int);
            Sqlparam.Value = objcmsImagesDO.ImageID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ImageID"]))
                    objcmsImagesDO.ImageID = Convert.ToInt32(dr["ImageID"]);
                if (!Convert.IsDBNull(dr["AlbumID"]))
                    objcmsImagesDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objcmsImagesDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objcmsImagesDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["ImgFile"]))
                    objcmsImagesDO.ImgFile = Convert.ToString(dr["ImgFile"]);
                if (!Convert.IsDBNull(dr["StyleAlbum"]))
                    objcmsImagesDO.StyleAlbum = Convert.ToBoolean(dr["StyleAlbum"]);
                if (!Convert.IsDBNull(dr["Thumbnail"]))
                    objcmsImagesDO.Thumbnail = Convert.ToString(dr["Thumbnail"]);

            }
            return objcmsImagesDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsImagesDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    cmsImagesDO objcmsImagesDO = new cmsImagesDO();
                    if (!Convert.IsDBNull(dr["ImageID"]))
                        objcmsImagesDO.ImageID = Convert.ToInt32(dr["ImageID"]);
                    if (!Convert.IsDBNull(dr["AlbumID"]))
                        objcmsImagesDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objcmsImagesDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objcmsImagesDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["ImgFile"]))
                        objcmsImagesDO.ImgFile = Convert.ToString(dr["ImgFile"]);
                    if (!Convert.IsDBNull(dr["StyleAlbum"]))
                        objcmsImagesDO.StyleAlbum = Convert.ToBoolean(dr["StyleAlbum"]);
                    arrcmsImagesDO.Add(objcmsImagesDO);
                }
            }
            return arrcmsImagesDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        #endregion


        public DataTable SelectByCategoryID(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_GetByCategoryID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectByAlbumID(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_GetByAlbumID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public int DeleteByalbum(int PLID)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_DeleteByalbum";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = PLID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public void UpdateAlt(int stt, int[] spid, string[] alt)
        {
            SqlCommand SqlComm = new SqlCommand();
            SqlComm.CommandType = CommandType.Text;
            string s = "";
            for (int i = 0; i < stt; i++)
            {
                s += "Update cmsImages set Description= N'" + alt[i] + "' where ImageID=" + spid[i] + " ";
            }
            SqlComm.CommandText = s;

            base.ExecuteNoneQuery(SqlComm);
        }
    }

}
