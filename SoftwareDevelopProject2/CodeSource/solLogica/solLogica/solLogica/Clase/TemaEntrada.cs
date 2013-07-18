using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class TemaEntrada
    {
        protected int _id;
        protected String _nombre;

        protected internal TemaEntrada(String nombre)
        {
            Nombre = nombre;
        }

        internal String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        internal int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        

    }
}
