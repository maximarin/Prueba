using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógicaa
{
   public class Cliente
    { 
        public string NombreApellido { get; set; }
        public int Codigo { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string Mail { get; set; }

        public Cliente()
        {
            FechaEliminacion = DateTime.MinValue; 
        }

    }
}
