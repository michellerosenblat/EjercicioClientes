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
using EjercicioClientes.Entidades;
using EjercicioClientes.Entidades.Excepciones;

namespace EjercicioClientes
{
    public partial class AltaClienteForm : Form
    {
        ClienteServicio servicio;
        Menu menu;
        public AltaClienteForm()
        {
            InitializeComponent();
            servicio = new ClienteServicio();
            menu = new Menu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
             int id= servicio.ProximoId();
            List <Cliente> clientes = servicio.TraerClientes();
            Cliente cliente = new Cliente(id, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text);
                servicio.InsertarCliente(cliente);
            MessageBox.Show("Se dio de alta el cliente");
                BorrarCampos();
            }
            catch (ClienteExistenteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BorrarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void AltaClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
