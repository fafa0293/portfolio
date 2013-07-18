<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ModificarPerfil.aspx.vb" Inherits="AppWeb.ModificarBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" Runat="server">
<p class="small">
Su nombre completo y correo electrónico serán visibles por todos los usuarios del sistema.
</p>
<p class="small">
Los demás datos solamente pueden ser accesados por el rector, los directores académicos, profesores, y encargados de registro.
</p>
<p class="small">
Todos los campos de este formulario son requeridos.
</p>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">

<% If update AND IsPostBack Then%>
    <div class="success">
        <h1>&iexcl;&Eacute;xito!</h1>
        <p>Se han modificado los datos del perfil</p>
    </div>
<% End If%>

<% If update = False AND IsPostBack Then%>
    <div class="alert">
        <h1>¡Error!</h1>
        <p>No se modific&oacute; el perfil</p>
    </div>
<% End If%>
<h1>Modificar Perfil</h1>
<hr />
    <h2>Informaci&oacute;n Personal</h2>
    <div class="spaced clear">
        <label class="form-row">
	        <asp:Label ID="Label1" runat="server" Text="C&eacute;dula"></asp:Label>
	        <asp:TextBox ID="txtCedula" class="required digits" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label2" runat="server" Text="Carn&eacute;"></asp:Label>
	        <asp:TextBox ID="txtCarnet" class="required digits" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
	        <asp:TextBox ID="txtNombre" class="required" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label4" runat="server" Text="Primer Apellido"></asp:Label>
	        <asp:TextBox ID="txtApellido1" class="required" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label5" runat="server" Text="Segundo Apellido"></asp:Label>
	        <asp:TextBox ID="txtApellido2" class="required" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label6" runat="server" Text="G&eacute;nero"></asp:Label>
            <asp:RadioButton ID="rbdMasculino" runat="server" GroupName="gbGenero" 
                Text="Masculino" />
            <asp:RadioButton ID="rbdFemenino" runat="server" GroupName="gbGenero" 
                Text="Femenino" />
        </label>
        <label class="form-row">
	        <asp:Label ID="Label7" runat="server" Text="Fecha Nacimiento"></asp:Label>
	        <asp:TextBox ID="txtFechaNacimiento" class="required date" runat="server">
	        </asp:TextBox>
        </label>
    </div>

    <h2 class="clear">Contacto</h2>
    <div class="spaced clear">
        <label class="form-row">
	        <asp:Label ID="Label8" runat="server" Text="Correo Electr&oacute;nico"></asp:Label>
	        <asp:TextBox ID="txtCorreoElectronico" class="required email" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label9" runat="server" Text="Tel&eacute;fono Celular"></asp:Label>
	        <asp:TextBox ID="txtTelefonoCelular" class="required digits" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label10" runat="server" Text="Tel&eacute;fono Casa"></asp:Label>
	        <asp:TextBox ID="txtTelefonoCasa" class="required digits" runat="server">
	        </asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label11" runat="server" Text="Direcci&oacute;n"></asp:Label>
	        <textarea cols="3" rows="4" ID="txtDireccion" class="required" runat="server"></textarea>
        </label>

        <label class="form-row">
	        <asp:Button ID="Button1" runat="server" Text="Modificar" />
        </label>
    </div>
</asp:Content>
