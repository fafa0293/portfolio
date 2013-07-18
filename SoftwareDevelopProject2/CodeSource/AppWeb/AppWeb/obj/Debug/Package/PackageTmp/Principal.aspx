<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="Principal.aspx.vb" Inherits="AppWeb.Principal1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <asp:Panel Visible="false" ID="pnlRegistro" runat="server">
        <h2>Opciones Administrativas</h2>
        <ul class="well navbar-horizontal pull-left">
            <li><a href="ListarCurso.aspx">Ver Cursos</a></li>
            <li><a href="ListarGrupo.aspx">Ver Grupos</a></li>
            <li><a href="AsignarEstudianteAGrupo.aspx">Asignar Estudiante a Grupo</a></li>
            <li><a href="AsignarProfeAGrupo.aspx">Asignar Profesor a Grupo</a></li>
        </ul>
    </asp:Panel>

    <asp:Panel Visible="false" ID="pnlProfesor" runat="server">
        <h2>Opciones Administrativas</h2>
        <ul class="well navbar-horizontal pull-left">
            <li><a href="AsignarEstudianteATema.aspx">Asignar Estudiante a Tema</a></li>
        </ul>
    </asp:Panel>

    <div id="logos" style="text-align: center;">
        <img alt="Star Community System" src="img/logo.png" />
        <a href="http://ucenfotec.ac.cr/"><img alt="Cenfotec" src="img/cenfologo.jpg" /></a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvenido a Star Community System, Cenfotec</h1>
    <img alt="Cenfotec" src="img/cenfo.jpg" />
</asp:Content>
