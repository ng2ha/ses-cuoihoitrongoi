<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucnonCustomer.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucnonCustomer" %>
<h2 style="text-align: left;">
    Danh sách Khách Hàng Chưa Duyệt</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvUser" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" 
                CellPadding="4" Width="100%"
                DataKeyNames="ID" OnPageIndexChanging="gvUser_PageIndexChanging" OnRowDeleting="gvUser_RowDeleting"
                
                AllowPaging="True" onrowcommand="gvUser_RowCommand" 
                onselectedindexchanged="gvUser_SelectedIndexChanged1">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID_Customer" Visible="true">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TenRe" HeaderText="Tên Chú Rể" />
                    
                    <asp:BoundField DataField="DCRe" HeaderText="Địa Chỉ" />
                    <asp:BoundField DataField="TenDau" HeaderText="Tên Cô Dâu" />
                    <asp:BoundField DataField="DCDau" HeaderText="Địa Chỉ" />
                    <asp:BoundField DataField="tgDamNgo" HeaderText="Dặm Ngõ" />
                    <asp:BoundField DataField="tgAnHoi" HeaderText="Ăn Hỏi" />
                    <asp:BoundField DataField="tgThanhHon" HeaderText="Thành Hôn" />
                    <asp:BoundField DataField="DDTC" HeaderText="Đia Chỉ TC" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btCreate" runat="server" CommandName="create" CommandArgument='<%#Eval("ID") %>' ImageUrl="~/AdminCP/images/add_16x16.gif" />
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="editdc" CommandArgument='<%#Eval("ID") %>' ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ID") %>'
                                CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
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

<asp:Panel ID="pnAdvance" Visible="false" runat="server">
    <asp:Label Width="100px" Text="Ten Dang Nhap" runat="server"></asp:Label>
    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label1" Width="100px" Text="Mat Khau" runat="server"></asp:Label>
    <asp:TextBox ID="txtmk" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnThem" Text="TaoTaiKhoan" runat="server" onclick="btnThem_Click" />
</asp:Panel>

<asp:Panel ID="pnedit" runat="server" Visible="false">
    <div style="width: 49%; float: left; border-right: dotted 1px white;">
        <div class="contact-text">
            <a>Họ & tên chú rể: </a>
        </div>
        <input id="txtGroomName" class="contact-input" type="text"  runat="server" />
        <div style="margin-top: 5px; height: 30px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                ControlToValidate="txtGroomName"></asp:RequiredFieldValidator></div>
        <div class="contact-text">
            <a>Địa chỉ nhà trai: </a>
        </div>
        <input id="txtGroomAddress" class="contact-input" type="text" readonly="readonly"
            runat="server" />
        <div style="margin-top: 5px; height: 30px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                ControlToValidate="txtGroomAddress"></asp:RequiredFieldValidator></div>
        <div class="contact-text">
            <a>Số điện thoại liên hệ: </a>
        </div>
        <input id="txtGroomTel" class="contact-input" type="text"  runat="server" />
        <div class="contact-text">
            <a>Địa chỉ mail: </a>
        </div>
        <input id="txtGroommail" class="contact-input" type="text"  runat="server" />
        <div class="contact-text">
            <a>Điểm tiệc nhà trai tổ chức: </a>
        </div>
        <input id="txtGroomHall" class="contact-input" type="text"  runat="server" />
    </div>
    <div style="width: 50%; float: left">
        <div class="contact-text">
            <a>Họ & tên cô dâu: </a>
        </div>
        <input id="txtBrideName" class="contact-input" type="text"  runat="server" />
        <div style="margin-top: 5px; height: 30px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                ControlToValidate="txtBrideName"></asp:RequiredFieldValidator></div>
        <div class="contact-text">
            <a>Địa chỉ nhà gái: </a>
        </div>
        <input id="txtBrideAddress" class="contact-input" type="text" readonly="readonly"
            runat="server" />
        <div style="margin-top: 5px; height: 30px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                ControlToValidate="txtBrideAddress"></asp:RequiredFieldValidator></div>
        <div class="contact-text">
            <a>Số điện thoại liên hệ: </a>
        </div>
        <input id="txtBrideTel" class="contact-input" type="text"  runat="server" />
        <div class="contact-text">
            <a>Địa chỉ mail: </a>
        </div>
        <input id="txtBrideMail" class="contact-input" type="text"  runat="server" />
        <div class="contact-text">
            <a>Điểm tiệc nhà gái tổ chức: </a>
        </div>
        <input id="txtBrideHall" class="contact-input" type="text"  runat="server" />
    </div>
    <div>
        <asp:Button ID="btn" runat="server" Text="Sua" onclick="btn_Click" />
    </div>
</asp:Panel>