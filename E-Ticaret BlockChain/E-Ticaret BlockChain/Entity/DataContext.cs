using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Ticaret_BlockChain.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Block> Blocks { get; set; }
        //public DbSet<Blockchain> Blockchains { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}