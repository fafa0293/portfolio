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
    public class PruebasFabian
    {
        # region Web


        # region Listar Estudiantes de un Grupo

        [TestMethod]
        public void listarEstudiantesDeGrupo()
        {
            int idGrupo = 1;

            List<StrUsuario> estudiantes = GestorUsuario.listarEstudiantesPorGrupoId(idGrupo);

            foreach (StrUsuario estudiante in estudiantes)
            {
                int idEste = Convert.ToInt32(estudiante.idUsuario);

                Assert.IsTrue(seAsignoEstudiante(idGrupo,idEste));
            }

        }

        public Boolean seAsignoEstudiante(int idGrupo, int idEste)
        {
            try
            {
                GestorGrupo.asignarEstudianteAGrupo(idGrupo, idEste);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        # endregion

        # region Listar Profesores de un Grupo

        [TestMethod]
        public void listarProfesoresDeGrupo()
        {
            int idGrupo = 1;

            List<StrUsuario> profesores = GestorUsuario.listarProfesoresPorGrupoId(idGrupo);

            foreach (StrUsuario profesor in profesores)
            {
                int idProf = Convert.ToInt32(profesor.idUsuario);

                Assert.IsTrue(seAsignoProfesor(idGrupo, idProf));
            }

        }

        public Boolean seAsignoProfesor(int idGrupo, int idProf)
        {
            try
            {
                GestorGrupo.asignarProfesorAGrupo(idGrupo, idProf);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        # endregion

        # region Listar Aportes por Id Tema

        [TestMethod]
        public void listarAportesPorTemaId()
        {
            int idTema = 1;
            String sidTema = Convert.ToString(idTema);

            List<StrAporte> aportes = GestorAporte.listarAportesPorTemaId(idTema);

            foreach (StrAporte aporte in aportes)
            {
                Assert.IsTrue(aporte.IdTema.Equals(sidTema));
            }

        }

        # endregion

        # region Buscar Estudiantes de un Tema

        [TestMethod]
        public void buscarEstudiantesTema()
        {
            int idTema = 1;

            List<StrUsuario> estudiantes = GestorUsuario.buscarEstudiantesTema(idTema);

            foreach (StrUsuario estudiante in estudiantes)
            {
                int idEste = Convert.ToInt32(estudiante.idUsuario);

                Assert.IsTrue(seAsignoEstudianteTema(idTema, idEste));
            }

        }

        public Boolean seAsignoEstudianteTema(int idTema, int idEste)
        {
            try
            {
                GestorTema.asignarEstudianteATema(idEste, idTema);
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        # endregion

        # region Listar Entradas Por Id Blog

        [TestMethod]
        public void listarEntradasPorBlogId()
        {
            int idBlog = 1;
            String sidBlog = Convert.ToString(idBlog);

            List<StrEntrada> entradas = GestorEntrada.listarEntradasPorBlogId(idBlog);

            foreach (StrEntrada entrada in entradas)
            {
                Assert.IsTrue(entrada.IdBlog.Equals(sidBlog));
            }

        }

        # endregion

        # region Deshabilitar Blog

        [TestMethod]
        public void deshabilitarBlog()
        {
            String idBlog = "1";
            String idUsuario = "1";
            String sidBlog = Convert.ToString(idBlog);

            GestorBlog.deshabilitarBlog(idBlog, idUsuario);
            Boolean habia = false;
            try
            {
                StrBlog blog = GestorBlog.buscarBlogPorId(idBlog);
            }
            catch (Exception)
            {

                habia = true;
            }
           
            Assert.IsTrue(habia);
        }

        # endregion

        # region Registrar Entrada

        [TestMethod]
        public void registrarEntrada()
        {
            int idBlog = 1;
            String sTituloBlog = "La entrada";

            GestorEntrada.registrarEntrada(idBlog, "La entrada", "Entrada de prueba");
            Boolean habia = false;

                List<StrEntrada> entradas = GestorEntrada.listarEntradasPorTitulo(idBlog, "La entrada");

                foreach (StrEntrada entrada in entradas)
                {
                    if (entrada.Titulo.Equals(sTituloBlog))
                    {
                        habia = true;
                    }
                }


            Assert.IsTrue(habia);
        }

        # endregion

        # region Editar Entrada

        [TestMethod]
        public void modificarEntrada()
        {

        }

        # endregion

        # region Buscar Entrada por Id

        [TestMethod]
        public void buscarEntrada()
        {

                StrEntrada ent = GestorEntrada.entradaId(1);
                Assert.IsTrue(ent.IdEntrada.Equals("1"));

           
            
        }

        # endregion

        # region Denunciar Entrada

        [TestMethod]
        public void denunciarEntrada()
        {

        }

        # endregion

        # endregion

        # region Local

        # region Listar Foros de UsuarioLog

        [TestMethod]
        public void listarForosPorUsuarioLog()
        {
            // este usuario esta en el script de datos 15, y puede ver varios foros
            GestorSesion.iniciarSesion("jvargas13@gmail.com", "password", "web");
            String sidUsuario = Convert.ToString(GestorSesion.getIdUsuario());

            List<StrForo> foros = GestorForo.listarForosPorUsuarioLog();

            foreach (StrForo foro in foros)
            {
                Assert.IsTrue(foro.IdUsuario.Equals(sidUsuario));
            }
        }

        # endregion

        # region Desadignar Rol de Usuario

        [TestMethod]
        public void desadignarRolUsuario()
        {
            int idRol = 5;
            int idUsuario = 2;
            String sidUsuario = Convert.ToString(idUsuario);

            GestorRol.eliminarAsignacion(idUsuario, idRol);
            Boolean habia = true;
            
            List<StrUsuario>usuarios = GestorUsuario.buscarUsuarioPorRol("Encargado de Registro");

            foreach (StrUsuario usuario in usuarios)
            {
                if (usuario.idUsuario.Equals(sidUsuario)) 
                {
                 habia = false;   
                }
            }


            Assert.IsTrue(habia);
        }

        # endregion

        # region Desasignar Curso a Carrera

        [TestMethod]
        public void desasignarCursoCarrera()
        {
            int idCurso = 1;
            int idCarrera = 1;
            String sidCurso = Convert.ToString(idCurso);

            GestorCarrera.eliminarAsignacion(idCurso, idCarrera);
            Boolean habia = true;
            
            List<StrCurso>cursos = GestorCurso.listarCursosPorCarreraId(idCarrera);

            foreach (StrCurso curso in cursos)
            {
                if (curso.IdCurso.Equals(sidCurso)) 
                {
                 habia = false;   
                }
            }


            Assert.IsTrue(habia);
        }

        # endregion

        # endregion
    }
}
