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
    public partial class tmslcekrn : Form
    {
        public tmslcekrn()
        {
            InitializeComponent();
        }

        private void satisgir_Click(object sender, EventArgs e)
        {
            satisekr satis = new satisekr();
            satis.Show();
        }

        private void aracgor_Click(object sender, EventArgs e)
        {
            aracgoruntule gorntule = new aracgoruntule();
            gorntule.Show();
            gorntule.silkno.Enabled = false;
            gorntule.aracsil.Enabled = false;
        }

        private void cikisyap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
