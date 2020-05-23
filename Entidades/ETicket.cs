using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPiscina.Entidades
{
    public class ETicket
    {
        private int idticket;
        private string codigo;
        private int idcliente;
        private int idservicio;
        private double costo;
        private int idcasillero;
        private DateTime fecha;
        private string estado;
        public int Idticket { get; set; }
        public string Codigo { get; set; }
        public int Idcliente { get; set; }
        public int Idservicio { get; set; }
        public double Costo { get; set; }
        public int Idcasillero { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}