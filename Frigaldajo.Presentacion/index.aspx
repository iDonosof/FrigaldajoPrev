<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Frigaldajo.Presentacion.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbTitulo" runat="server" Text="Eventos"></asp:Label>
    <asp:GridView ID="gvEventList" runat="server"></asp:GridView>
</asp:Content>