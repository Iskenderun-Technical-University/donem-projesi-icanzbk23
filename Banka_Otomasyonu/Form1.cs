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
                    Yetkili_iþlem yi = new Yetkili_iþlem();
                    yi.Show();
                    this.Hide();
                }
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("select * from musteriler where tcNo = @p1 and sifre = @p2", con);
                komut.Parameters.AddWithValue("@p1", kAdi);
                komut.Parameters.AddWithValue("@p2", parola);

                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    adSoyad = dr["adSoyad"].ToString();
                    mID = int.Parse(dr["ID"].ToString());
                    sonuc = true;
                }
                con.Close();

                if (sonuc)
                {
                    sonuc = false;
                    Müsteriislem mi = new Müsteriislem();
                    mi.Show();
                }
                else
                {
                    MessageBox.Show("Hatalý Kullanýcý Adý/TC veya Parola !", "Hatalý Giriþ Denemesi");
                }

            }

        }
    }
}