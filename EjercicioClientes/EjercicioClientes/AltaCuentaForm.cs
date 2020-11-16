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
        public AltaCuentaForm()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            cuentaServicio = new CuentaServicio();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
                if (!string.IsNullOrEmpty(this.Errores))
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                Cuenta cuenta = new Cuenta(cuentaServicio.ProximoIdCuenta(), txtDescripcion.Text, ((Cliente)cmbClientes.SelectedItem).ID);
                cuentaServicio.IngresarCuenta(cuenta);
                    MessageBox.Show("Se ingreso correctamente la cuenta");
                    BorrarCampos();
                }
            catch (CuentaExistenteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AltaCuentaForm_Load(object sender, EventArgs e)
        {
            //crear un servicio para traer solo los cliente sin cuentas
            cmbClientes.DataSource = clienteServicio.TraerClientes();
            BorrarCampos();
        }

        private string Errores
        {
            get
            {
                return (Validacion.ValidarString(txtDescripcion.Text, "Descripción de cuenta") +
                        Validacion.ValidarComboBox(cmbClientes.SelectedIndex, "Cliente"));
            }
        }

        public void BorrarCampos()
        {
            txtDescripcion.Clear();
            cmbClientes.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
