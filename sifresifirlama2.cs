using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Login_Sayfasi
{
    internal class sifresifirlama2
    {
        OleDbConnection baglanti;
        OleDbCommand komut;

        public void sifreSıfırlama(String kullaniciMail, string yeniParola)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Vt.accdb");
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kullaniciislemleri SET sifre =@NewPassword WHERE e_posta =@kullaniciEmail", baglanti);
                komut.Parameters.AddWithValue("@NewPassword", yeniParola);
                komut.Parameters.AddWithValue("@kullaniciEmail", kullaniciMail);
                int satır = komut.ExecuteNonQuery();
                if (satır > 0)
                {
                    MessageBox.Show("Şifre Güncellendi");

                }
                else
                {
                    MessageBox.Show("Şifre Güncelleme Yapılamadı");
                }

                baglanti.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Şifre Oluşturma Hatası",ex.Message);
            }
        }
    }
}
