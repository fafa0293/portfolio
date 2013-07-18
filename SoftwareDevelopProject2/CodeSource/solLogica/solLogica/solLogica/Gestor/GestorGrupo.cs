﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public static class GestorGrupo
    {

        /// <summary>
        /// Método para registrar un grupo.
        /// </summary>
        /// <param name="pidCurso">Id del Curso del grupo.</param>
        /// <param name="pcodigo">Código del grupo.</param>
        /// <param name="pnombre">Nombre del grupo.</param>
        /// <param name="pperiodo">Período al que pertenece.</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static void registrarGrupo(int pidCurso, String pcodigo, String pnombre, String pperiodo)
        {
            PersGrupo psGrupo = new PersGrupo();
            Grupo grupo = new Grupo(pidCurso, pcodigo, pnombre, pperiodo);
            psGrupo.registrarGrupo(grupo);
            List<StrGrupo> grupos = psGrupo.buscarGrupoPorCodigo(pcodigo);
            GestorForo.registrarForo(pnombre, Convert.ToInt32(grupos[0].IdGrupo));
            GestorBitacora.registrarBitacora("Registró el grupo: " + pnombre + "-" + pcodigo + ".");
        }

        /// <summary>
        /// Método para modificar grupos.
        /// </summary>
        /// <param name="pidGrupo">Id del grupo.</param>
        /// <param name="pidCurso">Id del Curso del grupo.</param>
        /// <param name="pcodigo">Código del grupo.</param>
        /// <param name="pnombre">Nombre del grupo.</param>
        /// <param name="pperiodo">Período al que pertenece.</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static void modificarGrupo(int pidGrupo, int pidCurso, String pcodigo, String pnombre, String pperiodo,Boolean pestado)
        {
            PersGrupo psGrupo = new PersGrupo();
            Grupo grupo = new Grupo(pidGrupo, pidCurso,pcodigo, pnombre, pperiodo,pestado);
            psGrupo.modificarGrupo(grupo);
            PersForo psForo = new PersForo();
            psForo.modificarForo(new Foro(pidGrupo,pnombre));
            GestorBitacora.registrarBitacora("Modificó el grupo: " + pnombre + "-" + pcodigo + ".");
        }

        /// <summary>
        /// Método para eliminar grupos.
        /// </summary>
        /// <param name="pidGrupo">Id del grupo.</param>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static void eliminarGrupo(int pidGrupo)
        {
            PersGrupo psGrupo = new PersGrupo();
            StrGrupo grupoEliminado = psGrupo.buscarGrupoPorId(pidGrupo);
            psGrupo.eliminarGrupo(pidGrupo);
            GestorBitacora.registrarBitacora("Eliminó el grupo: " + grupoEliminado.Nombre + "-" + grupoEliminado.Codigo+".");
        }

        /// <summary>
        /// Método para buscar todos los grupos.
        /// </summary>
        /// <returns>Lista de StrGrupo.</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static List<StrGrupo> buscarGrupos()
        {
            PersGrupo psGrupo = new PersGrupo();
            return psGrupo.buscarGrupos();
        }

        /// <summary>
        /// Método para buscar un grupo por su ID.
        /// </summary>
        /// <param name="pcodigo">Código del grupo.</param>
        /// <returns>StrGrupo.</returns>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static StrGrupo buscarGrupoPorId(int pidGrupo)
        {
            StrGrupo grupo= (new PersGrupo()).buscarGrupoPorId(pidGrupo);
            return grupo;
        }

    
        public static int buscarGrupoExistente(String pcodigo)
        {
            StrGrupo grupo = (new PersGrupo()).buscarGrupoExistente(pcodigo);
            return Convert.ToInt32(grupo.IdGrupo);
        }

        /// <summary>
        /// Método para buscar todos los grupos por su código.
        /// </summary>
        /// <param name="pcodigo">Código del grupo.</param>
        /// <returns>Lista de StrGrupo.</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static List<StrGrupo> buscarGrupoPorCodigo(String pcodigo)
        {
            PersGrupo psGrupo = new PersGrupo();
            return psGrupo.buscarGrupoPorCodigo(pcodigo);
          
        }

        /// <summary>
        /// Método para buscar todos los grupos por su nombre.
        /// </summary>
        /// <param name="pnombre">Nombre del grupo.</param>
        /// <returns>Lista de StrGrupo.</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static List<StrGrupo> buscarGrupoPorNombre(String pnombre)
        {
            PersGrupo psGrupo = new PersGrupo();
            return psGrupo.buscarGrupoPorNombre(pnombre);
        }

        /// <summary>
        /// Método para listar todos los grupos.
        /// </summary>
        /// <returns>Lista de StrGrupo.</returns>
        /// <remarks>Autor: Dylhann Obando</remarks>
        public static List<StrGrupo> listarGrupos()
        {
            PersGrupo psGrupo = new PersGrupo();
            return psGrupo.buscarGrupos();
        }

        /// <summary>
        /// Método encargado de asignar un profesor a un grupo
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idGrupo"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void asignarProfesorAGrupo(int idUsuario, int idGrupo)
        {
            PersUsuario _persUsuario = new PersUsuario();
            PersGrupo _persGrupo = new PersGrupo();

            (new PersGrupo()).asignarProfesorAGrupo(idUsuario, idGrupo);

            StrGrupo _grupo = _persGrupo.buscarGrupoPorId(idGrupo);
            StrUsuario _usuario = _persUsuario.buscarUsuarioPorId(idUsuario);

            _persGrupo.asignarEstudianteAGrupo(idUsuario, idGrupo);

            GestorBitacora.registrarBitacora(String.Format("Asignó el Profesor " +
            "{0} al grupo {1} {2}", _usuario.Nombre + " " + _usuario.Apellido1 + " " + _usuario.Apellido2, _grupo.Codigo, _grupo.Nombre));
        }

        /// <summary>
        /// Metodo que se encarga de asignar un estudiante a un grupo
        /// </summary>
        /// <param name="idUsuario">Id del usuario</param>
        /// <param name="idGrupo">Id del grupo</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void asignarEstudianteAGrupo(int idUsuario, int idGrupo)
        {
            PersUsuario _persUsuario = new PersUsuario();
            PersGrupo _persGrupo = new PersGrupo();

            StrGrupo _grupo = _persGrupo.buscarGrupoPorId(idGrupo);
            StrUsuario _usuario = _persUsuario.buscarUsuarioPorId(idUsuario);

            _persGrupo.asignarEstudianteAGrupo(idUsuario, idGrupo);

            GestorBitacora.registrarBitacora(String.Format("Asignó el Estudiante " +
            "{0} al grupo {1} {2}", _usuario.Nombre + " " + _usuario.Apellido1 + " " + _usuario.Apellido2, _grupo.Codigo, _grupo.Nombre));
        }

        /// <summary>
        /// Método que se encarga de desasignar un estudiante de un grupo
        /// </summary>
        /// <param name="idGrupo"></param>
        /// <param name="idUsuario"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void eliminarAsignacionEstudiante(int idGrupo, int idUsuario)
        {
            PersUsuario _persUsuario = new PersUsuario();
            PersGrupo _persGrupo = new PersGrupo();

            StrGrupo _grupo = _persGrupo.buscarGrupoPorId(idGrupo);
            StrUsuario _usuario = _persUsuario.buscarUsuarioPorId(idUsuario);

            _persGrupo.eliminarAsignacionEstudiante(idUsuario, idGrupo);

            GestorBitacora.registrarBitacora(String.Format("Desasignó el Estudiante " +
            "{0} del grupo {1} {2}", _usuario.Nombre + " " + _usuario.Apellido1 + " " + _usuario.Apellido2, _grupo.Codigo, _grupo.Nombre));
        }

        /// <summary>
        ///  Método que se encarga de desasignar un profesor de un grupo
        /// </summary>
        /// <param name="idGrupo"></param>
        /// <param name="idUsuario"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void eliminarAsignacionProfesor(int idGrupo, int idUsuario)
        {
            PersUsuario _persUsuario = new PersUsuario();
            PersGrupo _persGrupo = new PersGrupo();

            StrGrupo _grupo = _persGrupo.buscarGrupoPorId(idGrupo);
            StrUsuario _usuario = _persUsuario.buscarUsuarioPorId(idUsuario);

            _persGrupo.eliminarAsignacionProfesor(idUsuario, idGrupo);

            GestorBitacora.registrarBitacora(String.Format("Desasignó el Profesor " +
            "{0} del grupo {1} {2}", _usuario.Nombre + " " + _usuario.Apellido1 + " " + _usuario.Apellido2, _grupo.Codigo, _grupo.Nombre));
        }

        /// <summary>
        /// Devuelve los grupos de un curso
        /// </summary>
        /// <param name="idGCurso"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static List<StrGrupo> listarGruposPorCursoId(int idCurso)
        {
            List<StrGrupo> grupos = (new PersGrupo()).buscarGruposPorIdCurso(idCurso);
            //GestorBitacora.registrarBitacora("Listó grupos del curso: " + idCurso + ".");
            return grupos;
        }

    }
}