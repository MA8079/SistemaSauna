using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using SistemaPiscina.Acceso;
using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;


namespace SistemaPiscina.Negocio
{
    public class LServicio : IServicio
    {
        Datos OAD = new Datos();
        public void EliminarServicio(EServicio servicio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",servicio.Idservicio));
            OAD.TransaccionSQL("Delete from TblServicio where IdServicio=@id",parametros);
        }

        public void ListarServicio(DropDownList ddlservicio)
        {
            ddlservicio.DataSource = OAD.LeerRegistro("Select * from TblServicio");
            ddlservicio.DataTextField = "Nombre";
            ddlservicio.DataValueField = "IdServicio";
            ddlservicio.DataBind();
        }

        public void ListarServicio(GridView grillaservicio)
        {
            grillaservicio.DataSource= OAD.LeerRegistro("Select * from TblServicio");
            grillaservicio.DataBind();
        }

        public void ModificarServicio(EServicio servicio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",servicio.Idservicio));
            parametros.Add(new SqlParameter("@nombre",servicio.Nombre)) ;
            parametros.Add(new SqlParameter("@costo",servicio.Costo));
            OAD.TransaccionSQL("Update TblServicio set Nombre=@nombre,Costo=@costo where IdServicio=@id",parametros);
        }

        public double ObtenerPrecio(int idservicio)
        {
            double Costo=0;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",idservicio));
            SqlDataReader DR=OAD.Lector("Select Costo from TblServicio where IdServicio=@id",parametros);
            if (DR.Read())
            {
                Costo =double.Parse(DR["Costo"].ToString());
            }
            return Costo;
            
        }

        public void RegistrarServicio(EServicio servicio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();            
            parametros.Add(new SqlParameter("@nombre", servicio.Nombre));
            parametros.Add(new SqlParameter("@costo", servicio.Costo));
            OAD.TransaccionSQL("Insert into TblServicio values(@nombre,@costo)", parametros);
        }
    }
}