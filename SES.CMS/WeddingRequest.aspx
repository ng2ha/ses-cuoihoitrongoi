<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="WeddingRequest.aspx.cs" Inherits="SES.CMS.WeddingRequest" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc2" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
        <uc2:ucBreadcrumb runat="server" ID="ucBreadcrumb1" />
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                   <h1 class="h1style">
                        <asp:Label ID="lblContentTitle" runat="server" Text="Title">KỊCH BẢN CƯỚI HỎI</asp:Label>
                    </h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <blockquote class="serviceintro">
                <div style="width: 100%; height: 20px; float: left; height: auto; margin-top: 10px;
                    margin-bottom: 10px;">
                    Xin vui lòng cho biết đầy đủ những thông tin dưới đây. Chúng tôi sẽ xây dựng kịch
                    bản cưới hỏi chi tiết theo thông tin của bạn và gửi lại cho bạn trong vòng 24 giờ.
                    Xem kịch bản cưới hỏi mẫu <b><a style="color:#fff; font-weight:bold;" target="_blank" href="/NewsDetail/46/Huong-dan-Xay-dung-Kich-ban-Cuoi.aspx">tại đây</a></b>.                    
                </div>
                <div style="width: 49%; float: left; border-right: dotted 1px white;">
                    <div class="contact-text">
                        <a>Họ & tên chú rể: </a>
                    </div>
                    <input id="txtGroomName" class="contact-input" type="text" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                            ControlToValidate="txtGroomName"></asp:RequiredFieldValidator></div>
                    <div class="contact-text">
                        <a>Địa chỉ nhà trai: </a>
                    </div>
                    <input id="txtGroomAddress" class="contact-input" type="text" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                            ControlToValidate="txtGroomAddress"></asp:RequiredFieldValidator></div>
                    <div class="contact-text">
                        <a>Số điện thoại liên hệ: </a>
                    </div>
                    <input id="txtGroomTel" class="contact-input" type="text" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                            ControlToValidate="txtGroomTel"></asp:RequiredFieldValidator></div>
                    <div class="contact-text">
                        <a>Địa chỉ mail: </a>
                    </div>
                    <input id="txtGroommail" class="contact-input" type="text" runat="server" />
                    <asp:RegularExpressionValidator ID="expEmail" runat="server" ControlToValidate="txtGroommail" ErrorMessage="*" ValidationExpression="^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$"></asp:RegularExpressionValidator>
                    <div class="contact-text">
                        <a>Điểm tiệc Nhà trai: </a>
                    </div>
                    <input id="txtGroomHall" class="contact-input" type="text" runat="server" />
                        
                    
                </div>
                <div style="width: 50%; float: left">
                    <div class="contact-text">
                        <a>Họ & tên cô dâu: </a>
                    </div>
                    <input id="txtBrideName" class="contact-input" type="text" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                            ControlToValidate="txtBrideName"></asp:RequiredFieldValidator></div>
                    <div class="contact-text">
                        <a>Địa chỉ nhà gái: </a>
                    </div>
                    <input id="txtBrideAddress" class="contact-input" type="text" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                            ControlToValidate="txtBrideAddress"></asp:RequiredFieldValidator></div>
                    <div class="contact-text">
                        <a>Số điện thoại liên hệ: </a>
                    </div>
                    <input id="txtBrideTel" class="contact-input" type="text" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                            ControlToValidate="txtBrideTel"></asp:RequiredFieldValidator></div>
                    <div class="contact-text">
                        <a>Địa chỉ mail: </a>
                    </div>
                    <input id="txtBrideMail" class="contact-input" type="text" runat="server" />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtBrideMail" ErrorMessage="*" ValidationExpression="^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$"></asp:RegularExpressionValidator>
                    <div class="contact-text">
                        <a>Điểm tiệc Nhà gái: </a>
                    </div>
                    <input id="txtBrideHall" class="contact-input" type="text" runat="server" />
                </div>
                <div style="width: 100%; height: 20px; float: left;">
                </div>
            </blockquote>
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="h1style">
                        <asp:Label ID="Label1" runat="server" Text="Title">THÔNG TIN CHUNG</asp:Label>
                    </h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <blockquote class="serviceintro">
                <div style="width: 100%; height: 20px; float: left;">
                </div>
                <div style="width: 100%; float: left;">
                    <div class="contact-text" style="width: 250px;">
                        <a>Lễ dạm ngõ: Thời điểm có mặt tại nhà gái:</a>
                    </div>
                    <dxe:ASPxDateEdit ID="txtDamngo" CssClass="date-input" runat="server" EditFormat="Custom"
                        EditFormatString="dd/MM/yyyy">
                    </dxe:ASPxDateEdit>
                    <asp:DropDownList ID="ddlHDamNgo" CssClass="time-input" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlPDamNgo" CssClass="time-input" runat="server">
                    </asp:DropDownList>
                    <div style="width: 100%; height: 2px; float: left;">
                    </div>
                    <div class="contact-text" style="width: 250px;">
                        <a>Lễ ăn hỏi: Thời điểm có mặt tại nhà gái:</a>
                    </div>
                    <dxe:ASPxDateEdit ID="txtAnhoi" CssClass="date-input" runat="server" EditFormat="Custom"
                        EditFormatString="dd/MM/yyyy">
                    </dxe:ASPxDateEdit>
                    <asp:DropDownList ID="ddlHAnhoi" CssClass="time-input" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlPAnhoi" CssClass="time-input" runat="server">
                    </asp:DropDownList>
                    <div style="width: 100%; height: 2px; float: left;">
                    </div>
                    <div class="contact-text" style="width: 250px;">
                        <a>Lễ cưới: Thời điểm có mặt tại nhà gái: </a>
                    </div>
                    <dxe:ASPxDateEdit ID="txtDondau" CssClass="date-input" runat="server" EditFormat="Custom"
                        EditFormatString="dd/MM/yyyy">
                    </dxe:ASPxDateEdit>
                    <asp:DropDownList CssClass="time-input" ID="ddlHDondau" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList CssClass="time-input" ID="ddlPDondau" runat="server">
                    </asp:DropDownList>
                    <div style="width: 100%; height: 2px; float: left;">
                    </div>
                    <div class="contact-text" style="width: 250px;">
                        <a>Lễ cưới: Thời điểm tổ chức tiệc: </a>
                    </div>
                    <dxe:ASPxDateEdit ID="txtTieccuoi" CssClass="date-input" runat="server" EditFormat="Custom"
                        EditFormatString="dd/MM/yyyy">
                    </dxe:ASPxDateEdit>
                    <asp:DropDownList CssClass="time-input" ID="ddlHTieccuoi" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList CssClass="time-input" ID="ddlPTieccuoi" runat="server">
                    </asp:DropDownList>
                    <div style="width: 100%; height: 2px; float: left;">
                    </div>
                    <div class="contact-text" style="width: 100%">
                        <a>Những yêu cầu đặc biệt cho ngày cưới hỏi của bạn: </a>
                    </div>
                    <textarea id="txtOther" class="contact-input" style="width: 75%; height: 105px" cols="40" rows="20" runat="server"></textarea>
                    <div class="contact-text" style="width: 200px;">
                        <a>Lựa chọn dịch vụ</a>
                    </div>
                    <div class="contact-text">
                        <asp:RadioButton ID="rdoAll" Text="Trọn gói" GroupName="Service" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rdoSome" Text="Theo yêu cầu" GroupName="Service" runat="server" />
                    </div>
                    <div style="width: 100%; margin-bottom: 10px; margin-top: 5px; height: auto; float: left;">
                        <div id="divluachon" style="float: left; width: 740; padding-left: 0px; display: none;">
                            <div class="DichVu" style="width: 740px; margin-top: 20px; float: left;">
                                <div class="AnHoi" style="width: 370px; float: left">
                                    <table style="width: 370px">
                                        <tr>
                                            <td colspan="3">
                                                <h1 class="h1style">DỊCH VỤ NGÀY ĂN HỎI</h1>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px; width: 150px;">
                                                Lễ dạm ngõ
                                            </td>
                                            <td style="width: 70px;">
                                                <asp:RadioButton GroupName="damngo" runat="server" ID="rdLang" Checked="true" Text="Lãng" />
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="damngo" runat="server" ID="rdTrap" Text="Tráp" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Chụp ảnh ngoài trời
                                            </td>
                                            <td colspan="2">
                                                <asp:CheckBox runat="server" ID="chkChupDN" Checked="true" Text="Có sử dụng" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Lễ ăn hỏi:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt11" runat="server"></asp:TextBox>
                                                <td>
                                                    Tráp
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Quay phim:
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="quayphim" runat="server" ID="anHD" Checked="true" Text="Full HD" />
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="quayphim" runat="server" ID="ahThuong" Text="Thường" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Chụp ảnh:
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="Anh" runat="server" ID="rdAlbum" Checked="true" Text="Album" />
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="Anh" runat="server" ID="rdThuong" Text="Chụp kiểu" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Xe 16 chỗ:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt2" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Xe 29 chỗ:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt3" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Nam bê tráp:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt12" runat="server"></asp:TextBox>
                                                <td>
                                                    Người
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Nữ đỡ tráp:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt13" runat="server"></asp:TextBox>
                                                <td>
                                                    Người
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Phông Lễ ăn hỏi
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt4" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Bàn ghế:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt6" runat="server"></asp:TextBox>
                                                <td>
                                                    Bộ
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Nhà bạt:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt7" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                          <tr>
                                            <td style="height: 30px;">
                                                Pháo giấy:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txtPhaoGiay" runat="server"></asp:TextBox>
                                                <td>
                                                   Cây
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Chữ Hỷ:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txtChuHy" runat="server"></asp:TextBox>
                                                <td>
                                                   Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Hoa Ăn hỏi
                                            </td>
                                            <td style="height: 40px;" colspan="2">
                                                <asp:CheckBox ID="chkAHCT" Text="Hoa Trang trí cầu thang" runat="server" /><br />
                                                <asp:CheckBox ID="chkAHTK" Text="Hoa bàn tiếp khách" runat="server" /><br />
                                                <asp:CheckBox ID="chkAHCH" Text="Cổng hoa" runat="server" /><br />
                                                <asp:CheckBox ID="chkAHHKG" Text="Hoa Trang trí Nội thất Không gian" runat="server" /><br />
                                                <asp:CheckBox ID="chkHPhong" Text="Hoa Trang trí Phông" runat="server" /><br />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="DamCuoi" style="width: 370px; float: left">
                                    <table>
                                        <tr><td colspan="3">
                                            <h1 class="h1style">DỊCH VỤ NGÀY CƯỚI</h1></td></tr>
                                        <tr style="width: 365px; text-align: left;">
                                            <td style="height: 30px; text-align: left; width: 70px;">
                                                Lễ xin dâu
                                            </td>
                                            <td colspan="2"><asp:CheckBox ID="ckxindau" runat="server" Text="Có sử dụng" runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px; width: 150px;">
                                                Quay phim:
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="dcquayphim" runat="server" ID="rddcHD" Checked="true"
                                                    Text="Full HD" />
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="dcquayphim" runat="server" ID="rddcThuong" Text="Thường" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Chụp ảnh:
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="dcchupanh" runat="server" ID="rddcAl" Checked="true"
                                                    Text="Album" />
                                            </td>
                                            <td>
                                                <asp:RadioButton GroupName="dcchupanh" runat="server" ID="rddcKieu" Text="Chụp kiểu" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Xe 4 chỗ:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt14" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Xe 16 chỗ:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt15" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                Chiếc
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Xe 29 chỗ:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt16" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Phông Đám cưới:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt17" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Bàn ghế:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt19" runat="server"></asp:TextBox>
                                                <td>
                                                    Bộ
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Nhà bạt:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt20" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Pháo:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt22" runat="server"></asp:TextBox>
                                                <td>
                                                    Cây
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 30px;">
                                                Chữ Hỷ:
                                            </td>
                                            <td>
                                                <asp:TextBox CssClass="txt" ID="txt23" runat="server"></asp:TextBox>
                                                <td>
                                                    Chiếc
                                                </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <strong>Hoa Cưới tại Nhà</strong>
                                            </td>
                                            <td colspan="2">
                                            </td>
                                            </tr>
                                        <tr>
                                        <td><asp:CheckBox ID="chkHX" Text="Hoa tay & hoa Xe" runat="server" /><br />
                                                <asp:CheckBox ID="chkCT" Text="Hoa Trang trí cầu thang" runat="server" /><br />
                                                <asp:CheckBox ID="chkTK" Text="Hoa bàn tiếp khách" runat="server" /><br />
                                                <asp:CheckBox ID="chkCHC" Text="Cổng hoa" runat="server" /></td>
                                            <td colspan="2" style="width: 170px; margin-left: 10px;">
                                                <asp:CheckBox ID="chkHP" Text="Hoa phòng cô dâu chú rể" runat="server" /><br />
                                                <asp:CheckBox ID="chkHKG" Text="Hoa Trang trí Không gian" runat="server" /><br />
                                                <asp:CheckBox ID="CheckBox6" Text="Hoa Trang trí Phông" runat="server" /><br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <strong>Hoa Cưới tại Điểm tiệc</strong>
                                            </td>
                                            <td colspan="2">
                                            </td>
                                            </tr>
                                            <tr>
                                            <td>
                                                <asp:CheckBox ID="CheckBox1" Text="Cổng Hoa" runat="server" /><br />
                                                <asp:CheckBox ID="CheckBox4" Text="Hoa Bánh cưới" runat="server" /><br />
                                                <asp:CheckBox ID="CheckBox3" Text="Hoa sân khấu" runat="server" />
                                            </td>
                                            <td colspan="2" style="width: 170px; margin-left: 10px;">
                                            <asp:CheckBox ID="CheckBox2" Text="Hoa Trang trí đường dẫn" runat="server" /><br />
                                                <asp:CheckBox ID="CheckBox5" Text="Hoa Trang trí tháp ly" runat="server" /><br />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div id="divtrongoi" style="width: 100%; margin-bottom: 10px; margin-top: 5px; height: auto;
                            float: left; display: none;">
                            <div class="contact-text" style="width: 100%;">
                                <div style="float: left; width: 200px;">
                                    Lựa chọn các Gói dịch vụ:</div>
                                <div style="float: left; text-align:center; width:100%;">
                                <br />
                                    <table width="560px" style="margin-left:30px;" border="0">
                                        <tr>
                                            <td style="width: 140px; text-align:center">
                                                <a href="/Dich-Vu-Cuoi-Hoi-Chi-Tiet/72/GOI-CUOI-KIM-CUONG.aspx" target="_blank"><img src="/images/GOI-CUOI-KIM-CUONG.jpg" width="100px" height="100px" alt="Gói cưới kim cương" /></a>
                                                <br />
                                                <asp:RadioButton ID="rdoGoi1" GroupName="trg" Text="Gói Cưới Kim cương" runat="server" />
                                            </td>
                                            <td style="width: 140px; text-align:center"><a href="/Thong-Tin-Cuoi-Hoi/74/GOI-CUOI-RUBY.aspx" target="_blank">
                                            <img src="/images/GOI-CUOI-RUBY.jpg"  width="100px" height="100px" alt="Gói cưới ruby" /></a>
                                             <br />
                                            <asp:RadioButton ID="rdoGoi2" GroupName="trg" Text="Gói Cưới Ruby" runat="server" />
                                            </td>
                                            <td style="width: 140px; text-align:center">
                                                <a href="/Dich-Vu-Cuoi-Hoi-Chi-Tiet/120/GOI-CUOI--LUC-BAO.aspx" target="_blank"><img src="/images/GOI-CUOI-LUC-BAO.jpg" width="100px" height="100px" alt="Gói cưới Lục bảo" /></a>
                                                <br />
                                                <asp:RadioButton ID="rdoLucBao" GroupName="trg" Text="Gói Cưới Lục bảo" runat="server" />
                                            </td>
                                              <td style="width: 140px; text-align:center">
                                                
                                                <a href="/Thong-Tin-Cuoi-Hoi/75/GOI-CUOI-SAPPHIRE.aspx" target="_blank">
                                                <img src="/images/GOI-CUOI-SAPPHIRE.jpg"  width="100px" height="100px" alt="Gói cưới Sapphire" /></a>
                                                 <br />
                                                <asp:RadioButton ID="rdoGoi3" GroupName="trg" Text="Gói Cưới Sapphire" runat="server" />
                                            </td>
                                            
                                        </tr>
                                        <tr>
                                        <td style="width: 140px; text-align:center">
                                            
                                              <a href="/Thong-Tin-Cuoi-Hoi/73/GOI-CUOI-NGOC-TRAI.aspx" target="_blank">
                                              <img src="/images/GOI-CUOI-NGOC-TRAI.jpg"  width="100px" height="100px" alt="Gói cưới ngọc trai" /></a>  
                                               <br />
                                              <asp:RadioButton ID="rdoGoi4" GroupName="trg" Text="Gói Cưới Ngọc trai" runat="server" />
                                            </td>
                                            
                                            <td style="width: 140px; text-align:center">
                                                <a href="/Dich-Vu-Cuoi-Hoi-Chi-Tiet/119/GOI-CUOI--NGOC-BICH.aspx" target="_blank"><img src="/images/GOI-CUOI-NGOC-BICH.jpg" width="100px" height="100px" alt="Gói cưới kim cương" /></a>
                                                <br />
                                                <asp:RadioButton ID="rdoNgocBich" GroupName="trg" Text="Gói Cưới Ngọc Bích" runat="server" />
                                            </td>
                                        <td style="width: 140px; text-align:center">
                                                <a href="/Dich-Vu-Cuoi-Hoi-Chi-Tiet/118/GOI-CUOI--HOANG-YEN.aspx" target="_blank"><img src="/images/GOI-CUOI-HOANG-YEN.jpg" width="100px" height="100px" alt="Gói cưới kim cương" /></a>
                                                <br />
                                                <asp:RadioButton ID="rdoHoangYen" GroupName="trg" Text="Gói Cưới Hoàng Yến" runat="server" />
                                            </td>
                                            <td style="width: 140px; text-align:center">
                                             
                                            </td>
                                            
                                          
                                        </tr>
                                       
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="contact-text" style="width: 200px;">
                        <a>Nhập kí tự bảo mật hình bên:</a>
                    </div>
                    <input id="txtCaptcha" style="margin-top: 5px; margin-left: 5px; width: 60px;" class="package-input"
                        type="text" runat="server" />
                    <div class="contact-text" style="width: 400px; margin-top: 0px;">
                        <cc1:CaptchaControl ID="ccJoin" runat="server" CaptchaBackgroundNoise="none" CaptchaLength="5"
                            CaptchaHeight="31" CaptchaWidth="90" BackColor="#780000" Width="90px" FontColor="White"
                            CaptchaLineNoise="None" CaptchaMinTimeout="5" CaptchaMaxTimeout="240" />
                    </div>
                </div>
                <div style="width: 100%; height: 20px; float: left;">
                </div>
                <asp:Button CssClass="submit" Text="Gửi" ID="btnSend" runat="server" OnClick="btnSend_Click" /><br />
                <asp:Label ID="lbl" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
