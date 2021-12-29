using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace E_Ticaret_BlockChain.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<User> kullanicilar = new List<User>()
            {
                new User(){Name="user1",Surname="surname1",Mail="user1@mail.com",Password="user1"},
                new User(){Name="user2",Surname="surname2",Mail="user2@mail.com",Password="user2"},
                new User(){Name="user3",Surname="surname3",Mail="user3@mail.com",Password="user3"}                
            };
            foreach (var kullanici in kullanicilar)
            {
                context.Users.Add(kullanici);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){Title="Yıldızlı Gece",Price=15000,Description="",Image="sanat1.jpg",SellerId=1},
                new Product(){Title="İnci Küpeli Kız",Price=10000,Description="",Image="sanat2.jpg",SellerId=2},
                new Product(){Title="Çığlık",Price=8500,Description="",Image="sanat3.jpg",SellerId=3},
                new Product(){Title="Belleğin Azmi",Price=17600,Description="",Image="sanat4.jpg",SellerId=3},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            List<Transaction> islemler = new List<Transaction>()
            {
                new Transaction(){ProductId=1,SellerId=1,BuyerId=3},
                new Transaction(){ProductId=3,SellerId=2,BuyerId=1},
            };
            foreach (var islem in islemler)
            {
                context.Transactions.Add(islem);
            }
            context.SaveChanges();

            List<Block> blocks = new List<Block>()
            {
                new Block(){prevHash="000",hash="a123",data="adfsdf",timestamp="13432"}
            };
            foreach (var blocklar in blocks)
            {
                context.Blocks.Add(blocklar);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}