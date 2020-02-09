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
    public partial class satilmisaraclar : Form
    {
        public satilmisaraclar()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        private void satilmisaraclar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buySellDBDataSet.satilanaraclar' table. You can move, or remove it, as needed.
            this.satilanaraclarTableAdapter.Fill(this.buySellDBDataSet.satilanaraclar);
            griddoldur();

        }
        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
            da = new OleDbDataAdapter("Select *from satilanaraclar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "satilanaraclar");
            dataGridView1.DataSource = ds.Tables["satilanaraclar"];
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
            cmd.CommandText = "delete from satilanaraclar where arackimlik=" + silkno.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
    }
}
