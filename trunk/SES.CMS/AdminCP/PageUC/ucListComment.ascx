<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListComment.ascx.cs"
    Inherits="SES.CMS.AdminCP.PageUC.ucListComment" %>
<h2 style="text-align: left;">
    Danh sách Comment</h2>
<div style="width: 90%; float: left; margin-bottom: 10px;">
    Lựa chọn theo Bài viết có đánh giá/Bình luận:
    <asp:DropDownList ID="cboArticle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboArticle_SelectedIndexChanged">
    </asp:DropDownList>
</div>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView AutoGenerateColumns="False" Width="100%" ID="gvComment" runat="server"
                BackColor="White" BorderColor="#CC9966" DataKeyNames="CommentID" BorderStyle="None"
                BorderWidth="1px" CellPadding="4" OnRowDeleting="gvComment_RowDeleting" OnSelectedIndexChanged="gvComment_SelectedIndexChanged"
                AllowPaging="True" OnPageIndexChanging="gvComment_PageIndexChanging" PageSize="50">
                <RowStyle BackColor="White" ForeColor="#330099" />
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <Columns>
                    <asp:BoundField DataField="UserEmail" HeaderText="Email" />
                    <asp:BoundField DataField="CommentID" HeaderText="CommentID" Visible="false" />
                    <asp:BoundField DataField="ArticleStar" ItemStyle-Width="40px" HeaderText="Đánh giá" />
                    <asp:BoundField DataField="Title" HeaderText="Bài viết" />
                    <asp:TemplateField HeaderText="Ý kiến" ItemStyle-Width="80px">
                        <ItemTemplate>
                            <%#getlink(Eval("CommentID").ToString())%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="isAccept" ItemStyle-Width="30px" HeaderText="Duyệt" />
                    <asp:TemplateField ItemStyle-Width="40px">
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/ok_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("CommentID") %>'
                                CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
