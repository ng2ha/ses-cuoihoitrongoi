<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucArticle.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucArticle" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<script type="text/javascript">
    function SelectAndClosePopup(value) {
        cbCategory.SetValue(value);
        pcParent.Hide();
    }
</script>

<h2>
    Cập nhật Tin tức</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Tiêu đề:
        </td>
        <td class="style9" colspan="3">
            <asp:TextBox ID="txtTitle" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="*** Cần nhập tiêu đề" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        &nbsp;<asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" Visible="False">[Xem 
            ảnh]</asp:HyperLink>
            &nbsp;<asp:CheckBox ID="chkVote" Text="Cho Đánh giá" runat="server" />
            &nbsp;<asp:CheckBox ID="chkComment" Text="Cho Bình luận" runat="server" />
        </td>
    </tr>
    <tr>
        <td >
            Danh mục:
        </td>
        <td >
            <div style="float: left; vertical-align: middle;">
                <dxe:ASPxComboBox ID="cboCategory" ClientEnabled="false" ClientInstanceName="cbCategory"
                    runat="server" Height="16px" Width="143px">
                </dxe:ASPxComboBox>
            </div>
            <div style="float: left; margin-left: 5px; vertical-align: middle; width: 54px;">
                <dxe:ASPxButton ID="btnSelectParent" runat="server" Text="Chọn">
                    <ClientSideEvents Click="function(s, e) { pcParent.Show();}" />
                </dxe:ASPxButton>
            </div>
        </td>
        <td style="display:none;">
        Parent Article:
        </td>
        <td style="display:none;">
        <asp:DropDownList Visible="false" ID="ddlArticle" runat="server">
        </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Mô tả:
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtDescription" runat="server" Height="102px" TextMode="MultiLine"
                Width="90%"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Chi tiết:</td>
        <td colspan="3">
            <CKEditor:CKEditorControl ID="txtArticleDetail" runat="server" Width="90%">
            </CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hiển thị:
        </td>
        <td class="style4" colspan="3">
            <div style="float: left; vertical-align: middle;">
                &nbsp;
                <asp:CheckBox ID="chkIsHomePage" runat="server" />
                Hiện ở trang chủ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkIsPublish" runat="server" />
                Ẩn đi &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Số
                thứ tự:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
            <div style="float: left; vertical-align: middle;">
                <asp:TextBox ID="txtOrderID" runat="server" Width="68px" 
                    ValidationGroup="submitGrp"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtOrderID" ErrorMessage="*** Cần nhập số thứ tự" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4" colspan="3">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" 
                ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="Hủy" />
        </td>
    </tr>
</table>
<dxpc:ASPxPopupControl ID="pcParent" runat="server" ClientInstanceName="pcParent"
    CloseAction="CloseButton" ContentUrl="~/AdminCP/ListCategory.aspx" HeaderText="Chọn danh mục"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Height="336px"
    Width="699px">
    <ContentCollection>
        <dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
        </dxpc:PopupControlContentControl>
    </ContentCollection>
</dxpc:ASPxPopupControl>

