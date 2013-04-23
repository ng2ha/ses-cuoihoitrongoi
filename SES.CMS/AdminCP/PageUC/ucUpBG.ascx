<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucUpBG.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucUpBG" %>
<h2>
    Cập nhật hình ảnh</h2>
<table width="100%"><tr><td>Ảnh Nền hiện tại</td><td><img src="../Media/bg.png"/> </td></tr>
        <tr><td>Chọn ảnh</td><td><asp:FileUpload ID="fuBG" runat="server" />
            <asp:RequiredFieldValidator ValidationGroup="BG" ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="***" ControlToValidate="fuBG"></asp:RequiredFieldValidator>
            </td></tr>
<tr><td></td><td><asp:Button runat="server" 
    ID="btnXacNhan" Text="Xác nhận" onclick="btnXacNhan_Click" /></td></tr>
<tr><td>Ảnh Header hiện tại</td><td><img width="300px" src="../Media/banner-top.png"/></td></tr>
<tr><td>Chọn ảnh mới</td><td><asp:FileUpload ID="FileUpload1" runat="server" /></td></tr>
<tr><td>&nbsp;</td><td>
            <asp:Button runat="server" 
    ID="Button1" Text="Xác nhận" onclick="Button1_Click"/></td></tr>
</table>
