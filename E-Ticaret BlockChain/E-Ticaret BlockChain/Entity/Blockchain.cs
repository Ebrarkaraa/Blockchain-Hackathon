using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret_BlockChain.Entity
{
    public class Blockchain
    {
        public List<Block> chain = new List<Block>();

        public Block createGenesisBlock()
        {
            return new Block();
        }

        public Block getLatestBlock()
        {
            return this.chain[this.chain.Count - 1];
        }

        public void addBlock(Block newBlock)
        {
            //newBlock.prevHash = this.getLatestBlock().hash;
            //newBlock.hash = newBlock.calculateHash();
            this.chain.Add(newBlock);
        }
        public bool isChainValid()
        {
            for (int i = 1; i < this.chain.Count; i++)
            {
                Block currentBlock = this.chain[i];
                Block prevBlock = this.chain[i - 1];
                if (currentBlock.hash != currentBlock.calculateHash())
                {
                    return false;
                }
                if (currentBlock.prevHash != prevBlock.hash)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
