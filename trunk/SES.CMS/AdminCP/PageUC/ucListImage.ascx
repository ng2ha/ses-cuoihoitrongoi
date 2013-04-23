<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListImage.ascx.cs"
    Inherits="SES.CMS.AdminCP.PageUC.ucListImage" %>
<h2>
    Danh sách Hình ảnh</h2>
<div style="width: 60%; float: left; margin-bottom: 10px;">
    Lựa chọn theo album:
    <asp:DropDownList ID="cboAlbum" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboAlbum_SelectedIndexChanged">
    </asp:DropDownList>
</div>
<div style="width: 40%; float: right; text-align: right; margin-bottom: 10px;">
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Thêm mới" />
</div>
<%--<asp:GridView ID="gvAt" DataKeyNames="ImageID" runat="server" AutoGenerateColumns="False"
    BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px"
    CellPadding="4" OnRowDeleting="gvAt_RowDeleting" OnSelectedIndexChanged="gvAt_SelectedIndexChanged"
    PageSize="100" Width="100%">
    <RowStyle BackColor="White" ForeColor="#330099" />
    <Columns>
        <asp:BoundField DataField="STT" HeaderText="STT" ReadOnly="True" SortExpression="STT" />
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" />
        <asp:BoundField DataField="AlbumName" HeaderText="Album" SortExpression="Title" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ImageID") %>'
                    CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>--%>
<asp:DataList ID="dlImages" runat="server" Width="100%" BackColor="White" BorderColor="#CC9966"
    BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="7"
    RepeatDirection="Horizontal" DataKeyField="ImageID" OnDeleteCommand="dlImages_DeleteCommand"
    OnSelectedIndexChanged="dlImages_SelectedIndexChanged">
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <ItemStyle BackColor="White" ForeColor="#330099" Width="120px" />
    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <ItemTemplate>
        <center>
            <a class="fancyboxx" rel="group1" title="<%#Eval("Title")%>" href="<%#"/Media/" + (Eval("ImgFile")).ToString() %>">
                <img width="100px" height="70px" src="<%#"/Media/" + (Eval("Thumbnail")).ToString() %>" /></a>
            <br />
            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ImageID") %>'
                CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            <br />
            <%#Eval("Title")%>
        </center>
    </ItemTemplate>
</asp:DataList>
<table border="0" width="100%">
    <tr>
        <td align="left">
            <asp:LinkButton ID="lbPrev" runat="server" Font-Bold="True" OnClick="lbPrev_Click1">
Trang trước
            </asp:LinkButton>
        </td>
        <td align="right">
            <asp:LinkButton ID="lbNext" runat="server" Font-Bold="True" OnClick="lbNext_Click1">
Trang sau
            </asp:LinkButton>
        </td>
    </tr>
</table>
