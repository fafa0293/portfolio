<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ListarGrupo.aspx.vb" Inherits="AppWeb.ListarGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <asp:Panel ID="pnBusqueda" runat="server">
         <label class="form-row-sidebar">
         <span>
            <asp:RadioButton ID="rbNombre" runat="server" GroupName="BuscarGrupo" 
            Text="Nombre" /></span>
                <asp:TextBox ID="txtBuscarNombre" runat="server"></asp:TextBox>
         </label>
        <label class="form-row-sidebar">
           <span> <asp:RadioButton ID="rbCodigo" runat="server" GroupName="BuscarGrupo" 
                Text="Código" /> </span>
                  <asp:TextBox ID="txtBuscarCodigo" runat="server"></asp:TextBox>
                </label>
          <label class="form-row-sidebar">
          <span>
            <asp:RadioButton ID="rbCurso" runat="server" GroupName="BuscarGrupo" 
                Text="Curso" /></span>
                <asp:DropDownList ID="ddlCurso" runat="server" DataTextField="Nombre" 
                DataValueField="IdCurso">
                </asp:DropDownList>
            <br/>
         </label>
         <label class="form-row-sidebar">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
        </label>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Grupos</h1>
    <hr>
<div class="lista-aportes">
    <asp:Repeater ID="listaGrupos" runat="server">
        <ItemTemplate>
            <div class="aporte">
                <h2><%# Container.DataItem.Nombre%></h2>
                <div class="pull-right">
                    <div class="clear">
                        <a class="link-button" href="EstudiantesGrupo.aspx?ID=<%# Container.DataItem.IdGrupo%>">Estudiantes</a>
                        <a class="link-button" href="ProfesorGrupo.aspx?ID=<%# Container.DataItem.IdGrupo%>">Profesores</a>
                    </div>
                    <div class="clear pull-right" style="margin-top: 6px;">
                        <asp:Button ID="btnEliminar" CommandName="Eliminar" CommandArgument='<%# Container.DataItem.IdGrupo %>' Text="Eliminar" runat="server" OnClientClick="if (! confirm('¿Desea eliminar al grupo?')) return false;" />
                    </div>
                </div>
                <p class="summary">
                    <strong>C&oacute;digo:</strong> <%# Container.DataItem.Codigo%><br />
                    <strong>Per&iacute;odo:</strong> <%# Container.DataItem.Periodo%><br />
                    <strong>Curso:</strong> <%# Container.DataItem.Curso%><br />
                    <strong>Estado:</strong> <%# Container.DataItem.Estado%><br />
                </p>
            </div>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaGrupos.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontr&oacute; ning&uacute;n grupo.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>
</div>
</asp:Content>
