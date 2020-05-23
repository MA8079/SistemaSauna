using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPiscina.Entidades
{
    public class EServicio
    {
        private int idservicio;
        private string nombre;
        private double costo;
        public int Idservicio { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
    }
}