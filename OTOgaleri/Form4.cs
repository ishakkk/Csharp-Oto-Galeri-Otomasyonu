using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;


namespace OTOgaleri
{
    public partial class sifredegis : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        public sifredegis()
        {
            InitializeComponent();
        }
        int sayacp=3,rsayi;

        private void Form4_Load(object sender, EventArgs e)
        {
            yst.Enabled = false;
            ystt.Enabled = false;
            aktkodp.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = false;
            button9.Enabled = false;
            ysp.Enabled = false;
            ystp.Enabled = false;
            button1.Enabled = false;
            button8.Enabled = false;
            aktkodt.Enabled = false;
            button4.Enabled = false;
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (epostap.Text == "")
            {
                MessageBox.Show("Lütfen E-posta adresinizi giriniz !");
            }
            else
            {
                Random r = new Random();
                rsayi = r.Next(0, 100000);
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("buysell0005@gmail.com");
                ePosta.To.Add(epostap.Text.ToString());
                ePosta.Subject = "Buy&Sell Güvenlik Aktivasyon Kodu";
                ePosta.Body = ("Aktivasyon Kodunuz : " + rsayi);
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("buysell0005@gmail.com", "12345678bs");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                object userState = ePosta;
                bool kontrol = true;
                try
                {
                    MessageBox.Show("Aktivasyon Kodunuz Gönderildi Lütfen E-postanızı Kontrol Edin.");
                    smtp.SendAsync(ePosta, (object)ePosta);
                    aktkodp.Enabled = true;
                    button5.Enabled = true;
                }
                catch (SmtpException ex)
                {
                    kontrol = false;
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatası! \nLutfen Üretici Firmaya Başvurun !");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//patronsifredegistir
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuySellDB.accdb");
            if (ysp.Text == ystp.Text && ysp.Text != "" && ystp.Text != "")
            {
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update kullanicigirisi set kullaniciadi='" + sistgiris.kadi_patron +"',Sifre='" + ystp.Text + "' where kullaniciadi='" + sistgiris.kadi_patron + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz Başarı İle Değiştirildi !");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Şifreniz Değiştirilemedi! \nLütfen Tekrar Deneyin !");
                    con.Close();
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rsayi.ToString() == aktkodp.Text)
            {
                ysp.Enabled = true;
                ystp.Enabled = true;
                button1.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                sayacp--;
                MessageBox.Show("YANLIŞ AKTİVASYON KODU ! \n KALAN HAKKINIZ " + sayacp);
                if (sayacp == 0)
                {
                    MessageBox.Show("Hakkınız Bitti...");
                    Application.Exit();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sistgiris frm = new sistgiris();
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sistgiris frm = new sistgiris();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (epostat.Text == "")
            {
                MessageBox.Show("Lütfen E-posta adresinizi giriniz !");
            }
            else
            {
                Random r = new Random();
                rsayi = r.Next(0, 100000);
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("buysell0005@gmail.com");

                ePosta.To.Add(epostat.Text.ToString());
                ePosta.Subject = "Buy&Sell Güvenlik Aktivasyon Kodu";
                ePosta.Body = ("Aktivasyon Kodunuz : " + rsayi);
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("buysell0005@gmail.com", "12345678bs");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                object userState = ePosta;
                bool kontrol = true;
                try
                {
                    MessageBox.Show("Aktivasyon Kodunuz Gönderildi Lütfen E-postanızı Kontrol Edin.");
                    smtp.SendAsync(ePosta, (object)ePosta);
                    aktkodt.Enabled = true;
                    button4.Enabled = true;
                }
                catch (SmtpException ex)
                {
                    kontrol = false;
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatası! \nLutfen Üretici Firmaya Başvurun !");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rsayi.ToString() == aktkodt.Text)
            {
                yst.Enabled = true;
                ystt.Enabled = true;
                button2.Enabled = true;
                button9.Enabled = true;
            }
            else
            {
                sayacp--;
                MessageBox.Show("YANLIŞ AKTİVASYON KODU ! \n KALAN HAKKINIZ " + sayacp);
                if (sayacp == 0)
                {
                    MessageBox.Show("Hakkınız Bitti...");
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//temsilcisifredegistir
        {
            if (yst.Text == ystt.Text && yst.Text != "" && ystt.Text != "")
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update kullanicigirisi set kullaniciadi='" + sistgiris.kadi_temsilci + "',Sifre='" + ystt.Text + "' where kullaniciadi='" + sistgiris.kadi_temsilci + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifreniz başarı ile değiştirildi.");
                con.Close();
            }
            else
            {
                MessageBox.Show("Şifreniz Değiştirilemedi! \nLütfen Tekrar Deneyin !");
                con.Close();
            }
        }
    }
}