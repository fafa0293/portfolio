using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Security.Cryptography;
using solLogica.Persistente;
using solLogica.Estructura;

namespace solLogica.Gestor
{
    public static class GestorSeguridad
    {

        public static bool validarInicioSesion(String email, String contrasenna)
        {
            PersUsuario pu = new PersUsuario();
            StrUsuario usuario = pu.buscarUsuarioPorId(2); // cambiar por buscarUsuarioPorEmail(email)

            String contrasennaCifrada = usuario.Contrasenna;

            return (cifrarContrasenna(contrasenna) == contrasennaCifrada);
        }

        #region "proceso de cifrado"

        public static string cifrarContrasenna(string pText)
        {
            byte[] _arrByte = null;
           
            SHA256CryptoServiceProvider _hash = new SHA256CryptoServiceProvider();

            _arrByte = _hash.ComputeHash(Encoding.UTF8.GetBytes(pText));

            return Convert.ToBase64String(_arrByte);

        }
        #endregion
    }
}
