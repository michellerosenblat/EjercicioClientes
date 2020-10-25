using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private string email;
        private int telefono;
        private int dni;
        private int id;
        private DateTime fechaNacimiento;
        private bool activo;

        public Cliente (string nombre, string apellido, string direccion, string email, int telefono, int dni, DateTime fechaNacimiento, bool activo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.activo = activo;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }
        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public int ProximoID()
        {
            return id + 1;
        }


    }
}
