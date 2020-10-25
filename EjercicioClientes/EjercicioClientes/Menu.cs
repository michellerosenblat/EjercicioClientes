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
        public Menu()
        {
            InitializeComponent();
            cliente = new ClienteServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
