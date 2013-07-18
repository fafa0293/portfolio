using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrAporte
    {
        private String _idAporte;
        private String _idTema;
        private String _idUsuario;
        private String _fecha;
        private String _contenido;
        private String _calificacion;
        private String _nomUsuario;

        public StrAporte(String idAporte, String idTema, String idUsuario, String fecha, String contenido, String calificación,String nomUsuarios)
        {
            _idAporte = idAporte;
            _idTema = idTema;
            _idUsuario = idUsuario;
            _fecha = fecha;
            _contenido = contenido;
            _nomUsuario = nomUsuarios;
            _calificacion = calificación;
        }

        




        public String IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        

        public String IdAporte
        {
            get { return _idAporte; }
            set { _idAporte = value; }
        }

        public String IdTema
        {
            get { return _idTema; }
            set { _idTema = value; }
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

        public String NomUsuario
        {
            get { return _nomUsuario; }
            set { _nomUsuario = value; }
        }

        public String Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }
    }
}
