using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Login_Sayfasi
{
    public partial class SonucKolay : Form
    {
        public SonucKolay()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDogru_Click(object sender, EventArgs e)
        {
            

        }

        private void SonucKolay_Load(object sender, EventArgs e)
        {
            lblDogru.Text = Kolay.dogru.ToString();
            lblYanlis.Text = Kolay.yanlis.ToString();
            lblPuan.Text = (Kolay.dogru * 3).ToString();
        }

        private void lblPuan_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
