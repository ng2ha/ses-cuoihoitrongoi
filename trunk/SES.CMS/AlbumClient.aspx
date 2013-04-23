<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlbumClient.aspx.cs"
    Inherits="SES.CMS.AlbumClient" Title="Untitled Page" %>

<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="h1style">ẢNH CƯỚI CỦA TÔI</h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <blockquote class="serviceintrox">
                <strong>
                    <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></strong>
                <br />
                <asp:Label ID="lblDetailInfo" runat="server" Text="Label"></asp:Label>
                <br />
                <div style="margin-left: 5px; float: left; width: 98%;">
                <div style="margin-left: 0px; height: 25px; width: 80%; float: left">
                                <a href="#" style="color: #fff;">Tên file</a>
                            </div>
                            <div style="margin-right: 0px; height: 25px; width: 20%; float: left">
                                <a href="#" style="color: #fff;"></a></div>
                                
                    <asp:Repeater ID="rptFile" runat="server">
                        <ItemTemplate>
                            <div style="border-bottom: dotted 1px #fff; padding-top:5px; margin-left: 0px; height: 20px; width: 80%; float: left">
                                <a href="<%#Eval("FTPAddress")%>" target="_blank" style="font-weight:normal; color: #fff;">»  <%#Eval("TenFile")%></a>
                            </div>
                            <div style=" text-align:right; border-bottom: dotted 1px #fff; padding-top:5px;margin-right: 0px; height: 20px; width: 20%; float: left">
                                <a href="<%#Eval("FTPAddress")%>" target="_blank" style="font-weight:normal;color: #fff;">Tải về</a></div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div style="float: right">
                    <asp:Button CssClass="submit" Width="80px" Text="Thoát ra" runat="server" ID="btnSend"
                        OnClick="btnSend_Click" />
                </div>
            </blockquote>
             <br />
              <br />
        </div>
    </div>
</asp:Content>
