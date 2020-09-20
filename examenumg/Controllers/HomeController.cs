using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using examenumg.Models;
using examenumg.Extension;

namespace examenumg.Controllers
{
    public class HomeController : Controller
    {
        // Uso de Dependency Injection
        readonly IServicio _service;

        public HomeController(IServicio service)
        {
            _service = service;
        }


        // Ingreso de credenciales del usuario
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        // Validación de los datos del usuario
        [HttpPost]
        public ActionResult Valid(string usuario, string pwd)
        {
            // Validación de Usuario
            object respuesta;
            respuesta = _service.ValidacionUsuario(usuario, pwd);

            Result oResult = null;

            // valida el tipo de objeto en su respuesta
            if (respuesta is Result resultado)
            {
                // obtengo el resultado y se traslada al objeto de tipo Result
                oResult = resultado;
            }

            // Se realiza la instancia y traslado de informacion para sus elementos.
            var oRetorno = new Result()
            {
                iCodigo = oResult.iCodigo,
                cMessage = oResult.cMessage
            };

            return View(oRetorno);
        }

    }
}
