<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewScript.aspx.cs" Inherits="SES.CMS.ViewScript" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Xem Kịch bản cưới - CuoiHoiTronGoi.com.vn</title>
    <style type="text/css">
        @import url("stylex.css");
        .Estilo5
        {
            font-size: 18px;
            font-weight: bold;
        }
        .Estilo6
        {
            font-size: 24px;
            font-weight: bold;
        }
        .Estilo8
        {
            font-size: 18px;
            color: #000000;
            font-weight: bold;
        }
        .style6
        {
            width: 67px;
            text-align: center;
        }
        .style7
        {
            width: 66px;
            text-align: center;
        }
        .style10
        {
            width: 65px;
            text-align: center;
        }
        .style11
        {
            height: 35px;
        }
        .submit
{
	width: 57px;
height: 27px;
color: white;
background-color: #D32145;
text-align: center;
font: normal 12/27px arial;
cursor: pointer;
border:0;
float:right;
margin-bottom:0px;
}
        .style12
        {
            width: 672px;
            text-align:left;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="960px" border="0">
        <tr>
            <td class="style12">
                <img src="/images/header.jpg" />
            </td>
        </tr>
    </table>
    <table width="960px" id="rounded-corner" summary="2007 Major IT Companies' Profit">
        <thead>
            <tr>
                <td colspan="4">
                    <table width="960px" id="rounded-corner" summary="2007 Major IT Companies' Profit">
                        <tr bgcolor="#CCCCCC">
                            <td bgcolor="#CCCCCC" colspan="4">
                                <div align="center" class="Estilo5">
                                    THÔNG TIN KHÁCH HÀNG</div>
                            </td>
                        </tr>
                        <tr>
                            <td width="198">
                                Họ và tên Chú Rể:
                            </td>
                            <td colspan="3">
                                <strong>
                                    <asp:Label Font-Bold="true" ID="lblTenChuRe" runat="server" Text="Label"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Địa chỉ nhà Chú Rể:
                            </td>
                            <td colspan="3">
                                <strong>
                                    <asp:Label Font-Bold="true" ID="lblNhaChuRe" runat="server" Text="Label"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Họ và tên Cô Dâu:
                            </td>
                            <td colspan="3">
                                <strong>
                                    <asp:Label Font-Bold="true" ID="lblTenCoDau" runat="server" Text="Label"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Địa chỉ nhà Cô Dâu:
                            </td>
                            <td colspan="3">
                                <strong>
                                    <asp:Label Font-Bold="true" ID="lblNhaCoDau" runat="server" Text="Label"></asp:Label></strong>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Thời điểm Lễ Dạm Ngõ:
                            </td>
                            <td colspan="2">
                                <div align="center">
                                    Giờ có mặt tại NG:<strong><asp:Label Font-Bold="true" ID="lblHDamNgo" runat="server" Text="Label"></asp:Label></strong>
                                    </div>
                            </td>
                            <td width="274">
                                <div align="center">Ngày:<strong><asp:Label Font-Bold="true" ID="lblNgayDamNgo" runat="server" Text="Label"></asp:Label>
                                    </strong>(Dương lịch)</div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Thời điểm Lễ Ăn hỏi:
                            </td>
                            <td width="302" align="center">
                                Giờ NT khởi hành:<strong><asp:Label Font-Bold="true" ID="lblNTKhoiHanh" runat="server" Text=""></asp:Label></strong>
                            </td>
                            <td width="166">
                                <div align="center">
                                    Giờ có mặt tại NG:<strong><asp:Label Font-Bold="true" ID="lblGioDenNG" runat="server"
                                        Text="Label"></asp:Label></strong></div>
                            </td>
                            <td>
                                <div align="center">
                                    Ngày: <strong>
                                        <asp:Label Font-Bold="true" ID="lblNgayAnHoi" runat="server" Text="Label"></asp:Label></strong>(Dương
                                    lịch)</div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Thời điểm Lễ Cưới:
                            </td>
                            <td align="center">
                                Giờ NT khởi hành:<strong><asp:Label Font-Bold="true" ID="lblNTKhoiHanhTH" runat="server" Text=""></asp:Label></strong>
                            </td>
                            <td>
                                <div align="center">
                                    Giờ có mặt tại NG: <strong><asp:Label Font-Bold="true" ID="lblGioDenNGTH" runat="server" Text="Label"></asp:Label></strong></div>
                            </td>
                            <td>
                                <div align="center">
                                    Ngày: <strong>
                                        <asp:Label Font-Bold="true" ID="lblNgayThanhHon" runat="server" Text="Label"></asp:Label>
                                    </strong>(Dương lịch)</div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Thời điểm Tổ chức tiệc:</td>
                            <td align="center" colspan="2">
                                <div align="center">
                                    Đến điểm tiệc:<strong><asp:Label Font-Bold="true" ID="lblHTiecCuoi" 
                                        runat="server" Text="Label"></asp:Label></strong>
                                    </div>
                            </td>
                            <td>
                                 <div align="center">
                                    Ngày: <strong>
                                        <asp:Label Font-Bold="true" ID="lblNgayTiec" runat="server" Text="Label"></asp:Label>
                                    </strong>(Dương lịch)</div></td>
                        </tr>
                        <tr>
                            <td>
                                Địa điểm đặt tiệc cưới nhà trai:
                            </td>
                            <td colspan="3">
                                <div align="center">
                                    <strong>
                                        <asp:Label Font-Bold="true" ID="lblChoDatTiecCuoi" runat="server" Text="Label"></asp:Label></strong></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Địa điểm đặt tiệc cưới nhà gái</td>
                            <td colspan="3">
                                <div align="center">
                                    <strong>
                                        <asp:Label Font-Bold="true" ID="lblChoDatTiecCuoiNG" runat="server" 
                                        Text="Label"></asp:Label></strong></div>
                            </td>
                        </tr>
                        <tr>
                        <td class="style12">
                            Lộ trình từ nhà trai đến nhà gái
                        </td>
                        <td colspan="3">
                            <div align="center">
                                    <strong>
                                        <asp:Label Font-Bold="true" ID="lblNTNG" runat="server" Text="Label"></asp:Label>
                                        </strong>
                                        </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="style12">
                            Lộ trình từ nhà gái về nhà trai
                        </td>
                        <td colspan="3">
                            <div align="center">
                                    <strong>
                                        <asp:Label Font-Bold="true" ID="lblNGNT" runat="server" Text="Label"></asp:Label>
                                        </strong>
                                        </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="style12">
                            Lộ trình từ nhà trai ra điểm tiệc
                        </td>
                        <td colspan="3">
                            <div align="center">
                                    <strong>
                                        <asp:Label Font-Bold="true" ID="lblNTDT" runat="server" Text="Label"></asp:Label>
                                        </strong>
                                        </div>
                        </td>
                    </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="height: 40px;">
                    <div align="center" class="Estilo6">
                        NHỮNG CÔNG VIỆC CẦN CHUẨN BỊ</div>
                </td>
            </tr>
            <tr bgcolor="#CCCCCC">
                <th width="39" class="rounded-company" scope="col">
                    <div align="center" class="Estilo8">
                        STT</div>
                </th>
                <th width="238" class="rounded-q1" scope="col">
                    <div align="center" class="Estilo8">
                        NỘI DUNG</div>
                </th>
                <th width="191" class="rounded-q2" scope="col">
                    <div align="center" class="Estilo8">
                        THỜI ĐIỂM
                    </div>
                </th>
                <th width="472" class="rounded-q4" scope="col">
                    <div align="center" class="Estilo8">
                        THỰC HIỆN CÔNG VIỆC</div>
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td colspan="4" style="height: 35px;">
                    <div align="center" class="Estilo5">
                        LỄ DẠM NGÕ
                    </div>
                </td>
            </tr>
            <tr>
                <td align="center">
                    1
                </td>
                <td>
                    Lễ dạm ngõ
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt1" Width="131px" runat="server"></asp:Label>
                </td>
                <td>
                    Nhân viên Quang Dũng
                </td>
            </tr>
            <tr>
                <td colspan="4" style="height: 35px;">
                    <div align="center" class="Estilo5">
                        LỄ ĂN HỎI</div>
                </td>
            </tr>
            <tr>
                <td align="center" rowspan="6">
                    1
                </td>
                <td>
                    <strong>
                        <asp:Label Font-Bold="true" ID="lblDichVuAH" runat="server" Text=""></asp:Label>
                    </strong>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt2" Width="133px" runat="server"></asp:Label>
                </td>
                <td rowspan="6">
                    Nhân viên Quang Dũng sẽ chuyển đến tận nhà trai và nhà gái
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Font-Bold="true" ID="lblDichVuAHN1" runat="server" Text=""></asp:Label></td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txtTGAnHoiN1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td><asp:Label Font-Bold="true" ID="lblDichVuAHN2" runat="server" Text=""></asp:Label></td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txtTGAnHoiN2" runat="server" Text="Label"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td><asp:Label Font-Bold="true" ID="lblDichVuAHN3" runat="server" Text=""></asp:Label></td>
                <td align="center"><asp:Label Font-Bold="true" ID="txtTGAnHoiN3" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label Font-Bold="true" ID="lblDichVuAHN4" runat="server" Text=""></asp:Label></td>
                <td align="center"> <asp:Label Font-Bold="true" ID="txtTGAnHoiN4" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label Font-Bold="true" ID="lblDichVuAHN5" runat="server" Text=""></asp:Label></td>
                <td align="center"><asp:Label Font-Bold="true" ID="txtTGAnHoiN5" runat="server" Text="Label"></asp:Label></td>
            </tr>
            
            <tr>
                <td colspan="4" style="height: 35px;">
                    <div align="center" class="Estilo5">
                        LỄ CƯỚI</div>
                </td>
            </tr>
            <tr>
                <td align="center" rowspan="5">
                    1
                </td>
                <td >
                    <strong>
                        <asp:Label Font-Bold="true" ID="lblDichVuNC" runat="server" Text=""></asp:Label>
                    </strong>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt7" runat="server" Width="135px"></asp:Label>
                </td>
                <td>
                    Nhân viên Quang Dũng sẽ chuyển đến tận nhà trai và nhà gái
                </td>
            </tr>
            <tr>
                <td >
                    <strong>
                        <asp:Label ID="lblDichVuNCN1" runat="server" Text=""></asp:Label>
                    </strong>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txtTGLeCuoiN1" runat="server" Width="135px"></asp:Label>
                </td>
                <td>
                    Khách hàng đến lấy tại Cửa hàng.
                </td>
            </tr>
            <tr>
                <td >
                    <strong>
                        <asp:Label Font-Bold="true" ID="lblDichVuNCN2" runat="server" Text=""></asp:Label>
                    </strong>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txtTGLeCuoiN2" runat="server" Width="135px"></asp:Label>
                </td>
                <td rowspan="3">
                    Nhân viên Quang Dũng sẽ chuyển đến tận nhà trai và nhà gái
                </td>
            </tr>
            <tr>
                <td >
                    <strong>
                        <asp:Label Font-Bold="true" ID="lblDichVuNCN3" runat="server" Text=""></asp:Label>
                    </strong>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txtTGLeCuoiN3" runat="server" Width="135px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td >
                    <strong>
                        <asp:Label Font-Bold="true" ID="lblDichVuNCN4" runat="server" Text=""></asp:Label>
                    </strong>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txtTGLeCuoiN4" runat="server" Width="135px"></asp:Label>
                </td>
            </tr>   
        </tbody>
    </table>
    <br />
    <table width="960px" id="rounded-corner" summary="2007 Major IT Companies' Profit">
        <thead>
            <tr>
                <td colspan="4" style="height: 40px;">
                    <div align="center" class="Estilo6">
                        QUY TRÌNH NGHI LỄ CƯỚI HỎI</div>
                </td>
            </tr>
            <tr bgcolor="#CCCCCC">
                <th width="45px" class="rounded-company" scope="col">
                    <div align="center" class="Estilo8">
                        STT</div>
                </th>
                <th width="497px" class="rounded-q1" scope="col">
                    <div align="center" class="Estilo8">
                        NỘI DUNG</div>
                </th>
                <th width="145px" class="rounded-q2" scope="col">
                    <div align="center" class="Estilo8">
                        THỜI ĐIỂM
                    </div>
                </th>
                <th width="271px" class="rounded-q4" scope="col">
                    <div align="center" class="Estilo8">
                        THỰC HIỆN CÔNG VIỆC</div>
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td colspan="4" style="height: 35px;">
                    <div align="center" class="Estilo5">
                        LỄ DẠM NGÕ</div>
                </td>
            </tr>
            <tr>
                <td align="center">
                    1
                </td>
                <td>
                    - Gia đình hai bên nói chuyện xin phép cho đôi trẻ được công khai đi lại, tìm hiểu
                    nhau.<br />
                    - Thống nhất ngày, giờ và lễ vật ăn hỏi
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Bố mẹ và hai bên gia đình
                </td>
            </tr>
            <tr>
                <td align="center">
                    2
                </td>
                <td>
                    Nhà trai trao lễ vật
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Bố mẹ nhà trai
                </td>
            </tr>
            <tr>
                <td align="center">
                    3
                </td>
                <td>
                    Nhà gái nhận lễ vật, đặt lên bàn thờ và kết thúc buổi lễ
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Bố mẹ nhà gái
                </td>
            </tr>
            <tr>
                <td colspan="4" style="height: 35px;">
                    <div align="center" class="Estilo5">
                        LỄ ĂN HỎI</div>
                </td>
            </tr>
            <tr>
                <td align="center">
                    1
                </td>
                <td>
                   Chụp ảnh tráp lễ, chụp ảnh chú rể cùng gia đình và đội tráp nam.
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="tt4" Width="133px" runat="server"></asp:Label>
                </td>
                <td>
                    Chú rể, đội tráp nam và đội chụp ảnh quay phim
                </td>
            </tr>
            <tr>
                <td align="center">
                    2
                </td>
                <td>
                    Bắt đầu khởi hành từ nhà trai
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="tt5" Width="133px" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center">
                    3
                </td>
                <td>
                    Đến nhà gái, ổn định đội hình trước khi vào nhà gái (sắp xếp các cụ vào trước
                        hay đội tráp vào trước là do gia đình quyết định)
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="tt6" Width="133px" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center">
                    4
                </td>
                <td>
                    Nhà trai dừng trước cửa, nhà gái ra đón tiếp, đội tráp nữ tiến đến xếp đôi và
                        đỡ tráp cùng đội tráp nam
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center">
                    5
                </td>
                <td>
                    Xếp tráp lễ ở bàn hoặc bàn thờ nhà gái theo thứ tự
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Theo đội tráp với sự sắp xếp theo quy định hoặc theo ý muốn nhà gái
                </td>
            </tr>
            <tr>
                <td align="center">
                    6
                </td>
                <td>
                    Hai bên họ hàng ổn định chỗ ngồi, nhà gái rót nước mời nhà nhà trai
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đội tráp nữ rót nước mời nhà trai và đội tráp nam
                </td>
            </tr>
            <tr>
                <td align="center">
                    7
                </td>
                <td>
                    Nhà trai đứng lên thưa chuyện với nhà gái (giới thiệu thành phần, mục đích)
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện họ nhà Trai
                </td>
            </tr>
            <tr>
                <td align="center">
                    8
                </td>
                <td>
                    Nhà Gái phát biểu đáp lễ
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện họ nhà Gái
                </td>
            </tr>
            <tr>
                <td align="center">
                    9
                </td>
                <td>
                    Nhà Trai đứng lên có lời với nhà Gái để nhà Gái nhận lễ.
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện họ nhà Trai
                </td>
            </tr>
            <tr>
                <td align="center">
                    10
                </td>
                <td>
                    Họ nhà Gái có lời nhận lễ.
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện họ nhà Gái
                </td>
            </tr>
            <tr>
                <td align="center">
                    11
                </td>
                <td>
                    Nhà trai mở lời bắt đầu nghi lễ Trao - Nhận
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện họ nhà Trai
                </td>
            </tr>
            <tr>
                <td align="center">
                    12
                </td>
                <td>
                    Thực hiện nghi lễ Trao - Nhận (thường là trao tượng trưng 3 lễ: trầu cau, rượu -
                    thuốc, chè)
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Hai bà thông gia
                </td>
            </tr>
            <tr>
                <td align="center">
                    13
                </td>
                <td>
                    Xin phép cho cháu (tên chú rể) vào đón cháu (tên cô dâu) để ra mắt hai họ
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện họ nhà Trai
                </td>
            </tr>
            <tr>
                <td align="center">
                    14
                </td>
                <td>
                    Thực hiện nghi lễ Gia tiên (thắp hương ban thờ họ nhà gái) Mang tráp lễ lên ban
                    thờ nhà gái
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Cô dâu chú rể thực hiện Đội tráp nam mang lễ lên
                </td>
            </tr>
            <tr>
                <td align="center">
                    15
                </td>
                <td>
                    Cô dâu chú rể rót nước mời hai họ. Hai họ mạn đàm ngày, giờ cho đám cưới.
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện hai họ
                </td>
            </tr>
            <tr>
                <td align="center">
                    16
                </td>
                <td>
                    Chuẩn bị đồ lại quả cho nhà trai: Mỗi tráp lấy một ít, thường chọn số lẻ 3,5…
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Nhà gái
                </td>
            </tr>
            <tr>
                <td align="center">
                    17
                </td>
                <td>
                    Cô dâu chú rể cùng hai đội tráp nam, nữ và bạn bè chụp ảnh lưu niệm
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Cô dâu, chú rể cùng 2 đội tráp nam nữ
                </td>
            </tr>
            <tr>
                <td align="center">
                    18
                </td>
                <td>
                    Phát biểu kết thúc
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Đại diện nhà trai
                </td>
            </tr>
            <tr>
                <td align="center">
                    19
                </td>
                <td>
                    Nhà gái trao lại quả cho nhà trai.
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    Hai bà thông gia
                </td>
            </tr>
            <tr>
                <td>
                    <center>
                        20</center>
                </td>
                <td>
                    Đội tráp nam mang lễ lại quả về
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="tt23" Width="133px" runat="server"></asp:Label>
                </td>
                <td>
                    Đội tráp nam
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <div align="center" class="Estilo5">
                        LỄ CƯỚI</div>
                </td>
            </tr>
            <tr>
                <td rowspan="4" style="height: 35px; font-weight: 700;" align="center">
                    LỄ XIN DÂU
                </td>
                <td>
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style7">
                                1
                            </td>
                            <td>
                                Đến cửa hàng lấy lễ xin dâu
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="tt24" runat="server" Width="138px"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr align="center">
                <td>
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style10">
                                2
                            </td>
                            <td>
                                Đoàn đón dâu mang cơi trầu khởi hành đến nhà gái
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt25" runat="server" Width="138px"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style10">
                                3
                            </td>
                            <td>
                                Hai người nhà trai mang cơi trầu vào trước bàn thờ nhà gái, thắp hương khấn vái
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt26" runat="server" Width="138px"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style7">
                                4
                            </td>
                            <td>
                                Nhà gái vái chào đáp lễ, sau đó chủ động xin miễn lễ và cử một người cùng với hai
                                người nhà trai ra đón đoàn đón dâu
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt27" runat="server" Width="138px"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center">
                    <b>LỄ CƯỚI (TẠI GIA ĐÌNH) </b>
                </td>
                <td colspan="3">
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td rowspan="8" style="width: 43px;">
                                TẠI NHÀ GÁI
                            </td>
                            <td style="width: 20px;">
                                <center>
                                    1</center>
                            </td>
                            <td style="width: 425px;">
                                Đoàn đón dâu vào nhà gái, ổn định chỗ ngồi
                            </td>
                            <td style="width: 145px;" align="center">
                                <asp:Label Font-Bold="true" ID="txt28" runat="server" Width="138px"></asp:Label>
                            </td>
                            <td style="width: 268px;">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    2</center>
                            </td>
                            <td>
                                Nhà trai có đôi lời phát biểu
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                Đại diện nhà trai
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    3</center>
                            </td>
                            <td>
                                Nhà gái có đôi lời phát biểu
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                Đại diện nhà gái
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    4</center>
                            </td>
                            <td>
                                Xin phép cho chú rể vào phòng trao hoa cho cô dâu
                            </td>
                            <td align="center">
                                <asp:Label Font-Bold="true" ID="txt31" Text="" runat="server" Width="138px"></asp:Label>
                            </td>
                            <td>
                                Đại diện nhà trai
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    5</center>
                            </td>
                            <td>
                                Cô dâu chú rể làm lễ gia tiên
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    6</center>
                            </td>
                            <td>
                                Chú rể đón cô dâu xuống chào hai họ, rót nước mời và chụp ảnh lưu niệm. (và trao
                                quà lưu niệm, nếu có)
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    7</center>
                            </td>
                            <td>
                                Nhà trai phát biểu trước khi đưa cô dâu đi
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                Đại diện nhà trai
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    8</center>
                            </td>
                            <td>
                                Nhà gái cùng cô dâu theo về nhà trai
                            </td>
                            <td align="center">
                                <asp:Label Font-Bold="true" ID="txt35" Text=" " runat="server" Width="138px"></asp:Label>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="7">
                                TẠI NHÀ TRAI
                            </td>
                            <td>
                                <center>
                                    9</center>
                            </td>
                            <td>
                                Hai họ ổn định chỗ ngồi
                            </td>
                            <td align="center">
                                <asp:Label Font-Bold="true" ID="txt36" runat="server" Width="138px"></asp:Label>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    10</center>
                            </td>
                            <td>
                                Họ nhà trai xin phép cho cô dâu chú rể lên làm lễ gia tiên
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    11</center>
                            </td>
                            <td>
                                Làm lễ gia tiên
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                Bố chú rể + đại diện nhà gái Cô dâu + chú rể
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    12</center>
                            </td>
                            <td>
                                Chú rể dẫn cô dâu ra mắt mẹ chồng và cùng nhau xuống chào 2 họ và chụp ảnh lưu niệm
                                (trao quà lưu niệm, nếu có)
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    13</center>
                            </td>
                            <td>
                                Mời nhà gái lên thăm phòng cô dâu chú rể
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                Mẹ chồng + cô dâu chú rể
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    14</center>
                            </td>
                            <td>
                                Nhà gái có lời kết thúc
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                Đại diện nhà gái
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <center>
                                    15</center>
                            </td>
                            <td>
                                Nhà trai nhà gái cũng ra điểm tiệc
                            </td>
                            <td align="center">
                                <asp:Label Font-Bold="true" ID="txt42" runat="server" Width="138px"></asp:Label>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr align="center">
                <td rowspan="4">
                    <b>LỄ CƯỚI (TẠI ĐIỂM TIỆC) </b>
                </td>
                <td class="style11">
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style6">
                                16
                            </td>
                            <td>
                                Cô dâu chú rể cùng gia đình 2 bên đến Điểm tiệc trước chuẩn bị đón khách
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="style11">
                    <asp:Label Font-Bold="true" ID="txt43" runat="server" Width="138px"></asp:Label>
                </td>
                <td class="style11">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style6">
                                17
                            </td>
                            <td>
                                Bố mẹ hai bên cùng cô dâu chú rể xếp hàng bắt tay đón khách đến dự (nên đứng theo
                                hàng dọc là thuận tiện nhất cho việc bắt tay cảm ơn khách đến dự lễ cưới)
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt44" runat="server" Width="138px"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style7">
                                18
                            </td>
                            <td>
                                Trong bữa tiệc, do MC của điểm tiệc đảm nhiệm:<br />
                                - MC thay mặt hai họ và CD- CR chào đón quý khách.<br />
                                - Mời đại diện 2 gia đình ra mắt.<br />
                                - Mời CD-CR lên sân khấu để tiến hành các thủ tục của lễ thành hôn.<br />
                                - Đại diện 2 gia đình phát biểu, cảm ơn quý khách.<br />
                                - CD-CR trao nhẫn cưới. CD-CR cắt bánh Gato.<br />
                                - Mời CD-CR bật champagne và rót tháp ly.<br />
                                - CD-CR nâng ly mời bố mẹ 2 bên tạ ơn công sinh thành.<br />
                                Đại diện hai gia đình và CD-CR cùng nâng ly với toàn thể hội hôn và đến từng bàn
                                tiệc chạm ly chia vui cùng quý khách.<br />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <table id="rounded-corner" width="100%">
                        <tr>
                            <td class="style7">
                                19
                            </td>
                            <td>
                                Bố mẹ hai bên cùng cô dâu chú rể xếp hàng cảm ơn và tiễn khách ra về
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="center">
                    <asp:Label Font-Bold="true" ID="txt46" runat="server" Width="138px"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </tbody>
    </table>
    <div style="float:left; text-align:left; width:960px;">
    <br />
    <asp:Button ID="btnOut" CssClass="submit" Width="80px"  runat="server" 
                    Text="Thoát ra" onclick="btnOut_Click" />
                    </div>
    </form>
    
</body>
</html>
