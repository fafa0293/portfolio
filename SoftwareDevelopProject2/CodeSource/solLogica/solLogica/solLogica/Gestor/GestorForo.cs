using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using solLogica.Estructura;
using solLogica.Persistente;
using solLogica.Clase;

namespace solLogica.Gestor
{
    public static class GestorForo
    {
        public static StrForo buscarForoPorIdGrupo(int idForo)
        {
            PersForo psForo = new PersForo();
            return psForo.buscarForoPorGrupo(idForo);
        }

        public static void registrarForo(String pnombre,int pidGrupo)
        {
            PersForo psForo = new PersForo();
            Foro foro = new Foro(pidGrupo, pnombre);
            psForo.registrarForo(foro);
        }

        /// <summary>
        /// Devuelve los foros del usuario
        /// </summary>
        /// <remarks>Author: Fabián Vega Ramírez</remarks>
        public static List<StrForo> listarForosPorUsuarioLog()
        {
            StrUsuario usuariolog = GestorUsuario.buscarUsuarioPorId(GestorSesion.getIdUsuario());
            List<StrForo> foros;

            if (GestorUsuario.buscarUsuarioPorRol("director académico").Contains(usuariolog))
            {
                foros = (new PersForo()).listarForosDA(GestorSesion.getIdUsuario());
            }
            else
            {
                foros = (new PersForo()).listarForos(GestorSesion.getIdUsuario());
            }
            
            //GestorBitacora.registrarBitacora("Listó todos sus foros.");
            return foros;
        }

        public static bool usuarioLogPuedeVerForo(int idForo)
        {
            StrUsuario usuario = GestorUsuario.buscarUsuarioPorId(GestorSesion.getIdUsuario());
            List<StrForo> foros = GestorForo.listarForosPorUsuarioLog();

            foreach (StrForo f in foros)
            {
                if (Convert.ToInt32(f.IdForo) == idForo)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool foroTieneTema(int idForo, int idTema)
        {
            List<StrTema> temas = GestorTema.listarTemasDeGrupo(idForo);
            foreach (StrTema t in temas)
            {
                if (Convert.ToInt32(t.IdTema) == idTema)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
