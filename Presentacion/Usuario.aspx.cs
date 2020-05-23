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
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarUsuarios();
            }
        }

        private void ListarUsuarios()
        {
            IUsuario lusuario = new LUsuario();
            lusuario.ListarUsuario(Grillausuario);
        }

        protected void Btnguardar_Click(object sender, EventArgs e)
        {
            EUsuario usuario = new EUsuario();
            usuario.Usuario = Tbusuario.Text;
            usuario.Password = Tbpass.Text;
            IUsuario lusuario = new LUsuario();
            lusuario.RegistrarUsuario(usuario);
            ListarUsuarios();
            Limpiar();
        }
        private void Limpiar()
        {
            Tbid.Text = "";
            Tbusuario.Text = "";
            Tbpass.Text = "";

        }

        protected void Btneliminar_Click(object sender, EventArgs e)
        {
            EUsuario usuario = new EUsuario();
            usuario.Id = int.Parse(Tbid.Text);
            IUsuario lusario = new LUsuario();
            lusario.EliminarUsuario(usuario);
            ListarUsuarios();
            Limpiar();
        }

        protected void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Btneliminar.Visible = false;
        }

        protected void Grillausuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btneliminar.Visible = true;
            Tbid.Text = Grillausuario.Rows[Grillausuario.SelectedIndex].Cells[1].Text;
            Tbusuario.Text= Grillausuario.Rows[Grillausuario.SelectedIndex].Cells[2].Text;
            Tbpass.Text= Grillausuario.Rows[Grillausuario.SelectedIndex].Cells[3].Text;
        }
    }
}