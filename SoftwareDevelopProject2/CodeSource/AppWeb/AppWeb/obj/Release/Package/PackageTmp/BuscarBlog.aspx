<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="BuscarBlog.aspx.vb" Inherits="AppWeb.BuscarBlog1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
<div class="text small">
    <h1>Buscar Blogs</h1>
    <p class="clearfix">
    <asp:Panel ID="pnBusqueda" runat="server">
        <label class="form-row-sidebar">
            <asp:RadioButton ID="rdbNombre" runat="server" GroupName="Grupo" Text="Nombre"/>       
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </label>
        <label class="form-row-sidebar">
            <asp:RadioButton ID="rdbRol" runat="server" GroupName="Grupo" Text="Rol"/>
            <asp:DropDownList ID="cmbRol" runat="server" DataTextField="Nombre" 
                DataValueField="IdRol">
            </asp:DropDownList>
        </label>
        <label class="form-row-sidebar">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
        </label>
    </asp:Panel>
    </p>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<h1>Blogs encontrados</h1>
 <hr />
<div class="lista-blogs">
    <asp:Repeater ID="listaBlogs" runat="server">
        <ItemTemplate>
            <a class="blog" href="Blog.aspx?ID=<%# Container.DataItem.IdBlog%>">
            <h1>Blog de <%# Container.DataItem.NombreUsuario%></h1>
            <div class="summary"><strong>Entradas:</strong> <%# Container.DataItem.CantEntradas%></div>
            </a>
        </ItemTemplate>
        <FooterTemplate>  
            <% If listaBlogs.Items.Count = 0 Then%>
                <div class="alert">
                    <h1>¡Atenci&oacute;n!</h1>
                    <p>No se encontr&oacute; ning&uacute;n blog.</p>
                </div>
            <% End If%>  
        </FooterTemplate>  
    </asp:Repeater>
</div>
</asp:Content>
