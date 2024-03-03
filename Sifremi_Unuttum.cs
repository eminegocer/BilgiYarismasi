using System;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proje_Login_Sayfasi
{
    public partial class Sifremi_Unuttum : Form
    {
        string randomCode;
        public static string to;
        public string kullaniciMail;

        public Sifremi_Unuttum()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Vt.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            string k_eposta = textBox1.Text;
            OleDbCommand komut = new OleDbCommand("SELECT COUNT(*) FROM kullaniciislemleri where e_posta=@ePosta", baglanti);
            komut.Parameters.AddWithValue("@ePosta", k_eposta);
            baglanti.Open();
            int KullaniciS = (int)komut.ExecuteScalar();
            baglanti.Close();

            if (KullaniciS > 0)
            {
                string from, pass, messageBody;
                Random rnd = new Random();
                randomCode = rnd.Next(100000, 999999).ToString();
                MailMessage message = new MailMessage();
                to = textBox1.Text;
                from = "goceremine496@gmail.com";
                pass = "vyzn pctu zerx lkez";
                messageBody = "Sıfırlama Kodunuz: " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Şifre Sıfırlama Kodu";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Kod Başarıyla Gönderildi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("E-posta adresi bulunamadı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == textBox2.Text)
            {
                to = textBox1.Text;
                Şifre_Yenileme sy = new Şifre_Yenileme();
                sy.EmailAl(to); // 'kullaniciMail' yerine 'to' kullanmalısınız
                this.Hide();
                sy.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kod");
            }
        }
    }
}
