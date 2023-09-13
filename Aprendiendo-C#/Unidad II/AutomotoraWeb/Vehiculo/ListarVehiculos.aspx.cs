using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomotoraWeb
{
    public partial class ListarVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string message = Request.Params["message"];
            if (message != null)
                lblMessage.Text += message + "\n";

            string filter = Request.Params["filter"];
            if (filter != null)
                CargarGrillaBusquedaAvanzada(filter);
            else
                CargarGrillaListarTodos();

        }

        private void CargarGrillaListarTodos()
        {
            gdvListadoVehiculos.DataSource = null;
            var res = VehiculoController.ReadAll();
            if (res.Count == 0)
                lblMessage.Text += "No existen más registros para mostrar";
            else
            {
                lblMessage.Text = $"Se han encontrado {res.Count} registros";
                gdvListadoVehiculos.DataSource = res;
                gdvListadoVehiculos.DataBind();
            }
        }

        private void CargarGrillaBusquedaAvanzada(string filtro)
        {
            gdvListadoVehiculos.DataSource = null;
            var res = VehiculoController.Search(filtro);
            if (res.Count == 0)
                lblMessage.Text += $"No existen registro con el filtro: {filtro}";
            else
            {
                lblMessage.Text = $"Se han encontrado {res.Count} coincidencias con el filtro {filtro}";
                gdvListadoVehiculos.DataSource = res;
                gdvListadoVehiculos.DataBind();
            }
        }

        protected void gdvListadoVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row = gdvListadoVehiculos.SelectedIndex;
            string vin = gdvListadoVehiculos.DataKeys[row].Values[0].ToString();
            string url = string.Format("~/Vehiculo/DetalleVehiculo.aspx?vin={0}", vin);
            Response.Redirect(url);
        }
    }
}