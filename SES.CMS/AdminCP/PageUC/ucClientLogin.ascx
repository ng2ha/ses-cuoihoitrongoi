<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucClientLogin.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucClientLogin" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<h2>
    Cập nhật thông tin đăng nhập khách hàng</h2>
<table width="100%">
    <tr>
        <td>
            <p style="width: 120px; margin: 0">
                Username</p>
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
            <p style="width: 120px; margin: 0">
                Password</p>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            
        </td>
    </tr>
    <tr>
        <td>
            Tên khách hàng
        </td>
        <td>
            <asp:TextBox ID="txtClientName" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
           
           Địa chỉ Máy chủ(không điền ftp://) </td>
        <td>
             <asp:TextBox ID="txtServer" runat="server" Width="193px"></asp:TextBox> 
        </td>
    </tr>
  
    <tr>
        <td class="style8">
            Trình bày:</td>
         <td colspan=3>
             <CKEditor:CKEditorControl ID="txtDetailInfo" runat="server" Width="90%">
            </CKEditor:CKEditorControl>
        </td>
       
    </tr>
    
    <tr>
        <td colspan="4">
            <div style="float: left; margin-right: 10px; margin-top: 10px;">
                <dxe:ASPxButton ID="btSave" runat="server" Text="Lưu" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                    CssPostfix="Soft_Orange" OnClick="btSave_Click">
                </dxe:ASPxButton>
            </div>
            <div style="margin-top: 10px;">
                <dxe:ASPxButton ID="btCancel" runat="server" Text="Hủy" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                    CssPostfix="Soft_Orange">
                </dxe:ASPxButton>
            </div>
        </td>
    </tr>
</table>