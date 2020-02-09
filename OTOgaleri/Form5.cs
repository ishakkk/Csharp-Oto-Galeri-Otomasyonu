using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OTOgaleri
{
    public partial class aracgoruntule : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        public aracgoruntule()
        {
            InitializeComponent();
        }

        private void aracgoruntule_Load(object sender, EventArgs e)
        {
            griddoldur();
            // TODO: This line of code loads data into the 'buySellDBDataSet.araceklevegoruntule' table. You can move, or remove it, as needed.
            this.araceklevegoruntuleTableAdapter.Fill(this.buySellDBDataSet.araceklevegoruntule);
        }
        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
            da = new OleDbDataAdapter("Select *from araceklevegoruntule", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "araceklevegoruntule");
            dataGridView1.DataSource = ds.Tables["araceklevegoruntule"];
            con.Close();
        }

        private void tablgunc_Click(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void aracsil_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from araceklevegoruntule where arackimlik=" + silkno.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            arcekle ekle = new arcekle();
            ekle.gncid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ekle.ruhno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ekle.marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ekle.seri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ekle.model.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ekle.yil.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ekle.cmbyakit.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            ekle.cmbvites.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ekle.km.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ekle.kasatipi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ekle.mhacim.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            ekle.mguc.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            ekle.cmbcekis.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            ekle.renk.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            ekle.cmbgaranti.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            ekle.cmbuyruk.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            ekle.plakano.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            ekle.cmbkimden.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            ekle.cmbtakas.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            ekle.cmbdurum.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            ekle.rsmpth.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            ekle.rprpth.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            ekle.fiyat.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            ekle.kcncshp.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            ekle.Show();
            this.Hide();
        }
    }
}
