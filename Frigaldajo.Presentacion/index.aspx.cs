using System;
using Frigaldajo.Negocios;

namespace Frigaldajo.Presentacion
{
    public partial class index : System.Web.UI.Page
    {
        Repositorio repo = new Repositorio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["repo"] != null)
            {
                repo = (Repositorio)Session["repo"];
            }
            gvEventList.DataSource = repo.GetListaEventos();
            gvEventList.DataBind();
        }
    }
}