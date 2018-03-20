using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógicaa
{
    public class ReporteVenta
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public double MontoTotal { get; set; }


        public ReporteVenta()
        {
            MontoTotal = 0;

        }
    }
}
