<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="encuestas.aspx.cs" Inherits="Frigaldajo.Presentacion.encuestas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="cajaEncuesta">
        <h1 class="text-center orange-title">Encuentas</h1>
        <br />
        <div id="centrarCaja">
            <table>
            <tr> <!--Primera Fila-->
                <td>
                    
                </td>
                <td class="margin-text">
                    <img src="IMG/triste.png" />
                </td>
                <td class="margin-text">
                    <img src="IMG/neutral.png" />
                </td>
                <td class="margin-text">
                    <img src="IMG/sonriente.png" />
                </td>
            </tr>
            <tr>
                <td class="margin-text">
                    <p class="orange-title text-right">¿Te Gusto el Evento?</p>
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbEvento1" GroupName="evento" runat="server" />
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbEvento2" GroupName="evento" runat="server" />
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbEvento3" GroupName="evento" runat="server" />
                </td>
            </tr>
            <tr> <!--Segunda Fila-->
                <td>
                    
                </td>
                <td class="margin-text">
                    <img src="IMG/triste.png" />
                </td>
                <td class="margin-text">
                    <img src="IMG/neutral.png" />
                </td>
                <td class="margin-text">
                    <img src="IMG/sonriente.png" />
                </td>
            </tr>
            <tr>
                <td class="margin-text">
                    <p class="orange-title text-right">¿Como estuvo la organización?</p>
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbOrganizacion1" GroupName="organizacion" runat="server" />
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbOrganizacion2" GroupName="organizacion" runat="server" />
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbOrganizacion3" GroupName="organizacion" runat="server" />
                </td>
            </tr>
            <tr> <!--Tercera Fila-->
                <td>
                    
                </td>
                <td class="margin-text">
                    <img src="IMG/triste.png" />
                </td>
                <td class="margin-text">
                    <img src="IMG/neutral.png" />
                </td>
                <td class="margin-text">
                    <img src="IMG/sonriente.png" />
                </td>
            </tr>
            <tr>
                <td class="margin-text">
                    <p class="orange-title text-right">¿Que te parecio el tiempo de espera?</p>
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbTiempo1" GroupName="tiempo" runat="server" />
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbTiempo2" GroupName="tiempo" runat="server" />
                </td>
                <td class="margin-text">
                    <asp:RadioButton class="radio" ID="rdbTiempo3" GroupName="tiempo" runat="server" />
                </td>
            </tr>
        </table>
        <br />
        <table> <!--Seccion final-->
            <tr>
                <td>
                    <p class="orange-title">¿Alguna sugerencia, queja o comentario que quieras hacer?</p>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox class="textboxEncuesta" ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button class="botonEnviar" ID="btnAgregar_Externos" runat="server" Text="Enviar" OnClick="btnAgregar_Externos_Click" />
                </td>
            </tr>
            <tr>
                <asp:Label ID="lbMessage" runat="server" Text=""></asp:Label>
            </tr>
        </table>
        </div>
    </div>
</asp:Content>
