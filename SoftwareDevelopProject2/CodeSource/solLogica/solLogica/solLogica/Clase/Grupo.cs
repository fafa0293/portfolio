using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solLogica.Clase
{
    public class Grupo
    {
        protected int _idGrupo;
        protected int _idCurso;
        protected String _codigo;
        protected String _nombre;
        protected String _periodo;
        private Boolean _estado;


        /// <summary>
        /// Constructor sin Id del Grupo.
        /// </summary>
        /// <param name="pidCurso">Id del Curso del grupo.</param>
        /// <param name="pcodigo">Código del grupo.</param>
        /// <param name="pnombre">Nombre del grupo.</param>
        /// <param name="pperiodo">Período al que pertenece el grupo.</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        protected internal Grupo(int pidCurso, String pcodigo, String pnombre, String pperiodo)
            : this(-1, pidCurso, pcodigo, pnombre, pperiodo)
        {
        }

        /// <summary>
        /// Construtor general de grupo.
        /// </summary>
        /// <param name="pidGrupo">Id del grupo.</param>
        /// <param name="pidCurso">Id del Curso del grupo.</param>
        /// <param name="pcodigo">Código del grupo.</param>
        /// <param name="pnombre">Nombre del grupo.</param>
        /// <param name="pperiodo">Período al que pertenece.</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        protected internal Grupo(int pidGrupo, int pidCurso, String pcodigo, String pnombre, String pperiodo,Boolean pestado=false)
        {
            IdGrupo = pidGrupo;
            IdCurso = pidCurso;
            Periodo = pperiodo;
            Codigo = pcodigo;
            Nombre = pnombre;
            Estado = pestado;
        }

        internal int IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        internal int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        internal String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        internal String Periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }

        internal String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }


        internal Boolean Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

    }
}