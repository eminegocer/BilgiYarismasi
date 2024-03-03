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
    public partial class SeviyeSecimi : Form
    {
        public SeviyeSecimi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrta_Click(object sender, EventArgs e)
        {
            Orta frm = new Orta();
            this.Hide();
            frm.Show();
        }

        private void BtnKolay_Click(object sender, EventArgs e)
        {
            Kolay frm = new Kolay();
            frm.Show();
            this.Visible = false;
        }

        private void BtnZor_Click(object sender, EventArgs e)
        {
            Zor frm = new Zor();
            
            frm.Show();
            this.Visible=false;
        }

        private void SeviyeSecimi_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
