using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tia_Veneno.Permisos;

namespace Tia_Veneno.Controllers
{
    [ValidarSesion]
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult CerrarSesion()
        {

            Session["Usuario"] = null;
            return RedirectToAction("Login","Acceso");
        }
        public ActionResult variable()
        { 
        

        string variable = Convert.ToString(Session["Usuario"]);

            return RedirectToAction("Shop", "Shop");
        }
    }
}