namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.PubKey = new System.Windows.Forms.TextBox();
            this.PriKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Validatebt = new System.Windows.Forms.Button();
            this.createTransaction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.TextBox();
            this.NewBlock = new System.Windows.Forms.Button();
            this.ReadAll = new System.Windows.Forms.Button();
            this.readPendingtransactions = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(842, 314);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Block";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 2;
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(767, 332);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(87, 49);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.generateWallet_Click);
            // 
            // PubKey
            // 
            this.PubKey.Location = new System.Drawing.Point(423, 332);
            this.PubKey.Name = "PubKey";
            this.PubKey.Size = new System.Drawing.Size(338, 20);
            this.PubKey.TabIndex = 4;
            // 
            // PriKey
            // 
            this.PriKey.Location = new System.Drawing.Point(423, 353);
            this.PriKey.Name = "PriKey";
            this.PriKey.Size = new System.Drawing.Size(338, 20);
            this.PriKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key";
            // 
            // Validatebt
            // 
            this.Validatebt.Location = new System.Drawing.Point(767, 388);
            this.Validatebt.Name = "Validatebt";
            this.Validatebt.Size = new System.Drawing.Size(87, 23);
            this.Validatebt.TabIndex = 8;
            this.Validatebt.Text = "Validate Keys";
            this.Validatebt.UseVisualStyleBackColor = true;
            this.Validatebt.Click += new System.EventHandler(this.Validatebt_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(12, 435);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(75, 44);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.createTransaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount";
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(148, 459);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(92, 20);
            this.fee.TabIndex = 11;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(147, 438);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(93, 20);
            this.amount.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Receiver Key";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(349, 455);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(338, 20);
            this.receiver.TabIndex = 14;
            // 
            // NewBlock
            // 
            this.NewBlock.Location = new System.Drawing.Point(13, 369);
            this.NewBlock.Name = "NewBlock";
            this.NewBlock.Size = new System.Drawing.Size(74, 42);
            this.NewBlock.TabIndex = 16;
            this.NewBlock.Text = "Generate New Block";
            this.NewBlock.UseVisualStyleBackColor = true;
            this.NewBlock.Click += new System.EventHandler(this.NewBlock_Click);
            // 
            // ReadAll
            // 
            this.ReadAll.Location = new System.Drawing.Point(176, 331);
            this.ReadAll.Name = "ReadAll";
            this.ReadAll.Size = new System.Drawing.Size(75, 23);
            this.ReadAll.TabIndex = 17;
            this.ReadAll.Text = "Read All";
            this.ReadAll.UseVisualStyleBackColor = true;
            this.ReadAll.Click += new System.EventHandler(this.ReadAll_Click);
            // 
            // readPendingtransactions
            // 
            this.readPendingtransactions.Location = new System.Drawing.Point(94, 369);
            this.readPendingtransactions.Name = "readPendingtransactions";
            this.readPendingtransactions.Size = new System.Drawing.Size(85, 42);
            this.readPendingtransactions.TabIndex = 18;
            this.readPendingtransactions.Text = "Read Pending Transactions";
            this.readPendingtransactions.UseVisualStyleBackColor = true;
            this.readPendingtransactions.Click += new System.EventHandler(this.readPendingtransactions_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(767, 438);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(87, 37);
            this.validate.TabIndex = 19;
            this.validate.Text = "Full Blockchain Validation";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(660, 388);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(101, 23);
            this.checkBalance.TabIndex = 20;
            this.checkBalance.Text = "Balance Check";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.checkBalance_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 481);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readPendingtransactions);
            this.Controls.Add(this.ReadAll);
            this.Controls.Add(this.NewBlock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.createTransaction);
            this.Controls.Add(this.Validatebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriKey);
            this.Controls.Add(this.PubKey);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.TextBox PubKey;
        private System.Windows.Forms.TextBox PriKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Validatebt;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.Button NewBlock;
        private System.Windows.Forms.Button ReadAll;
        private System.Windows.Forms.Button readPendingtransactions;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button checkBalance;
    }
}

