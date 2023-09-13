using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomotoraWeb
{
    public partial class AgregarVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CargarAnios();
        }

        protected void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            Modelo.Vehiculo vehiculo = new Modelo.Vehiculo()
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Anio = Convert.ToInt32(ddlAnio.SelectedItem.Text),
                VIN = txtVIN.Text.ToUpper(),
                EsElectrico = (chkEsElectrico.Checked) ? true : false
            };

            string message = VehiculoController.Create(vehiculo);

            Response.Redirect($"~/Vehiculo/ListarVehiculos.aspx?message={message}");
        }

        private void CargarAnios()
        {
            ddlAnio.Items.Clear();
            ddlAnio.Items.Add("Seleccionar");
            ddlAnio.Items[0].Attributes["disabled"] = "disabled";
            ddlAnio.Items[0].Attributes["selected"] = "selected";

            int year = DateTime.Now.Year +1;

            for(int i = 2000; i< year; i++)
            {
                ddlAnio.Items.Add(i.ToString());
            }
        }
    }
}