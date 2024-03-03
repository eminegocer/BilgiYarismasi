using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proje_Login_Sayfasi
{
    public partial class Şifre_Yenileme : Form
    {
        string kad = Sifremi_Unuttum.to;
        public String email;
        

        public Şifre_Yenileme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                sifresifirlama2 sf = new sifresifirlama2();
                sf.sifreSıfırlama(email, textBox1.Text);

            }
            else
            {
                MessageBox.Show("Şifreler Birbiriyle Uyuşmuyor");
            }
        }
        public void EmailAl(String Email) 
        {
            Sifremi_Unuttum su1 = new Sifremi_Unuttum();
            email = Email;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
