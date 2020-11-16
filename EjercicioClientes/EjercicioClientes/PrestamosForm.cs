using EjercicioClientes.Entidades.Entidades;
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
    public partial class PrestamosForm : Form
    {
        private TipoPrestamoServicio tpservicio;
        public PrestamosForm()
        {
            InitializeComponent();
            tpservicio = new TipoPrestamoServicio();
            lstTipoPrestamos.ClearSelected();
        }
        public string Errores
        {
            get
            {
                return (Validacion.ValidarNumero(txtMonto.Text, "Monto") +
                        Validacion.ValidarNumero(txtPlazo.Text, "Plazo") +
                        (lstTipoPrestamos.SelectedIndex == -1 ? "Debe seleccionar un tipo préstamo\n" : string.Empty));
            }
        }

        private void PrestamosForm_Load(object sender, EventArgs e)
        {
            LimpiarSeleccion();
        }
        private TipoPrestamo ObtenerTipoPrestamoSeleccionado()
        {
            return (TipoPrestamo)lstTipoPrestamos.SelectedItem;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Errores))
                    throw new FormatException("Error en los campos " + "\n" + this.Errores);

                Prestamo simulacro = new Prestamo(ObtenerTipoPrestamoSeleccionado(), Convert.ToDouble(txtMonto.Text), Convert.ToInt32(txtPlazo.Text));
                txtCapital.Text = (simulacro.CuotaCapital()).ToString();
                txtInteres.Text = simulacro.CuotaInteres().ToString();
                txtCuota.Text = simulacro.Cuota().ToString();

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

        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPrestamo tp = ObtenerTipoPrestamoSeleccionado();
            if (tp != null)
            {
                txtLinea.Text = tp.Linea;
                txtTNA.Text = tp.TNA.ToString();
                txtMonto.Enabled = true;
                txtPlazo.Enabled = true;
            }
        }
        private void LimpiarSeleccion()
        {
            lstTipoPrestamos.DataSource = tpservicio.GetTipoPrestamo();
            lstTipoPrestamos.SelectedIndex = -1; // otra forma sería tener un item que sea value 0 o -1 y descripción --seleccione--

            txtTNA.Text = string.Empty;
            txtLinea.Text = string.Empty;

            txtMonto.Text = string.Empty;
            txtPlazo.Text = string.Empty;

            txtTNA.Enabled = false;
            txtLinea.Enabled = false;

            txtMonto.Enabled = false;
            txtPlazo.Enabled = false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
           
        }
    }
}
