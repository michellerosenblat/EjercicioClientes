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
        private Cliente cliente;
        public AltaClienteForm()
        {
            InitializeComponent();
            servicio = new ClienteServicio();
            
        }
        public AltaClienteForm(Cliente cliente)
        {
            InitializeComponent();
            servicio = new ClienteServicio();
            this.cliente = cliente;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private string Errores
        {
            get
            {
                return (Validacion.ValidarString(txtNombre.Text, "Nombre") +
                        Validacion.ValidarString(txtApellido.Text, "Apellido") +
                        Validacion.ValidarString(txtDireccion.Text, "Dirección") +
                        Validacion.ValidarNumero(txtTelefono.Text, "Teléfono") +
                        Validacion.ValidarMail(txtEmail.Text));
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
                if (!string.IsNullOrEmpty(this.Errores))
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                if (cliente is null)
                {
                    servicio.InsertarCliente(CrearCliente(servicio.ProximoId()) );
                    MessageBox.Show("Se ha ingresado correctamente el cliente");
                }else
                {
                    servicio.Update(CrearCliente(cliente.ID));
                    MessageBox.Show("Se ha modificado correctamente el cliente");
                }
               
                BorrarCampos();
            }
            catch (ClienteExistenteException ex)
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
        private Cliente CrearCliente(int id)
        {
            return new Cliente(id, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
        }

        public void BorrarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void AltaClienteForm_Load(object sender, EventArgs e)
        {
            if (!(cliente is null))
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDireccion.Text = cliente.Direccion;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
