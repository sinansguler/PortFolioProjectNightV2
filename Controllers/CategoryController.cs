using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortFolioProjectNightV2.Controllers
{
    public class CategoryController : Controller
    {

        public ActionResult Categorylist()
        {
            return View();
        }

        public ActionResult CreateCategory()
        {
            return View(); 
        }
    }
}