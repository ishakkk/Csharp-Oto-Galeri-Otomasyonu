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
    public partial class arcekle : Form
    {
        public arcekle()
        {
            InitializeComponent();
        }
        int resimindex = 0;
        public static String temsilci;
        string pictpath,docpath;

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
                temsilci = tetadsoyad.Text;
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into temsilciliste (AdSoyad) values ('" + tetadsoyad.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Temsilci Veri Tabanına Eklendi !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tetadsoyad.Text = "";
            }
            catch
            {
                MessageBox.Show("Temsilci Veri Tabanına Eklenemedi !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void fekle_Click(object sender, EventArgs e)//fotekle
        {
            OpenFileDialog dosya_sec = new OpenFileDialog();
            dosya_sec.Filter = "Resim Dosyası |*.jpg| Resim Dosyası|*.png;";
            dosya_sec.FilterIndex = 2;//masaustune yönlendirecek
            DialogResult sonuc = dosya_sec.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ımageList1.Images.Add(Image.FromFile(dosya_sec.FileName));
                Image secilenResim = Image.FromFile(dosya_sec.FileName);
                ımageList1.Images.Add(secilenResim);
                
                pictpath = dosya_sec.FileName;
                rsmpth.Text = pictpath;
            }
        }

        private void raporekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Rapor Dosyası |*.pdf";//elektronik imza icin yalnizca pdf
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Rapor Dosyası Seçiniz..";
            file.Multiselect = true;
            file.FilterIndex = 2;//masaustune yönlendirecek

            if (file.ShowDialog() == DialogResult.OK)
            {
                docpath = file.FileName;
                string DosyaAdi = file.SafeFileName;
                rprpth.Text=docpath;
            }

        }

        private void resimgoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = rsmpth.Text;
            }
            catch
            {
                MessageBox.Show("Araca Ait Herhangi Bir Fotoğraf Bulunmamaktadır ! \n Not : Araç Fotoğrafı Eklemek İçin Fotoğraf Ekle Butonuna Basınız...","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void aracekle_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
                cmd = new OleDbCommand();
                con.Open();
                da = new OleDbDataAdapter("Select *From araceklecegoruntule", con);
                cmd.Connection = con;
                cmd.CommandText = "insert into araceklevegoruntule (ruhsatno,marka,seri,model,yil,yakit,vites,km,kasatipi,motorhacmi,motorgucu,cekis,renk,garanti,plakauyruk,plakano,kimden,takas,durumu,goruntupath,raporpath,fiyat,kacincisahip) values ('" + ruhno.Text + "','" + marka.Text + "','" + seri.Text + "','" + model.Text + "','" + yil.Text + "','" + cmbyakit.Text + "','" + cmbvites.Text + "','" + km.Text + "','" + kasatipi.Text + "','" + mhacim.Text + "','" + mguc.Text + "','" + cmbcekis.Text + "','" + renk.Text + "','" + cmbgaranti.Text + "','" + cmbuyruk.Text + "','" + plakano.Text + "','" + cmbkimden.Text + "','" + cmbtakas.Text + "','" + cmbdurum.Text + "','" + rsmpth.Text + "','" + rprpth.Text + "','" + fiyat.Text + "','" +kcncshp.Text +"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Aracınız Veri Tabanına Eklendi !","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                pictureBox1.ImageLocation = "";
            }
            catch 
            {
                MessageBox.Show("Aracınız Veri Tabanına Eklenemedi !","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void goruntulearac_Click(object sender, EventArgs e)
        {
            aracgoruntule goruntule = new aracgoruntule();
            goruntule.Show();
            this.Hide();
            MessageBox.Show("Tabloda Aracın Üzerine Çift Tıklayarak Bilgileri Bir Önceki Ekrana(Araç Ekleme & Güncelleme Ve Temsilci Ekleme) Ekranına Getirebilirsiniz.", "Bilgilendirme !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aracgunc_Click(object sender, EventArgs e)
        {
            try
            {
                if (gncid.Text == "")
                {
                    MessageBox.Show("Lütfen Aracın ID'sini Giriniz! \nNot : Güncellemek istediğiniz araç için araçları görüntüle butonuna basınız !","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update araceklevegoruntule set ruhsatno='" + ruhno.Text + "', marka='" + marka.Text + "', seri='" + seri.Text + "', model='" + model.Text + "', yil='" + yil.Text + "', yakit='" + cmbyakit.Text + "', vites='" + cmbvites.Text + "', km='" + km.Text + "', kasatipi='" + kasatipi.Text + "', motorhacmi='" + mhacim.Text + "', motorgucu='" + mguc.Text + "', cekis='" + cmbcekis.Text + "', renk='" + renk.Text + "', garanti='" + cmbgaranti.Text + "', plakauyruk='" + cmbuyruk.Text + "', plakano='" + plakano.Text + "', kimden='" + cmbkimden.Text + "', takas='" + cmbtakas.Text + "', durumu='" + cmbdurum + "', goruntupath='" + rsmpth.Text + "', raporpath='" + rprpth.Text + "', fiyat='" + fiyat.Text + "', kacincisahip='" + kcncshp.Text + "' where arackimlik=" + gncid.Text + "";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Aracınız Veri Tabanına Eklendi !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    gncid.Clear();
                    pictureBox1.ImageLocation = "";
                }
            }
            catch
            {
                MessageBox.Show("Aracınız Güncellenemedi !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resimsil_Click(object sender, EventArgs e)
        {
            rsmpth.Clear();
            pictureBox1.ImageLocation = "";
        }
    }
}
