namespace CalculatorWindowsForms
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
            this.operasi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hasiltxt = new System.Windows.Forms.TextBox();
            this.angka2 = new System.Windows.Forms.TextBox();
            this.angka1 = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.Button();
            this.operator1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // operasi
            // 
            this.operasi.AutoSize = true;
            this.operasi.Location = new System.Drawing.Point(12, 33);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(43, 13);
            this.operasi.TabIndex = 0;
            this.operasi.Text = "Operasi";
            this.operasi.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // hasiltxt
            // 
            this.hasiltxt.Location = new System.Drawing.Point(233, 109);
            this.hasiltxt.Name = "hasiltxt";
            this.hasiltxt.Size = new System.Drawing.Size(100, 20);
            this.hasiltxt.TabIndex = 5;
            this.hasiltxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // angka2
            // 
            this.angka2.Location = new System.Drawing.Point(233, 71);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(100, 20);
            this.angka2.TabIndex = 6;
            // 
            // angka1
            // 
            this.angka1.Location = new System.Drawing.Point(233, 30);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(100, 20);
            this.angka1.TabIndex = 7;
            this.angka1.TextChanged += new System.EventHandler(this.angka1_TextChanged);
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(65, 119);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(75, 23);
            this.hasil.TabIndex = 8;
            this.hasil.Text = "Hitung";
            this.hasil.UseVisualStyleBackColor = true;
            this.hasil.Click += new System.EventHandler(this.button1_Click);
            // 
            // operator1
            // 
            this.operator1.FormattingEnabled = true;
            this.operator1.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Pembagian",
            "Perkalian"});
            this.operator1.Location = new System.Drawing.Point(65, 30);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(121, 21);
            this.operator1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.operator1);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.angka1);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.hasiltxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hasiltxt;
        private System.Windows.Forms.TextBox angka2;
        private System.Windows.Forms.TextBox angka1;
        private System.Windows.Forms.ComboBox operator1;
        private System.Windows.Forms.Button hasil;
    }
}

