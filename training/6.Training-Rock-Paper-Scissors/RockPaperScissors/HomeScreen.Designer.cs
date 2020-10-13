namespace RockPaperScissors
{
    partial class HomeScreen
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
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.radioButtonScissors = new System.Windows.Forms.RadioButton();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.radioButtonPaper = new System.Windows.Forms.RadioButton();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxEnemy = new System.Windows.Forms.GroupBox();
            this.radioButtonEnemyScissors = new System.Windows.Forms.RadioButton();
            this.radioButtonEnemyRock = new System.Windows.Forms.RadioButton();
            this.radioButtonEnemyPaper = new System.Windows.Forms.RadioButton();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWinsCount = new System.Windows.Forms.Label();
            this.labelDrawsCount = new System.Windows.Forms.Label();
            this.labelLosesCount = new System.Windows.Forms.Label();
            this.groupBoxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.groupBoxEnemy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.radioButtonScissors);
            this.groupBoxPlayer.Controls.Add(this.radioButtonRock);
            this.groupBoxPlayer.Controls.Add(this.radioButtonPaper);
            this.groupBoxPlayer.Controls.Add(this.pictureBoxPlayer);
            this.groupBoxPlayer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(200, 301);
            this.groupBoxPlayer.TabIndex = 0;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player";
            // 
            // radioButtonScissors
            // 
            this.radioButtonScissors.AutoSize = true;
            this.radioButtonScissors.Location = new System.Drawing.Point(6, 266);
            this.radioButtonScissors.Name = "radioButtonScissors";
            this.radioButtonScissors.Size = new System.Drawing.Size(82, 21);
            this.radioButtonScissors.TabIndex = 4;
            this.radioButtonScissors.TabStop = true;
            this.radioButtonScissors.Text = "Scissors";
            this.radioButtonScissors.UseVisualStyleBackColor = true;
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Location = new System.Drawing.Point(6, 239);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(61, 21);
            this.radioButtonRock.TabIndex = 3;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "Rock";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaper
            // 
            this.radioButtonPaper.AutoSize = true;
            this.radioButtonPaper.Location = new System.Drawing.Point(6, 212);
            this.radioButtonPaper.Name = "radioButtonPaper";
            this.radioButtonPaper.Size = new System.Drawing.Size(67, 21);
            this.radioButtonPaper.TabIndex = 2;
            this.radioButtonPaper.TabStop = true;
            this.radioButtonPaper.Text = "Paper";
            this.radioButtonPaper.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(188, 171);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            this.pictureBoxPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxEnemy
            // 
            this.groupBoxEnemy.Controls.Add(this.radioButtonEnemyScissors);
            this.groupBoxEnemy.Controls.Add(this.radioButtonEnemyRock);
            this.groupBoxEnemy.Controls.Add(this.radioButtonEnemyPaper);
            this.groupBoxEnemy.Controls.Add(this.pictureBoxEnemy);
            this.groupBoxEnemy.Location = new System.Drawing.Point(275, 12);
            this.groupBoxEnemy.Name = "groupBoxEnemy";
            this.groupBoxEnemy.Size = new System.Drawing.Size(200, 301);
            this.groupBoxEnemy.TabIndex = 5;
            this.groupBoxEnemy.TabStop = false;
            this.groupBoxEnemy.Text = "Enemy";
            // 
            // radioButtonEnemyScissors
            // 
            this.radioButtonEnemyScissors.AutoSize = true;
            this.radioButtonEnemyScissors.Enabled = false;
            this.radioButtonEnemyScissors.Location = new System.Drawing.Point(6, 266);
            this.radioButtonEnemyScissors.Name = "radioButtonEnemyScissors";
            this.radioButtonEnemyScissors.Size = new System.Drawing.Size(82, 21);
            this.radioButtonEnemyScissors.TabIndex = 4;
            this.radioButtonEnemyScissors.TabStop = true;
            this.radioButtonEnemyScissors.Text = "Scissors";
            this.radioButtonEnemyScissors.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnemyRock
            // 
            this.radioButtonEnemyRock.AutoSize = true;
            this.radioButtonEnemyRock.Enabled = false;
            this.radioButtonEnemyRock.Location = new System.Drawing.Point(6, 239);
            this.radioButtonEnemyRock.Name = "radioButtonEnemyRock";
            this.radioButtonEnemyRock.Size = new System.Drawing.Size(61, 21);
            this.radioButtonEnemyRock.TabIndex = 3;
            this.radioButtonEnemyRock.TabStop = true;
            this.radioButtonEnemyRock.Text = "Rock";
            this.radioButtonEnemyRock.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnemyPaper
            // 
            this.radioButtonEnemyPaper.AutoSize = true;
            this.radioButtonEnemyPaper.Enabled = false;
            this.radioButtonEnemyPaper.Location = new System.Drawing.Point(6, 212);
            this.radioButtonEnemyPaper.Name = "radioButtonEnemyPaper";
            this.radioButtonEnemyPaper.Size = new System.Drawing.Size(67, 21);
            this.radioButtonEnemyPaper.TabIndex = 2;
            this.radioButtonEnemyPaper.TabStop = true;
            this.radioButtonEnemyPaper.Text = "Paper";
            this.radioButtonEnemyPaper.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(188, 171);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemy.TabIndex = 0;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(508, 33);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(267, 164);
            this.listBoxResults.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of draws:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of loses:";
            // 
            // labelWinsCount
            // 
            this.labelWinsCount.AutoSize = true;
            this.labelWinsCount.Location = new System.Drawing.Point(630, 228);
            this.labelWinsCount.Name = "labelWinsCount";
            this.labelWinsCount.Size = new System.Drawing.Size(16, 17);
            this.labelWinsCount.TabIndex = 10;
            this.labelWinsCount.Text = "0";
            // 
            // labelDrawsCount
            // 
            this.labelDrawsCount.AutoSize = true;
            this.labelDrawsCount.Location = new System.Drawing.Point(630, 251);
            this.labelDrawsCount.Name = "labelDrawsCount";
            this.labelDrawsCount.Size = new System.Drawing.Size(16, 17);
            this.labelDrawsCount.TabIndex = 11;
            this.labelDrawsCount.Text = "0";
            // 
            // labelLosesCount
            // 
            this.labelLosesCount.AutoSize = true;
            this.labelLosesCount.Location = new System.Drawing.Point(630, 278);
            this.labelLosesCount.Name = "labelLosesCount";
            this.labelLosesCount.Size = new System.Drawing.Size(16, 17);
            this.labelLosesCount.TabIndex = 12;
            this.labelLosesCount.Text = "0";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLosesCount);
            this.Controls.Add(this.labelDrawsCount);
            this.Controls.Add(this.labelWinsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxEnemy);
            this.Controls.Add(this.groupBoxPlayer);
            this.Name = "HomeScreen";
            this.Text = "Paper Rock Scissors";
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.groupBoxEnemy.ResumeLayout(false);
            this.groupBoxEnemy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonScissors;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.RadioButton radioButtonPaper;
        private System.Windows.Forms.GroupBox groupBoxEnemy;
        private System.Windows.Forms.RadioButton radioButtonEnemyScissors;
        private System.Windows.Forms.RadioButton radioButtonEnemyRock;
        private System.Windows.Forms.RadioButton radioButtonEnemyPaper;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWinsCount;
        private System.Windows.Forms.Label labelDrawsCount;
        private System.Windows.Forms.Label labelLosesCount;
    }
}

