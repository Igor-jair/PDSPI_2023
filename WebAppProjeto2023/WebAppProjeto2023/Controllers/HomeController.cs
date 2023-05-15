using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto2023.Models;

namespace WebAppProjeto2023.Controllers
{
    public class HomeController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(
                context.Categorias.OrderBy(context => context.Nome),
                context.Fabricantes.OrderBy(context => context.Nome)
                );
        }
    }
}