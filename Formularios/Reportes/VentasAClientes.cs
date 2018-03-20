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

namespace Formularios.Reportes
{
    public partial class VentasAClientes : Form
    {
        public VentasAClientes()
        {
            InitializeComponent();
        }

        private void VentasAClientes_Load(object sender, EventArgs e)
        {
            IMetodos owner = this.Owner as IMetodos;
            
            cbSeleccionarCliente.DataSource = owner.CargarClientesCB();
            cbSeleccionarCliente.DisplayMember = "Nombre" + "Apellido";

            cbSeleccionarCliente.ValueMember = "Codigo";

            AutoCompleteStringCollection listaString = new AutoCompleteStringCollection();

            foreach (var item in owner.CargarClientesCB())
            {
                cbSeleccionarCliente.AutoCompleteCustomSource.Add(item.NombreApellido);
            }


            cbSeleccionarCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSeleccionarCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnActualizarGrillaVentasCliente_Click(object sender, EventArgs e)
        {
         
            Cliente clienteSeleccionado = cbSeleccionarCliente.SelectedItem as Cliente;

            if (clienteSeleccionado.NombreApellido != "Seleccionar...")
            {
                
                IMetodos owner = this.Owner as IMetodos;
                gridVentasCliente.AutoGenerateColumns = true;
                gridVentasCliente.DataSource = owner.ObtenerVentasAClientes(Convert.ToDateTime(dtPrimerFecha.Text), Convert.ToDateTime(dtSegundaFecha.Text), clienteSeleccionado.Codigo);

                if (gridVentasCliente.DataSource == null)
                {
                    MessageBox.Show("NO SE REGISTRARON VENTAS ENTRE ESE PERÍODO DE TIEMPO");
                    gridVentasCliente.DataSource = "";
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE.");
            }
        }
    }
}
