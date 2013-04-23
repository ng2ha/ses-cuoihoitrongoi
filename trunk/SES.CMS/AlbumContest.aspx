<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlbumContest.aspx.cs"
    Inherits="SES.CMS.AlbumContest" Title="Untitled Page" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="h1style">
                        <asp:Label ID="lblContentTitle" runat="server" Text="Title">Đăng kí tham dự cuộc thi Ảnh</asp:Label>
                    </h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <blockquote class="serviceintro">
                <div style="width: 100%; height: 20px; float: left; font-family: Arial; font-size: 12px;
                    line-height: 20px; display: none; font-weight: lighter; height: auto; margin-top: 10px;
                    margin-bottom: 10px;">
                    <h1 class="h1style">CÔNG TY TNHH NGHỆ THUẬT QUANG DŨNG</h1>
                    <br />
                    Địa chỉ: Số 14, ngõ 66, Tân Mai, Hoàng Mai, Hà Nội. Điện thoại / Fax: 04 3 927 5296.
                    Hotline: 0933 151515
                    <br />
                    + CỬA HÀNG SỐ 1: 68 Hàng Than, Ba Đình, Hà Nội. ĐT: (04)32 668 668 - (04)39 275
                    383
                    <br />
                    + CỬA HÀNG SỐ 2: 15 Hàng Giấy, Hoàn Kiếm, Hà Nội. ĐT: 04 39275043.
                </div>
                <div style="width: 100%; float: left;">
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Họ & tên: (người dự thi)</a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtName" style="width: 40%; margin-top: 0px;" class="contact-input" type="text"
                        runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                            ControlToValidate="txtName"></asp:RequiredFieldValidator></div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Địa chỉ: </a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtAddress" style="width: 40%; margin-top: 0px;" class="contact-input"
                        type="text" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                            ControlToValidate="txtAddress"></asp:RequiredFieldValidator></div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Số điện thoại liên hệ: </a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtTel" style="width: 40%; margin-top: 0px;" class="contact-input" type="text"
                        runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                            ControlToValidate="txtTel"></asp:RequiredFieldValidator></div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Địa chỉ e-mail: </a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtEmail" style="width: 40%; margin-top: 0px;" class="contact-input" type="text"
                        runat="server" />
                        <div style="width: 10%; margin-top: 0px; float:left;">
                        <asp:RegularExpressionValidator ID="expEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ValidationExpression="^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$"></asp:RegularExpressionValidator>
                        </div>
                      <div style="width: 100%; float: left; height: 1px;">
                    </div>  
                        <div class="contact-text" style="margin-top: 3px;">
                        <a>Upload Album ảnh: </a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <asp:FileUpload ID="FileUpload1" width="40%" CssClass="contact-input" runat="server" />  
                      
                    <div style="width: 10%; margin-top: 0px; float:left;">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                            ControlToValidate="FileUpload1"></asp:RequiredFieldValidator></div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    
                </div>
                <div style="width: 100%; height: 10px; float: left;">
                </div>
            </blockquote>
            <blockquote class="serviceintro">
                <div style="width: 100%; float: left;">
                    <div class="contact-text">
                        <a>Mô tả album ảnh: </a>
                    </div>
                    <textarea id="txtOther" class="contact-input" style="width: 75%; height: 105px" cols="40" rows="20" runat="server"></textarea>
                    <br />
                    <div style="width: 100%; float: left; height: 5px;">
                    </div>
                    <div class="contact-text" style="width: 143px;">
                        <a>Nhập kí tự bảo mật:</a>
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
                <asp:Button CssClass="submit" Text="Gửi" runat="server" ID="btnSend" onclick="btnSend_Click"/>
            </blockquote>
            <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
        </div>
    </div>
</asp:Content>
