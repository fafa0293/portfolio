using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoBD;
using solLogica.Clase;
using solLogica.Estructura;

namespace solLogica.Persistente
{
    class PersTema : PersistAbstracto
    {
        /// <summary>
        ///  Método que se encarga de registrar temas y devolver el id del tema registrado
        /// </summary>
        /// <param name="tema"></param>
        /// <returns></returns>
        /// <remarks>Author: Fabián Vega</remarks>
        public int agregarTema(Tema tema)
        {
            Parametro pIdForo = new Parametro("pIdForo", tema.IdForo);
            Parametro pIdUsuario = new Parametro("pIdUsuario", tema.IdUsuario);
            Parametro pTitulo = new Parametro("pTitulo", tema.Titulo);
            Parametro pMaxAportes = new Parametro("pMaxAportes", tema.AportesMax);
            Parametro pMinAportes = new Parametro("pMinAportes", tema.AportesMin);
            Parametro pFechaI = new Parametro("pFechaI", tema.FechaInicio);
            Parametro pFechaF = new Parametro("pFechaF", tema.FechaFin);

            String sql = "INSERT INTO [BDStarCommunitySystem].[dbo].[T_Tema] " +
                           "([id_usuario] ,[id_foro] ,[titulo],[fecha_inicio],[fecha_fin],[min_aportes] ,[max_aportes]) " +
                            "VALUES(pIdUsuario, pIdForo, pTitulo, pFechaI, pFechaF, pMinAportes, pMaxAportes)";
            try
            {
                Acceso.EjecutarSQL(sql, pIdForo, pIdUsuario, pTitulo, pMaxAportes, pMinAportes, pFechaI, pFechaF);
            
                IDataReader dr = Acceso.EjecutarSQLSelect("SELECT MAX(id_tema) FROM T_Tema");
                dr.Read();

                return dr.GetInt32(0);

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

        }

        public void modificarTema(Tema tema)
        {
            Parametro pidTema = new Parametro("pidTema", tema.IdTema);
            Parametro ptitulo = new Parametro("ptitulo", tema.Titulo);
            Parametro paportesMax = new Parametro("paportesMax", tema.AportesMax);
            Parametro paportesMin = new Parametro("paportesMin", tema.AportesMin);
            Parametro pfechaInicio = new Parametro("pfechaInicio", tema.FechaInicio);
            Parametro pfechaFin = new Parametro("pfechaFin", tema.FechaFin);

            String sql = "UPDATE [BDStarCommunitySystem].[dbo].[T_Tema] SET " +
                "[titulo] = ptitulo,[min_aportes] = paportesMin" +
                ",[max_aportes] = paportesMax, [fecha_inicio] = pfechaInicio, [fecha_fin] = pfechaFin WHERE id_tema = pidTema";
            try
            {
                Acceso.EjecutarSQL(sql, pidTema, ptitulo,
                    paportesMax, paportesMin, pfechaInicio, pfechaFin);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void eliminarTema(int idTema)
        {

            Parametro pidTema = new Parametro("pid_tema", idTema);
            Parametro[] parametros = { pidTema };

            String sql = "UPDATE [BDStarCommunitySystem].[dbo].[T_Tema] SET [eliminado] = 1" +
                "WHERE T_Tema.id_tema = pid_tema";
            try
            {
                Acceso.EjecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrTema> buscarTemas(int idForo, String codigo = null, String nombre = null)
        {
            IDataReader dr;
            Parametro pnombre = new Parametro("tituloTema", nombre);
            Parametro pcodigo = new Parametro("codigoGrupo", codigo);

            Parametro[] parametros;

            if (idForo < 0)
            {
                parametros = new Parametro[] { pnombre, pcodigo };
            }
            else
            {
                Parametro pidForo = new Parametro("idForo", idForo);
                parametros = new Parametro[] { pidForo, pnombre, pcodigo };
            }

            String sql = "sp_buscarTema";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, parametros);
                List<StrTema> listaTemas = new List<StrTema>();
                StrTema Tema;

                while (dr.Read())
                {
                    Tema = new StrTema(
                        dr.GetInt32(1).ToString(),
                        dr.GetString(2),
                        dr.GetString(0),
                        dr.GetString(5),
                        dr.GetInt32(4).ToString(),
                        dr.GetInt32(3).ToString(),
                        dr.GetDateTime(6).ToShortDateString().ToString(),
                        dr.GetDateTime(7).ToShortDateString().ToString());

                    listaTemas.Add(Tema);
                }
                dr.Close();
                return listaTemas;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método para buscar tema por id.
        /// </summary>
        /// <param name="pidTema">Id de tema a buscar.</param>
        /// <returns>Un StrTema</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public StrTema buscarTemaPorId(int pidTema)
        {
            IDataReader dr;
            Parametro idTema = new Parametro("id_tema", pidTema);
            String sql = "sp_buscarTemaPorId";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idTema);
                dr.Read();
                StrTema tema = new StrTema(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetInt32(4).ToString(),
                        dr.GetInt32(5).ToString(),
                        dr.GetDateTime(6).ToShortDateString().ToString(),
                        dr.GetDateTime(7).ToShortDateString().ToString());

                dr.Close();
                return tema;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que se encarga de asignar un estudiante a un tema
        /// </summary>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idTema">Id del grupo</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void asignarEstudianteATema(int idUsuario, int idTema)
        {

            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            Parametro pidTema = new Parametro("pidTema", idTema);

            String sql = "Insert Into T_UsuarioXTema (id_usuario, id_tema) " +
                        "VALUES(pidUsuario, pidTema)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidTema);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que se encarga de desasignar un estudiante de un tema
        /// </summary>
        /// <param name="idUsuario"</param>
        /// <param name="idTema"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public void eliminarAsignacionEstudianteATema(int idUsuario, int idTema)
        {

            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            Parametro pidTema = new Parametro("pidTema", idTema);

            String sql = "DELETE FROM T_UsuarioXTema WHERE " +
                        "id_usuario = pidUsuario AND id_tema = pidTema";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidTema);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrTema> listarTemas()
        {
            IDataReader dr;
            String sql = "sp_listarTemas";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql);
                List<StrTema> listaTemas = new List<StrTema>();
                StrTema Tema;

                while (dr.Read())
                {
                    Tema = new StrTema(
                        dr.GetInt32(1).ToString(),
                        dr.GetString(2),
                        dr.GetString(0),
                        dr.GetString(5),
                        dr.GetInt32(4).ToString(),
                        dr.GetInt32(3).ToString(),
                        dr.GetDateTime(6).ToShortDateString().ToString(),
                        dr.GetDateTime(7).ToShortDateString().ToString());

                    listaTemas.Add(Tema);
                }
                dr.Close();
                return listaTemas;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que lista los temas de un grupo
        /// </summary>
        /// <param name="id_grupo">Id del grupo</param>
        /// <returns name="_listaTemas">Retorna una lista de temas de un grupo</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public List<StrTema> listarTemasDeUnGrupo(int id_grupo)
        {
            Parametro pidGrupo = new Parametro("id_grupo", id_grupo);

            IDataReader dr;
            String sql = "sp_listarTemasDeGrupo";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidGrupo);
                List<StrTema> _listaTemas = new List<StrTema>();
                StrTema Tema;

                while (dr.Read())
                {
                    Tema = new StrTema(
                         dr.GetInt32(1).ToString(),
                         dr.GetString(2),
                         dr.GetString(0),
                         dr.GetString(5),
                         dr.GetInt32(4).ToString(),
                         dr.GetInt32(3).ToString(),
                         dr.GetDateTime(6).ToShortDateString().ToString(),
                         dr.GetDateTime(7).ToShortDateString().ToString());


                    _listaTemas.Add(Tema);
                }
                dr.Close();

                return _listaTemas;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que cambia el estado del tema
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        internal void cambiarEstadoDeTema(int idTema, String estado)
        {
            Parametro pidTema = new Parametro("pidTema", idTema);
            Parametro pestado = new Parametro("pestado", estado);

            String sql = "UPDATE [BDStarCommunitySystem].[dbo].[T_Tema] SET " +
                "[estado] = pestado WHERE id_tema = pidTema";
            try
            {
                Acceso.EjecutarSQL(sql, pidTema, pestado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrTema> listarTemasEstudiante(int idUsuario)
        {
            Parametro pidUsuario = new Parametro("idUsuario", idUsuario);

            IDataReader dr;
            String sql = "sp_listarTemasUsuario";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidUsuario);
                List<StrTema> _listaTemas = new List<StrTema>();
                StrTema Tema;

                while (dr.Read())
                {
                    Tema = new StrTema(
                         dr.GetInt32(1).ToString(),
                         dr.GetString(2),
                         dr.GetString(0),
                         dr.GetString(5),
                         dr.GetInt32(4).ToString(),
                         dr.GetInt32(3).ToString(),
                         dr.GetDateTime(6).ToShortDateString().ToString(),
                         dr.GetDateTime(7).ToShortDateString().ToString());


                    _listaTemas.Add(Tema);
                }
                dr.Close();

                return _listaTemas;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool usuarioTieneTema(int idUsuario, int idTema)
        {
            Parametro pidTema = new Parametro("pidTema", idTema);
            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            IDataReader dr;

            String sql = "SELECT COUNT(id_tema) FROM T_Tema WHERE id_usuario = pidUsuario AND id_tema = pidTema";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidTema, pidUsuario);
                dr.Read();
                
                int count = dr.GetInt32(0);

                return (count > 0);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        internal int obtenerIdForo(int idTema)
        {
            Parametro pidTema = new Parametro("pidTema", idTema);
            IDataReader dr;

            String sql = "SELECT id_foro FROM T_Tema WHERE id_tema = pidTema";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidTema);
                dr.Read();

                int id = dr.GetInt32(0);

                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
