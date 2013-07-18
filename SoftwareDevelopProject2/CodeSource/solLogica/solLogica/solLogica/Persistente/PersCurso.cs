﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Estructura;
using AccesoBD;
using System.Data;

namespace solLogica.Persistente
{
    internal class PersCurso : PersistAbstracto
    {
        /// <summary>
        /// Metodo de la clase que registra un curso recibe un objeto Curso
        /// </summary>
        /// <param name="curso">Objeto Curso de tipo Curso</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void registrarCurso(Curso curso)
        {
            Parametro pcodigo = new Parametro("pcodigo", curso.Codigo);
            Parametro pnombre = new Parametro("pnombre", curso.Nombre);
            Parametro pcreditos = new Parametro("pcreditos", curso.Creditos);
            Parametro pestado = new Parametro("pestado", curso.Estado);

            String sql = "INSERT INTO T_Curso (codigo_curso, nombre_curso, creditos, estado) " +
            "VALUES (pcodigo, pnombre, pcreditos,pestado)";

            try
            {
                Acceso.EjecutarSQL(sql, pcodigo, pnombre, pcreditos, pestado);
            }
            catch (Exception e)
            {
                StrCurso str = buscarCursoExistente(curso.Codigo);
                curso.IdCurso = Convert.ToInt32(str.IdCurso);
                modificarCurso(curso);
            }
        }

