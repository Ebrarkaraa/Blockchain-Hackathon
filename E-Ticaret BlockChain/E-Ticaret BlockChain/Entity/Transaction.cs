using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret_BlockChain.Entity
{
    public class Transaction
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? SellerId { get; set; }
        public int? BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public Seller Seller { get; set; }
        public Product Product { get; set; }

    }
}