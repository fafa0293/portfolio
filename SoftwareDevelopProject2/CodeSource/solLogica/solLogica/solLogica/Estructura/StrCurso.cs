using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrCurso
    {
        private String _idCurso;
        private String _codigo;
        private String _nombre;
        private String _creditos;
        private String _estado;

        public StrCurso (String idCurso, String codigo, String nombre, String creditos, String estado)
        {
            _idCurso = idCurso;
            _codigo = codigo;
            _nombre = nombre;
            _creditos = creditos;
            _estado = estado;
            
        }

        public String IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Creditos
        {
            get { return _creditos; }
            set { _creditos = value; }
        }
        public String Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
