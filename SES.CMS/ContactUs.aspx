<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs"
    Inherits="SES.CMS.ContactUs" Title="Untitled Page" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mainct">
      <style>
  blockquote.serviceintro span {
    	display:block;
  	}
  	</style>
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
            <uc2:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="h1style">
                        <asp:Label ID="lblContentTitle" runat="server" Text="Title" Font-Size="18px">LIÊN HỆ</asp:Label>
                    </h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <blockquote class="serviceintro" style="display:">
                <div style="width: 100%; height: 20px; float: left; font-family: Arial; font-size: 12px;
                    line-height: 20px; font-weight: lighter; height: auto; margin-top: 10px; margin-bottom: 10px;">
                    <h1 class="h1style">CÔNG TY TNHH NGHỆ THUẬT QUANG DŨNG</h1>
                    <br />
                    <asp:Label ID="lblThongTin" runat="server"></asp:Label>
                </div>
                <div style="width: 100%; float: left;">
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Họ & tên:</a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtGroomName" style="width: 40%; margin-top: 0px;" class="contact-input"
                        type="text" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                        ControlToValidate="txtGroomName"></asp:RequiredFieldValidator>
                        <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Địa chỉ: </a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtGroomAddress" style="width: 40%; margin-top: 0px;" class="contact-input"
                        type="text" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                        ControlToValidate="txtGroomAddress"></asp:RequiredFieldValidator>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Số điện thoại liên hệ: </a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtGroomTel" style="width: 40%; margin-top: 0px;" class="contact-input"
                        type="text" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                        ControlToValidate="txtGroomTel"></asp:RequiredFieldValidator>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <div class="contact-text" style="margin-top: 3px;">
                        <a>Địa chỉ e-mail: </a>
                    </div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtGroommail" style="width: 40%; margin-top: 0px;" class="contact-input"
                        type="text" runat="server" />
                    <div style="width: 10%; margin-top: 0px; float: left">
                        <asp:RegularExpressionValidator ID="expEmail" runat="server" ControlToValidate="txtGroommail"
                            ErrorMessage="*" ValidationExpression="^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div style="width: 100%; height: 10px; float: left;">
                </div>
            </blockquote>
            <blockquote class="serviceintro">
                <div style="width: 100%; float: left;">
                    <div class="contact-text">
                        <a>Yêu cầu của bạn: </a>
                    </div>
                    <textarea id="txtOther" class="contact-input" style="width: 75%; height: 105px" cols="40"
                        rows="20" runat="server"></textarea>
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
                <asp:Button CssClass="submit" Text="Gửi" runat="server" ID="btnSend" OnClick="btnSend_Click" />
            </blockquote>
            <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
        </div>
    </div>
</asp:Content>
