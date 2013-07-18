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
    public class PruebasJonathan
    {
        [TestMethod]
        public void buscarTodosBlog()
        {
            Boolean condicion = false;
            List<StrBlog> blogs = GestorBlog.listarBlogs();
            
            if (blogs.Count>0)
            {
                condicion = true;
            }
            
            //Si es false no tiene datos
            Assert.IsFalse(condicion);

        }

        public void buscarBlogPorNombre()
        {
            String nombre = "Pablo";
            List<StrBlog> blogs = GestorBlog.buscarBlogsPorNombre(nombre);
            foreach(StrBlog blog in blogs)
            {
                Assert.IsTrue(Regex.IsMatch(blog.NombreUsuario, nombre, RegexOptions.IgnoreCase));  
                
            }
        }

        public void buscarBlogPorIdRol()
        {
            Boolean condicion = false;
            int idRol = 1; //Rol de profesor
            List<StrBlog> blogs = GestorBlog.buscarBlogsPorIdRol(idRol);

            if (blogs.Count > 0)
            {
                condicion = true;
            }

            //Si es false no tiene datos
            Assert.IsFalse(condicion);
        }

        public void cerrarTema()
        {
            int idTema = 1;
            Boolean condicion = false;
            GestorTema.cambiarEstadoDeTema(idTema, "Cerrado");

            StrTema tema = GestorTema.buscarTemaId(idTema);

            if (tema.IdTema.Equals(idTema))
            {
                condicion = true;
            }
           
            //Deberia la variable condicion encontrarse en false en este momento
            Assert.IsFalse(condicion);
        }

        public void abrirTema()
        {
            int idTema = 1;
            Boolean condicion = false;
            GestorTema.cambiarEstadoDeTema(idTema, "Abierto");

            StrTema tema = GestorTema.buscarTemaId(idTema);

            if (tema.IdTema.Equals(idTema))
            {
                condicion = true;
            }

            //Deberia la variable condicion encontrarse en true en este momento
            Assert.IsFalse(condicion);
        }

        public void modificarDatosPerfil()
        {
            int idUsuarioABuscar = 1;
            StrUsuario usuario = GestorUsuario.buscarUsuarioPorId(idUsuarioABuscar);
            
            //Datos a modificar
            String idUsuario = usuario.idUsuario;
            String nombre = usuario.Nombre;
            String apellido1 = usuario.Apellido1;
            String apellido2 = usuario.Apellido2;
            String cedula = usuario.Cedula;
            String carne = usuario.Carnet;
            String genero = usuario.Genero;
            String correoElectronico = usuario.Correo;
            String contrasenna = usuario.Contrasenna;
            String fechaNacimiento = usuario.FechaNacimiento;
            String direccion = usuario.Direccion;
            String telefonoFijo = usuario.TelefonoFijo;
            String telefonoCelular = usuario.TelefonoFijo;

            //Se modifica la direccion
            direccion = "Costa Rica";

            GestorUsuario.modificarUsuario(nombre, apellido1, apellido2, cedula, carne, Convert.ToChar(genero), correoElectronico, contrasenna, Convert.ToDateTime(fechaNacimiento), direccion, telefonoFijo, telefonoCelular, Convert.ToInt32(idUsuario));

            StrUsuario usuarioModificado = GestorUsuario.buscarUsuarioPorId(idUsuarioABuscar);

            Assert.IsTrue(Regex.IsMatch(usuarioModificado.Direccion, direccion, RegexOptions.IgnoreCase));
       
            }
    }
}
