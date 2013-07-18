<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="AsignarEstudianteATema.aspx.vb" Inherits="AppWeb.AsignarEstudianteATema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <p class="small">
        Para asignar un estudiante a un tema, primero debe buscar el tema al que lo quiere asignar.
    </p>
    <p class="small">
        Después, seleccione un estudiante de la lista y un tema en la otra lista, y presione el botón de asignar.
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
            <label><asp:Label ID="lblGrupo" runat="server" Text="Grupo"></asp:Label>
            <asp:DropDownList ID="ddlGrupo" runat="server" DataTextField="Nombre" 
            DataValueField="IdGrupo">
            </asp:DropDownList></label>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
         </div>
     </asp:Panel>
     <asp:Panel ID="pnlEstudiante" runat="server" GroupingText="Estudiante">
         <div class="spaced clear">
             <label class="form-row">
                 <asp:GridView ID="gvEstudiante" runat="server" AutoGenerateColumns="False" 
                 AutoGenerateSelectButton="True" DataKeyNames="IdUsuario" CssClass="gridview"
                 DataMember="IdUsuario">
                     <Columns>
                         <asp:BoundField HeaderText="Id" DataField="IdUsuario" Visible="False" />
                         <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                         <asp:BoundField HeaderText="Primer Apellido" DataField="Apellido1" />
                         <asp:BoundField HeaderText="Segundo Apellido" DataField="Apellido2" />
                         <asp:BoundField DataField="Cedula" HeaderText="Cédula" />
                     </Columns>
                     <SelectedRowStyle CssClass="selected-row" />
                 </asp:GridView>
                 <% If gvEstudiante.Rows.Count = 0 And IsPostBack Then%>
                    <div class="alert">
                        <h1>¡Atenci&oacute;n!</h1>
                        <p>No se encontraron estudiantes.</p>
                    </div>
                <% End If%>
             </label>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnlTemas" runat="server" GroupingText="Temas">
         <div class="spaced clear">
             <label class="form-row">
                 <asp:GridView ID="gvTema" runat="server" AutoGenerateColumns="False" CssClass="gridview"
                 AutoGenerateSelectButton="True" DataKeyNames="IdTema" DataMember="IdTema">
                     <Columns>
                         <asp:BoundField HeaderText="Id" DataField="IdTema" Visible="False" />
                         <asp:BoundField DataField="Titulo" HeaderText="Título Tema" />
                     </Columns>
                        <SelectedRowStyle CssClass="selected-row" />
                 </asp:GridView>
                 <% If gvTema.Rows.Count = 0 And IsPostBack Then%>
                    <div class="alert">
                        <h1>¡Atenci&oacute;n!</h1>
                        <p>No hay se encontraron Temas.</p>
                    </div>
                <% End If%>

             </label>
        </div>
    </asp:Panel>
    <asp:Button ID="btnAsignar" runat="server" Text="Asignar" 
        onclientclick="return confirm(&quot;¿Está seguro que desea realizar la asignación del estudiante al tema?&quot;)" />
    <a href="Principal.aspx" class="link-button">Cancelar</a>
</asp:Content>
