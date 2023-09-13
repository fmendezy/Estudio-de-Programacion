using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomotoraWeb.Vehiculo
{
    public partial class ActualizarVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string vin = Request.Params["vin"];
                if (vin != null)
                    CargarRegistro(vin);
                else
                    lblMessage.Text = "Se debe proporcionar el VIN del vehículo";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string vin = lblVIN_Value.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string message = VehiculoController.Update(vin, marca, modelo);
            Response.Redirect($"~/Vehiculo/ListarVehiculos.aspx?message={message}");
        }

        /*Método que permite cargar el registro en pantalla en base al vin proporcionado*/
        private void CargarRegistro(string vin)
        {
            var res = VehiculoController.Read(vin);
            if (res == null)
                lblMessage.Text = $"El vehículo con VIN {vin} no ha podido ser encontrado";
            else
            {
                lblIdValue.Text = res.Id;
                txtMarca.Text = res.Marca;
                txtModelo.Text = res.Modelo;
                lblAnioValue.Text = res.Anio.ToString();
                lblVIN_Value.Text = res.VIN;
                lblTipoMotorValue.Text = (res.EsElectrico) ? "Eléctrico" : "Gasolina";
            }
        }
    }
}