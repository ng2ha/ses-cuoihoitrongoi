<%@ Page Language="C#" EnableViewState="false" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SES.CMS.Default1" Title="Untitled Page" %>

<%@ Register Src="Module/ucHappyWedding.ascx" TagName="ucHappyWedding" TagPrefix="uc2" %>
<%@ Register Src="Module/ucPopup.ascx" TagName="ucPopup" TagPrefix="uc4" %>
<%@ Register Src="Module/ucThongKe.ascx" TagName="ucThongKe" TagPrefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc4:ucPopup ID="ucPopup1" runat="server" />
    <div class="mainct">
        <div class="cttop">
            <ul class="ul-top-service">
                <asp:Repeater ID="rptTopSV" runat="server">
                    <ItemTemplate>
                        <li>
                            <div class="s-img-box">
                                <a href="/Dich-Vu-Cuoi-Hoi/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                                    <img src="/Media/<%#Eval("ImageURL") %>" alt="<%#(Eval("Title"))%>" /></a>
                            </div>
                            <div class="s-title-box">
                                <a href="/Dich-Vu-Cuoi-Hoi/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                                    <h1>
                                        <%#Eval("Title") %>
                                    </h1>
                                </a>
                            </div>
                            <div class="s-description-box">
                                <%#WordCut2(Eval("Description").ToString())%>
                            </div>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <%-- <div class="topsvitem">
                        <div class="topsvitem-title">
                            <h1 class="h1">
                                <a href="/Dich-Vu-Cuoi-Hoi/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                                    </a>
                            </h1>
                        </div>
                        <div class="topsvitem-hoavan">
                        </div>
                        <div class="topsvitem-ct">
                            <div class="topsvitem-ct-picholder">
                               
                            </div>
                            <div class="topsvitem-ct-intro">
                               
                            </div>
                        </div>
                    </div>--%>
        </div>
        <div class="ct-left">
            <div class="weddingconsult">
                <div class="weddingconsult-title">
                    <div class="weddingconsult-title-txt">
                        <h1 class="h1">
                            <a href="/Tin-Cuoi-Hoi/45/Tu-Van-Mua-Cuoi.aspx">Tư vấn mùa cưới </a>
                        </h1>
                    </div>
                    <div class="weddingconsult-title-rgt">
                    </div>
                </div>
                <div class="weddingconsult-ct">
                    <asp:Repeater ID="rptConsult" runat="server">
                        <ItemTemplate>
                            <div class="weddingconsult-ct-item">
                                <div class="weddingconsult-ct-item-picholder">
                                    <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                        <img src="/Media/<%#Eval("ImageUrl")%>" alt="<%#(Eval("Title"))%>" /></a>
                                </div>
                                <div class="weddingconsult-ct-item-if">
                                    <div class="weddingconsult-ct-item-if-title">
                                        <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                            <%#Eval("Title")%></a>
                                    </div>
                                    <div class="weddingconsult-ct-item-if-text">
                                        <%#WordCut(Eval("Description").ToString())%>
                                    </div>
                                </div>
                                <div class="weddingconsult-readmore">
                                    <a href='/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>'>Xem tiếp</a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <div class="ct-right">
            <asp:Label ID="lblCuocThiAnh" runat="server" Text=""></asp:Label>
            <uc2:ucHappyWedding ID="ucHappyWedding1" runat="server" />
        </div>
        <div class="search-box">
        <div class="s-search">
            <asp:TextBox ID="txtSearch" CssClass="r-search-input" runat="server"></asp:TextBox>
                <asp:Button ID="btnTimkiem" runat="server" Text="Tìm kiếm" CssClass="r-submitSearch"
                    OnClick="btnTimkiem_Click" />
        </div>
        </div>
        <%--    <div class="ctright">
            <div class="Search1">
                
            </div>
        </div>--%>
    </div>
</asp:Content>
