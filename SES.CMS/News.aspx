<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs"
    Inherits="SES.CMS.News" Title="Untitled Page" %>

<%@ Register Src="Module/ucHappyWedding.ascx" TagName="ucHappyWedding" TagPrefix="uc2" %>
<%@ Register Src="Module/ucAlbumLink.ascx" TagName="ucAlbumLink" TagPrefix="uc3" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <div class="ctleft">
            <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
            <div class="topsvitem-title">
                <h1 class="h1">
                <asp:HyperLink ID="hplTitle" runat="server">
                        <asp:Label ID="lblTitle" runat="server" Text="Label" Font-Size="18px"></asp:Label></asp:HyperLink>
                </h1>
            </div>
            <asp:Repeater ID="rptListNews" runat="server">
                <ItemTemplate>
                    <div class="topsvitem" style="height: auto; min-height: 130px; border-bottom: solid #A62021 1px;">
                        <div class="topsvitem-ct">
                            <div class="topsvitem-ct-picholder">
                                <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                    <img src="/Media/<%#Eval("ImageUrl")%>" alt="<%#(Eval("Title"))%>"/></a>
                            </div>
                            <div class="topsvitem-ct-intro" style="margin-top: 0px;">
                                <p>
                                    <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                        <%#Eval("Title")%></a>
                                </p>
                                <%#Eval("Description")%>
                                <p style="text-align: right;">
                                    <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                        Chi tiết
                                        <img src="/images/hearts.png" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div style="width: 100%; float: left; margin-top: 10px;">
                <div style="float: left;">
                    <asp:ImageButton ID="cmdPrev" Visible="false" OnClick="cmdPrev_Click" runat="server"
                        ImageUrl="~/images/PrevPage.png" /></div>
                <div style="float: right;">
                    <asp:ImageButton ID="cmdNext" Visible="false" OnClick="cmdNext_Click" runat="server"
                        ImageUrl="~/images/NextPage.png" /></div>
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
