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
    public partial class calisanliste : Form
    {
        public calisanliste()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        

        private void calisanliste_Load(object sender, EventArgs e)
        {
            griddoldur();
            // TODO: This line of code loads data into the 'buySellDBDataSet.temsilciliste' table. You can move, or remove it, as needed.
            this.temsilcilisteTableAdapter.Fill(this.buySellDBDataSet.temsilciliste);

        }

        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
            da = new OleDbDataAdapter("Select *from temsilciliste", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "temsilciliste");
            dataGridView1.DataSource = ds.Tables["temsilciliste"];
            con.Close();
        }

        private void ciktems_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from temsilciliste where ID=" + siltid.Text + "";
                cmd.ExecuteNonQuery();
                con.Close();
                siltid.Clear();
                griddoldur();
            }
            catch
            {
                MessageBox.Show("Temsilci Veri Tabandan Çıkarılamadı !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }

        
    }