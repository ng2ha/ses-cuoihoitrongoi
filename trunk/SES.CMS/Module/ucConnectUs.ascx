<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucConnectUs.ascx.cs" Inherits="SES.CMS.Module.ucConnectUs" %>
  <script type="text/javascript">
    function clickSearch(e) {
        if (e.value == "") {
            e.value = "Nhập Email của bạn...";
        }
        else 
        {
        if(e.value == "Nhập Email của bạn...")
            e.value = "";
            }
    }
    
</script>
  <div style="float: left; margin-left: 20px; height: auto; width: 100%;">
                                <div style="float: left; text-align: left; font-weight: bold; margin-left: 0px; width: 100%;
                                    color: #FDD017; font-size: 13px;">
                                   Nhận Thông tin Khuyến mãi hấp dẫn:
                                </div>
                                <div style="float: left; margin-left: 0px; margin-top: 5px; width: 100%">
                                    <asp:TextBox Text="Nhập Email của bạn..." CssClass="contact-input-mail" ValidationGroup="xxs" ID="txtMailinglist" runat="server"></asp:TextBox>
                                    <asp:Button ID="btnMaillist" CssClass="submit-mail" ValidationGroup="xxs" runat="server" 
                                        Text="Đăng ký" onclick="btnMaillist_Click" />
                                    <div style="float:left; width:10px;">
                                        <asp:RequiredFieldValidator ForeColor="White" ValidationGroup="xxs" ID="RequiredFieldValidator1" ControlToValidate="txtMailinglist" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ForeColor="White" ValidationGroup="xxs" ID="expEmail" runat="server" ControlToValidate="txtMailinglist" ErrorMessage="*" ValidationExpression="^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div style="float: left; text-align: left; margin-top: 10px; font-weight: bold; margin-left: 0px;
                                    width: 100%; color: #FDD017; font-size: 13px;">
                                    Kết nối Cưới Hỏi Trọn Gói:
                                    <div class="socialicon" style="margin-top: 5px; margin-left: 0px; width: 100%;">
                                        <a href="http://www.facebook.com/CuoiHoiTronGoi.QuangDung">
                                            <img alt="Chúng tôi trên Facebook" src="/images/facebook.png" /></a>
                                            <a href="http://CuoiHoiTronGoi.com.vn/RSS.aspx">
                                            <img alt="Chúng tôi trên Facebook" src="/images/rss.png" width="20px" height="20px" /></a>
                                        <iframe runat="server" id="abc" scrolling="no" frameborder="0" style="margin-bottom: 2px;
                                            float: left; border: none; overflow: hidden; width: 85px; height: 24px;" allowtransparency="true">
                                        </iframe>
                                        
                                        
                                    </div>
                                </div>
                            </div>