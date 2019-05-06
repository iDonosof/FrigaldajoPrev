using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Frigaldajo.Negocios;


namespace Frigaldajo.Presentacion
{
    public partial class alumnos : System.Web.UI.Page
    {
        public Repositorio repo = new Repositorio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text.Trim().ToLower();
            if(repo.InsertAlumno(rut))
            {
                Imagen.ImageUrl = "IMG/valido_true.png";
                var list = repo.GetAlumnos();
            }
            else
            {
                Imagen.ImageUrl = "IMG/noValido_true.png";
            }
            txtRut.Text = string.Empty;
        }
    }
}