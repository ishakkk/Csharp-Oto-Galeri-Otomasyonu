namespace OTOgaleri
{
    partial class calisanliste
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temsilcilisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buySellDBDataSet = new OTOgaleri.BuySellDBDataSet();
            this.temsilcilisteTableAdapter = new OTOgaleri.BuySellDBDataSetTableAdapters.temsilcilisteTableAdapter();
            this.ciktems = new System.Windows.Forms.Button();
            this.siltid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temsilcilisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buySellDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.temsilcilisteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // temsilcilisteBindingSource
            // 
            this.temsilcilisteBindingSource.DataMember = "temsilciliste";
            this.temsilcilisteBindingSource.DataSource = this.buySellDBDataSet;
            // 
            // buySellDBDataSet
            // 
            this.buySellDBDataSet.DataSetName = "BuySellDBDataSet";
            this.buySellDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temsilcilisteTableAdapter
            // 
            this.temsilcilisteTableAdapter.ClearBeforeFill = true;
            // 
            // ciktems
            // 
            this.ciktems.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ciktems.Location = new System.Drawing.Point(43, 367);
            this.ciktems.Name = "ciktems";
            this.ciktems.Size = new System.Drawing.Size(144, 30);
            this.ciktems.TabIndex = 6;
            this.ciktems.Text = "Temsilciyi Çıkart";
            this.ciktems.UseVisualStyleBackColor = true;
            this.ciktems.Click += new System.EventHandler(this.ciktems_Click);
            // 
            // siltid
            // 
            this.siltid.Location = new System.Drawing.Point(43, 341);
            this.siltid.Name = "siltid";
            this.siltid.Size = new System.Drawing.Size(144, 20);
            this.siltid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Çıkarılacak Temsilci ID :";
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "Temsilci Ad & Soyad";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            // 
            // calisanliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 409);
            this.Controls.Add(this.ciktems);
            this.Controls.Add(this.siltid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "calisanliste";
            this.Text = "Çalışanlar Listesi";
            this.Load += new System.EventHandler(this.calisanliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temsilcilisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buySellDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BuySellDBDataSet buySellDBDataSet;
        private System.Windows.Forms.BindingSource temsilcilisteBindingSource;
        private BuySellDBDataSetTableAdapters.temsilcilisteTableAdapter temsilcilisteTableAdapter;
        public System.Windows.Forms.Button ciktems;
        public System.Windows.Forms.TextBox siltid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
    }
}