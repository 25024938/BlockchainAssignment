using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> Blocks = new List<Block>();
        int transactionPerBlock = 5;
        public List<Transaction> transactionPool = new List<Transaction>();

        public Blockchain()
        {
            Blocks.Add(new Block());
        }
        public String getBlockAsString(int index)
        {
            return Blocks[index].ToString();
        }
        public Block GetLastBlock()
        {

            return Blocks[Blocks.Count - 1];
        }

        public List<Transaction> getPendingTransactions()
        {
            int n = Math.Min(transactionPool.Count, transactionPerBlock);
            List<Transaction> transactions = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);
            return transactions;
        }

        public bool ValidateHash(Block b)
        {
            String rehash = b.CreateHash();
            return rehash.Equals(b.hash);
        }
        public bool ValidateMerkleRoot(Block b)
        {
            String reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.merkleRoot);
        }

        public double GetBalance(String address)
        {
            double balance = 0;
            foreach(Block b in Blocks)
            {
                foreach(Transaction t in b.transactionList)
                {
                    if(t.recipientAddress.Equals(address))
                    {
                        balance += t.amount;
                    }
                    if (t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee);
                    }
                }
            }
            return balance;
        }


        //Print the entire blockchain
        public override string ToString()
        {
            String output = String.Empty;
            //loops through all blocks in the blockchain and output block in string format
            Blocks.ForEach(b => output += b.ToString() + "\n");
                return output;
        }
    }
}
