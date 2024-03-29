﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPopup.ascx.cs" Inherits="SES.CMS.Module.ucPopup" %>
<asp:Label ID="lblScr" runat="server"></asp:Label>
<script type="text/javascript">   
var popupStatus1 = 0;
//loading popup with jQuery magic!
function loadPopup1(){
 //loads popup only if it is disabled
 if(popupStatus1==0){
  $("#backgroundPopup1").css({
   "opacity": "0.7",
   "position": "fixed",
    "top": 0,
  "left": 0,
   "background": "black"
  });
  $("#backgroundPopup1").fadeIn();
  $("#popupContact1").fadeIn();
  popupStatus1 = 1;
 }
}
//disabling popup with jQuery magic!
function disablePopup1(){
 //disables popup only if it is enabled
 if(popupStatus1==1){
  $("#backgroundPopup1").fadeOut("slow");
  $("#popupContact1").fadeOut("slow");
  popupStatus1 = 0;
 }
}
//centering popup
function centerPopup1(){
 //request data for centering
 var windowWidth = document.documentElement.clientWidth;
 var windowHeight = document.documentElement.clientHeight;
 var popupHeight = $("#popupContact1").height();
 var popupWidth = $("#popupContact1").width();
 //centering
 $("#popupContact1").css({
  "position": "fixed",
  "top": (windowHeight - popupHeight)/2,
  "left": (windowWidth-popupWidth)/2,
  "background": "white"
 });
 //only need force for IE6
 
 $("#backgroundPopup1").css({
  "height": windowHeight,
  "width": windowWidth
 });
 
}

//CONTROLLING EVENTS IN jQuery
$(document).ready(function(){
// $("#popupData").hide(0);						   
 $("#backgroundPopup1").hide(0);
 $("#popupContact1").hide(0);
 //LOADING POPUP
 //centering with css
 centerPopup1();
 //load popup
 loadPopup1();
    
 //CLOSING POPUP
 //Click the x event!
 $("#popupContactClose1").click(function(){
  disablePopup1();
    return false;
 });
 //Click out event!
 $("#backgroundPopup1").click(function(){
  //disablePopup();
 });
 //Press Escape event!
 $(document).keypress(function(e){
  if(e.keyCode==27 && popupStatus1==1){
   disablePopup1();
  }
 });
});              
</script>
