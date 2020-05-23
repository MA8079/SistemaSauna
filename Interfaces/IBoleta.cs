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
    interface IBoleta
    {
        void RegistrarBoleta(EBoleta boleta);
        void ListarBoletas(GridView grilla);
        
        
    }
}
