using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SistemaPiscina.Acceso;
using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;

namespace SistemaPiscina.Negocio
{
    public class LCliente : ICLiente
    {
        Datos OAD = new Datos();

        public DataSet ListaDinamica(string nombre)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre",nombre));
            return OAD.LeerRegistro("Select * from TblCliente where Nombre like ='%@nombre%'",parametros);
        }

        public DataSet ListarCliente()
        {
            return OAD.LeerRegistro("Select * from TblCliente");
        }

        public void ModificarCliente(ECliente cliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",cliente.Idcliente));
            parametros.Add(new SqlParameter("@dni", cliente.Dni));
            parametros.Add(new SqlParameter("@telefono", cliente.Telefono));
            OAD.TransaccionSQL("Update TblCliente set DNI=@dni,Telefono=@dni where IdCliente=@id",parametros);
        }

        public string ObtenerApellido(int id)
        {
            String Apellido = null;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",id));
            SqlDataReader DR=OAD.Lector("Select Apellido from TblCliente where IdCliente=@id",parametros);
            while (DR.Read())
            {
                Apellido = DR["Apellido"].ToString();
            }
            return Apellido;
        }

        
        public int ObtenerID(string apellido)
        {
            int ID=0;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@apellido",apellido));
            SqlDataReader Dr=OAD.Lector("Select IdCliente from TblCliente where Apellido=@apellido",parametros);
            while (Dr.Read())
            {
                ID = int.Parse(Dr["IdCliente"].ToString());
            }
            return ID;
        }

        public void RegistrarCliente(ECliente cliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre",cliente.Nombre));
            parametros.Add(new SqlParameter("@apellido", cliente.Apellido));
            parametros.Add(new SqlParameter("@dni", cliente.Dni));
            parametros.Add(new SqlParameter("@telefono", cliente.Telefono));
            OAD.TransaccionSQL("Insert into TblCliente values(@nombre,@apellido,@dni,@telefono)",parametros);
        }
    }
}