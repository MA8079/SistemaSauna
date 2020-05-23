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
    interface IUsuario
    {
        void ListarUsuario(GridView grilla);
        void RegistrarUsuario(EUsuario usuario);
        void EliminarUsuario(EUsuario usuario);        
        bool ValidarUsuario(EUsuario usuario);
    }
}
