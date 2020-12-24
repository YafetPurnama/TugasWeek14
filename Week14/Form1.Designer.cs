namespace Week14
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNamaPanjang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxdari = new System.Windows.Forms.TextBox();
            this.textBoxmenjadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelhasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukan Kalimat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNamaPanjang
            // 
            this.textBoxNamaPanjang.Location = new System.Drawing.Point(204, 48);
            this.textBoxNamaPanjang.Name = "textBoxNamaPanjang";
            this.textBoxNamaPanjang.Size = new System.Drawing.Size(492, 20);
            this.textBoxNamaPanjang.TabIndex = 1;
            this.textBoxNamaPanjang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukan Huruf";
            // 
            // textBoxdari
            // 
            this.textBoxdari.Location = new System.Drawing.Point(204, 105);
            this.textBoxdari.Name = "textBoxdari";
            this.textBoxdari.Size = new System.Drawing.Size(169, 20);
            this.textBoxdari.TabIndex = 3;
            this.textBoxdari.TextChanged += new System.EventHandler(this.textBoxdari_TextChanged);
            // 
            // textBoxmenjadi
            // 
            this.textBoxmenjadi.Location = new System.Drawing.Point(490, 104);
            this.textBoxmenjadi.Name = "textBoxmenjadi";
            this.textBoxmenjadi.Size = new System.Drawing.Size(206, 20);
            this.textBoxmenjadi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menjadi";
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(205, 180);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(491, 51);
            this.buttonKonversi.TabIndex = 6;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil :";
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhasil.Location = new System.Drawing.Point(208, 286);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(0, 25);
            this.labelhasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxmenjadi);
            this.Controls.Add(this.textBoxdari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNamaPanjang);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamaPanjang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxdari;
        private System.Windows.Forms.TextBox textBoxmenjadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelhasil;
    }
}

