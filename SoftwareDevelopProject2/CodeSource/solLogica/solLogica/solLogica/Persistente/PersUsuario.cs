using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using solLogica.Clase;
using solLogica.Estructura;
using AccesoBD;

namespace solLogica.Persistente
{
    internal class PersUsuario : PersistAbstracto
    {

        /// <summary>
        /// Metodo que encarga de registrar un usuario
        /// </summary>
        /// <param name="usuario">Objeto usuario de tipo Usuario</param>
        public void registrarUsuario(Usuario usuario)
        {
            Parametro pNombre = new Parametro("pNombre", usuario.Nombre);
            Parametro pApellido1 = new Parametro("pApellido1", usuario.Apellido1);
            Parametro pApellido2 = new Parametro("pApellido2", usuario.Apellido2);
            Parametro pCedula = new Parametro("pCedula", usuario.Cedula);
            Parametro pCarnet = new Parametro("pCarnet", usuario.Carnet);
            Parametro pGenero = new Parametro("pGenero", usuario.Genero);
            Parametro pCorreo_Electronico = new Parametro("pCorreo_Electronico", usuario.Correo);
            Parametro pContrasenna = new Parametro("pContrasenna", usuario.Contrasenna);
            Parametro pfecha_Nacimiento = new Parametro("pfecha_Nacimiento", usuario.FechaNacimiento);
            Parametro pdireccion = new Parametro("pdireccion", usuario.Direccion);
            Parametro ptelefono_Fijo = new Parametro("ptelefono_Fijo", usuario.TelefonoFijo);
            Parametro ptelefono_Celular = new Parametro("ptelefono_Celular", usuario.TelefonoCelular);



            String sql = "INSERT INTO T_Usuario (nombre, apellido1, apellido2, cedula, carnet, genero, correo_electronico," +
                                                "contrasenna, fecha_nacimiento, direccion, telefono_fijo, telefono_celular) " +
            "VALUES (pNombre, pApellido1, pApellido2, pCedula, pCarnet, pGenero, pCorreo_Electronico, pContrasenna, " +
                    "pfecha_Nacimiento, pdireccion, ptelefono_Fijo, ptelefono_Celular)";

            try
            {
                Acceso.EjecutarSQL(sql, pNombre, pApellido1, pApellido2, pCedula, pCarnet, pGenero, pCorreo_Electronico, pContrasenna,
                    pfecha_Nacimiento, pdireccion, ptelefono_Fijo, ptelefono_Celular);
                
                String cedula = usuario.Cedula;

                int idUsuario = 0;
                PersUsuario _pu = new PersUsuario();
                List<StrUsuario> _listaUsuarios = _pu.buscarUsuarioPorCedula(cedula);

                foreach (StrUsuario _usuario in _listaUsuarios)
                {
                    if (_usuario.Cedula.Equals(cedula))
                    {
                        idUsuario = int.Parse(_usuario.idUsuario);
                        break;
                    }
                }

                Parametro pid_usuario = new Parametro("pid_usuario", idUsuario);
                Parametro pid_blog = new Parametro("pid_blog", idUsuario);
                String sql2 = "INSERT INTO T_Blog (id_blog,id_usuario) " +
                                "VALUES (pid_blog,pid_usuario)";


                Acceso.EjecutarSQL(sql2, pid_usuario, pid_blog);

            }
            catch (Exception e)
            {
                StrUsuario str = buscarUsuarioExistente(usuario.Cedula,usuario.Carnet,usuario.Correo);
                usuario.IdUsuario = Convert.ToInt32(str.idUsuario);
                modificarUsuario(usuario);
            }
        }

