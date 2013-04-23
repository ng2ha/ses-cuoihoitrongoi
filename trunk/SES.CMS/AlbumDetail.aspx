<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs"
    Inherits="SES.CMS.AlbumDetail" Title="Untitled Page" %>

<%@ Register src="Module/ucSocialLink.ascx" tagname="ucSocialLink" tagprefix="uc5" %>
<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
#fancybox-right {
	right: 330px;
}
</style>
    <div class="mainct">
    <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
        <div class="topsvitem-title">
            
            <h1 class="h1">
            <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="18px"></asp:Label> <asp:Label ID="lblTitle" runat="server" Text="Album Hình ảnh" Font-Size="18px"></asp:Label>
            </h1>

        </div>
        <div class="album-intro">
            <asp:Label ID="lblDescription" runat="server" Text="Album Hình ảnh"></asp:Label>
        </div>
        
        
        
        <div style="width: 100%; margin-top: 10px; float: left; height: auto;">
            <asp:Repeater ID="rptAlbums" runat="server">
                <ItemTemplate>
                    <div style="float: left; width: 158px; height: 120px; margin-left: 18px; margin-right: 18px;">
                        <div class="topsvitem-ct-picholder" id="lightdiv">
                            <%--<a  class="fancyboxx" rel="group1" href="/Media/<%#Eval("ImgFile") %>" title="<%#Eval("Title") %>">
                                <img alt="<%#Eval("Description") %>" src="/Media/<%#Eval("Thumbnail") %>" /></a>--%>
                                <a  class="fancyboxstream" href="/PhotoStream/<%#Eval("ImageID") %>/Default.aspx">
                                <img alt="<%#Eval("Description") %>" src="/Media/<%#Eval("Thumbnail") %>" /></a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
                        
        </div>
        <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
    </div>
</asp:Content>
