
namespace ChallengeBankAccount
{
    partial class BankAccountForm
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
            this.labelTitleLeftBankAccount = new System.Windows.Forms.Label();
            this.labelTitleRightBankAccount = new System.Windows.Forms.Label();
            this.buttonWithdrawLeftBankAccount = new System.Windows.Forms.Button();
            this.textBoxWithdrawLeftBankAccount = new System.Windows.Forms.TextBox();
            this.labelWithdrawLeftBankAccount = new System.Windows.Forms.Label();
            this.buttonDepositLeftBankAccount = new System.Windows.Forms.Button();
            this.textBoxDepositLeftBankAccount = new System.Windows.Forms.TextBox();
            this.labelDepositLeftBankAccount = new System.Windows.Forms.Label();
            this.buttonTransferLeftBankAccount = new System.Windows.Forms.Button();
            this.textBoxTransferLeftBankAccount = new System.Windows.Forms.TextBox();
            this.labelTransferLeftBankAccount = new System.Windows.Forms.Label();
            this.buttonWithdrawRightBankAccount = new System.Windows.Forms.Button();
            this.textBoxWithdrawRightBankAccount = new System.Windows.Forms.TextBox();
            this.labelWithdrawRightBankAccount = new System.Windows.Forms.Label();
            this.buttonDepositRightBankAccount = new System.Windows.Forms.Button();
            this.textBoxDepositRightBankAccount = new System.Windows.Forms.TextBox();
            this.labelDepositRightBankAccount = new System.Windows.Forms.Label();
            this.buttonTransferRightBankAccount = new System.Windows.Forms.Button();
            this.textBoxTransferRightBankAccount = new System.Windows.Forms.TextBox();
            this.labelTransferRightBankAccount = new System.Windows.Forms.Label();
            this.labelBalanceHeadingLeftBankAccount = new System.Windows.Forms.Label();
            this.labelBalanceOutputLeftBankAccount = new System.Windows.Forms.Label();
            this.labelBalanceOutputRightBankAccount = new System.Windows.Forms.Label();
            this.labelBalanceHeadingRightBankAccount = new System.Windows.Forms.Label();
            this.listBoxTransactions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitleLeftBankAccount
            // 
            this.labelTitleLeftBankAccount.AutoSize = true;
            this.labelTitleLeftBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleLeftBankAccount.Location = new System.Drawing.Point(28, 31);
            this.labelTitleLeftBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleLeftBankAccount.Name = "labelTitleLeftBankAccount";
            this.labelTitleLeftBankAccount.Size = new System.Drawing.Size(266, 24);
            this.labelTitleLeftBankAccount.TabIndex = 1;
            this.labelTitleLeftBankAccount.Text = "Bankrekening: Duck, Dagobert";
            // 
            // labelTitleRightBankAccount
            // 
            this.labelTitleRightBankAccount.AutoSize = true;
            this.labelTitleRightBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleRightBankAccount.Location = new System.Drawing.Point(532, 31);
            this.labelTitleRightBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleRightBankAccount.Name = "labelTitleRightBankAccount";
            this.labelTitleRightBankAccount.Size = new System.Drawing.Size(221, 24);
            this.labelTitleRightBankAccount.TabIndex = 11;
            this.labelTitleRightBankAccount.Text = "Bankrekening: Gans, Gijs";
            // 
            // buttonWithdrawLeftBankAccount
            // 
            this.buttonWithdrawLeftBankAccount.Location = new System.Drawing.Point(193, 172);
            this.buttonWithdrawLeftBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWithdrawLeftBankAccount.Name = "buttonWithdrawLeftBankAccount";
            this.buttonWithdrawLeftBankAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonWithdrawLeftBankAccount.TabIndex = 0;
            this.buttonWithdrawLeftBankAccount.Text = "Bedrag opnemen";
            this.buttonWithdrawLeftBankAccount.UseVisualStyleBackColor = true;
            this.buttonWithdrawLeftBankAccount.Click += new System.EventHandler(this.buttonWithdrawLeftBankAccount_Click);
            // 
            // textBoxWithdrawLeftBankAccount
            // 
            this.textBoxWithdrawLeftBankAccount.Location = new System.Drawing.Point(39, 175);
            this.textBoxWithdrawLeftBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWithdrawLeftBankAccount.Name = "textBoxWithdrawLeftBankAccount";
            this.textBoxWithdrawLeftBankAccount.Size = new System.Drawing.Size(132, 22);
            this.textBoxWithdrawLeftBankAccount.TabIndex = 2;
            // 
            // labelWithdrawLeftBankAccount
            // 
            this.labelWithdrawLeftBankAccount.AutoSize = true;
            this.labelWithdrawLeftBankAccount.Location = new System.Drawing.Point(35, 144);
            this.labelWithdrawLeftBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWithdrawLeftBankAccount.Name = "labelWithdrawLeftBankAccount";
            this.labelWithdrawLeftBankAccount.Size = new System.Drawing.Size(67, 16);
            this.labelWithdrawLeftBankAccount.TabIndex = 3;
            this.labelWithdrawLeftBankAccount.Text = "Opnemen";
            // 
            // buttonDepositLeftBankAccount
            // 
            this.buttonDepositLeftBankAccount.Location = new System.Drawing.Point(193, 254);
            this.buttonDepositLeftBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDepositLeftBankAccount.Name = "buttonDepositLeftBankAccount";
            this.buttonDepositLeftBankAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonDepositLeftBankAccount.TabIndex = 4;
            this.buttonDepositLeftBankAccount.Text = "Bedrag storten";
            this.buttonDepositLeftBankAccount.UseVisualStyleBackColor = true;
            this.buttonDepositLeftBankAccount.Click += new System.EventHandler(this.buttonDepositLeftBankAccount_Click);
            // 
            // textBoxDepositLeftBankAccount
            // 
            this.textBoxDepositLeftBankAccount.Location = new System.Drawing.Point(39, 256);
            this.textBoxDepositLeftBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDepositLeftBankAccount.Name = "textBoxDepositLeftBankAccount";
            this.textBoxDepositLeftBankAccount.Size = new System.Drawing.Size(132, 22);
            this.textBoxDepositLeftBankAccount.TabIndex = 5;
            // 
            // labelDepositLeftBankAccount
            // 
            this.labelDepositLeftBankAccount.AutoSize = true;
            this.labelDepositLeftBankAccount.Location = new System.Drawing.Point(35, 225);
            this.labelDepositLeftBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepositLeftBankAccount.Name = "labelDepositLeftBankAccount";
            this.labelDepositLeftBankAccount.Size = new System.Drawing.Size(50, 16);
            this.labelDepositLeftBankAccount.TabIndex = 6;
            this.labelDepositLeftBankAccount.Text = "Storten";
            // 
            // buttonTransferLeftBankAccount
            // 
            this.buttonTransferLeftBankAccount.Location = new System.Drawing.Point(193, 342);
            this.buttonTransferLeftBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTransferLeftBankAccount.Name = "buttonTransferLeftBankAccount";
            this.buttonTransferLeftBankAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonTransferLeftBankAccount.TabIndex = 7;
            this.buttonTransferLeftBankAccount.Text = "Bedrag overboeken";
            this.buttonTransferLeftBankAccount.UseVisualStyleBackColor = true;
            this.buttonTransferLeftBankAccount.Click += new System.EventHandler(this.buttonTransferLeftBankAccount_Click);
            // 
            // textBoxTransferLeftBankAccount
            // 
            this.textBoxTransferLeftBankAccount.Location = new System.Drawing.Point(39, 345);
            this.textBoxTransferLeftBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTransferLeftBankAccount.Name = "textBoxTransferLeftBankAccount";
            this.textBoxTransferLeftBankAccount.Size = new System.Drawing.Size(132, 22);
            this.textBoxTransferLeftBankAccount.TabIndex = 8;
            // 
            // labelTransferLeftBankAccount
            // 
            this.labelTransferLeftBankAccount.AutoSize = true;
            this.labelTransferLeftBankAccount.Location = new System.Drawing.Point(35, 314);
            this.labelTransferLeftBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransferLeftBankAccount.Name = "labelTransferLeftBankAccount";
            this.labelTransferLeftBankAccount.Size = new System.Drawing.Size(100, 16);
            this.labelTransferLeftBankAccount.TabIndex = 9;
            this.labelTransferLeftBankAccount.Text = "Overboeken >>";
            // 
            // buttonWithdrawRightBankAccount
            // 
            this.buttonWithdrawRightBankAccount.Location = new System.Drawing.Point(697, 172);
            this.buttonWithdrawRightBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWithdrawRightBankAccount.Name = "buttonWithdrawRightBankAccount";
            this.buttonWithdrawRightBankAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonWithdrawRightBankAccount.TabIndex = 10;
            this.buttonWithdrawRightBankAccount.Text = "Bedrag opnemen";
            this.buttonWithdrawRightBankAccount.UseVisualStyleBackColor = true;
            this.buttonWithdrawRightBankAccount.Click += new System.EventHandler(this.buttonWithdrawRightBankAccount_Click);
            // 
            // textBoxWithdrawRightBankAccount
            // 
            this.textBoxWithdrawRightBankAccount.Location = new System.Drawing.Point(543, 175);
            this.textBoxWithdrawRightBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWithdrawRightBankAccount.Name = "textBoxWithdrawRightBankAccount";
            this.textBoxWithdrawRightBankAccount.Size = new System.Drawing.Size(132, 22);
            this.textBoxWithdrawRightBankAccount.TabIndex = 12;
            // 
            // labelWithdrawRightBankAccount
            // 
            this.labelWithdrawRightBankAccount.AutoSize = true;
            this.labelWithdrawRightBankAccount.Location = new System.Drawing.Point(539, 144);
            this.labelWithdrawRightBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWithdrawRightBankAccount.Name = "labelWithdrawRightBankAccount";
            this.labelWithdrawRightBankAccount.Size = new System.Drawing.Size(67, 16);
            this.labelWithdrawRightBankAccount.TabIndex = 13;
            this.labelWithdrawRightBankAccount.Text = "Opnemen";
            // 
            // buttonDepositRightBankAccount
            // 
            this.buttonDepositRightBankAccount.Location = new System.Drawing.Point(697, 254);
            this.buttonDepositRightBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDepositRightBankAccount.Name = "buttonDepositRightBankAccount";
            this.buttonDepositRightBankAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonDepositRightBankAccount.TabIndex = 14;
            this.buttonDepositRightBankAccount.Text = "Bedrag storten";
            this.buttonDepositRightBankAccount.UseVisualStyleBackColor = true;
            this.buttonDepositRightBankAccount.Click += new System.EventHandler(this.buttonDepositRightBankAccount_Click);
            // 
            // textBoxDepositRightBankAccount
            // 
            this.textBoxDepositRightBankAccount.Location = new System.Drawing.Point(543, 256);
            this.textBoxDepositRightBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDepositRightBankAccount.Name = "textBoxDepositRightBankAccount";
            this.textBoxDepositRightBankAccount.Size = new System.Drawing.Size(132, 22);
            this.textBoxDepositRightBankAccount.TabIndex = 15;
            // 
            // labelDepositRightBankAccount
            // 
            this.labelDepositRightBankAccount.AutoSize = true;
            this.labelDepositRightBankAccount.Location = new System.Drawing.Point(539, 225);
            this.labelDepositRightBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepositRightBankAccount.Name = "labelDepositRightBankAccount";
            this.labelDepositRightBankAccount.Size = new System.Drawing.Size(50, 16);
            this.labelDepositRightBankAccount.TabIndex = 16;
            this.labelDepositRightBankAccount.Text = "Storten";
            // 
            // buttonTransferRightBankAccount
            // 
            this.buttonTransferRightBankAccount.Location = new System.Drawing.Point(697, 342);
            this.buttonTransferRightBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTransferRightBankAccount.Name = "buttonTransferRightBankAccount";
            this.buttonTransferRightBankAccount.Size = new System.Drawing.Size(148, 28);
            this.buttonTransferRightBankAccount.TabIndex = 17;
            this.buttonTransferRightBankAccount.Text = "Bedrag overboeken";
            this.buttonTransferRightBankAccount.UseVisualStyleBackColor = true;
            this.buttonTransferRightBankAccount.Click += new System.EventHandler(this.buttonTransferRightBankAccount_Click);
            // 
            // textBoxTransferRightBankAccount
            // 
            this.textBoxTransferRightBankAccount.Location = new System.Drawing.Point(543, 345);
            this.textBoxTransferRightBankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTransferRightBankAccount.Name = "textBoxTransferRightBankAccount";
            this.textBoxTransferRightBankAccount.Size = new System.Drawing.Size(132, 22);
            this.textBoxTransferRightBankAccount.TabIndex = 18;
            // 
            // labelTransferRightBankAccount
            // 
            this.labelTransferRightBankAccount.AutoSize = true;
            this.labelTransferRightBankAccount.Location = new System.Drawing.Point(539, 314);
            this.labelTransferRightBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransferRightBankAccount.Name = "labelTransferRightBankAccount";
            this.labelTransferRightBankAccount.Size = new System.Drawing.Size(100, 16);
            this.labelTransferRightBankAccount.TabIndex = 19;
            this.labelTransferRightBankAccount.Text = "Overboeken <<";
            // 
            // labelBalanceHeadingLeftBankAccount
            // 
            this.labelBalanceHeadingLeftBankAccount.AutoSize = true;
            this.labelBalanceHeadingLeftBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceHeadingLeftBankAccount.Location = new System.Drawing.Point(35, 90);
            this.labelBalanceHeadingLeftBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalanceHeadingLeftBankAccount.Name = "labelBalanceHeadingLeftBankAccount";
            this.labelBalanceHeadingLeftBankAccount.Size = new System.Drawing.Size(53, 16);
            this.labelBalanceHeadingLeftBankAccount.TabIndex = 20;
            this.labelBalanceHeadingLeftBankAccount.Text = "Saldo:";
            // 
            // labelBalanceOutputLeftBankAccount
            // 
            this.labelBalanceOutputLeftBankAccount.AutoSize = true;
            this.labelBalanceOutputLeftBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceOutputLeftBankAccount.Location = new System.Drawing.Point(113, 90);
            this.labelBalanceOutputLeftBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalanceOutputLeftBankAccount.Name = "labelBalanceOutputLeftBankAccount";
            this.labelBalanceOutputLeftBankAccount.Size = new System.Drawing.Size(16, 16);
            this.labelBalanceOutputLeftBankAccount.TabIndex = 21;
            this.labelBalanceOutputLeftBankAccount.Text = "--";
            // 
            // labelBalanceOutputRightBankAccount
            // 
            this.labelBalanceOutputRightBankAccount.AutoSize = true;
            this.labelBalanceOutputRightBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceOutputRightBankAccount.Location = new System.Drawing.Point(617, 90);
            this.labelBalanceOutputRightBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalanceOutputRightBankAccount.Name = "labelBalanceOutputRightBankAccount";
            this.labelBalanceOutputRightBankAccount.Size = new System.Drawing.Size(16, 16);
            this.labelBalanceOutputRightBankAccount.TabIndex = 23;
            this.labelBalanceOutputRightBankAccount.Text = "--";
            // 
            // labelBalanceHeadingRightBankAccount
            // 
            this.labelBalanceHeadingRightBankAccount.AutoSize = true;
            this.labelBalanceHeadingRightBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceHeadingRightBankAccount.Location = new System.Drawing.Point(539, 90);
            this.labelBalanceHeadingRightBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalanceHeadingRightBankAccount.Name = "labelBalanceHeadingRightBankAccount";
            this.labelBalanceHeadingRightBankAccount.Size = new System.Drawing.Size(53, 16);
            this.labelBalanceHeadingRightBankAccount.TabIndex = 22;
            this.labelBalanceHeadingRightBankAccount.Text = "Saldo:";
            // 
            // listBoxTransactions
            // 
            this.listBoxTransactions.ItemHeight = 16;
            this.listBoxTransactions.Location = new System.Drawing.Point(38, 410);
            this.listBoxTransactions.Name = "listBoxTransactions";
            this.listBoxTransactions.Size = new System.Drawing.Size(807, 196);
            this.listBoxTransactions.TabIndex = 25;
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 644);
            this.Controls.Add(this.listBoxTransactions);
            this.Controls.Add(this.labelBalanceOutputRightBankAccount);
            this.Controls.Add(this.labelBalanceHeadingRightBankAccount);
            this.Controls.Add(this.labelBalanceOutputLeftBankAccount);
            this.Controls.Add(this.labelBalanceHeadingLeftBankAccount);
            this.Controls.Add(this.labelTransferRightBankAccount);
            this.Controls.Add(this.textBoxTransferRightBankAccount);
            this.Controls.Add(this.buttonTransferRightBankAccount);
            this.Controls.Add(this.labelDepositRightBankAccount);
            this.Controls.Add(this.textBoxDepositRightBankAccount);
            this.Controls.Add(this.buttonDepositRightBankAccount);
            this.Controls.Add(this.labelWithdrawRightBankAccount);
            this.Controls.Add(this.textBoxWithdrawRightBankAccount);
            this.Controls.Add(this.labelTitleRightBankAccount);
            this.Controls.Add(this.buttonWithdrawRightBankAccount);
            this.Controls.Add(this.labelTransferLeftBankAccount);
            this.Controls.Add(this.textBoxTransferLeftBankAccount);
            this.Controls.Add(this.buttonTransferLeftBankAccount);
            this.Controls.Add(this.labelDepositLeftBankAccount);
            this.Controls.Add(this.textBoxDepositLeftBankAccount);
            this.Controls.Add(this.buttonDepositLeftBankAccount);
            this.Controls.Add(this.labelWithdrawLeftBankAccount);
            this.Controls.Add(this.textBoxWithdrawLeftBankAccount);
            this.Controls.Add(this.labelTitleLeftBankAccount);
            this.Controls.Add(this.buttonWithdrawLeftBankAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BankAccountForm";
            this.Text = "Bankzaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitleLeftBankAccount;
        private System.Windows.Forms.Label labelTitleRightBankAccount;
        private System.Windows.Forms.Button buttonWithdrawLeftBankAccount;
        private System.Windows.Forms.TextBox textBoxWithdrawLeftBankAccount;
        private System.Windows.Forms.Label labelWithdrawLeftBankAccount;
        private System.Windows.Forms.Button buttonDepositLeftBankAccount;
        private System.Windows.Forms.TextBox textBoxDepositLeftBankAccount;
        private System.Windows.Forms.Label labelDepositLeftBankAccount;
        private System.Windows.Forms.Button buttonTransferLeftBankAccount;
        private System.Windows.Forms.TextBox textBoxTransferLeftBankAccount;
        private System.Windows.Forms.Label labelTransferLeftBankAccount;
        private System.Windows.Forms.Button buttonWithdrawRightBankAccount;
        private System.Windows.Forms.TextBox textBoxWithdrawRightBankAccount;
        private System.Windows.Forms.Label labelWithdrawRightBankAccount;
        private System.Windows.Forms.Button buttonDepositRightBankAccount;
        private System.Windows.Forms.TextBox textBoxDepositRightBankAccount;
        private System.Windows.Forms.Label labelDepositRightBankAccount;
        private System.Windows.Forms.Button buttonTransferRightBankAccount;
        private System.Windows.Forms.TextBox textBoxTransferRightBankAccount;
        private System.Windows.Forms.Label labelTransferRightBankAccount;
        private System.Windows.Forms.Label labelBalanceHeadingLeftBankAccount;
        private System.Windows.Forms.Label labelBalanceOutputLeftBankAccount;
        private System.Windows.Forms.Label labelBalanceOutputRightBankAccount;
        private System.Windows.Forms.Label labelBalanceHeadingRightBankAccount;
        private System.Windows.Forms.ListBox listBoxTransactions;
    }
}

