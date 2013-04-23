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
/// Summary description for cmsThongTinKHDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class cmsThongTinKHDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public cmsThongTinKHDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(cmsThongTinKHDO objcmsThongTinKHDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@username", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.username;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@pass", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.pass;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenRe", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.TenRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCRe", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.DCRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenDau", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.TenDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCDau", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.DCDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgAnHoiDuKien", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgAnHoiDuKien;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgThanhHonDuKien", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgThanhHonDuKien;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgThanhHon", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgThanhHon;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DDTC", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.DDTC;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHTrap", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.AHTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHHD", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.AHHD;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHAlbum", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.AHAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe4", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHXe4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe16", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHXe16;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe29", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHXe29;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhong", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHPhong;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBanAnHoi", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHBanAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBanGhe", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBat", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHCongHoa", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHCongHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhao", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHPhao;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChuHy", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHDoAnHoi", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHDoAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHDoiTrap", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHDoiTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHDoiTrapNu", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHDoiTrapNu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXinDau", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCXinDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHD", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHD;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCAlbum", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXe4", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCXe4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXe16", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCXe16;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXe29", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCXe29;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCPhongGai", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCPhongGai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCPhongTrai", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCPhongTrai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCBanGhe", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCNhaBat", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCNhaBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCCongHoa", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCCongHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCPhao", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCPhao;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCChuHy", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaTay", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaTay;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaCauThang", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaCauThang;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaBanTK", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaBanTK;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaPC", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaPC;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int createKH(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_CreateKH";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tg1", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgAnHoiDuKien;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tg2", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgThanhHonDuKien;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;

        }

        public int Update(cmsThongTinKHDO objcmsThongTinKHDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@username", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.username;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@pass", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.pass;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenRe", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.TenRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCRe", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.DCRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenDau", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.TenDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCDau", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.DCDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgAnHoiDuKien", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgAnHoiDuKien;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgThanhHonDuKien", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgThanhHonDuKien;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@tgThanhHon", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.tgThanhHon;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DDTC", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.DDTC;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHTrap", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.AHTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHHD", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.AHHD;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHAlbum", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.AHAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe4", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHXe4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe16", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHXe16;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe29", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHXe29;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhong", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHPhong;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBanAnHoi", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHBanAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBanGhe", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBat", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHCongHoa", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHCongHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhao", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHPhao;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChuHy", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHDoAnHoi", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHDoAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHDoiTrap", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHDoiTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHDoiTrapNu", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.AHDoiTrapNu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXinDau", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCXinDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHD", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHD;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCAlbum", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCAlbum;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXe4", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCXe4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXe16", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCXe16;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCXe29", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCXe29;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCPhongGai", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCPhongGai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCPhongTrai", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCPhongTrai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCBanGhe", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCNhaBat", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCNhaBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCCongHoa", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCCongHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCPhao", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCPhao;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCChuHy", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaTay", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaTay;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaCauThang", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaCauThang;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaBanTK", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaBanTK;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DCHoaPC", SqlDbType.Bit);
            Sqlparam.Value = objcmsThongTinKHDO.DCHoaPC;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(cmsThongTinKHDO objcmsThongTinKHDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsThongTinKHDO Select(cmsThongTinKHDO objcmsThongTinKHDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["ID"]))
                    objcmsThongTinKHDO.ID = Convert.ToInt32(dr["ID"]);
                if (!Convert.IsDBNull(dr["username"]))
                    objcmsThongTinKHDO.username = Convert.ToString(dr["username"]);
                if (!Convert.IsDBNull(dr["pass"]))
                    objcmsThongTinKHDO.pass = Convert.ToString(dr["pass"]);
                if (!Convert.IsDBNull(dr["TenRe"]))
                    objcmsThongTinKHDO.TenRe = Convert.ToString(dr["TenRe"]);
                if (!Convert.IsDBNull(dr["DCRe"]))
                    objcmsThongTinKHDO.DCRe = Convert.ToString(dr["DCRe"]);
                if (!Convert.IsDBNull(dr["TenDau"]))
                    objcmsThongTinKHDO.TenDau = Convert.ToString(dr["TenDau"]);
                if (!Convert.IsDBNull(dr["DCDau"]))
                    objcmsThongTinKHDO.DCDau = Convert.ToString(dr["DCDau"]);
                if (!Convert.IsDBNull(dr["tgDamNgo"]))
                    objcmsThongTinKHDO.tgDamNgo = Convert.ToString(dr["tgDamNgo"]);
                if (!Convert.IsDBNull(dr["tgAnHoiDuKien"]))
                    objcmsThongTinKHDO.tgAnHoiDuKien = Convert.ToString(dr["tgAnHoiDuKien"]);
                if (!Convert.IsDBNull(dr["tgAnHoi"]))
                    objcmsThongTinKHDO.tgAnHoi = Convert.ToString(dr["tgAnHoi"]);
                if (!Convert.IsDBNull(dr["tgThanhHonDuKien"]))
                    objcmsThongTinKHDO.tgThanhHonDuKien = Convert.ToString(dr["tgThanhHonDuKien"]);
                if (!Convert.IsDBNull(dr["tgThanhHon"]))
                    objcmsThongTinKHDO.tgThanhHon = Convert.ToString(dr["tgThanhHon"]);
                if (!Convert.IsDBNull(dr["DDTC"]))
                    objcmsThongTinKHDO.DDTC = Convert.ToString(dr["DDTC"]);
                if (!Convert.IsDBNull(dr["AHTrap"]))
                    objcmsThongTinKHDO.AHTrap = Convert.ToBoolean(dr["AHTrap"]);
                if (!Convert.IsDBNull(dr["AHHD"]))
                    objcmsThongTinKHDO.AHHD = Convert.ToBoolean(dr["AHHD"]);
                if (!Convert.IsDBNull(dr["AHAlbum"]))
                    objcmsThongTinKHDO.AHAlbum = Convert.ToBoolean(dr["AHAlbum"]);
                if (!Convert.IsDBNull(dr["AHXe4"]))
                    objcmsThongTinKHDO.AHXe4 = Convert.ToInt32(dr["AHXe4"]);
                if (!Convert.IsDBNull(dr["AHXe16"]))
                    objcmsThongTinKHDO.AHXe16 = Convert.ToInt32(dr["AHXe16"]);
                if (!Convert.IsDBNull(dr["AHXe29"]))
                    objcmsThongTinKHDO.AHXe29 = Convert.ToInt32(dr["AHXe29"]);
                if (!Convert.IsDBNull(dr["AHPhong"]))
                    objcmsThongTinKHDO.AHPhong = Convert.ToInt32(dr["AHPhong"]);
                if (!Convert.IsDBNull(dr["AHBanAnHoi"]))
                    objcmsThongTinKHDO.AHBanAnHoi = Convert.ToInt32(dr["AHBanAnHoi"]);
                if (!Convert.IsDBNull(dr["AHBanGhe"]))
                    objcmsThongTinKHDO.AHBanGhe = Convert.ToInt32(dr["AHBanGhe"]);
                if (!Convert.IsDBNull(dr["AHBat"]))
                    objcmsThongTinKHDO.AHBat = Convert.ToInt32(dr["AHBat"]);
                if (!Convert.IsDBNull(dr["AHCongHoa"]))
                    objcmsThongTinKHDO.AHCongHoa = Convert.ToInt32(dr["AHCongHoa"]);
                if (!Convert.IsDBNull(dr["AHPhao"]))
                    objcmsThongTinKHDO.AHPhao = Convert.ToInt32(dr["AHPhao"]);
                if (!Convert.IsDBNull(dr["AHChuHy"]))
                    objcmsThongTinKHDO.AHChuHy = Convert.ToInt32(dr["AHChuHy"]);
                if (!Convert.IsDBNull(dr["AHDoAnHoi"]))
                    objcmsThongTinKHDO.AHDoAnHoi = Convert.ToInt32(dr["AHDoAnHoi"]);
                if (!Convert.IsDBNull(dr["AHDoiTrap"]))
                    objcmsThongTinKHDO.AHDoiTrap = Convert.ToInt32(dr["AHDoiTrap"]);
                if (!Convert.IsDBNull(dr["AHDoiTrapNu"]))
                    objcmsThongTinKHDO.AHDoiTrapNu = Convert.ToInt32(dr["AHDoiTrapNu"]);
                if (!Convert.IsDBNull(dr["DCXinDau"]))
                    objcmsThongTinKHDO.DCXinDau = Convert.ToBoolean(dr["DCXinDau"]);
                if (!Convert.IsDBNull(dr["DCHD"]))
                    objcmsThongTinKHDO.DCHD = Convert.ToBoolean(dr["DCHD"]);
                if (!Convert.IsDBNull(dr["DCAlbum"]))
                    objcmsThongTinKHDO.DCAlbum = Convert.ToBoolean(dr["DCAlbum"]);
                if (!Convert.IsDBNull(dr["DCXe4"]))
                    objcmsThongTinKHDO.DCXe4 = Convert.ToInt32(dr["DCXe4"]);
                if (!Convert.IsDBNull(dr["DCXe16"]))
                    objcmsThongTinKHDO.DCXe16 = Convert.ToInt32(dr["DCXe16"]);
                if (!Convert.IsDBNull(dr["DCXe29"]))
                    objcmsThongTinKHDO.DCXe29 = Convert.ToInt32(dr["DCXe29"]);
                if (!Convert.IsDBNull(dr["DCPhongGai"]))
                    objcmsThongTinKHDO.DCPhongGai = Convert.ToInt32(dr["DCPhongGai"]);
                if (!Convert.IsDBNull(dr["DCPhongTrai"]))
                    objcmsThongTinKHDO.DCPhongTrai = Convert.ToInt32(dr["DCPhongTrai"]);
                if (!Convert.IsDBNull(dr["DCBanGhe"]))
                    objcmsThongTinKHDO.DCBanGhe = Convert.ToInt32(dr["DCBanGhe"]);
                if (!Convert.IsDBNull(dr["DCNhaBat"]))
                    objcmsThongTinKHDO.DCNhaBat = Convert.ToInt32(dr["DCNhaBat"]);
                if (!Convert.IsDBNull(dr["DCCongHoa"]))
                    objcmsThongTinKHDO.DCCongHoa = Convert.ToInt32(dr["DCCongHoa"]);
                if (!Convert.IsDBNull(dr["DCPhao"]))
                    objcmsThongTinKHDO.DCPhao = Convert.ToInt32(dr["DCPhao"]);
                if (!Convert.IsDBNull(dr["DCChuHy"]))
                    objcmsThongTinKHDO.DCChuHy = Convert.ToInt32(dr["DCChuHy"]);
                if (!Convert.IsDBNull(dr["DCHoaTay"]))
                    objcmsThongTinKHDO.DCHoaTay = Convert.ToInt32(dr["DCHoaTay"]);
                if (!Convert.IsDBNull(dr["DCHoaCauThang"]))
                    objcmsThongTinKHDO.DCHoaCauThang = Convert.ToBoolean(dr["DCHoaCauThang"]);
                if (!Convert.IsDBNull(dr["DCHoaBanTK"]))
                    objcmsThongTinKHDO.DCHoaBanTK = Convert.ToBoolean(dr["DCHoaBanTK"]);
                if (!Convert.IsDBNull(dr["DCHoaPC"]))
                    objcmsThongTinKHDO.DCHoaPC = Convert.ToBoolean(dr["DCHoaPC"]);

            }
            return objcmsThongTinKHDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsThongTinKHDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    cmsThongTinKHDO objcmsThongTinKHDO = new cmsThongTinKHDO();
                    if (!Convert.IsDBNull(dr["ID"]))
                        objcmsThongTinKHDO.ID = Convert.ToInt32(dr["ID"]);
                    if (!Convert.IsDBNull(dr["username"]))
                        objcmsThongTinKHDO.username = Convert.ToString(dr["username"]);
                    if (!Convert.IsDBNull(dr["pass"]))
                        objcmsThongTinKHDO.pass = Convert.ToString(dr["pass"]);
                    if (!Convert.IsDBNull(dr["TenRe"]))
                        objcmsThongTinKHDO.TenRe = Convert.ToString(dr["TenRe"]);
                    if (!Convert.IsDBNull(dr["DCRe"]))
                        objcmsThongTinKHDO.DCRe = Convert.ToString(dr["DCRe"]);
                    if (!Convert.IsDBNull(dr["TenDau"]))
                        objcmsThongTinKHDO.TenDau = Convert.ToString(dr["TenDau"]);
                    if (!Convert.IsDBNull(dr["DCDau"]))
                        objcmsThongTinKHDO.DCDau = Convert.ToString(dr["DCDau"]);
                    if (!Convert.IsDBNull(dr["tgDamNgo"]))
                        objcmsThongTinKHDO.tgDamNgo = Convert.ToString(dr["tgDamNgo"]);
                    if (!Convert.IsDBNull(dr["tgAnHoiDuKien"]))
                        objcmsThongTinKHDO.tgAnHoiDuKien = Convert.ToString(dr["tgAnHoiDuKien"]);
                    if (!Convert.IsDBNull(dr["tgAnHoi"]))
                        objcmsThongTinKHDO.tgAnHoi = Convert.ToString(dr["tgAnHoi"]);
                    if (!Convert.IsDBNull(dr["tgThanhHonDuKien"]))
                        objcmsThongTinKHDO.tgThanhHonDuKien = Convert.ToString(dr["tgThanhHonDuKien"]);
                    if (!Convert.IsDBNull(dr["tgThanhHon"]))
                        objcmsThongTinKHDO.tgThanhHon = Convert.ToString(dr["tgThanhHon"]);
                    if (!Convert.IsDBNull(dr["DDTC"]))
                        objcmsThongTinKHDO.DDTC = Convert.ToString(dr["DDTC"]);
                    if (!Convert.IsDBNull(dr["AHTrap"]))
                        objcmsThongTinKHDO.AHTrap = Convert.ToBoolean(dr["AHTrap"]);
                    if (!Convert.IsDBNull(dr["AHHD"]))
                        objcmsThongTinKHDO.AHHD = Convert.ToBoolean(dr["AHHD"]);
                    if (!Convert.IsDBNull(dr["AHAlbum"]))
                        objcmsThongTinKHDO.AHAlbum = Convert.ToBoolean(dr["AHAlbum"]);
                    if (!Convert.IsDBNull(dr["AHXe4"]))
                        objcmsThongTinKHDO.AHXe4 = Convert.ToInt32(dr["AHXe4"]);
                    if (!Convert.IsDBNull(dr["AHXe16"]))
                        objcmsThongTinKHDO.AHXe16 = Convert.ToInt32(dr["AHXe16"]);
                    if (!Convert.IsDBNull(dr["AHXe29"]))
                        objcmsThongTinKHDO.AHXe29 = Convert.ToInt32(dr["AHXe29"]);
                    if (!Convert.IsDBNull(dr["AHPhong"]))
                        objcmsThongTinKHDO.AHPhong = Convert.ToInt32(dr["AHPhong"]);
                    if (!Convert.IsDBNull(dr["AHBanAnHoi"]))
                        objcmsThongTinKHDO.AHBanAnHoi = Convert.ToInt32(dr["AHBanAnHoi"]);
                    if (!Convert.IsDBNull(dr["AHBanGhe"]))
                        objcmsThongTinKHDO.AHBanGhe = Convert.ToInt32(dr["AHBanGhe"]);
                    if (!Convert.IsDBNull(dr["AHBat"]))
                        objcmsThongTinKHDO.AHBat = Convert.ToInt32(dr["AHBat"]);
                    if (!Convert.IsDBNull(dr["AHCongHoa"]))
                        objcmsThongTinKHDO.AHCongHoa = Convert.ToInt32(dr["AHCongHoa"]);
                    if (!Convert.IsDBNull(dr["AHPhao"]))
                        objcmsThongTinKHDO.AHPhao = Convert.ToInt32(dr["AHPhao"]);
                    if (!Convert.IsDBNull(dr["AHChuHy"]))
                        objcmsThongTinKHDO.AHChuHy = Convert.ToInt32(dr["AHChuHy"]);
                    if (!Convert.IsDBNull(dr["AHDoAnHoi"]))
                        objcmsThongTinKHDO.AHDoAnHoi = Convert.ToInt32(dr["AHDoAnHoi"]);
                    if (!Convert.IsDBNull(dr["AHDoiTrap"]))
                        objcmsThongTinKHDO.AHDoiTrap = Convert.ToInt32(dr["AHDoiTrap"]);
                    if (!Convert.IsDBNull(dr["AHDoiTrapNu"]))
                        objcmsThongTinKHDO.AHDoiTrapNu = Convert.ToInt32(dr["AHDoiTrapNu"]);
                    if (!Convert.IsDBNull(dr["DCXinDau"]))
                        objcmsThongTinKHDO.DCXinDau = Convert.ToBoolean(dr["DCXinDau"]);
                    if (!Convert.IsDBNull(dr["DCHD"]))
                        objcmsThongTinKHDO.DCHD = Convert.ToBoolean(dr["DCHD"]);
                    if (!Convert.IsDBNull(dr["DCAlbum"]))
                        objcmsThongTinKHDO.DCAlbum = Convert.ToBoolean(dr["DCAlbum"]);
                    if (!Convert.IsDBNull(dr["DCXe4"]))
                        objcmsThongTinKHDO.DCXe4 = Convert.ToInt32(dr["DCXe4"]);
                    if (!Convert.IsDBNull(dr["DCXe16"]))
                        objcmsThongTinKHDO.DCXe16 = Convert.ToInt32(dr["DCXe16"]);
                    if (!Convert.IsDBNull(dr["DCXe29"]))
                        objcmsThongTinKHDO.DCXe29 = Convert.ToInt32(dr["DCXe29"]);
                    if (!Convert.IsDBNull(dr["DCPhongGai"]))
                        objcmsThongTinKHDO.DCPhongGai = Convert.ToInt32(dr["DCPhongGai"]);
                    if (!Convert.IsDBNull(dr["DCPhongTrai"]))
                        objcmsThongTinKHDO.DCPhongTrai = Convert.ToInt32(dr["DCPhongTrai"]);
                    if (!Convert.IsDBNull(dr["DCBanGhe"]))
                        objcmsThongTinKHDO.DCBanGhe = Convert.ToInt32(dr["DCBanGhe"]);
                    if (!Convert.IsDBNull(dr["DCNhaBat"]))
                        objcmsThongTinKHDO.DCNhaBat = Convert.ToInt32(dr["DCNhaBat"]);
                    if (!Convert.IsDBNull(dr["DCCongHoa"]))
                        objcmsThongTinKHDO.DCCongHoa = Convert.ToInt32(dr["DCCongHoa"]);
                    if (!Convert.IsDBNull(dr["DCPhao"]))
                        objcmsThongTinKHDO.DCPhao = Convert.ToInt32(dr["DCPhao"]);
                    if (!Convert.IsDBNull(dr["DCChuHy"]))
                        objcmsThongTinKHDO.DCChuHy = Convert.ToInt32(dr["DCChuHy"]);
                    if (!Convert.IsDBNull(dr["DCHoaTay"]))
                        objcmsThongTinKHDO.DCHoaTay = Convert.ToInt32(dr["DCHoaTay"]);
                    if (!Convert.IsDBNull(dr["DCHoaCauThang"]))
                        objcmsThongTinKHDO.DCHoaCauThang = Convert.ToBoolean(dr["DCHoaCauThang"]);
                    if (!Convert.IsDBNull(dr["DCHoaBanTK"]))
                        objcmsThongTinKHDO.DCHoaBanTK = Convert.ToBoolean(dr["DCHoaBanTK"]);
                    if (!Convert.IsDBNull(dr["DCHoaPC"]))
                        objcmsThongTinKHDO.DCHoaPC = Convert.ToBoolean(dr["DCHoaPC"]);
                    arrcmsThongTinKHDO.Add(objcmsThongTinKHDO);
                }
            }
            return arrcmsThongTinKHDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectNonAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_GetnonAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public int createUser(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_createUser";
            SqlParameter Sqlparam = new SqlParameter();

            Sqlparam = new SqlParameter("@username", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.username;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@pass", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsThongTinKHDO.pass;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public DataTable selectUser(cmsThongTinKHDO objcmsThongTinKHDO)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "sp_cmsThongTinKH_selectbyUser";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = objcmsThongTinKHDO.username;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable getNonServ()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_GetNonServ";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable getServ()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsThongTinKH_GetServ";

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
