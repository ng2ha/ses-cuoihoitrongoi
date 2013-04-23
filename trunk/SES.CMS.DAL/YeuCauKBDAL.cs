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
/// Summary description for YeuCauKBDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class YeuCauKBDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public YeuCauKBDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(YeuCauKBDO objYeuCauKBDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ChapNhan", SqlDbType.Bit);
            Sqlparam.Value = objYeuCauKBDO.ChapNhan;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.TenDangNhap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MatKhai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.MatKhai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenChuRe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.TenChuRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenCoDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.TenCoDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiaChiNhaTrai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiaChiNhaTrai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiaChiNhaGai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiaChiNhaGai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SoDTChuRe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.SoDTChuRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SoDTCoDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.SoDTCoDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MailChuRe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.MailChuRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MailCoDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.MailCoDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiemTiecNT", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiemTiecNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiemTiecNG", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiemTiecNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhutDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhutDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhutAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhutAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayDonDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayDonDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioDonDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioDonDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhuDonDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhuDonDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayTiecCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayTiecCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioTiecCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioTiecCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhutTiecCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhutTiecCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@YeuCauKhac", SqlDbType.NText);
            Sqlparam.Value = objYeuCauKBDO.YeuCauKhac;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TronGoi", SqlDbType.Bit);
            Sqlparam.Value = objYeuCauKBDO.TronGoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SoDichVuTronGoi", SqlDbType.Int);
            Sqlparam.Value = objYeuCauKBDO.SoDichVuTronGoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHLoaiDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHLoaiDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChupNgoaiTroi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHChupNgoaiTroi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHTrapLeAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHTrapLeAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHQuayPhim", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHQuayPhim;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChupAnh", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHChupAnh;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe16Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHXe16Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe29Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHXe29Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHNamBeTrap", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHNamBeTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHNuDoTrap", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHNuDoTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhongNhaGai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHPhongNhaGai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBanGhe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHNhaBat", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHNhaBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHHoaAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHHoaAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCLeXinDau", SqlDbType.Bit);
            Sqlparam.Value = objYeuCauKBDO.NCLeXinDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCQuayPhim", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCQuayPhim;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCChupAnh", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCChupAnh;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCXe4Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCXe4Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCXe16Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCXe16Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCXe29Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCXe29Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCPhongDamCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCPhongDamCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCBanGhe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCNhaBat", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCNhaBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCPhao", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCPhao;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCChuHy", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCHoaCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCHoaCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhaoGiay", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHPhaoGiay;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChuHy", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(YeuCauKBDO objYeuCauKBDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@YeuCauKBID", SqlDbType.Int);
            Sqlparam.Value = objYeuCauKBDO.YeuCauKBID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ChapNhan", SqlDbType.Bit);
            Sqlparam.Value = objYeuCauKBDO.ChapNhan;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.TenDangNhap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MatKhai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.MatKhai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenChuRe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.TenChuRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TenCoDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.TenCoDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiaChiNhaTrai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiaChiNhaTrai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiaChiNhaGai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiaChiNhaGai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SoDTChuRe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.SoDTChuRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SoDTCoDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.SoDTCoDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MailChuRe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.MailChuRe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MailCoDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.MailCoDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiemTiecNT", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiemTiecNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DiemTiecNG", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.DiemTiecNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhutDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhutDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhutAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhutAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayDonDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayDonDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioDonDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioDonDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhuDonDau", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhuDonDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NgayTiecCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NgayTiecCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioTiecCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.GioTiecCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhutTiecCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.PhutTiecCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@YeuCauKhac", SqlDbType.NText);
            Sqlparam.Value = objYeuCauKBDO.YeuCauKhac;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TronGoi", SqlDbType.Bit);
            Sqlparam.Value = objYeuCauKBDO.TronGoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SoDichVuTronGoi", SqlDbType.Int);
            Sqlparam.Value = objYeuCauKBDO.SoDichVuTronGoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHLoaiDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHLoaiDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChupNgoaiTroi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHChupNgoaiTroi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHTrapLeAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHTrapLeAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHQuayPhim", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHQuayPhim;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChupAnh", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHChupAnh;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe16Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHXe16Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHXe29Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHXe29Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHNamBeTrap", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHNamBeTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHNuDoTrap", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHNuDoTrap;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhongNhaGai", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHPhongNhaGai;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHBanGhe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHNhaBat", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHNhaBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHHoaAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHHoaAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCLeXinDau", SqlDbType.Bit);
            Sqlparam.Value = objYeuCauKBDO.NCLeXinDau;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCQuayPhim", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCQuayPhim;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCChupAnh", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCChupAnh;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCXe4Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCXe4Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCXe16Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCXe16Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCXe29Cho", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCXe29Cho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCPhongDamCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCPhongDamCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCBanGhe", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCBanGhe;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCNhaBat", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCNhaBat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCPhao", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCPhao;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCChuHy", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NCHoaCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.NCHoaCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHPhaoGiay", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHPhaoGiay;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHChuHy", SqlDbType.NVarChar);
            Sqlparam.Value = objYeuCauKBDO.AHChuHy;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(YeuCauKBDO objYeuCauKBDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@YeuCauKBID", SqlDbType.Int);
            Sqlparam.Value = objYeuCauKBDO.YeuCauKBID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public YeuCauKBDO Select(YeuCauKBDO objYeuCauKBDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@YeuCauKBID", SqlDbType.Int);
            Sqlparam.Value = objYeuCauKBDO.YeuCauKBID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["YeuCauKBID"]))
                    objYeuCauKBDO.YeuCauKBID = Convert.ToInt32(dr["YeuCauKBID"]);
                if (!Convert.IsDBNull(dr["ChapNhan"]))
                    objYeuCauKBDO.ChapNhan = Convert.ToBoolean(dr["ChapNhan"]);
                if (!Convert.IsDBNull(dr["TenDangNhap"]))
                    objYeuCauKBDO.TenDangNhap = Convert.ToString(dr["TenDangNhap"]);
                if (!Convert.IsDBNull(dr["MatKhai"]))
                    objYeuCauKBDO.MatKhai = Convert.ToString(dr["MatKhai"]);
                if (!Convert.IsDBNull(dr["TenChuRe"]))
                    objYeuCauKBDO.TenChuRe = Convert.ToString(dr["TenChuRe"]);
                if (!Convert.IsDBNull(dr["TenCoDau"]))
                    objYeuCauKBDO.TenCoDau = Convert.ToString(dr["TenCoDau"]);
                if (!Convert.IsDBNull(dr["DiaChiNhaTrai"]))
                    objYeuCauKBDO.DiaChiNhaTrai = Convert.ToString(dr["DiaChiNhaTrai"]);
                if (!Convert.IsDBNull(dr["DiaChiNhaGai"]))
                    objYeuCauKBDO.DiaChiNhaGai = Convert.ToString(dr["DiaChiNhaGai"]);
                if (!Convert.IsDBNull(dr["SoDTChuRe"]))
                    objYeuCauKBDO.SoDTChuRe = Convert.ToString(dr["SoDTChuRe"]);
                if (!Convert.IsDBNull(dr["SoDTCoDau"]))
                    objYeuCauKBDO.SoDTCoDau = Convert.ToString(dr["SoDTCoDau"]);
                if (!Convert.IsDBNull(dr["MailChuRe"]))
                    objYeuCauKBDO.MailChuRe = Convert.ToString(dr["MailChuRe"]);
                if (!Convert.IsDBNull(dr["MailCoDau"]))
                    objYeuCauKBDO.MailCoDau = Convert.ToString(dr["MailCoDau"]);
                if (!Convert.IsDBNull(dr["DiemTiecNT"]))
                    objYeuCauKBDO.DiemTiecNT = Convert.ToString(dr["DiemTiecNT"]);
                if (!Convert.IsDBNull(dr["DiemTiecNG"]))
                    objYeuCauKBDO.DiemTiecNG = Convert.ToString(dr["DiemTiecNG"]);
                if (!Convert.IsDBNull(dr["NgayDamNgo"]))
                    objYeuCauKBDO.NgayDamNgo = Convert.ToString(dr["NgayDamNgo"]);
                if (!Convert.IsDBNull(dr["GioDamNgo"]))
                    objYeuCauKBDO.GioDamNgo = Convert.ToString(dr["GioDamNgo"]);
                if (!Convert.IsDBNull(dr["PhutDamNgo"]))
                    objYeuCauKBDO.PhutDamNgo = Convert.ToString(dr["PhutDamNgo"]);
                if (!Convert.IsDBNull(dr["NgayAnHoi"]))
                    objYeuCauKBDO.NgayAnHoi = Convert.ToString(dr["NgayAnHoi"]);
                if (!Convert.IsDBNull(dr["GioAnHoi"]))
                    objYeuCauKBDO.GioAnHoi = Convert.ToString(dr["GioAnHoi"]);
                if (!Convert.IsDBNull(dr["PhutAnHoi"]))
                    objYeuCauKBDO.PhutAnHoi = Convert.ToString(dr["PhutAnHoi"]);
                if (!Convert.IsDBNull(dr["NgayDonDau"]))
                    objYeuCauKBDO.NgayDonDau = Convert.ToString(dr["NgayDonDau"]);
                if (!Convert.IsDBNull(dr["GioDonDau"]))
                    objYeuCauKBDO.GioDonDau = Convert.ToString(dr["GioDonDau"]);
                if (!Convert.IsDBNull(dr["PhuDonDau"]))
                    objYeuCauKBDO.PhuDonDau = Convert.ToString(dr["PhuDonDau"]);
                if (!Convert.IsDBNull(dr["NgayTiecCuoi"]))
                    objYeuCauKBDO.NgayTiecCuoi = Convert.ToString(dr["NgayTiecCuoi"]);
                if (!Convert.IsDBNull(dr["GioTiecCuoi"]))
                    objYeuCauKBDO.GioTiecCuoi = Convert.ToString(dr["GioTiecCuoi"]);
                if (!Convert.IsDBNull(dr["PhutTiecCuoi"]))
                    objYeuCauKBDO.PhutTiecCuoi = Convert.ToString(dr["PhutTiecCuoi"]);
                if (!Convert.IsDBNull(dr["YeuCauKhac"]))
                    objYeuCauKBDO.YeuCauKhac = Convert.ToString(dr["YeuCauKhac"]);
                if (!Convert.IsDBNull(dr["TronGoi"]))
                    objYeuCauKBDO.TronGoi = Convert.ToBoolean(dr["TronGoi"]);
                if (!Convert.IsDBNull(dr["SoDichVuTronGoi"]))
                    objYeuCauKBDO.SoDichVuTronGoi = Convert.ToInt32(dr["SoDichVuTronGoi"]);
                if (!Convert.IsDBNull(dr["AHLoaiDamNgo"]))
                    objYeuCauKBDO.AHLoaiDamNgo = Convert.ToString(dr["AHLoaiDamNgo"]);
                if (!Convert.IsDBNull(dr["AHChupNgoaiTroi"]))
                    objYeuCauKBDO.AHChupNgoaiTroi = Convert.ToString(dr["AHChupNgoaiTroi"]);
                if (!Convert.IsDBNull(dr["AHTrapLeAnHoi"]))
                    objYeuCauKBDO.AHTrapLeAnHoi = Convert.ToString(dr["AHTrapLeAnHoi"]);
                if (!Convert.IsDBNull(dr["AHQuayPhim"]))
                    objYeuCauKBDO.AHQuayPhim = Convert.ToString(dr["AHQuayPhim"]);
                if (!Convert.IsDBNull(dr["AHChupAnh"]))
                    objYeuCauKBDO.AHChupAnh = Convert.ToString(dr["AHChupAnh"]);
                if (!Convert.IsDBNull(dr["AHXe16Cho"]))
                    objYeuCauKBDO.AHXe16Cho = Convert.ToString(dr["AHXe16Cho"]);
                if (!Convert.IsDBNull(dr["AHXe29Cho"]))
                    objYeuCauKBDO.AHXe29Cho = Convert.ToString(dr["AHXe29Cho"]);
                if (!Convert.IsDBNull(dr["AHNamBeTrap"]))
                    objYeuCauKBDO.AHNamBeTrap = Convert.ToString(dr["AHNamBeTrap"]);
                if (!Convert.IsDBNull(dr["AHNuDoTrap"]))
                    objYeuCauKBDO.AHNuDoTrap = Convert.ToString(dr["AHNuDoTrap"]);
                if (!Convert.IsDBNull(dr["AHPhongNhaGai"]))
                    objYeuCauKBDO.AHPhongNhaGai = Convert.ToString(dr["AHPhongNhaGai"]);
                if (!Convert.IsDBNull(dr["AHBanGhe"]))
                    objYeuCauKBDO.AHBanGhe = Convert.ToString(dr["AHBanGhe"]);
                if (!Convert.IsDBNull(dr["AHNhaBat"]))
                    objYeuCauKBDO.AHNhaBat = Convert.ToString(dr["AHNhaBat"]);
                if (!Convert.IsDBNull(dr["AHHoaAnHoi"]))
                    objYeuCauKBDO.AHHoaAnHoi = Convert.ToString(dr["AHHoaAnHoi"]);
                if (!Convert.IsDBNull(dr["NCLeXinDau"]))
                    objYeuCauKBDO.NCLeXinDau = Convert.ToBoolean(dr["NCLeXinDau"]);
                if (!Convert.IsDBNull(dr["NCQuayPhim"]))
                    objYeuCauKBDO.NCQuayPhim = Convert.ToString(dr["NCQuayPhim"]);
                if (!Convert.IsDBNull(dr["NCChupAnh"]))
                    objYeuCauKBDO.NCChupAnh = Convert.ToString(dr["NCChupAnh"]);
                if (!Convert.IsDBNull(dr["NCXe4Cho"]))
                    objYeuCauKBDO.NCXe4Cho = Convert.ToString(dr["NCXe4Cho"]);
                if (!Convert.IsDBNull(dr["NCXe16Cho"]))
                    objYeuCauKBDO.NCXe16Cho = Convert.ToString(dr["NCXe16Cho"]);
                if (!Convert.IsDBNull(dr["NCXe29Cho"]))
                    objYeuCauKBDO.NCXe29Cho = Convert.ToString(dr["NCXe29Cho"]);
                if (!Convert.IsDBNull(dr["NCPhongDamCuoi"]))
                    objYeuCauKBDO.NCPhongDamCuoi = Convert.ToString(dr["NCPhongDamCuoi"]);
                if (!Convert.IsDBNull(dr["NCBanGhe"]))
                    objYeuCauKBDO.NCBanGhe = Convert.ToString(dr["NCBanGhe"]);
                if (!Convert.IsDBNull(dr["NCNhaBat"]))
                    objYeuCauKBDO.NCNhaBat = Convert.ToString(dr["NCNhaBat"]);
                if (!Convert.IsDBNull(dr["NCPhao"]))
                    objYeuCauKBDO.NCPhao = Convert.ToString(dr["NCPhao"]);
                if (!Convert.IsDBNull(dr["NCChuHy"]))
                    objYeuCauKBDO.NCChuHy = Convert.ToString(dr["NCChuHy"]);
                if (!Convert.IsDBNull(dr["NCHoaCuoi"]))
                    objYeuCauKBDO.NCHoaCuoi = Convert.ToString(dr["NCHoaCuoi"]);
                if (!Convert.IsDBNull(dr["AHPhaoGiay"]))
                    objYeuCauKBDO.AHPhaoGiay = Convert.ToString(dr["AHPhaoGiay"]);
                if (!Convert.IsDBNull(dr["AHChuHy"]))
                    objYeuCauKBDO.AHChuHy = Convert.ToString(dr["AHChuHy"]);

            }
            return objYeuCauKBDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrYeuCauKBDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    YeuCauKBDO objYeuCauKBDO = new YeuCauKBDO();
                    if (!Convert.IsDBNull(dr["YeuCauKBID"]))
                        objYeuCauKBDO.YeuCauKBID = Convert.ToInt32(dr["YeuCauKBID"]);
                    if (!Convert.IsDBNull(dr["ChapNhan"]))
                        objYeuCauKBDO.ChapNhan = Convert.ToBoolean(dr["ChapNhan"]);
                    if (!Convert.IsDBNull(dr["TenDangNhap"]))
                        objYeuCauKBDO.TenDangNhap = Convert.ToString(dr["TenDangNhap"]);
                    if (!Convert.IsDBNull(dr["MatKhai"]))
                        objYeuCauKBDO.MatKhai = Convert.ToString(dr["MatKhai"]);
                    if (!Convert.IsDBNull(dr["TenChuRe"]))
                        objYeuCauKBDO.TenChuRe = Convert.ToString(dr["TenChuRe"]);
                    if (!Convert.IsDBNull(dr["TenCoDau"]))
                        objYeuCauKBDO.TenCoDau = Convert.ToString(dr["TenCoDau"]);
                    if (!Convert.IsDBNull(dr["DiaChiNhaTrai"]))
                        objYeuCauKBDO.DiaChiNhaTrai = Convert.ToString(dr["DiaChiNhaTrai"]);
                    if (!Convert.IsDBNull(dr["DiaChiNhaGai"]))
                        objYeuCauKBDO.DiaChiNhaGai = Convert.ToString(dr["DiaChiNhaGai"]);
                    if (!Convert.IsDBNull(dr["SoDTChuRe"]))
                        objYeuCauKBDO.SoDTChuRe = Convert.ToString(dr["SoDTChuRe"]);
                    if (!Convert.IsDBNull(dr["SoDTCoDau"]))
                        objYeuCauKBDO.SoDTCoDau = Convert.ToString(dr["SoDTCoDau"]);
                    if (!Convert.IsDBNull(dr["MailChuRe"]))
                        objYeuCauKBDO.MailChuRe = Convert.ToString(dr["MailChuRe"]);
                    if (!Convert.IsDBNull(dr["MailCoDau"]))
                        objYeuCauKBDO.MailCoDau = Convert.ToString(dr["MailCoDau"]);
                    if (!Convert.IsDBNull(dr["DiemTiecNT"]))
                        objYeuCauKBDO.DiemTiecNT = Convert.ToString(dr["DiemTiecNT"]);
                    if (!Convert.IsDBNull(dr["DiemTiecNG"]))
                        objYeuCauKBDO.DiemTiecNG = Convert.ToString(dr["DiemTiecNG"]);
                    if (!Convert.IsDBNull(dr["NgayDamNgo"]))
                        objYeuCauKBDO.NgayDamNgo = Convert.ToString(dr["NgayDamNgo"]);
                    if (!Convert.IsDBNull(dr["GioDamNgo"]))
                        objYeuCauKBDO.GioDamNgo = Convert.ToString(dr["GioDamNgo"]);
                    if (!Convert.IsDBNull(dr["PhutDamNgo"]))
                        objYeuCauKBDO.PhutDamNgo = Convert.ToString(dr["PhutDamNgo"]);
                    if (!Convert.IsDBNull(dr["NgayAnHoi"]))
                        objYeuCauKBDO.NgayAnHoi = Convert.ToString(dr["NgayAnHoi"]);
                    if (!Convert.IsDBNull(dr["GioAnHoi"]))
                        objYeuCauKBDO.GioAnHoi = Convert.ToString(dr["GioAnHoi"]);
                    if (!Convert.IsDBNull(dr["PhutAnHoi"]))
                        objYeuCauKBDO.PhutAnHoi = Convert.ToString(dr["PhutAnHoi"]);
                    if (!Convert.IsDBNull(dr["NgayDonDau"]))
                        objYeuCauKBDO.NgayDonDau = Convert.ToString(dr["NgayDonDau"]);
                    if (!Convert.IsDBNull(dr["GioDonDau"]))
                        objYeuCauKBDO.GioDonDau = Convert.ToString(dr["GioDonDau"]);
                    if (!Convert.IsDBNull(dr["PhuDonDau"]))
                        objYeuCauKBDO.PhuDonDau = Convert.ToString(dr["PhuDonDau"]);
                    if (!Convert.IsDBNull(dr["NgayTiecCuoi"]))
                        objYeuCauKBDO.NgayTiecCuoi = Convert.ToString(dr["NgayTiecCuoi"]);
                    if (!Convert.IsDBNull(dr["GioTiecCuoi"]))
                        objYeuCauKBDO.GioTiecCuoi = Convert.ToString(dr["GioTiecCuoi"]);
                    if (!Convert.IsDBNull(dr["PhutTiecCuoi"]))
                        objYeuCauKBDO.PhutTiecCuoi = Convert.ToString(dr["PhutTiecCuoi"]);
                    if (!Convert.IsDBNull(dr["YeuCauKhac"]))
                        objYeuCauKBDO.YeuCauKhac = Convert.ToString(dr["YeuCauKhac"]);
                    if (!Convert.IsDBNull(dr["TronGoi"]))
                        objYeuCauKBDO.TronGoi = Convert.ToBoolean(dr["TronGoi"]);
                    if (!Convert.IsDBNull(dr["SoDichVuTronGoi"]))
                        objYeuCauKBDO.SoDichVuTronGoi = Convert.ToInt32(dr["SoDichVuTronGoi"]);
                    if (!Convert.IsDBNull(dr["AHLoaiDamNgo"]))
                        objYeuCauKBDO.AHLoaiDamNgo = Convert.ToString(dr["AHLoaiDamNgo"]);
                    if (!Convert.IsDBNull(dr["AHChupNgoaiTroi"]))
                        objYeuCauKBDO.AHChupNgoaiTroi = Convert.ToString(dr["AHChupNgoaiTroi"]);
                    if (!Convert.IsDBNull(dr["AHTrapLeAnHoi"]))
                        objYeuCauKBDO.AHTrapLeAnHoi = Convert.ToString(dr["AHTrapLeAnHoi"]);
                    if (!Convert.IsDBNull(dr["AHQuayPhim"]))
                        objYeuCauKBDO.AHQuayPhim = Convert.ToString(dr["AHQuayPhim"]);
                    if (!Convert.IsDBNull(dr["AHChupAnh"]))
                        objYeuCauKBDO.AHChupAnh = Convert.ToString(dr["AHChupAnh"]);
                    if (!Convert.IsDBNull(dr["AHXe16Cho"]))
                        objYeuCauKBDO.AHXe16Cho = Convert.ToString(dr["AHXe16Cho"]);
                    if (!Convert.IsDBNull(dr["AHXe29Cho"]))
                        objYeuCauKBDO.AHXe29Cho = Convert.ToString(dr["AHXe29Cho"]);
                    if (!Convert.IsDBNull(dr["AHNamBeTrap"]))
                        objYeuCauKBDO.AHNamBeTrap = Convert.ToString(dr["AHNamBeTrap"]);
                    if (!Convert.IsDBNull(dr["AHNuDoTrap"]))
                        objYeuCauKBDO.AHNuDoTrap = Convert.ToString(dr["AHNuDoTrap"]);
                    if (!Convert.IsDBNull(dr["AHPhongNhaGai"]))
                        objYeuCauKBDO.AHPhongNhaGai = Convert.ToString(dr["AHPhongNhaGai"]);
                    if (!Convert.IsDBNull(dr["AHBanGhe"]))
                        objYeuCauKBDO.AHBanGhe = Convert.ToString(dr["AHBanGhe"]);
                    if (!Convert.IsDBNull(dr["AHNhaBat"]))
                        objYeuCauKBDO.AHNhaBat = Convert.ToString(dr["AHNhaBat"]);
                    if (!Convert.IsDBNull(dr["AHHoaAnHoi"]))
                        objYeuCauKBDO.AHHoaAnHoi = Convert.ToString(dr["AHHoaAnHoi"]);
                    if (!Convert.IsDBNull(dr["NCLeXinDau"]))
                        objYeuCauKBDO.NCLeXinDau = Convert.ToBoolean(dr["NCLeXinDau"]);
                    if (!Convert.IsDBNull(dr["NCQuayPhim"]))
                        objYeuCauKBDO.NCQuayPhim = Convert.ToString(dr["NCQuayPhim"]);
                    if (!Convert.IsDBNull(dr["NCChupAnh"]))
                        objYeuCauKBDO.NCChupAnh = Convert.ToString(dr["NCChupAnh"]);
                    if (!Convert.IsDBNull(dr["NCXe4Cho"]))
                        objYeuCauKBDO.NCXe4Cho = Convert.ToString(dr["NCXe4Cho"]);
                    if (!Convert.IsDBNull(dr["NCXe16Cho"]))
                        objYeuCauKBDO.NCXe16Cho = Convert.ToString(dr["NCXe16Cho"]);
                    if (!Convert.IsDBNull(dr["NCXe29Cho"]))
                        objYeuCauKBDO.NCXe29Cho = Convert.ToString(dr["NCXe29Cho"]);
                    if (!Convert.IsDBNull(dr["NCPhongDamCuoi"]))
                        objYeuCauKBDO.NCPhongDamCuoi = Convert.ToString(dr["NCPhongDamCuoi"]);
                    if (!Convert.IsDBNull(dr["NCBanGhe"]))
                        objYeuCauKBDO.NCBanGhe = Convert.ToString(dr["NCBanGhe"]);
                    if (!Convert.IsDBNull(dr["NCNhaBat"]))
                        objYeuCauKBDO.NCNhaBat = Convert.ToString(dr["NCNhaBat"]);
                    if (!Convert.IsDBNull(dr["NCPhao"]))
                        objYeuCauKBDO.NCPhao = Convert.ToString(dr["NCPhao"]);
                    if (!Convert.IsDBNull(dr["NCChuHy"]))
                        objYeuCauKBDO.NCChuHy = Convert.ToString(dr["NCChuHy"]);
                    if (!Convert.IsDBNull(dr["NCHoaCuoi"]))
                        objYeuCauKBDO.NCHoaCuoi = Convert.ToString(dr["NCHoaCuoi"]);
                    if (!Convert.IsDBNull(dr["AHPhaoGiay"]))
                        objYeuCauKBDO.AHPhaoGiay = Convert.ToString(dr["AHPhaoGiay"]);
                    if (!Convert.IsDBNull(dr["AHChuHy"]))
                        objYeuCauKBDO.AHChuHy = Convert.ToString(dr["AHChuHy"]);
                    arrYeuCauKBDO.Add(objYeuCauKBDO);
                }
            }
            return arrYeuCauKBDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        public DataTable SelectByAccept(int accept)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_GetByAccept";

            SqlParameter Sqlparam;
            Sqlparam = new SqlParameter("@IsAccept", SqlDbType.Int);
            Sqlparam.Value = accept;
            Sqlcomm.Parameters.Add(Sqlparam);


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectLogin(string username, string password)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spYeuCauKB_GetByLogin";

            SqlParameter Sqlparam;
            Sqlparam = new SqlParameter("@username", SqlDbType.NVarChar);
            Sqlparam.Value = username;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@password", SqlDbType.NVarChar);
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

        #endregion

    }

}
