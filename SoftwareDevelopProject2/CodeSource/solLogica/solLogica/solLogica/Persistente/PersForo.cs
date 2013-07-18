using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Estructura;
using solLogica.Clase;
using AccesoBD;
using System.Data;

namespace solLogica.Persistente
{
    internal class PersForo : PersistAbstracto
    {
        public void registrarForo(Foro pforo)
        {
            Parametro pidGrupo = new Parametro("pid_grupo", pforo.IdGrupo);
            Parametro pnombre = new Parametro("pnombre", pforo.NombreForo);

            Parametro[] parametros = { pidGrupo, pnombre, };

            String sql = "INSERT INTO T_Foro ([nombre_foro],[id_grupo]) VALUES (pnombre,pid_grupo)";
            try
            {
                Acceso.EjecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void modificarForo(Foro pforo)
        {
            Parametro pidGrupo = new Parametro("pid_grupo", pforo.IdGrupo);
            Parametro pnombre = new Parametro("pnombre", pforo.NombreForo);

            Parametro[] parametros = { pidGrupo, pnombre,};

            String sql = "UPDATE T_Foro SET nombre_foro = pnombre, eliminado = 0 "+
                "WHERE id_grupo = pid_grupo";
            try
            {
                Acceso.EjecutarSQL(sql, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public StrForo buscarForoPorGrupo(int pid){
            IDataReader dr;
            Parametro pidGrupo = new Parametro("id_grupo", pid);
            Parametro[] parametros = { pidGrupo };

            String sql = "sp_buscarForoPorGrupo";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, parametros);
                dr.Read();
                StrForo foro = new StrForo(
                       dr.GetInt32(0).ToString(),
                       dr.GetInt32(1).ToString(),
                       dr.GetInt32(2).ToString(),
                       dr.GetString(3),
                       dr.GetInt32(4).ToString(),
                       dr.GetInt32(5).ToString()
                       );
                      
                dr.Close();
                return foro;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrForo> listarForos(int pidUsuario)
        {
            IDataReader dr;
            Parametro idUsuario = new Parametro("idUsuario", pidUsuario);

            String sql = "sp_ListarForoUsuario";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idUsuario);
                StrForo foro;
                List<StrForo> foros = new List<StrForo>();
                while (dr.Read())
                {

                    foro = new StrForo(
                       dr.GetInt32(0).ToString(),
                       dr.GetInt32(1).ToString(),
                       dr.GetInt32(2).ToString(),
                       dr.GetString(3),
                       dr.GetInt32(4).ToString(),
                       dr.GetInt32(5).ToString()
                       );
                    foros.Add(foro);
                }
                dr.Close();
                return foros;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrForo> listarForosDA(int pidUsuario)
        {
            IDataReader dr;
            Parametro idUsuario = new Parametro("idUsuario", pidUsuario);

            String sql = "sp_ListarForoDA";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idUsuario);
                StrForo foro;
                List<StrForo> foros = new List<StrForo>();
                while (dr.Read())
                {

                    foro = new StrForo(
                       dr.GetInt32(0).ToString(),
                       dr.GetInt32(1).ToString(),
                       dr.GetInt32(2).ToString(),
                       dr.GetString(3),
                       dr.GetInt32(4).ToString(),
                       dr.GetInt32(5).ToString()
                       );
                    foros.Add(foro);
                }
                dr.Close();
                return foros;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
