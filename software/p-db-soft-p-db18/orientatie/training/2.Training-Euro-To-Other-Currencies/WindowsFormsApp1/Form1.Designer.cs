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
            this.textBoxInputCustomCurrency = new System.Windows.Forms.TextBox();
            this.buttonConvertToEuro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelEuroSymbol = new System.Windows.Forms.Label();
            this.labelCustomCurrencySymbol = new System.Windows.Forms.Label();
            this.buttonConvertToCustomCurrency = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCurrencies = new System.Windows.Forms.ComboBox();
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
            // textBoxInputCustomCurrency
            // 
            this.textBoxInputCustomCurrency.Location = new System.Drawing.Point(308, 73);
            this.textBoxInputCustomCurrency.Name = "textBoxInputCustomCurrency";
            this.textBoxInputCustomCurrency.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputCustomCurrency.TabIndex = 1;
            this.textBoxInputCustomCurrency.Text = "1";
            // 
            // buttonConvertToEuro
            // 
            this.buttonConvertToEuro.Location = new System.Drawing.Point(201, 73);
            this.buttonConvertToEuro.Name = "buttonConvertToEuro";
            this.buttonConvertToEuro.Size = new System.Drawing.Size(42, 23);
            this.buttonConvertToEuro.TabIndex = 2;
            this.buttonConvertToEuro.Text = "<";
            this.buttonConvertToEuro.UseVisualStyleBackColor = true;
            this.buttonConvertToEuro.Click += new System.EventHandler(this.ConvertCustomCurrencyToEuro);
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
            // labelCustomCurrencySymbol
            // 
            this.labelCustomCurrencySymbol.AutoSize = true;
            this.labelCustomCurrencySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomCurrencySymbol.Location = new System.Drawing.Point(439, 53);
            this.labelCustomCurrencySymbol.Name = "labelCustomCurrencySymbol";
            this.labelCustomCurrencySymbol.Size = new System.Drawing.Size(53, 58);
            this.labelCustomCurrencySymbol.TabIndex = 6;
            this.labelCustomCurrencySymbol.Text = "$";
            // 
            // buttonConvertToCustomCurrency
            // 
            this.buttonConvertToCustomCurrency.Location = new System.Drawing.Point(249, 73);
            this.buttonConvertToCustomCurrency.Name = "buttonConvertToCustomCurrency";
            this.buttonConvertToCustomCurrency.Size = new System.Drawing.Size(42, 23);
            this.buttonConvertToCustomCurrency.TabIndex = 8;
            this.buttonConvertToCustomCurrency.Text = ">";
            this.buttonConvertToCustomCurrency.UseVisualStyleBackColor = true;
            this.buttonConvertToCustomCurrency.Click += new System.EventHandler(this.ConvertEuroToCustomCurrency);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Van euro naar:";
            // 
            // comboBoxCurrencies
            // 
            this.comboBoxCurrencies.FormattingEnabled = true;
            this.comboBoxCurrencies.Location = new System.Drawing.Point(249, 124);
            this.comboBoxCurrencies.Name = "comboBoxCurrencies";
            this.comboBoxCurrencies.Size = new System.Drawing.Size(159, 24);
            this.comboBoxCurrencies.TabIndex = 10;
            this.comboBoxCurrencies.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencies_SelectedIndexChanged);
            // 
            // EuroDollarConverterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 249);
            this.Controls.Add(this.comboBoxCurrencies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConvertToCustomCurrency);
            this.Controls.Add(this.labelCustomCurrencySymbol);
            this.Controls.Add(this.labelEuroSymbol);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConvertToEuro);
            this.Controls.Add(this.textBoxInputCustomCurrency);
            this.Controls.Add(this.textBoxInputEuro);
            this.Name = "EuroDollarConverterApp";
            this.Text = "Euro - US Dollar Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputEuro;
        private System.Windows.Forms.TextBox textBoxInputCustomCurrency;
        private System.Windows.Forms.Button buttonConvertToEuro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelEuroSymbol;
        private System.Windows.Forms.Label labelCustomCurrencySymbol;
        private System.Windows.Forms.Button buttonConvertToCustomCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCurrencies;
    }
}

