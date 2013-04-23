<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucProductLine.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucProductLine" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<h2>
    Cập nhật Dây chuyền</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Tiêu đề:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="*** Cần nhập tiêu đề" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        &nbsp;<asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" Visible="False">[Xem 
            ảnh]</asp:HyperLink>
            &nbsp;</td>
    </tr>
      <tr>
        <td class="style8">
            Chi tiết:</td>
        <td>
            <CKEditor:CKEditorControl ID="txtDescription" runat="server" Width="90%">
            </CKEditor:CKEditorControl>
        </td>
    </tr>
    
    <tr>
        <td class="style8">
            Tag:
        </td>
        <td>
            <asp:TextBox ID="txtMetaTag" runat="server" Height="80px" TextMode="MultiLine"
                Width="90%"></asp:TextBox>
        </td>
    </tr>
  
    
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" 
                ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="Hủy" />
        </td>
    </tr>
</table>