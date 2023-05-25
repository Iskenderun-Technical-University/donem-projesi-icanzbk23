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
    public partial class Musteriguncelle : Form
    {
        public Musteriguncelle()
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

            SqlCommand komut = new SqlCommand("update musteriler set adSoyad=@p1, adres=@p2, telefon=@p3 where Id = @p4 or tcNo=@p5", con);
            komut.Parameters.AddWithValue("@p4", txtAra.Text);
            komut.Parameters.AddWithValue("@p5", txtAra.Text);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtAdres.Text);
            komut.Parameters.AddWithValue("@p3", txtTel.Text);

            con.Open();
            int sonuc = komut.ExecuteNonQuery();





            if (sonuc == 1)
            {
                MessageBox.Show("Güncelleme Yapıldı ", "Güncelleme Tamam", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Güncelleme Yapılamadı !", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txtBakiye_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

