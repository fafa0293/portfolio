using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Estructura;
using AccesoBD;
using System.Data;

namespace solLogica.Persistente
{
    internal class PersComentario : PersistAbstracto
    {

        /// <summary>
        /// Metodo de la clase que agregar un comentario a una entrada
        /// </summary>
        /// <param name="comentario">Objeto Comentario de tipo Comentario</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void agregarComentarioAEntrada(Comentario comentario)
        {
            Parametro pidUsuario = new Parametro("pidUsuario", comentario.IdUsuario );
            Parametro pidAporte = new Parametro("pidAporte", comentario.IdAporte);
            Parametro pidEntrada = new Parametro("pidEntrada", comentario.IdEntrada);
            Parametro pfecha = new Parametro("pfecha", comentario.Fecha);
            Parametro pcontenido = new Parametro("pcontenido", comentario.Contenido);

            String sql = "INSERT INTO T_Comentario (id_usuario, id_aporte, id_entrada, fecha, contenido) " +
            "VALUES (pidUsuario, pidAporte, pidEntrada, pfecha, pcontenido)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidAporte, pidEntrada, pfecha, pcontenido);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo de la clase que se encarga de eliminar un comentario de una entrada
        /// </summary>
        /// <param name="idComentario">id del comenatrio, de tipo int</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void eliminarComenatrioDeEntrada(int idComentario)
        {
            Parametro pidComentario = new Parametro("pidComentario", idComentario);

            String sql = "DELETE T_Comentario " +
            "WHERE id = pidComentario";

            try
            {
                Acceso.EjecutarSQL(sql, pidComentario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo de la clase que agregar un comentario a un aporte de tema
        /// </summary>
        /// <param name="comentario">Objeto Comentario de tipo Comentario</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void agregarComentarioAporteTema(Comentario comentario)
        {
            Parametro pidUsuario = new Parametro("pidUsuario", comentario.IdUsuario);
            Parametro pidAporte = new Parametro("pidAporte", comentario.IdAporte);
            Parametro pidEntrada = new Parametro("pidEntrada", comentario.IdEntrada);
            Parametro pfecha = new Parametro("pfecha", comentario.Fecha);
            Parametro pcontenido = new Parametro("pcontenido", comentario.Contenido);

            String sql = "INSERT INTO T_Comentario (id_usuario, id_aporte, id_entrada, fecha, contenido) " +
            "VALUES (pidUsuario, pidAporte, pidEntrada, pfecha, pcontenido)";

            try
            {
                Acceso.EjecutarSQL(sql, pidUsuario, pidAporte, pidEntrada, pfecha, pcontenido);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo de la clase que se encarga de eliminar un comentario de un aporte a un tema
        /// </summary>
        /// <param name="idComentario">id del comenatrio, de tipo int</param>
        /// <param name="idUsuario">id del usuario que intenta borrar el comentario, de tipo int</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void eliminarComenatrioDeAporte(int idComentario, int idUsuario)
        {
            Parametro pidComentario = new Parametro("pidComentario", idComentario);
            Parametro pidUsuario = new Parametro("pidUsuario", idUsuario);

            String sql = "DELETE T_Comentario " +
            "WHERE id = pidComentario AND id_usuario = pidUsuario";

            try
            {
                Acceso.EjecutarSQL(sql, pidComentario, pidUsuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca los comentarios de una entrada.
        /// </summary>
        /// <param name="idEntrada"></param>
        /// <returns name="_comentario">Devuelve la lista de comentarios</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public  List<StrComentario> buscarComentariosXIdEntrada(int idEntrada)
        {
            IDataReader _drComentarios;
            Parametro pidEntrada = new Parametro("id_entrada", idEntrada);

            String sql = "sp_listarComentariosDeEntrada";
            try
            {
                _drComentarios = Acceso.EjecutarSQLSelect(sql, pidEntrada);
                StrComentario  _comentarios;
                List<StrComentario> _comentario = new List<StrComentario>();

                while (_drComentarios.Read())
                {
                    _comentarios = new StrComentario(
                        _drComentarios.GetInt32(0).ToString(),
                        _drComentarios.GetInt32(1).ToString(),
                        _drComentarios.GetInt32(2).ToString(),
                        _drComentarios.GetInt32(3).ToString(),
                        _drComentarios.GetDateTime(4).ToString(),
                        _drComentarios.GetString(5),
                        _drComentarios.GetString(6));

                    _comentario.Add(_comentarios);
                }
                _drComentarios.Close();
                return _comentario;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Metodo que busca los comentarios de un aporte.
        /// </summary>
        /// <param name="idAporte"></param>
        /// <returns name="_listaComentarios">Devuelve la lista de comentarios</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public List<StrComentario> buscarComentariosXIdAporte(int idAporte)
        {
            IDataReader _drComentarios;
            Parametro pidAporte = new Parametro("id_aporte", idAporte);

            String sql = "sp_listarComentariosDeAporte";
            try
            {
                _drComentarios = Acceso.EjecutarSQLSelect(sql, pidAporte);
                StrComentario _comentarios;
                List<StrComentario> _listaComentarios = new List<StrComentario>();

                while (_drComentarios.Read())
                {
                    _comentarios = new StrComentario(
                        _drComentarios.GetInt32(0).ToString(),
                        _drComentarios.GetInt32(1).ToString(),
                        _drComentarios.GetInt32(2).ToString(),
                        _drComentarios.GetInt32(3).ToString(),
                        _drComentarios.GetDateTime(4).ToString(),
                        _drComentarios.GetString(5),
                        _drComentarios.GetString(6));

                    _listaComentarios.Add(_comentarios);
                }
                _drComentarios.Close();
                return _listaComentarios;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
 
    }
}
