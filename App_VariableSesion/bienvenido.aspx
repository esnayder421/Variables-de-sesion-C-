<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="bienvenido.aspx.cs" Inherits="App_VariableSesion.bienvenido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        BIENVENIDO
        <asp:Label ID="Lblusuario" runat="server"></asp:Label>
    </p>
</asp:Content>
