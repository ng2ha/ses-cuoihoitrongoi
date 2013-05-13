<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAlbumDaThucHien.ascx.cs"
    Inherits="SES.CMS.Module.ucAlbumDaThucHien" %>
<div class="album-du-an-title">
    <h1>
        Lễ cưới đã thực hiện</h1>
</div>
<div class="album-box">
<asp:Repeater ID="rptKH" runat="server">
    <ItemTemplate>
        <div class="al-box">
            <div class="al-box-detail">
                <a class="fancyboxx" href='/Media/<%#Eval("ImgFile") %>' rel="gallery">
                    <img alt="<%#Eval("Description") %>" src="/Media/<%#Eval("Thumbnail") %>" /></a>
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>
</div>
