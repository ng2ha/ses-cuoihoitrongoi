<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SES.CMS.Search" Title="Untitled Page" %>
<%@ Register Src="Module/ucServiceMenu.ascx" TagName="ucServiceMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSocialLink.ascx" TagName="ucSocialLink" TagPrefix="uc5" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainct">
        <uc1:ucServiceMenu ID="ucServiceMenu1" runat="server" />
        <div class="servicecontent">
        <uc2:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
            <div class="servicecontent-top">
                <div class="servicecontent-top-left">
                    <h1 class="h1style">
                        <asp:Label ID="lblContentTitle" runat="server" Text="Title" Font-Size="18px">TÌM KIẾM</asp:Label>
                    </h1>
                </div>
                <div class="servicecontent-top-rgt">
                </div>
            </div>
            <br /><br /><br />
            <blockquote class="serviceintro">
           <div id="cse" style="width: 100%;">Loading</div>
<script src="http://www.google.com/jsapi" type="text/javascript"></script>
<script type="text/javascript"> 
  google.load('search', '1', {language : 'vi', style : google.loader.themes.ESPRESSO});
  google.setOnLoadCallback(function() {
    var customSearchOptions = {};  var customSearchControl = new google.search.CustomSearchControl(
      '002139266318757955430:xtvbik8uzja', customSearchOptions);
    customSearchControl.setResultSetSize(google.search.Search.FILTERED_CSE_RESULTSET);
    customSearchControl.draw('cse');
    function parseParamsFromUrl() {
      var params = {};
      var parts = window.location.search.substr(1).split('\x26');
      for (var i = 0; i < parts.length; i++) {
        var keyValuePair = parts[i].split('=');
        var key = decodeURIComponent(keyValuePair[0]);
        params[key] = keyValuePair[1] ?
            decodeURIComponent(keyValuePair[1].replace(/\+/g, ' ')) :
            keyValuePair[1];
      }
      return params;
    }

    var urlParams = parseParamsFromUrl();
    var queryParamName = "q";
    if (urlParams[queryParamName]) {
      customSearchControl.execute(urlParams[queryParamName]);
    }
  }, true);
</script>
            </blockquote>
          <style type="text/css">
  .gsc-control-cse {
    font-family: Georgia, serif;
    border-color: #780000;
    background-color: #780000;
  }
  .gsc-control-cse .gsc-table-result {
    font-family: Georgia, serif;
  }
  input.gsc-input {
    border-color: #3333ff;
  }
  input.gsc-search-button {
    border-color: #ff0000;
    background-color: #990000;
  }
  .gsc-tabHeader.gsc-tabhInactive {
    border-color: #A25B08;
    background-color: #A25B08;
  }
  .gsc-tabHeader.gsc-tabhActive {
    border-color: #330000;
    background-color: #461200;
  }
  .gsc-tabsArea {
    border-color: #330000;
  }
  .gsc-webResult.gsc-result,
  .gsc-results .gsc-imageResult {
    border-color: #780000;
    background-color: #780000;
  }
  .gsc-webResult.gsc-result:hover,
  .gsc-imageResult:hover {
    border-color: #990000;
    background-color: #990000;
  }
  .gsc-webResult.gsc-result.gsc-promotion:hover {
    border-color: #990000;
    background-color: #990000;
  }
  .gs-webResult.gs-result a.gs-title:link,
  .gs-webResult.gs-result a.gs-title:link b,
  .gs-imageResult a.gs-title:link,
  .gs-imageResult a.gs-title:link b {
    color: #ffff66;
  }
  .gs-webResult.gs-result a.gs-title:visited,
  .gs-webResult.gs-result a.gs-title:visited b,
  .gs-imageResult a.gs-title:visited,
  .gs-imageResult a.gs-title:visited b {
    color: #cc9933;
  }
  .gs-webResult.gs-result a.gs-title:hover,
  .gs-webResult.gs-result a.gs-title:hover b,
  .gs-imageResult a.gs-title:hover,
  .gs-imageResult a.gs-title:hover b {
    color: #ffcc00;
  }
  .gs-webResult.gs-result a.gs-title:active,
  .gs-webResult.gs-result a.gs-title:active b,
  .gs-imageResult a.gs-title:active,
  .gs-imageResult a.gs-title:active b {
    color: #996633;
  }
  .gsc-cursor-page {
    color: #ffff66;
  }
  a.gsc-trailing-more-results:link {
    color: #ffff66;
  }
  .gs-webResult .gs-snippet,
  .gs-imageResult .gs-snippet,
  .gs-fileFormatType {
    color: #ffffff;
  }
  .gs-webResult div.gs-visibleUrl,
  .gs-imageResult div.gs-visibleUrl {
    color: #33cc00;
  }
  .gs-webResult div.gs-visibleUrl-short {
    color: #33cc00;
  }
  .gs-webResult div.gs-visibleUrl-short {
    display: none;
  }
  .gs-webResult div.gs-visibleUrl-long {
    display: block;
  }
  .gs-promotion div.gs-visibleUrl-short {
    display: none;
  }
  .gs-promotion div.gs-visibleUrl-long {
    display: block;
  }
  .gsc-cursor-box {
    border-color: #780000;
  }
  .gsc-results .gsc-cursor-box .gsc-cursor-page {
    border-color: #A25B08;
    background-color: #780000;
    color: #ffff66;
  }
  .gsc-results .gsc-cursor-box .gsc-cursor-current-page {
    border-color: #330000;
    background-color: #461200;
    color: #cc9933;
  }
  .gsc-webResult.gsc-result.gsc-promotion {
    border-color: #FEFEDC;
    background-color: #FFFFCC;
  }
  .gsc-completion-title {
    color: #ffff66;
  }
  .gsc-completion-snippet {
    color: #ffffff;
  }
  .gs-promotion a.gs-title:link,
  .gs-promotion a.gs-title:link *,
  .gs-promotion .gs-snippet a:link {
    color: #0000CC;
  }
  .gs-promotion a.gs-title:visited,
  .gs-promotion a.gs-title:visited *,
  .gs-promotion .gs-snippet a:visited {
    color: #0000CC;
  }
  .gs-promotion a.gs-title:hover,
  .gs-promotion a.gs-title:hover *,
  .gs-promotion .gs-snippet a:hover {
    color: #0000CC;
  }
  .gs-promotion a.gs-title:active,
  .gs-promotion a.gs-title:active *,
  .gs-promotion .gs-snippet a:active {
    color: #0000CC;
  }
  .gs-promotion .gs-snippet,
  .gs-promotion .gs-title .gs-promotion-title-right,
  .gs-promotion .gs-title .gs-promotion-title-right *  {
    color: #333333;
  }
  .gs-promotion .gs-visibleUrl,
  .gs-promotion .gs-visibleUrl-short {
    color: #A25B08;
  }</style> 
            <uc5:ucSocialLink ID="ucSocialLink1" runat="server" />
        </div>
    </div>
</asp:Content>
