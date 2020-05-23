using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI.WebControls;
using SistemaPiscina.Acceso;
using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;

namespace SistemaPiscina.Negocio
{
    public class LCasillero : ICasillero
    {
        Datos OAD = new Datos();
        public void CambiarEstado(ECasillero casillero)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@estado",casillero.Estado));
            parametros.Add(new SqlParameter("@id",casillero.Idcasillero));
            OAD.TransaccionSQL("Update TblCasillero set Estado=@estado where IdCasillero=@id",parametros);   
        }
                
        public void RegistrarCasillero(ECasillero casillero)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@numero",casillero.Numero));
            parametros.Add(new SqlParameter("@estado",casillero.Estado));
            OAD.TransaccionSQL("Insert into TblCasillero values(@numero,@estado)",parametros);
        }
        public void CasilleroDisponible(DropDownList Ddl)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataSet Data = OAD.LeerRegistro("Select * from TblCasillero where Estado='Disponible'");
            Ddl.DataSource = Data;
            Ddl.DataTextField = "Numero";
            Ddl.DataValueField = "IdCasillero";
            Ddl.DataBind();
        }
        public void ListarCasilleros(GridView grilla)
        {
            grilla.DataSource = OAD.LeerRegistro("Select * from TblCasillero");
            grilla.DataBind();
        }

        public int ObtenerID(string casillero)
        {
            int Id = 0;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@numero",casillero));
            SqlDataReader DR=OAD.Lector("Select IdCasillero from TblCasillero where Numero=@numero",parametros);
            if (DR.Read())
            {
                Id = int.Parse(DR["IdCasillero"].ToString());
            }
            return Id;
        }
    }
}