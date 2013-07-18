<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="Error.aspx.vb" Inherits="AppWeb._Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    $("#sidebar-menu").addClass("invisible");
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="error">
        <h1>¡Error!</h1>
        <p>
            <asp:Label runat="server" ID="lblError" Text="¡Hubo un error desconocido!"></asp:Label>
        </p><p>
            <a href="javascript:history.go(-1)">Volver a la página anterior</a>
        </p>
    </div>
</asp:Content>
