using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public static class GestorBlog
    {

        /// <summary>
        /// Método para listar todos los blogs
        /// </summary>
        /// <returns>Lista de StrBlog.</returns>
        /// <remarks>Autor: Jonathan Jara Moras</remarks>
        public static List<StrBlog> listarBlogs()
        {
            PersBlog psGrupo = new PersBlog();
            return psGrupo.listarBlogs();
        }

        /// <summary>
        /// Método para buscar los blogs
        /// </summary>
        /// <returns>Lista de StrBlog.</returns>
        /// <remarks>Autor: Jonathan Jara Moras</remarks>
        public static List<StrBlog> buscarBlogs(String idGrupo, String idRol)
        {
            PersBlog psGrupo = new PersBlog();
            return psGrupo.buscarBlogs(idGrupo, idRol);
        }

        /// <summary>
        /// Devuelve una estructura de blog, que busca por el id del Blog
        /// </summary>
        /// <param name="idBlog"></param>
        /// <remarks>Author: Jonathan Jara Morales</remarks>
        public static StrBlog buscarBlogPorId(String idBlog)
        {
            PersBlog psBlog = new PersBlog();
            return psBlog.buscarBlogPorId(idBlog);
        }

       
        public static void deshabilitarBlog(String idBlog, String idUsario)
        {
            (new PersBlog()).deshabilitarBlog((new Blog(idBlog, idUsario)));
        }

        public static List<StrBlog> buscarBlogsPorIdRol(int idRol)
        {
            PersBlog psBlog = new PersBlog();
            return psBlog.buscarBlogPorIdRol(idRol);
        }

        public static List<StrBlog> buscarBlogsPorNombre(String nombre)
        {
            PersBlog psBlog = new PersBlog();
            return psBlog.buscarBlogsPorNombre(nombre);
        }
    }
}
