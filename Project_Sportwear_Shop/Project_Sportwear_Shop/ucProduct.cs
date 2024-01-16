using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sportwear_Shop
{
    public partial class ucProduct : UserControl
    {
        BanHangForm BHF;
        public ucProduct(BanHangForm bf)
        {
            InitializeComponent();
            BHF = bf;
        }
        public event EventHandler onSelect = null;
        private void ucProduct_Load(object sender, EventArgs e)
        {
            duongthang.Height = 2;
        }
        public string TenSP
        {
            get { return lbl_TenSP.Text; }
            set { lbl_TenSP.Text = value; }
        }
        private int GiaBan;

        public int GiaBan1
        {
            get { return GiaBan; }
            set { GiaBan = value; }
        }

        public Image PImage
        {
            get { return pBImage.Image; }
            set { pBImage.Image = value; }
        }
        private string PCategory;

        public string PCategory1
        {
            get { return PCategory; }
            set { PCategory = value; }
        }

        private void pBImage_Click(object sender, EventArgs e)
        {
            BanHangModule2 bh = new BanHangModule2(this, BHF);
            bh.ShowDialog();
            if (onSelect != null)
            {
                onSelect(this, e);
            }
        }
    }
}
