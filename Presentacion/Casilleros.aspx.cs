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
    public partial class Casilleros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarCasilleros();
            }

        }

        private void ListarCasilleros()
        {
            ICasillero lcasillero = new LCasillero();
            lcasillero.ListarCasilleros(Grillacasillero);
        }

        protected void Btnguardar_Click(object sender, EventArgs e)
        {
            ECasillero casillero = new ECasillero();
            casillero.Numero = int.Parse(Tbnumero.Text);
            casillero.Estado = Tbestado.Text;
            ICasillero lcasillero = new LCasillero();
            lcasillero.RegistrarCasillero(casillero);
            ListarCasilleros();
            Limpiar();
        }
        private void Limpiar()
        {
            Tbnumero.Text = "";
            Tbestado.Text = "";
        }
    }
}