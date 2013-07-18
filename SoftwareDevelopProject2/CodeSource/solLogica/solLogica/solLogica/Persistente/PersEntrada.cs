using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Estructura;
using AccesoBD;
using System.Data;

namespace solLogica.Persistente
{
    internal class PersEntrada:PersistAbstracto
    {

        internal void registrarEntrada(Entrada entrada)
        {
            Parametro pidBlog = new Parametro("pIdB", entrada.IdBlog);
            Parametro pFecha = new Parametro("pFecha", entrada.Fecha);
            Parametro pContenido = new Parametro("pConte", entrada.Contenido);
            Parametro pTitulo = new Parametro("pTitulo", entrada.Titulo);

            String sql = "INSERT INTO [BDStarCommunitySystem].[dbo].[T_Entrada]([id_blog],[fecha],[titulo],[contenido]) " +
                "VALUES(pIdB,pFecha,pTitulo,pConte)";
            try
            {
                Acceso.EjecutarSQL(sql, pidBlog, pFecha, pContenido, pTitulo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        internal void modificarEntrada(Entrada entrada)
        {
            Parametro pId = new Parametro("pId", entrada.IdEntrada);
            Parametro pIdB = new Parametro("pidblog", entrada.IdBlog);
            Parametro pFecha = new Parametro("pFecha", entrada.Fecha);
            Parametro pContenido = new Parametro("pContenido", entrada.Contenido);
            Parametro pTitulo = new Parametro("pTitulo", entrada.Titulo);

            String sql = "UPDATE [BDStarCommunitySystem].[dbo].[T_Entrada] "+
                            "SET [id_blog] = pidblog ,[fecha] = pFecha ,[titulo] = pTitulo,[contenido] = pContenido " +
                            "WHERE [id] = pId";
            try
            {
                Acceso.EjecutarSQL(sql, pId, pIdB, pFecha, pContenido, pTitulo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrEntrada> buscarEntradasPorIdBlog(int pid)
        {
            IDataReader dr;
            Parametro pidBlog = new Parametro("idBlog", pid);

            String sql = "sp_EntradasBlog";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidBlog);
                StrEntrada entrada;
                List<StrEntrada> entradas = new List<StrEntrada>();
                int cali = 0;

                while (dr.Read())
                {
                    entrada = new StrEntrada(
                        dr.GetInt32(0).ToString(),
                        dr.GetDateTime(2).ToString(),
                        dr.GetString(4),
                        dr.GetString(3),
                        cali.ToString(),
                        dr.GetInt32(1).ToString());

                    entradas.Add(entrada);
                }
                dr.Close();
                return entradas;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrEntrada> buscarEntradasPorTitulo(int pidBlog,String ptitulo)
        {
            IDataReader dr;
            Parametro idBlog = new Parametro("id_blog", pidBlog);
            Parametro titulo = new Parametro("titulo", ptitulo);
            String sql = "sp_buscarEntradasPorTitulo";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idBlog,titulo);
                StrEntrada entrada;
                List<StrEntrada> entradas = new List<StrEntrada>();
                String cal;
                while (dr.Read())
                {
                    cal = (dr.IsDBNull(4) ? "0" : dr.GetDouble(4).ToString());
                    entrada = new StrEntrada(
                        dr.GetInt32(0).ToString(),
                        dr.GetDateTime(1).ToString(),
                        dr.GetString(2),
                        dr.GetString(3),
                        cal,
                        dr.GetInt32(5).ToString());

                    entradas.Add(entrada);
                }
                dr.Close();
                return entradas;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrEntrada> buscarEntradasPorTema(int pidBlog, int pidTema)
        {
            IDataReader dr;
            Parametro idBlog = new Parametro("id_blog", pidBlog);
            Parametro idTema = new Parametro("id_tema", pidTema);
            String sql = "sp_buscarEntradasPorTema";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idBlog, idTema);
                StrEntrada entrada;
                List<StrEntrada> entradas = new List<StrEntrada>();
                String cal;
                while (dr.Read())
                {
                    cal = (dr.IsDBNull(4) ? "0" : dr.GetDouble(4).ToString());
                    entrada = new StrEntrada(
                        dr.GetInt32(0).ToString(),
                        dr.GetDateTime(1).ToString(),
                        dr.GetString(2),
                        dr.GetString(3),
                          cal.ToString(),
                        dr.GetInt32(5).ToString());

                    entradas.Add(entrada);
                }
                dr.Close();
                return entradas;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrTemaEntrada> buscarTemasPorEntrada(int pidEntrada)
        {
            IDataReader dr;
            Parametro idEntrada = new Parametro("id_entrada", pidEntrada);
            String sql = "sp_buscarTemasPorEntrada";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idEntrada);
                StrTemaEntrada entrada;
                List<StrTemaEntrada> entradas = new List<StrTemaEntrada>();

                while (dr.Read())
                {
                    entrada = new StrTemaEntrada(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1));

                    entradas.Add(entrada);
                }
                dr.Close();
                return entradas;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrCalificacion> buscarCalificacionDeUsuario(int pidEntrada, int pidUsuario)
        {
            IDataReader dr;
            Parametro idEntrada = new Parametro("id_entrada", pidEntrada);
            Parametro idCalificacion = new Parametro("id_usuario", pidUsuario);
            String sql = "sp_buscarCalificacionDeUsuario";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idEntrada, idCalificacion);
                StrCalificacion calificacion;
                List<StrCalificacion> calificaciones = new List<StrCalificacion>();

                while (dr.Read())
                {
                    calificacion = new StrCalificacion(
                        dr.GetInt32(0).ToString(),
                        dr.GetInt32(1).ToString(),
                        dr.GetInt32(2).ToString(),
                        dr.GetInt32(3).ToString());

                    calificaciones.Add(calificacion);
                }
                dr.Close();
                return calificaciones;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrTemaEntrada> buscarTemasPorBlog(int pidBlog)
        {
            IDataReader dr;
            Parametro idBlog = new Parametro("id_blog", pidBlog);
            String sql = "sp_buscarTemasPorBlog";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idBlog);
                StrTemaEntrada entrada;
                List<StrTemaEntrada> entradas = new List<StrTemaEntrada>();

                while (dr.Read())
                {
                    entrada = new StrTemaEntrada(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1));

                    entradas.Add(entrada);
                }
                dr.Close();
                return entradas;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void registrarCalificacion(Calificacion calificacion)
        {
            Parametro pcalificacion = new Parametro("pcalificacion", calificacion.CalificacionDada);
            Parametro pidEntrada = new Parametro("pidEntrada", calificacion.IdEntrada);
            Parametro pidUsuario = new Parametro("pidUsuario", calificacion.IdUsuario);
           

            String sql = "INSERT INTO [BDStarCommunitySystem].[dbo].[T_Calificacion]([id_usuario],[id_entrada],[calificacion]) " +
                "VALUES(pidUsuario,pidEntrada,pcalificacion)";
            try
            {
                Acceso.EjecutarSQL(sql, pcalificacion, pidEntrada, pidUsuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<int> buscarCalificacionesDeEntrada(int pid)
        {
            IDataReader dr;
            Parametro pidBlog = new Parametro("idEntrada", pid);

            String sql = "sp_CalificacionesEntrada";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidBlog);
                List<int> calis = new List<int>();
                int cali;
                while (dr.Read())
                {
                    cali = dr.GetInt32(0);
                    calis.Add(cali);
                }
                dr.Close();
                return calis;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal StrEntrada buscarEntradasPorId(int pid)
        {
            IDataReader dr;
            Parametro idEntrada = new Parametro("idEntrda", pid);

            String sql = "sp_EntradaId";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idEntrada);
                StrEntrada entrada;
                
                int cali = 0;
                dr.Read();

                    entrada = new StrEntrada(
                        dr.GetInt32(0).ToString(),
                        dr.GetDateTime(2).ToString(),
                        dr.GetString(4),
                        dr.GetString(3),
                        cali.ToString(),
                        dr.GetInt32(1).ToString());

                   
                dr.Close();
                return entrada;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal StrEntrada buscarUltimaEntrada(int pidBlog)
        {
            IDataReader dr;
            Parametro idBlog = new Parametro("idBlog", pidBlog);

            String sql = "sp_buscarUltimaEntrada";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idBlog);
                StrEntrada entrada;

                int cali = 0;
                dr.Read();

                entrada = new StrEntrada(
                    dr.GetInt32(0).ToString(),
                    dr.GetDateTime(2).ToString(),
                    dr.GetString(4),
                    dr.GetString(3),
                    cali.ToString(),
                    dr.GetInt32(1).ToString());


                dr.Close();
                return entrada;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

       

        public void registrarTemasDeEntrada(TemaEntrada ptema)
        {

            Parametro tema = new Parametro("pnombre",ptema.Nombre);
            String sql = "INSERT INTO T_Tema_Entrada (nombre) " +
             "VALUES (pnombre)";

            try
            {
                Acceso.EjecutarSQL(sql, tema);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void asignarTemaAEntrada(int pidTema, int pidEntrada)
        {
            Parametro idTema = new Parametro("pidTema", pidTema);
            Parametro idEntrada = new Parametro("pidEntrada", pidEntrada);

            String sql = "INSERT INTO T_TemaXEntrada (id_tema,id_entrada) " +
             "VALUES (pidTema,pidEntrada)";

            try
            {
                Acceso.EjecutarSQL(sql, idTema,idEntrada);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal StrTemaEntrada buscarUltimaTema()
        {
            IDataReader dr;

            String sql = "sp_buscarUltimoTemaDeEntrada";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, new Parametro[0]);
                dr.Read();

                StrTemaEntrada tema = new StrTemaEntrada(
                       dr.GetInt32(0).ToString(),
                       dr.GetString(1));


                dr.Close();
                return tema;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
