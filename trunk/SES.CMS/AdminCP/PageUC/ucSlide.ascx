<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSlide.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucSlide" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<script type="text/javascript">
    function SelectAndClosePopup(value) {
        cbParent.SetValue(value);
        pcParent.Hide();
    }
</script>

<h2>
    Cập nhật Slide</h2>
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
        &nbsp;
            &nbsp; Số thứ tự: <asp:TextBox ID="txtOrder" runat="server" Width="50px" 
                ValidationGroup="submitGrp"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtOrder" ErrorMessage="*** Cần nhập số thứ tự" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td class="style8">
            Hiện ở trang:
        </td>
        <td class="style9">
            <div style="float: left; vertical-align: middle;">
                <dxe:ASPxComboBox ID="cboParent" ClientEnabled="false" ClientInstanceName="cbParent"
                    runat="server" Height="16px" Width="143px">
                </dxe:ASPxComboBox>
            </div>
            <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <dxe:ASPxButton ID="btnSelectParent" runat="server" Text="Chọn">
                    <ClientSideEvents Click="function(s, e) { pcParent.Show();}" />
                </dxe:ASPxButton>
            </div>
            <div style="float:left;">
                <asp:RadioButton ID="chkHome" GroupName="selecttype" runat="server" Text="Hiện ở trang chủ" />
                <asp:RadioButton ID="chkHappyWedding" GroupName="selecttype" runat="server" Text="Hiện ở CMHP" />
                <asp:RadioButton ID="chkAlbumAnh" GroupName="selecttype" runat="server" Text="Hiện ở Album" />
            </div>
        </td>
    </tr>
    
    <tr>
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" Visible="False">[Xem 
            ảnh]</asp:HyperLink>
        </td>
    </tr>
    
     
   <tr>
        <td class="style8">
            Đường dẫn:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtSlideURL" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtSlideURL" ErrorMessage="*** Cần nhập đường dẫn" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        &nbsp;
            &nbsp;</td>
    </tr>
    
    <tr>
        <td class="style8">
            Chi tiết:</td>
        <td>
            <asp:TextBox ID="txtDescription" TextMode="MultiLine" runat="server" Width="90%">
           </asp:TextBox>
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
<dxpc:ASPxPopupControl ID="pcParent" runat="server" ClientInstanceName="pcParent"
    CloseAction="CloseButton" ContentUrl="~/AdminCP/ListCategory.aspx" HeaderText="Chọn danh mục mẹ"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Height="336px"
    Width="699px">
    <ContentCollection>
        <dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
        </dxpc:PopupControlContentControl>
    </ContentCollection>
</dxpc:ASPxPopupControl>
