using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace solLogica.Clase
{
    public class Blog
    {
        #region Atributos de la clase Blog

        protected String _id_blog;
        protected String _id_usuario;

        #endregion

        #region Propiedades de la clase Blog

        internal String Id_blog
        {
            get 
            { 
                return _id_blog;
            }
            set 
            { 
                _id_blog = value; 
            }
        }

        internal String Id_usuario
        {
            get 
            { 
                return _id_usuario; 
            }
            set 
            { 
                _id_usuario = value; 
            }
        }

        #endregion

        #region Constructores

         ///<summary>
        ///constructor vacio
        ///</summary>
        ///<remarks>
        ///Autor: Christopher Vargas
        ///</remarks>
        protected internal Blog()
        {
        }
        /// <summary>
        /// Constructor con todos los parametros
        /// </summary>
        /// <param name="pid_blog"> Id del blog de tipo String</param>
        /// <param name="pid_usuario">Id del usuario de tipo String</param>
        ///<remarks>
        ///Autor: Christopher Vargas
        ///</remarks> 
        protected internal Blog(String pid_blog, String pid_usuario)
        {
            Id_blog = pid_blog;
            Id_usuario = pid_usuario;
        }
        #endregion
    }
}
