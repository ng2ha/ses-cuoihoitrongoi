<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ServiceDetail.aspx.cs"
    Inherits="SES.CMS.ServiceDetail1" Title="Untitled Page" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
            <uc2:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
            <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="servicecontent-top-lefth1">
                        <asp:Literal ID="lblContentTitle" runat="server" Text="Title"></asp:Literal>
                    </h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <br />
            <blockquote class="serviceintro">
                <br />
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            </blockquote>
            <div class="serviceimg">
                <div class="serviceimgls">
                    <div class="serviceimg">
                        <script type="text/javascript">
                            $(function () {
                                $('#lightdiv a').lightBox();
                            });
                        </script>
                        <div class="serviceimgl2" id="lightdiv">
                            <asp:Repeater ID="rptServiceL2" runat="server">
                                <HeaderTemplate>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="serviceimgls-detail">
                                        <div class="serviceimgls-detail-pic">
                                            <%#ReturnLink(Eval("ImageID").ToString())%>
                                            <img alt="<%#Eval("Description") %>" src="/Media/<%#Eval("Thumbnail") %>" />
                                            </a>
                                        </div>
                                        <div class="serviceimgls-detail-title">
                                            <font class="h2">
                                                <%#(Eval("Title").ToString().ToUpper())%></a> </font>
                                        </div>
                                    </div>
                                </ItemTemplate>
                                <FooterTemplate>
                                </FooterTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
