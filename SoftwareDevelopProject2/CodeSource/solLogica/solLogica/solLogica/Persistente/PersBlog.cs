using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Estructura;
using AccesoBD;
using System.Data.SqlClient;
using System.Data;

namespace solLogica.Persistente
{
    internal class PersBlog : PersistAbstracto
    {
        public List<StrBlog> listarBlogs()
        {
            IDataReader dr;
            StrBlog blog;
            List<StrBlog> blogs = new List<StrBlog>();
             
            String sql = "sp_listarBlogs";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql);
                while (dr.Read())
                {
                    blog = new StrBlog(
                    dr.GetInt32(0).ToString(),
                    dr.GetInt32(1).ToString(),
                    dr.GetString(2),
                    dr.GetInt32(3).ToString());
                    blogs.Add(blog);
                   
                }
                dr.Close();
                return blogs;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrBlog> buscarBlogs(string idGrupo, string idRol)
        {
            IDataReader dr;
            StrBlog blog;
            List<StrBlog> blogs = new List<StrBlog>();
            Parametro pidGrupo = new Parametro("idGrupo", idGrupo);
            Parametro pidRol = new Parametro("idRol", idRol);

            String sql = "sp_listarBlogsPorGrupoRol";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidRol, pidGrupo);
                while (dr.Read())
                {
                    blog = new StrBlog(
                    dr.GetInt32(0).ToString(),
                    dr.GetInt32(1).ToString(),
                    dr.GetString(2),
                    dr.GetInt32(3).ToString());
                    blogs.Add(blog);

                }
                dr.Close();
                return blogs;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal StrBlog buscarBlogPorId(string idBlog)
        {
            IDataReader dr;
            Parametro pidUsuario = new Parametro("idBlog", idBlog);
            StrBlog blog;
            String sql = "sp_buscarBlogPorId";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidUsuario);
                dr.Read();
                blog = new StrBlog(
                    dr.GetInt32(0).ToString(),
                    dr.GetInt32(1).ToString(),
                    dr.GetString(2),
                    dr.GetInt32(3).ToString());

                dr.Close();
                return blog;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void deshabilitarBlog(Blog blog)
        {
            Parametro pIdBlog = new Parametro("pIdBLog", blog.Id_blog);
            Parametro pIdUsuario = new Parametro("pIdUser", blog.Id_usuario);
            Parametro activo = new Parametro("pactivo", 0);

            String sql = "UPDATE [BDStarCommunitySystem].[dbo].[T_Blog] " +
                "SET [id_usuario] = pIdUser, [activo] = pactivo " +
                "WHERE id_blog = pIdBLog";
            try
            {
                Acceso.EjecutarSQL(sql, pIdBlog, pIdUsuario, activo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

         internal List<StrBlog> buscarBlogPorIdRol(int idRol)
        {
            IDataReader dr;
            StrBlog blog;
            List<StrBlog> blogs = new List<StrBlog>();
            Parametro pidRol = new Parametro("idRol", idRol);

            String sql = "sp_buscarBlogPorIdRol";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidRol);
                while (dr.Read())
                {
                    blog = new StrBlog(
                    dr.GetInt32(0).ToString(),
                    dr.GetInt32(1).ToString(),
                    dr.GetString(2),
                    dr.GetInt32(3).ToString());
                    blogs.Add(blog);

                }
                dr.Close();
                return blogs;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrBlog> buscarBlogsPorNombre(string nombre)
        {
            IDataReader dr;
            StrBlog blog;
            List<StrBlog> blogs = new List<StrBlog>();
            Parametro pidRol = new Parametro("nombre", nombre);

            String sql = "sp_buscarBlogPorNombreUsuario";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidRol);
                while (dr.Read())
                {
                    blog = new StrBlog(
                    dr.GetInt32(0).ToString(),
                    dr.GetInt32(1).ToString(),
                    dr.GetString(2),
                    dr.GetInt32(3).ToString());
                    blogs.Add(blog);

                }
                dr.Close();
                return blogs;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    
}
