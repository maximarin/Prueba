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

namespace Formularios.Clientes
{
    public partial class GrillaClientes : Form
    {
        public GrillaClientes()
        {
            InitializeComponent();
        }

        private void GrillaClientes_Load(object sender, EventArgs e)
        {
            AgregarClientesComboBox();

            DataGridViewLinkColumn Editar = new DataGridViewLinkColumn();
            Editar.HeaderText = "Edicion";
            Editar.Text = "Editar";
            Editar.UseColumnTextForLinkValue = true;
            gridClientes.Columns.Add(Editar);

            DataGridViewLinkColumn Eliminar = new DataGridViewLinkColumn();
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForLinkValue = true;
            gridClientes.Columns.Add(Eliminar);
            gridClientes.Columns[0].Width = 200;


        }



        private void AgregarClientesComboBox()
        {
            IMetodos owner = this.Owner as IMetodos;

            cbClientes.DataSource = owner.CargarClientesCB();
            cbClientes.DisplayMember = "NombreApellido";
            cbClientes.ValueMember = "Codigo";

            AutoCompleteStringCollection listaString = new AutoCompleteStringCollection();

            foreach (var item in owner.CargarClientesCB())
            {
                listaString.Add(item.NombreApellido);
            }

            cbClientes.AutoCompleteCustomSource = listaString;
            cbClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbClientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }



        private void ActualizarGrilla()
        {
            IMetodos owner = this.Owner as IMetodos;
            Cliente clienteSeleccionado = cbClientes.SelectedItem as Cliente;

            gridClientes.AutoGenerateColumns = true;
            gridClientes.DataSource = owner.ObtenerCliente1(clienteSeleccionado.Codigo);

            if (gridClientes.DataSource != null)
            {
                gridClientes.Columns.Remove("FechaEliminacion");

            }

            else
            {
                gridClientes.DataSource = "";
            }

        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrilla(); 
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
                var column = gridClientes.Columns[e.ColumnIndex];
                var row = gridClientes.Rows[e.RowIndex];

                if (column.HeaderText == "Eliminar")
                {
                    var mensaje = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.OKCancel);

                    if (mensaje == DialogResult.OK)
                    {
                        Cliente clienteSeleccionado = row.DataBoundItem as Cliente;
                        IMetodos owner = this.Owner as IMetodos;
                        owner.BajaCLiente(clienteSeleccionado.Codigo);
                        ActualizarGrilla();
                        AgregarClientesComboBox();

                    }
                }
                else
                {
                    if (column.HeaderText == "Edicion")
                    {
                        Cliente clienteSeleccionado = row.DataBoundItem as Cliente;
                        ModificarCliente nuevaModificacion = new ModificarCliente(clienteSeleccionado);
                        nuevaModificacion.Owner = this;
                        nuevaModificacion.Show();


                    }
                }
            
        }
    }
}
