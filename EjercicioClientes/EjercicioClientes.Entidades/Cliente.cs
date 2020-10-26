using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        private string nombre;
        [DataMember]
        private string apellido;
        [DataMember]
        private string direccion;
        [DataMember]
        private string email;
        [DataMember]
        private string telefono;
        [DataMember]
        private int dni;
        [DataMember]
        private int id;
        [DataMember]
        private DateTime fechaNacimiento;
        [DataMember]
        private bool activo;

        public Cliente ()
        {

        }
        public Cliente (string nombre, string apellido, string direccion, string email, string telefono, int dni, DateTime fechaNacimiento, bool activo)
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

        public Cliente (int id, string nombre, string apellido, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
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

        public string Telefono
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

        public override string ToString()
        {
            return nombre + " " + apellido + " " + direccion;
        }

        public override bool Equals(object obj)
        {
            return (obj != null && obj is Cliente && this.id == ((Cliente)obj).ID);

        }

    }
}
