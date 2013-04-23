<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Album.aspx.cs"
    Inherits="SES.CMS.Album" Title="Untitled Page" %>

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
                        <asp:Label ID="lblTitle" runat="server" Text="Album Hình ảnh" Font-Size="18px"></asp:Label></asp:HyperLink></h1>
            </div>
            <div class="album-intro">
               Mỗi khoảnh khắc ý nghĩa cùng những phút giây tràn đầy niềm vui & hạnh phúc bên gia đình, người thân, bạn bè trong ngày trọng đại của bạn sẽ được lưu giữ lại bằng những hình ảnh trung thực & sống động nhất bởi những dòng máy chụp chuyên nghiệp như Canon EOS - 1DS Mark III, 5D Mark II...
            </div>
            <div style="width: 100%; margin-top:20px; float: left; height: auto;">
            <asp:Repeater ID="rptAlbums" runat="server">
                <ItemTemplate>
                    <div class="topsvitem" style="height:125px; border-bottom: solid #A62021 1px; padding-bottom:5px;">
                        <div class="topsvitem-ct">
                            <div class="topsvitem-ct-picholder">
                                <a href="/Anh-Bia-Album-Cuoi-Hoi/<%#Eval("AlbumID") %>/<%#Change_AV(Eval("Title").ToString()) %>"><img src="/Media/<%#Eval("ImgFile") %>" alt="<%#(Eval("Title"))%>" /></a>
                            </div>
                            <div class="topsvitem-ct-intro">
                            <div class="topsvitem-titlex" style="width:100%;">
                            <h1 class="h1style"><%#(Eval("Title").ToString().ToUpper())%></h1>
                        </div>
                               <%#Eval("Description") %>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
               </asp:Repeater> 
            <asp:Repeater id="rptAlbumsx" Visible="false" runat="server">
            <ItemTemplate>
            <div style="float:left; width:158px; height:145px; margin-left:20px;margin-right:20px;">
                <div class="topsvitem-ct-picholder">
                    <a href="/Anh-Bia-Album-Cuoi-Hoi/<%#Eval("AlbumID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                        <img src="/Media/<%#Eval("ImgFile") %>" alt="<%#(Eval("Title"))%>" /></a>
                </div>
                <div class="serviceimgls-detail-title" style="height:35px; line-height:20px;">
                                            <h1 class="h1style">
                                                <%#(Eval("Title").ToString().ToUpper())%></h1>
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
                        <h1 class="h1">
                        <a href="/Thong-Tin-Cuoi-Hoi/49/He-Thong-Dich-Vu.html">Dịch vụ </a></h1>
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
                                        <img src="/Media/<%#Eval("ImageURL")%>" alt="<%#(Eval("Title"))%>" /></a>
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
