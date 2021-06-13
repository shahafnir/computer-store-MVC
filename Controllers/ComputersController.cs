using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace computer_store_MVC.Controllers
{
    public class ComputersController : Controller
    {
        // GET: Computers
        public ActionResult Index()
        {
            return View();
        }
    }
}