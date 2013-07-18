using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using solLogica.Gestor;
using solLogica.Estructura;
using solLogica.Clase;

namespace PruebasLogica
{
    [TestClass]
    public class PruebasChristopher
    {
        int aporte;

        # region Prueba asignar estudiante a tema

        [TestMethod]
        public void buscarTemasGrupo()
        {
            int idUsuario = 7;
            int idGrupo = 6;

            List<StrTema> temas = GestorTema.listarTemasDeGrupo(idGrupo);

            foreach (StrTema tema in temas)
            {
                int idTema = Convert.ToInt32(tema.IdTema);

                Assert.IsTrue(asignarEstudianteTema(idUsuario, idTema));
            }

        }

        public Boolean asignarEstudianteTema(int idUsuario, int idTema)
        {
            try
            {
                GestorTema.asignarEstudianteATema(idUsuario, idUsuario);
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        #endregion

        # region Prueba asignar estudiante a grupo

        [TestMethod]
        public void buscarGruposDeCurso()
        {
            int idUsuario = 7;
            int idCurso = 3;

            List<StrGrupo> grupos = GestorGrupo.listarGruposPorCursoId(idCurso);

            foreach (StrGrupo grupo in grupos)
            {
                int idGrupo = Convert.ToInt32(grupo.IdGrupo);

                Assert.IsTrue(asignarEstudianteGrupo(idUsuario, idGrupo));
            }

        }

        public Boolean asignarEstudianteGrupo(int idUsuario, int idGrupo)
        {
            try
            {
                GestorGrupo.asignarEstudianteAGrupo(idUsuario, idGrupo);
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        #endregion

        # region Prueba asignar profesor a grupo

        [TestMethod]
        public void buscarGruposDeCursoAsignProfe()
        {
            int idUsuario = 3;
            int idCurso = 11;

            List<StrGrupo> grupos = GestorGrupo.listarGruposPorCursoId(idCurso);

            foreach (StrGrupo grupo in grupos)
            {
                int idGrupo = Convert.ToInt32(grupo.IdGrupo);

                Assert.IsTrue(asignarProfeGrupo(idUsuario, idGrupo));
            }

        }

        public Boolean asignarProfeGrupo(int idUsuario, int idGrupo)
        {
            try
            {
                GestorGrupo.asignarEstudianteAGrupo(idUsuario, idGrupo);
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        #endregion

        #region Prueba desasignar estudiante de grupo

        [TestMethod]
        public void buscarEstudianteGrupo()
        {
            int idGrupo = 10;

            List<StrUsuario> estudiantes = GestorUsuario.listarEstudiantesPorGrupoId(idGrupo);

            foreach (StrUsuario usuario in estudiantes)
            {
                int idUsuario = Convert.ToInt32(usuario.idUsuario);

                Assert.IsTrue(desasignarEstudianteGrupo(idUsuario, idGrupo));
            }

        }

        public Boolean desasignarEstudianteGrupo(int idUsuario, int idGrupo)
        {
            try
            {
                GestorGrupo.eliminarAsignacionEstudiante(idUsuario, idGrupo);
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }


        #endregion

        #region Prueba agregar comentario a Entrada

        [TestMethod]
        public void agregarComentario()
        {
            int usuario = 1;
            int entrada = 1;
            
            DateTime fecha= DateTime.Now;
            String contenido= "Prueba 2 de la prueba 1";

            GestorComentario.agregarComentarioEntrada(usuario, aporte, entrada, fecha, contenido);
            Boolean verdadero = false;

            List<StrComentario> comentario = GestorComentario.listarComentariosDeEntrada(entrada);

            foreach (StrComentario comentarios in comentario)
            {
                if (comentarios.IdEntrada.Equals(entrada))
                {
                    verdadero = true;
                }
            }
                Assert.IsTrue(verdadero);

        }

        #endregion

        #region Prueba eliminar comentario a Entrada

        [TestMethod]
        public void eliminarComentario()
        {
            int idComentario = 5;

            GestorComentario.eliminarComentrtarioDeEntrada(idComentario);


            Assert.IsTrue(eliminarComentarioEntrada(idComentario));

        }

        public Boolean eliminarComentarioEntrada(int idComentario)
        {
            try
            {
                GestorComentario.eliminarComentrtarioDeEntrada(idComentario);
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        #endregion
    }


}
