using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret_BlockChain.Entity
{
    public class Buyer : User
    {
        public int BuyerId { get; set; }

        public List<Product> Products { get; set; }
    }
}