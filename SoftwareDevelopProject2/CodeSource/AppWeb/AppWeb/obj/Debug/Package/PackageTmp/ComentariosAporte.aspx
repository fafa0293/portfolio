<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ComentariosAporte.aspx.vb" Inherits="AppWeb.ComentariosAporte" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server" id="form2">
    <div id="lista-comentarios" class="lista-comentarios-min">
    <asp:Repeater ID="listaComentariosAporte" runat="server">
        <ItemTemplate>
            <div class="comentario">
                <div class="contenido-comentario clear clearfix">
                    <p class="pull-left">
                        <a class="pull-left" href="Blog.aspx?ID=<%# Container.DataItem.IdUsuario%>"><%# Container.DataItem.NombreUsuario%></a>: <%# HttpUtility.HtmlEncode(Container.DataItem.Contenido).Replace(Environment.NewLine, "<br />")%>
                    </p>
                     <div style="text-align: right;" class="date pull-right"><%# Container.DataItem.Fecha%><br />
                     <a data-id-usuario="<%# Container.DataItem.IdUsuario %>" class="eliminar-comentario-aporte" onclick='return confirm("¿Está seguro de que desea eliminar el comentario?")' href="Tema.aspx?ID=<% Response.Write(Request.QueryString("IDTema")) %>&EliminarComentario=<%# Container.DataItem.IdComentario %>">Eliminar</a></div>
                </div>
            </div> 
        </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
