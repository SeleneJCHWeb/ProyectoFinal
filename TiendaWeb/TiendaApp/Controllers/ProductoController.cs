using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaLogic;

namespace TiendaApp.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var listado = ProductoCL.Listar();
            return View(listado);
        }

        public ActionResult Listar()
        {
            return View();
        }
    }
}