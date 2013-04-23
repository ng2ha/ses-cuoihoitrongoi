<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListProduct.ascx.cs" Inherits="SES.CMS.AdminCP.PageUC.ucListProduct" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<h2>
    Danh sách Dây chuyền</h2>
<dxwgv:ASPxGridView ID="gvProduct" runat="server"
    AutoGenerateColumns="False" KeyFieldName="ProductID" Width="90%" 
    EnableCallBacks="False" onstartrowediting="gvProduct_StartRowEditing" 
    onrowdeleting="gvProduct_RowDeleting">
    <SettingsPager AlwaysShowPager="True" PageSize="30">
    </SettingsPager>
    <Columns>
        <dxwgv:GridViewDataTextColumn Caption="STT" Width="5%" FieldName="STT" Name="colSTT" 
            VisibleIndex="0">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn Caption="Tiêu đề" Width="40%" FieldName="Title" 
            Name="colTitle" VisibleIndex="1">
        </dxwgv:GridViewDataTextColumn>
          <dxwgv:GridViewDataTextColumn Caption="Dây chuyền" Width="24%" FieldName="LineName" 
            Name="colProductLine" VisibleIndex="2">
        </dxwgv:GridViewDataTextColumn>
        
    <dxwgv:GridViewDataTextColumn Caption="Nổi bật" Width="5%" FieldName="IsHompage" 
            Name="colIsHompage" VisibleIndex="1">
        </dxwgv:GridViewDataTextColumn>
        
        <dxwgv:GridViewCommandColumn Caption="Sửa" Width="5%" VisibleIndex="6">
            <EditButton Text="Sửa" Visible="True">
            </EditButton>
            <HeaderStyle HorizontalAlign="Center" />
        </dxwgv:GridViewCommandColumn>
         <dxwgv:GridViewCommandColumn Caption="Xóa" Width="5%" VisibleIndex="7">
            <DeleteButton Text="Xóa" Visible="True">
            </DeleteButton>
            <HeaderStyle HorizontalAlign="Center" />
        </dxwgv:GridViewCommandColumn>
        
        <dxwgv:GridViewDataTextColumn Caption="ProductID" FieldName="ProductID" 
            Visible="False" VisibleIndex="7">
        </dxwgv:GridViewDataTextColumn>
    </Columns>
</dxwgv:ASPxGridView>
<asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Thêm mới" />

