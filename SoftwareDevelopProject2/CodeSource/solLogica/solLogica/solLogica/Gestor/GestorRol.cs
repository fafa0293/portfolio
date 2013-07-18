using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public static class GestorRol
    {

        /// <summary>
        /// Registra un nuevo Rol en el Sistema
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static void registrarRol(String nombre)
        {
            Rol rol = new Rol(nombre);
            (new PersRol()).registrarRol(rol);
            GestorBitacora.registrarBitacora("Creó el rol: " + nombre +".");
        }

        /// <summary>
        /// Modifica un Rol que ya ha sido registro en el Sistema
        /// </summary>
        /// <param name="idRol"></param>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static void modificarRol(int idRol, String nombre)
        {
            Rol rol = new Rol(idRol, nombre);
            (new PersRol()).modificarRol(rol);
            GestorBitacora.registrarBitacora("Modificó el rol: " + nombre + ".");
        }

        /// <summary>
        /// Elimina un Rol del Sistema
        /// </summary>
        /// <param name="idRol"></param>
        /// <remarks>Autor: Dylhann Obando Mckenzie</remarks>
        public static void eliminarRol(int pidRol)
        {
            PersRol psRol= new PersRol();
            StrRol rol = psRol.buscarRolPorId(pidRol);
            psRol.eliminarRol(pidRol);
            GestorBitacora.registrarBitacora("Eliminó el rol: " + rol.Nombre + ".");
        }

        /// <summary>
        /// Lista todos los roles activos del sistema
        /// </summary>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static List<StrRol> listarRoles()
        {
            List<StrRol> roles = (new PersRol()).listarRoles();
            //GestorBitacora.registrarBitacora("Listó todos los roles.");
            return roles;
        }

        /// <summary>
        /// Asigna un Permiso a un Rol
        /// </summary>
        /// <param name="idsPermiso"></param>
        /// <param name="idRol"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static void asignarPermisosARol(List<int> idsPermisos, int idRol)
        {
            PersRol pr = new PersRol();
            StrRol rol = pr.buscarRolPorId(idRol);
            pr.asignarPermisosARol(idsPermisos, idRol);

            GestorBitacora.registrarBitacora(
                String.Format("asignó permisos ({0}) al rol {1}",
                String.Join(", ", idsPermisos),
                rol.Nombre));
        }


        public static StrRol buscarRolPorId(int idRol)
        {
            StrRol rol=(new PersRol()).buscarRolPorId(idRol);

            return rol;
        }

        /// <summary>
        /// Metodo que se encarga de asignar un rol a un usuario
        /// </summary>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idRol">Id del rol</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void asignarRolAUsuario(int idUsuario, int idRol)
        {
       

            PersUsuario _persUsuario = new PersUsuario();
            PersRol _persRol = new PersRol();

            StrRol _rol = _persRol.buscarRolPorId(idRol);
            StrUsuario _usuario = _persUsuario.buscarUsuarioPorId(idUsuario);

            _persRol.asignarRolAUnUsuario(idUsuario, idRol);

            GestorBitacora.registrarBitacora(String.Format("Asignó el Rol " +
            "{0} al Usuario {1}",  _rol.Nombre, _usuario.Nombre + " " + _usuario.Apellido1 + " " + _usuario.Apellido2));

        }

        /// <summary>
        /// Método para eliminar asignacion de rol a usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idRol"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static void eliminarAsignacion(int idUsuario, int idRol)
        {
            (new PersRol()).eliminarAsignacionDeUsuario(idUsuario, idRol);
        }

    }
}
