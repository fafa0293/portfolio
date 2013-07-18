using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Estructura;
using solLogica.Clase;
using solLogica.Persistente;

namespace solLogica.Gestor
{
    public static class GestorAporte
    {
        public static void agregarAporte(int idTema, int idUsuario, DateTime fecha, String contenido)
        {
            (new PersAporte()).registrarAporte(idTema, idUsuario, contenido, fecha);
        }

        public static void modificarAporte(int idAporte, int idTema, String fecha, String contenido)
        {
        }

        public static void eliminarAporte(int idAporte)
        {
        }

        /// <summary>
        /// Califica un aporte
        /// </summary>
        /// <param name="idAporte"></param>
        /// <param name="calificacion"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void calificarAporte(int idAporte, int calificacion)
        {
            (new PersAporte()).calificarAporte(idAporte, calificacion);
        }

        /// <summary>
        /// Devuelve los cursos de una Carrera
        /// </summary>
        /// <param name="idGCurso"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static List<StrAporte> listarAportesPorTemaId(int idTema)
        {
            List<StrAporte> aportes = (new PersAporte()).buscarAportePorIdTema(idTema);
            //GestorBitacora.registrarBitacora("Listó aportes del tema: " + idTema + ".");
            return aportes;
        }

        /// <summary>
        /// Devuelve una estructura de aporte
        /// </summary>
        /// <param name="idAporte"></param>
        /// <remarks>Author: Jonathan Jara Morales</remarks>
        public static StrAporte buscarAportePorId(int idAporte)
        {
            return (new PersAporte()).buscarAportePorId(idAporte);
        
        }

        /// <summary>
        /// Devuelve un arreglo de aporte
        /// </summary>
        /// <param name="idAporte"></param>
        /// <remarks>Author: Jonathan Jara Morales</remarks>
        public static String[] BuscarAportePorIdConvert(StrAporte aporte)
        {

            String[] array = { aporte.Calificacion, aporte.Contenido, aporte.Fecha, aporte.IdTema, aporte.IdUsuario, aporte.NomUsuario };
            return array;
        }
            
    }

}
