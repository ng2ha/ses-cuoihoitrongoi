<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListImagealt.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucListImagealt" %>
<asp:GridView ID="gvAt" DataKeyNames="ImageID" runat="server" AutoGenerateColumns="False"
    BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px"
    CellPadding="4"  PageSize="100" Width="100%" AllowPaging="True" 
    onpageindexchanging="gvAt_PageIndexChanging">
    <RowStyle BackColor="White" ForeColor="#330099" />
    <Columns>
        <asp:BoundField DataField="STT" HeaderText="STT" ReadOnly="True" 
            SortExpression="STT" >
            <ItemStyle Width="3%" />
        </asp:BoundField>
        <asp:BoundField DataField="Title" HeaderText="Tiêu đề" SortExpression="Title" >
            <ItemStyle Width="25%" />
        </asp:BoundField>
        <asp:BoundField DataField="AlbumName" HeaderText="Album" 
            SortExpression="Title" >
            <ItemStyle Width="25%" />
        </asp:BoundField>
          <asp:TemplateField HeaderText="Thẻ Alt">
                <ItemTemplate>
                    <asp:TextBox runat="server" Width="100%" ID="txtAlt" Text='<%#Eval("Description") %>'></asp:TextBox>
                </ItemTemplate>
                <ItemStyle Width="43%" />
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Ảnh">
             <ItemTemplate>
             <a class="fancyboxx" rel="group1" title='<%#Eval("AlbumName") %> -> <%#Eval("Title") %>'  href="<%#"/Media/" + (Eval("ImgFile")).ToString() %>" target="_blank" /> Xem ảnh </a>
             </ItemTemplate>
             <ItemStyle Width="4%" />
             </asp:TemplateField>
            
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
<asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" 
    onclick="btnUpdate_Click" />

          
