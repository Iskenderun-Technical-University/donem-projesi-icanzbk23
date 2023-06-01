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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");
        private void button1_Click(object sender, EventArgs e)
        {
            
           
                SqlCommand komut = new SqlCommand("select * from musteriler where Id = @p1 or tcNo=@p2", con);
                komut.Parameters.AddWithValue("@p1", txtAra.Text);
                komut.Parameters.AddWithValue("@p2", txtAra.Text);
                con.Open();
                SqlDataReader dr = komut.ExecuteReader();





                if (dr.Read())
                {
                    txtId.Text = dr["Id"].ToString();
                    txtTcNo.Text = dr["tcNo"].ToString();
                    txtAdSoyad.Text = dr["adSoyad"].ToString();
                    txtAdres.Text = dr["adres"].ToString();
                    txtTel.Text = dr["telefon"].ToString();
                    txtBakiye.Text = dr["bakiye"].ToString();
                }
                else
                {
                    MessageBox.Show("TC NO/ ID  Değerini Giriniz!", "Arama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Text = "";
                    txtTcNo.Text = "";
                    txtAdSoyad.Text = "";
                    txtAdres.Text = "";
                    txtTel.Text = "";
                    txtBakiye.Text = "";
                    txtId.Text = "";
                }

                con.Close();
            }
        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("update musteriler set durum = @p1 where Id = @p2 or tcNo=@p3",con);
            komut.Parameters.AddWithValue("@p1", 0);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);
            komut.Parameters.AddWithValue("@p3", txtAra.Text);
            

            

           DialogResult dr = MessageBox.Show("Müşteri Kaydını Silmek İstediğinizden Emin misiniz ? ", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi !", "Silme İşlemi İptali");

            }
            else {
                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Silme İşlemi Yapıldı ", "Silme İşlemi Tamam", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    
                    MessageBox.Show("Silme İşlemi Yapılamadı !", "Silme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                }
                con.Close();
                txtId.Text = "";
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTel.Text = "";
                txtBakiye.Text = "";
                txtId.Text = "";

            }

        }
    }
}
