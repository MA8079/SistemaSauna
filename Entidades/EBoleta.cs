using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SistemaPiscina.Entidades
{
    public class EBoleta
    {
        private int idboleta;
        private string ruc;
        private int idticket;
        private string cliente;
        private string servicio;
        private double total;
        private DateTime fecha;

        public int Idboleta { get; set; }
        public string Ruc { get; set; }
        public int Idticket { get; set; }
        public string Cliente { get; set; }
        public string Servicio { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}