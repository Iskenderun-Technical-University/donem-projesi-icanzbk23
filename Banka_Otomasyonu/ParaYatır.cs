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
    public partial class ParaYatır : Form
    {
        public ParaYatır()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(maskedTextBox1.Text);
            if (int.Parse(maskedTextBox1.Text) <= 10)
            {
                MessageBox.Show("Lütfen en az 10TL yatırınız", "Para Yatırma İşlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye += @p1, where Id = @p2", con);

                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.mID);

                con.Open();
                int sonuc = komut.ExecuteNonQuery();





                if (sonuc == 1)
                {
                    MessageBox.Show("Para Yatırma İşlemi Yapıldı ", "Para Yatırma İşlemi Tamam", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Para Yatırma İşlemi Yapılamadı !", "Para Yatırma İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

                con.Close();
                maskedTextBox1.Text = "";
            }
        }
    }
}
