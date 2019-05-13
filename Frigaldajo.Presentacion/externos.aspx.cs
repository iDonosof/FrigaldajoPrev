using System;
using Frigaldajo.Negocios;

namespace Frigaldajo.Presentacion
{
    public partial class externos : System.Web.UI.Page
    {
        Repositorio repo = new Repositorio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Externos_Click(object sender, EventArgs e)
        {
            //Agregar el txt para la edad
            Externo externo = new Externo()
            {
                Nombre = txtNombre_Externos.Text,
                Correo = txtCorreo_Externos.Text,
                Edad = 40,
                IdEvento = 1,
                Rut = txtRut_Externos.Text,
                Telefono = int.Parse(txtTelefono_Externos.Text)
            };
            if (repo.InsertExterno(externo))
            {
                //Se agrego correctamente 
                repo.InsertExterno(externo);
                lbMensaje.Text = "Agregado correctamente";
            }
            else
            {
                //no se agrego correctamente
                lbMensaje.Text = "Ocurrio un error";
            }
        }
    }
}