using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public class GestorTema
    {
        /// <summary>
        /// Agrega un nuevo Tema en a un foro
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static void agregarTema(int idUsuario, int idForo, String titulo, int aportesMin, int aportesMax, DateTime fechaInicio, DateTime fechaFin)
        {
            Tema tema = new Tema(idUsuario, idForo, titulo, aportesMin, aportesMax, fechaInicio, fechaFin);
            GestorBitacora.registrarBitacora("Agregó el tema: " + titulo + ".");
            
            int idTema = (new PersTema()).agregarTema(tema);

            List<StrUsuario> estudiantes = GestorUsuario.listarEstudiantesPorGrupoId(idForo);

            foreach (StrUsuario estudiante in estudiantes)
            {
                asignarEstudianteATema(Convert.ToInt32(estudiante.idUsuario), idTema);
            }
        }
        
        /// <summary>
        /// Método para modificar temas.
        /// </summary>
        /// <param name="pidTema">Id el tema.</param>
        /// <param name="ptitulo">Título del tema.</param>
        /// <param name="paportesMin">Aportes mínimos del tema.</param>
        /// <param name="paportesMax">Aportes máximos del tema.</param>
        /// <param name="pfechaInicio">Fecha de inicio del tema.</param>
        /// <param name="pfechaFin">Fecha del fin del tema.</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static void modificarTema(int pidTema, String ptitulo, int paportesMin, int paportesMax,
            DateTime pfechaInicio,DateTime pfechaFin)
        {
            PersTema psTema = new PersTema();
            Tema tema = new Tema(pidTema, ptitulo, paportesMin, paportesMax,pfechaInicio,pfechaFin);
            psTema.modificarTema(tema);
            GestorBitacora.registrarBitacora("Modificó el tema: "+ptitulo+".");
        }

        /// <summary>
        /// Método para eliminar temas.
        /// </summary>
        /// <param name="pidTema">Id el tema.</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static void eliminarTema(int pidTema)
        {
            PersTema psTema = new PersTema();
            psTema.eliminarTema(pidTema);
            StrTema tema = psTema.buscarTemaPorId(pidTema);
            GestorBitacora.registrarBitacora("Eliminó el tema: " + tema.Titulo+ ".");
        }

        /// <summary>
        /// Método que busca todos los temas de un foro
        /// </summary>
        /// <param name="idForo"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<StrTema> buscarTemasPorForo(int idForo)
        {
            PersTema pt = new PersTema();
            return pt.buscarTemas(idForo);
        }

        /// <summary>
        /// Método que busca temas por id foro, y codigo de grupo y/o nombre
        /// </summary>
        /// <param name="idForo"></param>
        /// <param name="codigoGrupo"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<StrTema> buscarTemas(int idForo, String codigoGrupo, String nombre)
        {
            PersTema pt = new PersTema();

            codigoGrupo = codigoGrupo.Equals("") ? null : codigoGrupo;
            nombre = nombre.Equals("") ? null : nombre;

            List<StrTema> temas = pt.buscarTemas(idForo, codigoGrupo, nombre);

            if (GestorSesion.usuarioTieneRol("estudiante"))
            {
                temas.RemoveAll(tema => !GestorTema.usuarioTieneAccesoATema(GestorSesion.getIdUsuario(), Convert.ToInt32(tema.IdTema)));
            }

            return temas;
        }

        public static bool usuarioTieneAccesoATema(int idUsuario, int idTema)
        {
            List<int> idsTemas = new List<int>();
            List<StrTema> temas = GestorTema.listarTemasEstudiante(GestorSesion.getIdUsuario());

            foreach (StrTema t in temas)
            {
                idsTemas.Add(Convert.ToInt32(t.IdTema));
            }

            return idsTemas.Contains(idTema);
        }

        /// <summary>
        /// Metodo que se encarga de asignar un estudiante a un tema
        /// </summary>
        /// <param name="idusuario">Id del estudiante</param>
        /// <param name="idTema">Id del tema</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void asignarEstudianteATema(int idusuario,int idTema)
        {
            PersUsuario _persUsuario = new PersUsuario();
            PersTema _persTema = new PersTema();

            StrTema _tema = _persTema.buscarTemaPorId(idTema);
            StrUsuario _usuario = _persUsuario.buscarUsuarioPorId(idusuario);

            _persTema.asignarEstudianteATema(idusuario, idTema);

            GestorBitacora.registrarBitacora(String.Format("Asignó el Estudiante " +
            "{0} al tema {1}", _usuario.Nombre + " " + _usuario.Apellido1 + " " + _usuario.Apellido2, _tema.Titulo));

        }

        /// <summary>
        /// Metodo que se encarga de desasignar un estudiante a un tema
        /// </summary>
        /// <param name="idusuario">Id del estudiante</param>
        /// <param name="idTema">Id del tema</param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void eliminarAsignacionEstudianteATema(int idusuario, int idTema)
        {
            PersUsuario _persUsuario = new PersUsuario();
            PersTema _persTema = new PersTema();

            StrTema _tema = _persTema.buscarTemaPorId(idTema);
            StrUsuario _usuario = _persUsuario.buscarUsuarioPorId(idusuario);

            _persTema.eliminarAsignacionEstudianteATema(idusuario, idTema);

            GestorBitacora.registrarBitacora(String.Format("Desasignó el Estudiante " +
            "{0} del tema {1}", _usuario.Nombre + " " + _usuario.Apellido1 + " " + _usuario.Apellido2, _tema.Titulo));

        }

        public static List<StrTema> listarTemas()
        {
            PersTema pr = new PersTema();
            return pr.listarTemas();
        }

        /// <summary>
        /// Metodo que lista los temas de un grupo
        /// </summary>
        /// <returns name="_temas">Devuelve la lista de temas</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrTema> listarTemasDeGrupo(int id_grupo)
        {

            PersTema _persTema = new PersTema();

            List<StrTema> _temas = new List<StrTema>();

            _temas = _persTema.listarTemasDeUnGrupo(id_grupo);

            return _temas;
        }

        /// <summary>
        /// Buscar Tema por Id
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static StrTema buscarTemaId(int idTema)
        {
            return (new PersTema()).buscarTemaPorId(idTema);
        }

        /// <summary>
        /// Cerrar Tema
        /// </summary>
        /// <param name="idTema"></param>
        /// <remarks>Autor: Jonathan Jara</remarks>
        /// 
        public static void cambiarEstadoDeTema(int idTema, String estado)
        {
            PersTema psTema = new PersTema();
            psTema.cambiarEstadoDeTema(idTema, estado);
        }

        /// <summary>
        /// Obtiene el id de un foro a partir de un tema
        /// </summary>
        /// <param name="idTema"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static int obtenerIdForo(int idTema)
        {
            return (new PersTema()).obtenerIdForo(idTema);
        }

        /// <summary>
        /// Obtiene los temas que un estudiante puede ver
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<StrTema> listarTemasEstudiante(int idUsuario)
        {
            PersTema psTema = new PersTema();
            List<StrTema> temas = psTema.listarTemasEstudiante(idUsuario);

            return temas;
        }
        
        /// <summary>
        /// Determina si un usuario es dueño de un tema
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idTema"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static Boolean usuarioTieneTema(int idUsuario, int idTema)
        {
            PersTema psTema = new PersTema();
            return psTema.usuarioTieneTema(idUsuario, idTema);
        }
    }
}
