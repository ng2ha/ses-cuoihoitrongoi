<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientLogin.aspx.cs"
    Inherits="SES.CMS.ClientLogin" Title="Untitled Page" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="h1style">ẢNH CƯỚI CỦA TÔI</h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <blockquote class="serviceintro">
                Cảm ơn các bạn đã sử dụng dịch vụ của chúng tôi.
                <br />
                <br />
                Mời bạn nhập mã số để xem ảnh cưới của mình.Ảnh cưới của bạn chỉ lưu trong vòng
                30 ngày. Nếu cần thêm thông tin hoặc cần tư vấn bạn gửi Email tại mục Liên hệ hoặc
                gọi điện đến Công ty để được trợ giúp.
                <br />
                <br />
                
                <div style="width: 100%; float: left;">
                    <div class="contact-text" style="margin-top: 3px;"><a>Tên đăng nhập</a></div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtName" style="width: 40%; margin-top: 0px;" class="contact-input" type="text"
                        runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                            ControlToValidate="txtName"></asp:RequiredFieldValidator></div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    
                    <div class="contact-text" style="margin-top: 3px;"><a>Mật khẩu</a></div>
                    <div style="width: 100%; float: left; height: 1px;">
                    </div>
                    <input id="txtPassword" type="password" style="width: 40%; margin-top: 0px;" class="contact-input" runat="server" />
                    <div style="margin-top: 5px; height: 30px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                            ControlToValidate="txtPassword"></asp:RequiredFieldValidator></div>
                    <div style="width: 100%; float: left; height: 10px;">
                    </div>
                    
                </div>
                 <br />
                <br />
                <asp:Button CssClass="submit" Width="80px" Text="Đăng nhập" runat="server" 
                    ID="btnSend" onclick="btnSend_Click"/>
            </blockquote>
            <uc2:ucSocialLink ID="ucSocialLink1" runat="server" />
        </div>
    </div>
</asp:Content>
