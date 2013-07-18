using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Estructura;
using solLogica.Persistente;
using System.Collections;

namespace solLogica.Gestor
{
    public static class GestorUsuario
    {
        /// <summary>
        /// Método para buscar un usuario por su id
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static StrUsuario buscarUsuarioPorId(int idUsuario)
        {
            PersUsuario pu = new PersUsuario();
            return pu.buscarUsuarioPorId(idUsuario);
        }

        /// <summary>
        /// Metodo que se encarga de Registrar un Usuario a la BD
        /// </summary>
        /// <param name="pnombre">Nombre de Usuario de tipo String</param>
        /// <param name="papellido1">Primer Apellido del usuario de tipo String</param>
        /// <param name="papellido2">Segundo Apellido del usuario de tipo String</param>
        /// <param name="pcedula">Cedula del usuario de tipo String</param>
        /// <param name="pcarnet">Carnet del usuario de tipo String</param>
        /// <param name="pgenero">Genero del usuario de tipo Char</param>
        /// <param name="pcorreo">Correo del usuario de tipo String</param>
        /// <param name="pcontrasenna">Contraseña del usuario de tipo String</param>
        /// <param name="pfechaNacimiento">Fecha de nacimiento del usuario de tipo DateTime</param>
        /// <param name="pdireccion">Direccion del usuario de tipo String</param>
        /// <param name="ptelefonoFijo">Telefono Fijo del usuario de tipo String</param>
        /// <param name="ptelefonoCelular">Telefono celular del usuario de tipo String</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void registrarUsuario(String pnombre, String papellido1, String papellido2, String pcedula, String pcarnet,
            Char pgenero, String pcorreo, String pcontrasenna, DateTime pfechaNacimiento, String pdireccion,
            String ptelefonoFijo, String ptelefonoCelular)
        {
            Usuario usuario = new Usuario(pnombre, papellido1, papellido2, pcedula, pcarnet,
                pgenero, pcorreo, pcontrasenna, pfechaNacimiento, pdireccion,
                ptelefonoFijo, ptelefonoCelular);

            PersUsuario pu = new PersUsuario();
            pu.registrarUsuario(usuario);

            GestorBitacora.registrarBitacora(String.Format("Registro el usuario {0} {1}", pcedula, pnombre));
        }
        ///<summary>
        ///Metodo de la clase encargada de Modificar un Usuario
        ///</summary>
        ///<param name="pnombre">Nombre del Usuario, tipo String</param>
        ///<param name="papellido1">Primer Apellido del Usuario, tipo String</param>
        ///<param name="papellido2">Segundo Apellido del Usuario, tipo String</param>
        ///<param name="pcedula">Cedula del USuario, tipo String</param>
        ///<param name="pcarnet">Carnet del Usuario, tipo String</param>
        ///<param name="pgenero">Genero del Usuario, tipo Char</param>
        ///<param name="pcorreo">Correo del Usuario, tipo String</param>
        ///<param name="pcontrasenna">Contrasenna del Usuario, tipo String</param>
        ///<param name="pfecha_nacimiento">Fecha de Nacimiento del Usuario, tipo DateTime</param>
        ///<param name="pdireccion">Direccion del Usuario, tipo String</param>
        ///<param name="ptelefono_fijo">Telefono fijo del Usuario, tipo String</param>
        ///<param name="ptelefono_celular">Telefono celular del Usuario, tipo String</param>
        ///<remarks>
        ///Autor: Ernesto Villarreal
        ///</remarks>
        public static void modificarUsuario(String pnombre, String papellido1, String papellido2, String pcedula, String pcarnet,
            Char pgenero, String pcorreo, String pcontrasenna, DateTime pfechaNacimiento, String pdireccion,
            String ptelefono_fijo, String ptelefonoCelular, int pidUsuario)
        {
            PersUsuario pu = new PersUsuario();

            StrUsuario usuario = pu.buscarUsuarioPorId(pidUsuario);

            pu.modificarUsuario(new Usuario(pnombre, papellido1, papellido2, pcedula, pcarnet,
                pgenero, pcorreo, pcontrasenna, pfechaNacimiento, pdireccion,
                ptelefono_fijo, ptelefonoCelular, pidUsuario));

            GestorBitacora.registrarBitacora("modificó al usuario " + usuario.Nombre + " " + usuario.Apellido1 + " " + usuario.Apellido2);
        }

        ///<summary>
        ///Metodo de la clase encargada de Eliminar un Usuario
        ///</summary>
        ///<param name="idUsuario"></param>
        ///<remarks>
        ///Autor: Christopher Vargas
        ///</remarks>
        public static void eliminarUsuario(int idUsuario)
        {
            PersUsuario pu = new PersUsuario();
            StrUsuario usuario = pu.buscarUsuarioPorId(idUsuario);
            pu.eliminarUsuario(idUsuario);

            GestorBitacora.registrarBitacora("eliminó al usuario " + usuario.Nombre + " " + usuario.Apellido1 + " " + usuario.Apellido2);
        }

