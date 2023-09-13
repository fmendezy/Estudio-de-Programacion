using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomotoraWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filter = txtFiltro.Text.ToUpper();

            string url = string.Format("~/Vehiculo/ListarVehiculos.aspx?filter={0}", filter);

            Response.Redirect(url);
        }
    }
}