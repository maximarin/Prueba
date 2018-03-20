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

namespace Formularios
{
    public partial class AltaClientes : Form
    {
        public AltaClientes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (tbDireccion.Text != "" && tbLocalidad.Text != "" && tbMail.Text != "" && tbNombre.Text != "" && tbTelefono.Text !="")
            {
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.NombreApellido = tbNombre.Text;
                nuevoCliente.Localidad = tbLocalidad.Text;
                nuevoCliente.Telefono = tbTelefono.Text;
                nuevoCliente.FechaEliminacion = DateTime.MinValue;
                nuevoCliente.Mail = tbMail.Text;
                nuevoCliente.Direccion = tbDireccion.Text;

                IMetodos owner = this.Owner as IMetodos;
                owner.AltaCliente(nuevoCliente);
                this.Close();
            }
            else
            {
                MessageBox.Show("INGRESE CORRECTAMENTE LOS DATOS"); 
            }
     

        }
    }
}
