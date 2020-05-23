using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPiscina.Entidades
{
    public class EUsuario
    {
        private int id;
        private string usuario;
        private string password;
        private string tipo;
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
    }
}