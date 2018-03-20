using Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lógicaa
{
    public partial class IngresoAlSistema : Form
    {
        public IngresoAlSistema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Marianoaviazzi" && tbContraseña.Text == "40556794")
            {
                PantallaPrincipal nuevaPantalla = new PantallaPrincipal();
                nuevaPantalla.Owner = this;
               
                nuevaPantalla.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("ASEGÚRESE DE INGRESAR CORRECTAMENTE LOS DATOS");
            }
        }
    }
}
