using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;
using SistemaPiscina.Acceso;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SistemaPiscina.Negocio
{
    public class LUsuario : IUsuario
    {
        Datos OAD = new Datos();
        public void EliminarUsuario(EUsuario usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", usuario.Id));
            OAD.TransaccionSQL("Delete from TblUsuario where IdUsuario=@id", parametros);
        }

        public void ListarUsuario(GridView grilla)
        {
            grilla.DataSource=OAD.LeerRegistro("Select * from TblUsuario");
            grilla.DataBind();
        }

        public void RegistrarUsuario(EUsuario usuario)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuario", usuario.Usuario));
            parametros.Add(new SqlParameter("@contraseña", usuario.Password));
            
            OAD.TransaccionSQL("Insert into TblUsuario values(@usuario,@contraseña)", parametros);

        }

        public bool ValidarUsuario(EUsuario usuario)
        {
            List<SqlParameter> parametos = new List<SqlParameter>();
            parametos.Add(new SqlParameter("@user",usuario.Usuario));
            parametos.Add(new SqlParameter("@pass",usuario.Password));
            SqlDataReader DR = OAD.Lector("Select * from TblUsuario where Usuario=@user and Password=@pass",parametos);
            if (DR.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}