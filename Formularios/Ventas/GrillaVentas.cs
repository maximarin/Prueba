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
    public partial class GrillaVentas : Form
    {
        public GrillaVentas()
        {
            InitializeComponent();
        }

        private void GrillaVentas_Load(object sender, EventArgs e)
        {
            IMetodos owner = this.Owner as IMetodos;
            DataGridViewLinkColumn Imprimir = new DataGridViewLinkColumn();
            Imprimir.HeaderText = "Impresión";
            Imprimir.Text = "Imprimir";
            Imprimir.UseColumnTextForLinkValue = true;
            gridGrillaVentas.Columns.Add(Imprimir);

            DataGridViewLinkColumn Editar = new DataGridViewLinkColumn();
            Editar.HeaderText = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForLinkValue = true;
            gridGrillaVentas.Columns.Add(Editar); 

            gridGrillaVentas.AutoGenerateColumns = true;
            gridGrillaVentas.DataSource = owner.ObtenerVentas();

            if (gridGrillaVentas.DataSource == null)
            {
                gridGrillaVentas.DataSource = "";
            }
            else
            {
                gridGrillaVentas.Columns[2].HeaderText = "Cliente";
                gridGrillaVentas.Columns[3].HeaderText = "Dirección";
                gridGrillaVentas.Columns[4].HeaderText = "Localidad";
                gridGrillaVentas.Columns[5].HeaderText = "Teléfono"; 
                


            }



        }

        private void gridGrillaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = gridGrillaVentas.Columns[e.ColumnIndex];
            var row = gridGrillaVentas.Rows[e.RowIndex];

            if (column.HeaderText == "Impresión")
            {
                Venta ventaSeleccionada = row.DataBoundItem as Venta;

                Facturación nuevaFactura = new Facturación(ventaSeleccionada);
                nuevaFactura.Owner = this;
                nuevaFactura.ShowDialog();

            }
            else
            {
                if (column.HeaderText == "Editar")
                {
                    Venta ventaSeleccionada = row.DataBoundItem as Venta;
                    ModificarVenta owner = new ModificarVenta(ventaSeleccionada);
                    owner.Owner = this;
                    owner.ShowDialog();



                }
            }
        }
    }
}
