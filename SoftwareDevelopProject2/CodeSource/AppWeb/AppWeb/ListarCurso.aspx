<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ListarCurso.aspx.vb" Inherits="AppWeb.ListarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
 <h1>Cursos</h1>
 <hr />
<div class="lista-aportes">
    <asp:Repeater ID="listaCursos" runat="server">
        <ItemTemplate>
            <div class="aporte">
                <h2><%# Container.DataItem.Nombre%></h2>
                <p class="summary">
                    <strong>C&oacute;digo :</strong> <%# Container.DataItem.Codigo%><br />
                    <strong>Creditos :</strong> <%# Container.DataItem.Creditos%><br />
                    <strong>Estado :</strong> <%# Container.DataItem.Estado%><br />
                </p>
            </div>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaCursos.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontr&oacute; ning&uacute;n curso.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>
</div>
</asp:Content>
