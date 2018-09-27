namespace WindowsFormsApp1___Fah
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
            this.buttonHitung = new System.Windows.Forms.Button();
            this.txtnilaiA = new System.Windows.Forms.TextBox();
            this.txtnilaiB = new System.Windows.Forms.TextBox();
            this.lstHasil = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(245, 146);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(161, 96);
            this.buttonHitung.TabIndex = 0;
            this.buttonHitung.Text = "Hitung";
            this.buttonHitung.UseVisualStyleBackColor = true;
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // txtnilaiA
            // 
            this.txtnilaiA.Location = new System.Drawing.Point(72, 76);
            this.txtnilaiA.Name = "txtnilaiA";
            this.txtnilaiA.Size = new System.Drawing.Size(113, 22);
            this.txtnilaiA.TabIndex = 1;
            // 
            // txtnilaiB
            // 
            this.txtnilaiB.Location = new System.Drawing.Point(72, 146);
            this.txtnilaiB.Name = "txtnilaiB";
            this.txtnilaiB.Size = new System.Drawing.Size(113, 22);
            this.txtnilaiB.TabIndex = 2;
            // 
            // lstHasil
            // 
            this.lstHasil.Location = new System.Drawing.Point(72, 220);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(113, 22);
            this.lstHasil.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.comboBox.Location = new System.Drawing.Point(245, 74);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(161, 24);
            this.comboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nilai B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operasi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(458, 298);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.txtnilaiB);
            this.Controls.Add(this.txtnilaiA);
            this.Controls.Add(this.buttonHitung);
            this.Name = "Form1";
            this.Text = "Kalkulator Mini";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.TextBox txtnilaiA;
        private System.Windows.Forms.TextBox txtnilaiB;
        private System.Windows.Forms.TextBox lstHasil;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

