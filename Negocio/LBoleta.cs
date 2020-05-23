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
    public class LBoleta : IBoleta
    {
        Datos OAD = new Datos();
        public void ListarBoletas(GridView grilla)
        {
            grilla.DataSource = OAD.LeerRegistro("Select * from VistaBoletas order by Fecha DESC");
            grilla.DataBind();
        }
                             
        public void RegistrarBoleta(EBoleta boleta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@ruc",boleta.Ruc));
            parametros.Add(new SqlParameter("@idticket",boleta.Idticket));
            parametros.Add(new SqlParameter("@cliente",boleta.Cliente));
            parametros.Add(new SqlParameter("@servicio",boleta.Servicio));
            parametros.Add(new SqlParameter("@total",boleta.Total));
            parametros.Add(new SqlParameter("@fecha",boleta.Fecha));
            OAD.TransaccionSQL("Insert into TblBoleta values(@ruc,@idticket,@cliente,@servicio,@total,@fecha)",parametros);

        }
    }
}