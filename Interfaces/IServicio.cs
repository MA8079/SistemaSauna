using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using SistemaPiscina.Entidades;

namespace SistemaPiscina.Interfaces
{
    interface IServicio
    {
        void RegistrarServicio(EServicio servicio);
        void EliminarServicio(EServicio servicio);
        void ModificarServicio(EServicio servicio);
        void ListarServicio(DropDownList ddlservicio);
        void ListarServicio(GridView grillaservicio);
        double ObtenerPrecio(int idservicio);
    }
}
