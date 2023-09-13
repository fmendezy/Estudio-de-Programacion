using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineWeb.Pelicula
{
    public partial class DetallePelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.Params["id"];
            if (id == null)
                lblMessage.Text = "El id debe ser proporcionado";
            else
            {
                CargarRegistro(id);
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = lblId_Value.Text;
            string url = string.Format("~/Pelicula/ActualizarPelicula.aspx?id={0}", id);
            Response.Redirect(url);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = lblId_Value.Text;
            string message = PeliculaController.Delete(id);
            string url = string.Format("~/Pelicula/ListarPeliculas.aspx?message={0}", message);
            Response.Redirect(url);
        }

        private void CargarRegistro(string id)
        {
            var res = PeliculaController.Read(id);
            if (res == null)
                lblMessage.Text = $"No existe el registro con ID {id}";
            else
            {
                lblId_Value.Text = res.Id;
                lblNombre_Value.Text = res.Nombre;
                lblDirector_Value.Text = res.Director;
                lblIdioma_Value.Text = res.Idioma;
                lblDuracion_Value.Text = res.Duracion.ToString();
                lblValoracion_Value.Text = res.Valoracion.ToString();
                lblEsTodoPublico_Value.Text = (res.EsTodoPublico) ? "Si" : "No";
                lblEnCartelera_Value.Text = (res.EnCartelera) ? "Si" : "No";
                lblTieneSubtitulo_Value.Text = (res.TieneSubtitulos) ? "Si" : "No";
                lblFechaEstreno_Value.Text = res.FechaEstreno.ToString();
            }
        }
    }
}