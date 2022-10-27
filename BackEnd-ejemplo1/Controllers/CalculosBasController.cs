using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd_ejemplo1.Models;
using BackEnd_ejemplo1.Services;

namespace BackEnd_ejemplo1.Controllers
{
    public class CalculosBasController : Controller
    {
         //GET: CalculosBas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string Num1, string Num2)
        {
            int res = Convert.ToInt16(Num1) + Convert.ToInt16(Num2);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Operas()
        {
            OperaBas op = new OperaBas();
            return View(op);
        }
        public ActionResult Operas(OperaBas op)
        {
            op.Suma();
            ViewBag.Res = op.Res;
            return View(op);
        }
     
        public ActionResult MuestraPeliculas()
        {
            var peliculasservice = new PeliculaService();
            var model = peliculasservice.ObtenerPelicula();

            return View(model);
        }
        public ActionResult MuestraPeliculas2()
        {
            var peliculasservice = new PeliculaService();
            var model = peliculasservice.ObtenerPelicula();

            return View(model);
        }
        public ActionResult temporal()
        {
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult temporal2()
        {
            return RedirectToAction("index","Home");
        }
    }
}