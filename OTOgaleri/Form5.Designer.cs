namespace OTOgaleri
{
    partial class aracgoruntule
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
            this.label1 = new System.Windows.Forms.Label();
            this.silkno = new System.Windows.Forms.TextBox();
            this.aracsil = new System.Windows.Forms.Button();
            this.tablgunc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.araceklevegoruntuleTableAdapter = new OTOgaleri.BuySellDBDataSetTableAdapters.araceklevegoruntuleTableAdapter();
            this.buySellDBDataSet = new OTOgaleri.BuySellDBDataSet();
            this.araceklevegoruntuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arackimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruhsatnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasatipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorhacmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorgucuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cekisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakauyrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goruntupathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raporpathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kacincisahipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buySellDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araceklevegoruntuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silinecek Aracın Kimlik No :";
            // 
            // silkno
            // 
            this.silkno.Location = new System.Drawing.Point(231, 356);
            this.silkno.Name = "silkno";
            this.silkno.Size = new System.Drawing.Size(121, 20);
            this.silkno.TabIndex = 2;
            // 
            // aracsil
            // 
            this.aracsil.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracsil.Location = new System.Drawing.Point(387, 349);
            this.aracsil.Name = "aracsil";
            this.aracsil.Size = new System.Drawing.Size(75, 30);
            this.aracsil.TabIndex = 3;
            this.aracsil.Text = "Araç Sil";
            this.aracsil.UseVisualStyleBackColor = true;
            this.aracsil.Click += new System.EventHandler(this.aracsil_Click);
            // 
            // tablgunc
            // 
            this.tablgunc.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tablgunc.Location = new System.Drawing.Point(16, 307);
            this.tablgunc.Name = "tablgunc";
            this.tablgunc.Size = new System.Drawing.Size(123, 30);
            this.tablgunc.TabIndex = 4;
            this.tablgunc.Text = "Tablo Güncelle";
            this.tablgunc.UseVisualStyleBackColor = true;
            this.tablgunc.Click += new System.EventHandler(this.tablgunc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arackimlikDataGridViewTextBoxColumn,
            this.ruhsatnoDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.seriDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.yakitDataGridViewTextBoxColumn,
            this.vitesDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.kasatipiDataGridViewTextBoxColumn,
            this.motorhacmiDataGridViewTextBoxColumn,
            this.motorgucuDataGridViewTextBoxColumn,
            this.cekisDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.garantiDataGridViewTextBoxColumn,
            this.plakauyrukDataGridViewTextBoxColumn,
            this.plakanoDataGridViewTextBoxColumn,
            this.kimdenDataGridViewTextBoxColumn,
            this.takasDataGridViewTextBoxColumn,
            this.durumuDataGridViewTextBoxColumn,
            this.goruntupathDataGridViewTextBoxColumn,
            this.raporpathDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.kacincisahipDataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 301);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // araceklevegoruntuleTableAdapter
            // 
            this.araceklevegoruntuleTableAdapter.ClearBeforeFill = true;
            // 
            // buySellDBDataSet
            // 
            this.buySellDBDataSet.DataSetName = "BuySellDBDataSet";
            this.buySellDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araceklevegoruntuleBindingSource
            // 
            this.araceklevegoruntuleBindingSource.DataMember = "araceklevegoruntule";
            this.araceklevegoruntuleBindingSource.DataSource = this.buySellDBDataSet;
            // 
            // arackimlikDataGridViewTextBoxColumn
            // 
            this.arackimlikDataGridViewTextBoxColumn.DataPropertyName = "arackimlik";
            this.arackimlikDataGridViewTextBoxColumn.HeaderText = "Arac Kimlik (ID)";
            this.arackimlikDataGridViewTextBoxColumn.Name = "arackimlikDataGridViewTextBoxColumn";
            // 
            // ruhsatnoDataGridViewTextBoxColumn
            // 
            this.ruhsatnoDataGridViewTextBoxColumn.DataPropertyName = "ruhsatno";
            this.ruhsatnoDataGridViewTextBoxColumn.HeaderText = "Ruhsat No ";
            this.ruhsatnoDataGridViewTextBoxColumn.Name = "ruhsatnoDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // seriDataGridViewTextBoxColumn
            // 
            this.seriDataGridViewTextBoxColumn.DataPropertyName = "seri";
            this.seriDataGridViewTextBoxColumn.HeaderText = "Seri";
            this.seriDataGridViewTextBoxColumn.Name = "seriDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "Yıl";
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            // 
            // yakitDataGridViewTextBoxColumn
            // 
            this.yakitDataGridViewTextBoxColumn.DataPropertyName = "yakit";
            this.yakitDataGridViewTextBoxColumn.HeaderText = "Yakıt";
            this.yakitDataGridViewTextBoxColumn.Name = "yakitDataGridViewTextBoxColumn";
            // 
            // vitesDataGridViewTextBoxColumn
            // 
            this.vitesDataGridViewTextBoxColumn.DataPropertyName = "vites";
            this.vitesDataGridViewTextBoxColumn.HeaderText = "Vites";
            this.vitesDataGridViewTextBoxColumn.Name = "vitesDataGridViewTextBoxColumn";
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Kilometre";
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            // 
            // kasatipiDataGridViewTextBoxColumn
            // 
            this.kasatipiDataGridViewTextBoxColumn.DataPropertyName = "kasatipi";
            this.kasatipiDataGridViewTextBoxColumn.HeaderText = "Kasa Tipi";
            this.kasatipiDataGridViewTextBoxColumn.Name = "kasatipiDataGridViewTextBoxColumn";
            // 
            // motorhacmiDataGridViewTextBoxColumn
            // 
            this.motorhacmiDataGridViewTextBoxColumn.DataPropertyName = "motorhacmi";
            this.motorhacmiDataGridViewTextBoxColumn.HeaderText = "Motor Hacmi";
            this.motorhacmiDataGridViewTextBoxColumn.Name = "motorhacmiDataGridViewTextBoxColumn";
            // 
            // motorgucuDataGridViewTextBoxColumn
            // 
            this.motorgucuDataGridViewTextBoxColumn.DataPropertyName = "motorgucu";
            this.motorgucuDataGridViewTextBoxColumn.HeaderText = "Motor Gücü";
            this.motorgucuDataGridViewTextBoxColumn.Name = "motorgucuDataGridViewTextBoxColumn";
            // 
            // cekisDataGridViewTextBoxColumn
            // 
            this.cekisDataGridViewTextBoxColumn.DataPropertyName = "cekis";
            this.cekisDataGridViewTextBoxColumn.HeaderText = "Çekiş";
            this.cekisDataGridViewTextBoxColumn.Name = "cekisDataGridViewTextBoxColumn";
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "Renk";
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            // 
            // garantiDataGridViewTextBoxColumn
            // 
            this.garantiDataGridViewTextBoxColumn.DataPropertyName = "garanti";
            this.garantiDataGridViewTextBoxColumn.HeaderText = "Garanti";
            this.garantiDataGridViewTextBoxColumn.Name = "garantiDataGridViewTextBoxColumn";
            // 
            // plakauyrukDataGridViewTextBoxColumn
            // 
            this.plakauyrukDataGridViewTextBoxColumn.DataPropertyName = "plakauyruk";
            this.plakauyrukDataGridViewTextBoxColumn.HeaderText = "Plaka Uyruk";
            this.plakauyrukDataGridViewTextBoxColumn.Name = "plakauyrukDataGridViewTextBoxColumn";
            // 
            // plakanoDataGridViewTextBoxColumn
            // 
            this.plakanoDataGridViewTextBoxColumn.DataPropertyName = "plakano";
            this.plakanoDataGridViewTextBoxColumn.HeaderText = "Plaka No";
            this.plakanoDataGridViewTextBoxColumn.Name = "plakanoDataGridViewTextBoxColumn";
            // 
            // kimdenDataGridViewTextBoxColumn
            // 
            this.kimdenDataGridViewTextBoxColumn.DataPropertyName = "kimden";
            this.kimdenDataGridViewTextBoxColumn.HeaderText = "Kimden";
            this.kimdenDataGridViewTextBoxColumn.Name = "kimdenDataGridViewTextBoxColumn";
            // 
            // takasDataGridViewTextBoxColumn
            // 
            this.takasDataGridViewTextBoxColumn.DataPropertyName = "takas";
            this.takasDataGridViewTextBoxColumn.HeaderText = "Takas";
            this.takasDataGridViewTextBoxColumn.Name = "takasDataGridViewTextBoxColumn";
            // 
            // durumuDataGridViewTextBoxColumn
            // 
            this.durumuDataGridViewTextBoxColumn.DataPropertyName = "durumu";
            this.durumuDataGridViewTextBoxColumn.HeaderText = "Durumu";
            this.durumuDataGridViewTextBoxColumn.Name = "durumuDataGridViewTextBoxColumn";
            // 
            // goruntupathDataGridViewTextBoxColumn
            // 
            this.goruntupathDataGridViewTextBoxColumn.DataPropertyName = "goruntupath";
            this.goruntupathDataGridViewTextBoxColumn.HeaderText = "Görüntü URL";
            this.goruntupathDataGridViewTextBoxColumn.Name = "goruntupathDataGridViewTextBoxColumn";
            // 
            // raporpathDataGridViewTextBoxColumn
            // 
            this.raporpathDataGridViewTextBoxColumn.DataPropertyName = "raporpath";
            this.raporpathDataGridViewTextBoxColumn.HeaderText = "Rapor URL";
            this.raporpathDataGridViewTextBoxColumn.Name = "raporpathDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // kacincisahipDataGridViewTextBoxColumn
            // 
            this.kacincisahipDataGridViewTextBoxColumn.DataPropertyName = "kacincisahip";
            this.kacincisahipDataGridViewTextBoxColumn.HeaderText = "Kaçıncı Sahip";
            this.kacincisahipDataGridViewTextBoxColumn.Name = "kacincisahipDataGridViewTextBoxColumn";
            // 
            // aracgoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tablgunc);
            this.Controls.Add(this.aracsil);
            this.Controls.Add(this.silkno);
            this.Controls.Add(this.label1);
            this.Name = "aracgoruntule";
            this.Text = "Araç Görüntüle & Sil";
            this.Load += new System.EventHandler(this.aracgoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buySellDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araceklevegoruntuleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tablgunc;
        private BuySellDBDataSetTableAdapters.araceklevegoruntuleTableAdapter araceklevegoruntuleTableAdapter;
        private BuySellDBDataSet buySellDBDataSet;
        private System.Windows.Forms.BindingSource araceklevegoruntuleBindingSource;
        public System.Windows.Forms.TextBox silkno;
        public System.Windows.Forms.Button aracsil;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arackimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruhsatnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasatipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorhacmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorgucuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cekisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakauyrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goruntupathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raporpathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kacincisahipDataGridViewTextBoxColumn;
    }
}