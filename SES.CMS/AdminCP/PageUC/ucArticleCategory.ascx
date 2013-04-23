<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucArticleCategory.ascx.cs"
    Inherits="SES.CMS.AdminCP.PageUC.ucArticleCategory" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<script type="text/javascript">
    function SelectAndClosePopup(value) {
        cbParent.SetValue(value);
        pcParent.Hide();
    }
</script>

<h2>
    Cập nhật Danh mục Tin tức</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Tiêu đề:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle" runat="server" Width="273px" ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"
                ErrorMessage="*** Nhập tiêu đề" ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
            <asp:RadioButton ID="rdoCT" GroupName="type" Text="Trang thông tin" runat="server" />
            <asp:RadioButton ID="rdoSV" GroupName="type" Text="Trang Dịch vụ" runat="server" />
            <asp:RadioButton ID="rdoSVD" GroupName="type" Text="Dịch vụ chi tiết" runat="server" />
            <asp:RadioButton ID="rdoNW" runat="server" GroupName="type" Text="Tin tức" />
           
        </td>
    </tr>
    <tr>
        <td class="style8">
            Danh mục:
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
            <div style="float: left; margin-left: 5px; vertical-align: middle;">
                <asp:CheckBox ID="chkIsTop" runat="server" />Danh mục cấp cao nhất</div>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh:
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
            Thẻ Description</td>
        <td class="style9">
            <asp:TextBox ID="txtKeyword" runat="server" Width="100%"></asp:TextBox></td>
    </tr>
     <tr>
        <td class="style8">
            Tiêu đề trang web</td>
        <td class="style9">
            <asp:TextBox ID="txtWebTitle" runat="server" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="style8">
            Mô tả:
        </td>
        <td>
            <CKEditor:CKEditorControl ID="txtDescription" runat="server">
            </CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Nội dung chi tiết:
        </td>
        <td>
            <CKEditor:CKEditorControl ID="txtDetailContent" runat="server">
            </CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hiển thị:
        </td>
        <td class="style4">
            <div style="float: left; vertical-align: middle;">
                &nbsp;
                <asp:CheckBox ID="chkIsHomePage" runat="server" />
                Hiện ở trang chủ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkIsPublish" runat="server" />
                Ẩn đi &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Số
                thứ tự:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
            <div style="float: left; vertical-align: middle;">
                <asp:TextBox ID="txtOrderID" runat="server" Width="68px" ValidationGroup="submitGrp"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtOrderID"
                ErrorMessage="*** Cần nhập số thứ tự" ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" ValidationGroup="submitGrp" />
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
