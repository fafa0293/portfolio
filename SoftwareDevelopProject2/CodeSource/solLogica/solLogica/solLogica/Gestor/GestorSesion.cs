using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Estructura;
using solLogica.Persistente;

namespace solLogica.Gestor
{
    public class GestorSesion
    {
        private static Usuario _usuario = null;
        private static Boolean _sesionIniciada = false;

        /// <summary>
        /// Metodo encargado del inicio de sesion al sistema
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static Boolean iniciarSesion(String pusuario, String pcontrasenna, String nombreApp){
            Boolean sesionIniciada = false;
            
            String contrasennaCifrada = GestorSeguridad.cifrarContrasenna(pcontrasenna);
            PersUsuario pers = new PersUsuario();

            try
            {
                StrUsuario varUsuario = pers.buscarUsuarioSesion(pusuario, contrasennaCifrada);

                Usuario usuario = new Usuario(
                varUsuario.Nombre,
                varUsuario.Apellido1,
                varUsuario.Apellido2,
                varUsuario.Cedula,
                varUsuario.Carnet,
                Convert.ToChar(varUsuario.Genero),
                varUsuario.Correo,
                varUsuario.Contrasenna,
                Convert.ToDateTime(varUsuario.FechaNacimiento),
                varUsuario.Direccion,
                varUsuario.TelefonoFijo,
                varUsuario.TelefonoCelular,
                Convert.ToInt32(varUsuario.idUsuario));

                setUsuario(usuario);

                if (nombreApp == "local")
                {
                    if (usuarioTienePermiso("utilizarAplicacionLocal"))
                    {
                        sesionIniciada = true;
                    }
                    else
                    {
                        setUsuario(null);
                    }
                }
                else
                {
                    sesionIniciada = true;
                }
                setInicioSesion(sesionIniciada);
                return sesionIniciada;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Método que retorna el nombre completo del usuario actual
        /// </summary>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static String getNombreCompletoUsuario()
        {
            if (_usuario == null)
            {
                return "";
            }

            return String.Format("{0} {1} {2}", _usuario.Nombre, _usuario.Apellido1, _usuario.Apellido2);
        }

        /// <summary>
        /// Metodo setear la sesion activa
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        private static void setInicioSesion(bool psesionIniciada)
        {
            _sesionIniciada = psesionIniciada;
        }

        /// <summary>
        /// Metodo encargado de setear el usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        private static void setUsuario(Usuario varUsuario)
        {
            _usuario = varUsuario;
        }

        /// <summary>
        /// Método que retorna si el usuario actual tiene el permiso con el nombrePermiso
        /// </summary>
        /// <param name="nombrePermiso"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static Boolean usuarioTienePermiso(String nombrePermiso)
        {
            if (_usuario == null)
            {
                return false;
            }

            List<StrRol> listaRoles = (new PersRol()).buscarRolesPorUsuario(_usuario.IdUsuario);

            foreach (StrRol rol in listaRoles)
            {
                List<StrPermiso> listaPermisos = (new PersPermiso()).buscarPermisosPorRol(Convert.ToInt32(rol.IdRol));

                foreach (StrPermiso permiso in listaPermisos)
                {
                    if (permiso.Nombre.Equals(nombrePermiso))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Método que retorna el id del usuario actual
        /// </summary>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static int getIdUsuario()
        {
           return _usuario.IdUsuario;
        }

        /// <summary>
        /// Metodo encargado de obtener la contrasenna ddel usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static String getContrasennaUsuario()
        {
           return _usuario.Contrasenna;
        }

        /// <summary>
        /// Metodo encargado del inicio de sesion al sistema
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static void cerrarSesion()
        {
            setUsuario(null);
            setInicioSesion(false);
        }

        /// <summary>
        /// Metodo encargado del cierre de sesion
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static bool sesionIniciada()
        {
            return _sesionIniciada;
        }

        public static Boolean usuarioTieneRol(String rol)
        {
            return GestorUsuario.buscarUsuarioPorRol(rol).Contains(
                GestorUsuario.buscarUsuarioPorId(getIdUsuario()));
        }
    }
}
