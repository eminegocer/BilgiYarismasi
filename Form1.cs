using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje_Login_Sayfasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Vt.accdb");
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from kullaniciislemleri where kad = '" + textBox1.Text + "'and sifre= '" + textBox2.Text + "'", baglanti);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SeviyeSecimi frm = new SeviyeSecimi();
                frm.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hata");
            }

            try
            {
                OleDbCommand sorgu = new OleDbCommand("select kad,sifre from kullaniciislemleri where kad=@ad and sifre=@sifre", baglanti);
                baglanti.Open();
                sorgu.Parameters.AddWithValue("ad", textBox1.Text.Trim());
                sorgu.Parameters.AddWithValue("sifre", textBox2.Text.Trim());
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();

                if (dr.Read())
                {
                    
                }
                else
                {
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış. Lütfen Tekrar Deneyiniz");
                }

            }
            catch
            {
                MessageBox.Show(" Lütfen Kullanıcı Adı Veya Şifrenizle Giriş Yapın");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Sifremi_Unuttum frm = new Sifremi_Unuttum();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yeni_Hesap_Ekleme frm = new Yeni_Hesap_Ekleme();
            frm.Show();
            this.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
