<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomeSlide.ascx.cs"
    Inherits="SES.CMS.Module.ucHomeSlide" %>
<div class="cpslide">
    <%--Slide images--%>
    <div class="flexslider">
        <ul class="slides">
            <asp:Repeater ID="rptSlide" runat="server">
                <ItemTemplate>
                    <li>
                        <img src="/Media/<%#Eval("SlideImg") %>" />
                        <p class="flex-caption">
                            <a href="<%#Eval("SlideURL") %>"><%#Eval("Title") %></a>
                            <br />
                            <%#Eval("Description")%></p>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
    <%--Slide images--%>
</div>
