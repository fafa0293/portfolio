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
    internal class PersGrupo : PersistAbstracto
    {
        /// <summary>
        /// Metodo para registrar Grupos
        /// </summary>
        /// <param name="pgrupo">prupo</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public void registrarGrupo(Grupo pgrupo)
        {
            PersForo psForo = new PersForo();

            Parametro pcodigo = new Parametro("pcodigo", pgrupo.Codigo);
            Parametro pnombre = new Parametro("pnombre", pgrupo.Nombre);
            Parametro pperiodo = new Parametro("pperiodo", pgrupo.Periodo);
            Parametro pidCurso = new Parametro("pid_curso", pgrupo.IdCurso);

            Parametro[] parametros = { pcodigo, pnombre, pperiodo, pidCurso };

            String sql = "INSERT INTO T_Grupo (codigo_grupo,nombre_grupo,periodo,id_curso) " +
                    "VALUES (pcodigo,pnombre,pperiodo,pid_curso)";

           
            try
            {
                Acceso.EjecutarSQL(sql, parametros);
                (new PersCurso()).activarCurso(pgrupo.IdCurso);
            }
            catch (Exception e)
            {
                throw e;
                //StrGrupo str = buscarGrupoExistente(pgrupo.Codigo);
              //  pgrupo.IdGrupo = Convert.ToInt32(pgrupo.IdGrupo);
               // modificarGrupo(pgrupo);
            }

        }

        /// <summary>
        /// Metodo para modificar Grupos
        /// </summary>
        /// <param name="pgrupo">prupo</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public void modificarGrupo(Grupo pgrupo)
        {
            PersForo psForo = new PersForo();

            Parametro pidGrupo = new Parametro("pid_grupo", pgrupo.IdGrupo);
            Parametro pcodigo = new Parametro("pcodigo", pgrupo.Codigo);
            Parametro pnombre = new Parametro("pnombre", pgrupo.Nombre);
            Parametro pperiodo = new Parametro("pperiodo", pgrupo.Periodo);
            Parametro pidCurso = new Parametro("pid_curso", pgrupo.IdCurso);
            Parametro pestado = new Parametro("pestado", pgrupo.Estado);
            Parametro[] parametros = { pcodigo, pnombre, pperiodo, pidCurso, pestado, pidGrupo };

            String sql = "UPDATE T_Grupo SET [codigo_grupo] = pcodigo,[nombre_grupo] = pnombre," +
                "[periodo] = pperiodo,[id_curso] = pid_curso,[estado] = pestado,"+
                "eliminado = 0 WHERE T_Grupo.id_grupo = pid_grupo";
            try
            {
                Acceso.EjecutarSQL(sql, parametros);
                (new PersCurso()).activarCurso(pgrupo.IdCurso);
                Foro foro = new Foro(pgrupo.IdGrupo, pgrupo.Nombre);
                psForo.modificarForo(foro);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo para eliminar Grupos
        /// </summary>
        /// <param name="pid">pid</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public void eliminarGrupo(int pid)
        {
            
            Parametro pidGrupo = new Parametro("id_grupo", pid);

            String sql = "sp_eliminarGrupo";
            try
            {
                Acceso.EjecutarSQLSelect(sql, pidGrupo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca un grupo por su Id
        /// </summary>
        /// <param name="pid">pid</param>
        /// <returns>Un StrGrupo</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public StrGrupo buscarGrupoPorId(int pid)
        {
          
            IDataReader dr;
            Parametro pidGrupo = new Parametro("id_grupo", pid);
            Parametro[] parametros = { pidGrupo };

            String sql = "sp_buscarGrupoPorId";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, parametros);
                dr.Read();
                StrGrupo grupo = new StrGrupo(
                       dr.GetInt32(0).ToString(),
                       dr.GetString(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4),
                       dr.GetString(5),
                       dr.GetInt32(6).ToString());
                dr.Close();
                return grupo;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que permite buscar grupos.
        /// </summary>
        /// <returns>Lista de StrGrupo</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public List<StrGrupo> buscarGrupos()
        {
            IDataReader dr;
            StrGrupo grupo;
       
            String sql = "sp_listarGrupos";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, new Parametro[0]);
                List<StrGrupo> grupos = new List<StrGrupo>();
                while(dr.Read())
                {
                       grupo = new StrGrupo(
                       dr.GetInt32(0).ToString(),
                       dr.GetString(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4),
                       dr.GetString(5),
                       dr.GetInt32(6).ToString());
                    grupos.Add(grupo);
                }
            dr.Close();
            return grupos;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Metodo que busca grupos solamente por su codigo
        /// </summary>
        /// <param name="pcodigo">pcodigo</param>
        /// <returns>Lista de StrGrupo</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public List<StrGrupo> buscarGrupoPorCodigo(String pcodigo)
        {
            IDataReader dr;
            Parametro pcodigoGrupo = new Parametro("codigo_grupo", pcodigo);
            List<StrGrupo> grupos = new List<StrGrupo>();
            StrGrupo grupo;
            
            String sql = "sp_buscarGrupoPorCodigo";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pcodigoGrupo);
                while (dr.Read())
                {
                    grupo = new StrGrupo(
                      dr.GetInt32(0).ToString(),
                      dr.GetString(1),
                      dr.GetString(2),
                      dr.GetString(3),
                      dr.GetString(4),
                     dr.GetString(5),
                     dr.GetInt32(6).ToString());
                    grupos.Add(grupo);
                }
                dr.Close();
                return grupos;
              

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca grupos solamente por su codigo
        /// </summary>
        /// <param name="pcodigo">pcodigo</param>
        /// <returns>Lista de StrGrupo</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public StrGrupo buscarGrupoExistente(String pcodigo)
        {
            IDataReader dr;
            Parametro pcodigoGrupo = new Parametro("codigo_grupo", pcodigo);
            
            StrGrupo grupo;

            String sql = "sp_buscarGrupoExistente";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pcodigoGrupo);
                dr.Read();
                {
                    grupo = new StrGrupo(
                      dr.GetInt32(0).ToString(),
                      dr.GetString(1),
                      dr.GetString(2),
                      dr.GetString(3),
                      dr.GetString(4),
                     dr.GetString(5),
                     dr.GetInt32(6).ToString());
                  
                }
                dr.Close();
                return grupo;


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca grupos solamente por su nombre
        /// </summary>
        /// <param name="pnombre"></param>
        /// <returns></returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public List<StrGrupo> buscarGrupoPorNombre(String pnombre)
        {
            IDataReader dr;
            Parametro pnombreGrupo = new Parametro("nombre", pnombre);
            StrGrupo grupo;
            List<StrGrupo> grupos = new List<StrGrupo>();
            String sql = "sp_buscarGrupoPorNombre";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pnombreGrupo);
                while (dr.Read())
                {
                    grupo = new StrGrupo(
                      dr.GetInt32(0).ToString(),
                      dr.GetString(1),
                      dr.GetString(2),
                      dr.GetString(3),
                      dr.GetString(4),
                     dr.GetString(5),
                     dr.GetInt32(6).ToString());
                    grupos.Add(grupo);
                }
                dr.Close();
                return grupos;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método que se encarga de asignar un profesor a un grupo
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idGrupo"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public void asignarProfesorAGrupo(int idUsuario, int idGrupo)
        {
            int idRol = 0;
            PersRol persRol = new PersRol();
            List<StrRol> listaRoles = persRol.listarRoles();

            foreach (StrRol rol in listaRoles)
            {
                if (rol.Nombre.Equals("Profesor"))
                {
                    idRol = int.Parse(rol.IdRol);
                    break;
                }
            }

            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            Parametro pidGrupo = new Parametro("pidGrupo", idGrupo);
            Parametro pidRol = new Parametro("pidRol", idRol);

            String sql = "Insert Into T_UsuarioXGrupo (id_usuario, id_grupo, id_rol) " +
                        "VALUES(pidUsuario, pidGrupo, pidRol)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidGrupo, pidRol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que se encarga de asignar un estudiante a un grupo
        /// </summary>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idGrupo">Id del grupo</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void asignarEstudianteAGrupo(int idUsuario, int idGrupo)
        {
            int idRol = 0;
            PersRol persRol = new PersRol();
            List<StrRol> listaRoles = persRol.listarRoles();

            foreach (StrRol rol in listaRoles)
            {
                if (rol.Nombre.Equals("Estudiante")) {
                    idRol = int.Parse(rol.IdRol);
                    break;
                }
            }

            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            Parametro pidGrupo = new Parametro("pidGrupo", idGrupo);
            Parametro pidRol = new Parametro("pidRol", idRol);

            String sql = "Insert Into T_UsuarioXGrupo (id_usuario, id_grupo, id_rol) " +
                        "VALUES(pidUsuario, pidGrupo, pidRol)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidGrupo, pidRol);
                activarGrupo(idGrupo);

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Método para cambiar
        /// </summary>
        /// <param name="pidGrupo"></param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public void activarGrupo(int pidGrupo){
            StrGrupo strGrupo = buscarGrupoPorId(pidGrupo);
            Grupo grupo = new Grupo(Convert.ToInt32(strGrupo.IdGrupo),
                Convert.ToInt32(strGrupo.IdCurso),
                strGrupo.Codigo,strGrupo.Nombre,strGrupo.Periodo,true);
            modificarGrupo(grupo);
        }

        /// <summary>
        /// Metodo que se encarga de desasignar un usuario a un grupo
        /// </summary>
        /// <param name="nombreRol">Nombre del rol del usuario</param>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idGrupo">Id del grupo</param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        internal void eliminarAsignacionUsuario(String nombreRol, int idUsuario, int idGrupo)
        {
            int idRol = 0;
            PersRol persRol = new PersRol();
            List<StrRol> listaRoles = persRol.listarRoles();

            foreach (StrRol rol in listaRoles)
            {
                if (rol.Nombre.Equals(nombreRol))
                {
                    idRol = int.Parse(rol.IdRol);
                    break;
                }
            }

            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            Parametro pidGrupo = new Parametro("pidGrupo", idGrupo);
            Parametro pidRol = new Parametro("pidRol", idRol);

            String sql = "DELETE FROM T_UsuarioXGrupo " +
                        "WHERE id_usuario = pidUsuario AND id_grupo = pidGrupo AND id_rol = pidRol";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidGrupo, pidRol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que se encarga de desasignar un profesor de un grupo
        /// </summary>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idGrupo">Id del grupo</param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public void eliminarAsignacionProfesor(int idUsuario, int idGrupo)
        {
            eliminarAsignacionUsuario("Profesor", idUsuario, idGrupo);
        }

        /// <summary>
        /// Metodo que se encarga de desasignar un estudiante a un grupo
        /// </summary>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idGrupo">Id del grupo</param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public void eliminarAsignacionEstudiante(int idUsuario, int idGrupo)
        {
            eliminarAsignacionUsuario("Estudiante", idUsuario, idGrupo);
        }

        public List<StrGrupo> buscarGruposPorIdCurso(int idCurso)
        {
            IDataReader dr;
            Parametro pidCurso = new Parametro("idCurso", idCurso);
            List<StrGrupo> grupos = new List<StrGrupo>();
            String sql = "sp_GruposPorCurso";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidCurso);
                while (dr.Read())
                {
                    grupos.Add(new StrGrupo(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(3),
                        dr.GetInt32(6).ToString()));
                }
                dr.Close();
                return grupos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrGrupo> buscarGruposPorIdCurso(string nombreCurso)
        {
            IDataReader dr;
            Parametro pnombreCurso = new Parametro("nombreCurso", nombreCurso);
            List<StrGrupo> grupos = new List<StrGrupo>();
            String sql = "sp_GruposPorCursoNombre";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pnombreCurso);
                while (dr.Read())
                {
                    grupos.Add(new StrGrupo(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(3),
                        dr.GetInt32(6).ToString()));
                }
                dr.Close();
                return grupos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
