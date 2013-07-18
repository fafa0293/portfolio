using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Clase;
using solLogica.Estructura;
using solLogica.Persistente;

namespace solLogica.Gestor
{
    public static class GestorBitacora
    {

        /// <summary>
        /// Registra una nueva Bitacora en el Sistema
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="fecha"></param>
        /// <param name="idUsuario"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static void registrarBitacora(String descripcion)
        {
            descripcion = GestorSesion.getNombreCompletoUsuario() + " " + descripcion;

            Bitacora bitacora = new Bitacora(descripcion, DateTime.Now, GestorSesion.getIdUsuario());
            PersBitacora pb = new PersBitacora();
            pb.registrarBitacora(bitacora);
        }

        /// <summary>
        /// Obtiene la Bitacora un el Usuario especificado.
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <remarks>Autor: Fabián Vega</remarks>
        public static List<StrBitacora> mostrarBitacora(int idUsuario)
        {
            PersBitacora pb = new PersBitacora();
            return pb.buscarBitacoraPorUsuario(idUsuario);
        }

        /// <summary>
        /// Devuelve una lista de estructuras de aporte de bitacoras
        /// </summary>
        /// <param name="nombreRol"></param>
        /// <remarks>Author: Jonathan Jara Morales</remarks>
        public static List<StrBitacora> mostrarBitacoraPorRol(String nombreRol)
        {
            PersBitacora pb = new PersBitacora();
            return pb.buscarBitacoraPorRol(nombreRol);
        }

    }
}
