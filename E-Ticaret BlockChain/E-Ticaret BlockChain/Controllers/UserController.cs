using E_Ticaret_BlockChain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret_BlockChain.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        DataContext _context = new DataContext();
        public ActionResult Index()
        {
            return View(_context.Users.ToList());
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User u)
        {
            if (!ModelState.IsValid)
            {
                return View("AddUser");
            }
            _context.Users.Add(u);
            _context.SaveChanges();
            return View();
        }
    }
}