﻿using System;
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
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {
            

            float sayi = float.Parse(maskedTextBox1.Text);
            if(sayi > Form1.mBakiye) {
                MessageBox.Show("Yetersiz Bakiye","Para Çekme İşlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye -= @p1, where Id = @p2", con);
                
                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.mID);

                con.Open();
                int sonuc = komut.ExecuteNonQuery();





                if (sonuc == 1)
                {
                    MessageBox.Show("Para Çekme İşlemi Yapıldı ", "Para Çekme İşlemi Tamam", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Para Çekme İşlemi Yapılamadı !", "Para Çekme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    
                }

                con.Close();
                maskedTextBox1.Text = "";
            }
        }
    }
}
