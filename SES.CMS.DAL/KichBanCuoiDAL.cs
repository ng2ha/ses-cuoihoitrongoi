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
/// Summary description for KichBanCuoiDAL
/// </summary>
namespace SES.CMS.DAL
{

    public class KichBanCuoiDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public KichBanCuoiDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(KichBanCuoiDO objKichBanCuoiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@YeuCauKBID", SqlDbType.Int);
            Sqlparam.Value = objKichBanCuoiDO.YeuCauKBID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioNTKhoiHanhAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.GioNTKhoiHanhAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioNTKhoiHanhTH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.GioNTKhoiHanhTH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DVLeAnHoi", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.DVLeAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHLoTrinhNTNG", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.AHLoTrinhNTNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHLoTrinhNGNT", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.AHLoTrinhNGNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGTrapNamCoMatNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGTrapNamCoMatNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGTrapNuCoMatNG", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGTrapNuCoMatNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DVLeCuoi", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.DVLeCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@XeGanHoa", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.XeGanHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@XeCoMatNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.XeCoMatNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@LCLoTrinhNTNG", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.LCLoTrinhNTNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@LCLoTrinhNGNT", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.LCLoTrinhNGNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@LCLoTrinhNGRaDT", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.LCLoTrinhNGRaDT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTChupAnhTrapAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTChupAnhTrapAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTKhoiHanhNhatraiAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTKhoiHanhNhatraiAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTDenNhaGaiNgoiAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTDenNhaGaiNgoiAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTTrapNamMangLeLQVeAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTTrapNamMangLeLQVeAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTLayLeXinDauCuaHangLC", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTLayLeXinDauCuaHangLC;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTDoanXinDenNTLC", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTDoanXinDenNTLC;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QT2NguoiVaoNG", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QT2NguoiVaoNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNGDonNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNGDonNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNTOnDinhCho", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNTOnDinhCho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNTXinPhepHoa", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNTXinPhepHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNGDiCungNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNGDiCungNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QT2HoOnDinh", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QT2HoOnDinh;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QT2NhaRaDiemTiec", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QT2NhaRaDiemTiec;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@CDCRDenTruocDon", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.CDCRDenTruocDon;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BoMeDonKhach", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.BoMeDonKhach;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BoMeCamOn", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.BoMeCamOn;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN1", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN2", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN3", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN4", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN5", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN5;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN1", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN2", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN3", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN4", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG1", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG2", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG3", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG4", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG5", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG5;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(KichBanCuoiDO objKichBanCuoiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@KichBanCuoiID", SqlDbType.Int);
            Sqlparam.Value = objKichBanCuoiDO.KichBanCuoiID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@YeuCauKBID", SqlDbType.Int);
            Sqlparam.Value = objKichBanCuoiDO.YeuCauKBID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioNTKhoiHanhAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.GioNTKhoiHanhAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@GioNTKhoiHanhTH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.GioNTKhoiHanhTH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeDamNgo", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeDamNgo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DVLeAnHoi", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.DVLeAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeAnHoi", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeAnHoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHLoTrinhNTNG", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.AHLoTrinhNTNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AHLoTrinhNGNT", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.AHLoTrinhNGNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGTrapNamCoMatNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGTrapNamCoMatNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGTrapNuCoMatNG", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGTrapNuCoMatNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DVLeCuoi", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.DVLeCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoi", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoi;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@XeGanHoa", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.XeGanHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@XeCoMatNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.XeCoMatNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@LCLoTrinhNTNG", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.LCLoTrinhNTNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@LCLoTrinhNGNT", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.LCLoTrinhNGNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@LCLoTrinhNGRaDT", SqlDbType.NText);
            Sqlparam.Value = objKichBanCuoiDO.LCLoTrinhNGRaDT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTChupAnhTrapAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTChupAnhTrapAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTKhoiHanhNhatraiAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTKhoiHanhNhatraiAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTDenNhaGaiNgoiAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTDenNhaGaiNgoiAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTTrapNamMangLeLQVeAH", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTTrapNamMangLeLQVeAH;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTLayLeXinDauCuaHangLC", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTLayLeXinDauCuaHangLC;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTDoanXinDenNTLC", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTDoanXinDenNTLC;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QT2NguoiVaoNG", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QT2NguoiVaoNG;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNGDonNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNGDonNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNTOnDinhCho", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNTOnDinhCho;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNTXinPhepHoa", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNTXinPhepHoa;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QTNGDiCungNT", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QTNGDiCungNT;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QT2HoOnDinh", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QT2HoOnDinh;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@QT2NhaRaDiemTiec", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.QT2NhaRaDiemTiec;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@CDCRDenTruocDon", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.CDCRDenTruocDon;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BoMeDonKhach", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.BoMeDonKhach;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BoMeCamOn", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.BoMeCamOn;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN1", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN2", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN3", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN4", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGAnHoiN5", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGAnHoiN5;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN1", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN2", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN3", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TGLeCuoiN4", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.TGLeCuoiN4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG1", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG1;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG2", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG2;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG3", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG3;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG4", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG4;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ExtCHTG5", SqlDbType.NVarChar);
            Sqlparam.Value = objKichBanCuoiDO.ExtCHTG5;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(KichBanCuoiDO objKichBanCuoiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@KichBanCuoiID", SqlDbType.Int);
            Sqlparam.Value = objKichBanCuoiDO.KichBanCuoiID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public KichBanCuoiDO Select(KichBanCuoiDO objKichBanCuoiDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@KichBanCuoiID", SqlDbType.Int);
            Sqlparam.Value = objKichBanCuoiDO.KichBanCuoiID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["KichBanCuoiID"]))
                    objKichBanCuoiDO.KichBanCuoiID = Convert.ToInt32(dr["KichBanCuoiID"]);
                if (!Convert.IsDBNull(dr["YeuCauKBID"]))
                    objKichBanCuoiDO.YeuCauKBID = Convert.ToInt32(dr["YeuCauKBID"]);
                if (!Convert.IsDBNull(dr["GioNTKhoiHanhAH"]))
                    objKichBanCuoiDO.GioNTKhoiHanhAH = Convert.ToString(dr["GioNTKhoiHanhAH"]);
                if (!Convert.IsDBNull(dr["GioNTKhoiHanhTH"]))
                    objKichBanCuoiDO.GioNTKhoiHanhTH = Convert.ToString(dr["GioNTKhoiHanhTH"]);
                if (!Convert.IsDBNull(dr["TGLeDamNgo"]))
                    objKichBanCuoiDO.TGLeDamNgo = Convert.ToString(dr["TGLeDamNgo"]);
                if (!Convert.IsDBNull(dr["DVLeAnHoi"]))
                    objKichBanCuoiDO.DVLeAnHoi = Convert.ToString(dr["DVLeAnHoi"]);
                if (!Convert.IsDBNull(dr["TGLeAnHoi"]))
                    objKichBanCuoiDO.TGLeAnHoi = Convert.ToString(dr["TGLeAnHoi"]);
                if (!Convert.IsDBNull(dr["AHLoTrinhNTNG"]))
                    objKichBanCuoiDO.AHLoTrinhNTNG = Convert.ToString(dr["AHLoTrinhNTNG"]);
                if (!Convert.IsDBNull(dr["AHLoTrinhNGNT"]))
                    objKichBanCuoiDO.AHLoTrinhNGNT = Convert.ToString(dr["AHLoTrinhNGNT"]);
                if (!Convert.IsDBNull(dr["TGTrapNamCoMatNT"]))
                    objKichBanCuoiDO.TGTrapNamCoMatNT = Convert.ToString(dr["TGTrapNamCoMatNT"]);
                if (!Convert.IsDBNull(dr["TGTrapNuCoMatNG"]))
                    objKichBanCuoiDO.TGTrapNuCoMatNG = Convert.ToString(dr["TGTrapNuCoMatNG"]);
                if (!Convert.IsDBNull(dr["DVLeCuoi"]))
                    objKichBanCuoiDO.DVLeCuoi = Convert.ToString(dr["DVLeCuoi"]);
                if (!Convert.IsDBNull(dr["TGLeCuoi"]))
                    objKichBanCuoiDO.TGLeCuoi = Convert.ToString(dr["TGLeCuoi"]);
                if (!Convert.IsDBNull(dr["XeGanHoa"]))
                    objKichBanCuoiDO.XeGanHoa = Convert.ToString(dr["XeGanHoa"]);
                if (!Convert.IsDBNull(dr["XeCoMatNT"]))
                    objKichBanCuoiDO.XeCoMatNT = Convert.ToString(dr["XeCoMatNT"]);
                if (!Convert.IsDBNull(dr["LCLoTrinhNTNG"]))
                    objKichBanCuoiDO.LCLoTrinhNTNG = Convert.ToString(dr["LCLoTrinhNTNG"]);
                if (!Convert.IsDBNull(dr["LCLoTrinhNGNT"]))
                    objKichBanCuoiDO.LCLoTrinhNGNT = Convert.ToString(dr["LCLoTrinhNGNT"]);
                if (!Convert.IsDBNull(dr["LCLoTrinhNGRaDT"]))
                    objKichBanCuoiDO.LCLoTrinhNGRaDT = Convert.ToString(dr["LCLoTrinhNGRaDT"]);
                if (!Convert.IsDBNull(dr["QTChupAnhTrapAH"]))
                    objKichBanCuoiDO.QTChupAnhTrapAH = Convert.ToString(dr["QTChupAnhTrapAH"]);
                if (!Convert.IsDBNull(dr["QTKhoiHanhNhatraiAH"]))
                    objKichBanCuoiDO.QTKhoiHanhNhatraiAH = Convert.ToString(dr["QTKhoiHanhNhatraiAH"]);
                if (!Convert.IsDBNull(dr["QTDenNhaGaiNgoiAH"]))
                    objKichBanCuoiDO.QTDenNhaGaiNgoiAH = Convert.ToString(dr["QTDenNhaGaiNgoiAH"]);
                if (!Convert.IsDBNull(dr["QTTrapNamMangLeLQVeAH"]))
                    objKichBanCuoiDO.QTTrapNamMangLeLQVeAH = Convert.ToString(dr["QTTrapNamMangLeLQVeAH"]);
                if (!Convert.IsDBNull(dr["QTLayLeXinDauCuaHangLC"]))
                    objKichBanCuoiDO.QTLayLeXinDauCuaHangLC = Convert.ToString(dr["QTLayLeXinDauCuaHangLC"]);
                if (!Convert.IsDBNull(dr["QTDoanXinDenNTLC"]))
                    objKichBanCuoiDO.QTDoanXinDenNTLC = Convert.ToString(dr["QTDoanXinDenNTLC"]);
                if (!Convert.IsDBNull(dr["QT2NguoiVaoNG"]))
                    objKichBanCuoiDO.QT2NguoiVaoNG = Convert.ToString(dr["QT2NguoiVaoNG"]);
                if (!Convert.IsDBNull(dr["QTNGDonNT"]))
                    objKichBanCuoiDO.QTNGDonNT = Convert.ToString(dr["QTNGDonNT"]);
                if (!Convert.IsDBNull(dr["QTNTOnDinhCho"]))
                    objKichBanCuoiDO.QTNTOnDinhCho = Convert.ToString(dr["QTNTOnDinhCho"]);
                if (!Convert.IsDBNull(dr["QTNTXinPhepHoa"]))
                    objKichBanCuoiDO.QTNTXinPhepHoa = Convert.ToString(dr["QTNTXinPhepHoa"]);
                if (!Convert.IsDBNull(dr["QTNGDiCungNT"]))
                    objKichBanCuoiDO.QTNGDiCungNT = Convert.ToString(dr["QTNGDiCungNT"]);
                if (!Convert.IsDBNull(dr["QT2HoOnDinh"]))
                    objKichBanCuoiDO.QT2HoOnDinh = Convert.ToString(dr["QT2HoOnDinh"]);
                if (!Convert.IsDBNull(dr["QT2NhaRaDiemTiec"]))
                    objKichBanCuoiDO.QT2NhaRaDiemTiec = Convert.ToString(dr["QT2NhaRaDiemTiec"]);
                if (!Convert.IsDBNull(dr["CDCRDenTruocDon"]))
                    objKichBanCuoiDO.CDCRDenTruocDon = Convert.ToString(dr["CDCRDenTruocDon"]);
                if (!Convert.IsDBNull(dr["BoMeDonKhach"]))
                    objKichBanCuoiDO.BoMeDonKhach = Convert.ToString(dr["BoMeDonKhach"]);
                if (!Convert.IsDBNull(dr["BoMeCamOn"]))
                    objKichBanCuoiDO.BoMeCamOn = Convert.ToString(dr["BoMeCamOn"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN1"]))
                    objKichBanCuoiDO.TGAnHoiN1 = Convert.ToString(dr["TGAnHoiN1"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN2"]))
                    objKichBanCuoiDO.TGAnHoiN2 = Convert.ToString(dr["TGAnHoiN2"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN3"]))
                    objKichBanCuoiDO.TGAnHoiN3 = Convert.ToString(dr["TGAnHoiN3"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN4"]))
                    objKichBanCuoiDO.TGAnHoiN4 = Convert.ToString(dr["TGAnHoiN4"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN5"]))
                    objKichBanCuoiDO.TGAnHoiN5 = Convert.ToString(dr["TGAnHoiN5"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN1"]))
                    objKichBanCuoiDO.TGLeCuoiN1 = Convert.ToString(dr["TGLeCuoiN1"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN2"]))
                    objKichBanCuoiDO.TGLeCuoiN2 = Convert.ToString(dr["TGLeCuoiN2"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN3"]))
                    objKichBanCuoiDO.TGLeCuoiN3 = Convert.ToString(dr["TGLeCuoiN3"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN4"]))
                    objKichBanCuoiDO.TGLeCuoiN4 = Convert.ToString(dr["TGLeCuoiN4"]);
                if (!Convert.IsDBNull(dr["ExtCHTG1"]))
                    objKichBanCuoiDO.ExtCHTG1 = Convert.ToString(dr["ExtCHTG1"]);
                if (!Convert.IsDBNull(dr["ExtCHTG2"]))
                    objKichBanCuoiDO.ExtCHTG2 = Convert.ToString(dr["ExtCHTG2"]);
                if (!Convert.IsDBNull(dr["ExtCHTG3"]))
                    objKichBanCuoiDO.ExtCHTG3 = Convert.ToString(dr["ExtCHTG3"]);
                if (!Convert.IsDBNull(dr["ExtCHTG4"]))
                    objKichBanCuoiDO.ExtCHTG4 = Convert.ToString(dr["ExtCHTG4"]);
                if (!Convert.IsDBNull(dr["ExtCHTG5"]))
                    objKichBanCuoiDO.ExtCHTG5 = Convert.ToString(dr["ExtCHTG5"]);

            }
            return objKichBanCuoiDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrKichBanCuoiDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    KichBanCuoiDO objKichBanCuoiDO = new KichBanCuoiDO();
                    if (!Convert.IsDBNull(dr["KichBanCuoiID"]))
                        objKichBanCuoiDO.KichBanCuoiID = Convert.ToInt32(dr["KichBanCuoiID"]);
                    if (!Convert.IsDBNull(dr["YeuCauKBID"]))
                        objKichBanCuoiDO.YeuCauKBID = Convert.ToInt32(dr["YeuCauKBID"]);
                    if (!Convert.IsDBNull(dr["GioNTKhoiHanhAH"]))
                        objKichBanCuoiDO.GioNTKhoiHanhAH = Convert.ToString(dr["GioNTKhoiHanhAH"]);
                    if (!Convert.IsDBNull(dr["GioNTKhoiHanhTH"]))
                        objKichBanCuoiDO.GioNTKhoiHanhTH = Convert.ToString(dr["GioNTKhoiHanhTH"]);
                    if (!Convert.IsDBNull(dr["TGLeDamNgo"]))
                        objKichBanCuoiDO.TGLeDamNgo = Convert.ToString(dr["TGLeDamNgo"]);
                    if (!Convert.IsDBNull(dr["DVLeAnHoi"]))
                        objKichBanCuoiDO.DVLeAnHoi = Convert.ToString(dr["DVLeAnHoi"]);
                    if (!Convert.IsDBNull(dr["TGLeAnHoi"]))
                        objKichBanCuoiDO.TGLeAnHoi = Convert.ToString(dr["TGLeAnHoi"]);
                    if (!Convert.IsDBNull(dr["AHLoTrinhNTNG"]))
                        objKichBanCuoiDO.AHLoTrinhNTNG = Convert.ToString(dr["AHLoTrinhNTNG"]);
                    if (!Convert.IsDBNull(dr["AHLoTrinhNGNT"]))
                        objKichBanCuoiDO.AHLoTrinhNGNT = Convert.ToString(dr["AHLoTrinhNGNT"]);
                    if (!Convert.IsDBNull(dr["TGTrapNamCoMatNT"]))
                        objKichBanCuoiDO.TGTrapNamCoMatNT = Convert.ToString(dr["TGTrapNamCoMatNT"]);
                    if (!Convert.IsDBNull(dr["TGTrapNuCoMatNG"]))
                        objKichBanCuoiDO.TGTrapNuCoMatNG = Convert.ToString(dr["TGTrapNuCoMatNG"]);
                    if (!Convert.IsDBNull(dr["DVLeCuoi"]))
                        objKichBanCuoiDO.DVLeCuoi = Convert.ToString(dr["DVLeCuoi"]);
                    if (!Convert.IsDBNull(dr["TGLeCuoi"]))
                        objKichBanCuoiDO.TGLeCuoi = Convert.ToString(dr["TGLeCuoi"]);
                    if (!Convert.IsDBNull(dr["XeGanHoa"]))
                        objKichBanCuoiDO.XeGanHoa = Convert.ToString(dr["XeGanHoa"]);
                    if (!Convert.IsDBNull(dr["XeCoMatNT"]))
                        objKichBanCuoiDO.XeCoMatNT = Convert.ToString(dr["XeCoMatNT"]);
                    if (!Convert.IsDBNull(dr["LCLoTrinhNTNG"]))
                        objKichBanCuoiDO.LCLoTrinhNTNG = Convert.ToString(dr["LCLoTrinhNTNG"]);
                    if (!Convert.IsDBNull(dr["LCLoTrinhNGNT"]))
                        objKichBanCuoiDO.LCLoTrinhNGNT = Convert.ToString(dr["LCLoTrinhNGNT"]);
                    if (!Convert.IsDBNull(dr["LCLoTrinhNGRaDT"]))
                        objKichBanCuoiDO.LCLoTrinhNGRaDT = Convert.ToString(dr["LCLoTrinhNGRaDT"]);
                    if (!Convert.IsDBNull(dr["QTChupAnhTrapAH"]))
                        objKichBanCuoiDO.QTChupAnhTrapAH = Convert.ToString(dr["QTChupAnhTrapAH"]);
                    if (!Convert.IsDBNull(dr["QTKhoiHanhNhatraiAH"]))
                        objKichBanCuoiDO.QTKhoiHanhNhatraiAH = Convert.ToString(dr["QTKhoiHanhNhatraiAH"]);
                    if (!Convert.IsDBNull(dr["QTDenNhaGaiNgoiAH"]))
                        objKichBanCuoiDO.QTDenNhaGaiNgoiAH = Convert.ToString(dr["QTDenNhaGaiNgoiAH"]);
                    if (!Convert.IsDBNull(dr["QTTrapNamMangLeLQVeAH"]))
                        objKichBanCuoiDO.QTTrapNamMangLeLQVeAH = Convert.ToString(dr["QTTrapNamMangLeLQVeAH"]);
                    if (!Convert.IsDBNull(dr["QTLayLeXinDauCuaHangLC"]))
                        objKichBanCuoiDO.QTLayLeXinDauCuaHangLC = Convert.ToString(dr["QTLayLeXinDauCuaHangLC"]);
                    if (!Convert.IsDBNull(dr["QTDoanXinDenNTLC"]))
                        objKichBanCuoiDO.QTDoanXinDenNTLC = Convert.ToString(dr["QTDoanXinDenNTLC"]);
                    if (!Convert.IsDBNull(dr["QT2NguoiVaoNG"]))
                        objKichBanCuoiDO.QT2NguoiVaoNG = Convert.ToString(dr["QT2NguoiVaoNG"]);
                    if (!Convert.IsDBNull(dr["QTNGDonNT"]))
                        objKichBanCuoiDO.QTNGDonNT = Convert.ToString(dr["QTNGDonNT"]);
                    if (!Convert.IsDBNull(dr["QTNTOnDinhCho"]))
                        objKichBanCuoiDO.QTNTOnDinhCho = Convert.ToString(dr["QTNTOnDinhCho"]);
                    if (!Convert.IsDBNull(dr["QTNTXinPhepHoa"]))
                        objKichBanCuoiDO.QTNTXinPhepHoa = Convert.ToString(dr["QTNTXinPhepHoa"]);
                    if (!Convert.IsDBNull(dr["QTNGDiCungNT"]))
                        objKichBanCuoiDO.QTNGDiCungNT = Convert.ToString(dr["QTNGDiCungNT"]);
                    if (!Convert.IsDBNull(dr["QT2HoOnDinh"]))
                        objKichBanCuoiDO.QT2HoOnDinh = Convert.ToString(dr["QT2HoOnDinh"]);
                    if (!Convert.IsDBNull(dr["QT2NhaRaDiemTiec"]))
                        objKichBanCuoiDO.QT2NhaRaDiemTiec = Convert.ToString(dr["QT2NhaRaDiemTiec"]);
                    if (!Convert.IsDBNull(dr["CDCRDenTruocDon"]))
                        objKichBanCuoiDO.CDCRDenTruocDon = Convert.ToString(dr["CDCRDenTruocDon"]);
                    if (!Convert.IsDBNull(dr["BoMeDonKhach"]))
                        objKichBanCuoiDO.BoMeDonKhach = Convert.ToString(dr["BoMeDonKhach"]);
                    if (!Convert.IsDBNull(dr["BoMeCamOn"]))
                        objKichBanCuoiDO.BoMeCamOn = Convert.ToString(dr["BoMeCamOn"]);
                    if (!Convert.IsDBNull(dr["TGAnHoiN1"]))
                        objKichBanCuoiDO.TGAnHoiN1 = Convert.ToString(dr["TGAnHoiN1"]);
                    if (!Convert.IsDBNull(dr["TGAnHoiN2"]))
                        objKichBanCuoiDO.TGAnHoiN2 = Convert.ToString(dr["TGAnHoiN2"]);
                    if (!Convert.IsDBNull(dr["TGAnHoiN3"]))
                        objKichBanCuoiDO.TGAnHoiN3 = Convert.ToString(dr["TGAnHoiN3"]);
                    if (!Convert.IsDBNull(dr["TGAnHoiN4"]))
                        objKichBanCuoiDO.TGAnHoiN4 = Convert.ToString(dr["TGAnHoiN4"]);
                    if (!Convert.IsDBNull(dr["TGAnHoiN5"]))
                        objKichBanCuoiDO.TGAnHoiN5 = Convert.ToString(dr["TGAnHoiN5"]);
                    if (!Convert.IsDBNull(dr["TGLeCuoiN1"]))
                        objKichBanCuoiDO.TGLeCuoiN1 = Convert.ToString(dr["TGLeCuoiN1"]);
                    if (!Convert.IsDBNull(dr["TGLeCuoiN2"]))
                        objKichBanCuoiDO.TGLeCuoiN2 = Convert.ToString(dr["TGLeCuoiN2"]);
                    if (!Convert.IsDBNull(dr["TGLeCuoiN3"]))
                        objKichBanCuoiDO.TGLeCuoiN3 = Convert.ToString(dr["TGLeCuoiN3"]);
                    if (!Convert.IsDBNull(dr["TGLeCuoiN4"]))
                        objKichBanCuoiDO.TGLeCuoiN4 = Convert.ToString(dr["TGLeCuoiN4"]);
                    if (!Convert.IsDBNull(dr["ExtCHTG1"]))
                        objKichBanCuoiDO.ExtCHTG1 = Convert.ToString(dr["ExtCHTG1"]);
                    if (!Convert.IsDBNull(dr["ExtCHTG2"]))
                        objKichBanCuoiDO.ExtCHTG2 = Convert.ToString(dr["ExtCHTG2"]);
                    if (!Convert.IsDBNull(dr["ExtCHTG3"]))
                        objKichBanCuoiDO.ExtCHTG3 = Convert.ToString(dr["ExtCHTG3"]);
                    if (!Convert.IsDBNull(dr["ExtCHTG4"]))
                        objKichBanCuoiDO.ExtCHTG4 = Convert.ToString(dr["ExtCHTG4"]);
                    if (!Convert.IsDBNull(dr["ExtCHTG5"]))
                        objKichBanCuoiDO.ExtCHTG5 = Convert.ToString(dr["ExtCHTG5"]);
                    arrKichBanCuoiDO.Add(objKichBanCuoiDO);
                }
            }
            return arrKichBanCuoiDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public KichBanCuoiDO SelectByYC(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spKichBanCuoi_GetByYeuCauKBID";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@YeuCauKBID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            KichBanCuoiDO objKichBanCuoiDO = new KichBanCuoiDO();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["KichBanCuoiID"]))
                    objKichBanCuoiDO.KichBanCuoiID = Convert.ToInt32(dr["KichBanCuoiID"]);
                if (!Convert.IsDBNull(dr["YeuCauKBID"]))
                    objKichBanCuoiDO.YeuCauKBID = Convert.ToInt32(dr["YeuCauKBID"]);
                if (!Convert.IsDBNull(dr["GioNTKhoiHanhAH"]))
                    objKichBanCuoiDO.GioNTKhoiHanhAH = Convert.ToString(dr["GioNTKhoiHanhAH"]);
                if (!Convert.IsDBNull(dr["GioNTKhoiHanhTH"]))
                    objKichBanCuoiDO.GioNTKhoiHanhTH = Convert.ToString(dr["GioNTKhoiHanhTH"]);
                if (!Convert.IsDBNull(dr["TGLeDamNgo"]))
                    objKichBanCuoiDO.TGLeDamNgo = Convert.ToString(dr["TGLeDamNgo"]);
                if (!Convert.IsDBNull(dr["DVLeAnHoi"]))
                    objKichBanCuoiDO.DVLeAnHoi = Convert.ToString(dr["DVLeAnHoi"]);
                if (!Convert.IsDBNull(dr["TGLeAnHoi"]))
                    objKichBanCuoiDO.TGLeAnHoi = Convert.ToString(dr["TGLeAnHoi"]);
                if (!Convert.IsDBNull(dr["AHLoTrinhNTNG"]))
                    objKichBanCuoiDO.AHLoTrinhNTNG = Convert.ToString(dr["AHLoTrinhNTNG"]);
                if (!Convert.IsDBNull(dr["AHLoTrinhNGNT"]))
                    objKichBanCuoiDO.AHLoTrinhNGNT = Convert.ToString(dr["AHLoTrinhNGNT"]);
                if (!Convert.IsDBNull(dr["TGTrapNamCoMatNT"]))
                    objKichBanCuoiDO.TGTrapNamCoMatNT = Convert.ToString(dr["TGTrapNamCoMatNT"]);
                if (!Convert.IsDBNull(dr["TGTrapNuCoMatNG"]))
                    objKichBanCuoiDO.TGTrapNuCoMatNG = Convert.ToString(dr["TGTrapNuCoMatNG"]);
                if (!Convert.IsDBNull(dr["DVLeCuoi"]))
                    objKichBanCuoiDO.DVLeCuoi = Convert.ToString(dr["DVLeCuoi"]);
                if (!Convert.IsDBNull(dr["TGLeCuoi"]))
                    objKichBanCuoiDO.TGLeCuoi = Convert.ToString(dr["TGLeCuoi"]);
                if (!Convert.IsDBNull(dr["XeGanHoa"]))
                    objKichBanCuoiDO.XeGanHoa = Convert.ToString(dr["XeGanHoa"]);
                if (!Convert.IsDBNull(dr["XeCoMatNT"]))
                    objKichBanCuoiDO.XeCoMatNT = Convert.ToString(dr["XeCoMatNT"]);
                if (!Convert.IsDBNull(dr["LCLoTrinhNTNG"]))
                    objKichBanCuoiDO.LCLoTrinhNTNG = Convert.ToString(dr["LCLoTrinhNTNG"]);
                if (!Convert.IsDBNull(dr["LCLoTrinhNGNT"]))
                    objKichBanCuoiDO.LCLoTrinhNGNT = Convert.ToString(dr["LCLoTrinhNGNT"]);
                if (!Convert.IsDBNull(dr["LCLoTrinhNGRaDT"]))
                    objKichBanCuoiDO.LCLoTrinhNGRaDT = Convert.ToString(dr["LCLoTrinhNGRaDT"]);
                if (!Convert.IsDBNull(dr["QTChupAnhTrapAH"]))
                    objKichBanCuoiDO.QTChupAnhTrapAH = Convert.ToString(dr["QTChupAnhTrapAH"]);
                if (!Convert.IsDBNull(dr["QTKhoiHanhNhatraiAH"]))
                    objKichBanCuoiDO.QTKhoiHanhNhatraiAH = Convert.ToString(dr["QTKhoiHanhNhatraiAH"]);
                if (!Convert.IsDBNull(dr["QTDenNhaGaiNgoiAH"]))
                    objKichBanCuoiDO.QTDenNhaGaiNgoiAH = Convert.ToString(dr["QTDenNhaGaiNgoiAH"]);
                if (!Convert.IsDBNull(dr["QTTrapNamMangLeLQVeAH"]))
                    objKichBanCuoiDO.QTTrapNamMangLeLQVeAH = Convert.ToString(dr["QTTrapNamMangLeLQVeAH"]);
                if (!Convert.IsDBNull(dr["QTLayLeXinDauCuaHangLC"]))
                    objKichBanCuoiDO.QTLayLeXinDauCuaHangLC = Convert.ToString(dr["QTLayLeXinDauCuaHangLC"]);
                if (!Convert.IsDBNull(dr["QTDoanXinDenNTLC"]))
                    objKichBanCuoiDO.QTDoanXinDenNTLC = Convert.ToString(dr["QTDoanXinDenNTLC"]);
                if (!Convert.IsDBNull(dr["QT2NguoiVaoNG"]))
                    objKichBanCuoiDO.QT2NguoiVaoNG = Convert.ToString(dr["QT2NguoiVaoNG"]);
                if (!Convert.IsDBNull(dr["QTNGDonNT"]))
                    objKichBanCuoiDO.QTNGDonNT = Convert.ToString(dr["QTNGDonNT"]);
                if (!Convert.IsDBNull(dr["QTNTOnDinhCho"]))
                    objKichBanCuoiDO.QTNTOnDinhCho = Convert.ToString(dr["QTNTOnDinhCho"]);
                if (!Convert.IsDBNull(dr["QTNTXinPhepHoa"]))
                    objKichBanCuoiDO.QTNTXinPhepHoa = Convert.ToString(dr["QTNTXinPhepHoa"]);
                if (!Convert.IsDBNull(dr["QTNGDiCungNT"]))
                    objKichBanCuoiDO.QTNGDiCungNT = Convert.ToString(dr["QTNGDiCungNT"]);
                if (!Convert.IsDBNull(dr["QT2HoOnDinh"]))
                    objKichBanCuoiDO.QT2HoOnDinh = Convert.ToString(dr["QT2HoOnDinh"]);
                if (!Convert.IsDBNull(dr["QT2NhaRaDiemTiec"]))
                    objKichBanCuoiDO.QT2NhaRaDiemTiec = Convert.ToString(dr["QT2NhaRaDiemTiec"]);
                if (!Convert.IsDBNull(dr["CDCRDenTruocDon"]))
                    objKichBanCuoiDO.CDCRDenTruocDon = Convert.ToString(dr["CDCRDenTruocDon"]);
                if (!Convert.IsDBNull(dr["BoMeDonKhach"]))
                    objKichBanCuoiDO.BoMeDonKhach = Convert.ToString(dr["BoMeDonKhach"]);
                if (!Convert.IsDBNull(dr["BoMeCamOn"]))
                    objKichBanCuoiDO.BoMeCamOn = Convert.ToString(dr["BoMeCamOn"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN1"]))
                    objKichBanCuoiDO.TGAnHoiN1 = Convert.ToString(dr["TGAnHoiN1"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN2"]))
                    objKichBanCuoiDO.TGAnHoiN2 = Convert.ToString(dr["TGAnHoiN2"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN3"]))
                    objKichBanCuoiDO.TGAnHoiN3 = Convert.ToString(dr["TGAnHoiN3"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN4"]))
                    objKichBanCuoiDO.TGAnHoiN4 = Convert.ToString(dr["TGAnHoiN4"]);
                if (!Convert.IsDBNull(dr["TGAnHoiN5"]))
                    objKichBanCuoiDO.TGAnHoiN5 = Convert.ToString(dr["TGAnHoiN5"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN1"]))
                    objKichBanCuoiDO.TGLeCuoiN1 = Convert.ToString(dr["TGLeCuoiN1"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN2"]))
                    objKichBanCuoiDO.TGLeCuoiN2 = Convert.ToString(dr["TGLeCuoiN2"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN3"]))
                    objKichBanCuoiDO.TGLeCuoiN3 = Convert.ToString(dr["TGLeCuoiN3"]);
                if (!Convert.IsDBNull(dr["TGLeCuoiN4"]))
                    objKichBanCuoiDO.TGLeCuoiN4 = Convert.ToString(dr["TGLeCuoiN4"]);
                if (!Convert.IsDBNull(dr["ExtCHTG1"]))
                    objKichBanCuoiDO.ExtCHTG1 = Convert.ToString(dr["ExtCHTG1"]);
                if (!Convert.IsDBNull(dr["ExtCHTG2"]))
                    objKichBanCuoiDO.ExtCHTG2 = Convert.ToString(dr["ExtCHTG2"]);
                if (!Convert.IsDBNull(dr["ExtCHTG3"]))
                    objKichBanCuoiDO.ExtCHTG3 = Convert.ToString(dr["ExtCHTG3"]);
                if (!Convert.IsDBNull(dr["ExtCHTG4"]))
                    objKichBanCuoiDO.ExtCHTG4 = Convert.ToString(dr["ExtCHTG4"]);
                if (!Convert.IsDBNull(dr["ExtCHTG5"]))
                    objKichBanCuoiDO.ExtCHTG5 = Convert.ToString(dr["ExtCHTG5"]);
            }
            return objKichBanCuoiDO;
        }

        #endregion

    }

}
