using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrCarrera
    {   
        private String _idCarrera;
        private String _codigo;
        private String _nombre;
        private String _cantCursos;

        public StrCarrera(String idCarrera, String codigo, String nombre, String cantCursos="" )
        {
            _idCarrera = idCarrera;
            _codigo = codigo;
            _nombre = nombre;
            _cantCursos = cantCursos;

        }

        public String IdCarrera
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
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

        public String CantCursos
        {
            get { return _cantCursos; }
            set { _cantCursos = value; }
        }
    }
}
