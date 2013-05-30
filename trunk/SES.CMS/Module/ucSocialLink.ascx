<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSocialLink.ascx.cs"
    Inherits="SES.CMS.Module.ucSocialLink" %>
<div class="socialicon">
    <iframe runat="server" id="abc" scrolling="no" frameborder="0" style="margin-bottom: 2px;
        float: left; border: none; overflow: hidden; width: 85px; height: 24px;" allowtransparency="true">
    </iframe>
     <asp:HyperLink runat="server" Target="_blank" ID="hplFacebook" NavigateUrl="http://www.facebook.com/sharer.php?u="><img alt="Chia sẻ thông tin này lên Facebook" src="/images/facebook.png" /></asp:HyperLink>
                                <asp:HyperLink runat="server" Target="_blank" ID="hplGoogle" NavigateUrl="https://plusone.google.com/_/+1/confirm?hl=en&url="><img alt="Chia sẻ lên Google Plus" src="/images/google.png" /></asp:HyperLink>
                                <asp:HyperLink runat="server" Target="_blank" ID="hplTwitter" NavigateUrl="http://twitter.com/home/?status="><img alt="Chia sẻ thông tin này lên Twitter" src="/images/twitter.png" /></asp:HyperLink>
</div>
