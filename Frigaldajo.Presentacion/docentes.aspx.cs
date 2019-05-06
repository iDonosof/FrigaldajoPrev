using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frigaldajo.Negocios;

namespace Frigaldajo.Presentacion
{
    public partial class docentes : System.Web.UI.Page
    {
        Repositorio repo = new Repositorio();
        protected void Page_Load(object sender, EventArgs e)
        {

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
                //Agregado
            }
            else
            {
                //No lo agrego
            }
        }
    }
}