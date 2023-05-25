using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    public partial class Yetkili_işlem : Form
    {
        public Yetkili_işlem()
        {
            InitializeComponent();
        }

        private void Yetkili_işlem_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle();
            me.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusteriAra ma = new MusteriAra();
            ma.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteriguncelle mg = new Musteriguncelle();
            mg.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriSil ms = new MusteriSil();
            ms.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListeleme ml = new MusteriListeleme();   
            ml.Show();
        }
    }
}
