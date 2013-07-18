<%@ Page Title="Foro" Language="vb" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="Foro.aspx.vb" Inherits="AppWeb.Foro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <div class="text small">
        <h1>Buscar Temas</h1>
        <p class="clearfix">
            <label class="form-row-sidebar">
                <span>T&iacute;tulo</span>
                <asp:TextBox ID="txtTituloTema" runat="server"></asp:TextBox>
            </label>
            <label class="form-row-sidebar">
                <asp:Button runat="server" Text="Buscar" ID="btnBuscar" />
            </label>
        </p>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div class="clearfix">
    <h1 class="pull-left"><asp:Label runat="server" ID="lblNombreForo" Text="NombreForo"></asp:Label>: Temas encontrados</h1>
    <div class="pull-right">
        <asp:HyperLink runat="server" CssClass="link-button" Visible="false" ID="linkEstGrupo"></asp:HyperLink>
        <asp:HyperLink runat="server" CssClass="link-button" Visible="false" ClientIDMode="Static" Text="Nuevo tema" ID="linkMostrarRegTema"></asp:HyperLink>
    </div>
</div>
<asp:Panel ID="pnlNuevoTema" Visible="false" runat="server">
    <div id="registrar-nuevo-tema">
        <h2>Agregar Nuevo Tema</h2>
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
            <asp:Label ID="lblAportesMinimo" runat="server" Text="Aportes M&iacute;nimos: "></asp:Label>
            <asp:TextBox ID="txtAporteMinimo" class="required digits"  runat="server"></asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Button ID="btnRegistrarTema" runat="server" Text="Agregar" OnClientClick="return confirm('¿Está seguro de que desea registrar un nuevo tema?');"/>
        </label>
    </div>
</asp:Panel>
<hr class="clear"  />
<div class="clear lista-temas">
    <asp:Repeater ID="listaTemas" runat="server">
        <ItemTemplate>
            <a class="tema clearfix" href="Tema.aspx?ID=<%# Container.DataItem.IdTema %>">
                <h1><%# Container.DataItem.Titulo%></h1>
                <div class="clear clearfix summary">
                    <div class="pull-left">
                        <strong>Empezado por:</strong> <%# Container.DataItem.NombreUsuario%><br />
                        <strong>Iniciado:</strong> <span class="date"><%# Container.DataItem.FechaInicio %></span>
                    </div>
                    <div class="pull-right">
                        <strong>M&iacute;nimo de aportes:</strong> <span class="date"><%# Container.DataItem.AportesMin%></span><br />
                        <strong>M&aacute;ximo de aportes:</strong> <span class="date"><%# Container.DataItem.AportesMax%></span>
                    </div>
                </div>
            </a>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaTemas.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontr&oacute; ning&uacute;n tema.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>
</div>
</asp:Content>
