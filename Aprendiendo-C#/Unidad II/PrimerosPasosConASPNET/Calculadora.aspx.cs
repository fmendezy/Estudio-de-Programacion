using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerosPasosConASPNET
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            lblResultados.Text = "Los resultados son:";
            lblSuma.Text = "Resultado suma: ";
            lblMultiplicacion.Text = "Resultado multiplicación: ";
            lblResta.Text = "Resultado resta: ";
            lblDivision.Text = "Resultado division: ";

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPrimerNumero.Text, out int primerNumero) &&
                int.TryParse(txtSegundoNumero.Text, out int segundoNumero))
            {
                int suma = primerNumero + segundoNumero;
                int rest = primerNumero - segundoNumero;
                int multi = primerNumero * segundoNumero;

                double divi = (double)primerNumero / segundoNumero; // Asegurarse de la división decimal

                // Mostrar resultados en labels
                lblSuma.Text += suma;
                lblMultiplicacion.Text += multi;
                lblResta.Text += rest;
                lblDivision.Text += divi;
            }
            else
            {
                // Si no se pueden convertir a numeros, mostrara un mensaje de error
                lblResultados.Text = "Por favor, ingrese números válidos en ambas cajas de texto.";
                lblSuma.Text += "Error en el valor";
                lblMultiplicacion.Text += "Error en el valor";
                lblResta.Text += "Error en el valor";
                lblDivision.Text += "Error en el valor";
            }
        }
    }
}