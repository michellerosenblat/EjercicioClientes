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
    public partial class Menu : Form
    {
        private ClienteServicio cliente;
        private AltaClienteForm altaClienteForm;
        public Menu()
        {
            InitializeComponent();
            cliente = new ClienteServicio();
            altaClienteForm = new AltaClienteForm();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            altaClienteForm.Owner = this;
            altaClienteForm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listarClientes_Click(object sender, EventArgs e)
        {
            lstClientes.DataSource = cliente.TraerClientes();
        }
    }
}
