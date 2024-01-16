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
    public partial class SanPhamForm : Form
    {
        SqlConnection con;
        MainForm temp;
        public SanPhamForm(MainForm tam)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            temp = tam;
        }
        #region Method
        public void loadSearch()
        {
            cbb_Search.Items.Clear();
            string[] a = {"Tên Sản Phẩm", "Tên Hãng", "Tên Loại", "Giá Bán" };
            cbb_Search.Items.AddRange(a);
        }
        public void loadHangSanXuat()
        {
            try
            {
                con.Open();
                string sql = "SELECT distinct TenHang FROM HANGSANPHAM";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cmb_HangSX.Items.Add(rd["TenHang"].ToString());
                }
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        public void loadLoaiSanPham()
        {
            try
            {
                con.Open();
                string sql = "SELECT distinct TenLoai FROM HANGSANPHAM";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cmb_LoaiSP.Items.Add(rd["TenLoai"].ToString());
                }
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void getDataSanPham()
        {
            try
            {
                dgv_DanhSachSanPham.Rows.Clear();
                con.Open();
                string sql = "SELECT * FROM SANPHAM LEFT  JOIN HANGSANPHAM ON SANPHAM.IDHangSanPham = HANGSANPHAM.IDHangSanPham ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Image imagePath = Image.FromFile(rd["HinhAnh"].ToString());
                    dgv_DanhSachSanPham.Rows.Add(rd["TenHang"].ToString(), rd["TenSanPham"].ToString(), rd["TenLoai"].ToString(), rd["Size"], rd["TinhTrang"].ToString(), rd["GiaBan"].ToString(), rd["SoLuongTon"].ToString(), imagePath);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDuLieuSanPham()
        {
            try
            {
                con.Open();
                string sql = "	SELECT * FROM SANPHAM LEFT  JOIN HANGSANPHAM ON SANPHAM.IDHangSanPham = HANGSANPHAM.IDHangSanPham ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Image imagePath = Image.FromFile(rd["HinhAnh"].ToString());
                    dgv_DanhSachSanPham.Rows.Add(rd["TenHang"].ToString(), rd["TenSanPham"].ToString(), rd["TenLoai"].ToString(), rd["Size"], rd["TinhTrang"].ToString(), rd["GiaBan"].ToString(), rd["SoLuongTon"].ToString(), imagePath);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            loadSearch();
            loadHangSanXuat();
            loadLoaiSanPham();
            getDataSanPham();

            if (temp.lblRole.Text != "Chức Vụ: Quản Lý Cửa Hàng")
            {
                btn_AddNCC.Hide();
                dgv_DanhSachSanPham.ContextMenuStrip = null;
            }
        }

        private void btn_AddNCC_Click(object sender, EventArgs e)
        {
            AddEditSanPham asp = new AddEditSanPham(this);
            asp.check_btn = true;
            asp.ShowDialog();
        }

        //========
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddEditSanPham module = new AddEditSanPham(this);
            module.label4.Hide();
            module.label9.Hide();
            module.cbb_HangSP.SelectedItem = dgv_DanhSachSanPham.CurrentRow.Cells[0].Value.ToString();
            module.txt_TenSanPham.Text = dgv_DanhSachSanPham.CurrentRow.Cells[1].Value.ToString();
            module.txt_TenSanPham.Enabled = false;
            module.rdo_L.Enabled = module.rdo_M.Enabled = module.rdo_S.Enabled = module.rdo_XL.Enabled = false;
            module.txt_GiaBan.Text = dgv_DanhSachSanPham.CurrentRow.Cells[5].Value.ToString();
            module.AddEditSanPham_Load(sender, e);
            DataGridViewImageCell imageCell = (DataGridViewImageCell)dgv_DanhSachSanPham.CurrentRow.Cells[7];
            Image image = (Image)imageCell.Value;
            module.pictureBox1.Image = image;
            module.cbb_LoaiSP.SelectedItem = dgv_DanhSachSanPham.CurrentRow.Cells[2].Value.ToString();
            string rdo = dgv_DanhSachSanPham.CurrentRow.Cells[3].Value.ToString();
            if (rdo == "S")
            {
                module.rdo_S.Checked = true;
                module.rdo_L.Checked = false;
                module.rdo_M.Checked = false;
                module.rdo_XL.Checked = false;
            }
            else if (rdo == "M")
            {
                module.rdo_S.Checked = false;
                module.rdo_L.Checked = false;
                module.rdo_M.Checked = true;
                module.rdo_XL.Checked = false;
            }
            else if (rdo == "L")
            {
                module.rdo_S.Checked = false;
                module.rdo_L.Checked = true;
                module.rdo_M.Checked = false;
                module.rdo_XL.Checked = false;
            }
            else if (rdo == "XL")
            {
                module.rdo_S.Checked = false;
                module.rdo_L.Checked = false;
                module.rdo_M.Checked = false;
                module.rdo_XL.Checked = true;
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT DISTINCT IDHangSanPham FROM HANGSANPHAM WHERE TenHang='" + dgv_DanhSachSanPham.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                module.cbb_HangSP.SelectedItem = rd["IDHangSanPham"];
            }
            rd.Close();
            con.Close();
            module.ShowDialog();
        }

        private void txt_TimKiemSP_TextChanged(object sender, EventArgs e)
        {
            string search = txt_TimKiemSP.Text.Trim();
            if (cbb_Search.Text != "")
            {
                if (search == "")
                {
                    getDataSanPham();
                }
                else
                {
                    if (cbb_Search.SelectedItem.ToString() == "Tên Sản Phẩm")
                    {
                        dgv_DanhSachSanPham.Rows.Clear();
                        string sql = "	SELECT * FROM SANPHAM LEFT  JOIN HANGSANPHAM ON SANPHAM.IDHangSanPham = HANGSANPHAM.IDHangSanPham  where SANPHAM.TenSanPham LIKE N'%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Image imagePath = Image.FromFile(rd["HinhAnh"].ToString());
                            dgv_DanhSachSanPham.Rows.Add(rd["TenHang"].ToString(), rd["TenSanPham"].ToString(), rd["TenLoai"].ToString(), rd["Size"], rd["TinhTrang"].ToString(), rd["GiaBan"].ToString(), rd["SoLuongTon"].ToString(), imagePath);
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_Search.SelectedItem.ToString() == "Tên Hãng")
                    {
                        dgv_DanhSachSanPham.Rows.Clear();
                        string sql = "	SELECT * FROM SANPHAM LEFT  JOIN HANGSANPHAM ON SANPHAM.IDHangSanPham = HANGSANPHAM.IDHangSanPham where HANGSANPHAM.TenHang LIKE N'%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Image imagePath = Image.FromFile(rd["HinhAnh"].ToString());
                            dgv_DanhSachSanPham.Rows.Add(rd["TenHang"].ToString(), rd["TenSanPham"].ToString(), rd["TenLoai"].ToString(), rd["Size"], rd["TinhTrang"].ToString(), rd["GiaBan"].ToString(), rd["SoLuongTon"].ToString(), imagePath);
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_Search.SelectedItem.ToString() == "Tên Loại")
                    {
                        dgv_DanhSachSanPham.Rows.Clear();
                        string sql = "	SELECT * FROM SANPHAM LEFT  JOIN HANGSANPHAM ON SANPHAM.IDHangSanPham = HANGSANPHAM.IDHangSanPham where HANGSANPHAM.TenLoai LIKE N'%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Image imagePath = Image.FromFile(rd["HinhAnh"].ToString());
                            dgv_DanhSachSanPham.Rows.Add(rd["TenHang"].ToString(), rd["TenSanPham"].ToString(), rd["TenLoai"].ToString(), rd["Size"], rd["TinhTrang"].ToString(), rd["GiaBan"].ToString(), rd["SoLuongTon"].ToString(), imagePath);
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_Search.SelectedItem.ToString() == "Giá Bán")
                    {
                        dgv_DanhSachSanPham.Rows.Clear();
                        string sql = "	SELECT * FROM SANPHAM LEFT  JOIN HANGSANPHAM ON SANPHAM.IDHangSanPham = HANGSANPHAM.IDHangSanPham  where SANPHAM.GiaBan between 0 and '" + search + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Image imagePath = Image.FromFile(rd["HinhAnh"].ToString());
                            dgv_DanhSachSanPham.Rows.Add(rd["TenHang"].ToString(), rd["TenSanPham"].ToString(), rd["TenLoai"].ToString(), rd["Size"], rd["TinhTrang"].ToString(), rd["GiaBan"].ToString(), rd["SoLuongTon"].ToString(), imagePath);
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

        private void dgv_DanhSachSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachSanPham.SelectedRows.Count > 0)
            {
            
                txt_TenSP.Text = dgv_DanhSachSanPham.CurrentRow.Cells[1].Value.ToString();
                cmb_HangSX.SelectedItem = dgv_DanhSachSanPham.CurrentRow.Cells[0].Value.ToString();
                cmb_LoaiSP.SelectedItem = dgv_DanhSachSanPham.CurrentRow.Cells[2].Value.ToString();
                txt_TinhTrang.Text = dgv_DanhSachSanPham.CurrentRow.Cells[4].Value.ToString();
                txt_GiaBan.Text = dgv_DanhSachSanPham.CurrentRow.Cells[5].Value.ToString();
                txt_SoLuongTon.Text = dgv_DanhSachSanPham.CurrentRow.Cells[6].Value.ToString();
                Image img = (Image)dgv_DanhSachSanPham.CurrentRow.Cells[7].Value;
                img_SP.Image = new Bitmap(img);
                string rdo = dgv_DanhSachSanPham.CurrentRow.Cells[3].Value.ToString();
                if (rdo == "S")
                {
                    rdo_S.Checked = true;
                    rdo_L.Checked = false;
                    rdo_M.Checked = false;
                    rdo_XL.Checked = false;
                }
                else if (rdo == "M")
                {
                    rdo_S.Checked = false;
                    rdo_L.Checked = false;
                    rdo_M.Checked = true;
                    rdo_XL.Checked = false;
                }
                else if (rdo == "L")
                {
                    rdo_S.Checked = false;
                    rdo_L.Checked = true;
                    rdo_M.Checked = false;
                    rdo_XL.Checked = false;
                }
                else if (rdo == "XL")
                {
                    rdo_S.Checked = false;
                    rdo_L.Checked = false;
                    rdo_M.Checked = false;
                    rdo_XL.Checked = true;
                }

            }
            else
            {
                txt_TenSP.Clear();
                cmb_HangSX.SelectedIndex = -1;
                cmb_LoaiSP.SelectedIndex = -1;
                txt_SoLuongTon.Clear();
                txt_TinhTrang.Clear();
                txt_GiaBan.Clear();
                img_SP.Image = null;
            }
        }

        private void btn_ResetNCC_Click(object sender, EventArgs e)
        {
            txt_TimKiemSP.Clear();
            cbb_Search.SelectedIndex = -1;
        }

        public bool checkTinhTrang()
        {
            string rdo = dgv_DanhSachSanPham.CurrentRow.Cells[3].Value.ToString();
            if (rdo == "S")
            {
                rdo_S.Checked = true;
                rdo_L.Checked = false;
                rdo_M.Checked = false;
                rdo_XL.Checked = false;
            }
            else if (rdo == "M")
            {
                rdo_S.Checked = false;
                rdo_L.Checked = false;
                rdo_M.Checked = true;
                rdo_XL.Checked = false;
            }
            else if (rdo == "L")
            {
                rdo_S.Checked = false;
                rdo_L.Checked = true;
                rdo_M.Checked = false;
                rdo_XL.Checked = false;
            }
            else if (rdo == "XL")
            {
                rdo_S.Checked = false;
                rdo_L.Checked = false;
                rdo_M.Checked = false;
                rdo_XL.Checked = true;
            }
            string tinhtrang = "";
            con.Open();
            string sql = "SELECT TINHTRANG FROM SANPHAM WHERE TENSANPHAM ='" + txt_TenSP.Text + "'AND SIZE='" + rdo + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tinhtrang = rd["TinhTrang"].ToString();
            }

            if (tinhtrang == "Chưa Nhập Sản Phẩm")
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rdo = dgv_DanhSachSanPham.CurrentRow.Cells[3].Value.ToString();
            if (rdo == "S")
            {
                rdo_S.Checked = true;
                rdo_L.Checked = false;
                rdo_M.Checked = false;
                rdo_XL.Checked = false;
            }
            else if (rdo == "M")
            {
                rdo_S.Checked = false;
                rdo_L.Checked = false;
                rdo_M.Checked = true;
                rdo_XL.Checked = false;
            }
            else if (rdo == "L")
            {
                rdo_S.Checked = false;
                rdo_L.Checked = true;
                rdo_M.Checked = false;
                rdo_XL.Checked = false;
            }
            else if (rdo == "XL")
            {
                rdo_S.Checked = false;
                rdo_L.Checked = false;
                rdo_M.Checked = false;
                rdo_XL.Checked = true;
            }
            try
            {
               if(checkTinhTrang()==false)
               {
                   con.Open();
                   string sql = "exec DeleteSanPham '" + txt_TenSP.Text + "','" + rdo + "'";
                   SqlCommand cmd = new SqlCommand(sql, con);
                   cmd.ExecuteNonQuery();
                   con.Close();
                   MessageBox.Show("Xóa Thành Công");
                   getDataSanPham();
               }
               else
               {
                   MessageBox.Show("Sản Phẩm Này Đã Nhập Hàng Không Thể Xóa");
               }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
