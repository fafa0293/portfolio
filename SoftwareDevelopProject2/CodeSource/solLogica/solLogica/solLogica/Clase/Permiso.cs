using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Permiso
    {
        protected int _idPermiso;
        protected String _nombre;
        protected String _descripcion;

        /// <summary>
        /// Contructor con todos los parametros
        /// </summary>
        /// <param name="idPermiso"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        protected internal Permiso(int idPermiso, String nombre, String descripcion)
        {
            IdPermiso = idPermiso;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        /// <summary>
        /// Contructor con todos los parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        protected internal Permiso(String nombre, String descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        internal String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        internal String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        internal int IdPermiso
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }
    }
}
