<%@ Page Title="" validateRequest="false"  Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" EnableEventValidation="true" CodeBehind="Entrada.aspx.vb" Inherits="AppWeb.Entrada1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
<asp:HiddenField ClientIDMode="Static" ID="idUsuarioLog" runat="server" />
<asp:HiddenField ClientIDMode="Static" ID="idUsuarioBlog" runat="server" />
<div class="text small">
    <h2><asp:Label runat="server" ID="lblNombreUsuario2" Text=""></asp:Label></h2>
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
    <div class="clear text temas">
        <!-- Listar aquí todos los temas del blog de este usuario --->
        <!-- Cuando hace click en un tema, lo envía a una lista de las entradas con ese tema -->
        <!-- Por ejemplo Blog.aspx?IDUsuario=1&Tema=programacion -->
        <!-- <span>Tema 1</span> <span>Tema 2</span> <span>Tema 3</span> -->
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
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Runat="Server">
<h1>
    <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
</h1>
<hr />
<div class="entrada">
    <div>
        <h2 class="pull-left"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></h2>
        <div class="date pull-right"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></div>
    </div>
    <div class="clear">
        <asp:Label ID="Label6" class="temas pull-left" runat="server" Text="Temas: "></asp:Label>
        <asp:Repeater ID="listaTemas" runat="server"> 
            <ItemTemplate>
                <div class="temas pull-left">
                    <a class="blog" href="Blog.aspx?TEMA=<%# Container.DataItem.Id%>">
                        <asp:Label ID="Label6" runat="server" Text="<%# HttpUtility.HtmlEncode(Container.DataItem.Nombre)%>"></asp:Label>
                    </a>
                    &nbsp;        
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="pull-right">
            <asp:Button ID="Button2" runat="server" Text="Modificar" visible="false"/>
            <asp:Button ID="Button3" runat="server" Text="Denunciar" visible="true"/>
        </div>
    </div>

    <div class="clear contenido-entrada">
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            
        </p>
    </div>
     <div class="pull-left" style="margin-top: 6px;">
        <strong>Calificaci&oacute;n:</strong>
        <asp:Label runat="server" Visible="true" ID="lblCalificacion"></asp:Label>
        <asp:DropDownList style="width: 50px; min-width: 0;" ID="ddlCalificar"  Visible="false" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Button  style="margin-left: 4px;" ID="btnCalificar" Visible="false" runat="server" Text="Calificar" />
    </div>
    <div class="clear clearfix" style="margin-top: 6px;">
        <h1 class="pull-left ">Comentarios</h1>
        <a href="#" id="agregar-comentario" class="link-button pull-right">Agregar comentario</a>
    </div>
    <div id="form-agregar-comentario" style="margin-top: 6px;" class="clear clearfix">
        <label class="form-row">
            <asp:Label ID="Label1" runat="server" Text="Comentario"></asp:Label>
            <asp:TextBox ID="txtComentario" runat="server" Width="380px" TextMode="MultiLine"></asp:TextBox>
        </label>
        <label class="form-row">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar comentario" />
        </label>
    </div>
    <hr />
    <div class="comentarios-entrada">
        <asp:Repeater ID="listaComentEntradas" runat="server">
            <ItemTemplate>
            <div class="comentario">
                <div class="autor-comentario clearfix">
                    <a class="pull-left" href="Blog.aspx?ID=<%# Container.DataItem.IdUsuario%>"><%# Container.DataItem.NombreUsuario%></a>
                    <div class="date pull-right">Agregado: <%# Container.DataItem.Fecha%></div>
                </div>
                <div class="contenido-comentario clear clearfix">
                    <p class="pull-left">
                        <%# HttpUtility.HtmlEncode(Container.DataItem.Contenido).Replace(Environment.NewLine, "<br />")%>
                    </p>
                    <div class="pull-right" style="margin-top: 6px;">
                        <asp:Button ID="btnEliminar" data-id-usuario="<%# Container.DataItem.IdUsuario %>" CssClass="btn-eliminar" CommandName="Eliminar" CommandArgument='<%# Container.DataItem.IdComentario %>' Text="Eliminar" runat="server" OnClientClick='return confirm("¿Está seguro de que desea eliminar este comentario?")' />
                    </div>
                </div>
            </div> 
            </ItemTemplate>
            <FooterTemplate>  
            <% If listaComentEntradas.Items.Count = 0 Then%>
                <div class="success">
                    <p>No hay comentarios.</p>
                </div>
            <% End If%>  
        </FooterTemplate>  
        </asp:Repeater>
    </div>
</div>
</asp:Content>
