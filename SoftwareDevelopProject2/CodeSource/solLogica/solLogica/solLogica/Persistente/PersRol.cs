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
    public class PersRol : PersistAbstracto
    {
        internal void registrarRol(Rol rol)
        {
            Parametro pnombre = new Parametro("pnombre", rol.Nombre);

            String sql = "INSERT INTO [BDStarCommunitySystem].[dbo].[T_Rol] ([nombre_rol])" +
                "VALUES(pnombre)";
            try
            {
                Acceso.EjecutarSQL(sql,pnombre);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void modificarRol(Rol rol)
        {
            Parametro pIdRol = new Parametro("pIdRol", rol.IdRol);
            Parametro pnombre = new Parametro("pnombre", rol.Nombre);

            String sql = "UPDATE [BDStarCommunitySystem].[dbo].[T_Rol] " +
                "SET [nombre_rol] = pnombre " +
                "WHERE dbo.T_Rol.id_rol = pIdRol";
            try
            {
                Acceso.EjecutarSQL(sql, pnombre, pIdRol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal StrRol buscarRolPorId(int pidRol)
        {
            IDataReader dr;
            Parametro idRol = new Parametro("idRol", pidRol);

            String sql = "sp_BuscarRolPorId";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idRol);
                dr.Read();
                StrRol rol = new StrRol(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1));
                dr.Close();
                return rol;

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        internal List<StrRol> listarRoles()
        {
            IDataReader dr;
            List<StrRol> roles = new List<StrRol>();
            String sql = "sp_ListarRoles";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql);
                while(dr.Read())
                {
                    roles.Add(new StrRol(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1)));
                }
                dr.Close();
                return roles;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método que busca los roles de un usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        internal List<StrRol> buscarRolesPorUsuario(int idUsuario)
        {
            IDataReader dr;
            List<StrRol> roles = new List<StrRol>();
            String sql = "sp_buscarRolesPorUsuario";
            Parametro pidUsuario = new Parametro("idUsuario", idUsuario);

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidUsuario);
                while (dr.Read())
                {
                    roles.Add(new StrRol(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1)));
                }
                dr.Close();
                return roles;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void eliminarRol(int pid)
        {
            Parametro pidRol = new Parametro("id_rol", pid);
            Parametro[] parametros = { pidRol };

            String sql = "sp_eliminarRol";
            try
            {
                Acceso.EjecutarSQLSelect(sql, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método que se encarga de asignar varios permisos a un rol
        /// </summary>
        /// <param name="idsPermisos"></param>
        /// <param name="idRol"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public void asignarPermisosARol(List<int> idsPermisos, int idRol)
        {
            try
            {
                Parametro pidRol = new Parametro("pidRol", idRol);
                Acceso.EjecutarSQL("DELETE FROM T_PermisoXRol WHERE id_rol = pidRol", pidRol);

                String sql = "INSERT INTO  T_PermisoXRol (id_permiso, id_rol) " +
                    "VALUES (pidPermiso, pidRol)";

                foreach (int idPermiso in idsPermisos)
                {
                    Parametro pidPermiso = new Parametro("pidPermiso", idPermiso);
                    Acceso.EjecutarSQL(sql, pidRol, pidPermiso);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que se encarga de asignar un rol a un usuario
        /// </summary>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idRol">Id del Rol</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void asignarRolAUnUsuario(int idUsuario, int idRol)
        {

            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            Parametro pidRol = new Parametro("pidRol", idRol);

            String sql = "Insert Into T_UsuarioXRol (id_usuario, id_rol) " +
                        "VALUES(pidUsuario, pidRol)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidRol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void eliminarAsignacionDeUsuario(int idUsuario, int idRol)
        {
            Parametro pIdUsuario = new Parametro("pIdUsuario", idUsuario);
            Parametro pIdRol = new Parametro("pIdRol", idRol);

            String sql = "DELETE FROM [BDStarCommunitySystem].[dbo].[T_UsuarioXRol] " +
                         "WHERE id_usuario= pIdUsuario AND id_rol=pIdRol";

            try
            {
                Acceso.EjecutarSQL(sql, pIdUsuario, pIdRol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
