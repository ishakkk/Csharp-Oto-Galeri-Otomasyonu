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
    public partial class sistgiris : Form
    {
        public sistgiris()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        int sayac = 3;
        /*public static String patron_sifre="01";
        public static String temsilci_sifre="33";*/
        public static String kadi_patron = "patron";
        public static String kadi_temsilci = "temsilci";

        private void giris_Click(object sender, EventArgs e)
        {
            String kadi_girilen;
            String girilen_sifre;
            girilen_sifre = sifre.Text;
            kadi_girilen = kadi.Text;

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|BuySellDB.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanicigirisi where kullaniciadi='" + kadi.Text + "' AND Sifre='" + sifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (giristuru.SelectedItem == "Patron")
                {
                    yoneticiekrani yntc = new yoneticiekrani();
                    yntc.Show();
                    this.Hide();
                }
                else if (giristuru.SelectedItem == "Müşteri Temsilcisi")
                {
                    tmslcekrn tmslc = new tmslcekrn();
                    tmslc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen Giriş Türü Alanından Bir Değer Seçiniz !");
                }
            }
            else
            {
                sayac--;
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI KALAN HAKKINIZ " + sayac);
                if (sayac == 0)
                {
                    MessageBox.Show("Sistem kilitlendi ! ");
                    sifre.Enabled = false;
                    kadi.Enabled = false;
                    giris.Enabled = false;
                }
            }

            con.Close();
        }

        private void degistir_Click(object sender, EventArgs e)
        {
            sifredegis sifre = new sifredegis();
            sifre.Show();
            this.Hide(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
