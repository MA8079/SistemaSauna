using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaPiscina.Interfaces;
using SistemaPiscina.Negocio;

namespace SistemaPiscina.Presentacion
{
    public partial class TicketPendiente : System.Web.UI.Page
    {
        static String IDticket;
        static String Cliente;
        static String Servicio;
        static String Costo;
        static String Casillero;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarPendientes();
            }
            

        }

        private void ListarPendientes()
        {
            ITicket lticket = new LTicket();
            lticket.TicketPendientes(GrillaTicket);
        }

        protected void GrillaTicket_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nombre, apellido;
            Btngenerar.Visible = true;
            IDticket =GrillaTicket.Rows[GrillaTicket.SelectedIndex].Cells[1].Text;
            nombre= GrillaTicket.Rows[GrillaTicket.SelectedIndex].Cells[3].Text;
            apellido=GrillaTicket.Rows[GrillaTicket.SelectedIndex].Cells[4].Text;
            Cliente = nombre + " " + apellido;
            Servicio = GrillaTicket.Rows[GrillaTicket.SelectedIndex].Cells[5].Text;
            Costo= GrillaTicket.Rows[GrillaTicket.SelectedIndex].Cells[6].Text;
            Casillero = GrillaTicket.Rows[GrillaTicket.SelectedIndex].Cells[7].Text;
        }

        protected void Btngenerar_Click(object sender, EventArgs e)
        {
            Session.Add("idticket",IDticket);
            Session.Add("cliente",Cliente);
            Session.Add("servicio",Servicio);
            Session.Add("costo",Costo);
            Session.Add("casillero",Casillero);
            Response.Redirect("Boleta.aspx");
            
        }
    }
}