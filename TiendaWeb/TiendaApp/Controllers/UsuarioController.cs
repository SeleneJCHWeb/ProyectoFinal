using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaLogic;
using TiendaOnline;

namespace TiendaApp.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var Listado = UsuarioCL.Listar();
            return View(Listado);
        }
    }
}