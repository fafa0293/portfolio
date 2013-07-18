using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace solLogica.Estructura
{
    public struct StrBlog
    {
       #region Atributos de la clase Blog

        private String _id_blog;
        private String _id_usuario;
        private String _nombre_usuario;
        private String _cant_entradas;

        #endregion

        public StrBlog(String pidBlog, String pidUsuario, String pnombreUsuario, String pcantEntradas)
        {
            _id_blog = pidBlog;
            _id_usuario = pidUsuario;
            _nombre_usuario = pnombreUsuario;
            _cant_entradas = pcantEntradas;
        }

        #region Propiedades de la clase Blog

        public String IdBlog
        {
            get {return _id_blog;}
            set {_id_blog = value;}
        }

        public String IdUsuario
        {
            get {return _id_usuario;}
            set {_id_usuario = value;}
        }

        public String NombreUsuario
        {
            get { return _nombre_usuario; }
            set { _nombre_usuario = value; }
        }

        public String CantEntradas
        {
            get { return _cant_entradas; }
            set { _cant_entradas = value; }
        }

        #endregion

    }
}
