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
using System.Text.RegularExpressions;

namespace Project_Sportwear_Shop
{
    public partial class NCCModule : Form
    {
        public bool isAddMode = false;
        SqlConnection con;
        NCCForm NccF;
        public NCCModule(NCCForm nf)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            NccF = nf;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #region Method
        public void UpdateButtonState()
        {
            if (isAddMode)
            {
                // Nếu đang ở chế độ sửa, làm mờ nút Thêm và hiển thị nút Sửa
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN NHÀ CUNG CẤP";
            }
            else
            {
                // Ngược lại, làm mờ nút Sửa và hiển thị nút Thêm
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN NHÀ CUNG CẤP";
            }
        }
        public bool KT_KhoaChinh(string ma)
        {
            con.Open();
            string sql = "SELECT * FROM NHACUNGCAP WHERE IDNHACUNGCAP = '" + ma + "'";
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
            if (string.IsNullOrEmpty(txt_MaNCC.Text) || string.IsNullOrEmpty(txt_TenNCC.Text) || string.IsNullOrEmpty(txt_DiaChiNCC.Text) || string.IsNullOrEmpty(txt_SDTNCC.Text) || string.IsNullOrEmpty(txt_EmailNCC.Text))
            {
                return false;
            }
            else
            {
                if (!(txt_MaNCC.Text.Length == 5 && txt_MaNCC.Text.StartsWith("NCC") == true && txt_MaNCC.Text.Substring(3).All(char.IsDigit) == true) || !IsValidEmail(txt_EmailNCC.Text) || (txt_SDTNCC.Text.ToArray().Length < 10 || txt_SDTNCC.Text.ToArray().Length > 10))
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
                txt_TenNCC.Clear();
                txt_DiaChiNCC.Clear();
                txt_SDTNCC.Clear();
                txt_EmailNCC.Clear();
                errorProvider1.Clear();
            }
            else
            {
                txt_MaNCC.Clear();
                txt_TenNCC.Clear();
                txt_DiaChiNCC.Clear();
                txt_SDTNCC.Clear();
                txt_EmailNCC.Clear();
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
            if (string.IsNullOrEmpty(txt_EmailNCC.Text))
            {
                errorProvider1.SetError(txt_EmailNCC, "Vui lòng điền thông tin");
            }
            else if (!IsValidEmail(txt_EmailNCC.Text))
            {
                errorProvider1.SetError(txt_EmailNCC, "Địa chỉ email không hợp lệ");
            }
            else
            {
                errorProvider1.SetError(txt_EmailNCC, "");
            }
            if (string.IsNullOrEmpty(txt_MaNCC.Text))
            {
                errorProvider1.SetError(txt_MaNCC, "Vui lòng điền thông tin");
            }
            else if (!(txt_MaNCC.Text.Length == 5 && txt_MaNCC.Text.StartsWith("NCC") == true && txt_MaNCC.Text.Substring(3).All(char.IsDigit) == true))
            {
                errorProvider1.SetError(txt_MaNCC, "Mã Nhà CC không đúng định dạng (VD: NCC00)");
            }
            else
            {
                errorProvider1.SetError(txt_MaNCC, "");
            }
            if (string.IsNullOrEmpty(txt_TenNCC.Text))
            {
                errorProvider1.SetError(txt_TenNCC, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_TenNCC, "");
            }
            if (string.IsNullOrEmpty(txt_DiaChiNCC.Text))
            {
                errorProvider1.SetError(txt_DiaChiNCC, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_DiaChiNCC, "");
            }
            if (string.IsNullOrEmpty(txt_SDTNCC.Text))
            {
                errorProvider1.SetError(txt_SDTNCC, "Vui lòng điền thông tin");
            }
            else if (txt_SDTNCC.Text.ToArray().Length < 10 || txt_SDTNCC.Text.ToArray().Length > 10)
            {
                errorProvider1.SetError(txt_SDTNCC, "Yêu cầu SĐT phải 10 chữ số");
            }
            else
            {
                errorProvider1.SetError(txt_SDTNCC, "");
            }
        }
        #endregion

        private void NCCModule_Load(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc muốn thêm thông tin nhà cung cấp này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (KT_KhoaChinh(txt_MaNCC.Text))
                        {
                            con.Open();
                            string sql = string.Format("EXEC ADDNhaCungCap '{0}', N'{1}', N'{2}', '{3}', '{4}'", txt_MaNCC.Text, txt_TenNCC.Text, txt_DiaChiNCC.Text, txt_SDTNCC.Text, txt_EmailNCC.Text);
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            NccF.getData();
                        }
                        else
                        {
                            MessageBox.Show("Trùng Mã Nhà CC", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
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

        private void txt_MaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_TenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_DiaChiNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa thông tin nhà cung cấp này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        string sql = string.Format("EXEC EDITNhaCungCap  '{0}',N'{1}', N'{2}','{3}','{4}'", txt_MaNCC.Text, txt_TenNCC.Text, txt_DiaChiNCC.Text, txt_SDTNCC.Text, txt_EmailNCC.Text);
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        NccF.getData();
                        this.Dispose();
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_EmailNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