        public void modificarUsuario(Usuario usuario)
        {
            Parametro pNombre = new Parametro("pNombre", usuario.Nombre);
            Parametro pApellido1 = new Parametro("pApellido1", usuario.Apellido1);
            Parametro pApellido2 = new Parametro("pApellido2", usuario.Apellido2);
            Parametro pCedula = new Parametro("pCedula", usuario.Cedula);
            Parametro pCarnet = new Parametro("pCarnet", usuario.Carnet);
            Parametro pGenero = new Parametro("pGenero", usuario.Genero);
            Parametro pCorreo_Electronico = new Parametro("pCorreo_Electronico", usuario.Correo);
            Parametro pContrasenna = new Parametro("pContrasenna", usuario.Contrasenna);
            Parametro pfecha_Nacimiento = new Parametro("pfecha_Nacimiento", usuario.FechaNacimiento);
            Parametro pdireccion = new Parametro("pdireccion", usuario.Direccion);
            Parametro ptelefono_Fijo = new Parametro("ptelefono_Fijo", usuario.TelefonoFijo);
            Parametro ptelefono_Celular = new Parametro("ptelefono_Celular", usuario.TelefonoCelular);
            Parametro pidUsuario = new Parametro("pidUsuario", usuario.IdUsuario);

            String sql = "UPDATE T_Usuario SET nombre = pNombre, apellido1 = pApellido1, " +
                         "apellido2 = pApellido2, cedula = pCedula, carnet = pCarnet, genero = pGenero, " +
                         "correo_electronico = pCorreo_Electronico, fecha_nacimiento = pfecha_Nacimiento, " +
                         "direccion = pdireccion, telefono_fijo = ptelefono_Fijo, telefono_celular = ptelefono_Celular, " +
                         "eliminado = 0";

            if (!usuario.Contrasenna.Equals(""))
            {
                sql += ", contrasenna = pContrasenna";
            }

            sql += " WHERE id_usuario = pidUsuario";

            try
            {
                Acceso.EjecutarSQL(sql, pNombre, pApellido1, pApellido2, pCedula, pCarnet, pGenero, pCorreo_Electronico, pContrasenna,
                    pfecha_Nacimiento, pdireccion, ptelefono_Fijo, ptelefono_Celular, pidUsuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca a los usuarios por el id
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public StrUsuario buscarUsuarioPorId(int idUsuario)
        {
            IDataReader dr;
            Parametro pidUsuario = new Parametro("idUsuario", idUsuario);

            String sql = "sp_buscarUsuarioPorId";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidUsuario);
                dr.Read();
                StrUsuario usuario = usuarioFromDataReader(dr);
                dr.Close();
                return usuario;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrUsuario> buscarDirectorAcademicoPorCarrera(int idCarrera)
        {
            IDataReader dr;
            Parametro pidCarrera = new Parametro("idCarrera", idCarrera);

            String sql = "sp_buscarDirectorAcademicoCarrera";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidCarrera);
                List<StrUsuario> listaUsuarios = new List<StrUsuario>();
                StrUsuario usuario;

                while (dr.Read())
                {
                    usuario = usuarioFromDataReader(dr);
                    listaUsuarios.Add(usuario);
                }
                dr.Close();
                return listaUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca a los usuarios por el nombre
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public List<StrUsuario> buscarUsuarioPorNombre(String pnombre)
        {
            IDataReader dr;
            Parametro pusuario = new Parametro("nombre", pnombre);

            String sql = "sp_buscarUsuarioNombre";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pusuario);
                List<StrUsuario> listaUsuarios = new List<StrUsuario>();
                StrUsuario usuario;

                while (dr.Read())
                {
                    usuario = usuarioFromDataReader(dr);
                    listaUsuarios.Add(usuario);
                }
                dr.Close();
                return listaUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public StrUsuario buscarUsuarioExistente(String pcedula, String pcarnet, String pcorreo)
        {
            IDataReader dr;
            Parametro cedula= new Parametro("cedula", pcedula);
            Parametro carnet = new Parametro("carnet", pcarnet);
            Parametro correo = new Parametro("correo", pcorreo);

            String sql = "sp_buscarUsuarioExistente";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, cedula, carnet, correo);
              
                StrUsuario usuario;

                dr.Read();
                usuario = usuarioFromDataReader(dr);

                dr.Close();
                return usuario;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca a los usuarios por el numero de cedula
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public List<StrUsuario> buscarUsuarioPorCedula(String pcedula)
        {
            IDataReader dr;
            Parametro pusuario = new Parametro("cedula", pcedula);

            String sql = "sp_buscarUsuarioPorCedula";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pusuario);
                List<StrUsuario> listaUsuarios = new List<StrUsuario>();
                StrUsuario usuario;

                while (dr.Read())
                {
                    usuario = usuarioFromDataReader(dr);
                    listaUsuarios.Add(usuario);
                }
                dr.Close();
                return listaUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca a los usuarios por el rol
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public List<StrUsuario> buscarUsuarioPorRol(String prol)
        {
            IDataReader dr;
            Parametro pusuario = new Parametro("nombreRol", prol);

            String sql = "sp_buscarUsuarioPorRol";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pusuario);
                List<StrUsuario> listaUsuarios = new List<StrUsuario>();
                StrUsuario usuario;

                while (dr.Read())
                {
                    usuario = usuarioFromDataReader(dr);
                    listaUsuarios.Add(usuario);
                }
                dr.Close();
                return listaUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca a todos los usuarios
        /// </summary>
        /// <remarks>Autor: Jonathan Jara Morales</remarks>
        public List<StrUsuario> buscarTodosUsuarios()
        {
            IDataReader dr;

            String sql = "sp_buscarTodosUsuarios";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql);
                List<StrUsuario> listaUsuarios = new List<StrUsuario>();
                StrUsuario usuario;

                while (dr.Read())
                {
                    usuario = usuarioFromDataReader(dr);
                    listaUsuarios.Add(usuario);
                }
                dr.Close();
                return listaUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Devuelve un struct de usuario a partir de un data reader
        /// El orden es el mismo de las columnas en la BD, haga que el SP respete ese orden
        /// El data reader tiene que traerse los datos del usuario en este orden:
        /// u.id_usuario, u.nombre, u.apellido1, u.apellido2, u.cedula, u.carnet,   
        /// u.genero, u.correo_electronico, u.contrasenna, u.fecha_nacimiento, u.direccion,
        /// u.telefono_fijo, u.telefono_celular
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        /// <remarks>Author: Ernesto Villarreal</remarks>
        private StrUsuario usuarioFromDataReader(IDataReader dr)
        {
            return new StrUsuario(
                dr.GetInt32(0).ToString(),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetString(5),
                dr.GetString(6),
                dr.GetString(7),
                dr.GetString(8),
                dr.GetDateTime(9).ToShortDateString(),
                dr.GetString(10),
                dr.GetString(11),
                dr.GetString(12));
        }

        public void registrarPorBatch(List<List<String>> pdatos)
        {

            List<Parametro> parametros = new List<Parametro>();
            List<String> fila;
            int idUsuario = 0;

            for (int i = 0; i < pdatos.Count;i++ )
            {
                fila = pdatos[i];
                parametros.Add(new Parametro("pnombre"+i,fila[0]));
                parametros.Add(new Parametro("papellidoP"+i,fila[1]));
                parametros.Add(new Parametro("papellidoS"+i,fila[2]));
                parametros.Add(new Parametro("pcedula"+i,fila[3]));
                parametros.Add(new Parametro("pcarnet"+i,fila[4]));
                parametros.Add(new Parametro("pgenero"+i,fila[5]));
                parametros.Add(new Parametro("pcorreo_electronico"+i,fila[6]));
                parametros.Add(new Parametro("pcontrasenna"+i, fila[7]));
                parametros.Add(new Parametro("pfecha_nacimiento"+i,fila[8]));
                parametros.Add(new Parametro("pdireccion"+i,fila[9]));
                parametros.Add(new Parametro("ptelefono_fijo"+i,fila[10]));
                parametros.Add(new Parametro("ptelefono_celular" + i,fila[11]));

            }
            String sql = "INSERT INTO T_Usuario (nombre, apellido1, apellido2, cedula, carnet, genero, correo_electronico," +
                         "contrasenna, fecha_nacimiento, direccion, telefono_fijo, telefono_celular) VALUES ";
            for (int i = 0; i < pdatos.Count;i++ )
            {
                sql+="(pnombre"+i+", papellidoP"+i+", papellidoS"+i+", pcedula"+i+", pcarnet"+i+", pgenero"+i+", pcorreo_electronico"+i+", pcontrasenna"+i+", " +
                "pfecha_nacimiento"+i+", pdireccion"+i+", ptelefono_fijo"+i+", ptelefono_celular"+i+")";
                if((i+1) < pdatos.Count){
                    sql+=",";
                }
            }

            PersRol psRol = new PersRol();
            String cedula;
            try
            {
                Acceso.EjecutarSQL(sql, parametros.ToArray());
                parametros = new List<Parametro>();
                
                for (int i = 0; i < pdatos.Count; i++)
                {
                    fila = pdatos[i];
                    cedula = fila[3];
                    idUsuario = Convert.ToInt32(buscarUsuarioPorCedula(cedula)[0].idUsuario);
                    psRol.asignarRolAUnUsuario(idUsuario,2);
                    parametros.Add(new Parametro("pid_blog"+i, idUsuario));
                    parametros.Add(new Parametro("pid_usuario" + i, idUsuario));
                }
                String sql2 = "INSERT INTO T_Blog (id_blog,id_usuario) VALUES ";
                for (int i = 0; i < pdatos.Count; i++)
                {
                    sql2 += "(pid_blog"+i+",pid_usuario" + i + ")";
                    if((i+1) < pdatos.Count){
                    sql2+=",";
                    }
                }
                    Acceso.EjecutarSQL(sql2, parametros.ToArray());
               

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void eliminarUsuario(int idUsuario)
        {
            Parametro pidUsuario = new Parametro("id_usuario", idUsuario);

            String sql = "sp_eliminarUsuario";

            try
            {
                Acceso.EjecutarSQLSelect(sql, pidUsuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrUsuario> buscarEstudiantesPorIdGrupo(int idGrupo)
        {
            IDataReader dr;
            Parametro pidGrupo = new Parametro("idGrupo", idGrupo);
            List<StrUsuario> estudiantes = new List<StrUsuario>();
            String sql = "sp_EstudiantesPorGrupo";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidGrupo);
                while (dr.Read())
                {
                    estudiantes.Add(new StrUsuario(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetDateTime(9).ToString(),
                        dr.GetString(10),
                        dr.GetString(11),
                        dr.GetString(12)));
                }
                dr.Close();
                return estudiantes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que lista los usuarios con el rol de estudiante
        /// </summary>
        /// <returns name="_listEstudiantes">Devuelve la lista de usuarios con el rol de estudiantes</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public List<StrUsuario> listarEstudiantes()
        {

            IDataReader _drUsuario;

            String sql = "sp_listarEstudiantes";

            List<StrUsuario> _listEstudiantes = new List<StrUsuario>();

            try
            {
                _drUsuario = Acceso.EjecutarSQLSelect(sql);

                StrUsuario _usuario;

                while (_drUsuario.Read())
                {
                    _usuario = new StrUsuario(
                        _drUsuario.GetInt32(0).ToString(), _drUsuario.GetString(1), _drUsuario.GetString(2), _drUsuario.GetString(3), _drUsuario.GetString(4),
                        _drUsuario.GetString(5), _drUsuario.GetString(6), _drUsuario.GetString(7), _drUsuario.GetString(8), _drUsuario.GetDateTime(9).ToString(),
                        _drUsuario.GetString(10), _drUsuario.GetString(11), _drUsuario.GetString(12));

                    _listEstudiantes.Add(_usuario);
                }
                _drUsuario.Close();

                return _listEstudiantes;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        internal List<StrUsuario> buscarEstudiantesTema(int idTema)
        {
            IDataReader dr;
            Parametro pnombreRol = new Parametro("nombreRol", "Estudiante");
            Parametro pidTema = new Parametro("idTema", idTema);
            String sql = "sp_buscarUsuariosTema";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pnombreRol, pidTema);
                List<StrUsuario> listaUsuarios = new List<StrUsuario>();
                StrUsuario usuario;

                while (dr.Read())
                {
                    usuario = usuarioFromDataReader(dr);
                    listaUsuarios.Add(usuario);
                }
                dr.Close();
                return listaUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal StrUsuario buscarUsuarioSesion(string usuario, string contrasennaCifrada)
        {
            IDataReader dr;
            Parametro pusuario = new Parametro("correoElectronico", usuario);
            Parametro pcontrasenna = new Parametro("contrasenna", contrasennaCifrada);
            String sql = "sp_iniciarSesion";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pusuario, pcontrasenna);
                dr.Read();
                StrUsuario _usuario = usuarioFromDataReader(dr);
                dr.Close();
                return _usuario;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<StrUsuario> buscarProfesorPorGrupo(String rol, String codigoGrupo)
        {
            IDataReader dr;
            Parametro pcodGrupo = new Parametro("codigoGrupo", codigoGrupo);
            Parametro pnombreRol = new Parametro("nombreRol", rol);

            String sql = "sp_buscarUsuarioPorGrupo";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pnombreRol, pcodGrupo);
                List<StrUsuario> listaUsuarios = new List<StrUsuario>();
                StrUsuario usuario;

                while (dr.Read())
                {
                    usuario = usuarioFromDataReader(dr);
                    listaUsuarios.Add(usuario);
                }
                dr.Close();
                return listaUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que lista los estudiantes de un grupo
        /// </summary>
        /// <param name="id_grupo">Id del grupo</param>
        /// <returns name="_listaEstudiantes">Retorna una lista de estudiantes de un grupo</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public List<StrUsuario> listarEstudiantesDeUnGrupo(int id_grupo)
        {
            Parametro pidGrupo = new Parametro("id_grupo", id_grupo);

            IDataReader _drUsuario;
            String sql = "sp_listarEstudiantesDeGrupo";

            try
            {
                _drUsuario = Acceso.EjecutarSQLSelect(sql, pidGrupo);
                List<StrUsuario> _listaEstudiantes = new List<StrUsuario>();
                StrUsuario _usuario;

                while (_drUsuario.Read())
                {
                    _usuario = new StrUsuario(
                        _drUsuario.GetInt32(0).ToString(),
                        _drUsuario.GetString(1),
                        _drUsuario.GetString(2),
                        _drUsuario.GetString(3),
                        _drUsuario.GetString(4),
                        _drUsuario.GetString(5),
                        _drUsuario.GetString(6),
                        _drUsuario.GetString(7),
                        _drUsuario.GetString(8),
                        _drUsuario.GetDateTime(9).ToString(),
                        _drUsuario.GetString(10),
                        _drUsuario.GetString(11),
                        _drUsuario.GetString(12));

                    _listaEstudiantes.Add(_usuario);
                }
                _drUsuario.Close();

                return _listaEstudiantes;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<StrUsuario> buscarProfesorPorIdGrupo(int idGrupo)
        {
            IDataReader dr;
            Parametro pidGrupo = new Parametro("idGrupo", idGrupo);
            List<StrUsuario> estudiantes = new List<StrUsuario>();
            String sql = "sp_BuscarProfesorPorIdGrupo";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidGrupo);
                while (dr.Read())
                {
                    estudiantes.Add(new StrUsuario(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetDateTime(9).ToString(),
                        dr.GetString(10),
                        dr.GetString(11),
                        dr.GetString(12)));
                }
                dr.Close();
                return estudiantes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}