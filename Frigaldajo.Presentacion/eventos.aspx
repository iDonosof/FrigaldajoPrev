<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="eventos.aspx.cs" Inherits="Frigaldajo.Presentacion.eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lbNombreEvento" AssociatedControlID="txtNombreEvento" runat="server" Text="Nombre del evento:"></asp:Label>
    <asp:TextBox ID="txtNombreEvento" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbEncargado" AssociatedControlID="txtEncargado" runat="server" Text="Nombre encargado"></asp:Label>
    <asp:TextBox ID="txtEncargado" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbEscuelaArea" AssociatedControlID="txtEscuelaArea" runat="server" Text="Nombre de la escuela encargada"></asp:Label>
    <asp:TextBox ID="txtEscuelaArea" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbFechaInicio" AssociatedControlID="txtFechaInicio" runat="server" Text="Fecha de inicio"></asp:Label>
    <asp:TextBox ID="txtFechaInicio" TextMode="Date" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbFechaTermino" AssociatedControlID="txtFechaTermino" runat="server" Text="Fecha termino"></asp:Label>
    <asp:TextBox ID="txtFechaTermino" TextMode="Date" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbHoraInicio" AssociatedControlID="txtHoraInicio" runat="server" Text="Hora inicio"></asp:Label>
    <asp:TextBox ID="txtHoraInicio" TextMode="Time" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbHoraTermino" AssociatedControlID="lbHoraTermino" runat="server" Text="Hora termino"></asp:Label>
    <asp:TextBox ID="txtHoraTermino" TextMode="Time" runat="server"></asp:TextBox>
    <br />
    
    <asp:Button ID="btnIngresar" runat="server" Text="Agregar evento" OnClick="btnIngresar_Click" />
    <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>

</asp:Content>
