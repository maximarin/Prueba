using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógicaa
{
   public class GananciaMes
    {
        public int Año { get; set; }
        public int Mes { get; set; }
        public double TotalVendido { get; set; }
       
        public double GananciaEstimada { get; set; }
        public List<int> CodigosVenta { get; set; }

        public GananciaMes()
        {
            this.CodigosVenta = new List<int>();

        }
    }
}
