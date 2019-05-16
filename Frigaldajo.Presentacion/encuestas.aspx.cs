using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frigaldajo.Presentacion
{
    public partial class encuestas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Externos_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            rdbEvento1.Checked = false;
            rdbEvento2.Checked = false;
            rdbEvento3.Checked = false;
            rdbOrganizacion1.Checked = false;
            rdbOrganizacion2.Checked = false;
            rdbOrganizacion3.Checked = false;
            rdbTiempo1.Checked = false;
            rdbTiempo2.Checked = false;
            rdbTiempo3.Checked = false;
            TextBox1.Text = string.Empty;
            lbMessage.Text = "Gracias por contestar la encuesta 😄";
        }
    }
}