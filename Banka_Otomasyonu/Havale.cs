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
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(txtMiktar.Text);
           /* int aliciNo = int.Parse(txtNo.Text);

            SqlCommand komut = new SqlCommand("select * from musteriler where Id = @p1", con);
            komut.Parameters.AddWithValue("@p1", txtNo.Text);
            bool sonuc = false;
            
            con.Open();
            SqlDataReader dr = komut.ExecuteReader();


            */

/*
            if (dr.Read())
            {
                sonuc = true;
                con.Close();
            }
            else if( !sonuc)
            {


                MessageBox.Show("Alıcı Hesap No Hatalı !","Havala/EFT işlemi");
                con.Close();
            }

            */

             if (sayi > Form1.mBakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Para Çekme İşlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye = bakiye - @p1 where Id = @p2", con);
               

                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.mID);
                

                SqlCommand komut2 = new SqlCommand("update musteriler set bakiye = bakiye + @p3 where Id = @p4", con);
                komut2.Parameters.AddWithValue("@p3", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p4", txtNo.Text);


                /* con.Open();
                 komut2.ExecuteNonQuery();
                 komut3.ExecuteNonQuery();*/


                /*  MessageBox.Show("Havale/EFT İşlemi Yapıldı ", "Havale/EFT İşlemi Tamam", MessageBoxButtons.OK);
                      Form1.mBakiye -= sayi;


                  sonuc = false;
                  con.Close();
                  txtNo.Text = "";
                  txtMiktar.Text = "";*/

                if (sayi < 10)
                {
                    MessageBox.Show("Lütfen 10 TL ve üstü bir değer giriniz ", "Eksik kayıt hatası",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();
                    int sonuc1 = komut2.ExecuteNonQuery();
                    con.Close();
                    if (sonuc1 == 1)
                    {
                        con.Open();
                        komut.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Havale İşlemi Gerçekleştirildi","Havale/EFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1.mBakiye -= sayi;
                    }
                    else
                    {
                        MessageBox.Show("Alıcı hesap no hatalı !", "Havale/EFT Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                txtMiktar.Text = "";
                txtNo.Text = "";
                
                
            }
        }
    }
}
