<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Reportes.aspx.vb" Inherits="AppWeb.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="span6">
            <h2 class="clear">Reportes Gr&aacute;ficos</h2>
            <ul class="navbar-horizontal pull-left">
                <li><a href="ReporteCantAportesEstudianteForoGrafico.aspx">Cantidad de Aportes por Estudiante a un Foro</a></li>
                <li><a href="ReporteCantidadAportesPorDiaTemaGrafico.aspx">Cantidad de Aportes por D&iacute;a a Temas</a></li>
                <li><a href="ReporteGrupoMayorCalificacionGrafico.aspx">Grupo con Mayor Calificación</a></li>
            </ul>
        </div>
        <div class="span6">
            <h2 class="clear">Reportes en Lista</h2>
            <ul class="navbar-horizontal pull-left">
                <li><a href="ReporteArticulosDeBlogLista.aspx">Art&iacute;culos de Blog</a></li>
                <li><a href="ReporteBlogsConMejoresNotas.aspx">Blogs con Mejores Calificaciones</a></li>
                <li><a href="ReporteBlogsMasComentadosNotas.aspx">Blogs M&aacute;s Comentados con Notas</a></li>
                <li><a href="ReporteCantAportesEstudianteForo.aspx">Cantidad de Aportes por Estudiante a un Foro</a></li>
                <li><a href="ReporteCantidadAportesPorDiaTema.aspx">Cantidad de Aportes por D&iacute;a a Temas</a></li>
                <li><a href="ReporteEnListaGruposForoCalificacion.aspx">Foros con Mayor Calificaci&oacute;n</a></li>
                <li><a href="ReporteEntradasPorBlog.aspx">Entradas por Blog</a></li>
                <li><a href="ReporteGruposMayorCalificacion.aspx">Grupos con Mayor Calificaci&oacute;n</a></li>
                <li><a href="ReporteListaBlogsMasComentados.aspx">Blogs M&aacute;s Comentados</a></li>
                <li><a href="ReporteListaBlogsXFechaUltimaEntrada.aspx">Blogs Actualizados Recientemente</a></li>
                <li><a href="ReporteListaForoConCeroTemas.aspx">Foros con Cero Temas</a></li>
                <li><a href="ReporteNotasPorAporteTema.aspx">Calificaciones de Aportes a Temas</a></li>
            </ul>
        </div>
    </div>
</asp:Content>
