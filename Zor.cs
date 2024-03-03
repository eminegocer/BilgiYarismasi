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
    public partial class Zor : Form
    {
        public Zor()
        {
            InitializeComponent();
        }
            Random rnd = new Random();
            int soruNo = 0;
            public static int dogru = 0;
            public static int yanlis = 0;
            static bool tiklama = false;

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Vt.accdb");

            private void Zor_Load(object sender, EventArgs e)
            {


                BtnBasla.Enabled = true;
                lblSoru.Text = soruNo.ToString();
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                panel1.Visible = false;
                label6.Visible = false;
        }


        private void BtnBasla_Click(object sender, EventArgs e)
        {

            baglan.Open();
            soruNo++;
            BtnBasla.Text = "Sonraki";
            lblSoru.Text = soruNo.ToString();
            BtnBasla.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnA.Visible = true;
            BtnB.Visible = true;
            BtnC.Visible = true;
            BtnD.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            panel1.Visible = true;
            label6.Visible = true;
            BtnA.BackColor = default;
            BtnB.BackColor = default;
            BtnC.BackColor = default;
            BtnD.BackColor = default;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            if (soruNo == 1)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM cografyazor1 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }


            }
            if (soruNo == 2)
            {

                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM cografyazor2 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 3)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM matematikzor1 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 4)
            {

                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM matematikzor2 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 5)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM sanatzor1 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 6)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM sanatzor2 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 7)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM sporzor1 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 8)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM sporzor2 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 9)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM tarihzor1 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }
            }
            if (soruNo == 10)
            {
                int randomId = rnd.Next(1, 4); // Rastgele bir ID oluştur

                OleDbCommand komut = new OleDbCommand("SELECT * FROM tarihzor2 WHERE Id = @randomId", baglan);
                komut.Parameters.AddWithValue("@randomId", randomId);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbl.Text = (oku["dogru"].ToString());

                }

            }
            if (soruNo == 11)
            {
                lblSoru.Text = "10";
                BtnBasla.Text = "Bitir";
                BtnBasla.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnA.Text = default;
                BtnB.Text = default;
                BtnC.Text = default;
                BtnD.Text = default;
                textBox1.Text = default;
                label4.Visible = false;
                label5.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;


            }
            if (soruNo == 12)
            {
                SonucZor sonuc = new SonucZor();
                sonuc.Show();
                this.Visible = false;
            }
            baglan.Close();
        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            if (BtnA.Text == lbl.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                BtnA.BackColor = Color.Green;
                label4.Visible = true;
                pictureBox1.Visible = true;
                BtnBasla.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
            else
            {

                if (tiklama == true)
                {
                    BtnA.Visible = false;
                    tiklama = false;

                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                    BtnA.BackColor = Color.Red;
                    label5.Visible = true;
                    pictureBox2.Visible = true;
                    BtnBasla.Enabled = true;
                    BtnA.Enabled = false;
                    BtnB.Enabled = false;
                    BtnC.Enabled = false;
                    BtnD.Enabled = false;
                    if (lbl.Text == BtnD.Text)
                    {
                        BtnD.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnB.Text)
                    {
                        BtnB.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnC.Text)
                    {
                        BtnC.BackColor = Color.Green;
                    }
                }
            }
            }

        private void BtnB_Click(object sender, EventArgs e)
        {

            if (BtnB.Text == lbl.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                BtnB.BackColor = Color.Green;
                label4.Visible = true;
                pictureBox1.Visible = true;
                BtnBasla.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
            else
            {
                if (tiklama == true)
                {
                    BtnB.Visible = false;
                    tiklama = false;
                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                    BtnB.BackColor = Color.Red;
                    label5.Visible = true;
                    pictureBox2.Visible = true;
                    BtnBasla.Enabled = true;
                    BtnA.Enabled = false;
                    BtnB.Enabled = false;
                    BtnC.Enabled = false;
                    BtnD.Enabled = false;
                    if (lbl.Text == BtnA.Text)
                    {
                        BtnA.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnD.Text)
                    {
                        BtnD.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnC.Text)
                    {
                        BtnC.BackColor = Color.Green;
                    }
                }
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {

            if (BtnC.Text == lbl.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                BtnC.BackColor = Color.Green;
                label4.Visible = true;
                pictureBox1.Visible = true;
                BtnBasla.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
            else
            {
                if (tiklama == true)
                {
                    BtnC.Visible = false;
                    tiklama = false;
                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                    BtnC.BackColor = Color.Red;
                    label5.Visible = true;
                    pictureBox2.Visible = true;
                    BtnBasla.Enabled = true;
                    BtnA.Enabled = false;
                    BtnB.Enabled = false;
                    BtnC.Enabled = false;
                    BtnD.Enabled = false;
                    if (lbl.Text == BtnA.Text)
                    {
                        BtnA.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnB.Text)
                    {
                        BtnB.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnD.Text)
                    {
                        BtnD.BackColor = Color.Green;
                    }
                }
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {

            if (BtnD.Text == lbl.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                BtnD.BackColor = Color.Green;
                label4.Visible = true;
                pictureBox1.Visible = true;
                BtnBasla.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
            else
            {
                if (tiklama == true)
                {
                    BtnD.Visible = false;
                    tiklama = false;
                }
                else
                {
                    yanlis++;
                    lblYanlis.Text = yanlis.ToString();
                    BtnD.BackColor = Color.Red;
                    label5.Visible = true;
                    pictureBox2.Visible = true;
                    BtnBasla.Enabled = true;
                    BtnA.Enabled = false;
                    BtnB.Enabled = false;
                    BtnC.Enabled = false;
                    BtnD.Enabled = false;
                    if (lbl.Text == BtnA.Text)
                    {
                        BtnA.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnB.Text)
                    {
                        BtnB.BackColor = Color.Green;
                    }
                    if (lbl.Text == BtnC.Text)
                    {
                        BtnC.BackColor = Color.Green;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tiklama = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            if (BtnA.Text == lbl.Text)
            {
                BtnB.Visible = false;
                BtnD.Visible = false;
            }
            if (BtnB.Text == lbl.Text)
            {
                BtnA.Visible = false;
                BtnC.Visible = false;
            }
            if (BtnC.Text == lbl.Text)
            {
                BtnB.Visible = false;
                BtnA.Visible = false;
            }
            if (BtnD.Text == lbl.Text)
            {
                BtnB.Visible = false;
                BtnC.Visible = false;
            }
            
        }
    }
    }

