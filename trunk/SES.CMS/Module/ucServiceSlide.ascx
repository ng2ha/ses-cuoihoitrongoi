<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucServiceSlide.ascx.cs"
    Inherits="SES.CMS.Module.ucServiceSlide" %>
<div class="cpslide">
    <div class="wt-rotator">
        <a href="#"></a>
        <div class="desc">
        </div>
        <div class="preloader">
        </div>
        <div class="c-panel">
            <div class="buttons">
                <div class="prev-btn">
                </div>
                <div class="play-btn">
                </div>
                <div class="next-btn">
                </div>
            </div>
            <div class="thumbnails">
                <ul>
                    <asp:Repeater ID="rptSlide" runat="server">
                        <ItemTemplate>
                            <li><a href="/Media/<%#Eval("SlideImg") %>" title="<%#Eval("Title") %>" /><a href="<%#Eval("SlideURL") %>">
                            </a>
                                <div>
                                    <span class="cap-title"><a href="<%#Eval("SlideURL") %>">
                                        <%#Eval("Title") %>
                                    </a></span>
                                    <br /><br />
                                    <%#Eval("Description")%>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>
    </div>
</div>
<div class="slide-under">
    <P class="h1-quang-dung"><asp:Literal runat="server" ID="ltrSlogan"></asp:Literal> </p>
    
</div>
