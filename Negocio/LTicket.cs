using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using SistemaPiscina.Acceso;
using SistemaPiscina.Entidades;
using SistemaPiscina.Interfaces;

namespace SistemaPiscina.Negocio
{
    public class LTicket : ITicket
    {
        Datos OAD = new Datos();

        public void CambiarEstado(ETicket ticket)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",ticket.Idticket));
            parametros.Add(new SqlParameter("@estado",ticket.Estado));
            OAD.TransaccionSQL("Update TblTicket set Estado=@estado where IdTicket=@id",parametros);
        }

        public void EliminarTicket(ETicket ticket)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",ticket.Idticket));
            OAD.TransaccionSQL("Delete from TblTicket where IdTicket=@id",parametros);
        }

        public void ListarTicket(GridView grilla)
        {
            grilla.DataSource=OAD.LeerRegistro("Select * from TblTicket");
            grilla.DataBind();
        }

        public void ModificarTicket(ETicket ticket)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",ticket.Idticket));
            parametros.Add(new SqlParameter("@servicio",ticket.Idservicio));
            parametros.Add(new SqlParameter("@costo",ticket.Costo));
            
            OAD.TransaccionSQL("Update TblTicket set IdServicio=@servicio,Costo=@costo where IdTicket=@id",parametros);

        }

        public void RegistrarTicket(ETicket ticket)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@codigo",ticket.Codigo));
            parametros.Add(new SqlParameter("@cliente",ticket.Idcliente));
            parametros.Add(new SqlParameter("@servicio",ticket.Idservicio));
            parametros.Add(new SqlParameter("@costo",ticket.Costo));
            parametros.Add(new SqlParameter("@casillero",ticket.Idcasillero));
            parametros.Add(new SqlParameter("@fecha",ticket.Fecha));
            parametros.Add(new SqlParameter("@estado",ticket.Estado));
            OAD.TransaccionSQL("Insert into TblTicket values(@codigo,@cliente,@servicio,@costo,@casillero,@fecha,@estado)",parametros);
        }

        public void TicketPendientes(GridView grilla)
        {
            grilla.DataSource=OAD.LeerRegistro("Select * from VistaTicketPendientes");
            grilla.DataBind();
        }
    }
}