<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultPost.aspx.cs" Inherits="Blog.UI.ConsultPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Consultar Post</h1>
        <hr />
    </div>
    <asp:GridView ID="dg_posts" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="dg_posts_PageIndexChanging" OnSelectedIndexChanged="dg_posts_SelectedIndexChanged" OnRowDeleting="dg_posts_RowDeleting">
        <AlternatingRowStyle BackColor="White" />
        
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        <Columns>
            <asp:ButtonField ButtonType="Button" Text="Eliminar" AccessibleHeaderText="Opciones" HeaderText="Opciones" CommandName="Delete" />
        </Columns>
    </asp:GridView>

</asp:Content>
