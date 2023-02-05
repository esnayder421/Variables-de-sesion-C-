<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="App_VariableSesion.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        text-align: center;
    }
    .auto-style3 {
        width: 462px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">USUARIO</td>
        <td>
            <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">CONTRASEÑA</td>
        <td>
            <asp:TextBox ID="TxtContrasena" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="2">
            <asp:Button ID="BtnAceptar" runat="server" OnClick="BtnAceptar_Click" Text="ACEPTAR" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Lblmensaje" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
