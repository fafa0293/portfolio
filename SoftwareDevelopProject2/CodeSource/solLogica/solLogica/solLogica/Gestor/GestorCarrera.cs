using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public static class GestorCarrera
    {
        /// <summary>
        /// Método para registrar una carrera
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void registrarCarrera(String codigo, String nombre)
        {
            Carrera carrera = new Carrera(codigo, nombre);
            PersCarrera pc = new PersCarrera();
            pc.registrarCarrera(carrera);

            GestorBitacora.registrarBitacora(String.Format("registró la carrera {0} {1}", codigo, nombre));
        }

        /// <summary>
        /// Método para modificar una carrera
        /// </summary>
        /// <param name="idCarrera"></param>
        /// <param name="nombre"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void modificarCarrera(int idCarrera, String nombre)
        {
            PersCarrera pc = new PersCarrera();
            StrCarrera strCarrera = pc.buscarCarreraPorId(idCarrera);
            Carrera carrera = new Carrera(idCarrera, strCarrera.Codigo, nombre);
            pc.modificarCarrera(carrera);

            GestorBitacora.registrarBitacora(String.Format("modificó la carrera {0} {1}", strCarrera.Codigo, nombre));
        }

        /// <summary>
        /// Método para eliminar una carrera
        /// </summary>
        /// <param name="idCarrera"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void eliminarCarrera(int idCarrera)
        {
            PersCarrera pc = new PersCarrera();

            StrCarrera strCarrera = pc.buscarCarreraPorId(idCarrera);
            pc.eliminarCarrera(idCarrera);

            GestorBitacora.registrarBitacora(String.Format("eliminó la carrera {0} {1}", strCarrera.Codigo, strCarrera.Nombre));
        }
        
        /// <summary>
        /// Método para buscar una carrera por su id
        /// </summary>
        /// <param name="pidCarrera"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static StrCarrera buscarCarreraPorId(int pidCarrera)
        {
            PersCarrera pc = new PersCarrera();
            return pc.buscarCarreraPorId(pidCarrera);
        }

        /// <summary>
        /// Método para buscar carreras
        /// </summary>
        /// <param name="nombre"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<StrCarrera> buscarCarreras(String codigo, String nombre)
        {
            PersCarrera pc = new PersCarrera();

            codigo = codigo.Equals("") ? null : codigo;
            nombre = nombre.Equals("") ? null : nombre;

            return pc.buscarCarreras(codigo, nombre);
        }

        /// <summary>
        /// Método para listar todas las carreras
        /// </summary>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static List<StrCarrera> listarCarreras()
        {
            PersCarrera pc = new PersCarrera();
            return pc.listarCarreras();
        }

        /// <summary>
        /// Método para asignar un director académico a una carrera
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idCarrera"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void asignarDirectorAcademicoACarrera(int idUsuario, int idCarrera)
        {
            PersCarrera pc = new PersCarrera();
            PersUsuario pu = new PersUsuario();
            StrCarrera carrera = pc.buscarCarreraPorId(idCarrera);
            StrUsuario usuario = pu.buscarUsuarioPorId(idUsuario);

            GestorBitacora.registrarBitacora(String.Format("asignó el director académico "+
            "{0} a la carrera {1} {2}", usuario.Nombre+" "+usuario.Apellido1+" "+usuario.Apellido2, carrera.Codigo, carrera.Nombre));

            pc.asignarDirectorAcademicoACarrera(idUsuario, idCarrera);
        }

        /// <summary>
        /// Método que se encarga de desasignar un director académico de una carrera
        /// </summary>
        /// <param name="idCurso"></param>
        /// <param name="idCarrera"></param>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        public static void eliminarAsignacionDeDirectorAcademico(int idUsuario, int idCarrera)
        {
            PersCarrera pc = new PersCarrera();
            PersUsuario pu = new PersUsuario();
            StrCarrera carrera = pc.buscarCarreraPorId(idCarrera);
            StrUsuario usuario = pu.buscarUsuarioPorId(idUsuario);

            pc.eliminarAsignacionDeDirectorAcademico(idUsuario, idCarrera);

            GestorBitacora.registrarBitacora(String.Format("desasignó al director académico " +
            "{0} de la carrera {1} {2}", usuario.Nombre + " " + usuario.Apellido1 + " " + usuario.Apellido2, carrera.Codigo, carrera.Nombre));
        }

        /// <summary>
        /// Método para asignar un curso a una carrera
        /// </summary>
        /// <param name="idCurso"></param>
        /// <param name="idCarrera"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static void asignarCursoACarrera(int idCurso, int idCarrera)
        {
            try
            {
                (new PersCarrera()).asignarCursoACarrera(idCurso, idCarrera);
                GestorBitacora.registrarBitacora("Asignación del curso: " + idCurso + " a la carrera: " + GestorCarrera.buscarCarreraPorId(idCarrera).Nombre + ".");
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        /// <summary>
        /// Método para eliminar asignacion de curso a una carrera
        /// </summary>
        /// <param name="idCurso"></param>
        /// <param name="idCarrera"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static void eliminarAsignacion(int idCurso, int idCarrera)
        {
            (new PersCarrera()).eliminarAsignacionDeCurso(idCurso, idCarrera);
        }
    }
}
