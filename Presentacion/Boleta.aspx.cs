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
    public partial class Boleta : System.Web.UI.Page
    {
        static string IdTicket,Casillero;   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idticket"] != null)
            {
                IdTicket = Convert.ToString(Session["idticket"]);
                Lbcliente.Text = Convert.ToString(Session["cliente"]);
                Lbservicio.Text = Convert.ToString(Session["servicio"]);
                Lbtotal.Text = Convert.ToString(Session["costo"]);
                Casillero = Convert.ToString(Session["casillero"]);
            }
            else
            {
                Response.Redirect("TicketPendiente.aspx");
            }
            if (!IsPostBack)
            {
                Lbfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                ListarBoletas();
            }
            

        }

        private void ListarBoletas()
        {
            IBoleta lboleta = new LBoleta();
            lboleta.ListarBoletas(Grillaboleta);
        }

        protected void Btnguardar_Click(object sender, EventArgs e)
        {
            if (Lbcliente.Text!="")
            {
                EBoleta boleta = new EBoleta();
                boleta.Ruc = Lbruc.Text;
                boleta.Idticket = int.Parse(IdTicket);
                boleta.Cliente = Lbcliente.Text;
                boleta.Servicio = Lbservicio.Text;
                boleta.Total = double.Parse(Lbtotal.Text);
                boleta.Fecha = Convert.ToDateTime(Lbfecha.Text);
                IBoleta lboleta = new LBoleta();
                lboleta.RegistrarBoleta(boleta);
                TicketCancelado(IdTicket);
                CasilleroDisponible(int.Parse(Casillero));
                ListarBoletas();
                Limpiar();
                RemoverSession();
            }
            else
            {
                LbMensaje.Text = "Campos vacíos,acción no permitida";
            }
        }
        
        private void TicketCancelado(string idticket)
        {
            ETicket ticket = new ETicket();
            ticket.Idticket = int.Parse(idticket);
            ticket.Estado = "Cancelado";
            ITicket lticket = new LTicket();
            lticket.CambiarEstado(ticket);
        }

        protected void Btnvolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("TicketPendiente.aspx");
        }

        private void CasilleroDisponible(int numero)
        {            
            ECasillero casillero = new ECasillero();
            casillero.Idcasillero = numero;
            casillero.Estado = "Disponible";
            ICasillero lcasillero = new LCasillero();
            lcasillero.CambiarEstado(casillero);
        }
        private void Limpiar()
        {
            Lbcliente.Text = "";
            Lbservicio.Text = "";
            Lbtotal.Text = "";
        }
        //
        private void RemoverSession()
        {
            Session.Remove("idticket");
            Session.Remove("cliente");
            Session.Remove("servicio");
            Session.Remove("costo");
            Session.Remove("casillero");
        }

    }
}