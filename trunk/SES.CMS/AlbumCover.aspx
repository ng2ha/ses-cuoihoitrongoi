<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlbumCover.aspx.cs"
    Inherits="SES.CMS.AlbumCover" Title="Untitled Page" %>

<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="mainct">
<uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
        <div class="topsvitem-title">
        
        <h1 class="h1">
            Album - <asp:Label ID="lblTitle" runat="server" Text="Album Hình ảnh" Font-Size="18px"></asp:Label>
        </h1>
        </div>
        <div class="album-intro">
            <asp:Label ID="lblDescription" runat="server" Text="Album Hình ảnh"></asp:Label>
        </div>
    <div class="serviceimg" style="float:left;width:300px;margin: 20px 20px 20px 90px">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    <div class="serviceimgl2" style="float:right;width:300px;margin: 20px 100px 20px 20px">
        <asp:Label ID="Label0" runat="server" Text="Label"></asp:Label>
    </div>
</div>
</asp:Content>
