using E_Ticaret_BlockChain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret_BlockChain.Controllers
{
    public class BlockController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Block
        public ActionResult Index()
        {
            Blockchain blockchain = new Blockchain();
            List<Block> blocks = addTransactionInBlock();
            for (int i = 0; i < blocks.Count; i++)
            {
                blockchain.chain.Add(blocks[i]);
            }
            if (!blockchain.isChainValid())
            {
                //zincir kırlmış
            }
            return View(db.Blocks.ToList());
        }

        public List<Block> addTransactionInBlock()
        {
            List<Block> blocks = new List<Block>();
            Block genesisBlock = new Block();
            genesisBlock.id = 0;
            genesisBlock.timestamp = "11/11/2012";
            genesisBlock.data = "";
            genesisBlock.prevHash = "00000000000000000000000000000000000000000000000000";
            genesisBlock.hash = genesisBlock.calculateHash();
            blocks.Clear();
            blocks.Add(genesisBlock);
            db.Blocks.Add(genesisBlock);
            List<Transaction> transactions = db.Transactions.ToList();
            for (int i = 1; i <= transactions.Count; i++)
            {
                Block blck = new Block();
                blck.id = i;
                blck.timestamp = "12/12/2012";
                blck.data = (transactions[i-1].ProductId + transactions[i-1].SellerId + transactions[i-1].BuyerId).ToString();

                blck.prevHash = blocks[i - 1].hash;
                blck.hash = blck.calculateHash();
                blocks.Add(blck);
                db.Blocks.Add(blck);
                db.SaveChanges();
            }
            return blocks;
            
        }
    }
}