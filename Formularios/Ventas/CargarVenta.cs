using Lógicaa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Ventas
{
    public partial class CargarVenta : Form
    {
        public CargarVenta()
        {
            InitializeComponent();
        }

        List<string> Productos = new List<string>();
        List<int> Cantidades = new List<int>();
        List<double> PreciosUnitarios = new List<double>();
        List<double> ImportesTotales = new List<double>(); 


        private void CargarVenta_Load(object sender, EventArgs e)
        {
            IMetodos owner = this.Owner as IMetodos;
            tbDescuento.Text = "0";
            cbSeleccionarClienteVenta.DataSource = owner.CargarClientesCB();
            cbSeleccionarClienteVenta.DisplayMember = "Nombre" + "Apellido";

            cbSeleccionarClienteVenta.ValueMember = "Codigo";

            AutoCompleteStringCollection listaString = new AutoCompleteStringCollection();

            foreach (var item in owner.CargarClientesCB())
            {
                cbSeleccionarClienteVenta.AutoCompleteCustomSource.Add(item.NombreApellido);
            }


            cbSeleccionarClienteVenta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSeleccionarClienteVenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnAgregarProductoVenta_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "" && tbTotal.Text != "" && tbNombre.Text !="" && tbUnitario.Text !="" && tbDescuento.Text !="")
            {
                Productos.Add(tbNombre.Text);
                Cantidades.Add(Convert.ToInt32(tbCantidad.Text));
                PreciosUnitarios.Add(Convert.ToDouble(tbUnitario.Text));
                ImportesTotales.Add(Convert.ToDouble(tbTotal.Text));

                DataTable tabla = new DataTable();
                tabla.Columns.Add("Nombre Producto");
                tabla.Columns.Add("Cantidad a comprar");
                tabla.Columns.Add("Precio Unitario");
                tabla.Columns.Add("Importe Total");

                double total = 0;
                for (int i = 0; i < Productos.Count; i++)
                {
                    DataRow fila = tabla.NewRow();
                    fila[0] = Productos[i];
                    fila[1] = Cantidades[i];
                    fila[2] = PreciosUnitarios[i];
                    fila[3] = ImportesTotales[i];
                    tabla.Rows.Add(fila);
                    total = total + Convert.ToDouble(ImportesTotales[i]);


                }

                tbSubTotalVenta.Text = Convert.ToString(total);
                gridVenta.DataSource = tabla;
                gridVenta.Columns[0].Width = 300;
                tbTotal.Text = "";
                tbNombre.Text = "";
                tbUnitario.Text = "";
                tbCantidad.Text = ""; 

            }
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {   
            if (gridVenta.DataSource != null)
            {
                Cliente clienteSeleccionado = cbSeleccionarClienteVenta.SelectedItem as Cliente;
                Venta nuevaVenta = new Venta();
                nuevaVenta.ListaProductos = Productos;
                nuevaVenta.ListaPreciosUnitarios = PreciosUnitarios;
                nuevaVenta.ListaPreciosTotales = ImportesTotales;
                nuevaVenta.SubTotal = Convert.ToDouble(tbSubTotalVenta.Text);
                nuevaVenta.Descuento = Convert.ToDouble(tbDescuento.Text);
                nuevaVenta.NombreClienteAsociado = clienteSeleccionado.NombreApellido;
                nuevaVenta.DireccionClienteAsociado = clienteSeleccionado.Direccion;
                nuevaVenta.TelefonoCliente = clienteSeleccionado.Telefono;
                nuevaVenta.LocalidadCliente = clienteSeleccionado.Localidad;
                nuevaVenta.Fecha = DateTime.Now;
                nuevaVenta.ListaCantidadProductos = Cantidades; 

                if (nuevaVenta.Descuento != 0)
                {
                    nuevaVenta.Total = nuevaVenta.SubTotal - ((nuevaVenta.SubTotal * nuevaVenta.Descuento) / 100);
                }
                else
                {
                    nuevaVenta.Total = nuevaVenta.SubTotal; 
                }

                IMetodos owner = this.Owner as IMetodos;
                owner.AltaVenta(nuevaVenta);
                this.Close();
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR LOS DATOS DE LA VENTA");
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
