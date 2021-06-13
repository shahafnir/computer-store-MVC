using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using computer_store_MVC.Models;

namespace computer_store_MVC.Controllers
{
    public class ComputersController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ComputersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Computers
        public ActionResult Index()
        {
            List<Computer> computers = new List<Computer>()
        {
            new Computer(1, "HP", "P122","i-7700k",32,500,4000,"https://www.hp.com/us-en/shop/app/assets/images/product/3C627UA%23ABA/center_facing.png?_=1595408015124")
        };

            return View();
        }
    }
}