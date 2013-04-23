<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListServices.aspx.cs" Inherits="SES.CMS.ListServices" Title="Untitled Page" %>
<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register src="Module/ucSocialLink.ascx" tagname="ucSocialLink" tagprefix="uc5" %>
<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
        <uc2:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="h1style">Cưới Hỏi Trọn Gói</h1>
                    
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <blockquote class="serviceintro" style="float:left;">
                <asp:Literal ID="ltSv" runat="server"></asp:Literal>
            </blockquote>

            <div class="serviceimg">
                <div class="serviceimgls">
                    <div class="serviceimg">
                    
                        <div class="serviceimgl2" style="margin-left:5px; width:740px;" id="lightdiv">
                            <asp:Repeater ID="rptServiceL2" runat="server">
                                <HeaderTemplate>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="serviceimgls-detail">
                                        <div class="serviceimgls-detail-pic">
                                            <a title="<%#(Eval("Title").ToString().ToUpper())%>" href="/Dich-Vu-Cuoi-Hoi/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                                                <img src="/Media/<%#Eval("ImageURL") %>" alt="<%#(Eval("Title"))%>"/></a>
                                        </div>
                                        <div class="serviceimgls-detail-title">
                                        
                                        <a title="<%#(Eval("Title").ToString().ToUpper())%>" href="/Dich-Vu-Cuoi-Hoi/<%#Eval("CategoryID") %>/<%#Change_AV(Eval("Title").ToString()) %>">
                                        <h1 class="h1"><%#(Eval("Title").ToString().ToUpper())%></h1></a>
                                        </a>
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
             <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
        </div>
    </div>
</asp:Content>
