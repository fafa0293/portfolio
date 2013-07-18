using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Rol
    {
        protected int _idRol;
        protected String _nombre;
        protected List<Permiso> _permisos;

        /// <summary>
        /// Constructor con todos los parametros
        /// </summary>
        /// <param name="idRol"></param>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        protected internal Rol(int idRol, String nombre)
        {
            IdRol = idRol;
            Nombre = nombre;
        }

        /// <summary>
        /// Constructor con todos los parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        protected internal Rol(String nombre)
        {
            Nombre = nombre;
        }

        internal List<Permiso> Permisos
        {
            get { return _permisos; }
            set { _permisos = value; }
        }

        internal String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        internal int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }
    }
}
