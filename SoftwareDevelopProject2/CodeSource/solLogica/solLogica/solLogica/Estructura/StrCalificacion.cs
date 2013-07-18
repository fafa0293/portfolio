using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrCalificacion
    {
        private String _idCalificacion;
        private String _idUsuario;
        private String _idEntrada;
        private String _calificacion;

        public StrCalificacion(String pidCalificacion, String pidUsuario, String pidEntrada, String pcalificacion)
        {
            _idCalificacion = pidCalificacion;
            _idUsuario = pidUsuario;
            _idEntrada = pidEntrada;
            _calificacion = pcalificacion;
        }

        public String IdCalificacion
        {
            get { return _idCalificacion; }
            set { _idCalificacion = value; }
        }

        public String IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public String IdEntrada
        {
            get { return _idEntrada; }
            set { _idEntrada = value; }
        }

        public String Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }

    }
}
