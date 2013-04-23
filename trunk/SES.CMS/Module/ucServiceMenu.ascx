<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucServiceMenu.ascx.cs"
    Inherits="SES.CMS.Module.ucServiceMenu" %>
<div id="navs" class="leftmenu">
    <asp:Repeater ID="rptServiceL1" OnItemDataBound="rptServiceL1_ItemDataBound" runat="server">
        <ItemTemplate>
            <div class="leftmenu-item">
                <div class="leftmenu-item-icon">
                </div>
                <div class="leftmenu-item-text">
                    <%#ReturnTopLink(Eval("CategoryID").ToString())%>
                </div>
            </div>
            <asp:Repeater ID="rptServiceL2" runat="server">
                <HeaderTemplate>
                    <div class="show-div">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="leftmenu-item-l2s">
                        <div class="leftmenu-item-icon-l2">
                        </div>
                        <div class="leftmenu-item-text-l2">
                            <%#ReturnDetailLink(Eval("CategoryID").ToString())%>
                            <%--<a href="/Dich-Vu-Cuoi-Hoi-Chi-Tiet/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>"><%#Eval("Title") %></a>--%>
                        </div>
                    </div>
                </ItemTemplate>
                <FooterTemplate>
                    </div></FooterTemplate>
            </asp:Repeater>
        </ItemTemplate>
    </asp:Repeater>
     <div class="Search1">
                        <asp:TextBox ID="txtSearch" Width="150px" CssClass="search-input" runat="server"></asp:TextBox>
                        <asp:Button ID="btnTimkiem" Width="55px" runat="server" Text="Tìm" 
                          CssClass="submitSearch" onclick="btnTimkiem_Click" />
                    </div>
    <a href="/AlbumClient.aspx">
        <img style="margin-top: 19px;" src="/images/clientlogin.jpg" border="0" /></a>
    
</div>
