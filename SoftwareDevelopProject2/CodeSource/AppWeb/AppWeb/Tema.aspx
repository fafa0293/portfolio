<%@ Page Title="" validateRequest="false" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="Tema.aspx.vb" Inherits="AppWeb.Tema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
    <h2><asp:Label ID="lblOpciones" runat="server" Text="" Visible="false"></asp:Label></h2>
    <p class="small">
        Se listan los aportes hechos a este tema. 
    </p><p class="small">
        Para ver los comentarios hechos a un aporte, haga click en el bot&oacute;n de "Ver comentarios".
        Usted tambi&eacute;n puede agregar su propios comentarios.
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<asp:HiddenField ID="hIdUsuarioLog" runat="server" ClientIDMode="Static" />
<asp:HiddenField ID="hIdAporteComentado" runat="server" ClientIDMode="Static" />
<h1 class="pull-left clearfix"><a href="ListarForo.aspx">Foros</a> &raquo; <asp:HyperLink runat="server" ID="lNombreForo" Text="NombreForo"></asp:HyperLink> &raquo; <asp:Label runat="server" ID="lblNombreTema" Text="Opciones"></asp:Label></h1>
<div class="pull-right clearfix" style="margin-bottom: 6px">
 <asp:Button CssClass="clear" Visible="false" ID="btnEstudiantes" runat="server" Text="Estudiantes" />
        <asp:Button CssClass="clear" Visible="false" ID="btnCerrar" runat="server" Text="Cerrar" />
        <asp:Button CssClass="clear" Visible="false" ID="btnModificar" runat="server" style="margin-top: 4px !important;" Text="Modificar" />
</div>
 <hr class="clear"/>
<div class="lista-aportes">
    <asp:Repeater ID="listaAportes" runat="server">
        <ItemTemplate>
            <div class="aporte clearfix">
                <div class="info-aporte">
                    <div class="clear">
                        <div class="autor-aporte pull-left">
                            <h3><a href="Blog.aspx?ID=<%# Container.DataItem.IdUsuario %>"><%# Container.DataItem.NomUsuario%></a></h3>
                        </div>
                        <div class="info-aporte pull-right">
                            <span class="date"><%# Container.DataItem.Fecha %> </span>
                        </div>
                    </div>
                </div>
                <div class="contenido-aporte clear">
                    <%# HttpUtility.HtmlEncode(Container.DataItem.Contenido).Replace(Environment.NewLine, "<br />")%>
                </div>
     
                <div class="pull-left">
                    <asp:Label ToolTip="<%# Container.DataItem.Calificacion%>" runat="server" Visible="true" ID="lblCalificacion"><strong>Calificaci&oacute;n:</strong> <%# Container.DataItem.Calificacion%></asp:Label>
                    <asp:DropDownList CssClass="pull-left" style="width: 50px; min-width: 0;" ID="ddlCalificar"  Visible="false" runat="server" AutoPostBack="False">
                    </asp:DropDownList>
                    <asp:Button ToolTip="<%# Container.DataItem.IdUsuario%>" style="margin-left: 6px !important;" ID="btnCalificar" Visible="false" CssClass="pull-left" runat="server" Text="Calificar" CommandName="Calificar" CommandArgument="<%# Container.DataItem.IdAporte%>" />
                </div>
                <div class="pull-right">
                    <a class="link-button clear" href="DenunciarAporte.aspx?IdAporte=<%# Container.DataItem.IdAporte %>">Denunciar</a>
                    <a href="#" style="margin-top: 6px;" data-id-usuario="<%# Container.DataItem.IdUsuario %>" data-id-tema="<%# Container.DataItem.IdTema %>" data-id="<%# Container.DataItem.IdAporte %>" class="agregar-comentario-aporte link-button clear">Ver comentarios</a>
                </div>
                    
                <div class="form-agregar-comentario-aporte clear clearfix" >
                    <div class="lista-comentarios clear clearfix" style="margin-top: 6px;"></div>
                    <label class="form-row" style="margin-top: 6px;">
                        <asp:Label ID="Label1" runat="server" Text="Agregar Comentario"></asp:Label>
                        <asp:TextBox ID="txtComentario" Width="50%" runat="server"></asp:TextBox>
                        <asp:Button  CommandName="Comentar" CommandArgument="<%# Container.DataItem.IdAporte%>" ID="btnComentar" runat="server" Text="Comentar" />
                    </label>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>  
        <% If listaAportes.Items.Count = 0 Then%>
            <div class="alert">
                <h1>¡Atenci&oacute;n!</h1>
                <p>No se encontraron aportes en este tema.</p>
            </div>
        <% End If%>  
    </FooterTemplate>  
    </asp:Repeater>

    <hr />
    <asp:Panel runat="server" ID="pnlAgregarAporte">
    <div class="form-agregar-aporte clear clearfix">
        <h2><asp:Label ID="Label1" runat="server" Text="Agregar Aporte"></asp:Label></h2>
        <asp:TextBox ID="txtAporte" runat="server" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox><br />
        <asp:Button ID="btnAporte"  OnClientClick='return validarNuevoAporte();' runat="server" Text="Agregar" />
    </div>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlCerrado" Visible="false">
        <div class="alert">
            <h1>Alerta</h1>
            <p>Este tema est&aacute; cerrado.</p>
        </div>
    </asp:Panel>
</div>
</asp:Content>
