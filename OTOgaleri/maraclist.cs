using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OTOgaleri
{
    public partial class maraclist : Form
    {
        public maraclist()
        {
            InitializeComponent();
        }

        private void maraclist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buySellDBDataSet.araceklevegoruntule' table. You can move, or remove it, as needed.
            this.araceklevegoruntuleTableAdapter.Fill(this.buySellDBDataSet.araceklevegoruntule);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            satisekr se = new satisekr();
            se.stcid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            se.ruhno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            se.marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            se.seri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            se.model.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            se.yil.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            se.cmbyakit.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            se.cmbvites.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            se.km.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            se.kasatipi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            se.mhacim.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            se.mguc.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            se.cmbcekis.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            se.renk.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            se.cmbgaranti.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            se.cmbuyruk.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            se.plakano.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            se.cmbkimden.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            se.cmbtakas.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            se.cmbdurum.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            se.rsmpth.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            se.rprpth.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            se.fiyat.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            se.kcncshp.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            se.Show();
        }
    }
}
