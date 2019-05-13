<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeBehind="docentes.aspx.cs" Inherits="Frigaldajo.Presentacion.docentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="cajaIngreso">
        <h1 class="text-center orange-title">Docentes</h1>
        <br />
        <table>
            <tr>
                <td>
                    <p class="orange-title">Nombre:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtNombre_Docente" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p class="orange-title">Rut:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtRut_Docente" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p class="orange-title">Telefono:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtTelefono_Docente" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <p class="orange-title">Correo:</p>
                </td>
                <td>
                    <asp:TextBox class="textboxDocente" ID="txtCorreo_Docente" runat="server"></asp:TextBox>
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
