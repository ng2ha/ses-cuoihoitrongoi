<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucThongKe.ascx.cs" Inherits="SES.CMS.Module.ucThongKe" %>

    <h3 style="color:#6297BC;">
        Thống kê truy cập
    </h3>
<asp:Panel ID="pnOne" runat="server">
<table cellpadding="0" cellspacing="0" Width="100%" >
        
        <tr>
            
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
                Đang truy cập
               </td>
            <td class="tdcounter">
                <% =Application["visitors_online"].ToString()%></td>
        </tr>
       
    </table>
</asp:Panel>
<asp:Panel ID="pnAll" runat="server">
    <table cellpadding="0" cellspacing="0" Width="100%" >
        <tr>
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
                Đang online
               </td>
            <td class="tdcounter">
                <% =Application["visitors_online"].ToString()%></td>
        </tr>
       <tr>
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td style="width:60%">
                Hôm nay
               </td>
            <td class="tdcounter">
                    <asp:Literal ID="lblHomNayd" runat="server"></asp:Literal>
                
                </td>
        </tr>
        <tr>
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
               Hôm qua
               </td>
            <td class="tdcounter">
                    <asp:Literal ID="lblHomQuad" runat="server"></asp:Literal>
                
                </td>
        </tr>
        <tr>
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
               Tuần này
               </td>
            <td class="tdcounter">
                    <asp:Literal ID="lblTuanNayd" runat="server"></asp:Literal>
                
                </td>
        </tr>
        <tr>
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
               Tuần trước
               </td>
            <td class="tdcounter">
                    <asp:Literal ID="lblTuanTruocd" runat="server"></asp:Literal>
                
                </td>
        </tr>
        <tr>
            <td class="tdimg">

               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
                Tháng này
               </td>
            <td class="tdcounter">
                    <asp:Literal ID="lblThangNayd" runat="server"></asp:Literal>
                
                </td>
        </tr>
        <tr>
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
               Tháng trước
               </td>
            <td class="tdcounter">
                    <asp:Literal ID="lblThangTruocd" runat="server"></asp:Literal>
                
                </td>
        </tr>
        <tr>
            <td class="tdimg">
               <img src="Images/visitorIcon.gif" />
               </td>
               <td class="tdTrangThai">
                Tất cả
               </td>
            <td class="tdcounter">
                    <asp:Literal ID="lblTatCad" runat="server"></asp:Literal>
                
                </td>
        </tr>        
    </table>
    </asp:Panel>
