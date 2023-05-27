using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Banka_Otomasyonu
{
    internal class HareketKaydet
    {
        public static void kaydet(int mId, string msj)
        {
            SqlConnection con = new SqlConnection("server = DESKTOP-OVD1DH3\\SQLEXPRESS ; initial catalog = Bankamatik; integrated security = sspi");
            SqlCommand komut = new SqlCommand("insert into Hareketler (musteriID, islem, tarih) values (@p1, @p2, @p3)", con);
            komut.Parameters.AddWithValue("@p1",mId);
            komut.Parameters.AddWithValue("@p2", msj);
            komut.Parameters.AddWithValue("@p3", DateTime.Now);

            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }

    }
}
