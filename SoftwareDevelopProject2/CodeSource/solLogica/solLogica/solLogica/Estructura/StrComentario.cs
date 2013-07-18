using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrComentario
    {

        private String _idComentario;
        private String _idUsuario;
        private String _idAporte;
        private String _idEntrada;
        private String _fecha;
        private String _contenido;
        private String _nombreUsuario;

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
        public  StrComentario(String idCometario, String idUsuario, String idAporte, String idEntrada, String fecha, String contenido, String nombreUsuario)
        {
            _idComentario = idCometario;
            _idUsuario = idUsuario;
            _idAporte = idAporte;
            _idEntrada = idEntrada;
            _fecha = fecha;
            _contenido = contenido;
            _nombreUsuario = nombreUsuario;
        }


        public String IdComentario
        {
            get { return _idComentario; }
            set { _idComentario = value; }
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

        public String IdEntrada
        {
            get { return _idEntrada; }
            set { _idEntrada = value; }
        }

        public String Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public String Contenido
        {
            get { return _contenido; }
            set { _contenido  = value; }
        }

        public String NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
    }
}
