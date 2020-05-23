using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;
using SistemaPiscina.Negocio;

namespace SistemaPiscina.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            EUsuario usuario = new EUsuario();
            usuario.Usuario = TbUsuario.Text;
            usuario.Password = TbPass.Text;
            IUsuario l_usuario = new LUsuario();
            bool Acceso=l_usuario.ValidarUsuario(usuario);
            if (Acceso==true)
            {
                Session.Add("Admin",true);
                Response.Redirect("Clientes.aspx");
            }
            else
            {
                LbError.Text = "Usuario y/o Contraseña inválido";
            }

        }
    }
}