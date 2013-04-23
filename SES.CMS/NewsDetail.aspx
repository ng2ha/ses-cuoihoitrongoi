<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs"
    Inherits="SES.CMS.NewsDetail" Title="Untitled Page" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="Module/ucHappyWedding.ascx" TagName="ucHappyWedding" TagPrefix="uc2" %>
<%@ Register Src="Module/ucAlbumLink.ascx" TagName="ucAlbumLink" TagPrefix="uc3" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Src="Module/ucPollResult.ascx" TagName="ucPollResult" TagPrefix="uc1" %>
<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script>
function toggleResult(){
	var div1 = document.getElementById('pollresult')
	if (div1.style.display == 'none') {
		div1.style.display = 'block'
	} else {
		div1.style.display = 'none'
	}
}
</script>

    <div class="mainct">
    <uc4:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
        <div class="ctleft">
            <div class="topsvitem-title">
            <h1 class="h1">
                <asp:HyperLink ID="hplTop" runat="server">  
                        <asp:Label ID="lblTitle" runat="server" Text="Label" Font-Size="18px"></asp:Label>
                </asp:HyperLink>        
            </h1>
            </div>
            <asp:Repeater ID="rptListNews" runat="server">
                <ItemTemplate>
                    <div class="topsvitem" style="height: auto; border-bottom: solid #A62021 1px;">
                        <div class="topsvitem-ct">
                            <div class="topsvitem-ct-intro" style="width: 100%;">
                                <div class="newsdetail-ct-picholder" id="lightdiv">
                                    <a class="fancyboxx" href="/Media/<%#Eval("ImageUrl")%>" title=" <%#Eval("Title")%>">
                                        <img src="/Media/<%#Eval("ImageUrl")%>" alt="<%#(Eval("Title"))%>"/></a>
                                </div>
                                <p>
                                    <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                        <%#Eval("Title")%></a>
                                </p>
                                <%#Eval("ArticleDetail")%>
                                <p style="text-align: right; margin-top: 10px;">
                                    <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                        <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div id="votesystem" runat="server" visible="false" style="float:left; width:100%; height:auto">
            <div style="width: 100%; float: left; margin-top: 5px; height: 19px; border-bottom: solid #A62021 1px;">
                <h1 class="h1style" style="color: White"><asp:Label ID="lblBLDG" runat="server" Text="Label"></asp:Label></h1>
                <div id="voteresultlink" runat="server" style="float: right; margin-top: 0px;">
                    <a style="color: #fff; font-size: 12px;" href='javascript:toggleResult();'>Xem Kết quả bình chọn </a>
                </div>
            </div>
            <div id="pollresult" style="width: 100%; height: auto; float: left; margin-bottom: 5px;
                padding-bottom: 3px; display:none;">
                <uc1:ucPollResult ID="ucPollResult1" runat="server" />
            </div>
            <div id="comment" style="width: 100%; height: auto; float: left; margin-bottom: 10px;
                padding-bottom: 3px;">
                <div style="width: 100%; float: left; margin-top: 10px;">
                    <div style="margin-top: 3px; float: left; font-size: 12px; color: White">
                        <a>Email của bạn</a>
                    </div>
                    <input id="txtEmail" style="width: 20%; margin-top: 0px; margin-left: 10px;" class="comment-input"
                        type="text" runat="server" />
                    <div style="margin-top: 5px; float: left; margin-left: 3px; height: 19px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                            ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    </div>
                    <div id="votecontrol" visible="false" style="float:left;" runat="server">
                    <div style="margin-left: 10px; margin-top: 3px; float: left; font-size: 12px; color: White">
                        <a>Bình chọn (điểm):</a>
                    </div>
                    <div style="margin-left: 10px; margin-top: 3px; float: left; font-size: 12px; color: White">
                        <asp:RadioButton GroupName="star" ID="rdo1" Text="1" runat="server" />&nbsp
                        <asp:RadioButton GroupName="star" ID="rdo2" Text="2" runat="server" />&nbsp
                        <asp:RadioButton GroupName="star" ID="rdo3" Text="3" runat="server" />&nbsp
                        <asp:RadioButton GroupName="star" ID="rdo4" Text="4" runat="server" />&nbsp
                        <asp:RadioButton GroupName="star" ID="rdo5" Text="5" runat="server" />&nbsp
                        <asp:RadioButton GroupName="star" ID="rdoNone" Text=" Không bình chọn" Checked="true"
                            runat="server" />
                    </div>
                    </div>
                </div>
                <div id="articlecomment" visible="false" style="float:left; height:auto; width:100%;" runat="server">
                <div style="width: 100%; float: left; margin-top: 5px;">
                    <div style="margin-top: 0px; float: left; font-size: 12px; color: White">
                        <a>Ý kiến của bạn</a>
                    </div>
                </div>
                <div style="width: 100%; float: left; margin-top: 5px;">
                    <textarea id="txtOther" style="margin-top: 2px; width: 75%; height: 95px" class="comment-input"
                        runat="server" />
                </div>
                </div>
                <div id="captcha" style="width: 100%; float: left; margin-top: 5px;">
                    <div style="margin-top: 0px; float: left; font-size: 12px; color: White">
                        <a>Ký tự bảo mật</a>
                    </div>
                    <input id="txtCaptcha" style="margin-top: 0px; margin-left: 5px; width: 60px;" class="package-input"
                        type="text" runat="server" />
                    <div style="margin-top: 0px; float: left; width: 100px">
                        <%=getCaptchaImage(31, 90)%>
                    </div>
                    <div style="margin-top: 0px; float: left; width: 100px">
                        <asp:Button CssClass="submit" Text="Gửi" runat="server" ID="btnSend" OnClick="btnSend_Click" />
                    </div>
                </div>
            </div>
            <div id="othercomment" runat="server" visible="false" style="width: 100%; height: auto; float: left; margin-bottom: 5px;">
                <asp:Repeater ID="rptComment" runat="server">
                    <ItemTemplate>
                        <div style="float: left; margin-bottom: 5px; font-size: 12px; color: White; width: 100%;
                            padding-bottom: 3px; border-bottom: solid #A62021 1px;">
                            <div style="float: right; margin-top: 4px;">
                                <%#GetStar(Eval("CommentID").ToString()) %>
                            </div>
                            <p>
                                <strong>
                                    <%#Eval("UserEmail")%></strong>
                            </p>
                            <p style="text-align: justify; margin-top: 3px; margin-bottom: 3px;">
                                "<%#Eval("CommentDetail")%>"
                            </p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            </div>
            <div class="other-newsdetail">
                <h1 class="h1style">CÁC BÀI VIẾT KHÁC</span>
                <asp:Repeater ID="rptOther" runat="server">
                    <ItemTemplate>
                        <p>
                            <a href="/Tin-Cuoi-Hoi-Chi-Tiet/<%#Eval("ArticleID")%>/<%#Change_AV(Eval("Title").ToString()) %>">
                                <img src="/images/hearts.png">&nbsp&nbsp&nbsp
                                <%#Eval("Title")%></a>
                        </p>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="ctright">
            <div class="weddingconsult1">
                <div class="weddingconsult-title1">
                    <div class="weddingconsult-title-txt1">
                        <h1 class="h1-title-short">
                            <a href="/List-Dich-Vu-Cuoi-Hoi/49/He-Thong-Dich-Vu.aspx">Dịch vụ</a>
                        </h1>
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
                                        <img src="/Media/<%#Eval("ImageURL")%>" alt="<%#(Eval("Title"))%>"/></a>
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
</div>
</asp:Content>
