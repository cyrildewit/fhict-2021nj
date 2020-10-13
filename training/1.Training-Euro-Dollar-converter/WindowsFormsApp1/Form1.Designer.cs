namespace WindowsFormsApp1
{
    partial class EuroDollarConverterApp
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
            this.textBoxInputEuro = new System.Windows.Forms.TextBox();
            this.textBoxInputDollar = new System.Windows.Forms.TextBox();
            this.buttonConvertToEuro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.labelEuroSymbol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConvertToDollar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputEuro
            // 
            this.textBoxInputEuro.Location = new System.Drawing.Point(80, 73);
            this.textBoxInputEuro.Name = "textBoxInputEuro";
            this.textBoxInputEuro.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputEuro.TabIndex = 0;
            this.textBoxInputEuro.Text = "1";
            // 
            // textBoxInputDollar
            // 
            this.textBoxInputDollar.Location = new System.Drawing.Point(308, 73);
            this.textBoxInputDollar.Name = "textBoxInputDollar";
            this.textBoxInputDollar.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputDollar.TabIndex = 1;
            this.textBoxInputDollar.Text = "1";
            // 
            // buttonConvertToEuro
            // 
            this.buttonConvertToEuro.Location = new System.Drawing.Point(201, 73);
            this.buttonConvertToEuro.Name = "buttonConvertToEuro";
            this.buttonConvertToEuro.Size = new System.Drawing.Size(42, 23);
            this.buttonConvertToEuro.TabIndex = 2;
            this.buttonConvertToEuro.Text = "<";
            this.buttonConvertToEuro.UseVisualStyleBackColor = true;
            this.buttonConvertToEuro.Click += new System.EventHandler(this.ConvertDollarToEuro);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownExchangeRate
            // 
            this.numericUpDownExchangeRate.DecimalPlaces = 2;
            this.numericUpDownExchangeRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownExchangeRate.Location = new System.Drawing.Point(273, 133);
            this.numericUpDownExchangeRate.Name = "numericUpDownExchangeRate";
            this.numericUpDownExchangeRate.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownExchangeRate.TabIndex = 4;
            this.numericUpDownExchangeRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelEuroSymbol
            // 
            this.labelEuroSymbol.AutoSize = true;
            this.labelEuroSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuroSymbol.Location = new System.Drawing.Point(12, 53);
            this.labelEuroSymbol.Name = "labelEuroSymbol";
            this.labelEuroSymbol.Size = new System.Drawing.Size(53, 58);
            this.labelEuroSymbol.TabIndex = 5;
            this.labelEuroSymbol.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Koers: 1 euro = $";
            // 
            // buttonConvertToDollar
            // 
            this.buttonConvertToDollar.Location = new System.Drawing.Point(249, 73);
            this.buttonConvertToDollar.Name = "buttonConvertToDollar";
            this.buttonConvertToDollar.Size = new System.Drawing.Size(42, 23);
            this.buttonConvertToDollar.TabIndex = 8;
            this.buttonConvertToDollar.Text = ">";
            this.buttonConvertToDollar.UseVisualStyleBackColor = true;
            this.buttonConvertToDollar.Click += new System.EventHandler(this.ConvertEuroToDollar);
            // 
            // EuroDollarConverterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 249);
            this.Controls.Add(this.buttonConvertToDollar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEuroSymbol);
            this.Controls.Add(this.numericUpDownExchangeRate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConvertToEuro);
            this.Controls.Add(this.textBoxInputDollar);
            this.Controls.Add(this.textBoxInputEuro);
            this.Name = "EuroDollarConverterApp";
            this.Text = "Euro - US Dollar Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputEuro;
        private System.Windows.Forms.TextBox textBoxInputDollar;
        private System.Windows.Forms.Button buttonConvertToEuro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownExchangeRate;
        private System.Windows.Forms.Label labelEuroSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConvertToDollar;
    }
}

