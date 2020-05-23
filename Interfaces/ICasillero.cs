using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using SistemaPiscina.Entidades;

namespace SistemaPiscina.Interfaces
{
    interface ICasillero
    {
        void RegistrarCasillero(ECasillero casillero);
        void CambiarEstado(ECasillero casillero);
        void CasilleroDisponible(DropDownList Ddl);
        void ListarCasilleros(GridView grilla);
        int ObtenerID(string casillero);
    }
}
