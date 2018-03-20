using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógicaa
{
    public class Empresa
    {


        public List<Cliente> Clientes { get; set; }
        public List<Venta> Ventas { get; set; }


        public Empresa()
        {

        }

        private List<Cliente> LeerArchivoClientes()
        {
            List<Cliente> listaDeserealizadaClientes = new List<Cliente>();

            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            string pathDirectory = path + "/Archivos";

            string pathFileClientes = pathDirectory + "/Clientes.txt";

            using (StreamReader reader = new StreamReader(pathFileClientes))
            {
                string cont = reader.ReadToEnd();
                listaDeserealizadaClientes = JsonConvert.DeserializeObject<List<Cliente>>(cont);
            }
            return listaDeserealizadaClientes;
        }

        private List<Venta> LeerArchivoVentas()
        {
            List<Venta> listaDeserealizadaVentas = new List<Venta>();
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            string pathDirectory = path + "/Archivos";

            string pathFileVentas = pathDirectory + "/Ventas.txt";

            using (StreamReader reader = new StreamReader(pathFileVentas))
            {
                string cont = reader.ReadToEnd();
                listaDeserealizadaVentas = JsonConvert.DeserializeObject<List<Venta>>(cont);
            }
            return listaDeserealizadaVentas;
        }

        public ResultadoOperacion AgregarCliente(Cliente nuevoCliente)
        {
            List<Cliente> nuevaLista = new List<Cliente>();
            Clientes = LeerArchivoClientes();


            if (Clientes != null)
            {

                nuevaLista = Clientes;
                nuevoCliente.Codigo = Clientes.Count + 1;
                nuevaLista.Add(nuevoCliente);




            }
            else
            {

                nuevoCliente.Codigo = 1;
                nuevaLista.Add(nuevoCliente);

            }



            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            string pathDirectory = path + "/Archivos";
            string pathFileClientes = pathDirectory + "/Clientes.txt";
            string output = JsonConvert.SerializeObject(nuevaLista);

            using (StreamWriter file = new System.IO.StreamWriter(pathFileClientes, false))
            {
                file.Write(output);
            }

            return (new ResultadoOperacion());
        }

        public ResultadoOperacion EliminarCliente(int codigoCliente)
        {
            Clientes = LeerArchivoClientes();

            foreach (var item in Clientes)
            {
                if (item.Codigo == codigoCliente)
                {
                    item.FechaEliminacion = DateTime.Now;
                    string output = JsonConvert.SerializeObject(Clientes);
                    string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                    string pathDirectory = path + "/Archivos";
                    string pathFileClientes = pathDirectory + "/Clientes.txt";
                    using (StreamWriter file = new System.IO.StreamWriter(pathFileClientes, false))
                    {
                        file.Write(output);
                    }
                    return (new ResultadoOperacion());
                }
            }
            return (new ResultadoOperacion());
        }

        public ResultadoOperacion ModificarCliente(Cliente clienteModificado)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = LeerArchivoClientes();

            foreach (var item in clientes)
            {
                if (item.Codigo == clienteModificado.Codigo)
                {
                    item.NombreApellido = clienteModificado.NombreApellido;                    
                    item.Localidad = clienteModificado.Localidad;
                    item.Telefono = clienteModificado.Telefono;
                    item.Direccion = clienteModificado.Direccion;
                    item.Mail = clienteModificado.Mail;
                    item.FechaEliminacion = clienteModificado.FechaEliminacion;
                     
                   

                    string output = JsonConvert.SerializeObject(clientes);
                    string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                    string pathDirectory = path + "/Archivos";
                    string pathFileClientes = pathDirectory + "/Clientes.txt";
                    using (StreamWriter file = new System.IO.StreamWriter(pathFileClientes, false))
                    {
                        file.Write(output);
                    }
                    return (new ResultadoOperacion());
                }
            }
            return (new ResultadoOperacion());
        }

        public List<Cliente> ObtenerListaClientes()
        {
            Clientes = LeerArchivoClientes();

            if (Clientes != null)
            {
                Clientes = LeerArchivoClientes().Where(x => x.FechaEliminacion == DateTime.MinValue).ToList();
            }
            return Clientes;
        }

        public List<Cliente> ObtenerCliente(int codigoCliente)
        {
            Clientes = LeerArchivoClientes();
            if (Clientes != null)
            {
                return codigoCliente == 0 ?
                  LeerArchivoClientes().Where(x => x.FechaEliminacion == DateTime.MinValue).ToList() :
                  LeerArchivoClientes().Where(x => x.FechaEliminacion == DateTime.MinValue && x.Codigo == codigoCliente).ToList();
            }
            return Clientes;
        }

        public ResultadoOperacion AltaVenta (Venta nuevaVenta)
        {
            Ventas = LeerArchivoVentas();

            if (Ventas != null)
            {
                nuevaVenta.Codigo = Ventas.Count + 1;
                Ventas.Add(nuevaVenta);

              
            }
            else
            {
                List<Venta> lista = new List<Venta>();
                nuevaVenta.Codigo = 1;
                lista.Add(nuevaVenta);
                Ventas = lista; 
            }

            string output1 = JsonConvert.SerializeObject(Ventas);
            string path1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            string pathDirectory1 = path1 + "/Archivos";
            string pathFileVentas = pathDirectory1 + "/Ventas.txt";
            using (StreamWriter file = new System.IO.StreamWriter(pathFileVentas, false))
            {
                file.Write(output1);
            }
            return new ResultadoOperacion();

        }

        public List<Venta> ObtenerListaVentas()
        {
            Ventas = LeerArchivoVentas();
            return Ventas;
        }

        public List<GananciaMes> ObtenerGanancia (DateTime primerFecha, DateTime segundaFecha)
        {
            List<GananciaMes> Ganancias = new List<GananciaMes>();
            Ventas = LeerArchivoVentas(); 

            if (Ventas != null)
            {
                foreach (var item in Ventas)
                {
                    if (item.Fecha.Date >= primerFecha.Date && item.Fecha.Date <= segundaFecha.Date)
                    {   
                       if (Ganancias.Count == 0)
                        {
                            GananciaMes ganancia = new GananciaMes();
                            ganancia.Año = item.Fecha.Year;
                            ganancia.Mes = item.Fecha.Month;
                            ganancia.CodigosVenta.Add(item.Codigo);
                            ganancia.TotalVendido = item.Total;
                            ganancia.GananciaEstimada = (item.Total * 15) / 100;
                            Ganancias.Add(ganancia);
                        }
                        else
                        {
                            bool agregado = false;
                            foreach (var item1 in Ganancias)
                            {
                                if ( item.Fecha.Year == item1.Año && item.Fecha.Month == item1.Mes && agregado == false)
                                {
                                    item1.TotalVendido = item1.TotalVendido + item.Total;
                                    item1.GananciaEstimada = item1.GananciaEstimada + ((item.Total * 15) / 100);
                                    agregado = true;
                                    
                                }
                               
                            }

                            if (agregado == false )
                            {
                                GananciaMes ganancia = new GananciaMes();
                                ganancia.Año = item.Fecha.Year;
                                ganancia.Mes = item.Fecha.Month;
                                ganancia.CodigosVenta.Add(item.Codigo);
                                ganancia.TotalVendido = item.Total;
                                ganancia.GananciaEstimada = (item.Total * 15) / 100;
                                Ganancias.Add(ganancia);
                            }
                        }



                       
                    }
                }

            }

            return Ganancias; 
        }

        public List<ReporteVenta> ObtenerListaVentasCliente(DateTime primerFecha, DateTime segundaFecha, int codigoCliente)
        {
            List<ReporteVenta> ListaVentas = new List<ReporteVenta>();


            Ventas = ObtenerListaVentas();

            if (Ventas != null)
            {

                foreach (var itemc in Clientes)
                {
                    foreach (var itemv in Ventas)
                    {
                        if (itemv.Fecha.Date >= primerFecha.Date && itemv.Fecha.Date <= segundaFecha.Date)
                        {
                            if (itemc.Codigo == codigoCliente && itemc.NombreApellido ==itemv.NombreClienteAsociado)
                            {
                                ReporteVenta venta = new ReporteVenta();
                                venta.Numero = itemv.Codigo;
                                venta.Fecha = itemv.Fecha;
                                venta.NombreCliente = itemc.NombreApellido;
                                venta.MontoTotal = itemv.Total;
                                ListaVentas.Add(venta);
                            }
                        }
                    }
                }


            }
            return ListaVentas;
        }
        
        public ResultadoOperacion ModificarVenta (Venta ventaModificada)
        {
            Ventas = LeerArchivoVentas();

            foreach (var item in Ventas)
            {
                if (item.Codigo == ventaModificada.Codigo)
                {
                    item.Descuento = ventaModificada.Descuento;
                    item.ListaCantidadProductos = ventaModificada.ListaCantidadProductos;
                    item.ListaPreciosTotales = ventaModificada.ListaPreciosTotales;
                    item.ListaProductos = ventaModificada.ListaProductos;
                    item.ListaPreciosUnitarios = ventaModificada.ListaPreciosUnitarios;
                    item.NombreClienteAsociado = ventaModificada.NombreClienteAsociado;
                    item.SubTotal = ventaModificada.SubTotal;
                    item.TelefonoCliente = ventaModificada.TelefonoCliente;
                    item.DireccionClienteAsociado = ventaModificada.DireccionClienteAsociado;
                }
            }

            string output1 = JsonConvert.SerializeObject(Ventas);
            string path1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            string pathDirectory1 = path1 + "/Archivos";
            string pathFileVentas = pathDirectory1 + "/Ventas.txt";
            using (StreamWriter file = new System.IO.StreamWriter(pathFileVentas, false))
            {
                file.Write(output1);
            }
            return new ResultadoOperacion();
        }

    }

    
}
