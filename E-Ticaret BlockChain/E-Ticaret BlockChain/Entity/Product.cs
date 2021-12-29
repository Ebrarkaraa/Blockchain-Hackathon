using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret_BlockChain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? SellerId { get; set; }
        public int? BuyerId { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
    }
}