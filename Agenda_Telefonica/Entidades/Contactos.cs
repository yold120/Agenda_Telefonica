using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Clases
{
    public class Contacto
    {
        private int _codigo;
        private string _nombre;
        private string _apellidos;
        private string _direccion;
        private string _codigo_postal;
        private string _telefono_residencial;
        private string _telefono_celular;
        private string _email;
        private string _sexo;
        private string _direccion_de_trabajo;
        private string _fecha_de_nacimiento;
        private string _estado_civil;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Codigo_postal { get => _codigo_postal; set => _codigo_postal = value; }
        public string Telefono_residencial { get => _telefono_residencial; set => _telefono_residencial = value; }
        public string Telefono_celular { get => _telefono_celular; set => _telefono_celular = value; }
        public string Email { get => _email; set => _email = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Direccion_de_trabajo { get => _direccion_de_trabajo; set => _direccion_de_trabajo = value; }
        public string Fecha_de_nacimiento { get => _fecha_de_nacimiento; set => _fecha_de_nacimiento = value; }
        public string Estado_civil { get => _estado_civil; set => _estado_civil = value; }

        public Contacto()
        {
        }

        public Contacto
            (
        int codigo
        ,string nombre 
        ,string apellidos 
        ,string direccion 
        ,string codigoPostal
        ,string telefonoResidencial
        ,string telefonoCelular
        ,string email
        ,string sexo
        ,string direccionDeTrabajo
        ,string fechaDeNacimiento
        ,string estadoCivil           
            
            )
        {
  
            this._codigo = codigo;
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._direccion = direccion;
            this._codigo_postal = codigoPostal;
            this._telefono_residencial = telefonoResidencial;
            this._telefono_celular = telefonoCelular;
            this._email = email;
            this._sexo = sexo;
            this._direccion_de_trabajo = direccionDeTrabajo;
            this._fecha_de_nacimiento = fechaDeNacimiento;
            this._estado_civil = estadoCivil;




        }
    }
}
