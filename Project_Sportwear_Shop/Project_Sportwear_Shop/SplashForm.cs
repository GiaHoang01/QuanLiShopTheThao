using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sportwear_Shop
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int starPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            starPoint += 5;
            progressBar1.Value = starPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                ConnectForm cnn = new ConnectForm();
                cnn.ShowDialog();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
