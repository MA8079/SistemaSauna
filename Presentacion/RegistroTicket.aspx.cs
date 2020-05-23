using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;
using SistemaPiscina.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPiscina.Presentacion
{
    public partial class RegistroTicket : System.Web.UI.Page
    {
        String Nombre=null;
        String DNI=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarServicio();
                CargarCasillero();
                ListarClientes();
                ListarTickets();
                Tbfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                Tbestado.Text = "Pendiente";
            }
            
            //LlenarDDL();
        }
        #region Funciones de Page Load
        private void CargarServicio()
        {
            IServicio lservicio = new LServicio();
            lservicio.ListarServicio(DdlServicio);

        }

        private void ListarTickets()
        {
            ITicket lticket = new LTicket();
            lticket.ListarTicket(Grillatickets);
        }

        private void ListarClientes()
        {
            ICLiente lcliente = new LCliente();
            Grillaclientes.DataSource = lcliente.ListarCliente();
            Grillaclientes.DataBind();
        }

        private void CargarCasillero()
        {
            ICasillero lcasillero = new LCasillero();
            lcasillero.CasilleroDisponible(Ddlcasillero);
        }

        #endregion

        #region Funciones de control de Formulario
        
        protected void Btnguardar_Click(object sender, EventArgs e)
        {
            //Se crea una instancia de la clase Lógica Cliente
            ICLiente lcliente = new LCliente();
            //Intancia de la clase Entidad Ticket
            ETicket ticket = new ETicket();
            //Se asigna los atributos del obejto ticket
            ticket.Codigo = Tbcodigo.Text;
            //Obtener el id del cliente mediante su apellido para asignar valor al atributo del objeto cliente
            ticket.Idcliente = lcliente.ObtenerID(Tbcliente.Text);//Lamada a la función Obtener ID de la clase Lógica Cliente
            //Asignar el campo de origen especificado
            ticket.Idservicio = int.Parse(DdlServicio.SelectedValue.ToString());
            //El valor de este atributo se asigna automaticamente al cambiar el valor del objeto seleccionado en el DDL Servicio
            ticket.Costo = double.Parse(Tbcosto.Text);
            //Agina el campo de origen especificado según el item seleccionado
            ticket.Idcasillero = int.Parse(Ddlcasillero.SelectedValue.ToString());
            //Convertir el valor de TbFecha al tipo de dato DateTime
            ticket.Fecha = Convert.ToDateTime(Tbfecha.Text);
            //EL estado se define por defecto en el TextBox al cargar la página
            ticket.Estado = Tbestado.Text;
            //Se crea una instancia de la clase Lógica Ticket 
            ITicket lticket = new LTicket();
            //Llamada al método Registrar del objeto LTicket
            lticket.RegistrarTicket(ticket); 
            /*Cambia el estado del casillero, se hace uso de un metodo ajeno a la clase Lógica Casillero (lcasillero)
             * que a su vez llama al método cambiar estado de LCasillero*/ 
            CasilleroOcupado(int.Parse(Ddlcasillero.SelectedValue.ToString()));
            //Se vuelve a cargar en el DropDownList los casilleros disponibles
            CargarCasillero();
            //Listar los tickets registrados
            ListarTickets();
            //Reinicia el valor de los campos TextBox
            Limpiar();
        }
        protected void Btnmodificar_Click(object sender, EventArgs e)
        {
            ETicket ticket = new ETicket();
            ticket.Idticket = int.Parse(Tbid.Text);
            ticket.Idservicio = int.Parse(DdlServicio.SelectedValue.ToString());
            ticket.Costo = double.Parse(Tbcosto.Text);
            ITicket lticket = new LTicket();
            lticket.ModificarTicket(ticket);
            ListarTickets();
            Btnmodificar.Visible = false;
            Ddlcasillero.Visible = true;
            Tbestado.Visible = true;
            Limpiar();
        }
        protected void Btnlimpiar_Click(object sender, EventArgs e)
        {
            if (Btnmodificar.Visible == true)
            {
                Btnmodificar.Visible = false;
            }
            Ddlcasillero.Visible = true;
            Tbestado.Visible = true;
            Limpiar();
        }
        protected void DdlServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            IServicio lservicio = new LServicio();
            int id = int.Parse(DdlServicio.SelectedValue.ToString());
            double Precio = lservicio.ObtenerPrecio(id);
            Tbcosto.Text = Precio.ToString();
        }
        protected void Grillatickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ddlcasillero.Visible = false;
            Tbestado.Visible = false;
            Btnmodificar.Visible =true;
            Tbid.Text = Grillatickets.Rows[Grillatickets.SelectedIndex].Cells[1].Text;
            int ID = int.Parse(Grillatickets.Rows[Grillatickets.SelectedIndex].Cells[3].Text);
            Tbcliente.Text = ObtenerApellido(ID);//Obtener el apellido del cliente mediante el id.
            Tbcodigo.Text = Grillatickets.Rows[Grillatickets.SelectedIndex].Cells[2].Text;
            DdlServicio.Text = Grillatickets.Rows[Grillatickets.SelectedIndex].Cells[4].Text;//Captura tal y conforme el valor
            Tbcosto.Text = Grillatickets.Rows[Grillatickets.SelectedIndex].Cells[5].Text;
        }
        protected void Grillaclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nombre = Grillaclientes.Rows[Grillaclientes.SelectedIndex].Cells[2].Text;
            Tbcliente.Text = Grillaclientes.Rows[Grillaclientes.SelectedIndex].Cells[3].Text;
            DNI = Grillaclientes.Rows[Grillaclientes.SelectedIndex].Cells[4].Text;
            Tbcodigo.Text = GenerarCodigo(Nombre, DNI);

        }
        #endregion

        private void CasilleroOcupado(int idcasillero)
        {
            ECasillero casillero = new ECasillero();
            casillero.Idcasillero =idcasillero;
            casillero.Estado = "Ocupado";
            ICasillero lcasillero = new LCasillero();            
            lcasillero.CambiarEstado(casillero);
        }

        private String GenerarCodigo(String nombre, String dni)
        {
            String Codigo = nombre.Substring(0, 3).ToUpper() + dni.Substring(0, 3).ToUpper();
            return Codigo;
        }
        private string ObtenerApellido(int id)
        {
            ICLiente lcliente = new LCliente();
            return lcliente.ObtenerApellido(id);
        }       
        private void Limpiar()
        {
            Tbid.Text = "";
            Tbcliente.Text = "";
            Tbcodigo.Text = "";
        }

        protected void Tbbuscar_TextChanged(object sender, EventArgs e)
        {
            Response.Redirect("www.x.com");
        }
    }
}