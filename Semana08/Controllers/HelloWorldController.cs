using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana08.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        public ActionResult Pruebafun(string name,int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

        public String Welcome()
        {
            return "Este es el metodo welcome";
        }

        public String Salida(string prueba)
        {
            return "Este es el metodo salida mensaje: "+prueba;
        }

        public String Prueba(string prueba, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hola "+prueba+", ID: "+ID);
        }
    }
}