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
    public partial class Açilis : Form
    {
        public Açilis()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void Açilis_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                sayac += 2;
                progressBar1.Value = sayac;
                if (progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                    timer1.Stop();
                    this.Hide();
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();

                }
            


        }
    }
}
