using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrRol
    {
        private String _idRol;
        private String _nombre;

        /// <summary>
        /// Constructor con todos sus parametros
        /// </summary>
        /// <param name="idRol"></param>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public StrRol(String idRol, String nombre)
        {
            _idRol = idRol;
            _nombre = nombre;
        }
        
        public String IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        
    }
}
