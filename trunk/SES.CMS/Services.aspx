<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs"
    Inherits="SES.CMS.Services1" Title="Untitled Page" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc3" %>
<%@ Register Src="Module/ucChildMenu.ascx" TagName="ucChildMenu" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <div style="float: left; width: 210px;">
            <uc2:ucChildMenu ID="ucChildMenu1" runat="server" />
            <br />
            <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server"/>
        </div>
        <div class="servicecontent">
            <uc3:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
            <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
            <div class="servicecontent-top">
                <div class="servicecontent-top-left" style="margin-left: -8px;">
                    <h1><asp:Label ID="lblContentTitle" runat="server" Text="Title" Font-Size="18px"></asp:Label></h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <br />
            <blockquote class="serviceintro">
                <br />
                <asp:Label ID="lblScr" Visible="false" runat="server" Text="Label"></asp:Label>
                <div visible="false" class="serviceintro-img" runat="server" id="divimg">
                    <asp:HyperLink ID="hplLight" CssClass="fancyboxx" runat="server">
                        <asp:Image ID="imgContent" runat="server" /></asp:HyperLink>
                </div>
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            </blockquote>
            <div class="serviceimg">
                <asp:Repeater ID="rptServiceL2" runat="server">
                    <HeaderTemplate>
                        <div class="serviceimgl2">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="serviceimgl2-detail">
                            <div class="serviceimgl2-detail-pic">
                                <a href="/<%#SelectPage(Eval("CategoryID").ToString()) %>/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                                    <img alt="<%#Eval("ParentTitle") %> - <%#Eval("Title") %>" src="/Media/<%#Eval("ImageURL") %>" /></a>
                            </div>
                            <div class="serviceimgl2-detail-title">
                                <a href="/<%#SelectPage(Eval("CategoryID").ToString()) %>/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                                    <%#(Eval("Title").ToString().ToUpper())%></a>
                            </div>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
                <asp:Repeater ID="rptKH" Visible="false" runat="server">
                    <HeaderTemplate>
                        <div class="serviceimgl2" id="lightdiv">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="serviceimgl2-detail">
                            <div class="serviceimgl2-detail-pic">
                                  <a class="fancyboxx" href='/Media/<%#Eval("ImgFile") %>' rel="gallery">
                                    <img alt="<%#Eval("Description") %>" src="/Media/<%#Eval("Thumbnail") %>" /></a>
                            </div>
                            <div class="serviceimgl2-detail-title">
                                <%#(Eval("Title").ToString().ToUpper())%></a>
                            </div>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
                <div class="serviceimgl2" id="lightdiv">
                    <asp:Repeater ID="rptServiceLs" Visible="false" runat="server">
                        <HeaderTemplate>
                            <div class="serviceimgls">
                                <div class="serviceimg">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div class="serviceimgls-detail">
                                <div class="serviceimgls-detail-pic">
                                    <a class="fancyboxx" href='/Media/<%#Eval("ImgFile") %>' rel="gallery">
                                        <img alt="<%#Eval("Title") %>" src="/Media/<%#Eval("ImgFile") %>" /></a>
                                </div>
                                <div class="serviceimgls-detail-title">
                                    <h1 class="h1style">
                                        <%#(Eval("Title").ToString().ToUpper())%></a></h1>
                                </div>
                            </div>
                        </ItemTemplate>
                        <FooterTemplate>
                            </div> </div>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
