using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrAporteDenuncia
    {
        private String _fecha;
        private String _contenido;
        private String _calificacion;
        private String _nombreUsuario;
        private String _correoUsuario;
        private String _apellido1Usuario;
        private String _apellido2Usuario;
        private String _nombreProfesor;
        private String _apellido1Profesor;
        private String _apellido2Profesor;
        private String _correoProfesor;

        public StrAporteDenuncia(String fecha, String contenido, String calificacion, String nombreUsuario,
                                String correoUsuario, String apellido1Usuario, String apellido2Usuario, String correoProfesor,
                                    String nombreProfesor, String apellido1Profesor, String apellido2Profesor)
        {
            this._fecha = fecha;
            this._contenido = contenido;
            this._calificacion = calificacion;
            this._nombreUsuario = nombreUsuario;
            this._correoUsuario = correoUsuario;
            this._apellido1Usuario = apellido1Usuario;
            this._apellido2Usuario = apellido2Usuario;
            this._nombreProfesor = nombreProfesor;
            this._apellido1Profesor = apellido1Profesor;
            this._apellido2Profesor = apellido2Profesor;
            this._correoProfesor = correoProfesor;
        }


        public String Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        

        public String Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }
       

        public String Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }
        

        public String NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        
        public String CorreoUsuario
        {
            get { return _correoUsuario; }
            set { _correoUsuario = value; }
        }
        

        public String Apellido1Usuario
        {
            get { return _apellido1Usuario; }
            set { _apellido1Usuario = value; }
        }
        

        public String Apellido2Usuario
        {
            get { return _apellido2Usuario; }
            set { _apellido2Usuario = value; }
        }
       

        public String NombreProfesor
        {
            get { return _nombreProfesor; }
            set { _nombreProfesor = value; }
        }
        

        public String Apellido1Profesor
        {
            get { return _apellido1Profesor; }
            set { _apellido1Profesor = value; }
        }
        

        public String Apellido2Profesor
        {
            get { return _apellido2Profesor; }
            set { _apellido2Profesor = value; }
        }
        

        public String CorreoProfesor
        {
            get { return _correoProfesor; }
            set { _correoProfesor = value; }
        }



       

        



    }
}
