using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    class Entrada
    {
        protected int _idEntrada;
        protected int _idBlog;
        protected DateTime _fecha;
        protected String _contenido;
        protected String _titulo;


        protected internal Entrada(int pidBlog,DateTime pFec, String pCont,String ptitulo)
        {
            IdBlog = pidBlog;
            Fecha = pFec;
            Contenido = pCont;
            Titulo = ptitulo;
        }

        protected internal Entrada(int idEntrada, int pidBlog, DateTime pFec, String pCont, String ptitulo)
        {
            IdEntrada = idEntrada;
            IdBlog = pidBlog;
            Fecha = pFec;
            Contenido = pCont;
            Titulo = ptitulo;
        }

        protected internal Entrada(int id, DateTime pFec, String pCont)
        {
            IdEntrada = id;
            Fecha = pFec;
            Contenido = pCont;
        }


        internal int IdBlog
        {
            get { return _idBlog; }
            set { _idBlog = value; }
        }

        internal String Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        internal DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        internal int IdEntrada
        {
            get { return _idEntrada; }
            set { _idEntrada = value; }
        }

        internal String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        
    }
}
