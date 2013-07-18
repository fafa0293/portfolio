using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public  class Tema
    {
        protected int _idTema;
        protected int _idUsuario;
        protected int _idForo;
        protected String _titulo;
        protected DateTime _fechaInicio;
        protected DateTime _fechaFin;  
        protected int _aportesMin;
        protected int _aportesMax;

        protected internal Tema(int idTema,int idUsuario, int idForo, String titulo, int aportesMin, int aportesMax,
            DateTime fechaInicio, DateTime fechaFin)
        {
            IdTema = idTema;
            IdUsuario = idUsuario;
            IdForo = idForo;
            Titulo = titulo;
            AportesMin = aportesMin;
            AportesMax = aportesMax;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        protected internal Tema(int idUsuario, int idForo, String titulo, int aportesMin, int aportesMax, DateTime fechaInicio, DateTime fechaFin)
        {
            IdUsuario = idUsuario;
            IdForo = idForo;
            Titulo = titulo;
            AportesMin = aportesMin;
            AportesMax = aportesMax;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        protected internal Tema(int pidTema, string ptitulo, int paportesMin, int paportesMax, DateTime pfechaInicio, DateTime pfechaFin)
            : this(pidTema, 0, 0, ptitulo, paportesMin, paportesMax, pfechaInicio, pfechaFin)
        {
        }


        internal DateTime FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        internal DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        internal int AportesMax
        {
            get { return _aportesMax; }
            set { _aportesMax = value; }
        }

        internal int AportesMin
        {
            get { return _aportesMin; }
            set { _aportesMin = value; }
        }
        internal String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        internal int IdForo
        {
            get { return _idForo; }
            set { _idForo = value; }
        }

        internal int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        internal int IdTema
        {
            get { return _idTema; }
            set { _idTema = value; }
        }
    }
}