        /// <summary>
        /// Metodo de la clase que se encarga de modificar un curso recibe un objeto Curso
        /// </summary>
        /// <param name="curso">Objeto Curso de tipo Curso</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void modificarCurso(Curso curso)
        {
            Parametro pidCurso = new Parametro("pidCurso", curso.IdCurso);
            Parametro pcodigo = new Parametro("pcodigo", curso.Codigo);
            Parametro pnombre = new Parametro("pnombre", curso.Nombre);
            Parametro pcreditos = new Parametro("pcreditos", curso.Creditos);
            Parametro pestado = new Parametro("pestado", curso.Estado);

            String sql = "UPDATE T_Curso " +
            "SET nombre_curso = pnombre, " +
            "creditos = pcreditos, " +
            "estado = pestado " +
            "WHERE id_curso = pidCurso";

            try
            {
                Acceso.EjecutarSQL(sql, pidCurso, pnombre, pcreditos, pestado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo de la clase que se encarga de eliminar un curso
        /// </summary>
        /// <param name="idCurso">id del curso, de tipo int</param>
        /// <remarks>Author: Christopher Vargas</remarks>
        public void eliminarCurso(int idCurso)
        {
            Parametro pidCurso = new Parametro("id_curso", idCurso);

            String sql = "sp_eliminarCurso";

            try
            {
                Acceso.EjecutarSQLSelect(sql, pidCurso);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que busca un curso por medio del codigo del curso
        /// </summary>
        /// <param name="codigoCurso">Codigo de Curso, de tipo String</param>
        /// <returns name="_listCursos">Devuelve la lista de cursos</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public List<StrCurso> buscarCursoPorCodigo(String codigoCurso)
        {

            IDataReader _drCursos;

            Parametro pcodigo_Curso = new Parametro("codigo_curso", codigoCurso);

            String sql = "sp_buscarCursoPorCodigo";

            List<StrCurso> _listCursos = new List<StrCurso>();

            try
            {
                _drCursos = Acceso.EjecutarSQLSelect(sql, pcodigo_Curso);

                StrCurso _curso;

                while (_drCursos.Read())
                {
                    _curso = new StrCurso(
                        _drCursos.GetInt32(0).ToString(), _drCursos.GetString(1),
                        _drCursos.GetString(2), _drCursos.GetString(3),
                        _drCursos.GetString(4));

                    _listCursos.Add(_curso);
                }
                _drCursos.Close();

                return _listCursos;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que busca un curso por medio del nombre
        /// </summary>
        /// <param name="nombre">Nombre del Curso, de tipo String</param>
        /// <returns name="_listCursos">Devuelve la lista de cursos</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public List<StrCurso> buscarCursoPorNombre(String nombre)
        {

            IDataReader _drCursos;

            Parametro pnombre = new Parametro("nombre_curso", nombre);

            String sql = "sp_buscarCursoPorNombre";

            List<StrCurso> _listCursos = new List<StrCurso>();

            try
            {
                _drCursos = Acceso.EjecutarSQLSelect(sql, pnombre);

                StrCurso _curso;

                while (_drCursos.Read())
                {
                    _curso = new StrCurso(
                        _drCursos.GetInt32(0).ToString(), _drCursos.GetString(1),
                        _drCursos.GetString(2), _drCursos.GetString(3),
                        _drCursos.GetString(4));

                    _listCursos.Add(_curso);
                }
                _drCursos.Close();

                return _listCursos;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public StrCurso buscarCursoExistente(String codigoCurso)
        {

            IDataReader dr;
            Parametro pcodigo_Curso = new Parametro("codigo_curso", codigoCurso);
            String sql = "sp_buscarCursoExistente";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pcodigo_Curso);
                StrCurso curso;
                dr.Read();
                
                    curso = new StrCurso(
                        dr.GetInt32(0).ToString(), dr.GetString(1),
                        dr.GetString(2), dr.GetString(3),
                        dr.GetString(4));
                dr.Close();
                return curso;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public StrCurso buscarCursoPorId(int pidCurso)
        {
            IDataReader dr;
            Parametro idCurso = new Parametro("idCurso", pidCurso);

            String sql = "sp_BuscarCursoPorId";

            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, idCurso);
                dr.Read();
                StrCurso curso = new StrCurso(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4));
                dr.Close();
                return curso;

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public List<StrCurso> buscarCursoPorIdCarrera(int pid)
        {
            IDataReader dr;
            Parametro pidCarrera = new Parametro("idCarrera", pid);

            String sql = "sp_CursosPorCarrera";
            try
            {
                dr = Acceso.EjecutarSQLSelect(sql, pidCarrera);
                StrCurso curso;
                List<StrCurso> cursos = new List<StrCurso>();
                while (dr.Read())
                {

                    curso = new StrCurso(
                        dr.GetInt32(0).ToString(),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4));
                    cursos.Add(curso);
                }
                dr.Close();
                return cursos;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que lista todos los curso
        /// </summary>
        /// <returns name="_listCursos">Devuelve la lista de cursos</returns>
        /// <remarks>Author: Christopher Vargas</remarks>
        public List<StrCurso> listarTodosCursos()
        {

            IDataReader _drCursos;

            String sql = "sp_listarCursos";

            List<StrCurso> _listCursos = new List<StrCurso>();

            try
            {
                _drCursos = Acceso.EjecutarSQLSelect(sql);

                StrCurso _curso;

                while (_drCursos.Read())
                {
                    _curso = new StrCurso(
                        _drCursos.GetInt32(0).ToString(), _drCursos.GetString(1),
                        _drCursos.GetString(2), _drCursos.GetString(3),
                        _drCursos.GetString(4));

                    _listCursos.Add(_curso);
                }
                _drCursos.Close();

                return _listCursos;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public void registrarCursosPorBatch(List<List<String>> pdatos)
        {

            List<Parametro> parametros = new List<Parametro>();
            List<String> fila;
            for (int i = 0; i < pdatos.Count;i++ ){
                fila = pdatos[i];
                parametros.Add(new Parametro("pcodigo"+i,fila[0]));
                parametros.Add( new Parametro("pnombre"+i,fila[1]));
                parametros.Add(new Parametro("pcreditos" + i, fila[2]));
            }
            String sql = "INSERT INTO T_Curso (codigo_curso, nombre_curso, creditos) " +
             "VALUES ";
            for (int i = 0; i < pdatos.Count; i++)
            {
                sql += "(pcodigo" + i + ", pnombre" + i + ", pcreditos" + i + ")";
              
                if ((i + 1) < pdatos.Count)
                {
                    sql += ",";
                }
            }
            try
            {
                Acceso.EjecutarSQL( sql ,parametros.ToArray() );
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void activarCurso(int pidCurso)
        {
            StrCurso strCurso = buscarCursoPorId(pidCurso);
            Curso curso = new Curso(Convert.ToInt32(strCurso.IdCurso),
                strCurso.Codigo,strCurso.Nombre,strCurso.Creditos,"Abierto"
                );
            modificarCurso(curso);
        }

    }
}