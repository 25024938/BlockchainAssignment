using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;
        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            richTextBox1.Text = "New Blockchain Initialised!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(Int32.TryParse(textBox1.Text, out index))
            {
                richTextBox1.Text = blockchain.getBlockAsString(index);
            }
        }

        private void generateWallet_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            PubKey.Text = myNewWallet.publicID;
            PriKey.Text = privKey;
        }

        private void Validatebt_Click(object sender, EventArgs e)
        {
            if(Wallet.Wallet.ValidatePrivateKey(PriKey.Text, PubKey.Text))
            {
                richTextBox1.Text = "Keys are Valid!";
            }
            else
            {
                richTextBox1.Text = " Keys are not Valid";
            }
        }

        private void createTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(PubKey.Text, receiver.Text, Double.Parse(amount.Text),Double.Parse(fee.Text), PriKey.Text);
            blockchain.transactionPool.Add(transaction);
            richTextBox1.Text = transaction.ToString();
        }

        private void NewBlock_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = blockchain.getPendingTransactions();
            Block newBlock = new Block(blockchain.GetLastBlock(), transactions, PubKey.Text);
            blockchain.Blocks.Add(newBlock);
            richTextBox1.Text = blockchain.ToString();
        }

        private void ReadAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ToString();
        }

        private void readPendingtransactions_Click(object sender, EventArgs e)
        {
            String transactions = String.Empty;
            blockchain.transactionPool.ForEach(t => transactions += (t.ToString() + "\n"));
            richTextBox1.Text = transactions;
        }

        private void validate_Click(object sender, EventArgs e)
        {
            if (blockchain.Blocks.Count == 1)
            {
                if (blockchain.ValidateMerkleRoot(blockchain.Blocks[0]))
                {
                    richTextBox1.Text = "Blockchain is valid";
                }
                else
                {
                    richTextBox1.Text = "Blockchain is invalid: Merkle Root";
                }

                return;
            }
            else
            {
                for (int i = 1; i < blockchain.Blocks.Count-1; i++)
                {
                    if (
                        blockchain.Blocks[i].prevHash != blockchain.Blocks[i - 1].hash ||   //Hash link check
                        blockchain.ValidateHash(blockchain.Blocks[i]) ||                    //Merkle Root Check
                        !blockchain.ValidateMerkleRoot(blockchain.Blocks[i])                //Hash Check
                        ) 
                    {
                        richTextBox1.Text = "Blockchain is invalid";
                        return;
                    }
                }
            }
            richTextBox1.Text = "Valid Blockchain";
        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.GetBalance(PubKey.Text).ToString() + " BCoins ";
        }
    }
}
