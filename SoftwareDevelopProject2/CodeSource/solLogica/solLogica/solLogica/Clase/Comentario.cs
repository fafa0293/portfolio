using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    class Comentario
    {
        protected int _idComentario;
        protected int _idUsuario;
        protected int _idAporte;
        protected int _idEntrada;
        protected DateTime _fecha;
        protected String _contenido;

        /// <summary>
        /// Constrcutor con todos los parametros
        /// </summary>
        /// <param name="idCometario"></param>
        /// <param name="idUsuario"></param>
        /// <param name="idAporte"></param>
        /// <param name="idEntrada"></param>
        /// <param name="fecha"></param>
        /// <param name="contenido"></param>
        /// <remarks>Author: Christopher Vargas</remarks>
        protected internal Comentario(int idCometario, int idUsuario, int idAporte, int idEntrada, DateTime fecha, String contenido)
        {
            IdComentario = idCometario;
            IdUsuario = idUsuario;
            IdAporte = idAporte;
            IdEntrada = idEntrada;
            Fecha = fecha;
            Contenido = contenido;
        }

        /// <summary>
        /// Constrcutor sin idComentario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idAporte"></param>
        /// <param name="idEntrada"></param>
        /// <param name="fecha"></param>
        /// <param name="contenido"></param>
        /// <remarks>Author: Christopher Vargas</remarks>
        protected internal Comentario( int idUsuario, int idAporte, int idEntrada, DateTime fecha, String contenido)
        {
            IdUsuario = idUsuario;
            IdAporte = idAporte;
            IdEntrada = idEntrada;
            Fecha = fecha;
            Contenido = contenido;
        }

        internal int IdComentario
        {
            get { return _idComentario; }
            set { _idComentario = value; }
        }

        internal int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        internal int IdAporte
        {
            get { return _idAporte; }
            set { _idAporte = value; }
        }

        internal int IdEntrada
        {
            get { return _idEntrada; }
            set { _idEntrada = value; }
        }

        internal DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        internal String Contenido
        {
            get { return _contenido; }
            set { _contenido  = value; }
        }
    }
}
