using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareRoutingASP.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        //GET   Test/Login/22/administrador
        public ActionResult Login(int id,string role)
        {
            //Le pasamos a la vista un ViewBag
            ViewBag.Id = id;
            ViewBag.Role = role;
            return View();
        }

         //     Test/SearchByTItle/tester
        public ActionResult SearchByTtitle(string title)
        {
            ViewBag.Title = title;
            return View();
        }



    }
}