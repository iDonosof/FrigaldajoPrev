using System;
using Frigaldajo.Negocios;
using System.Web.SessionState;

namespace Frigaldajo.Presentacion
{
    public partial class docentes : System.Web.UI.Page
    {
        Repositorio repo = new Repositorio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["repo"] != null)
            {
                repo = (Repositorio)Session["repo"];
            }
        }

        protected void btnAgregar_Externos_Click(object sender, EventArgs e)
        {
            //Agregar el txt de la edad del docente
            Docente docente = new Docente()
            {
                IdEvento = 1,
                Edad = 30,
                Nombre = txtNombre_Docente.Text,
                Rut = txtRut_Docente.Text,
                Telefono = int.Parse(txtTelefono_Docente.Text)
            };

            if (repo.InsertDocente(docente))
            {
                lbMensaje.Text = "Agregado correctamente";
            }
            else
            {
                lbMensaje.Text = "Ocurrio un error";
            }
            SaveChanges();
        }

        private void SaveChanges()
        {
            Session["repo"] = repo;
        }
    }
}