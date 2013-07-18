using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Estructura
{
    public struct StrGrupo
    {
        private String _idGrupo;
        private String _curso;
        private String _codigo;
        private String _nombre;   
        private String _periodo;
        private String _estado;
        private String _idCurso;    

       /// <summary>
       /// Constructor de StrGrupo
       /// </summary>
       /// <param name="pidGrupo">pidGrupo</param>
       /// <param name="pcodigo">pcodigo</param>
       /// <param name="pnombre">pnombre</param>
       /// <param name="pperiodo">pperiodo</param>
       /// <param name="pestado">pestado</param>
       /// <param name="pcurso">pcurso</param>
       /// <remarks>Autor: Dylhann Obando</remarks>
        public StrGrupo(String pidGrupo, String pcodigo ,String pnombre, String pperiodo,String pestado,
            String pcurso,String pidCurso)
        {
            _idGrupo = pidGrupo;
            _curso = pcurso;
            _codigo = pcodigo;
            _periodo = pperiodo;
            _nombre = pnombre;
            _estado = pestado;
            _idCurso = pidCurso;
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
      
        public String IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        public String Periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }

        

        public String Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    
    }
}
