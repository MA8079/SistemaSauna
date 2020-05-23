using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;
using SistemaPiscina.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPiscina.Presentacion
{
    public partial class Servicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarServicios();
            }
        }

        private void ListarServicios()
        {
            IServicio lservicio = new LServicio();
            lservicio.ListarServicio(Grillaservicios);
        }

        protected void Btnguardar_Click(object sender, EventArgs e)
        {
            EServicio servicio = new EServicio();
            servicio.Nombre = Tbnombre.Text;
            servicio.Costo = double.Parse(Tbcosto.Text);
            IServicio lservicio = new LServicio();
            lservicio.RegistrarServicio(servicio);
            ListarServicios();
            Limpiar();

        }
        private void Limpiar()
        {
            Tbid.Text = "";
            Tbnombre.Text = "";
            Tbcosto.Text = "";
        }

        protected void Btnmodificar_Click(object sender, EventArgs e)
        {
            EServicio servicio = new EServicio();
            servicio.Idservicio = int.Parse(Tbid.Text);
            servicio.Nombre = Tbnombre.Text;
            servicio.Costo = double.Parse(Tbcosto.Text);
            IServicio lservicio = new LServicio();
            lservicio.ModificarServicio(servicio);
            ListarServicios();
            Limpiar();
            Btnmodificar.Visible = false;
        }

        protected void Grillaservicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btnmodificar.Visible = true;
            Tbid.Text = Grillaservicios.Rows[Grillaservicios.SelectedIndex].Cells[1].Text;
            Tbnombre.Text = Grillaservicios.Rows[Grillaservicios.SelectedIndex].Cells[2].Text;
            Tbcosto.Text = Grillaservicios.Rows[Grillaservicios.SelectedIndex].Cells[3].Text;
        }

        protected void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Btnmodificar.Visible = true;
        }
    }
}