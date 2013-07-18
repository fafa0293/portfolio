using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoBD;

namespace solLogica.Persistente
{
    public abstract class PersistAbstracto
    {
        protected Acceso acceso;

        protected internal Acceso Acceso
        {
            get { return acceso; }
            private set { acceso = value; }
        }

        internal PersistAbstracto()
        {
            Acceso = new Acceso();
        }
    }
}
