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
    public class PersBitacora : PersistAbstracto
    {
        internal void registrarBitacora(Bitacora Bitacora)
        {
            Parametro pidUsuario = new Parametro("pidUsuario", Bitacora.IdUsuario);
            Parametro pfecha = new Parametro("pfecha", Bitacora.Fecha);
            Parametro pdescripcion = new Parametro("pdescripcion", Bitacora.Descripcion);

            String sql = "INSERT INTO T_Bitacora (id_usuario, fecha, descripcion) " +
            "VALUES (pidUsuario, pfecha, pdescripcion)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pfecha, pdescripcion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrBitacora> buscarBitacoraPorUsuario(int idUsuario)
        {
            IDataReader dr;
            Parametro pidUsuario = new Parametro("idUsuario", idUsuario);

            String sql = "sp_buscarBitacora";

            try
            {
                StrBitacora bitacora;
                List<StrBitacora> lista = new List<StrBitacora>();

                dr = Acceso.EjecutarSQLSelect(sql, pidUsuario);
                while (dr.Read())
                {
                    bitacora = new StrBitacora(
                            dr.GetInt32(0).ToString(),
                            dr.GetString(3),
                            dr.GetDateTime(2).ToShortDateString(),
                            dr.GetInt32(1).ToString());
                    lista.Add(bitacora);
                }
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal List<StrBitacora> buscarBitacoraPorRol(String nombreRol)
        {
            IDataReader dr;
            Parametro pidUsuario = new Parametro("nombreRol",    nombreRol);

            String sql = "sp_buscarBitacoraPorRol";

            try
            {
                StrBitacora bitacora;
                List<StrBitacora> lista = new List<StrBitacora>();

                dr = Acceso.EjecutarSQLSelect(sql, pidUsuario);
                while (dr.Read())
                {
                    bitacora = new StrBitacora(
                            dr.GetInt32(0).ToString(),
                            dr.GetString(3),
                            dr.GetDateTime(2).ToShortDateString(),
                            dr.GetInt32(1).ToString());
                    lista.Add(bitacora);
                }
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
