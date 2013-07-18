<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeBehind="DenunciarAporte.aspx.vb" Inherits="AppWeb.denunciarAporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SidebarContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<h1>Denunciar Aporte</h1>
    <div class="spaced clear">
        <label class="form-row">
	        <asp:Label ID="Label1" runat="server" Text="De:"></asp:Label>
	        <asp:TextBox ID="txtDe" runat="server"></asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label2" runat="server" Text="Para:"></asp:Label>
	        <asp:TextBox ID="txtPara" runat="server"></asp:TextBox>
        </label>
        <label class="form-row">
	        <asp:Label ID="Label11" runat="server" Text="Motivo:"></asp:Label>
	        <textarea cols="3" rows="4" ID="txtMotivo" class="required" runat="server"></textarea>
        </label>
        <label class="form-row">
            <asp:Button ID="btnDenunciar" runat="server" Text="Denunciar" />
        </label>
    </div>
</asp:Content>
