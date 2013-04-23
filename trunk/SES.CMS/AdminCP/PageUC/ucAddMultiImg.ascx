<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAddMultiImg.ascx.cs"
    Inherits="SES.CMS.AdminCP.PageUC.ucAddMultiImg" %>
<style type="text/css">
    .style1
    {
        height: 48px;
    }
</style>
<h2>
    Cập nhật hình ảnh</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Album:
        </td>
        <td class="style9">
            <div style="float: left; vertical-align: middle;">
                <asp:DropDownList ID="cboAlbum" runat="server">
                </asp:DropDownList>
            </div>
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 1
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle1" runat="server" Width="179px"></asp:TextBox>
            Thẻ Alt: 
            <asp:TextBox ID="txtAlt1" runat="server" Width="179px"></asp:TextBox>
            &nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
            <asp:RadioButton GroupName="Album1" ID="rdAlbum1" Checked="true" runat="server" Text="Ảnh Album" />
            <asp:RadioButton GroupName="Album1" ID="rdKieu1" runat="server" Text="Ảnh Kiểu" />
            <br />
            File ảnh 1:
            <asp:FileUpload ID="fuImage1" runat="server" />
            &nbsp;Ảnh Thumbnail 1:<asp:FileUpload ID="fuThumbnail1" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="style1">
            Hình ảnh 2
        </td>
        <td class="style1">
            <asp:TextBox ID="txtTitle2" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
             Thẻ Alt: 
            <asp:TextBox ID="txtAlt2" runat="server" Width="179px"></asp:TextBox>
            &nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
            <asp:RadioButton GroupName="Album2" ID="rdAlbum2" Checked="true" runat="server" Text="Ảnh Album" />
            <asp:RadioButton GroupName="Album2" ID="rdKieu2" runat="server" Text="Ảnh Kiểu" />
            <br />
            File ảnh 2:
            <asp:FileUpload ID="fuImage2" runat="server" />
            &nbsp;Ảnh Thumbnail 2:<asp:FileUpload ID="fuThumbnail2" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 3
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle3" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
             Thẻ Alt: 
            <asp:TextBox ID="txtAlt3" runat="server" Width="179px"></asp:TextBox>
            &nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
            <asp:RadioButton GroupName="Album3" ID="rdAlbum3" Checked="true" runat="server" Text="Ảnh Album" />
            <asp:RadioButton GroupName="Album3" ID="rdKieu3" runat="server" Text="Ảnh Kiểu" />
            <br />
            File ảnh 3:
            <asp:FileUpload ID="fuImage3" runat="server" />
            &nbsp;Ảnh Thumbnail 3:<asp:FileUpload ID="fuThumbnail3" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 4
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle4" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
             Thẻ Alt: 
            <asp:TextBox ID="txtAlt4" runat="server" Width="179px"></asp:TextBox>
            &nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
            <asp:RadioButton GroupName="Album4" ID="rdAlbum4" Checked="true" runat="server" Text="Ảnh Album" />
            <asp:RadioButton GroupName="Album4" ID="rdKieu4" runat="server" Text="Ảnh Kiểu" />
            <br />
            File ảnh 4:
            <asp:FileUpload ID="fuImage4" runat="server" />
            &nbsp;Ảnh Thumbnail 4:<asp:FileUpload ID="fuThumbnail4" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="style8">
            Hình ảnh 5
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle5" runat="server" Width="179px" ValidationGroup="submitGrp"></asp:TextBox>
             Thẻ Alt: 
            <asp:TextBox ID="txtAlt5" runat="server" Width="179px"></asp:TextBox>
            &nbsp;
            <asp:HyperLink ID="HyperLink5" runat="server" Target="_blank" Visible="False">[Xem 
        ảnh]</asp:HyperLink>
            <asp:RadioButton GroupName="Album5" ID="rdAlbum5" Checked="true" runat="server" Text="Ảnh Album" />
            <asp:RadioButton GroupName="Album5" ID="rdKieu5" runat="server" Text="Ảnh Kiểu" />
            <br />
            File ảnh 5:
            <asp:FileUpload ID="fuImage5" runat="server" />
            &nbsp;Ảnh Thumbnail 5:<asp:FileUpload ID="fuThumbnail5" runat="server" />
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
