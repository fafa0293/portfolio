using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;
namespace solLogica.Gestor
{
    public static class GestorEntrada
    {
        /// <summary>
        /// Registra una entrada
        /// </summary>
        /// <param name="idBlog"></param>
        /// <param name="titulo"></param>
        /// <param name="cont"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static void registrarEntrada(int idBlog, String titulo, String cont)
        {
            (new PersEntrada()).registrarEntrada((new Entrada(idBlog, DateTime.Now, cont, titulo)));
        }

        /// <summary>
        /// Modifica una entrada
        /// </summary>
        /// <param name="idEntrada"></param>
        /// <param name="idBlog"></param>
        /// <param name="fech"></param>
        /// <param name="titulo"></param>
        /// <param name="cont"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static void modificarEntrada(int idEntrada, int idBlog,DateTime fech ,String titulo, String cont)
        {
            Entrada ent = new Entrada(idEntrada, idBlog, fech, cont, titulo);
            (new PersEntrada()).modificarEntrada(ent);
        }
        /// <summary>
        /// Devuelve las entradas de un blog
        /// </summary>
        /// <param name="idGCurso"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static List<StrEntrada> listarEntradasPorBlogId(int idBlog)
        {
            List<StrEntrada> entradas = (new PersEntrada()).buscarEntradasPorIdBlog(idBlog);
            return obtenerEntradas(entradas);
        }

        /// <summary>
        /// Lista varias entradas por titulo
        /// </summary>
        /// <param name="pidBlog"></param>
        /// <param name="ptitulo"></param>
        /// <returns></returns>
        /// <remarks>Author: Dylhann Obando Mckenzie</remarks>
        public static List<StrEntrada> listarEntradasPorTitulo(int pidBlog, String ptitulo)
        {
            PersEntrada psEntrada = new PersEntrada();
            return obtenerEntradas(psEntrada.buscarEntradasPorTitulo(pidBlog, ptitulo));
        }

        /// <summary>
        ///  Lista varias entradas por tema
        /// </summary>
        /// <param name="pidBlog"></param>
        /// <param name="pidTema"></param>
        /// <returns></returns>
        /// <remarks>Author: Dylhann Obando Mckenzie</remarks>
        public static List<StrEntrada> listarEntradasPorTema(int pidBlog, int pidTema)
        {
            PersEntrada psEntrada = new PersEntrada();
            return obtenerEntradas(psEntrada.buscarEntradasPorTema(pidBlog, pidTema));
        }

        /// <summary>
        /// Registra una calificación
        /// </summary>
        /// <param name="pidUsuario"></param>
        /// <param name="pidEntrada"></param>
        /// <param name="pcalificacion"></param>
        /// <remarks>Author: Dylhann Obando Mckenzie</remarks>
        public static void registrarCalificacion(int pidUsuario,int pidEntrada, int pcalificacion)
        {
            Calificacion calificacion = new Calificacion(pidUsuario,pidEntrada,pcalificacion);
            PersEntrada psEntrada = new PersEntrada();
            psEntrada.registrarCalificacion(calificacion);
        }

        /// <summary>
        /// Devuelve una entrada especifica por su id
        /// </summary>
        /// <param name="idEntrada"></param>
        /// <returns></returns>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static StrEntrada entradaId(int idEntrada)
        {
            StrEntrada entrada = (new PersEntrada()).buscarEntradasPorId(idEntrada);
            entrada.Calificacion = obtenerPromedioCalificacionesEntrada(entrada);
            return entrada;
        }

        /// <summary>
        /// Devuelve los temas de una entrada
        /// </summary>
        /// <param name="idEntrada"></param>
        /// <returns></returns>
        /// <remarks>Author: Dylhann Obando Mckenzie</remarks>
        public static List<StrTemaEntrada> buscarTemasPorEntrada(int idEntrada)
        {
            PersEntrada psTemaEntrada = new PersEntrada();
            return psTemaEntrada.buscarTemasPorEntrada(idEntrada);
        }

        /// <summary>
        /// Devuelve los temas de un blog
        /// </summary>
        /// <param name="idBlog"></param>
        /// <returns></returns>
        /// <remarks>Author: Dylhann Obando Mckenzie</remarks>
        public static List<StrTemaEntrada> buscarTemasPorBlog(int idBlog)
        {
            PersEntrada psTemaEntrada = new PersEntrada();
            return psTemaEntrada.buscarTemasPorBlog(idBlog);
        }

        /// <summary>
        ///  Retorna la calificacion de una entrada hecha por un usuario especifico
        /// </summary>
        /// <param name="pidEntrada"></param>
        /// <param name="pidUsuario"></param>
        /// <returns></returns>
        /// <remarks>Author: Dylhann Obando Mckenzie</remarks>
        public static Int32 buscarCalificacionDeUsuario(int pidEntrada,int pidUsuario)
        {
            PersEntrada psEntrada = new PersEntrada();
            List<StrCalificacion> calificaciones = psEntrada.buscarCalificacionDeUsuario(pidEntrada,pidUsuario);
            return Convert.ToInt32(calificaciones.Find(item => Convert.ToInt32(item.IdEntrada) == pidEntrada).Calificacion);
        }

        /// <summary>
        /// Devuelve las entradas con sus calificaciones
        /// </summary>
        /// <param name="idGCurso"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static List<StrEntrada> obtenerEntradas(List<StrEntrada> entradas)
        {
            List<StrEntrada> lista = new List<StrEntrada>();
            StrEntrada entrada;
            for (int i = 0; i < entradas.Count; i++)
            {
                entrada = entradas[i];
                entrada.Calificacion = obtenerPromedioCalificacionesEntrada(entrada);
                lista.Add(entrada);
            }
            return lista;
        }

        /// <summary>
        ///  Asigna su calificación promedio a una entrada
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        private static string obtenerPromedioCalificacionesEntrada(StrEntrada entrada)
        {
            int idEntrada = Convert.ToInt32(entrada.IdEntrada);
            int cantCalis = 0;
            Double calificacion = 0;
            List<int> calis = (new PersEntrada()).buscarCalificacionesDeEntrada(idEntrada);

            foreach (int cali in calis)
            {
                calificacion = calificacion + cali;
                cantCalis = cantCalis + 1;
            }

            if (cantCalis > 0)
            {
                calificacion = calificacion / cantCalis;
            }

            return calificacion.ToString();
        }

        public static void registrarTemasDeEntrada(int idBlog, List<String> temas)
        {
            PersEntrada psEntrada = new PersEntrada();
            int idEntrada = Convert.ToInt32(psEntrada.buscarUltimaEntrada(idBlog).IdEntrada);

            StrTemaEntrada temaActual;
            foreach (String tema in temas)
            {
                psEntrada.registrarTemasDeEntrada(new TemaEntrada(tema));
                temaActual = psEntrada.buscarUltimaTema();
                psEntrada.asignarTemaAEntrada(Convert.ToInt32(temaActual.Id),idEntrada);
            }
           

        }


    }
}
