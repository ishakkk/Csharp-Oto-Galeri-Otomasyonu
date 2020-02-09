namespace OTOgaleri
{
    partial class tmslcekrn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tmslcekrn));
            this.satisgir = new System.Windows.Forms.Button();
            this.aracgor = new System.Windows.Forms.Button();
            this.cikisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // satisgir
            // 
            this.satisgir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisgir.Location = new System.Drawing.Point(115, 63);
            this.satisgir.Name = "satisgir";
            this.satisgir.Size = new System.Drawing.Size(139, 33);
            this.satisgir.TabIndex = 1;
            this.satisgir.Text = "Satış Gir";
            this.satisgir.UseVisualStyleBackColor = true;
            this.satisgir.Click += new System.EventHandler(this.satisgir_Click);
            // 
            // aracgor
            // 
            this.aracgor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracgor.Location = new System.Drawing.Point(115, 135);
            this.aracgor.Name = "aracgor";
            this.aracgor.Size = new System.Drawing.Size(139, 33);
            this.aracgor.TabIndex = 2;
            this.aracgor.Text = "Araba Görüntüle";
            this.aracgor.UseVisualStyleBackColor = true;
            this.aracgor.Click += new System.EventHandler(this.aracgor_Click);
            // 
            // cikisyap
            // 
            this.cikisyap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisyap.BackgroundImage")));
            this.cikisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisyap.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisyap.Location = new System.Drawing.Point(153, 208);
            this.cikisyap.Name = "cikisyap";
            this.cikisyap.Size = new System.Drawing.Size(59, 56);
            this.cikisyap.TabIndex = 3;
            this.cikisyap.UseVisualStyleBackColor = true;
            this.cikisyap.Click += new System.EventHandler(this.cikisyap_Click);
            // 
            // tmslcekrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(363, 298);
            this.Controls.Add(this.cikisyap);
            this.Controls.Add(this.aracgor);
            this.Controls.Add(this.satisgir);
            this.Name = "tmslcekrn";
            this.Text = "Temsilci Yönlendirme Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button satisgir;
        private System.Windows.Forms.Button aracgor;
        private System.Windows.Forms.Button cikisyap;
    }
}