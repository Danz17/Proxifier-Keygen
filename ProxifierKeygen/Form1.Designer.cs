namespace ProxifierKeygen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxKeyOutput = new System.Windows.Forms.TextBox();
            this.checkBoxCustomKeyPart = new System.Windows.Forms.CheckBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxExpiration = new System.Windows.Forms.CheckBox();
            this.textBoxCustomKeyPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(325, 496);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(336, 107);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "GENERATE";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Proxifier Standard Edition",
            "Proxifier Portable Edition",
            "Proxifier for Mac"});
            this.comboBox1.Location = new System.Drawing.Point(395, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(415, 45);
            this.comboBox1.TabIndex = 1;
            // 
            // textBoxKeyOutput
            // 
            this.textBoxKeyOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyOutput.Location = new System.Drawing.Point(32, 341);
            this.textBoxKeyOutput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxKeyOutput.Name = "textBoxKeyOutput";
            this.textBoxKeyOutput.ReadOnly = true;
            this.textBoxKeyOutput.Size = new System.Drawing.Size(932, 69);
            this.textBoxKeyOutput.TabIndex = 3;
            this.textBoxKeyOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxCustomKeyPart
            // 
            this.checkBoxCustomKeyPart.AutoSize = true;
            this.checkBoxCustomKeyPart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomKeyPart.Location = new System.Drawing.Point(189, 143);
            this.checkBoxCustomKeyPart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxCustomKeyPart.Name = "checkBoxCustomKeyPart";
            this.checkBoxCustomKeyPart.Size = new System.Drawing.Size(305, 42);
            this.checkBoxCustomKeyPart.TabIndex = 4;
            this.checkBoxCustomKeyPart.Text = "Custom 4th key part";
            this.checkBoxCustomKeyPart.UseVisualStyleBackColor = true;
            this.checkBoxCustomKeyPart.CheckedChanged += new System.EventHandler(this.checkBoxCustomKeyPart_CheckedChanged);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(181, 60);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(113, 38);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Product";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 222);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTimePicker1.MaxDate = new System.DateTime(3001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 44);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2099, 5, 4, 23, 23, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBoxExpiration
            // 
            this.checkBoxExpiration.AutoSize = true;
            this.checkBoxExpiration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExpiration.Location = new System.Drawing.Point(189, 234);
            this.checkBoxExpiration.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxExpiration.Name = "checkBoxExpiration";
            this.checkBoxExpiration.Size = new System.Drawing.Size(205, 42);
            this.checkBoxExpiration.TabIndex = 10;
            this.checkBoxExpiration.Text = "Expiring key";
            this.checkBoxExpiration.UseVisualStyleBackColor = true;
            this.checkBoxExpiration.CheckedChanged += new System.EventHandler(this.checkBoxExpiration_CheckedChanged);
            // 
            // textBoxCustomKeyPart
            // 
            this.textBoxCustomKeyPart.Enabled = false;
            this.textBoxCustomKeyPart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomKeyPart.Location = new System.Drawing.Point(624, 136);
            this.textBoxCustomKeyPart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxCustomKeyPart.MaxLength = 5;
            this.textBoxCustomKeyPart.Name = "textBoxCustomKeyPart";
            this.textBoxCustomKeyPart.Size = new System.Drawing.Size(185, 47);
            this.textBoxCustomKeyPart.TabIndex = 11;
            this.textBoxCustomKeyPart.TextChanged += new System.EventHandler(this.textBoxCustomKeyPart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 424);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "The key was automatically copied to the clipboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 610);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(854, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "If you paid for this, get a refund! Made by Danz#4441 for Eductional purposes.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 658);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buy me a coffee, PayPal aqweider@gmail.com :)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCustomKeyPart);
            this.Controls.Add(this.checkBoxExpiration);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.checkBoxCustomKeyPart);
            this.Controls.Add(this.textBoxKeyOutput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Proxifier Keygen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxKeyOutput;
        private System.Windows.Forms.CheckBox checkBoxCustomKeyPart;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxExpiration;
        private System.Windows.Forms.TextBox textBoxCustomKeyPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

