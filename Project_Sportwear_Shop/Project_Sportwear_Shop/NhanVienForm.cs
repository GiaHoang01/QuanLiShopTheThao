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
    public partial class NhanVienForm : Form
    {
        SqlConnection con;
        public NhanVienForm()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }
        #region Method
        public void LoadData()
        {
            try
            {
                dgv_NhanVien.Rows.Clear();
                string sql = "SELECT * FROM NHANVIEN";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DateTime ngaysinh = DateTime.Parse(rd[2].ToString());
                    DateTime nvl = DateTime.Parse(rd[9].ToString());
                    dgv_NhanVien.Rows.Add(rd[0].ToString(), rd[1].ToString(), ngaysinh.ToShortDateString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), nvl.ToShortDateString(), rd[10].ToString());
                }
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadCBBSort()
        {
            cmb_TimKiem.Items.Clear();
            string[] tk = { "Mã nhân viên", "Tên nhân viên", "Vị trí công việc" };
            foreach (string s in tk)
            {
                cmb_TimKiem.Items.Add(s);
            }
        }
        #endregion

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            //Chỉ cho phép đọc không được sửa
            txt_MaNV.ReadOnly = true;
            txt_TenNV.ReadOnly = true;
            dtp_NgaySinh.Enabled = false;
            txt_GT.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
            txt_SDTNV.ReadOnly = true;
            txt_EmailNV.ReadOnly = true;
            txt_VTCV.ReadOnly = true;
            txt_Luong.ReadOnly = true;
            dtp_NVL.Enabled = false;
            txt_IDTaiKhoan.ReadOnly = true;
            LoadData();
            //Load cmb tìm kiếm
            LoadCBBSort();
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_NhanVien.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                NhanVienModule module = new NhanVienModule(this);
                module.txt_MaNV.Enabled = false;
                module.txt_MaNV.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TenNV.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.dtp_NgaySinh.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.cmb_GT.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_DiaChi.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txt_SDTNV.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.txt_EmailNV.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                module.cmb_VTCV.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                module.txt_Luong.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                module.dtp_NVL.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
                module.txt_IDTaiKhoan.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[10].Value.ToString();
                module.txt_MaNV.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên: " + txt_TenNV.Text, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string sql = "DELETE FROM NHANVIEN WHERE IDNhanVien = '" + dgv_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    LoadData();
                }
            }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            NhanVienModule nv = new NhanVienModule(this);
            nv.isAddMode = true;
            nv.UpdateButtonState();
            nv.ShowDialog();
        }

        private void btn_ResetNV_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
        }

        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                //Load data lên textbox
                txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
                txt_TenNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
                dtp_NgaySinh.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
                txt_GT.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
                txt_DiaChi.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
                txt_SDTNV.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
                txt_EmailNV.Text = dgv_NhanVien.CurrentRow.Cells[6].Value.ToString();
                txt_VTCV.Text = dgv_NhanVien.CurrentRow.Cells[7].Value.ToString();
                txt_Luong.Text = dgv_NhanVien.CurrentRow.Cells[8].Value.ToString();
                dtp_NVL.Text = dgv_NhanVien.CurrentRow.Cells[9].Value.ToString();
                txt_IDTaiKhoan.Text = dgv_NhanVien.CurrentRow.Cells[10].Value.ToString();
                dgv_NhanVien.Cursor = Cursors.Hand;
            }
            else
            {
                txt_MaNV.Clear();
                txt_TenNV.Clear();
                txt_GT.Clear();
                txt_DiaChi.Clear();
                txt_SDTNV.Clear();
                txt_EmailNV.Clear();
                dtp_NVL.ResetText();
                dtp_NgaySinh.ResetText();
                txt_VTCV.Clear();
                txt_Luong.Clear();
                txt_IDTaiKhoan.Clear();
                dgv_NhanVien.Cursor = Cursors.Default;
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string search = txt_TimKiem.Text.Trim();
            if (cmb_TimKiem.Text != "")
            {
                if (search == "")
                {
                    LoadData();
                }
                else
                {
                    if (cmb_TimKiem.SelectedItem.ToString() == "Mã nhân viên")
                    {
                        dgv_NhanVien.Rows.Clear();
                        string sql = "SELECT * FROM NHANVIEN WHERE IDNhanVien LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NhanVien.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cmb_TimKiem.SelectedItem.ToString() == "Tên nhân viên")
                    {
                        dgv_NhanVien.Rows.Clear();
                        string sql = "SELECT * FROM NHANVIEN WHERE TenNhanVien LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NhanVien.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cmb_TimKiem.SelectedItem.ToString() == "Vị trí công việc")
                    {
                        dgv_NhanVien.Rows.Clear();
                        string sql = "SELECT * FROM NHANVIEN WHERE ViTriCongViec LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NhanVien.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
