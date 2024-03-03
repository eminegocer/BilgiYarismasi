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
    public partial class SonucOrta : Form
    {
        public SonucOrta()
        {
            InitializeComponent();
        }

        private void lblDogru_Click(object sender, EventArgs e)
        {

        }

        private void SonucOrta_Load(object sender, EventArgs e)
        {

            lblDogru.Text = Orta.dogru.ToString();
            lblYanlis.Text = Orta.yanlis.ToString();
            lblPuan.Text = (Orta.dogru * 5).ToString();
        }
    }
}
