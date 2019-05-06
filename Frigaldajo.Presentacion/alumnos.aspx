<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeBehind="alumnos.aspx.cs" Inherits="Frigaldajo.Presentacion.alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="text-center orange-title">Alumnos</h1>
        <table>
            <tr>
                <td> <!-- Columna Izquierda -->
                    <img src="IMG/codigoBarras.png" width="200" /><br />
                    <asp:TextBox class="textbox" ID="txtRut" runat="server" autofocus="true"></asp:TextBox>
                    <asp:Button class="botonBuscar" ID="btnBuscar" runat="server" OnClick="btnBuscar_Click"/>
                </td>
                <td> <!-- Columna Derecha-->
                    <%--<asp:CheckBox class="noValido" ID="cbNoValido" runat="server" Width="300" Height="200"/>
                    <asp:CheckBox class="valido" ID="cbValido" runat="server" Width="300" Height="200"/>--%>
                    <asp:Image ID="Imagen" runat="server" ImageUrl="IMG/valido_false.png"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
