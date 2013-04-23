<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucYCKichBan.ascx.cs"
    Inherits="SES.CMS.AdminCP.PageUC.ucYCKichBan" %>
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
    .style12
    {
        width: 332px;
    }
    .style13
    {
        width: 332px;
        height: 26px;
    }
    .style14
    {}
    .style15
    {
        font-weight: normal;
    }
    .style16
    {
        height: 26px;
    }
</style>
<table width="100%" id="rounded-corner">
    <tr>
        <td>
            Được phép truy cập & Xem kịch bản
            <asp:CheckBox ID="chkChapNhan" Text="" runat="server" />
            &nbsp; - Tên Đăng nhập:
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            - Mật khẩu:
            <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
            <asp:Button ID="btnCapNhat2" runat="server" Text="Cập nhật" OnClick="btnCapNhat2_Click" />
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
                                <asp:Label ID="lblTenChuRe" runat="server" Text="Label"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Địa chỉ nhà Chú Rể:
                        </td>
                        <td colspan="3">
                            <strong>
                                <asp:Label ID="lblNhaChuRe" runat="server" Text="Label"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Họ và tên Cô Dâu:
                        </td>
                        <td colspan="3">
                            <strong>
                                <asp:Label ID="lblTenCoDau" runat="server" Text="Label"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Địa chỉ nhà Cô Dâu:
                        </td>
                        <td colspan="3">
                            <strong>
                                <asp:Label ID="lblNhaCoDau" runat="server" Text="Label"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Thời điểm Lễ Dạm Ngõ:
                        </td>
                        <td colspan="2">
                            <div align="center">
                                Giờ có mặt tại NG:<strong>
                                    <asp:Label ID="lblHDamNgo" runat="server" Text="Label"></asp:Label></strong></div>
                        </td>
                        <td width="274">
                            <div align="center">
                                Ngày:<strong>
                                    <asp:Label ID="lblNgayDamNgo" runat="server" Text="Label"></asp:Label>
                                </strong>(Dương lịch)</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Thời điểm Lễ Ăn hỏi:
                        </td>
                        <td width="232">
                            <div align="center">
                                Giờ NT khởi hành:<strong>
                                    <asp:TextBox ID="lblNTKhoiHanh" Width="80px" runat="server" Text=""></asp:TextBox></strong></div>
                        </td>
                        <td width="236">
                            <div align="center">
                                Giờ có mặt tại NG:<strong><asp:Label ID="lblGioDenNG" runat="server" Text="Label"></asp:Label></strong></div>
                        </td>
                        <td>
                            <div align="center">
                                Ngày: <strong>
                                    <asp:Label ID="lblNgayAnHoi" runat="server" Text="Label"></asp:Label></strong>(Dương
                                lịch)</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Thời điểm Lễ Cưới:
                        </td>
                        <td>
                            <div align="center">
                                Giờ NT khởi hành:<strong>
                                    <asp:TextBox ID="lblNTKhoiHanhTH" Width="80px" runat="server" Text=""></asp:TextBox></strong></div>
                        </td>
                        <td>
                            <div align="center">
                                Giờ có mặt tại NG: <strong>
                                    <asp:Label ID="lblGioDenNGTH" runat="server" Text="Label"></asp:Label></strong></div>
                        </td>
                        <td>
                            <div align="center">
                                Ngày: <strong>
                                    <asp:Label ID="lblNgayThanhHon" runat="server" Text="Label"></asp:Label>
                                </strong>(Dương lịch)</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Thời điểm Tổ chức tiệc</td>
                        <td colspan="2">
                            <div align="center">
                                Đến điểm tiệc:<strong><asp:Label ID="lblHTiecCuoi" runat="server" 
                                    Font-Bold="true" Text="Label"></asp:Label>
                                </strong>
                            </div>
                        </td>
                        <td>
                             <div align="center">
                                Ngày: <strong>
                                    <asp:Label ID="lblTGToChucTiec" runat="server" Text="Label"></asp:Label>
                                </strong>(Dương lịch)</div></td>
                    </tr>
                    <tr>
                        <td>
                            Địa điểm đặt tiệc cưới nhà trai:
                        </td>
                        <td colspan="3">
                            <div align="center">
                                <strong>
                                    <asp:Label ID="lblChoDatTiecCuoi" runat="server" Text="Label"></asp:Label></strong></div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Địa điểm đặt tiệc cưới nhà gái:</td>
                        <td colspan="3">
                           <div align="center">
                                <strong>
                                    <asp:Label ID="lblChoDatTiecCuoiNG" runat="server" Text="Label"></asp:Label></strong></div></td>
                    </tr>
                    <tr>
            <td class="style12">
                Lộ trình từ nhà trai đến nhà gái
            </td>
            <td colspan="3">
                <asp:TextBox ID="txt3" Width="500px" runat="server" TextMode="SingleLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Lộ trình từ nhà gái về nhà trai
            </td>
            <td colspan="3">
                <asp:TextBox ID="txt4" Width="500px" runat="server" TextMode="SingleLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Lộ trình từ nhà trai ra điểm tiệc
            </td>
            <td colspan="3">
                <asp:TextBox ID="txtNTDT" Width="500px" runat="server" TextMode="SingleLine"></asp:TextBox>
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
            <th class="style12" scope="col">
                <div align="center" class="Estilo8">
                    NỘI DUNG</div>
            </th>
            <th width="155" class="rounded-q2" scope="col">
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
            <td class="style12">
                Lễ dạm ngõ
            </td>
            <td>
                <asp:TextBox ID="txt1" Width="131px" runat="server"></asp:TextBox>
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
                1</td>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuAH" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txt2" Width="133px" runat="server"></asp:TextBox>
            </td>
            <td rowspan="6">
                Nhân viên Quang Dũng sẽ chuyển đến tận nhà trai và nhà gái
            </td>
        </tr>
         <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuAHN1" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGAnHoiN1" Width="133px" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuAHN2" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGAnHoiN2" Width="133px" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuAHN3" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGAnHoiN3" Width="133px" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuAHN4" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGAnHoiN4" Width="133px" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuAHN5" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGAnHoiN5" Width="133px" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        
        <tr>
            <td colspan="4" style="height: 35px;">
                <div align="center" class="Estilo5">
                    LỄ CƯỚI</div>
            </td>
        </tr>
        <tr>
            <td align="center" rowspan="5">
                1</td>
            <td class="style13">
                <strong>
                    <asp:Label ID="lblDichVuNC" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td class="style14">
                <asp:TextBox ID="txt7" runat="server" Width="135px"></asp:TextBox>
            </td>
            <td class="style14">
                Nhân viên Quang Dũng sẽ chuyển đến tận nhà trai và nhà gái
            </td>
        </tr>
        
        <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuNCN1" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGLeCuoiN1" runat="server" Width="135px"></asp:TextBox>
            </td>
           
            <td class="style14">Khách hàng đến lấy tại cửa hàng</td>
           
        </tr>

        <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuNCN2" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGLeCuoiN2" runat="server" Width="135px"></asp:TextBox>
            </td>
            <td class="style14" rowspan="3">
                Nhân viên Quang Dũng sẽ chuyển đến tận nhà trai và nhà gái
                </td>
        </tr>
        
        <tr>
            <td class="style13">
                <strong>
                    <asp:Label ID="lblDichVuNCN3" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td class="style16">
                <asp:TextBox ID="txtTGLeCuoiN3" runat="server" Width="135px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                <strong>
                    <asp:Label ID="lblDichVuNCN4" runat="server" Text=""></asp:Label>
                </strong>
            </td>
            <td>
                <asp:TextBox ID="txtTGLeCuoiN4" runat="server" Width="135px"></asp:TextBox>
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
            <td class="style15">
                Chụp ảnh tráp lễ, chụp ảnh chú rể cùng gia đình và đội tráp nam.
            </td>
            <td>
                <asp:TextBox ID="tt4" Width="133px" runat="server"></asp:TextBox>
            </td>
            <td>
                Chú rể, đội tráp nam và đội chụp ảnh quay phim
            </td>
        </tr>
        <tr>
            <td align="center">
                2
            </td>
            <td class="style15">
                Bắt đầu khởi hành từ nhà trai
            </td>
            <td>
                <asp:TextBox ID="tt5" Width="133px" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="center">
                3
            </td>
            <td class="style15">
                Đến nhà gái, ổn định đội hình trước khi vào nhà gái (sắp xếp các cụ vào trước
                    hay đội tráp vào trước là do gia đình quyết định)
            </td>
            <td>
                <asp:TextBox ID="tt6" Width="133px" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="center">
                4
            </td>
            <td class="style15">
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
            <td class="style15">
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
            <td class="style15">
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
            <td class="style15">
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
            <td class="style15">
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
            <td class="style15">
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
            <td>
                <asp:TextBox ID="tt23" Width="133px" runat="server"></asp:TextBox>
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
            <td>
                <asp:TextBox ID="tt24" runat="server" Width="138px"></asp:TextBox>
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
                            2
                        </td>
                        <td>
                            Đoàn đón dâu mang cơi trầu khởi hành đến nhà gái
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:TextBox ID="txt25" runat="server" Width="138px"></asp:TextBox>
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
            <td>
                <asp:TextBox ID="txt26" runat="server" Width="138px"></asp:TextBox>
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
            <td>
                <asp:TextBox ID="txt27" runat="server" Width="138px"></asp:TextBox>
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
                        <td style="width: 145px;">
                            <asp:TextBox ID="txt28" runat="server" Width="138px"></asp:TextBox>
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
                        <td>
                            <asp:TextBox ID="txt31" Text=" " runat="server" Width="138px"></asp:TextBox>
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
                        <td>
                            <asp:TextBox ID="txt35" Text=" " runat="server" Width="138px"></asp:TextBox>
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
                        <td>
                            <asp:TextBox ID="txt36" runat="server" Width="138px"></asp:TextBox>
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
                        <td>
                            <asp:TextBox ID="txt42" runat="server" Width="138px"></asp:TextBox>
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
                            Cô dâu chú rể cùng gia đình 2 bên đến điểm tiệc trước chuẩn bị đón khách
                        </td>
                    </tr>
                </table>
            </td>
            <td class="style11">
                <asp:TextBox ID="txt43" runat="server" Width="138px"></asp:TextBox>
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
            <td>
                <asp:TextBox ID="txt44" runat="server" Width="138px"></asp:TextBox>
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
            <td>
                <asp:TextBox ID="txt46" runat="server" Width="138px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </tbody>
</table>
<asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" OnClick="btnCapNhat_Click" />
