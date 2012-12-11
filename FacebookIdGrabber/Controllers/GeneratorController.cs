using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FacebookIdGrabber.Models;

namespace FacebookIdGrabber.Controllers
{
    public class GeneratorController : Controller
    {
        public ActionResult Generate(string username)
        {
            var generator = new Generator(username);
            ViewData["id"] = generator.id;
            return View();
        }
        
    }
}
