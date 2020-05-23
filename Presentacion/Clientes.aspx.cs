using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;
using SistemaPiscina.Negocio;

namespace SistemaPiscina.Presentacion
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarCLientes();
            }
            
        }

        private void ListarCLientes()
        {
            ICLiente lcliente = new LCliente();
            GridviewClientes.DataSource=lcliente.ListarCliente();
            GridviewClientes.DataBind();
        }

        protected void Btnguardar_Click(object sender, EventArgs e)
        {
            ECliente cliente = new ECliente();
            cliente.Nombre = Tbnombre.Text;
            cliente.Apellido = Tbapellido.Text;
            cliente.Dni = Tbdni.Text;
            cliente.Telefono = tbtelefono.Text;
            ICLiente lcliente = new LCliente();
            lcliente.RegistrarCliente(cliente);
            ListarCLientes();
            Limpiar();

        }

        protected void Btnmodificar_Click(object sender, EventArgs e)
        {
            ECliente cliente = new ECliente();
            cliente.Idcliente = int.Parse(Tbid.Text);
            cliente.Dni = Tbdni.Text;
            cliente.Telefono = tbtelefono.Text;
            ICLiente lcliente = new LCliente();
            lcliente.ModificarCliente(cliente);
            ListarCLientes();
            Limpiar();
        }

        protected void GridviewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Btnmodificar.Enabled = true;
            Tbid.Text = GridviewClientes.Rows[GridviewClientes.SelectedIndex].Cells[1].Text;
            Tbnombre.Text = GridviewClientes.Rows[GridviewClientes.SelectedIndex].Cells[2].Text;
            Tbapellido.Text = GridviewClientes.Rows[GridviewClientes.SelectedIndex].Cells[3].Text;
            Tbdni.Text = GridviewClientes.Rows[GridviewClientes.SelectedIndex].Cells[4].Text;
            tbtelefono.Text = GridviewClientes.Rows[GridviewClientes.SelectedIndex].Cells[5].Text;
        }
        private void Limpiar()
        {
            Tbid.Text = "";
            Tbnombre.Text = "";
            Tbapellido.Text = "";
            Tbdni.Text = "";
            tbtelefono.Text = "";
        }

        protected void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Tbdni.MaxLength!=8)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (tbtelefono.MaxLength!=9)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}