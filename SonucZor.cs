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
    public partial class SonucZor : Form
    {
        public SonucZor()
        {
            InitializeComponent();
        }

        private void SonucZor_Load(object sender, EventArgs e)
        {
            lblDogru.Text = Zor.dogru.ToString();
            lblYanlis.Text = Zor.yanlis.ToString();
            lblPuan.Text = (Zor.dogru * 7).ToString();
        }
    }
}
