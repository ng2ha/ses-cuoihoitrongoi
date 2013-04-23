<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPollResult.ascx.cs" Inherits="SES.CMS.Module.ucPollResult" %>
<div style="float:left; width:100%; font-weight:bold;margin-bottom:5px; margin-top:5px; font-size:11px;color:white; font-family:Tahoma;">
Kết quả bình chọn:
</div>
<div style="float:left; width:100%; margin-bottom:5px; font-size:11px;color:white; font-family:Tahoma;">
<div style="float:left; width:25%; height:19px;">Số bình chọn 5* :<asp:Label Font-Bold="true" ID="Label5" runat="server" Text="Label"></asp:Label></div>
<div style="float:left; width:75%; height:19px;"> 
    <asp:Image ImageUrl = "/images/bar.png" Height="10px" ID="imgFive" runat="server" /> </div>
</div>
<div style="float:left; width:100%; margin-bottom:5px; font-size:11px;color:white; font-family:Tahoma;">
<div style="float:left; width:25%; height:19px;">Số bình chọn 4* :<asp:Label Font-Bold="true"  ID="Label4" runat="server" Text="Label"></asp:Label></div>
<div style="float:left; width:75%; height:19px;"> 
    <asp:Image ImageUrl = "/images/bar.png" Height="10px" ID="imgFour" runat="server" /> </div>
</div>
<div style="float:left; width:100%; margin-bottom:5px; font-size:11px;color:white; font-family:Tahoma;">
<div style="float:left; width:25%; height:19px;">Số bình chọn 3* :<asp:Label Font-Bold="true"  ID="Label3" runat="server" Text="Label"></asp:Label></div>
<div style="float:left; width:75%; height:19px;"> 
    <asp:Image ImageUrl = "/images/bar.png" Height="10px" ID="imgThree" runat="server" /> </div>
</div>
<div style="float:left; width:100%; margin-bottom:5px; font-size:11px;color:white; font-family:Tahoma;">
<div style="float:left; width:25%; height:19px;">Số bình chọn 2* :<asp:Label Font-Bold="true"  ID="Label2" runat="server" Text="Label"></asp:Label></div>
<div style="float:left; width:75%; height:19px;"> 
    <asp:Image ImageUrl = "/images/bar.png" Height="10px" ID="imgTwo" runat="server" /> </div>
</div>
<div style="float:left; width:100%; margin-bottom:0px; font-size:11px;color:white; font-family:Tahoma;">
<div style="float:left; width:25%; height:19px;">Số bình chọn 1* : <asp:Label Font-Bold="true" ID="Label1" runat="server" Text="Label"></asp:Label></div>
<div style="float:left; width:75%; height:19px;"> 
    <asp:Image ImageUrl = "/images/bar.png" Height="10px" ID="imgOne" runat="server" /> </div>
</div>