<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ReporteEnListaGruposForoCalificacion.aspx.vb" Inherits="AppWeb.ReporteEnListaGruposForoCalificacion" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
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
        <LocalReport ReportPath="Reportes\ReporteListaGruposMayorCalificacionForo.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ListaGrupoMayorCalificacion" 
                    Name="DataSet1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:SqlDataSource ID="ListaGrupoMayorCalificacion" runat="server" 
        ConnectionString="<%$ ConnectionStrings:conexionStr %>" 
        SelectCommand="sp_reporteGruposMayorCalificacionParticipacion" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
</asp:Content>
