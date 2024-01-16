using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sportwear_Shop
{
    public partial class BanHangModule2 : Form
    {
        SqlConnection con;
        ucProduct pro;
        BanHangForm BHF;
        public BanHangModule2(ucProduct p, BanHangForm bf)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            pro = p;
            BHF = bf;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region Method
        private void SLTon(string ten, string size)
        {
            string sql = "SELECT SoLuongTon FROM SANPHAM WHERE TenSanPham = N'" + ten + "' AND Size = '" + size + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txt_SLTon.Text = rd[0].ToString();
                }
                rd.Close();
                con.Close();
                lblTinhTrang.Visible = true;
                if (int.Parse(txt_SLTon.Text) != 0)
                {
                    lblTinhTrang.Text = "Còn Hàng";
                    lblTinhTrang.ForeColor = Color.Green;
                }
                else
                {
                    lblTinhTrang.Text = "Hết Hàng";
                    lblTinhTrang.ForeColor = Color.Red;
                }
            }
            else
            {
                rd.Close();
                con.Close();
                txt_SLTon.Text = "0";
                lblTinhTrang.Visible = true;
                lblTinhTrang.Text = "Chưa có sản phẩm này";
                lblTinhTrang.ForeColor = Color.Red;
            }
        }
        #endregion
        string sSize;
        private void rdoS_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoS.Checked)
            {
                SLTon(pro.TenSP.ToString(), rdoS.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoS.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        private void rdoM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoM.Checked)
            {
                SLTon(pro.TenSP.ToString(), rdoM.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoM.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        private void rdoL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoL.Checked)
            {
                SLTon(pro.TenSP.ToString(), rdoL.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoL.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        private void rdoXL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoXL.Checked)
            {
                SLTon(pro.TenSP.ToString(), rdoXL.Text);
                txt_SL.Enabled = true;
                txt_SL.Focus();
                sSize = rdoXL.Text;
            }
            else
            {
                txt_SLTon.Clear();
            }
        }

        private void BanHangModule2_Load(object sender, EventArgs e)
        {
            lblTittle.Text = pro.TenSP.ToString();
            txt_SL.Text = "1";
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
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SL.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SL.Clear();
                txt_SL.Focus();
                return;
            }
            else if (int.Parse(txt_SL.Text) > int.Parse(txt_SLTon.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng <= số lượng tồn kho", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SL.Clear();
                txt_SL.Focus();
                return;
            }
            else if (int.Parse(txt_SL.Text) == 0)
            {
                MessageBox.Show("Vui lòng không nhập số lượng = 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SL.Clear();
                txt_SL.Focus();
                return;
            }
            else if (int.Parse(txt_SLTon.Text) == 0)
            {
                MessageBox.Show("Hết hàng vui lòng chọn size khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SL.Clear();
                txt_SL.Focus();
                return;
            }
            foreach (DataGridViewRow item in BHF.dgv_Inf.Rows)
            {
                if (item.Cells[1].Value.ToString() == pro.TenSP && item.Cells[3].Value.ToString() == sSize)
                {
                    item.Cells[2].Value = txt_SL.Text;
                    item.Cells[5].Value = int.Parse(item.Cells[2].Value.ToString()) * int.Parse(item.Cells[4].Value.ToString());
                    BHF.GetTotal();
                    return;
                }
            }
            BHF.dgv_Inf.Rows.Add(new object[] { 0, pro.TenSP, txt_SL.Text, sSize, pro.GiaBan1, int.Parse(txt_SL.Text) * int.Parse(pro.GiaBan1.ToString()) });
            BHF.GetTotal();
            txt_SL.Clear();
            txt_SL.Focus();
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
