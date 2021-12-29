using E_Ticaret_BlockChain.Entity;
using E_Ticaret_BlockChain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret_BlockChain.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Cart

        [Authorize]
        public ActionResult Index()
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int Id = 1)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id );
            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }
            return RedirectToAction("Index");
        }
        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);
            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }
        public Cart GetCart()
        { 
            var cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}