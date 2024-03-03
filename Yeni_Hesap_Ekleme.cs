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
    public partial class Yeni_Hesap_Ekleme : Form
    {
        public Yeni_Hesap_Ekleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Vt.accdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("insert into kullaniciislemleri(kad,sifre,e_posta) values(@kad,@sifre,@e_posta)",baglanti);
            komut.Parameters.AddWithValue("@kad",textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            komut.Parameters.AddWithValue("@e_posta", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Başarılı");
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
