<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHappyWedding.ascx.cs"
    Inherits="SES.CMS.Module.ucHappyWedding" %>

<div class="weddinghappy">
    <div class="weddinghappy-title">
            <span id="h1">
                <asp:Label ID="lblTitle" runat="server" Text="Label" Font-Size="18px"></asp:Label>
            </span>
    </div>
    <div class="weddinghappy-slide">
        <div class="flexslider">
            <ul class="slides">
                <asp:Repeater ID="rptSlide" runat="server">
                    <ItemTemplate>
                        <li><a target="_blank" href="<%#Eval("SlideURL") %>">
                            <img src="/Media/<%#Eval("SlideImg") %>" />
                        </a>
                        <%--<div style="float:left; display:none; width:100%; margin-top:20px; margin-bottom:10px; font-family:Tahoma; font-size:14px; font-weight:bold; color:#fff;">
                        <%#Eval("Title") %>
                        </div>
                        <blockquote class="styleHappy">
                        <span>
                        <%#Eval("Description")%>
                        </span>
                        </blockquote>--%>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
</div>
