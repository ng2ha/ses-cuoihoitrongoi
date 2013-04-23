<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Content.aspx.cs"
    Inherits="SES.CMS.Content1" Title="Untitled Page" %>
<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>

<%@ Register src="Module/ucSocialLink.ascx" tagname="ucSocialLink" tagprefix="uc2" %>

<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
    
     <div class="mainct">
    <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
    <div class="servicecontent">
    <uc3:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
                    <div class="servicecontent-top">
                        <div class="servicecontent-top-left">
                            <h1 class="h1style"><asp:Label ID="lblContentTitle" runat="server" Text="Title" Font-Size="18px"></asp:Label> </h1>    
                        </div>
                        <div class="servicecontent-top-rgt">
                        </div>
                    </div>
                    <blockquote class="serviceintro">
                        <br />
                        <div visible="false" runat="server" class="serviceintro-img">
                            <a href="#">
                                <asp:Image ID="imgContent" runat="server" />
                            </a>
                        </div>
                        
                            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                        
                     
                    </blockquote>
                    <uc2:ucSocialLink ID="ucSocialLink1" runat="server" />
                                    </div>
     </div>
</asp:Content>
