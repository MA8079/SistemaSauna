using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPiscina.Entidades
{
    public class ECliente
    {
        private int idcliente;
        private string nombre;
        private string apellido;
        private string dni;
        private string telefono;

        public int Idcliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
    }
}