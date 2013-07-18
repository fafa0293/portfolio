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
    public class PersAporte : PersistAbstracto
    {
        internal void registrarAporte(int idTema, int idUsuario, String contenido, DateTime fecha)
        {
            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);
            Parametro pidTema = new Parametro("pidTema", idTema);
            Parametro pfecha = new Parametro("pfecha", fecha);
            Parametro pcontenido = new Parametro("pcontenido", contenido);

            String sql = "INSERT INTO T_Aporte (id_usuario, id_tema, fecha, contenido) " +
            "VALUES (pidUsuario, pidTema, pfecha, pcontenido)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidTema, pfecha, pcontenido);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrAporte> buscarAportePorIdTema(int pid)
        {
            IDataReader dr;
            Parametro pidTema = new Parametro("idTema", pid);

            String sql = "sp_AportesPorTema";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidTema);
                StrAporte aporte;
                List<StrAporte> aportes = new List<StrAporte>();
                while (dr.Read())
                {
                    String cali = "N/A";
                    if (!dr.IsDBNull(4))
                    {
                        cali = dr.GetInt32(4).ToString();
                    }
                    aporte = new StrAporte(
                        dr.GetInt32(0).ToString(),
                        dr.GetInt32(1).ToString(),
                        dr.GetInt32(5).ToString(),
                        dr.GetDateTime(2).ToString(),
                        dr.GetString(3),
                        cali,
                        dr.GetString(6) + " " + dr.GetString(7) + " " + dr.GetString(8));
                    aportes.Add(aporte);
                }
                dr.Close();
                return aportes;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


         /// <summary>
        /// Metodo que se encarga de traer una estructura de aporte
        /// </summary>
        /// <param name="idTema">Id del aporte</param>
        /// <remarks>Author: Jonathan Jara Morales</remarks>
        internal StrAporte buscarAportePorId(int idAporte)
        {
            IDataReader dr;
            Parametro pidAporte = new Parametro("idAporte", idAporte);
            String sql = "sp_buscarAportePorId";

            try
            {

                StrAporte aporte;
                dr = Acceso.EjecutarSQLSelect(sql, pidAporte);
                dr.Read();
                aporte = new StrAporte(
                        dr.GetInt32(0).ToString(),
                        dr.GetInt32(1).ToString(),
                        dr.GetInt32(5).ToString(),
                        dr.GetDateTime(2).ToString(),
                        dr.GetString(3),
                        dr.GetInt32(4).ToString(),
                        dr.GetString(6) + " " + dr.GetString(7) + " " + dr.GetString(8));
                dr.Close();
                return aporte;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void calificarAporte(int idAporte, int calificacion)
        {
            String sql = "UPDATE T_Aporte SET calificacion = pcalificacion WHERE id_aporte = pidAporte";
            Parametro pidAporte = new Parametro("pidAporte", idAporte);
            Parametro pcalificacion = new Parametro("pcalificacion", calificacion);

            Acceso.EjecutarSQLSelect(sql, pidAporte, pcalificacion);
        }
    }
}
