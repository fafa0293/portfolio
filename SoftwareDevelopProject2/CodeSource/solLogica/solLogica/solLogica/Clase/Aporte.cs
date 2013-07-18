using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Aporte
    {
        protected int _idAporte;
        protected int _idTema;
        protected int _idUsuario;
        protected String _fecha;
        protected String _contenido;
        protected int _calificación;
        protected Usuario _usuario;

        internal int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }


        internal int Calificación
        {
            get { return _calificación; }
            set { _calificación = value; }
        }

        protected internal Aporte(int idAporte, int idTema, int idUsuario,String fecha, String contenido, int cali)
        {
            IdAporte = idAporte;
            IdTema = idTema;
            IdUsuario = idUsuario;
            Fecha = fecha;
            Contenido = contenido;
            Calificación = cali;
        }

        internal int IdAporte
        {
            get { return _idAporte; }
            set { _idAporte = value; }
        }

        internal int IdTema
        {
            get { return _idTema; }
            set { _idTema = value; }
        }

        internal String Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        internal String Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }

        }

        internal Usuario Usuarios
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
    }
}
