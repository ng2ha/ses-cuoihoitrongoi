<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucImages.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucImages" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<style type="text/css">
    .style1
    {
        height: 28px;
    }
</style>
<h2>
    Cập nhật hình ảnh</h2>
<table width="100%" border="1">
    <tr>
        <td class="style1">
            Album:
        </td>
        <td class="style1">
           <div style="float: left; vertical-align: middle;">
                <asp:DropDownList ID="cboAlbum"
                    runat="server">
                </asp:DropDownList>
            </div></td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
        <asp:TextBox ID="txtTitle" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="*** Cần nhập tiêu đề" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        <asp:TextBox ID="txtAlt" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" Visible="False">[Xem 
            ảnh]</asp:HyperLink>
  
            <br />
        </td>
    </tr>
    <tr>
        <td class="style8">
            Thumbnail</td>
         <td class="style9">
            <asp:FileUpload ID="fuThumbnail" runat="server" />
            <asp:HyperLink ID="hplThumbnail" runat="server" Target="_blank" Visible="False">[Xem thumbnail]</asp:HyperLink>
         </td>
    <tr>
        <td class="style8">
            Loại ảnh</td>
         <td class="style9">
            <asp:RadioButton ID="rdAlbum" runat="server" Checked="true" GroupName="Album" 
                Text="Ảnh Album" />
            <asp:RadioButton ID="rdKieu" runat="server" GroupName="Album" Text="Ảnh Kiểu" />
         </td>
    </tr>
    </tr>
    
    <tr runat="server" id="trimg" visible="false">
        <td class="style8">
            Chi tiết:</td>
        <td>
            <CKEditor:CKEditorControl ID="txtDescription" runat="server" Width="90%">
            </CKEditor:CKEditorControl>
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