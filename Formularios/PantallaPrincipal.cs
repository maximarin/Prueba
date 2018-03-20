using Formularios.Clientes;
using Formularios.Ventas;
using Lógicaa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formularios
{
    public partial class PantallaPrincipal : Form, IMetodos 
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        Empresa nuevaEmpresa = new Empresa();

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            string pathDirectory = path + "/Archivos";
            if (!Directory.Exists(pathDirectory))
            {
                Directory.CreateDirectory(pathDirectory);
            }

            string pathFileClientes = pathDirectory + "/Clientes.txt";
            if (!File.Exists(pathFileClientes))
            {
                using (StreamWriter file = new System.IO.StreamWriter(pathFileClientes, false))
                {
                    file.Write("");
                }
            }

            string pathFileVentas = pathDirectory + "/Ventas.txt";
            if (!File.Exists(pathFileVentas))
            {
                using (StreamWriter file = new System.IO.StreamWriter(pathFileVentas, false))
                {
                    file.Write("");
                }
            }



        }

        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaClientes pantallaCliente = new AltaClientes();
            pantallaCliente.Owner = this;
            pantallaCliente.ShowDialog(); 

        }

        private void gRILLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaClientes grillaClientes = new GrillaClientes();
            grillaClientes.Owner = this;
            grillaClientes.ShowDialog();

        }

        private void cARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CargarVenta pantallaVenta = new CargarVenta();
            pantallaVenta.Owner = this;
            pantallaVenta.ShowDialog();

        }

        private void gRILLAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GrillaVentas grillaVentas = new GrillaVentas();
            grillaVentas.Owner = this;
            grillaVentas.ShowDialog(); 

        }

        public void AltaCliente(Cliente nuevoCliente)
        {
            MessageBox.Show(nuevaEmpresa.AgregarCliente(nuevoCliente).Mensaje); 

        }

        public void BajaCLiente(int codigoCliente)
        {
            throw new NotImplementedException();
        }

        public void ModificacionCliente(Cliente clienteModificado)
        {
            MessageBox.Show(nuevaEmpresa.ModificarCliente(clienteModificado).Mensaje);

        }

        public void AltaVenta(Venta nuevaVenta)
        {
            MessageBox.Show(nuevaEmpresa.AltaVenta(nuevaVenta).Mensaje); 
        }

        public List<Cliente> CargarClientesCB()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente() { NombreApellido = "Seleccionar...", Codigo = 0 });
            if (this.nuevaEmpresa.ObtenerListaClientes() != null)
            {
                clientes.AddRange(this.nuevaEmpresa.ObtenerListaClientes());
            }

            return clientes;
        }

        public List<Cliente> ObtenerCliente1(int codigoCliente)
        {
            return nuevaEmpresa.ObtenerCliente(codigoCliente); 

        }

        public List<Venta> ObtenerVentas()
        {
            return nuevaEmpresa.ObtenerListaVentas(); 
        }

        public List<ReporteVenta> ObtenerVentasAClientes(DateTime fecha1, DateTime fecha2, int codigoCliente)
        {
            return nuevaEmpresa.ObtenerListaVentasCliente(fecha1, fecha2, codigoCliente);
        }

        public List<GananciaMes> GananciaMeses(DateTime primerFecha, DateTime segundaFecha)
        {
            return nuevaEmpresa.ObtenerGanancia(primerFecha, segundaFecha); 

        }

        private void vENTASACLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.VentasAClientes ventas = new Reportes.VentasAClientes();
            ventas.Owner = this;
            ventas.ShowDialog(); 


        }

        private void gANANCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.GananciaMes reporte = new Reportes.GananciaMes();
            reporte.Owner = this;
            reporte.ShowDialog();
        }

        public void ModificacionVenta(Venta ventaModificada)
        {
            MessageBox.Show(nuevaEmpresa.ModificarVenta(ventaModificada).Mensaje);
            return;
        }
    }
}
