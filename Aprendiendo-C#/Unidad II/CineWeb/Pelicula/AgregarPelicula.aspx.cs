using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineWeb.Pelicula
{
    public partial class AgregarPelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarIdiomas();
                CargarValoracion();
            }
        }


        protected void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            Modelo.Pelicula p = new Modelo.Pelicula()
            {
                Nombre = txtNombre.Text,
                Director = txtDirector.Text,
                Idioma = ddlIdioma.SelectedItem.Text,
                Duracion = Convert.ToInt32(txtDuracion.Text),
                Valoracion = Convert.ToInt32(ddlValoracion.SelectedItem.Text),
                EsTodoPublico = chbEsTodoPublico.Checked,
                EnCartelera = chbEnCartelera.Checked,
                TieneSubtitulos = chbTieneSubtitulos.Checked,
                FechaEstreno = calFechaEstreno.SelectedDate
            };
            string message = PeliculaController.Create(p);
            string url = string.Format("~/Pelicula/ListarPeliculas.aspx?message={0}", message);
            Response.Redirect(url);
        }

        private void CargarIdiomas()
        {
            ddlIdioma.Items.Clear();
            ddlIdioma.Items.Add("Seleccionar");
            ddlIdioma.Items[0].Attributes["disabled"] = "disabled";
            ddlIdioma.Items[0].Attributes["selected"] = "selected";

            var idiomas = System.Enum.GetValues(typeof(Idioma));

            foreach (var idioma in idiomas)
            {
                ddlIdioma.Items.Add(idioma.ToString());
            }

            ddlIdioma.DataBind();
        }

        private void CargarValoracion()
        {
            ddlValoracion.Items.Clear();

            ddlValoracion.Items.Add("Seleccionar");
            ddlValoracion.Items[0].Attributes["disabled"] = "disabled";
            ddlValoracion.Items[0].Attributes["selected"] = "selected";

            for (int i = 1; i < 6; i++)
            {
                ddlValoracion.Items.Add(i.ToString());
            }

            ddlValoracion.DataBind();
        }

        private void SetDefaultValueDDl(DropDownList ddl)
        {
            ddl.Items.Clear();

            ddl.Items.Add("Seleccionar");
            ddl.Items[0].Attributes["disabled"] = "disabled";
            ddl.Items[0].Attributes["selected"] = "selected";
        }
    }
}