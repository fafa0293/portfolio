<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="ReporteNotasPorAporteTema.aspx.vb" Inherits="AppWeb.ReporteNotasPorAporteTema1" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<asp:DropDownList ID="ddUsuarios" runat="server" AppendDataBoundItems="True" 
        AutoPostBack="True">
        <asp:ListItem Value="-1">Seleccionar</asp:ListItem>
    </asp:DropDownList>
 <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="398px" InteractiveDeviceInfos="(Collection)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="705px">
        <LocalReport ReportPath="Reportes\ReporteNotasPorAporteTema.rdlc">
         <DataSources>
                <rsweb:ReportDataSource DataSourceId="SqlDataSource1" 
                    Name="ReporteNotasPorAporteTemaDataSet" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:conexionStr %>" 
        SelectCommand="sp_reporteNotasPorAporteTema" 
        SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddUsuarios" Name="idUsuario" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
