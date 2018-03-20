using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógicaa
{
   public  class Venta
    {
        public string NombreClienteAsociado { get; set; }
        public string DireccionClienteAsociado { get; set; }
        public string LocalidadCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public int Codigo { get; set; }
        public List<string> ListaProductos { get; set; } 
        public List<int> ListaCantidadProductos { get; set; }
        public List<double> ListaPreciosUnitarios { get; set; }
        public List<double> ListaPreciosTotales { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public Venta()
        {
            List<string> ListaProductos = new List<string>();
            List<int> ListaCantidadProductos = new List<int>();
            List<double> ListaPreciosUnitarios = new List<double>();
            List<double> ListaPreciosTotales = new List<double>();


        }

    }
}
