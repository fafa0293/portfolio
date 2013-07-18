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
    public class PersPermiso : PersistAbstracto
    {


        internal List<StrPermiso> listarPermisos()

        {
            IDataReader dr;
           
            String sql = "sp_ListarPermisos";

            try
            {
                StrPermiso permiso;
                List<StrPermiso> lista = new List<StrPermiso>();

                dr = Acceso.EjecutarSQLSelect(sql);
                while (dr.Read())
                {
                    permiso = new StrPermiso(
                            dr.GetInt32(0).ToString(),
                            dr.GetString(1),
                            dr.GetString(2));
                    lista.Add(permiso);
                }
                dr.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

         public List<StrPermiso> buscarPermisosPorRol(int idRol)
         {
             IDataReader dr;

             String sql = "sp_buscarPermisoPorRol";
             Parametro pidRol = new Parametro("idRol", idRol);

             try
             {
                 StrPermiso permiso;
                 List<StrPermiso> lista = new List<StrPermiso>();

                 dr = Acceso.EjecutarSQLSelect(sql, pidRol);
                 while (dr.Read())
                 {
                     permiso = new StrPermiso(
                             dr.GetInt32(0).ToString(),
                             dr.GetString(1),
                             dr.GetString(2));
                     lista.Add(permiso);
                 }
                 dr.Close();
                 return lista;
             }
             catch (Exception e)
             {
                 throw e;
             }
         }
    }
}
