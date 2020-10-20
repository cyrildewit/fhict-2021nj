namespace WindowsFormsApp1
{
    partial class Form1
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
            this.numericUpDownInput = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculateFor = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonCalculateWhile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownInput
            // 
            this.numericUpDownInput.Location = new System.Drawing.Point(45, 92);
            this.numericUpDownInput.Name = "numericUpDownInput";
            this.numericUpDownInput.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownInput.TabIndex = 0;
            // 
            // buttonCalculateFor
            // 
            this.buttonCalculateFor.Location = new System.Drawing.Point(192, 92);
            this.buttonCalculateFor.Name = "buttonCalculateFor";
            this.buttonCalculateFor.Size = new System.Drawing.Size(145, 23);
            this.buttonCalculateFor.TabIndex = 1;
            this.buttonCalculateFor.Text = "Calculate with for";
            this.buttonCalculateFor.UseVisualStyleBackColor = true;
            this.buttonCalculateFor.Click += new System.EventHandler(this.ButtonCalculateFor_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(406, 95);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 17);
            this.labelOutput.TabIndex = 2;
            // 
            // buttonCalculateWhile
            // 
            this.buttonCalculateWhile.Location = new System.Drawing.Point(192, 121);
            this.buttonCalculateWhile.Name = "buttonCalculateWhile";
            this.buttonCalculateWhile.Size = new System.Drawing.Size(145, 23);
            this.buttonCalculateWhile.TabIndex = 3;
            this.buttonCalculateWhile.Text = "Calculate with while";
            this.buttonCalculateWhile.UseVisualStyleBackColor = true;
            this.buttonCalculateWhile.Click += new System.EventHandler(this.ButtonCalculateWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculateWhile);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonCalculateFor);
            this.Controls.Add(this.numericUpDownInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownInput;
        private System.Windows.Forms.Button buttonCalculateFor;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonCalculateWhile;
    }
}

