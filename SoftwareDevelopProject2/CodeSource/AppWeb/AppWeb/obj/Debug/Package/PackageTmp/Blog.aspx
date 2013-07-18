<%@ Page Title="" validateRequest="false" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="Blog.aspx.vb" Inherits="AppWeb.Blog1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
<div class="text small">
    <h1><asp:Label runat="server" ID="lblNombreUsuario2" Text=""></asp:Label></h1>
    <p>Correo electrónico: <asp:Label runat="server" ID="lblCorreoElectronico" Text=""></asp:Label></p>
    <hr />
    <h2>Buscar</h2>
    <label class="form-row-sidebar">
        <asp:Label ID="lblTitulo" runat="server" Text="T&iacute;tulo"></asp:Label>
        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
    </label>
    <label class="form-row-sidebar">
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
    </label>
    <br class="clear" />
    <hr />
    <h2>Temas</h2>
    <div class="text temas">
        <!-- Listar aquí todos los temas del blog de este usuario --->
        <!-- Cuando hace click en un tema, lo envía a una lista de las entradas con ese tema -->
        <!-- Por ejemplo Blog.aspx?IDUsuario=1&Tema=programacion -->
         <asp:Repeater ID="listaTemasBlog" runat="server"> 
            <ItemTemplate>
                <div class="temas pull-left">
                    <a class="blog" href="Blog.aspx?TEMA=<%# Container.DataItem.Id%>">
                        <asp:Label ID="Label6" runat="server" Text="<%# HttpUtility.HtmlEncode(Container.DataItem.Nombre)%>"></asp:Label>
                    </a>
                    &nbsp;        
            </div>
        </ItemTemplate>
    </asp:Repeater>
    </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div class="clearfix" style="margin-bottom: 6px;">
    <h1 class="pull-left">Blog de <asp:Label runat="server" ID="lblNombreUsuario" Text=""></asp:Label></h1>
    <div class="pull-right">
        <asp:Button ID="Button1" runat="server" Text="Deshabilitar" visible="false"/><asp:Label
        ID="Label3" runat="server" Text="" Visible = "false"></asp:Label>
        <asp:Button ID="Button2" runat="server" CssClass="agregar-entrada" Text="Agregar Entrada" visible="false" />
    </div>
</div>
<hr class="clear" />
<div id="form-agregar-entrada" class="clear clearfix">
    <label class="form-row">
        <asp:Label ID="Label2" runat="server" Text="Titulo"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="380px" cssClass="required"></asp:TextBox>
    </label>
    <label class="form-row">
        <asp:Label ID="Label1" runat="server" Text="Contenido"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="380px" TextMode="MultiLine" cssClass="required"></asp:TextBox>
    </label>
    <label class="form-row">
        <asp:Button ID="Button3" runat="server" Text="Agregar" />
    </label>
</div>
<div class="blog clear">
<asp:Repeater ID="listaEntradas" runat="server">
        <ItemTemplate>
           
            <a class="entrada-blog" href="Entrada.aspx?ID=<%# Container.DataItem.IdEntrada%>">
                <h1 class="pull-left">Título: <%# HttpUtility.HtmlEncode(Container.DataItem.Titulo)%> </h1>
                <div class="date pull-right">Agregado: <%# Container.DataItem.Fecha%></div>
                <div class="summary clearfix">
                    <p class="clear">
                       <%# HttpUtility.HtmlEncode(Container.DataItem.Contenido)%>
                    </p>
                    <div class="pull-right">Calificaci&oacute;n: <%# Container.DataItem.Calificacion%></div>
                   <!-- <div class="temas">
                        <span>Tema 1</span> <span>Tema 2</span> <span>Tema 3</span>
                    </div>-->
                </div>
             </a>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaEntradas.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontr&oacute; ninguna entrada.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>
            
        
</div>
</asp:Content>
