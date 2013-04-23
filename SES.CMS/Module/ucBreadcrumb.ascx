<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucBreadcrumb.ascx.cs" Inherits="SES.CMS.Module.ucBreadcrumb" %>
<style type="text/css">
.center-title
{
	font-family:Tahoma;
	font-size:12px;
	color:White;
	padding-top:5px;
	padding-bottom:7px;
	float:left;
}
.center-title a
{
	font-family:Tahoma;
	font-size:12px;
	color:White;
	}
</style>
<div class="center-title" style="width:500px;">
    <a href="/Default.aspx" rel="nofollow">Trang chủ </a>
        <asp:Label ID="lblTitle" runat="server"></asp:Label>
</div>

