using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Usuario
    {
        #region Atributos de la clase Usuario

        protected String _nombre;
        protected String _apellido1;
        protected String _apellido2;
        protected String _cedula;
        protected String _carnet;
        protected Char _genero;
        protected String _correo;
        protected String _contrasenna;
        protected DateTime _fechaNacimiento;
        protected String _direccion;
        protected String _telefonoFijo;
        protected String _telefonoCelular;
        protected int _idUsuario;


        #endregion

        #region Propiedades de la clase Usuario

        internal String Nombre
        {
            get
            {
                return _nombre;
            }
            set 
            {
                _nombre = value;
            }
        }

        internal String Apellido1
        {
            get
            {
                return _apellido1 ;
            }
            set
            {
                _apellido1 = value;
            }
        }

        internal String Apellido2
        {
            get
            {
                return _apellido2;
            }
            set
            {
                _apellido2 = value;
            }
        }

        internal String Cedula
        {
            get
            {
                return _cedula;
            }
            set
            {
                _cedula = value;
            }
        }

        internal String Carnet
        {
            get
            {
                return _carnet;
            }
            set
            {
                _carnet = value;
            }
        }

        internal Char Genero
        {
            get
            {
                return _genero;
            }
            set
            {
                _genero = value;
            }
        }

        internal String Correo
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
            }
        }

        internal String Contrasenna
        {
            get
            {
                return _contrasenna;
            }
            set
            {
                _contrasenna = value;
            }
        }

        internal DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        internal String Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion  = value;
            }
        }

        internal String TelefonoFijo
        {
            get
            {
                return _telefonoFijo;
            }
            set
            {
                _telefonoFijo = value;
            }
        }

        internal String TelefonoCelular
        {
            get
            {
                return _telefonoCelular;
            }
            set
            {
                _telefonoCelular = value;
            }
        }
        internal int IdUsuario
        {
            get
            {
                return _idUsuario;
            }
            set
            {
                _idUsuario = value;
            }
        }
        #endregion

        #region Constructores
        ///<summary>
        ///constructor con todos los 13 parametros
        ///</summary>
        ///<param name="pnombre">Nombre del Usuario, tipo String</param>
        ///<param name="papellido1">Primer Apellido del Usuario, tipo String</param>
        ///<param name="papellido2">Segundo Apellido del Usuario, tipo String</param>
        ///<param name="pcedula">Cedula del USuario, tipo String</param>
        ///<param name="pcarnet">Carnet del Usuario, tipo String</param>
        ///<param name="pgenero">Genero del Usuario, tipo Char</param>
        ///<param name="pcorreo">Correo del Usuario, tipo String</param>
        ///<param name="pcontrasenna">Contrasenna del Usuario, tipo String</param>
        ///<param name="pfecha_nacimiento">Fecha de Nacimiento del Usuario, tipo DateTime</param>
        ///<param name="pdireccion">Direccion del Usuario, tipo String</param>
        ///<param name="ptelefono_fijo">Telefono fijo del Usuario, tipo String</param>
        ///<param name="ptelefono_celular">Telefono celular del Usuario, tipo String</param>
        ///<param name="pid_usuario">Rol del Usuario, tipo String</param>
        ///<remarks>
        ///Autor: Christopher Vargas
        ///</remarks>
        protected internal Usuario(String nombre, String apellido1, String apellido2, String cedula, String carnet, Char genero, String correo,
            String contrasenna, DateTime fechaNacimiento, String direccion, String telefonoFijo,
            String telefonoCelular, int idUsuario)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Cedula = cedula;
            Carnet = carnet;
            Genero = genero;
            Correo = correo;
            Contrasenna = contrasenna;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            TelefonoFijo = telefonoFijo;
            TelefonoCelular = telefonoCelular;
            IdUsuario = idUsuario;
        }

        // 12 parametros
        // metodo sin id para la creacion del usuario
        protected internal Usuario(String nombre, String apellido1, String apellido2, String cedula, String carnet, Char genero, String correo,
            String contrasenna, DateTime fechaNacimiento, String direccion, String telefonoFijo,
            String telefonoCelular) : this(nombre, apellido1, apellido2, cedula, carnet, genero, correo, contrasenna, fechaNacimiento, direccion, telefonoFijo, telefonoCelular, -1)
        {
        }

        //13 Parametros
        //Metodo creado para la busqueda de los usuarios
        protected internal Usuario(int idUsuario, String nombre, String apellido1, String apellido2, String cedula, String carnet, Char genero, String correo,
            String contrasenna, DateTime fechaNacimiento, String direccion, String telefonoFijo,
            String telefonoCelular)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Cedula = cedula;
            Carnet = carnet;
            Genero = genero;
            Correo = correo;
            Contrasenna = contrasenna;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            TelefonoFijo = telefonoFijo;
            TelefonoCelular = telefonoCelular;
        }
        #endregion
    }
}
