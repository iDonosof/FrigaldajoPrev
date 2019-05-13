using System;
using Frigaldajo.Negocios;

namespace Frigaldajo.Presentacion
{
    public partial class eventos : System.Web.UI.Page
    {
        Repositorio repo = new Repositorio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["repo"] != null)
            {
                repo = (Repositorio)Session["repo"];
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento()
            {
                Encargado = txtEncargado.Text,
                EscuelaArea = txtEscuelaArea.Text,
                FechaInicio = DateTime.Parse(txtFechaInicio.Text),
                FechaTermino = DateTime.Parse(txtFechaTermino.Text),
                HoraInicio = DateTime.Parse(txtHoraInicio.Text),
                HoraTermino = DateTime.Parse(txtHoraTermino.Text),
                NombreEvento = txtNombreEvento.Text,
            };
            lbMensaje.Text = repo.InsertEvento(evento) ? "Agregado correctamente" : "Ocurrio un error";
            SaveChanges();
            clearFields();
        }

        private void clearFields()
        {
            txtNombreEvento.Text = string.Empty;
            txtEncargado.Text = string.Empty;
            txtEscuelaArea.Text = string.Empty;
            txtFechaInicio.Text = string.Empty;
            txtFechaTermino.Text = string.Empty;
            txtHoraInicio.Text = string.Empty;
            txtHoraTermino.Text = string.Empty;
        }

        private void SaveChanges()
        {
            Session["repo"] = repo;
        }
    }
}