using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Bitacora
    {
        protected int _idBitacora;
        protected String _descripcion;
        protected DateTime _fecha;
        protected int _idUsuario;

        /// <summary>
        /// Constructor con todos los parametros
        /// </summary>
        /// <param name="idBitacora"></param>
        /// <param name="descripcion"></param>
        /// <param name="fecha"></param>
        /// <param name="idUsuario"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        protected internal Bitacora(int idBitacora, String descripcion, DateTime fecha, int idUsuario)
        {
            IdBitacora = idBitacora;
            Descripcion = descripcion;
            Fecha = fecha;
            IdUsuario = idUsuario;
        }

        /// <summary>
        /// Constructor con todos los parametros
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="fecha"></param>
        /// <param name="idUsuario"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        protected internal Bitacora(String descripcion, DateTime fecha, int idUsuario)
        {
            Descripcion = descripcion;
            Fecha = fecha;
            IdUsuario = idUsuario;
        }
        internal int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        internal DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        internal String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        internal int IdBitacora
        {
            get { return _idBitacora; }
            set { _idBitacora = value; }
        }

    }
}
