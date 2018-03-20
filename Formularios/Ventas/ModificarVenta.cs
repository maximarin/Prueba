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
    public partial class ModificarVenta : Form

    {
        int codigo;
        List<string> Productos = new List<string>();
        List<int> Cantidades = new List<int>();
        List<double> PreciosUnitarios = new List<double>();
        List<double> ImportesTotales = new List<double>();
        public ModificarVenta(Venta ventaModificar)
        {
            InitializeComponent();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Nombre Producto");
            tabla.Columns.Add("Cantidad a comprar");
            tabla.Columns.Add("Precio Unitario");
            tabla.Columns.Add("Importe Total");

            double total = 0;
            for (int i = 0; i < ventaModificar.ListaProductos.Count; i++)
            {
                DataRow fila = tabla.NewRow();
                fila[0] = ventaModificar.ListaProductos[i];
                fila[1] = ventaModificar.ListaCantidadProductos[i];
                fila[2] = ventaModificar.ListaPreciosUnitarios[i];
                fila[3] = ventaModificar.ListaPreciosTotales[i];
                tabla.Rows.Add(fila);
                total = total + Convert.ToDouble(ventaModificar.ListaPreciosTotales[i]);
                Productos.Add(ventaModificar.ListaProductos[i]);
                Cantidades.Add(ventaModificar.ListaCantidadProductos[i]);
                PreciosUnitarios.Add(ventaModificar.ListaPreciosUnitarios[i]);
                ImportesTotales.Add(ventaModificar.ListaPreciosTotales[i]);
            }


            gridVenta.DataSource = tabla;
            gridVenta.Columns[0].Width = 300;
            tbTotal.Text = "";
            tbNombre.Text = "";
            tbUnitario.Text = "";
            tbCantidad.Text = "";
            tbDescuento.Text = Convert.ToString(ventaModificar.Descuento);
            tbSubTotalVenta.Text = Convert.ToString(ventaModificar.SubTotal);
            cbSeleccionarClienteVenta.Text = ventaModificar.NombreClienteAsociado;
            codigo = ventaModificar.Codigo;

        }

        private void ModificarVenta_Load(object sender, EventArgs e)
        {
            IMetodos owner = this.Owner.Owner as IMetodos;
       
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

        private void btnCargarVenta_Click(object sender, EventArgs e)

        {
            Cliente clienteSeleccionado = cbSeleccionarClienteVenta.SelectedItem as Cliente;
            Venta ventaModificada = new Venta();
            ventaModificada.NombreClienteAsociado = cbSeleccionarClienteVenta.Text;
            ventaModificada.DireccionClienteAsociado = clienteSeleccionado.Direccion;
            ventaModificada.TelefonoCliente = clienteSeleccionado.Telefono;
            ventaModificada.LocalidadCliente = clienteSeleccionado.Localidad;
            ventaModificada.Descuento = Convert.ToDouble(tbDescuento.Text);
            ventaModificada.Codigo = codigo;
            ventaModificada.SubTotal = Convert.ToDouble(tbSubTotalVenta.Text);

            string nombre;
            List<string> Productos1 = new List<string>();
            List<int> Cantidades1 = new List<int>();
            List<double> PreciosUnitarios1 = new List<double>();
            List<double> ImportesTotales1 = new List<double>();

            for (int i = 0; i < gridVenta.RowCount-1; i++)
            {   
                nombre = Convert.ToString(gridVenta[0, i].Value);
                Productos1.Add ( nombre) ;
                Cantidades1.Add ( Convert.ToInt32(gridVenta[1, i].Value));
                PreciosUnitarios1.Add( Convert.ToDouble(gridVenta[2, i].Value));
                ImportesTotales1.Add( Convert.ToDouble(gridVenta[3, i].Value));
                


            }

            ventaModificada.ListaCantidadProductos = Cantidades1;
            ventaModificada.ListaPreciosTotales = ImportesTotales1;
            ventaModificada.ListaPreciosUnitarios = PreciosUnitarios1;
            ventaModificada.ListaProductos = Productos1;

            if (ventaModificada.Descuento != 0)
            {
                ventaModificada.Total = ventaModificada.SubTotal - ((ventaModificada.SubTotal * ventaModificada.Descuento) / 100);
            }
            else
            {
                ventaModificada.Total = ventaModificada.SubTotal;
            }

            IMetodos owner = this.Owner.Owner as IMetodos;
            owner.ModificacionVenta(ventaModificada);


        }

        private void btnAgregarProductoVenta_Click(object sender, EventArgs e)
        {
            if (tbCantidad.Text != "" && tbTotal.Text != "" && tbNombre.Text != "" && tbUnitario.Text != "" && tbDescuento.Text != "")
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
    }
}
