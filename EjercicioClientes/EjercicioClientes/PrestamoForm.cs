using EjercicioClientes.Entidades.Entidades;
using EjercicioClientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClientes
{
    public partial class PrestamoForm : Form
    {
        private TipoPrestamoServicio tpservicio;
        private PrestamoServicio prestamoServ;
        private List<Prestamo> prestamos;
        public PrestamoForm()
        {
            InitializeComponent();
            tpservicio = new TipoPrestamoServicio();
            prestamoServ = new PrestamoServicio();
            //lstTipoPrestamos.ClearSelected();
            prestamos = new List<Prestamo>();
          
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

        private void PrestamoForm_Load(object sender, EventArgs e)
        {
            LimpiarSeleccion();
            ActualizarListaPrestamos();
            txtComision.Enabled = false;
        }

        private void ActualizarListaPrestamos()
        {
            prestamos = prestamoServ.GetPrestamos();
            lstPrestamos.DataSource = prestamos;
            txtComision.Text = Operador.CalcularComisionDe(prestamos).ToString();
        }

        private TipoPrestamo ObtenerTipoPrestamoSeleccionado()
        {
            return (TipoPrestamo)lstTipoPrestamos.SelectedItem;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarErrores();

                Prestamo simulacro = DevolverPrestamoSegunDatos();
                txtCapital.Text = (simulacro.CuotaCapital()).ToString();
                txtInteres.Text = simulacro.CuotaInteres().ToString();
                txtCuota.Text = simulacro.Cuota().ToString();

            }
            catch (FormatException fex)
            {

                MessageBox.Show(fex.Message);
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void VerificarErrores()
        {
            if (!string.IsNullOrEmpty(this.Errores))
                throw new FormatException("Error en los campos " + "\n" + this.Errores);
        }

        private void LimpiarSeleccion()
        {
            lstTipoPrestamos.DataSource = tpservicio.GetTipoPrestamo();
            lstTipoPrestamos.SelectedIndex = -1; // otra forma sería tener un item que sea value 0 o -1 y descripción --seleccione--

            txtTNA.Text = string.Empty;
            txtLinea.Text = string.Empty;

            txtMonto.Text = string.Empty;
            txtPlazo.Text = string.Empty;

            txtCapital.Text = string.Empty;
            txtCuota.Text = string.Empty;
            txtInteres.Text = string.Empty;

            txtTNA.Enabled = false;
            txtLinea.Enabled = false;

            txtMonto.Enabled = false;
            txtPlazo.Enabled = false;

            txtCapital.Enabled = false;
            txtCuota.Enabled = false;
            txtInteres.Enabled = false;
        }

        private void lstTipoPrestamos_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try { 
            VerificarErrores();
                Prestamo p = DevolverPrestamoSegunDatos();
            prestamoServ.InsertarPrestamo(p);
                MessageBox.Show("Se ha agregado correctamente el prestamo");
                LimpiarSeleccion();
                ActualizarListaPrestamos(); 
            }
            catch (FormatException fex)
            {

                MessageBox.Show(fex.Message);
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private Prestamo DevolverPrestamoSegunDatos()
        {
            return new Prestamo(ObtenerTipoPrestamoSeleccionado(), Convert.ToDouble(txtMonto.Text), Convert.ToInt32(txtPlazo.Text));
        }
    }
    }

