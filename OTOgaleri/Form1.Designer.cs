namespace OTOgaleri
{
    partial class sistgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistgiris));
            this.giris = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.degistir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.giristuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.LightCyan;
            this.giris.Image = ((System.Drawing.Image)(resources.GetObject("giris.Image")));
            this.giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giris.Location = new System.Drawing.Point(308, 330);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(56, 50);
            this.giris.TabIndex = 0;
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(253, 260);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(161, 20);
            this.sifre.TabIndex = 2;
            this.sifre.Text = "9876";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifrenizi Giriniz :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // degistir
            // 
            this.degistir.BackColor = System.Drawing.SystemColors.Menu;
            this.degistir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degistir.Location = new System.Drawing.Point(253, 386);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(181, 35);
            this.degistir.TabIndex = 5;
            this.degistir.Text = "Şifre Değiştir";
            this.degistir.UseVisualStyleBackColor = false;
            this.degistir.Click += new System.EventHandler(this.degistir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(103, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı Giriniz :";
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(253, 215);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(161, 20);
            this.kadi.TabIndex = 7;
            this.kadi.Text = "patron";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(103, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giriş Türü : ";
            // 
            // giristuru
            // 
            this.giristuru.FormattingEnabled = true;
            this.giristuru.Items.AddRange(new object[] {
            "Patron",
            "Müşteri Temsilcisi"});
            this.giristuru.Location = new System.Drawing.Point(253, 303);
            this.giristuru.Name = "giristuru";
            this.giristuru.Size = new System.Drawing.Size(161, 21);
            this.giristuru.TabIndex = 9;
            // 
            // sistgiris
            // 
            this.AcceptButton = this.giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(548, 431);
            this.Controls.Add(this.giristuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.degistir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.giris);
            this.Name = "sistgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİSTEME GİRİŞ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button degistir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox giristuru;
    }
}

