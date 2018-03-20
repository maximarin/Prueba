using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógicaa
{
   public class ResultadoOperacion
    {
        public bool SePuedoRealizar { get; set; }
        public string Mensaje { get; set; }

        public ResultadoOperacion()
        {
            this.SePuedoRealizar = true;
            this.Mensaje = "La operación se concretó con éxito.";

        }

        public ResultadoOperacion(string mensaje)
        {
            this.SePuedoRealizar = false;
            this.Mensaje = mensaje;
        }
    }
}
