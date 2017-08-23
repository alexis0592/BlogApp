<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreatePost.aspx.cs" Inherits="Blog.UI.CreatePost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <table style="width: 100%;">
            <tr>
                <td>Titulo:</td>
                <td>
                    <asp:TextBox runat="server" ID="txt_title"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Contenido:</td>
                <td>
                    <asp:TextBox runat="server" ID="txt_contenido" TextMode="MultiLine"/>
                </td>
            </tr>
            <tr>
                <td>Autor:</td>
                <td>
                <asp:DropDownList ID="DropDownList_author" runat="server" OnSelectedIndexChanged="DropDownList_author_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
            <tr>
                <td style="text-align:center">
                    <asp:Button ID="btn_guardar" runat="server" Text="Save"/>
                </td>           
                <td style="text-align:center">
                    <asp:Button ID="btn_clean" runat="server" Text="Clean"/>
                </td>
                
            </tr>
        </table>

</asp:Content>
