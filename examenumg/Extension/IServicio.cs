using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examenumg.Extension
{
    public interface IServicio
    {
        /// <summary>
        /// Valida usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        object ValidacionUsuario(string usuario, string pwd);
    }
}
