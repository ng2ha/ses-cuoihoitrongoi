<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListNews.aspx.cs" Inherits="SES.CMS.ListNews" Title="Untitled Page" %>
<%@ Register src="Module/ucHappyWedding.ascx" tagname="ucHappyWedding" tagprefix="uc2" %>
<%@ Register src="Module/ucAlbumLink.ascx" tagname="ucAlbumLink" tagprefix="uc3" %>
<%@ Register src="Module/ucSocialLink.ascx" tagname="ucSocialLink" tagprefix="uc5" %>
<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="mainct">
        <div class="ctleft">
            <div class="topsvitem-title">
                <h1 class="h1">
                <asp:HyperLink ID="hplTop" runat="server">
                    <asp:Label ID="lblTitle" runat="server" Text="Tin tức" Font-Size="18px"></asp:Label></asp:HyperLink>
                </h1>
            </div>
            <div style="width: 100%; margin-top:20px; float: left; height: auto;">
            <asp:Repeater id="rptAlbums" runat="server">
            <ItemTemplate>
            <div style="float:left; width:158px; height:145px; margin-left:20px;margin-right:20px;">
                <div class="topsvitem-ct-picholder">
                    <a href="/Tin-Cuoi-Hoi/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                        <img src="/Media/<%#Eval("ImageURL") %>" alt="<%#(Eval("Title"))%>" /></a>
                </div>
                <div class="serviceimgls-detail-title" style="height:35px; line-height:20px;"><a href="/Tin-Cuoi-Hoi/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>"><h1 class="h1style">
                                                <%#(Eval("Title").ToString().ToUpper())%></a></h1></a>
                                        </div>
            </div>
            </ItemTemplate>
            </asp:Repeater>
            <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
            </div>
        </div>
        <div class="ctright">
      
            <div class="weddingconsult1">
                <div class="weddingconsult-title1">
                    <div class="weddingconsult-title-txt1">
                        <h1 class="h1"><a href="/List-Dich-Vu-Cuoi-Hoi/49/He-Thong-Dich-Vu.aspx">Dịch vụ </a></h1>
                    </div>
                    <div class="weddingconsult-title-rgt1">
                    </div>
                </div>
                <div class="weddingconsult-ct1">
                    <asp:Repeater ID="rptService" runat="server">
                        <ItemTemplate>
                            <div class="weddingconsult-ct-item1">
                                <div class="weddingconsult-ct-item-picholder1">
                                    <a href="/Dich-Vu-Cuoi-Hoi/<%#Eval("CategoryID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                        <img src="/Media/<%#Eval("ImageURL")%>" alt="<%#(Eval("Title"))%>"/></a>
                                </div>
                                <div class="weddingconsult-ct-item-if1">
                                    <div class="weddingconsult-ct-item-if-title1">
                                        <a href="/Dich-Vu-Cuoi-Hoi/<%#Eval("CategoryID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                            <%#Eval("Title")%></a>
                                    </div>
                                    <div class="weddingconsult-ct-item-if-text1">
                                        <%#WordCut(Eval("Description").ToString())%>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    
                </div>
            </div>
             <uc3:ucAlbumLink ID="ucAlbumLink1" runat="server" />
            <uc2:ucHappyWedding ID="ucHappyWedding1" runat="server" />
            
        </div>
    </div>
    </a>
</asp:Content>
