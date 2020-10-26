using EjercicioClientes.Entidades;
using EjercicioClientes.Entidades.Excepciones;
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
    public partial class AltaCuentaForm : Form
    {
        private ClienteServicio clienteServicio;
        private CuentaServicio cuentaServicio;
        private Menu menu;
        public AltaCuentaForm()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            cuentaServicio = new CuentaServicio();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idCliente = Validacion.EsInt(txtIdCliente.Text);
            if (clienteServicio.TraerClientesPorId(idCliente) != null)
            {
                try { 
                Cuenta cuenta = new Cuenta(cuentaServicio.ProximoIdCuenta(), txtDescripcion.Text, idCliente, cuentaServicio.ProximoId());
                cuentaServicio.IngresarCuenta(cuenta);
                    MessageBox.Show("Se ingreso correctamente la cuenta");
                    BorrarCampos();
                }
                catch (CuentaExistenteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AltaCuentaForm_Load(object sender, EventArgs e)
        {
            menu = new Menu();
        }

        public void BorrarCampos()
        {
            txtDescripcion.Clear();
            txtIdCliente.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
