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
    public partial class SanPhamNhap : UserControl
    {
        NhapHang NH;

        public SanPhamNhap(NhapHang nh)
        {
            InitializeComponent();
            NH = nh;
        }
        public event EventHandler onSelect = null;
        #region method

        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        private string tenSanPham;

        [Category("Custom Props")]

        private Image anhSanPham;
        [Category("Custom Props")]
        public Image AnhSanPham
        {
            get { return anhSanPham; }
            set { anhSanPham = value; picture_AnhSP.Image=value; }
        }


        [Category("Custom Props")]
        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; txt_TenSanPham.Text=value; }
        }

        #endregion

        private void picture_AnhSP_Click(object sender, EventArgs e)
        {
            ChiTietNhapHang nh = new ChiTietNhapHang(this, NH);
            nh.txt_TenSanPham.Text = TenSanPham;
            nh.AnhSanPham.Image = AnhSanPham;

            nh.ShowDialog();
            if (onSelect != null)
            {
                onSelect(this, e);
            }
        }

        private void SanPhamNhap_Load(object sender, EventArgs e)
        {
            duongthang.Height = 2;
        }
        


    }
}
