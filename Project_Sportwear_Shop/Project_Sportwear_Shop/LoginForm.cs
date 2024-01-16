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
    public partial class LoginForm : Form
    {
        SqlConnection con;
        public LoginForm()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text))
            {
                try
                {
                    string id = "", name = "", role = "";
                    string sql = "SELECT NHANVIEN.IDNhanVien, NHANVIEN.TenNhanVien, NHANVIEN.ViTriCongViec FROM NHANVIEN JOIN TAIKHOAN ON NHANVIEN.IDTaiKhoan = TAIKHOAN.IDTaiKhoan WHERE TAIKHOAN.TaiKhoan = '" + txt_username.Text + "' AND TAIKHOAN.MatKhau = '" + txt_password.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        id = reader["IDNhanVien"].ToString();
                        name = reader["TenNhanVien"].ToString();
                        role = reader["ViTriCongViec"].ToString();
                        MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm main = new MainForm();
                        main.SetIDNV(id);
                        main.SetUserName(name);
                        main.SetRole(role);
                        con.Close();
                        reader.Close();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else
                    {
                        con.Close();
                        reader.Close();
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                btn_login_Click(sender, e);
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
