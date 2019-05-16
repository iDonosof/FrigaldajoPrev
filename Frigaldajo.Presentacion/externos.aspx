<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeBehind="externos.aspx.cs" Inherits="Frigaldajo.Presentacion.externos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="cajaIngreso">
        <h1 class="text-center orange-title">Externos</h1>
        <br />
        <table>
            <tr>
                <td>
                    <p class="orange-title">Nombre:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtNombre_Externos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p class="orange-title">Rut:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtRut_Externos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p class="orange-title">Telefono:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtTelefono_Externos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p class="orange-title">Correo:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtCorreo_Externos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p class="orange-title">Edad:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtEdad_Externos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button class="botonAgregar" ID="btnAgregar_Externos" runat="server" Text="Agregar" OnClick="btnAgregar_Externos_Click" />
                </td>
            </tr>
        </table>
        <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
