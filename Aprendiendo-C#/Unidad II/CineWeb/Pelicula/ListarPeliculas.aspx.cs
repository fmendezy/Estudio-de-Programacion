using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineWeb.Pelicula
{
    public partial class ListarPeliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string message = Request.Params["message"];
            if (message != null)
                lblMessage.Text += message + "\n";

            string filtro = Request.Params["filtro"];
            if (filtro != null)
            {
                CargarGrillaBusquedaAvanzada(filtro);
            }
            else
                CargarGrillaListarTodo();
        }

        protected void gdvPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row = gdvPeliculas.SelectedIndex;

            string id = gdvPeliculas.DataKeys[row].Values[0].ToString();

            string url = string.Format("~/Pelicula/DetallePelicula.aspx?id={0}", id);

            Response.Redirect(url);
        }

        private void CargarGrillaListarTodo()
        {
            gdvPeliculas.DataSource = null;

            var res = PeliculaController.ReadAll();

            if (res.Count == 0)
                lblMessage.Text += "No hay peliculas registradas";
            else
            {
                lblMessage.Text += $"Se han encontrado {res.Count} registros:";
                gdvPeliculas.DataSource = res;
                gdvPeliculas.DataBind();
            }
        }

        private void CargarGrillaBusquedaAvanzada(string filtro)
        {
            var res = PeliculaController.Search(filtro);

            if (res.Count == 0)
                lblMessage.Text += $"No se encontraron peliculas con el filtro '{filtro}'";
            else
            {
                lblMessage.Text += $"Se han encontrado {res.Count} registros con el filtro '{filtro}'";
                gdvPeliculas.DataSource = res;
                gdvPeliculas.DataBind();
            }
        }
    }
}