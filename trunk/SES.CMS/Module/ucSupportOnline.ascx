<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSupportOnline.ascx.cs"
    Inherits="SES.CMS.Module.ucSupportOnline" %>
<div style="position: fixed; z-index: 9998; width: 220px; bottom: 0px; right: 0px;
    background-color: #780000; border: solid #c83838 1px; padding: 2px;" onmouseover="document.getElementById('nicksp').style.display='block';document.getElementById('yahooSupports').style.display='none';"
    onmouseout="document.getElementById('yahooSupports').style.display='block'; document.getElementById('nicksp').style.display='none';">
    <div id="yahooSupports" style="padding-top: 1px; padding-right: 1px; padding-bottom: 1px;
        padding-left: 1px; display: block;">
        <img src='/images/hotro.png' />
    </div>
    <div id="nicksp" style="padding-top: 1px; padding-right: 1px; padding-bottom: 1px;
        padding-left: 1px; display: none;">
        <img src='/images/hotro.png' />
        <asp:Label ID="lblScr" runat="server" Text=""></asp:Label>
    </div>
</div>
