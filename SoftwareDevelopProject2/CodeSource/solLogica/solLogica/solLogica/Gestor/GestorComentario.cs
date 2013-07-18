using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public static class GestorComentario
    {

        /// <summary>
        /// Metodo que agrega un comentario a una entrada
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idAporte"></param>
        /// <param name="idEntrada"></param>
        /// <param name="fecha"></param>
        /// <param name="contenido"></param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void agregarComentarioEntrada( int idUsuario, int idAporte, int idEntrada, DateTime fecha, String contenido)
        {
            Comentario _comentario = new Comentario( idUsuario, idAporte, idEntrada, fecha, contenido);
            PersComentario _pc = new PersComentario();
            _pc.agregarComentarioAEntrada(_comentario);

            //GestorBitacora.registrarBitacora(String.Format("Registro el comentario {0} {1}", codigo, nombre));
        }

        /// <summary>
        /// Metodo que se encarga de eliminar un comentario de una Entrada
        /// </summary>
        /// <param name="idComentario">id del comentario, de tipo int</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void eliminarComentrtarioDeEntrada(int idComentario)
        {
            PersComentario pc = new PersComentario();
            pc.eliminarComenatrioDeEntrada(idComentario);

        }

        /// <summary>
        /// Metodo que agrega un comentario a un apporte 
        /// </summary>
        /// <param name="idCometario"></param>
        /// <param name="idUsuario"></param>
        /// <param name="idAporte"></param>
        /// <param name="idEntrada"></param>
        /// <param name="fecha"></param>
        /// <param name="contenido"></param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void agregarComentarioaUnAporte(int idComentario, int idUsuario, int idAporte, int idEntrada, DateTime fecha, String contenido)
        {
            Comentario _comentario = new Comentario(idComentario, idUsuario, idAporte, idEntrada, fecha, contenido);
            PersComentario _pc = new PersComentario();
            _pc.agregarComentarioAporteTema(_comentario);

            //GestorBitacora.registrarBitacora(String.Format("Registro el comentario {0} {1}", codigo, nombre));
        }

        /// <summary>
        /// Metodo que se encarga de eliminar un comentario de un Aporte
        /// </summary>
        /// <param name="idComentario">id del comentario, de tipo int</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static void eliminarComentrtarioDeAporte(int idComentario)
        {
            PersComentario pc = new PersComentario();
            pc.eliminarComenatrioDeAporte(idComentario, GestorSesion.getIdUsuario());
        }

        /// <summary>
        /// Devuelve las comentarios de una entrada
        /// </summary>
        /// <param name="idEntrada"></param>
        /// <returns name="_listaComentarios">Devuelve la lista de comentarios</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrComentario > listarComentariosDeEntrada(int idEntrada)
        {
            PersComentario _comentarios = new PersComentario();

            List<StrComentario> _listaComentarios = new List<StrComentario>();

            _listaComentarios = _comentarios.buscarComentariosXIdEntrada(idEntrada);

            return _listaComentarios;
        }

        /// <summary>
        /// Devuelve las comentarios de un aporte
        /// </summary>
        /// <param name="idAporte"></param>
        /// <returns name="_listaComentarios">Devuelve la lista de comentarios</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public static List<StrComentario> listarComentariosDeAporte(int idAporte)
        {
            PersComentario _comentarios = new PersComentario();

            List<StrComentario> _listaComentarios = new List<StrComentario>();

            _listaComentarios = _comentarios.buscarComentariosXIdAporte(idAporte);

            return _listaComentarios;
        }
    }
}
