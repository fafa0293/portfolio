using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrUsuario
    {
        #region Atributos de la clase Usuario

        private String _nombre;
        private String _apellido1;
        private String _apellido2;
        private String _cedula;
        private String _carnet;
        private String _genero;
        private String _correo;
        private String _contrasenna;
        private String _fecha_nacimiento;
        private String _direccion;
        private String _telefono_fijo;
        private String _telefono_celular;
        private String _id_usuario;
   


        #endregion

        #region Propiedades de la clase Usuario

        public String Nombre
        {
            get{return _nombre;}
            set{_nombre = value;}
        }

        public String Apellido1
        {
            get{return _apellido1;}
            set{_apellido1 = value;}
        }

        public String Apellido2
        {
            get{return _apellido2;}
            set { _apellido2 = value;}
        }

        public String NombreCompleto
        {
            get { return String.Format("{0} {1} {2}", _nombre, _apellido1, _apellido2); }
        }

        public String Cedula
        {
            get{return _cedula;}
            set{_cedula = value;}
        }

        public String Carnet
        {
            get{return _carnet;}
            set{_carnet = value;}
        }

        public String Genero
        {
            get{return _genero;}
            set{_genero = value;}
        }

        public String Correo
        {
            get
            {return _correo;}
            set{_correo = value;}
        }

        public String Contrasenna
        {
            get{return _contrasenna;}
            set{_contrasenna = value;}
        }

        public String FechaNacimiento
        {
            get{return _fecha_nacimiento;}
            set{_fecha_nacimiento = value;}
        }

        public String Direccion
        {
            get{return _direccion;}
            set{_direccion  = value;}
        }

        public String TelefonoFijo
        {
            get{return _telefono_fijo;}
            set{_telefono_fijo = value;}
        }

        public String TelefonoCelular
        {
            get{return _telefono_celular;}
            set{_telefono_celular = value;}
        }
        public String idUsuario
        {
            get{return _id_usuario;}
            set{_id_usuario = value;}
        }
        #endregion

        #region Constructores

        public StrUsuario(String pid_usuario, String pnombre, String papellido1, String papellido2, String pcedula, String pcarnet, String pgenero, String pcorreo,
            String contrasenna, String pfecha_nacimiento, String pdireccion, String ptelefono_fijo, String ptelefono_celular)
        {
            _id_usuario = pid_usuario;
            _nombre = pnombre;
            _apellido1 = papellido1;
            _apellido2 = papellido2;
            _cedula = pcedula;
            _carnet = pcarnet;
            _genero = pgenero; 
            _correo = pcorreo;
            _fecha_nacimiento = pfecha_nacimiento;
            _direccion = pdireccion;
            _telefono_fijo = ptelefono_fijo;
            _telefono_celular = ptelefono_celular;
            _contrasenna = contrasenna;

        }
        
        #endregion
    }
}
