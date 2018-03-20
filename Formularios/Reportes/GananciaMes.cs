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
    public partial class GananciaMes : Form
    {
        public GananciaMes()
        {
            InitializeComponent();
        }

        private void GananciaMes_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularGanancia_Click(object sender, EventArgs e)
        {

            if (Convert.ToDateTime(dtPrimerFechaPeriodo.Text) <= Convert.ToDateTime(dtSegundaFechaPeriodo.Text))
            {
                IMetodos ganancia = this.Owner as IMetodos;
                gridVentasPeriodo.AutoGenerateColumns = true;
                gridVentasPeriodo.DataSource = ganancia.GananciaMeses(Convert.ToDateTime(dtPrimerFechaPeriodo.Text), Convert.ToDateTime(dtSegundaFechaPeriodo.Text));
                if (gridVentasPeriodo.DataSource == null)
                {
                    gridVentasPeriodo.DataSource = "";
                }
            }
            else
            {
                MessageBox.Show("LA SEGUNDA FECHA DEBE SER MAYOR O IGUAL A LA PRIMERA");
            }
        }
    }
}
