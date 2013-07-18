using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrEntrada
    {
        private String _idEntrada;
        private String _fecha;
        private String _contenido;
        private String _titulo;
        private String _calificacion;
        private String _idBlog;

     
       
        public StrEntrada(String id, String pFec, String pCont,String ptitulo,String pcalificacion,String pidBlog)
        {
            _idEntrada = id;
            _fecha = pFec;
            _contenido = pCont;
            _titulo = ptitulo;
            _calificacion = pcalificacion;
            _idBlog = pidBlog;
        }

      

        public String Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        public String Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public String IdEntrada
        {
            get { return _idEntrada; }
            set { _idEntrada = value; }
        }

        public String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public String Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }

        public String IdBlog
        {
            get { return _idBlog; }
            set { _idBlog = value; }
        }

    }
}
