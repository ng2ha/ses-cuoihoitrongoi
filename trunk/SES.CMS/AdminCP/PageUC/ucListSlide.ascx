<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListSlide.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucListSlide" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<h2>
    Danh sách Slide</h2>
    <div style="width:90%; float:left; margin-bottom:10px;">
Lựa chọn theo Danh mục: <asp:DropDownList ID="cboCategory" runat="server" 
        AutoPostBack="True" 
        onselectedindexchanged="cboCategory_SelectedIndexChanged">
    </asp:DropDownList>
</div>
<asp:GridView ID="gvSlide" DataKeyNames="SlideID" runat="server" AutoGenerateColumns="False" 
    BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
    CellPadding="4" onrowdeleting="gvSlide_RowDeleting" 
    onselectedindexchanged="gvSlide_SelectedIndexChanged" PageSize="100" Width="100%">
    <Columns>
        <asp:BoundField DataField="STT" HeaderText="STT" ReadOnly="True" SortExpression="STT" />
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" />
        <asp:BoundField DataField="SlideURL" HeaderText="Đường dẫn" SortExpression="SlideURL" />
        <asp:BoundField DataField="CategoryTitle" HeaderText="Hiển thị" SortExpression="CategoryTitle" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("SlideID") %>'
                    CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Thêm mới" />