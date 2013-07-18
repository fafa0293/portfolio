<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ModificarTema.aspx.vb" Inherits="AppWeb.ModificarTema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Modificar Tema
    </h1>
    <div class="spaced clear">
        <label class="form-row">
            <asp:Label ID="lblTitulo" runat="server" Text="T&iacute;tulo: "></asp:Label>
            <asp:TextBox ID="txtTitulo" CssClass="required" runat="server"></asp:TextBox>
        </label>
        <label class="form-row">
            <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha Inicio: "></asp:Label>
            <asp:TextBox ID="txtFechaInicio" CssClass="required date" runat="server">
             </asp:TextBox>
        </label>
         <label class="form-row">
            <asp:Label ID="lblFechaFin" runat="server" Text="Fecha Fin: "></asp:Label>
            <asp:TextBox ID="txtFechaFin" CssClass="required date" runat="server">
            </asp:TextBox>
        </label>
        <label class="form-row">
            <asp:Label ID="lblAportesMaximo" runat="server" Text="Aportes M&aacute;ximos: "></asp:Label>
            <asp:TextBox ID="txtAportesMaximos" class="required digits"  runat="server"></asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Button ID="Button1" runat="server" Text="Modificar" OnClientClick="if (! confirm('¿Desea modificar el tema?')) return false;"/>
        </label>
    </div>

</asp:Content>
