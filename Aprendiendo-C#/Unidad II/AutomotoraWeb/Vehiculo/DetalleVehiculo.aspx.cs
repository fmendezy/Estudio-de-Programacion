using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomotoraWeb.Vehiculo
{
    public partial class DetalleVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string vin = Request.Params["vin"];
            if (vin != null)
                CargarRegistro(vin);
            else
                lblMessage.Text = $"Debe proporcionar el VIN del vehículo";
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string vin = lblVIN_Value.Text;
            string url = string.Format("~/Vehiculo/ActualizarVehiculo.aspx?vin={0}", vin);
            Response.Redirect(url);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string vin = lblVIN_Value.Text;
            string message = VehiculoController.Delete(vin);
            string url = string.Format("~/Vehiculo/ListarVehiculos.aspx?message={0}", message);
            Response.Redirect(url);
        }

        private void CargarRegistro(string vin)
        {
            var vehiculo = VehiculoController.Read(vin);
            if (vehiculo != null)
            {
                lblMessage.Text = "Registro encontrado:";
                lblIdValue.Text = vehiculo.Id.ToString();
                lblMarcaValue.Text = vehiculo.Marca;
                lblModeloValue.Text = vehiculo.Modelo;
                lblAnioValue.Text = vehiculo.Anio.ToString();
                lblVIN_Value.Text = vehiculo.VIN;
                lblTipoMotorValue.Text = (vehiculo.EsElectrico) ? "Eléctrico" : "Gasolina";
            }
            else
            {
                lblMessage.Text = $"Vehículo con VIN {vin} no encontrado";
            }
        }
    }
}