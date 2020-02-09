namespace OTOgaleri
{
    partial class yoneticiekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticiekrani));
            this.arceklcik = new System.Windows.Forms.Button();
            this.tmsleklcik = new System.Windows.Forms.Button();
            this.satisgir = new System.Windows.Forms.Button();
            this.arcgoruntule = new System.Windows.Forms.Button();
            this.stlnarac = new System.Windows.Forms.Button();
            this.cikisyap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arceklcik
            // 
            this.arceklcik.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arceklcik.Location = new System.Drawing.Point(125, 35);
            this.arceklcik.Name = "arceklcik";
            this.arceklcik.Size = new System.Drawing.Size(139, 33);
            this.arceklcik.TabIndex = 0;
            this.arceklcik.Text = "Araç Ekle / Güncelle";
            this.arceklcik.UseVisualStyleBackColor = true;
            this.arceklcik.Click += new System.EventHandler(this.arceklcik_Click);
            // 
            // tmsleklcik
            // 
            this.tmsleklcik.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmsleklcik.Location = new System.Drawing.Point(125, 241);
            this.tmsleklcik.Name = "tmsleklcik";
            this.tmsleklcik.Size = new System.Drawing.Size(139, 33);
            this.tmsleklcik.TabIndex = 1;
            this.tmsleklcik.Text = "Temsilci Ekle";
            this.tmsleklcik.UseVisualStyleBackColor = true;
            this.tmsleklcik.Click += new System.EventHandler(this.tmsleklcik_Click);
            // 
            // satisgir
            // 
            this.satisgir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisgir.Location = new System.Drawing.Point(125, 170);
            this.satisgir.Name = "satisgir";
            this.satisgir.Size = new System.Drawing.Size(139, 33);
            this.satisgir.TabIndex = 2;
            this.satisgir.Text = "Satış Gir";
            this.satisgir.UseVisualStyleBackColor = true;
            this.satisgir.Click += new System.EventHandler(this.satisgir_Click);
            // 
            // arcgoruntule
            // 
            this.arcgoruntule.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arcgoruntule.Location = new System.Drawing.Point(125, 98);
            this.arcgoruntule.Name = "arcgoruntule";
            this.arcgoruntule.Size = new System.Drawing.Size(139, 33);
            this.arcgoruntule.TabIndex = 3;
            this.arcgoruntule.Text = "Araç Görüntüle / Sil";
            this.arcgoruntule.UseVisualStyleBackColor = true;
            this.arcgoruntule.Click += new System.EventHandler(this.arcgoruntule_Click_1);
            // 
            // stlnarac
            // 
            this.stlnarac.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stlnarac.Location = new System.Drawing.Point(125, 307);
            this.stlnarac.Name = "stlnarac";
            this.stlnarac.Size = new System.Drawing.Size(139, 53);
            this.stlnarac.TabIndex = 4;
            this.stlnarac.Text = "Satılan Araçları Görüntüle";
            this.stlnarac.UseVisualStyleBackColor = true;
            this.stlnarac.Click += new System.EventHandler(this.stlnarac_Click);
            // 
            // cikisyap
            // 
            this.cikisyap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisyap.BackgroundImage")));
            this.cikisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisyap.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisyap.Location = new System.Drawing.Point(164, 469);
            this.cikisyap.Name = "cikisyap";
            this.cikisyap.Size = new System.Drawing.Size(59, 56);
            this.cikisyap.TabIndex = 5;
            this.cikisyap.UseVisualStyleBackColor = true;
            this.cikisyap.Click += new System.EventHandler(this.cikisyap_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(125, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Temsilci Görüntüle / Çıkar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yoneticiekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(389, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikisyap);
            this.Controls.Add(this.stlnarac);
            this.Controls.Add(this.arcgoruntule);
            this.Controls.Add(this.satisgir);
            this.Controls.Add(this.tmsleklcik);
            this.Controls.Add(this.arceklcik);
            this.Name = "yoneticiekrani";
            this.Text = "Yönetici Yönlendirme Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button arceklcik;
        private System.Windows.Forms.Button tmsleklcik;
        private System.Windows.Forms.Button satisgir;
        private System.Windows.Forms.Button arcgoruntule;
        private System.Windows.Forms.Button stlnarac;
        private System.Windows.Forms.Button cikisyap;
        private System.Windows.Forms.Button button1;
    }
}