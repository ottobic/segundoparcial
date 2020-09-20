using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examenumg.Models;

namespace examenumg.Extension
{
    public class Servicio : IServicio
    {
        // Validación de los datos del usuario
        public object ValidacionUsuario(string usuario, string pwd)
        {
            int codigo = 0;
            var mensaje = "";

            // Busca el usuario
            var passwordUsuario = BuscaUsuario(usuario);

            // Valido la contraseña obtenida
            // En esta parte se puede modificar para agregar un llamado 
            // a una encriptación de contaseña, esto para mantener el principio solid Responsabilidad Unical

            // pwd = EncriptacionPassword(pwd);

            if (passwordUsuario == pwd)
            {
                mensaje = "Bienvenido...";
            }
            else
            {
                codigo = 1;
                mensaje = "Usuario o Password invalido..";
            }

            var oRespuesta = new Result()
            {
                iCodigo = codigo,
                cMessage = mensaje
            };

            return oRespuesta;
        }


        // Busca el usuario, en esta parte es una validación con un dato quemado,
        // pero aca se puede hacer una conexion a una base de datos haciendo la busqueda
        // y devolviendo la contraseña para su posterior validación
        string BuscaUsuario(string usuario)
        {
            var passwordUsuario = "";

            if (usuario == "otto20")
                passwordUsuario = "123456";

            return passwordUsuario;
        }
    }
}
