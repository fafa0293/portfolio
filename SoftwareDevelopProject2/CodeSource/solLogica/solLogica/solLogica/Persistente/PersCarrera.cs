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
    internal class PersCarrera : PersistAbstracto
    {
        public void registrarCarrera(Carrera carrera)
        {
            Parametro pcodigo = new Parametro("pcodigo", carrera.Codigo);
            Parametro pnombre = new Parametro("pnombre", carrera.Nombre);

            String sql = "INSERT INTO T_Carrera (codigo_carrera, nombre_carrera) " +
            "VALUES (pcodigo, pnombre)";

            try
            {
                Acceso.EjecutarSQL(sql, pcodigo, pnombre);
            }
            catch (Exception e)
            {
                StrCarrera str = buscarCarreraExistente(carrera.Codigo);
                carrera.IdCarrera = Convert.ToInt32(str.IdCarrera);
                modificarCarrera(carrera);
            }
        }

        public void modificarCarrera(Carrera carrera)
        {
            Parametro pidCarrera = new Parametro("pidCarrera", carrera.IdCarrera);
            //Parametro pcodigo = new Parametro("pcodigo", carrera.Codigo);
            Parametro pnombre = new Parametro("pnombre", carrera.Nombre);

            String sql = "UPDATE T_Carrera "+
            "SET nombre_carrera = pnombre, eliminado = 0 "+
            "WHERE id_carrera = pidCarrera";

            try
            {
                Acceso.EjecutarSQL(sql, pnombre, pidCarrera);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void eliminarCarrera(int idCarrera)
        {
            Parametro pidCarrera = new Parametro("id_Carrera", idCarrera);

            String sql = "sp_eliminarCarrera";


            try
            {
                Acceso.EjecutarSQLSelect(sql, pidCarrera);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public StrCarrera buscarCarreraPorId(int idCarrera)
        {
            IDataReader dr;
            Parametro pidCarrera = new Parametro("idCarrera", idCarrera);

            String sql = "sp_buscarCarrera";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidCarrera);
                dr.Read();
                StrCarrera carrera = new StrCarrera(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetInt32(3).ToString());
                dr.Close();
                return carrera;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrCarrera> listarCarreras()
        {
            return buscarCarreras(null, null);
        }

        public List<StrCarrera> buscarCarreras(String nombre, String codigo)
        {
            IDataReader dr;
            Parametro pnombre = new Parametro("nombre", nombre);
            Parametro pcodigo = new Parametro("codigo", codigo);

            String sql = "sp_buscarCarrera";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pnombre, pcodigo);
                List<StrCarrera> listaCarreras = new List<StrCarrera>();
                StrCarrera carrera;

                while (dr.Read())
                {
                    carrera = new StrCarrera(
                        dr.GetInt32(0).ToString(), 
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetInt32(3).ToString());

                    listaCarreras.Add(carrera);
                }
                dr.Close();
                return listaCarreras;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public StrCarrera buscarCarreraExistente(String codigo)
        {
            IDataReader dr;
            Parametro pcodigo = new Parametro("codigo", codigo);

            String sql = "sp_buscarCarreraExistente";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pcodigo);           
                StrCarrera carrera;
                dr.Read(); 
                carrera = new StrCarrera(
                    dr.GetInt32(0).ToString(),
                    dr.GetString(1),
                    dr.GetString(2));
                dr.Close();
                return carrera;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void asignarCursoACarrera(int idCurso, int idCarrera)
        {
            Parametro pIdCurso = new Parametro("pIdCurso", idCurso);
            Parametro pIdCarrera = new Parametro("pIdCarrera", idCarrera);

            String sql = "INSERT INTO [BDStarCommunitySystem].[dbo].[T_CursoXCarrera] ([id_carrera],[id_curso]) "+
                        "VALUES(pIdCarrera,pIdCurso)";

            try
            {
                Acceso.EjecutarSQL(sql, pIdCurso, pIdCarrera);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void eliminarAsignacionDeCurso(int idCurso, int idCarrera)
        {
            Parametro pIdCurso = new Parametro("pIdCurso", idCurso);
            Parametro pIdCarrera = new Parametro("pIdCarrera", idCarrera);

            String sql = "DELETE FROM [BDStarCommunitySystem].[dbo].[T_CursoXCarrera] "+
                         "WHERE id_carrera= pIdCarrera AND id_curso=pIdCurso";

            try
            {
                Acceso.EjecutarSQL(sql, pIdCurso, pIdCarrera);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método que se encarga de desasignar un director académico de una carrera
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idCarrera"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public void eliminarAsignacionDeDirectorAcademico(int idUsuario, int idCarrera)
        {
            int idRol = 0;
            PersRol persRol = new PersRol();
            List<StrRol> listaRoles = persRol.listarRoles();

            foreach (StrRol rol in listaRoles)
            {
                if (rol.Nombre.Equals("Director Académico"))
                {
                    idRol = int.Parse(rol.IdRol);
                    break;
                }
            }

            Parametro pIdUsuario = new Parametro("pIdUsuario", idUsuario);
            Parametro pIdCarrera = new Parametro("pIdCarrera", idCarrera);
            Parametro pIdRol = new Parametro("pIdRol", idRol);

            String sql = "DELETE FROM [BDStarCommunitySystem].[dbo].[T_UsuarioXCarrera] " +
                         "WHERE id_carrera= pIdCarrera AND id_usuario=pIdUsuario AND id_rol = pIdRol";
            try
            {
                Acceso.EjecutarSQL(sql, pIdUsuario, pIdCarrera, pIdRol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        ///  Método que se encarga de asignar un director académico a una carrera
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idCarrera"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public void asignarDirectorAcademicoACarrera(int idUsuario, int idCarrera)
        {
            int idRol = 0;
            PersRol persRol = new PersRol();
            List<StrRol> listaRoles = persRol.listarRoles();

            foreach (StrRol rol in listaRoles)
            {
                if (rol.Nombre.Equals("Director Académico"))
                {
                    idRol = int.Parse(rol.IdRol);
                    break;
                }
            }

            Parametro pIdUsuario = new Parametro("pIdUsuario", idUsuario);
            Parametro pIdCarrera = new Parametro("pIdCarrera", idCarrera);
            Parametro pIdRol = new Parametro("pIdRol", idRol);

            String sql = "INSERT INTO [BDStarCommunitySystem].[dbo].[T_UsuarioXCarrera] ([id_carrera],[id_usuario],[id_rol]) " +
                        "VALUES(pIdCarrera, pIdUsuario, pIdRol)";
            try
            {
                Acceso.EjecutarSQL(sql, pIdUsuario, pIdCarrera, pIdRol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
