using Lógicaa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    interface IMetodos
    {
        void AltaCliente(Cliente nuevoCliente);
        void BajaCLiente(int codigoCliente);
        void ModificacionCliente(Cliente clienteModificado);
        void AltaVenta(Venta nuevaVenta);
        List<Cliente> CargarClientesCB();
        List<Cliente> ObtenerCliente1(int codigoCliente);
        List<Venta> ObtenerVentas();
        List<ReporteVenta> ObtenerVentasAClientes(DateTime fecha1, DateTime fecha2, int codigoCliente);
        List<GananciaMes> GananciaMeses(DateTime primerFecha, DateTime segundaFecha);
        void ModificacionVenta(Venta ventaModificada);


    }
}
