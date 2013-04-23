<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListAlbum.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucListAlbum" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<h2>
    Danh sách Album</h2>
<asp:GridView ID="gvAlbum" DataKeyNames="AlbumID" runat="server" AutoGenerateColumns="False" 
    BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
    CellPadding="4" onrowdeleting="gvAlbum_RowDeleting" 
    onselectedindexchanged="gvAlbum_SelectedIndexChanged" PageSize="100" Width="100%">
    
     <RowStyle BackColor="White" ForeColor="#330099" />
    <Columns>
        <asp:BoundField DataField="STT" HeaderText="STT" ReadOnly="True" 
            SortExpression="STT" />
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" />
          <asp:BoundField DataField="AlbumID" HeaderText="AlbumID" Visible="false" />  
            
        <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("AlbumID") %>'
                                CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
    </Columns>
     <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
<asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Thêm mới" />