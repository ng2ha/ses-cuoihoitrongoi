<%@ Page Language="C#" EnableViewState="false" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SES.CMS.Default1" Title="Untitled Page" %>

<%@ Register Src="Module/ucHappyWedding.ascx" TagName="ucHappyWedding" TagPrefix="uc2" %>
<%@ Register Src="Module/ucPopup.ascx" TagName="ucPopup" TagPrefix="uc4" %>
<%@ Register Src="Module/ucThongKe.ascx" TagName="ucThongKe" TagPrefix="uc1" %>
<%@ Register Src="Module/ucAlbumDaThucHien.ascx" TagName="ucAlbumDaThucHien" TagPrefix="uc3" %>
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
                                    <h2>
                                        <%#Eval("Title") %>
                                    </h2>
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
                        <h2 class="h1">
                            <a href="/Tin-Cuoi-Hoi/45/Tu-Van-Mua-Cuoi.aspx">Tư vấn mùa cưới </a>
                        </h2>
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
                                    <a href='/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>'>
                                        Xem tiếp</a>
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
            <div style="float: left; text-align: left; margin-top: 10px; font-weight: bold; margin-left: 0px;
                width: 100%; color: #fff; font-size: 13px;">
                Kết nối Cưới Hỏi Trọn Gói:
                <div class="socialicon" style="margin-top: 5px; margin-left: 0px; width: 100%;">
                    <a href="http://www.facebook.com/CuoiHoiTronGoi.com.vn">
                        <img alt="Chúng tôi trên Facebook" src="/images/facebook.png" /></a> <a href="http://CuoiHoiTronGoi.com.vn/RSS.aspx">
                            <img alt="Chúng tôi trên Facebook" src="/images/rss.png" width="20px" height="20px" /></a>
                    <iframe runat="server" id="abc" scrolling="no" frameborder="0" style="margin-bottom: 2px;
                        float: left; border: none; overflow: hidden; width: 85px; height: 24px;" allowtransparency="true">
                    </iframe>
                </div>
            </div>
            <div class="social-facebook" style="display: none;">
                <iframe src="//www.facebook.com/plugins/likebox.php?href=http%3A%2F%2Fwww.facebook.com%2Fcuoihoitrongoi.com.vn&amp;width=328&amp;height=400&amp;show_faces=true&amp;colorscheme=light&amp;stream=false&amp;border_color&amp;header=false&amp;appId=339171169492293"
                    scrolling="no" frameborder="0" style="border: none; overflow: hidden; width: 328px;
                    background: #fff; height: 400px;" allowtransparency="true"></iframe>
            </div>
            <div class="Search1" style="margin-top: 10px;">
                <asp:TextBox ID="txtSearch" CssClass="search-input" runat="server"></asp:TextBox>
                <asp:Button ID="btnTimkiem" runat="server" Text="Tìm kiếm" CssClass="submitSearch"
                    OnClick="btnTimkiem_Click" />
            </div>
            <div class="album-du-an" style="display:none;">
               
                <uc3:ucAlbumDaThucHien ID="ucAlbumDaThucHien1" runat="server" />
            </div>
        </div>
        <%--    <div class="ctright">
            <div class="Search1">
                
            </div>
        </div>--%>
    </div>
    </span>
</asp:Content>
