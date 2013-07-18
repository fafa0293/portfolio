<%@ Page Title="" validateRequest="false" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ModificarEntrada.aspx.vb" Inherits="AppWeb.ModificarEntrada" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div class="spaced clear">
    <label class="form-row">
        <asp:Label ID="Label2" runat="server" Text="Titulo"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="380px" class="required"></asp:TextBox>
    </label>
    <label class="form-row">
        <asp:Label ID="Label1" runat="server" Text="Contenido"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="380px" TextMode="MultiLine" class="required"></asp:TextBox>
    </label>
    <label class="form-row">
        <asp:Button ID="Button3" runat="server" Text="Modificar" /><asp:Button ID="Button2" runat="server" Text="Cancelar" />
    </label>
    </div>
</asp:Content>
