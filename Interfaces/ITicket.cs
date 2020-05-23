using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using SistemaPiscina.Entidades;

namespace SistemaPiscina.Interfaces
{
    interface ITicket
    {
        void RegistrarTicket(ETicket ticket);
        void ModificarTicket(ETicket ticket);
        void EliminarTicket(ETicket ticket);
        void ListarTicket(GridView grilla);
        void TicketPendientes(GridView grilla);
        void CambiarEstado(ETicket ticket);
    }
}
