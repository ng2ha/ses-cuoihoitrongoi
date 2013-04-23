<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search1.aspx.cs"
    Inherits="SES.CMS.Search1" Title="Untitled Page" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
            <uc2:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h11 class="h1style">
                        <asp:Label ID="lblContentTitle" runat="server" Text="Title" Font-Size="18px">TÌM KIẾM</asp:Label>
                    </h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <br />
            <br />
            <br />
            <div class="Search">
                <div class="Result">
                    Có tất cả <asp:Label ID="lblresult" runat="server"></asp:Label> kết quả được tìm thấy.
                </div>
                <div class="SearchButton">
                    <asp:TextBox ID="txtSearch" CssClass="search-input" runat="server" ></asp:TextBox>
                    <asp:Button CssClass="submitSearch" ID="btnTimkiem" runat="server" Text="Tìm kiếm" OnClick="btnTimkiem_Click" />
                </div>
            </div>
            <asp:Repeater ID="rptSearch" runat="server">
                <ItemTemplate>
                    <div class="topsvitem1">
                        <div class="topsvitem-ct">
                            <div class="topsvitem-ct-picholder">
                                <a href=" <%#ReturnDetailLink(Eval("SearchID").ToString(),int.Parse(Eval("SearchType").ToString()))%>/<%#Eval("SearchID")%>/<%#Change_AV(Eval("Title").ToString())%>">
                                    <img src="/Media/<%#Eval("ImageFile")%>" alt="<%#(Eval("Title"))%>"/></a>
                            </div>
                            <div class="topsvitem-ct-intro1">
                                <a href=" <%#ReturnDetailLink(Eval("SearchID").ToString(),int.Parse(Eval("SearchType").ToString()))%>/<%#Eval("SearchID")%>/<%#Change_AV(Eval("Title").ToString())%>">
                                    <%#Eval("Title")%></a>
                                <br />
                                <%#WordCut(Eval("Description").ToString()) %>
                                <br></br>
                                <a href=" <%#ReturnDetailLink(Eval("SearchID").ToString(),int.Parse(Eval("SearchType").ToString()))%>/<%#Eval("SearchID")%>/<%#Change_AV(Eval("Title").ToString())%>">
                                    Đọc tiếp..</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
    </div>
    </div>
</asp:Content>
