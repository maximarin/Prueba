using Lógicaa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Ventas
{
    public partial class Facturación : Form
    {
        private Button botonImprimir = new Button();
        public Facturación(Venta ventaImprimir)
        {
            InitializeComponent();

            tbDireccionCliente.Text = ventaImprimir.DireccionClienteAsociado;
            tbNombreCliente.Text = ventaImprimir.NombreClienteAsociado; 
            tbSubTotal.Text = Convert.ToString(ventaImprimir.SubTotal);
            tbTotal.Text = Convert.ToString(ventaImprimir.Total);
            tbDescuento.Text = Convert.ToString(ventaImprimir.Descuento) + "" + "%";
            tbFechaVenta.Text = Convert.ToString(ventaImprimir.Fecha);
            tbNumeroFactura.Text = Convert.ToString(ventaImprimir.Codigo);
            tbDireccionCliente.Text = ventaImprimir.DireccionClienteAsociado;
            tbLocalidadCliente.Text = ventaImprimir.LocalidadCliente;
            tbTelefonoCliente.Text = Convert.ToString(ventaImprimir.TelefonoCliente);

            DataTable tabla = new DataTable();

            tabla.Columns.Add("Nombre Producto");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Precio Unitario");
            tabla.Columns.Add("Importe Total");



            for (int i = 0; i < ventaImprimir.ListaProductos.Count; i++)
            {
                DataRow fila = tabla.NewRow();

                fila[0] = ventaImprimir.ListaProductos[i];
                fila[1] = ventaImprimir.ListaCantidadProductos[i];
                fila[2] = ventaImprimir.ListaPreciosUnitarios[i];
                fila[3] = ventaImprimir.ListaPreciosTotales[i];
               
                tabla.Rows.Add(fila);
            }


            gridVenta.DataSource = tabla;
            gridVenta.Columns[0].Width = 200;
        }
        Bitmap imagen; 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button1);

            CapturarPantalla();

        }

   


        private void CapturarPantalla()
        {
          
            Graphics g = this.CreateGraphics();
            Size s = this.Size;
            imagen = new Bitmap(s.Width, s.Height, g);
            Graphics g2 = Graphics.FromImage(imagen);
            g2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialog1.ShowDialog();
        }

        private void Facturación_Load(object sender, EventArgs e)
        {
            tbVendedor.Text = "Mariano Aviazzi";
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(imagen, 0, 0);
        }
    }
}
