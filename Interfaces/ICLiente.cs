using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using SistemaPiscina.Entidades;


namespace SistemaPiscina.Interfaces
{
    interface ICLiente
    {
        void RegistrarCliente(ECliente cliente);
        void ModificarCliente(ECliente cliente);
        DataSet ListarCliente();
        int ObtenerID(string apellido);
        string ObtenerApellido(int id);
        
        DataSet ListaDinamica(String nombre);

        
    }
}
