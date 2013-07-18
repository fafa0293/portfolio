<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="ReporteCantidadEntradasDeUnBlog.aspx.vb" Inherits="AppWeb.ReporteCantidadEntradasDeUnBlog" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spaced clear">
        <label class="form-row-sidebar">
            <asp:Label ID="Label2" runat="server" Text="Nombre Usuario"></asp:Label>
            <asp:DropDownList ID="cmbUsuario" runat="server" DataTextField="NombreCompleto" 
                    DataValueField="idUsuario">
            </asp:DropDownList>
            </label>
        <label class="form-row">
	        <asp:Label ID="Label7" runat="server" Text="Fecha Inicio"></asp:Label>
	        <asp:TextBox ID="txtFechaInicio" class="required date" runat="server">
	        </asp:TextBox>
        </label>
            <label class="form-row">
	        <asp:Label ID="Label1" runat="server" Text="Fecha Fin"></asp:Label>
	        <asp:TextBox ID="txtFechaFin" class="required date" runat="server">
	        </asp:TextBox>
        </label>
    </div>
    <br /><br /><br />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" InteractiveDeviceInfos="(Colección)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
        <localreport reportpath="Reportes\ReporteCantidadEntradasDeUnBlog.rdlc">
            <datasources>
                <rsweb:ReportDataSource DataSourceId="ReporteCantidadEntradasDeUnBlogDataSource" 
                    Name="ReporteCantidadEntradasDeUnBlogDataSet" />
            </datasources>
        </localreport>
    </rsweb:ReportViewer>
    <asp:SqlDataSource ID="ReporteCantidadEntradasDeUnBlogDataSource" 
        runat="server" ConnectionString="<%$ ConnectionStrings:conexionStr %>" 
        SelectCommand="sp_reporteCantidadEntradasDeUnBlog" 
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbUsuario" Name="idUsuario" 
                PropertyName="SelectedValue" Type="Int32" />
            <asp:ControlParameter ControlID="txtFechaInicio" Name="fechaInicio" 
                PropertyName="Text" Type="DateTime" />
            <asp:ControlParameter ControlID="txtFechaFin" Name="fechaFin" 
                PropertyName="Text" Type="DateTime" />
        </SelectParameters>
    </asp:SqlDataSource>
    
</asp:Content>
