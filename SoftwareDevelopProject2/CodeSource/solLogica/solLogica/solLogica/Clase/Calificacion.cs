using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Calificacion
    {
        private int _idCalificacion;
        private int _idUsuario;
        private int _idEntrada;
        private int _calificacionDada;

        protected internal Calificacion(int pidUsuario,int pidEntrada, int pcalificacion)
        {
            IdUsuario = pidUsuario;
            IdEntrada = pidEntrada;
            CalificacionDada = pcalificacion;
        }

        internal int IdCalificacion
        {
            get { return _idCalificacion; }
            set { _idCalificacion = value; }
        }

        internal int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        internal int IdEntrada
        {
            get { return _idEntrada; }
            set { _idEntrada = value; }
        }

        internal int CalificacionDada
        {
            get { return _calificacionDada; }
            set { _calificacionDada = value; }
        }

    }
}
