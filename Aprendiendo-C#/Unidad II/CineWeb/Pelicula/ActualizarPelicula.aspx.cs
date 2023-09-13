using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineWeb.Pelicula
{
    public partial class ActualizarPelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.Params["id"];
            if (id == null)
                lblMessage.Text = "Se debe proporcionar el id";
            else
                if (!IsPostBack)
                CargarRegistro(id);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = lblId_Value.Text;
            int nuevaValoracion = Convert.ToInt32(ddlValoracion.SelectedItem.Text);
            bool nuevoEnCartelera = chkEnCartelera.Checked;
            string message = PeliculaController.Update(id, nuevaValoracion, nuevoEnCartelera);
            string url = string.Format("~/Pelicula/ListarPeliculas.aspx?message={0}", message);
            Response.Redirect(url);
        }

        private void CargarRegistro(string id)
        {
            var res = PeliculaController.Read(id);
            if (res == null)
                lblMessage.Text = $"La pelicula con ID {id} no pudo ser encontrada";
            else
            {
                CargarValoracion();
                lblId_Value.Text = res.Id;
                lblNombre_Value.Text = res.Nombre;
                ddlValoracion.Items[res.Valoracion].Attributes["selected"] = "selected";
                chkEnCartelera.Checked = res.EnCartelera;
            }
        }

        private void CargarValoracion()
        {
            ddlValoracion.Items.Clear();
            ddlValoracion.Items.Add("Seleccionar");
            ddlValoracion.Items[0].Attributes["disabled"] = "disabled";

            for (int i = 1; i < 6; i++)
            {
                ddlValoracion.Items.Add(i.ToString());
            }
            ddlValoracion.DataBind();
        }
    }
}