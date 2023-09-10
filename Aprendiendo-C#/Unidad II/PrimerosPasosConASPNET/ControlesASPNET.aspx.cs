using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerosPasosConASPNET
{
    public partial class ControlesASPNET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            lblMensajeRecibido.Text = txtMensaje.Text;
        }
    }
}