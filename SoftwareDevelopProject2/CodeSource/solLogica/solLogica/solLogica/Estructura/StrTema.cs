using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrTema
    {
        private String _idTema;
        private String _nombreUsuario;
        private String _nombreForo;
        private String _titulo;
        private String _aportesMin;
        private String _aportesMax;
        private String _fechaInicio;
        private String _fechaFin;

        public StrTema(String idTema, String usuario, String foro, String titulo, String aportesMin, String aportesMax,
            String fechaInicio, String fechaFin)
        {
            _idTema = idTema;
            _nombreUsuario = usuario;
            _nombreForo = foro;
            _titulo = titulo;
            _aportesMin = aportesMin;
            _aportesMax = aportesMax;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
        }

        public String FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        public String FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public String AportesMax
        {
            get { return _aportesMax; }
            set { _aportesMax = value; }
        }

        public String AportesMin
        {
            get { return _aportesMin; }
            set { _aportesMin = value; }
        }
        public String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public String NombreForo
        {
            get { return _nombreForo; }
            set { _nombreForo = value; }
        }

        public String NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public String IdTema
        {
            get { return _idTema; }
            set { _idTema = value; }
        }
    }
}
