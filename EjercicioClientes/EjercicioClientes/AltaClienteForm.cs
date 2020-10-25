using EjercicioClientes.Entidades;
using EjercicioClientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClientes
{
    public partial class AltaClienteForm : Form
    {
        ClienteServicio servicio;
        public AltaClienteForm()
        {
            InitializeComponent();
            servicio = new ClienteServicio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
            int id = servicio.InsertarCliente(cliente);
            MessageBox.Show("Se dio de alta el cliente con id " + id);
        }

        public void BorrarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
    }
}
