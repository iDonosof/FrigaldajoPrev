using System;
using Frigaldajo.Negocios;


namespace Frigaldajo.Presentacion
{
    public partial class alumnos : System.Web.UI.Page
    {
        public Repositorio repo = new Repositorio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["repo"] != null)
            {
                repo = (Repositorio)Session["repo"];
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text.Trim().ToLower();
            Imagen.ImageUrl = repo.InsertAlumno(rut) ? "IMG/valido_true.png" : "IMG/noValido_true.png";
            txtRut.Text = string.Empty;
            Session["repo"] = repo;
        }

        private void SaveChanges()
        {
            Session["repo"] = repo;
        }
    }
}