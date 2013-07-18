<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ListarForo.aspx.vb" Inherits="AppWeb.ListarForos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
<p class="small">
    A la derecha se muestran los foros que usted tiene permiso para acceder.
</p><p class="small">
    Haga click en el nombre de un foro para ver una lista de los temas que contiene.
</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <h1>Foros</h1>
  <hr />
  <div class="lista-temas">
    <asp:Repeater ID="listaForos" runat="server">
        <ItemTemplate>
             <div class="tema">
                <a class="tema pull-left" href="Foro.aspx?ID=<%# Container.DataItem.IdForo %>"><h1><%# Container.DataItem.NombreForo%></h1></a>
                <p class="clear summary">
                    <strong>Temas:</strong> <%# Container.DataItem.CantTemas%><br />
                    <strong>Aportes:</strong> <%# Container.DataItem.CantAportes%>
                </p>
            </div>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaForos.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontr&oacute; ning&uacute;n foro.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>
</div>
</asp:Content>
