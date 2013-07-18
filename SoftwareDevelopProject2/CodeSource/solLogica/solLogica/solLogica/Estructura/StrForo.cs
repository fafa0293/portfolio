using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrForo
    {
        private String _idForo;
        private String _idUsuario;
        private String _idGrupo;
        private String _nombreForo;
        private String _cantTemas;
        private String _cantAportes;

        public StrForo(String idForo, String idUsuario, String idGrupo, String nombreForo, String cantTemas, String cantAportes)
        {
            _idForo = idForo;
            _idUsuario = idUsuario;
            _idGrupo = idGrupo;
            _nombreForo = nombreForo;
            _cantTemas = cantTemas;
            _cantAportes = cantAportes;
        }

        public String IdForo
        {
            get { return _idForo; }
            set { _idForo = value; }
        }

        public String IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public String IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        public String NombreForo
        {
            get { return _nombreForo; }
            set { _nombreForo = value; }
        }

        public String CantTemas
        {
            get { return _cantTemas; }
            set { _cantTemas = value; }
        }

        public String CantAportes
        {
            get { return _cantAportes; }
            set { _cantAportes = value; }
        }
    }
}
