using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;
using System.Collections;

namespace solLogica.Gestor
{
    public static class GestorPermiso
    {
        /// <summary>
        /// Lista todos los Permisos activos del Sistema
        /// </summary>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static List<StrPermiso> listarPermiso()
        {
            PersPermiso perspermiso = new PersPermiso();
            return perspermiso.listarPermisos();
        }

        /// <summary>
        /// Lista los permisos de un rol
        /// </summary>
        /// <param name="idRol"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<StrPermiso> buscarPermisosPorRol(int idRol)
        {
            PersPermiso perspermiso = new PersPermiso();
            return perspermiso.buscarPermisosPorRol(idRol);
        }


        /// <summary>
        /// Lista los permisos de un rol, pero devuelve una lista con
        /// los permisos de todo el sistema para la IU
        /// </summary>
        /// <param name="idRol"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<Hashtable> buscarPermisosPorRolIU(int idRol)
        {
            List<StrPermiso> listaPermisos = listarPermiso();
            List<StrPermiso> permisosRol = buscarPermisosPorRol(idRol);

            List<Hashtable> result = new List<Hashtable>();

            foreach(StrPermiso permiso in listaPermisos) {
                Hashtable r = new Hashtable();
                r.Add("permiso", permiso);
                r.Add("checked", (permisosRol.IndexOf(permiso) != -1));

                result.Add(r);
            }

            return result;
        }
    }
}
