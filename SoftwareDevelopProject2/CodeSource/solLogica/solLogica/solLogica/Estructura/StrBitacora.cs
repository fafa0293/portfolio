using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrBitacora
    {
        private String _idBitacora;
        private String _descripcion;
        private String _fecha;
        private String _idUsuario;

        /// <summary>
        /// Constructor con todos sus parametros
        /// </summary>
        /// <param name="idBitacora"></param>
        /// <param name="descripcion"></param>
        /// <param name="fecha"></param>
        /// <param name="idUsuario"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public StrBitacora(String idBitacora, String descripcion, String fecha, String idUsuario)
        {
            _idBitacora = idBitacora;
            _descripcion = descripcion;
            _fecha = fecha;
            _idUsuario = idUsuario;
        }

        public String IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public String Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public String IdBitacora
        {
            get { return _idBitacora; }
            set { _idBitacora = value; }
        }

    }
}
