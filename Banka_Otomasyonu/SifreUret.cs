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
    public partial class SifreUret : Form
    {
        public SifreUret()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "" || txtTelefon.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları giriniz !", "şifre oluşturma İşlemi");
            }
            else if (txtSifre.Text.Length < 5)
            {
                MessageBox.Show("En az 5 karakter uzunluğunda şifre giriniz !", "şifre oluşturma İşlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set sifre = @p1 where tcNo = @p2 and telefon =@p3 ", con);

                komut.Parameters.AddWithValue("@p1", txtSifre.Text);
                komut.Parameters.AddWithValue("@p2", txtTc.Text);
                komut.Parameters.AddWithValue("@p3", txtTelefon.Text);


                con.Open();
                int sonuc = komut.ExecuteNonQuery();





                if (sonuc == 1)
                {
                    MessageBox.Show("şifre oluşturma işlemi yapıldı ", "Şifre Değiştirme İşlemi Tamam", MessageBoxButtons.OK);
                   // HareketKaydet.kaydet(Form1.mID, "Şifre Oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Şifre oluşturma İşlemi Yapılamadı !", "Şifre Değiştirme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

                con.Close();
                txtSifre.Text = "";
                txtTc.Text = "";
                txtTelefon.Text = "";

            }
        }
    }
}
