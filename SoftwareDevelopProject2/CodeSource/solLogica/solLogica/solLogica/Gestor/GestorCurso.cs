using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public static class GestorCurso
    {
        /// <summary>
        /// Metodo que registra un curso
        /// </summary>
        /// <param name="codigo">Codigo del curso, de tipo String</param>
        /// <param name="nombre">Nombre del curso, de tipo String</param>
        /// <param name="creditos">Créditos del curso, de tipo String</param>
        /// <param name="estado">Estado del curso, de tipo String</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void registrarCurso(String codigo, String nombre, String creditos, String estado)
        {
            Curso curso = new Curso(codigo, nombre, creditos, estado);
            PersCurso pc = new PersCurso();
            pc.registrarCurso(curso);

            GestorBitacora.registrarBitacora(String.Format("Registro el curso {0} {1}", codigo, nombre));
        }

        /// <summary>
        /// Metodo que se encarga de modificar un curso
        /// </summary>
        /// <param name="codigo">Codigo del curso, de tipo String</param>
        /// <param name="nombre">Nombre del curso, de tipo String</param>
        /// <param name="creditos">Créditos del curso, de tipo String</param>
        /// <param name="estado">Estado del curso, de tipo String</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void modificarCurso(int idCurso, String codigo, String nombre, String creditos, String estado)
        {
            Curso curso = new Curso(idCurso, codigo, nombre, creditos, estado);
            PersCurso pc = new PersCurso();
            StrCurso _strCurso = pc.buscarCursoPorId(idCurso);

            pc.modificarCurso(curso);

            GestorBitacora.registrarBitacora(String.Format("Se modifico el curso {0} {1}", _strCurso.Codigo, nombre));
        }

        /// <summary>
        /// Metodo que se encarga de eliminar un cursopor medio del id
        /// </summary>
        /// <param name="idCurso">id del curso, de tipo int</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void eliminarCurso(int idCurso)
        {
            PersCurso pc = new PersCurso();
            StrCurso _strCurso = pc.buscarCursoPorId(idCurso);
            pc.eliminarCurso(idCurso);

            GestorBitacora.registrarBitacora(String.Format("Elimino el curso {0} {1}", _strCurso.Codigo, _strCurso.Nombre));
        }



        /// <summary>
        /// Metodo que busca los cursos por codigo
        /// </summary>
        /// <param name="codigo">Codigo del curso, de tipo String</param>
        /// <returns name="_listCursos">Devuelve la lista de cursos</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrCurso> buscarCursoPorCodigo(String codigo)
        {

            PersCurso _persCurso = new PersCurso();

            List<StrCurso> _cursos = new List<StrCurso>();

            _cursos = _persCurso.buscarCursoPorCodigo (codigo);

            return _cursos;
        }

        /// <summary>
        /// Metodo que se encarga de buscar un curso por el nombre
        /// </summary>
        /// <param name="nombre">Nombre del curso, de tipo String</param>
        /// <returns name="_listCursos">Devuelve la lista de cursos</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrCurso> buscarCursoPorNombre(String nombre)
        {
            PersCurso _persCurso = new PersCurso();

            List<StrCurso> _cursos = new List<StrCurso>();

            _cursos = _persCurso.buscarCursoPorNombre(nombre);

            return _cursos;
        }


        /// <summary>
        /// Devuelve los cursos de una Carrera
        /// </summary>
        /// <param name="idGCurso"></param>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static List<StrCurso> listarCursosPorCarreraId(int idCarrera)
        {
            List<StrCurso> cursos = (new PersCurso()).buscarCursoPorIdCarrera(idCarrera);
            //GestorBitacora.registrarBitacora("Listó cursos de la carrera: " + idCarrera + ".");
            return cursos;
        }

        /// <summary>
        /// Metodo que lista todos los cursos
        /// </summary>
        /// <returns name="_listCursos">Devuelve la lista de cursos</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrCurso> listarCursos()
        {

            PersCurso _persCurso = new PersCurso();

            List<StrCurso> _cursos = new List<StrCurso>();

            _cursos = _persCurso.listarTodosCursos();

            return _cursos;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public static void registrarCursosPorBatch(List<List<String>> pdatos)
        {
            PersCurso psCurso = new PersCurso();
            psCurso.registrarCursosPorBatch(pdatos);
        }

    }
}
