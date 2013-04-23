<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListYCKichBan.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucListYCKichBan" %>
<asp:DropDownList ID="drp" runat="server" AutoPostBack="true" 
    onselectedindexchanged="drp_SelectedIndexChanged">

    <asp:ListItem Value="-1">Tất cả ------------</asp:ListItem>
    <asp:ListItem Value="1">Đã Xử lý & Cấp User</asp:ListItem>
    <asp:ListItem Value="0">Chưa Xử lý & Cấp User</asp:ListItem>
</asp:DropDownList><br />
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvUser" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" 
                CellPadding="4" Width="100%"
                DataKeyNames="YeuCauKBID" OnPageIndexChanging="gvUser_PageIndexChanging"
                OnSelectedIndexChanged="gvUser_SelectedIndexChanged"
                AllowPaging="True" OnRowCommand="gvUser_RowCommand">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="YeuCauKBID" Visible="false" HeaderText="YeuCauKBID">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField ControlStyle-Width="15%" DataField="TenDangNhap" HeaderText="Tên Đăng nhập" />
                    <asp:BoundField ControlStyle-Width="15%" DataField="MatKhai" HeaderText="Mật khẩu" />
                    <asp:BoundField ControlStyle-Width="15%" DataField="TenChuRe" HeaderText="Tên Chú Rể" />
                    <asp:BoundField ControlStyle-Width="15%" DataField="TenCoDau" HeaderText="Tên Cô dâu" />
                    <asp:BoundField ControlStyle-Width="10%" DataField="NgayTiecCuoi" HeaderText="Tiệc Cưới" />
                    <asp:BoundField ControlStyle-Width="15%" DataField="MailChuRe" HeaderText="Mail Chú Rể" />
                    <asp:BoundField ControlStyle-Width="15%" DataField="MailCoDau" HeaderText="Mail Cô dâu" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btDetail" runat="server" CommandName="detailYC" CommandArgument='<%#Eval("YeuCauKBID") %>' ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("YeuCauKBID") %>'
                                CommandName="Delete1" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            </asp:GridView>
        </td>
    </tr>
</table>