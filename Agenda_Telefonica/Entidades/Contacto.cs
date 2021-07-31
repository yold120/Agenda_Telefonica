using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Entidades
{
    public class Contacto
    {

        private int _codigo;
        private string _nombre;
        private string _apellidos;
        private string _direccion;
        private string _codigopostal;
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _sexo;
        private string _direcciondetrabajo;
        private string _fechadenacimiento;
        private string _estadocivil;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Codigopostal
        {
            get { return _codigopostal; }
            set { _codigopostal = value; }
        }

        public string Telefonoresidencial
        {
            get { return _telefonoresidencial; }
            set { _telefonoresidencial = value; }
        }

        public string Telefonocelular
        {
            get { return _telefonocelular; }
            set { _telefonocelular = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Direcciondetrabajo
        {
            get { return _direcciondetrabajo; }
            set { _direcciondetrabajo = value; }
        }

        public string Fechadenacimiento
        {
            get { return _fechadenacimiento; }
            set { _fechadenacimiento = value; }
        }

        public string Estadocivil
        {
            get { return _estadocivil; }
            set { _estadocivil = value; }
        }

        

        public Contacto()
        {
        }

        public Contacto
            (
             int     codigo
            , string nombre
            , string apellidos
            , string direccion
            , string codigopostal
            , string telefonoresidencial
            , string telefonocelular
            , string email
            , string sexo
            , string direcciondetrabajo
            , string fechadenacimiento
            , string estadocivil
            )
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._direccion = direccion;
            this._codigopostal = codigopostal;
            this._telefonoresidencial = telefonoresidencial;
            this._telefonocelular = telefonocelular;
            this._email = email;
            this._sexo = sexo;
            this._direcciondetrabajo = direcciondetrabajo;
            this._fechadenacimiento = fechadenacimiento;
            this._estadocivil = estadocivil;

        }
    }
}
