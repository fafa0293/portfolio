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
    public class PruebasDylhann
    {
        #region Buscar Grupos

        [TestMethod]
        public void pruebaListarGrupo()
        {  
            Boolean estaVacio;
            List<StrGrupo> grupos = GestorGrupo.buscarGrupos();
            if(grupos.Count()==0){
                estaVacio=true;
            }else{
                estaVacio=false;
            }

            Assert.IsFalse(estaVacio);
        }

        [TestMethod]
        public void pruebaBuscarGruposPorNombre()
        {
            String nombre = "Progra";
            List<StrGrupo> grupos = GestorGrupo.buscarGrupoPorNombre(nombre);
            foreach (StrGrupo grupo in grupos)
            {
                Assert.IsTrue(Regex.IsMatch(grupo.Nombre, nombre, RegexOptions.IgnoreCase));
            }
        }


        [TestMethod]
        public void pruebaBuscarGruposPorCodigo()
        {
            String codigo = "PROG1-NOC";
            List<StrGrupo> grupos = GestorGrupo.buscarGrupoPorCodigo(codigo);
            foreach (StrGrupo grupo in grupos)
            {
                Assert.IsTrue(Regex.IsMatch(grupo.Codigo, codigo, RegexOptions.IgnoreCase));
            }
        }
        
        #endregion

        #region Listar Cursos

        [TestMethod]
        public void pruebaListarCursos()
        {
            Boolean estaVacio;
            List<StrCurso> cursos = GestorCurso.listarCursos();
            if (cursos.Count() == 0)
            {
                estaVacio = true;
            }
            else
            {
                estaVacio = false;
            }

            Assert.IsFalse(estaVacio);
        }

        #endregion

      //  #region Buscar Entradas
        //    public void pruebaBuscarGruposPorNombre()
          //  {
            //    String titulo = "Lorem";
              //  int idBlog = 1;
               // List<StrEntrada> entradas = GestorEntrada.listarEntradasPorTitulo(idBlog,titulo);
                //foreach (StrEntrada entrada in entradas)
                //{
                 //   Assert.IsTrue(Regex.IsMatch(entrada.Titulo, titulo, RegexOptions.IgnoreCase));
                //}
            //}
       // #endregion
    }


}
