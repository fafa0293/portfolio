using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Curso
    {
        protected int _idCurso;
        protected String _codigo;
        protected String _nombre;
        protected String _creditos;
        protected String _estado;    
        protected List<Grupo> _grupos = null;

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="idCurso"></param>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="grupos">Lista de grupos, opcional</param>
        /// <remarks>Autor: Ernesto Villarreal</remarks>
        protected internal Curso(int idCurso, String codigo, String nombre, String creditos, String estado, List<Grupo> grupos = null)
        {
            IdCurso = idCurso;
            Codigo = codigo;
            Nombre = nombre;
            Grupos = grupos;
            Estado = estado;
            Creditos = creditos;
        }


        /// <summary>
        /// Constructor sin idCurso (para cuando se registra uno nueva)
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="creditos"></param>
        /// <param name="estado"></param>
        /// <param name="grupos">Lista de grupos, opcional</param>
        /// <remarks>Autor: Ernesto Villarreal</remarks>
        protected internal Curso(String codigo, String nombre, String creditos, String estado, List<Grupo> grupos=null) :
            this(-1, codigo, nombre, creditos, estado, grupos)
        {
        }

        internal int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
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

        internal String Creditos
        {
            get { return _creditos; }
            set { _creditos = value; }
        }
        internal String Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        internal List<Grupo> Grupos
        {
            get {return _grupos; }
            set { _grupos = value; }
        }
    }
}
