using EjercicioClientes.Entidades;
using EjercicioClientes.Entidades.Entidades;
using EjercicioClientes.Entidades.Enum;
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
    public partial class AltaTarjetaCreditoForm : Form
    {
        ClienteServicio clienteServicio;
        private Cliente clienteSeleccionado;
        private Cuenta cuenta;
        public AltaTarjetaCreditoForm()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             
            clienteSeleccionado = ((Cliente)cmbCliente.SelectedItem);
            cuenta = clienteSeleccionado.Cuenta;
            switch ((int)cmbTipoTarjeta.SelectedItem)
            {

                case (int)TipoTarjetaEnum.Visa:
                    {

                        TCVisa visa = new TCVisa((int)cmbPeriodo.SelectedItem, cuenta.Saldo, TCServicio.ProximoNroTarjeta().ToString(), clienteSeleccionado.ID);
                        TCServicio.Insertar(visa);
                        MessageBox.Show("Se ha creado correctamente la tarjeta nro " + visa.NroPlastico);
                        break;
                    }
                case (int)TipoTarjetaEnum.Master:
                    {
                        TCMaster master = new TCMaster((int)cmbPeriodo.SelectedItem, cuenta.Saldo, TCServicio.ProximoNroTarjeta().ToString(), clienteSeleccionado.ID);
                        TCServicio.Insertar(master);
                        MessageBox.Show("Se ha creado correctamente la tarjeta nro " + master.NroPlastico);
                        break;
                    }
                case (int)TipoTarjetaEnum.Amex:
                    {
                        TCAmex amex = new TCAmex((int)cmbPeriodo.SelectedItem, cuenta.Saldo, TCServicio.ProximoNroTarjeta().ToString(), clienteSeleccionado.ID);
                        TCServicio.Insertar(amex);
                        MessageBox.Show("Se ha creado correctamente la tarjeta nro " + amex.NroPlastico);
                        break;
                    }

            
            }
            


        }

        private void AltaTarjetaCreditoForm_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = clienteServicio.TraerClientesConCuenta();
            cmbTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjetaEnum));
            cmbPeriodo.DataSource = Enum.GetValues(typeof(PeriodoVencimiento));
        }
        
    }
}
