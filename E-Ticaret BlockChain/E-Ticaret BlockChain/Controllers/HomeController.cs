using E_Ticaret_BlockChain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret_BlockChain.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Shop()
        {
            return View(_context.Products.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}