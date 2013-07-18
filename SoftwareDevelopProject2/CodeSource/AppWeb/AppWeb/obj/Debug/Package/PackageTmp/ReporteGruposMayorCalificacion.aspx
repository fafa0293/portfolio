<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ReporteGruposMayorCalificacion.aspx.vb" Inherits="AppWeb.ReporteGruposMayorCalificacion" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" InteractiveDeviceInfos="(Colección)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
        <localreport reportpath="Reportes\ReporteGruposMayorCalificacion.rdlc">
            <datasources>
                <rsweb:ReportDataSource DataSourceId="ReporteGruposMayorCalificacionSqlDataSource" 
                    Name="ReporteGruposMayorCalificacionDataSet" />
            </datasources>
        </localreport>
    </rsweb:ReportViewer>
    <asp:SqlDataSource ID="ReporteGruposMayorCalificacionSqlDataSource" 
        runat="server" ConnectionString="<%$ ConnectionStrings:conexionStr %>" 
        SelectCommand="sp_reporteGruposMayoresCalificaciones" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    
</asp:Content>
