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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");
        public static string adSoyad = "";
        public static int mID;
        public static float mBakiye = 0.0f;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text;
            string parola = textBox2.Text;
            bool sonuc = false;

            if (radioButton1.Checked)
            {
                if (kAdi == "admin" && parola == "123")
                {
                    Yetkili_i�lem yi = new Yetkili_i�lem();
                    yi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatal� Kullan�c� Ad�/TC veya Parola !", "Hatal� Giri� Denemesi");
                }
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("select * from musteriler where tcNo = @p1 and sifre = @p2 and durum = 1", con);
                komut.Parameters.AddWithValue("@p1", kAdi);
                komut.Parameters.AddWithValue("@p2", parola);


                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    adSoyad = dr["adSoyad"].ToString();
                    mID = int.Parse(dr["ID"].ToString());
                    mBakiye = float.Parse(dr["bakiye"].ToString());
                    sonuc = true;
                }
                con.Close();

                if (sonuc)
                {
                    sonuc = false;
                    M�steriislem mi = new M�steriislem();
                    mi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giri� de�erlerinizi kontrol ediniz veya banka �ubenizle g�r���n�z !", "Hatal� Giri� Denemesi");
                }

            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUret su = new SifreUret(); 
            su.Show();  
        }
    }
}