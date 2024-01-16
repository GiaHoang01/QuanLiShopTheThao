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
using System.Text.RegularExpressions;

namespace Project_Sportwear_Shop
{
    public partial class NhanVienModule : Form
    {
        public bool isAddMode = false;
        SqlConnection con;
        NhanVienForm nvF;
        public NhanVienModule(NhanVienForm nf)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            nvF = nf;
        }
        #region Method
        public void UpdateButtonState()
        {
            if (isAddMode)
            {
                // Nếu đang ở chế độ sửa, làm mờ nút Thêm và hiển thị nút Sửa
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN NHÂN VIÊN";
            }
            else
            {
                // Ngược lại, làm mờ nút Sửa và hiển thị nút Thêm
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN NHÂN VIÊN";
            }
        }
        public bool KT_KhoaChinh(string ma)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT * FROM NHANVIEN WHERE IDNhanVien = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                con.Close();
                return false;
            }
            else
            {
                rd.Close();
                con.Close();
                return true;
            }
        }
        public bool KT_IDTaiKhoan(string ma)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT * FROM NHANVIEN WHERE IDTaiKhoan = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                con.Close();
                return false;
            }
            else
            {
                rd.Close();
                con.Close();
                return true;
            }
        }
        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txt_MaNV.Text) || string.IsNullOrEmpty(txt_TenNV.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_SDTNV.Text) || string.IsNullOrEmpty(txt_EmailNV.Text) || string.IsNullOrEmpty(txt_Luong.Text) || string.IsNullOrEmpty(cmb_GT.Text) || string.IsNullOrEmpty(cmb_VTCV.Text))
            {
                return false;
            }
            else
            {
                if (!(txt_MaNV.Text.Length == 5 && txt_MaNV.Text.StartsWith("NV") == true && txt_MaNV.Text.Substring(2).All(char.IsDigit) == true) || !IsValidEmail(txt_EmailNV.Text) || (txt_SDTNV.Text.ToArray().Length < 10 || txt_SDTNV.Text.ToArray().Length > 10))
                {
                    return false;
                }
            }
            return true;
        }
        public void Clear()
        {
            if (btn_sua.Enabled)
            {
                txt_TenNV.Clear();
                txt_DiaChi.Clear();
                txt_SDTNV.Clear();
                txt_EmailNV.Clear();
                txt_Luong.Clear();
                txt_IDTaiKhoan.Clear();
                cmb_VTCV.Text = null;
                cmb_GT.Text = null;
                errorProvider1.Clear();
            }
            else
            {
                txt_MaNV.Clear();
                txt_TenNV.Clear();
                txt_DiaChi.Clear();
                txt_SDTNV.Clear();
                txt_EmailNV.Clear();
                txt_Luong.Clear();
                txt_IDTaiKhoan.Clear();
                errorProvider1.Clear();
            }
        }
        public bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public void CheckErrorProvider()
        {
            if (string.IsNullOrEmpty(txt_EmailNV.Text))
            {
                errorProvider1.SetError(txt_EmailNV, "Vui lòng điền thông tin");
            }
            else if (!IsValidEmail(txt_EmailNV.Text))
            {
                errorProvider1.SetError(txt_EmailNV, "Địa chỉ email không hợp lệ");
            }
            else
            {
                errorProvider1.SetError(txt_EmailNV, "");
            }
            if (string.IsNullOrEmpty(txt_MaNV.Text))
            {
                errorProvider1.SetError(txt_MaNV, "Vui lòng điền thông tin");
            }
            else if (!(txt_MaNV.Text.Length == 5 && txt_MaNV.Text.StartsWith("NV") == true && txt_MaNV.Text.Substring(2).All(char.IsDigit) == true))
            {
                errorProvider1.SetError(txt_MaNV, "Mã nhân viên không đúng định dạng (VD: NV000)");
            }
            else
            {
                errorProvider1.SetError(txt_MaNV, "");
            }
            if (string.IsNullOrEmpty(txt_TenNV.Text))
            {
                errorProvider1.SetError(txt_TenNV, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_TenNV, "");
            }
            if (string.IsNullOrEmpty(txt_DiaChi.Text))
            {
                errorProvider1.SetError(txt_DiaChi, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_DiaChi, "");
            }
            if (string.IsNullOrEmpty(txt_SDTNV.Text))
            {
                errorProvider1.SetError(txt_SDTNV, "Vui lòng điền thông tin");
            }
            else if (txt_SDTNV.Text.ToArray().Length < 10 || txt_SDTNV.Text.ToArray().Length > 10)
            {
                errorProvider1.SetError(txt_SDTNV, "Yêu cầu SĐT phải 10 chữ số");
            }
            else
            {
                errorProvider1.SetError(txt_SDTNV, "");
            }
            //Check lương
            if (string.IsNullOrEmpty(txt_Luong.Text))
            {
                errorProvider1.SetError(txt_Luong, "Vui lòng nhập lương");
            }
            else
            {
                errorProvider1.SetError(txt_Luong, "");
            }
            //Chọn giới tính
            if (string.IsNullOrEmpty(cmb_GT.Text))
            {
                errorProvider1.SetError(cmb_GT, "Vui lòng chọn giới tính");
            }
            else
            {
                errorProvider1.SetError(cmb_GT, "");
            }
            //Chọn vị trí công việc
            if (string.IsNullOrEmpty(cmb_VTCV.Text))
            {
                errorProvider1.SetError(cmb_VTCV, "Vui lòng chọn vị trí công việc");
            }
            else
            {
                errorProvider1.SetError(cmb_VTCV, "");
            }
        }
        #endregion

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc muốn thêm nhân viên này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Kiểm tra trùng Mã nhân viên
                        if (KT_KhoaChinh(txt_MaNV.Text))
                        {
                            if (cmb_VTCV.Text != "Bảo Vệ")
                            {
                                //Kiểm tra trùng ID tài khoản
                                if (KT_IDTaiKhoan(txt_IDTaiKhoan.Text))
                                {
                                    string sql;
                                    if (con.State == ConnectionState.Closed)
                                    {
                                        con.Open();
                                    }
                                    if (txt_IDTaiKhoan.Text == "")
                                    {
                                        sql = "insert into NHANVIEN values('" + txt_MaNV.Text + "',N'" + txt_TenNV.Text + "','" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "',N'" + cmb_GT.Text + "',N'" + txt_DiaChi.Text + "','" + txt_SDTNV.Text + "', '" + txt_EmailNV.Text + "',N'" + cmb_VTCV.Text + "'," + txt_Luong.Text + ", '" + dtp_NVL.Value.ToString("yyyy/MM/dd") + "', null)";
                                    }
                                    else
                                    {
                                        sql = "insert into NHANVIEN values('" + txt_MaNV.Text + "',N'" + txt_TenNV.Text + "','" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "',N'" + cmb_GT.Text + "',N'" + txt_DiaChi.Text + "','" + txt_SDTNV.Text + "', '" + txt_EmailNV.Text + "',N'" + cmb_VTCV.Text + "'," + txt_Luong.Text + ", '" + dtp_NVL.Value.ToString("yyyy/MM/dd") + "','" + txt_IDTaiKhoan.Text + "')";
                                    }
                                    SqlCommand cmd = new SqlCommand(sql, con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Clear();
                                    nvF.LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Trùng ID tài khoản hoặc tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                            //Nếu vị trí công việc là Bảo vệ
                            else
                            {
                                if (con.State == ConnectionState.Closed)
                                {
                                    con.Open();
                                }
                                string sql = "insert into NHANVIEN values('" + txt_MaNV.Text + "',N'" + txt_TenNV.Text + "','" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "',N'" + cmb_GT.Text + "',N'" + txt_DiaChi.Text + "','" + txt_SDTNV.Text + "', '" + txt_EmailNV.Text + "',N'" + cmb_VTCV.Text + "'," + txt_Luong.Text + ", '" + dtp_NVL.Value.ToString("yyyy/MM/dd") + "', null)";
                                SqlCommand cmd = new SqlCommand(sql, con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                nvF.LoadData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Trùng Mã Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CheckErrorProvider();
                return;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa nhân viên này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (cmb_VTCV.Text != "Bảo Vệ")
                        {
                            //Kiểm tra trùng ID tài khoản
                            if (KT_IDTaiKhoan(txt_IDTaiKhoan.Text))
                            {
                                string sql;
                                if (con.State == ConnectionState.Closed)
                                {
                                    con.Open();
                                }
                                if (txt_IDTaiKhoan.Text == "")
                                {
                                    sql = "update NHANVIEN set TenNhanVien = N'" + txt_TenNV.Text + "', NgaySinh = '" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "', GioiTinh = N'" + cmb_GT.Text + "', DiaChi = N'" + txt_DiaChi.Text + "', SDT = '" + txt_SDTNV.Text + "', Email = '" + txt_EmailNV.Text + "', ViTriCongViec = N'" + cmb_VTCV.Text + "', Luong = " + txt_Luong.Text + ", NgayVaoLam = '" + dtp_NVL.Value.ToString("yyyy/MM/dd") + "', IDTaiKhoan = null where IDNhanVien = '" + txt_MaNV.Text + "'";
                                }
                                else
                                {
                                    sql = "update NHANVIEN set TenNhanVien = N'" + txt_TenNV.Text + "', NgaySinh = '" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "', GioiTinh = N'" + cmb_GT.Text + "', DiaChi = N'" + txt_DiaChi.Text + "', SDT = '" + txt_SDTNV.Text + "', Email = '" + txt_EmailNV.Text + "', ViTriCongViec = N'" + cmb_VTCV.Text + "', Luong = " + txt_Luong.Text + ", NgayVaoLam = '" + dtp_NVL.Value.ToString("yyyy/MM/dd") + "', IDTaiKhoan = '" + txt_IDTaiKhoan.Text + "' where IDNhanVien = '" + txt_MaNV.Text + "'";
                                }
                                SqlCommand cmd = new SqlCommand(sql, con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                nvF.LoadData();
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Trùng ID tài khoản hoặc tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        //Nếu vị trí công việc là Bảo vệ
                        else
                        {
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                            string sql = "update NHANVIEN set TenNhanVien = N'" + txt_TenNV.Text + "', NgaySinh = '" + dtp_NgaySinh.Value.ToString("yyyy/MM/dd") + "', GioiTinh = N'" + cmb_GT.Text + "', DiaChi = N'" + txt_DiaChi.Text + "', SDT = '" + txt_SDTNV.Text + "', Email = '" + txt_EmailNV.Text + "', ViTriCongViec = N'" + cmb_VTCV.Text + "', Luong = " + txt_Luong.Text + ", NgayVaoLam = '" + dtp_NVL.Value.ToString("yyyy/MM/dd") + "', IDTaiKhoan = null where IDNhanVien = '" + txt_MaNV.Text + "'";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            nvF.LoadData();
                            this.Dispose();
                        }
                    }
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
                CheckErrorProvider();
                return;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NhanVienModule_Load(object sender, EventArgs e)
        {
            string[] gt = { "Nam", "Nữ" };
            foreach (string s in gt)
            {
                cmb_GT.Items.Add(s);
            }
            con.Open();
            string sql = "SELECT DISTINCT ViTriCongViec from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmb_VTCV.Items.Add(rd["ViTriCongViec"].ToString());
            }
            rd.Close();
            con.Close();
            UpdateButtonState();
        }

        private void cmb_VTCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nếu vị trí công việc là Bảo Vệ thì không cần ID tài khoản
            if (cmb_VTCV.Text == "Bảo Vệ")
            {
                txt_IDTaiKhoan.Enabled = false;
            }
            else
                txt_IDTaiKhoan.Enabled = true;
        }

        private void txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_IDTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_TenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_EmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
