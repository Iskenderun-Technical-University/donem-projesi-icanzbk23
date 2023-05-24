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
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }

        private void MusteriAra_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