        /// <summary>
        /// Método para buscar un director académico por id de carrera
        /// </summary>
        /// <param name="idCarrera"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<StrUsuario> buscarDirectorAcademicoPorCarrera(int idCarrera)
        {
            PersUsuario pu = new PersUsuario();
            return pu.buscarDirectorAcademicoPorCarrera(idCarrera);
        }

        /// <summary>
        /// Metodo que busca a los usuarios por nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static List<StrUsuario> buscarUsuarioPorNombre(String pnombre)
        {
            PersUsuario pers = new PersUsuario();
            return pers.buscarUsuarioPorNombre(pnombre);
        }

        /// <summary>
        /// Metodo que busca a los usuarios por cedula
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static List<StrUsuario> buscarUsuarioPorCedula(String pcedula)
        {
            PersUsuario pers = new PersUsuario();
            return pers.buscarUsuarioPorCedula(pcedula);
        }

        /// <summary>
        /// Metodo que busca a los usuarios por rol
        /// </summary>
        /// <param name="nombreRol"></param>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static List<StrUsuario> buscarUsuarioPorRol(String pnombreRol)
        {
            PersUsuario pers = new PersUsuario();
            return pers.buscarUsuarioPorRol(pnombreRol);
        }

        /// <summary>
        /// Metodo que busca a los todos los usuarioss
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static List<StrUsuario> buscarTodosUsuarios()
        {
            PersUsuario pers = new PersUsuario();
            return pers.buscarTodosUsuarios();
        }

        public static void registrarUsuarioBatch(List<List<String>> pdatos)
        {
            PersUsuario psUsuario = new PersUsuario();
            psUsuario.registrarPorBatch(pdatos);
        }

        /// <summary>
        /// Devuelve los estudiantes de un grupo
        /// </summary>
        /// <param name="idGCurso"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static List<StrUsuario> listarEstudiantesPorGrupoId(int idGrupo)
        {
            List<StrUsuario> usuarios = (new PersUsuario()).buscarEstudiantesPorIdGrupo(idGrupo);
            //GestorBitacora.registrarBitacora("Listó estudiantes del grupo: " + idGrupo + ".");
            return usuarios;
        }


        /// <summary>
        /// Metodo que lista los usuarios con rol de estudiante
        /// </summary>
        /// <returns name="_usuarios">Devuelve la lista de usuarios</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrUsuario> listarTodosUsuariosEst()
        {

            PersUsuario _persUsuario = new PersUsuario();

            List<StrUsuario> _usuarios = new List<StrUsuario>();

            _usuarios = _persUsuario.listarEstudiantes();

            return _usuarios;
        }

        public static List<StrUsuario> buscarProfesorPorGrupo(String rol, String codGrupo)
        {
            PersUsuario pers = new PersUsuario();
            return pers.buscarProfesorPorGrupo(rol, codGrupo);
        }

        public static List<StrUsuario> buscarEstudiantesTema(int idTema)
        {
            PersUsuario pers = new PersUsuario();
            return pers.buscarEstudiantesTema(idTema);
        }

        /// <summary>
        /// Metodo que lista los estudiantes de un grupo
        /// </summary>
        /// <param name="id_grupo">Id del grupo</param>
        /// <returns name="_usuarios">Retorna una lista de estudiantes</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrUsuario> listarEstudiantesDeGrupo(int id_grupo)
        {
            PersUsuario _persUsuario = new PersUsuario();

            List<StrUsuario> _usuarios = new List<StrUsuario>();

            _usuarios = _persUsuario.listarEstudiantesDeUnGrupo(id_grupo);

            return _usuarios;
        }

        public static List<StrUsuario> listarProfesoresPorGrupoId(int idGrupo)
        {
            List<StrUsuario> usuarios = (new PersUsuario()).buscarProfesorPorIdGrupo(idGrupo);
            //GestorBitacora.registrarBitacora("Listó estudiantes del grupo: " + idGrupo + ".");
            return usuarios;
        }

        /// <summary>
        /// Retorna si un usuario tiene un rol dado
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static Boolean usuarioTieneRol(String rol, int idUsuario)
        {
            return GestorUsuario.buscarUsuarioPorRol(rol).Contains(
                GestorUsuario.buscarUsuarioPorId(idUsuario));
        }

        /// <summary>
        /// Metodo que convierte una estructura en un arreglo
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public static String[] buscarUsuarioPorIdConvert(StrUsuario usuario)
        {

            String[] array  =  { usuario.idUsuario, usuario.Nombre, 
                                   usuario.Apellido1, usuario.Apellido2, 
                                   usuario.Cedula, usuario.Carnet, usuario.Genero, 
                                   usuario.FechaNacimiento, usuario.Direccion,
                                   usuario.TelefonoFijo, usuario.TelefonoCelular,
                                   usuario.Contrasenna, usuario.Correo};



            return array;
        }
            
    }
}