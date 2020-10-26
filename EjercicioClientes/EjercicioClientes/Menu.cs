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
        private CuentaServicio cuenta;
        private AltaClienteForm altaClienteForm;
        private AltaCuentaForm altaCuentaForm;
        public Menu()
        {
            InitializeComponent();
            cliente = new ClienteServicio();
            cuenta = new CuentaServicio();
            altaClienteForm = new AltaClienteForm();
            altaCuentaForm = new AltaCuentaForm();
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

        private void button2_Click(object sender, EventArgs e)
        {
            lstCuentas.DataSource = cuenta.TraerCuentas();
        }

        private void btnAltaCuenta_Click(object sender, EventArgs e)
        {
            altaCuentaForm.Owner = this;
            altaCuentaForm.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
