using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Carrera
    {
        protected int _idCarrera;
        protected String _codigo;
        protected String _nombre;
        protected List<Curso> _cursos = null;

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="idCarrera"></param>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="cursos">Lista de cursos. Opcional</param>
        /// <remarks>Autor: Ernesto Villarreal</remarks>
        protected internal Carrera(int idCarrera, String codigo, String nombre, List<Curso> cursos=null)
        {
            IdCarrera = idCarrera;
            Codigo = codigo;
            Nombre = nombre;
            Cursos = cursos;
        }
        /// <summary>
        /// Constructor sin idCarrera (para cuando se registra una nueva)
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        protected internal Carrera(String codigo, String nombre)
            : this(-1, codigo, nombre)
        {
        }

        internal int IdCarrera
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }

        internal String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        internal String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        internal List<Curso> Cursos
        {
            get { return _cursos; }
            set { _cursos = value; }
        }
    }
}