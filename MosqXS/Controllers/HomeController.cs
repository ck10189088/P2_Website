using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MosqXS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MosqXSMain()
        {
            return View();
        }

        public IActionResult MosqXSHotSpot()
        {
            return View();
        }

        public ActionResult toHotSpot()
        {
            return RedirectToAction("MosqXSHotSpot");
        }

        public IActionResult MosqXSInfo()
        {
            return View();
        }
        public ActionResult MosqXSProduct()
        {
            return View();
        }
    }
}