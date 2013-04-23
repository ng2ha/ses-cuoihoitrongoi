<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SES.CMS.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

       <script type="text/javascript" src="/fancybox/jquery.fancybox-1.3.4.pack.js"></script>

    <script type="text/javascript" src="/fancybox/jquery.easing-1.3.pack.js"></script>

    <script type="text/javascript" src="/fancybox/jquery.mousewheel-3.0.4.pack.js"></script>

    <link rel="stylesheet" type="text/css" href="/fancybox/jquery.fancybox-1.3.4.css"
        media="screen" />

    <script type="text/javascript">
		$(document).ready(function() {
			/*
			*   Examples - images
			*/

				$("a.fancyboxstream").attr('rel', 'gallery').fancybox({
		 type: 'iframe',
		fitToView	: true,
		width		: '95%',
		height		: '82%',
		autoSize	: true,
		padding		: 0
	});
	});
    </script>



</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    <a class="fancyboxx" href="/PhotoStream/726/Default.aspx">Open 1</a>

<br />

<a class="fancyboxx" href="/PhotoStream/727/Default.aspx">Open 200x500</a>

    </div>
    </form>
</body>
</html>
