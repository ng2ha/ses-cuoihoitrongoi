<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucChildMenu.ascx.cs"
    Inherits="SES.CMS.Module.ucChildMenu" %>
<div id="navs" class="leftmenu" style="margin-bottom:20px;">
    <asp:Repeater ID="rptServiceL1" runat="server">
        <ItemTemplate>
            <div class="leftmenu-item">
                <div class="leftmenu-item-icon">
                </div>
                <div class="leftmenu-item-text">
                    <%#ReturnTopLink(Eval("CategoryID").ToString())%>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
