using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaPiscina.Negocio;
using SistemaPiscina.Interfaces;

namespace SistemaPiscina.Presentacion
{
    public partial class ListaBoleta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarBoletas();
            }
        }

        private void ListarBoletas()
        {
            IBoleta lboleta = new LBoleta();
            lboleta.ListarBoletas(Grillaboleta);
        }
    }
}