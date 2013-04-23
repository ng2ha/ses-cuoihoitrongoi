<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoStream.aspx.cs" Inherits="SES.CMS.PhotoStream" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <meta property="fb:app_id" content="452379928120208" />
    <!-- styles needed by jScrollPane -->
    <style type="text/css">
        .showimg
        {
            max-width: 580px;
            max-height: 600px;
            vertical-align: middle;
        }
        .fb-like-zone
        {
            border: 1px solid #DFDFDF;
            border-radius: 2px 2px 2px 2px;
            background-color: #F4F4F4;
            padding: 0px 7px 3px 3px;
            margin-bottom: 10px;
            margin-top: 10px;
            overflow: hidden;
            margin-left: 5px;
            float: left;
            width: 320px;
        }
    </style>

    <script type="text/javascript"> 
        function vertAlign(pImg) 
        {
        var lHeight = pImg.clientHeight;
        var lParentHeight = pImg.parentNode.clientHeight;
        pImg.style.marginTop = (lParentHeight - lHeight)/2 + "px";
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="fb-root">
    </div>

    <script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = "//connect.facebook.net/en_GB/all.js#xfbml=1&appId=452379928120208";
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>

    <div style="float: left; width: 905px; height: 600px;">
        <div style="float: left; width: 580px; background-color: Black; height: 600px; line-height: 600px;
            text-align: center;">
            <asp:Image ID="imgSho" CssClass="showimg" runat="server" />
        </div>
        <div style="float: left; width: 325px; height: 600px;">
            <div style="width: 320px; float: left; font-family: Tahoma; font-weight: bold; text-transform: uppercase;
                font-size: 16px; color: #333; text-align: justify; margin-left: 5px;">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
            <div class="fb-like-zone">
                <div style="width: 320px; margin-left: 5px; margin-top: 3px;" class="fb-like" id="fblike"
                    runat="server" data-send="false" data-width="320" data-show-faces="false" data-font="tahoma">
                </div>
            </div>
            <div style="width: 320px; height: 505px; margin-left: 5px; overflow: auto; overflow-x:hidden;" class="fb-comments"
                id="fbcm" runat="server" data-num-posts="3" data-width="320">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
