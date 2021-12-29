using E_Ticaret_BlockChain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace E_Ticaret_BlockChain.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DataContext _context = new DataContext();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u)
        {
            var info = _context.Users.FirstOrDefault(x => x.Mail == u.Mail && x.Password == u.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Mail, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }            
        }
    }
}