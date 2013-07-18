<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="EstudiantesTema.aspx.vb" Inherits="AppWeb.EstudiantesTema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
<p class="small">
    Se listan los estudiantes que pueden leer y hacer aportes al tema.
</p>
<p class="small">
    Para bloquear a un estudiante de este tema, presione el bot&oacute;n "Bloquear".
    Debe ingresar una justificaci&oacute;n antes de continuar.
</p>
<p>
    <asp:HyperLink ID="HyperLink1" runat="server">Volver al tema</asp:HyperLink>
</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<h1>Tema <asp:Label runat="server" ID="lblGrupo" Text=""></asp:Label>: Estudiantes Asignados</a></h1>
<asp:HiddenField ID="iIdTema" ClientIDMode="Static" runat="server" />
<div class="lista-estudiantes">
    <asp:Repeater ID="listaEstudiantes" runat="server">
        <ItemTemplate>
            <div class="estudiante">
                <h1><a href="Blog.aspx?ID=<%# Container.DataItem.IdUsuario %>"><%# Container.DataItem.Nombre & " " & Container.DataItem.Apellido1 & " " & Container.DataItem.Apellido2%></a></h1>
                <div class="pull-right opciones-estudiante-tema" data-id-usuario="<%# Container.DataItem.IdUsuario %>">
                    <asp:Button ID="btnBloquear" CommandName="Bloquear" CommandArgument='<%# Container.DataItem.IdUsuario %>' Text="Bloquear" runat="server" />
                </div>
                <p class="summary">
                    <strong>Carn&eacute;:</strong> <%# Container.DataItem.Carnet%><br />
                    <strong>Correo: <span class="date"><%# Container.DataItem.Correo%></span></strong><br />
                    <strong>G&eacute;nero:</strong> <%# Container.DataItem.Genero%><br />
                    <a href="Blog.aspx?ID=<%# Container.DataItem.IdUsuario %>">Ver blog</a>
                </p>
            </div>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaEstudiantes.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontr&oacute; ning&uacute;n Estudiante.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>
</div>
</asp:Content>
