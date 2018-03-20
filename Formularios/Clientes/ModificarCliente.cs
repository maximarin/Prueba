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
    public partial class ModificarCliente : Form
    {
        int codigo;
        public ModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            
            if (cliente != null)
            {

                tbNombre.Text = cliente.NombreApellido;
                tbLocalidad.Text = cliente.Localidad;
                tbMail.Text = cliente.Mail;
                tbTelefono.Text = cliente.Telefono;
                tbDireccion.Text = cliente.Direccion;
                codigo = cliente.Codigo;
            }
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {   

            if (tbTelefono.Text != "" && tbNombre.Text!="" && tbMail.Text!="" && tbLocalidad.Text !="" && tbDireccion.Text!="")
            {
                Cliente clienteModificado = new Cliente();
                clienteModificado.NombreApellido = tbNombre.Text;
                clienteModificado.Localidad = tbLocalidad.Text;
                clienteModificado.FechaEliminacion = DateTime.MinValue;
                clienteModificado.Mail = tbMail.Text;
                clienteModificado.Direccion = tbDireccion.Text;
                clienteModificado.Telefono = tbTelefono.Text;
                clienteModificado.Codigo = codigo;
                Cliente nuevo = new Cliente();
                nuevo = clienteModificado;
                
                IMetodos owner = this.Owner.Owner as IMetodos;
                owner.ModificacionCliente(clienteModificado);
                Close();



            }
            else
            {
                MessageBox.Show("INGRESE CORRECTAMENTE LOS DATOS"); 
            }
            

        }
    }
}
