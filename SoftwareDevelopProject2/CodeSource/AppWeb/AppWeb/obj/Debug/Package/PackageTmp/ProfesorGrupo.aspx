<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ProfesorGrupo.aspx.vb" Inherits="AppWeb.ProfesorGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <p class="small">
        Se listan los profesores asociados al grupo.
    </p><p class="small">
        Para desasignar a un profesor del grupo, presione el bot&oacute;n de desasignar.
        Esta acci&oacute;n debe ser confirmada.
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<h1><asp:Label runat="server" ID="lblGrupo" Text=""></asp:Label>: Profesores</h1>
<div class="lista-profesores">
    <asp:Repeater ID="listaProfesores" runat="server">
        <ItemTemplate>
            <div class="profesor">
                <h1><a href="href="Blog.aspx?ID=<%# Container.DataItem.IdUsuario %>"><%# Container.DataItem.Nombre & " " & Container.DataItem.Apellido1 & " " & Container.DataItem.Apellido2%></a></h1>
                <div class="pull-right">
                    <asp:Button ID="btnEliminar" CommandName="Eliminar" CommandArgument='<%# Container.DataItem.IdUsuario %>' Text="Desasignar" runat="server" 
                             onclientclick="return confirm(&quot;¿Desea desasignar al profesor del grupo?&quot;)"/>
                </div>
                <p class="summary">
                    <strong>Carn&eacute;:</strong> <%# Container.DataItem.Carnet%><br />
                    <strong>Correo: <span class="date"><%# Container.DataItem.Correo%></span></strong><br />
                    <strong>G&eacute;nero :</strong> <%# Container.DataItem.Genero%><br />
                    <a href="Blog.aspx?ID=<%# Container.DataItem.IdUsuario %>">Ver blog</a>
                </p>
            </div>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaProfesores.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontr&oacute; ning&uacute;n Profesor.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>
</div>
</asp:Content>
