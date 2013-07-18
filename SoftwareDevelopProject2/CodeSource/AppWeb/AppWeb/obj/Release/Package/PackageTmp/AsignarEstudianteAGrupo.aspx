<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="AsignarEstudianteAGrupo.aspx.vb" Inherits="AppWeb.AsignarEstudianteAGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
        <p class="small">
        Para asignar un estudiante, primero debe buscar el grupo al que lo quiere asignar.
    </p>
    <p class="small">
        Después, seleccione un estudiante de la lista y un grupo en la otra lista, y presione el botón de asignar.
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlSuccess" runat="server" Visible="false">
        <div class="success">
            <asp:Label ID="lblSuccess" runat="server"></asp:Label>
        </div>
     </asp:Panel>
    <asp:Panel ID="pnlAlert" runat="server" Visible="false">
        <div class="alert">
            <asp:Label ID="lblAlert" runat="server"></asp:Label>
        </div>
     </asp:Panel>
    <asp:Panel ID="pnlBusqueda" runat="server" GroupingText="Búsqueda" >
        <div class="spaced clear">
            <label><asp:Label ID="lblCurso" runat="server" Text="Curso"></asp:Label>
            <asp:DropDownList ID="ddlCurso" runat="server" DataTextField="Nombre" 
                DataValueField="IdCurso">
            </asp:DropDownList></label>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
         </div>
     </asp:Panel>
     <asp:Panel ID="pnlEstudiante" runat="server" GroupingText="Estudiante">
         <div class="spaced clear">
             <label class="form-row">
                 <asp:GridView ID="gvEstudiantes" runat="server" AutoGenerateColumns="False" 
                 AutoGenerateSelectButton="True" AllowSorting="True" CssClass="gridview"
                 DataKeyNames="IdUsuario" DataMember="IdUsuario">
                     <Columns>
                         <asp:BoundField HeaderText="id" DataField="IdUsuario" Visible="False" />
                         <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                         <asp:BoundField HeaderText="Primer Apellido" DataField="Apellido1" />
                         <asp:BoundField HeaderText="Segundo Apellido" DataField="Apellido2" />
                         <asp:BoundField DataField="Cedula" HeaderText="Cédula" />
                     </Columns>
                     <SelectedRowStyle CssClass="selected-row" />
                 </asp:GridView>
                 <% If gvEstudiantes.Rows.Count = 0 Then%>
                    <div class="alert">
                        <h1>¡Atenci&oacute;n!</h1>
                        <p>No hay estudiantes registrados.</p>
                    </div>
                <% End If%>
             </label>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnlGrupos" runat="server" GroupingText="Grupos">
         <div class="spaced clear">
             <label class="form-row">
                 <asp:GridView ID="gvGrupos" runat="server" AutoGenerateColumns="False" 
                 AutoGenerateSelectButton="True" DataKeyNames="IdGrupo" CssClass="gridview"
                 DataMember="IdGrupo">
                     <Columns>
                         <asp:BoundField HeaderText="Id" Visible="False" />
                         <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                     </Columns>
                     <SelectedRowStyle CssClass="selected-row" />
                 </asp:GridView>
                 <% If gvGrupos.Rows.Count = 0 And IsPostBack Then%>
                    <div class="alert">
                        <h1>¡Atenci&oacute;n!</h1>
                        <p>No se encontr&oacute; ning&uacute;n Grupo</p>
                    </div>
                <% End If%>
             </label>
        </div>
    </asp:Panel>
    <asp:Button ID="btnAsignar" runat="server" Text="Asignar" 
        onclientclick="return confirm(&quot;¿Está seguro que desea realizar la asignación del estudiante al grupo?&quot;)" />
    <a href="Principal.aspx" class="link-button">Cancelar</a>
</asp:Content>
