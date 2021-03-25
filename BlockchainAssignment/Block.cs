using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        DateTime timestamp;
        public int index;
        public String hash;
        public String prevHash;

        public List<Transaction> transactionList = new List<Transaction>();
        public String merkleRoot;

        public long nonce = 0;
        public int difficulty = 4;

        public double reward = 1.0;
        public double fees = .0;
        public String minerAddress = String.Empty;


        //Genesis Block
        public Block()
        {
            timestamp = DateTime.Now;
            index = 0;
            prevHash = String.Empty;
            this.merkleRoot = String.Empty;
            hash = Mine();
           
        }

        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)
        {
            timestamp = DateTime.Now;
            prevHash = lastBlock.hash;
            index = lastBlock.index + 1;
            this.minerAddress = minerAddress;
            transactions.Add(createRewardTransaction(transactions));
            this.transactionList = transactions;
            this.merkleRoot = MerkleRoot(transactionList);
            hash = Mine();

        }
        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timestamp.ToString() + prevHash + nonce.ToString() + merkleRoot;
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes((input)));

            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }
        public String Mine()
        {
            String hash = CreateHash();

            String re = new string('0', difficulty); // String of difficulty hash must have 4 zero to be mined
            while(!hash.StartsWith(re))
            {
                nonce++;
                hash = CreateHash();
            }
            return hash;
        }

        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            fees = transactions.Aggregate(.0, (acc, t) => acc + t.fee);
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, "");
        }

        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList();
           //No transaction
            if (hashes.Count == 0)
            {
                return String.Empty;
            }
            //one transaction
            if (hashes.Count == 1)
            {
                return HashCode.HashTools.combineHash(hashes[0], hashes[0]);
            }
            //two or more transactions
            while (hashes.Count != 1)
            {
                List<String> merkleLeaves = new List<String>();

                for (int i = 0; i < hashes.Count; i += 2)
                {
                    // when there is one independent hash combines with self
                    if (i == hashes.Count - 1)
                    {
                        
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i])); //handle odd number of leaves
                    }
                    // Else combine adjacent leaves
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i + 1])); // hash in pairs
                    }
                }
                hashes = merkleLeaves;
            }
            return hashes[0];
        }


        public override string ToString()
        {
            //String transactions = String.Empty;
           // transactionList.ForEach(t => transactions += (t.ToString() + "\n"));

            String transactions = String.Join("\n", transactionList);
            return "index: " + index.ToString() +
                "\tTimestamp: " + timestamp.ToString() +
                "\nPrevious Hash: " + prevHash +
                "\nHash: " + hash +
                "\nNonce: " + nonce.ToString() +
                "\nMerkleRoot: " + merkleRoot +
                "\nDifficulty Level: " + difficulty.ToString() +
                "\nTransactions: " + transactions;
        }

    }
}
