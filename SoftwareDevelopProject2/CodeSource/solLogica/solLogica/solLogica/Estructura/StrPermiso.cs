using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrPermiso
    {
        private String _idPermiso;
        private String _nombre;
        private String _descripcion;

        /// <summary>
        /// Constructor con todos sus parametros
        /// </summary>
        /// <param name="idPermiso"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public StrPermiso(String idPermiso, String nombre, String descripcion)
        {
            _idPermiso = idPermiso;
            _nombre = nombre;
            _descripcion = descripcion;
        }

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String IdPermiso
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }
    }
}
