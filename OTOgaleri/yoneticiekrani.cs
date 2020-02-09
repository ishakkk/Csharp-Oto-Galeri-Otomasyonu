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
    public partial class yoneticiekrani : Form
    {
        public yoneticiekrani()
        {
            InitializeComponent();
        }

        private void arcgoruntule_Click(object sender, EventArgs e)
        {
            aracgoruntule goruntule = new aracgoruntule();
            goruntule.Show();
        }

        private void satisgir_Click(object sender, EventArgs e)
        {
            satisekr satis = new satisekr();
            satis.Show();
        }

        private void tmsleklcik_Click(object sender, EventArgs e)
        {
            arcekle aracekle = new arcekle();
            aracekle.Show();
        }

        private void arcgoruntule_Click_1(object sender, EventArgs e)
        {
            aracgoruntule goruntule = new aracgoruntule();
            goruntule.Show();
        }

        private void arceklcik_Click(object sender, EventArgs e)
        {
            arcekle aracekle = new arcekle();
            aracekle.Show();
        }

        private void stlnarac_Click(object sender, EventArgs e)
        {
            satilmisaraclar sarac = new satilmisaraclar();
            sarac.Show();
        }

        private void cikisyap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calisanliste list = new calisanliste();
            list.Show();
        }

    }
}
