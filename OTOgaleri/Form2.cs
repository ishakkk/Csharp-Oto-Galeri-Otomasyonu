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
    public partial class satisekr : Form
    {
        public satisekr()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void sat_Click(object sender, EventArgs e)
        {
            try
            {
                arcekle ekle = new arcekle();
                if (stcid.Text == "")
                {
                    MessageBox.Show("Lütfen Aracın ID'sini Giriniz! \nNot : Aracın ID'sini Araçları Listele Kısmından Öğrenebilirsiniz !");
                }
                else
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    da = new OleDbDataAdapter("Select *From satilanaraclar", con);
                    cmd.Connection = con;
                    cmd.CommandText = "insert into satilanaraclar (ruhsatno,marka,seri,model,yil,yakit,vites,km,kasatipi,motorhacmi,motorgucu,cekis,renk,garanti,plakauyruk,plakano,kimden,takas,durumu,satistarihi,satansahis,mustis,mustsoyis,musttc,musttel,mustadr,goruntupath,raporpath,fiyat,kacincisahip) values ('" + ruhno.Text + "','" + marka.Text + "','" + seri.Text + "','" + model.Text + "','" + yil.Text + "','" + cmbyakit.Text + "','" + cmbvites.Text + "','" + km.Text + "','" + kasatipi.Text + "','" + mhacim.Text + "','" + mguc.Text + "','" + cmbcekis.Text + "','" + renk.Text + "','" + cmbgaranti.Text + "','" + cmbuyruk.Text + "','" + plakano.Text + "','" + cmbkimden.Text + "','" + cmbtakas.Text + "','" + cmbdurum.Text + "','" + tarih.Text + "','" + stnshs.Text + "','" + muisim.Text + "','" + musoyisim.Text + "','" + mutc.Text + "','" + mutel.Text + "','" + muadr.Text + "','" + rsmpth.Text + "','" + rprpth.Text + "','" + fiyat.Text + "','" + kcncshp.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "delete from araceklevegoruntule where arackimlik=" + stcid.Text + "";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Aracınız Satış Veri Tabanına Eklendi !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ruhno.Clear();
                    marka.Clear();
                    seri.Clear();
                    model.Clear();
                    yil.Clear();
                    cmbyakit.SelectedIndex = 0;
                    cmbvites.SelectedIndex = 0;
                    km.Clear();
                    kasatipi.Clear();
                    mhacim.Clear();
                    mguc.Clear();
                    cmbcekis.SelectedIndex = 0;
                    renk.Clear();
                    cmbgaranti.SelectedIndex = 0;
                    cmbuyruk.SelectedIndex = 0;
                    plakano.Clear();
                    cmbkimden.SelectedIndex = 0;
                    cmbtakas.SelectedIndex = 0;
                    cmbdurum.SelectedIndex = 0;
                    kcncshp.Clear();
                    rsmpth.Clear();
                    rprpth.Clear();
                    fiyat.Clear();
                    muisim.Clear();
                    musoyisim.Clear();
                    mutc.Clear();
                    mutel.Clear();
                    muadr.Clear();
                    stcid.Clear();
                    stnshs.Clear();
                }
            }
        
        catch
        {
            MessageBox.Show("Aracınız Satış Veri Tabanına Eklenemedi !","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
      }

        private void araclistele_Click(object sender, EventArgs e)
        {
            maraclist arlist = new maraclist();
            arlist.Show();
            this.Hide();
            MessageBox.Show("Tabloda Aracın Üzerine Çift Tıklayarak Bilgileri Satış Ekranına Getirebilirsiniz.", "Bilgilendirme !",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
