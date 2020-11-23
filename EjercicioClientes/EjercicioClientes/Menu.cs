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

        public Menu()
        {
            InitializeComponent();
            cliente = new ClienteServicio();
            cuenta = new CuentaServicio();
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
            AltaCuentaForm altaCuentaForm = new AltaCuentaForm();
            altaCuentaForm.Owner = this;
            altaCuentaForm.Show();
            this.Hide();
        }


        private void Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            PrestamoForm prestamosForm = new PrestamoForm();
            prestamosForm.Owner = this;
            prestamosForm.Show();
            this.Hide();
        }

        private void btnModificarSaldo_Click(object sender, EventArgs e)
        {
            ModificarSaldoForm modificarSaldo = new ModificarSaldoForm();
            modificarSaldo.Owner = this;
            modificarSaldo.Show();
            this.Hide();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
            {
                Cliente cliente = (Cliente)lstClientes.SelectedItem;
                altaClienteForm = new AltaClienteForm(cliente);
                altaClienteForm.Owner = this;
                altaClienteForm.Show();
                this.Hide();
            }
            
        }

        private void altaClientes_Click(object sender, EventArgs e)
        {
            altaClienteForm = new AltaClienteForm();
            altaClienteForm.Owner = this;
            altaClienteForm.Show();
            this.Hide();
        }

        private void altaClientes_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            lstClientes.DataSource = cliente.TraerClientes();
        }

        private void btnTarjtaCredito_Click(object sender, EventArgs e)
        {
            AltaTarjetaCreditoForm altaTarjeta = new AltaTarjetaCreditoForm();
            altaTarjeta.Owner = this;
            altaTarjeta.Show();
            this.Hide();
        }
    }
}
