using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Banka_Otomasyonu
{
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEski.Text == "" || txtYeni.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları giriniz !", "şifre değiştirme İşlemi");
            }
            else if (txtYeni.Text.Length < 5)
            {
                MessageBox.Show("En az 5 karakter uzunluğunda şifre giriniz !", "şifre değiştirme İşlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set sifre = @p1 where sifre = @p2", con);

                komut.Parameters.AddWithValue("@p1", txtYeni.Text);
                komut.Parameters.AddWithValue("@p2", txtEski.Text);

                con.Open();
                int sonuc = komut.ExecuteNonQuery();





                if (sonuc == 1)
                {
                    MessageBox.Show("şifre değiştirme işlemi yapıldı ", "Şifre Değiştirme İşlemi Tamam", MessageBoxButtons.OK);
                    HareketKaydet.kaydet(Form1.mID, "Şifre Değiştirlidi.");
                }
                else
                {
                    MessageBox.Show("Şifre Değiştirme İşlemi Yapılamadı !", "Para Çekme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

                con.Close();
                txtEski.Text = "";
                txtYeni.Text = "";
            }
        }
    }
}
