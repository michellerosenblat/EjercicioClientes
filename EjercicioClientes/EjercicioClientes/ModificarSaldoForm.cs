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
    public partial class ModificarSaldoForm : Form
    {
        private ClienteServicio clienteServicio;
        private CuentaServicio cuentaServicio;
        private Cuenta cuentaSeleccionada;
        private Cliente clienteSeleccionado;
        public ModificarSaldoForm()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            cuentaServicio = new CuentaServicio();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ModificarSaldoForm_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = clienteServicio.TraerClientesConCuenta();
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            cmbClientes.SelectedIndex = -1;
            txtCuenta.Enabled = false;
            txtSaldoActual.Enabled = false;
            txtCuenta.Text = string.Empty;
            txtSaldoActual.Text = string.Empty;
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex != -1)
            {
               
                clienteSeleccionado = ((Cliente)cmbClientes.SelectedItem);
                cuentaSeleccionada = clienteSeleccionado.Cuenta;
                txtCuenta.Text = cuentaSeleccionada.ToString();
                txtSaldoActual.Text = cuentaSeleccionada.Saldo.ToString();
            }


        }
        private string Errores
        {
            get
            {
                return Validacion.ValidarNumero(txtSaldoAModificar.Text, "Saldo a modificar") +
                    Validacion.ValidarComboBox(cmbClientes.SelectedIndex, "Cliente");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Errores))
                {
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                }
               
                cuentaServicio.ActualizarSaldoDe(cuentaSeleccionada, int.Parse(txtSaldoAModificar.Text));
                MessageBox.Show("Se ha actualizado correctamente el saldo");
                MailServicio.EnviarMailA(clienteSeleccionado);
                LimpiarCampos();
            }
            catch (SaldoNegativoException saldoEx)
            {
                MessageBox.Show(saldoEx.Message);
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
    }
}
