using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrTemaEntrada
    {
        public String _id;
        public String _nombre;

        public StrTemaEntrada(String id,String nombre)
        {
            _nombre = nombre;
            _id = id;
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
