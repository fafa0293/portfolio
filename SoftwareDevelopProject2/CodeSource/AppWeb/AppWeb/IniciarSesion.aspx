<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="IniciarSesion.aspx.vb" Inherits="AppWeb.IniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    //$("#sidebar-menu").addClass("invisible");
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <p class="small">
    Es requerido que inicie sesi&oacute;n en el sistema antes de utilizarlo.
</p>
<p class="small">
    Al iniciar sesi&oacute;n podr&aacute; acceder a todas las funcionalidades del sistema.
</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Iniciar Sesi&oacute;n</h1>
    <div class="spaced clear">
        <asp:Login ID="Login" runat="server" DestinationPageUrl="Principal.aspx" 
            FailureText="Acceso denegado." RenderOuterTable="False" OnAuthenticate="iniciarSesion">
            <LayoutTemplate>
            <label class="form-row">            
                <asp:Label ID="UserNameLabel" Text="Correo" runat="server" AssociatedControlID="UserName"></asp:Label>
                <asp:TextBox ID="UserName" runat="server" class="required email"></asp:TextBox>
            </label>
            <label class="form-row">
                <asp:Label ID="PasswordLabel" Text="Contraseña" runat="server" AssociatedControlID="Password"></asp:Label>
                <asp:TextBox ID="Password" runat="server"  class="required" TextMode="Password"></asp:TextBox>
            </label>       
            <label class="form-row">    
                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Iniciar Sesi&oacute;n" />                 
            </label>
            <label class="form-row">
                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
            </label>
            </LayoutTemplate>
        </asp:Login>
    </div>
</asp:Content>
