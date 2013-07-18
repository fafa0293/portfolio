using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using solLogica.Gestor;
using solLogica.Estructura;
using solLogica.Clase;
using System.Text.RegularExpressions;

namespace PruebasLogica
{
    [TestClass]
    public class PruebasErnesto
    {
        # region pruebas sesion
        [TestMethod]
        public void pruebaIniciarSesion()
        {
            // este usuario esta en el script de datos 16, es un encargado de registro
            int idUsuario = 1;
            GestorSesion.iniciarSesion("registro@cenfotec.com", "registro", "web");

            Assert.IsTrue(GestorSesion.getIdUsuario() == idUsuario);
        }
        
        public void pruebaCerrarSesion()
        {
            // este usuario esta en el script de datos 16, es un encargado de registro
            GestorSesion.iniciarSesion("registro@cenfotec.com", "registro", "web");
            GestorSesion.cerrarSesion();

            Assert.IsFalse(GestorSesion.sesionIniciada());
        }
        # endregion

        # region pruebas buscar y listar temas
        [TestMethod]
        public void pruebaBuscarTemasPorForo()
        {
            int idForo = 1;
            StrForo foro = GestorForo.buscarForoPorIdGrupo(idForo);
            List<StrTema> temas = GestorTema.buscarTemasPorForo(idForo);

            foreach (StrTema tema in temas)
            {
                Assert.IsTrue(tema.NombreForo.Equals(foro.NombreForo));
            }
        }

        [TestMethod]
        public void pruebaBuscarTemasPorForoYTitulo()
        {
            int idForo = 1;
            String titulo = "progra";

            List<StrTema> temas = GestorTema.buscarTemas(idForo, "", titulo);

            foreach (StrTema tema in temas)
            {
                // verificar que los titulos de los temas contengan "titulo"
                Assert.IsTrue(Regex.IsMatch(tema.Titulo, titulo, RegexOptions.IgnoreCase));
            }
        }

        # endregion
    }
}
