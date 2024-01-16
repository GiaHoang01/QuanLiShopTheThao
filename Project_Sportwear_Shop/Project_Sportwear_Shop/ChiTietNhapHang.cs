using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project_Sportwear_Shop
{
    public partial class ChiTietNhapHang : Form
    {
        SqlConnection con;
        SanPhamNhap spN;
        NhapHang NH;
        public ChiTietNhapHang(SanPhamNhap spn, NhapHang nh)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            spN = spn;
            NH = nh;
        }


        private void SLTon(string ten, string size)
        {
            string sql = "SELECT SoLuongTon FROM SANPHAM WHERE TENSANPHAM=N'"+ten+"' and size='"+size+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txt_SLTon.Text = rd["SoLuongTon"].ToString();
                }
                rd.Close();
                con.Close();
                lblTinhTrang.Visible = true;
                if (int.Parse(txt_SLTon.Text) != 0)
                {
                    lblTinhTrang.Text = "Sản Phẩm Này Còn Hàng";
                    lblTinhTrang.ForeColor = Color.Green;
                }
                else
                {
                    lblTinhTrang.Text = " Sản Phẩm Này Cháy Hàng";
                    lblTinhTrang.ForeColor = Color.Red;
                }
            }
            else
            {
                rd.Close();
                con.Close();
                txt_SLTon.Text = "0";
                lblTinhTrang.Visible = true;
                lblTinhTrang.Text = "Sản Phẩm Này Chưa Nhập";
                lblTinhTrang.ForeColor = Color.Red;
            }
        }

        string sSize;


        private void ChiTietNhapHang_Load(object sender, EventArgs e)
        {
    
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoS_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoS.Checked)
            {
                SLTon(spN.TenSanPham.ToString(), rdoS.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoS.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        private void rdoM_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoM.Checked)
            {
                SLTon(spN.TenSanPham.ToString(), rdoM.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoM.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        private void rdoL_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoL.Checked)
            {
                SLTon(spN.TenSanPham.ToString(), rdoL.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoL.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        private void rdoXL_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoXL.Checked)
            {
                SLTon(spN.TenSanPham.ToString(), rdoXL.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoXL.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        public bool CheckHangNhapChua()
        {
            string size="";
            if(rdoL.Checked)
            {
                size=rdoL.Text;
            }
            else if(rdoM.Checked)
            {
                size=rdoM.Text;
            }
            else if(rdoS.Checked)
            {
                size=rdoS.Text;
            }
            else if(rdoXL.Checked)
            {
                size=rdoXL.Text;
            }
            con.Open();
            string sql="Select count(*) from SANPHAM WHERE TENSANPHAM=N'"+txt_TenSanPham.Text+"' and Size='"+size+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int check = (int)cmd.ExecuteScalar();
            if(check==0)
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(CheckHangNhapChua()==true)
            {
                if (string.IsNullOrEmpty(txt_SL.Text))
                {
                    MessageBox.Show("Vui Lòng Nhập Số Lượng Cần Nhập Hàng");
                    return;
                }
                if (int.Parse(txt_SL.Text) <= 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Số Lượng Nhập Hàng Hợp Lệ");
                    return;
                }
                if (string.IsNullOrEmpty(txt_GiaNhap.Text))
                {
                    MessageBox.Show("Vui Lòng Nhập Giá Nhập của Sản Phẩm Nhập Hàng");
                    return;
                }
                if (int.Parse(txt_SL.Text) <= 0)
                {
                    MessageBox.Show("Vui Lòng  Nhập Giá Nhập của Sản Phẩm Nhập Hàng Hợp Lệ");
                    return;
                }
                foreach (DataGridViewRow item in NH.dgv_Inf.Rows)
                {
                    if (item.Cells[1].Value.ToString() == spN.TenSanPham && item.Cells[3].Value.ToString() == sSize)
                    {
                        item.Cells[2].Value = txt_SL.Text;
                        item.Cells[4].Value = txt_GiaNhap.Text;
                        item.Cells[5].Value = int.Parse(item.Cells[2].Value.ToString()) * int.Parse(item.Cells[4].Value.ToString());
                        NH.TinhTongChiTietHoaDon();
                        return;
                    }
                }
                NH.dgv_Inf.Rows.Add(new object[] { 0, spN.TenSanPham, txt_SL.Text, sSize, txt_GiaNhap.Text, int.Parse(txt_SL.Text) * int.Parse(txt_GiaNhap.Text), spN.AnhSanPham });
                NH.TinhTongChiTietHoaDon();
                txt_SL.Clear();
                txt_GiaNhap.Clear();
                txt_SL.Focus();
            }
            else
            {
                MessageBox.Show("Sản phẩm này chưa nhập");
                txt_GiaNhap.Clear();
                txt_SL.Clear();
                return;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_SL.Clear();
            rdoS.Checked = false;
            rdoM.Checked = false;
            rdoL.Checked = false;
            rdoXL.Checked = false;
            lblTinhTrang.Visible = false;
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
