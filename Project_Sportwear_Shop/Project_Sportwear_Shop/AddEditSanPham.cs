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
using System.IO;
namespace Project_Sportwear_Shop
{
    public partial class AddEditSanPham : Form
    {
        public bool check_btn = false;
        SqlConnection con;
        SanPhamForm spF;
        string fileAnh="";
        public AddEditSanPham(SanPhamForm sp)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            spF = sp;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #region Method
        public bool KiemTraInput()
        {
            if (check_btn == true)
            {
                if (!string.IsNullOrEmpty(txt_GiaBan.Text) && !string.IsNullOrEmpty(txt_TenSanPham.Text) && cbb_HangSP.Text != "" && cbb_LoaiSP.Text != "" && pictureBox1.Image != null)
                {
                    return true;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_GiaBan.Text) && !string.IsNullOrEmpty(txt_TenSanPham.Text) && cbb_HangSP.Text != "" && cbb_LoaiSP.Text != "")
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            if (check_btn == true)
            {
                txt_GiaBan.Clear();
                cbb_HangSP.SelectedIndex = -1;
                cbb_LoaiSP.SelectedIndex = -1;
                txt_TenSanPham.Clear();
               
                pictureBox1.Image = null;
                errorProvider1.Clear();
            }
            else
            {
                txt_GiaBan.Clear();
                cbb_HangSP.Text = null;
                cbb_LoaiSP.Text = null;
                txt_TenSanPham.Clear();

                pictureBox1.Image = null;
                errorProvider1.Clear();
            }
        }
        //Check button ADD/EDIT
        public void loadHangSanXuat()
        {
            DataSet ds = new DataSet();

            string sql = "select distinct* from HANGSANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(ds, "hang");
            cbb_HangSP.DataSource = ds.Tables["hang"];
            cbb_HangSP.DisplayMember = "TenHang";
            cbb_HangSP.ValueMember = "IDHangSanPham";
            cbb_HangSP.SelectedIndex = -1;
        }
        public void loadHangSanXuatEdit()
        {
            DataSet ds = new DataSet();

            string sql = "select distinct* from HANGSANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "hang");
            cbb_HangSP.DataSource = ds.Tables["hang"];
            cbb_HangSP.DisplayMember = "TenHang";
            cbb_HangSP.ValueMember = "IDHangSanPham";
            cbb_HangSP.Text=spF.dgv_DanhSachSanPham.CurrentRow.Cells[0].Value.ToString();
        }
        public void loadLoaiSanPham()
        {
            try
            {
                cbb_LoaiSP.Items.Clear();
                con.Open();
                string sql = "SELECT distinct TenLoai FROM HANGSANPHAM";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbb_LoaiSP.Items.Add(rd["TenLoai"].ToString());
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

        public void showErol()
        {
            if (string.IsNullOrEmpty(txt_GiaBan.Text))
            {
                errorProvider1.SetError(txt_GiaBan, "Vui lòng nhập giá bán");
            }
            else
            {
                errorProvider1.SetError(txt_GiaBan, "");
            }
            if (string.IsNullOrEmpty(txt_TenSanPham.Text))
            {
                errorProvider1.SetError(txt_TenSanPham, "Vui lòng nhập tên sản phẩm");
            }
            else
            {
                errorProvider1.SetError(txt_TenSanPham, "");
            }
            
            if (cbb_HangSP.Text == "")
            {
                errorProvider1.SetError(cbb_HangSP, "Vui lòng chọn hãng sản phẩm");
            }
            else
            {
                errorProvider1.SetError(cbb_HangSP, "");
            }
            if (cbb_LoaiSP.Text == "")
            {
                errorProvider1.SetError(cbb_LoaiSP, "Vui lòng chọn loại sản phẩm");
            }
            else
            {
                errorProvider1.SetError(cbb_LoaiSP, "");
            }
            if (pictureBox1.Image == null)
            {
                errorProvider1.SetError(pictureBox1, "Vui lòng chọn hình ảnh");
            }
            else
            {
                errorProvider1.SetError(pictureBox1, "");
            }
        }


        #endregion

        public void AddEditSanPham_Load(object sender, EventArgs e)
        {
            if(check_btn==true)
            {
                loadHangSanXuat();
                loadLoaiSanPham();
                lblTittle.Text = "Thêm Thông Tin Sản Phẩm";
            }
            else
            {
                loadHangSanXuatEdit();

                loadLoaiSanPham();
                lblTittle.Text = "Sửa Thông Tin Sản Phẩm";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|Tất cả các tệp (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileAnh = openFileDialog.FileName;
                    // Đọc hình ảnh từ tệp đã chọn
                    Image newImage = Image.FromFile(openFileDialog.FileName);
                    // Gán hình ảnh mới cho PictureBox
                    pictureBox1.Image = newImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (check_btn == true)
            {
                if (KiemTraInput() == true)
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        string rdo = "";
                        if (rdo_L.Checked == true)
                        {
                            rdo = "L";
                        }
                        else if (rdo_M.Checked == true)
                        {
                            rdo = "M";
                        }
                        else if (rdo_S.Checked == true)
                        {
                            rdo = "S";
                        }
                        else if (rdo_XL.Checked == true)
                        {
                            rdo = "XL";
                        }

                        string sql = "EXEC AddSanPham @TenSanPham, @IDHangSanPham, @HinhAnh,@Size, @GiaBan";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@TenSanPham", txt_TenSanPham.Text);
                        cmd.Parameters.AddWithValue("@IDHangSanPham", cbb_HangSP.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@HinhAnh", "../anh/" + Path.GetFileName(fileAnh));
                        cmd.Parameters.AddWithValue("@Size", rdo);
                        cmd.Parameters.AddWithValue("@GiaBan", txt_GiaBan.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Lưu Thành Công");
                        spF.getDataSanPham();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    showErol();
                    return;
                }
                Clear();
            }
            else
            {
                if (KiemTraInput() == true)
                {
                    try
                    {

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        if (fileAnh == "")
                        {
                            string rdo = "";
                            if (rdo_L.Checked == true)
                            {
                                rdo = "L";
                            }
                            else if (rdo_M.Checked == true)
                            {
                                rdo = "M";
                            }
                            else if (rdo_S.Checked == true)
                            {
                                rdo = "S";
                            }
                            else if (rdo_XL.Checked == true)
                            {
                                rdo = "XL";
                            }
                            string sql2 = "select HinhAnh from SANPHAM WHERE TenSanPham=N'"+txt_TenSanPham.Text+"' AND Size='"+rdo+"'";
                            SqlCommand cmd2 = new SqlCommand(sql2, con);
                            SqlDataReader rd = cmd2.ExecuteReader();

                            while (rd.Read())
                            {
                                fileAnh = rd["HinhAnh"].ToString();
                            }
                            con.Close();
                        }
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        string rdo1 = "";
                        if (rdo_L.Checked == true)
                        {
                            rdo1 = "L";
                        }
                        else if (rdo_M.Checked == true)
                        {
                            rdo1 = "M";
                        }
                        else if (rdo_S.Checked == true)
                        {
                            rdo1 = "S";
                        }
                        else if (rdo_XL.Checked == true)
                        {
                            rdo1 = "XL";
                        }

                        string sql = "EXEC EditSanPham @TenSanPham, @IDHangSanPham, @HinhAnh, @Size, @GiaBan";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@TenSanPham", txt_TenSanPham.Text);
                        cmd.Parameters.AddWithValue("@IDHangSanPham", cbb_HangSP.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@HinhAnh", "../anh/" + Path.GetFileName(fileAnh));
                        cmd.Parameters.AddWithValue("@Size",rdo1); 
                        cmd.Parameters.AddWithValue("@GiaBan", int.Parse(txt_GiaBan.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Lưu Thành Công");
                        spF.getDataSanPham();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    showErol();
                    return;
                }
                Clear();
                this.Dispose();
            }

        }

        private void txt_TinhTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
