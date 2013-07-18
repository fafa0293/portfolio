using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    internal class Foro
    {
        private int _idForo;
        private int _idGrupo;
        private String _nombreForo;
        private List<Tema> _temas;

        public Foro(int idForo, int idGrupo, String nombreForo)
        {
            IdForo = idForo;
            IdGrupo = idGrupo;
            NombreForo = nombreForo;         
        }

        public Foro(int idGrupo, String nombreForo)
            : this(0,idGrupo,nombreForo)
        {
        }

        public int IdForo
        {
            get { return _idForo; }
            set { _idForo = value; }
        }


        public int IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        public String NombreForo
        {
            get { return _nombreForo; }
            set { _nombreForo = value; }
        }

        public List<Tema> Temas
        {
            get { return _temas; }
            set { _temas = value; }
        }
    }
}
