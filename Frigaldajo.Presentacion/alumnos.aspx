<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeBehind="alumnos.aspx.cs" Inherits="Frigaldajo.Presentacion.alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="text-center orange-title">Alumnos</h1>
        <table>
            <tr>
                <td> <!-- Columna Izquierda -->
                    <img src="IMG/codigoBarras.png" width="200" /><br />
                    <asp:TextBox class="textbox" ID="txtRut" runat="server" ></asp:TextBox><asp:Button class="botonBuscar" ID="btnBuscar" runat="server" />
                </td>
                <td> <!-- Columna Derecha-->
                    <asp:CheckBox class="noValido" ID="CheckBox1" runat="server" Width="300" Height="200"/>
                    <asp:CheckBox class="valido" ID="CheckBox2" runat="server" Width="300" Height="200"/>

                </td>
            </tr>
        </table>
    </div>
</asp:Content>
