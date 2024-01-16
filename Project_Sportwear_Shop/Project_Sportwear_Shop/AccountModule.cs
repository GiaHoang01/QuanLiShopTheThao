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
    public partial class AccountModule : Form
    {
        public bool isAddMode = false;
        SqlConnection con;
        AccountForm acF;
        public AccountModule(AccountForm af)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            acF = af;
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
                lblTittle.Text = "THÊM THÔNG TIN TÀI KHOẢN";
            }
            else
            {
                // Ngược lại, làm mờ nút Sửa và hiển thị nút Thêm
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN TÀI KHOẢN";
            }
        }
        public void Clear()
        {
            if (btn_sua.Enabled)
            {
                txt_TK.Clear();
                txt_MK.Clear();
                errorProvider1.Clear();
            }
            else
            {
                txt_IDTK.Clear();
                txt_TK.Clear();
                txt_MK.Clear();
                errorProvider1.Clear();
            }
        }
        public bool KT_KhoaChinh (string ma)
        {
            con.Open();
            string sql = "SELECT * FROM TAIKHOAN WHERE IDTAIKHOAN = '" + ma + "'";
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
        public bool KT_TenTK(string tk)
        {
            con.Open();
            string sql = "SELECT * FROM TAIKHOAN WHERE TAIKHOAN = '" + tk + "'";
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
            if (string.IsNullOrEmpty(txt_IDTK.Text) || string.IsNullOrEmpty(txt_TK.Text) || string.IsNullOrEmpty(txt_MK.Text))
            {
                return false;
            }
            else
            {
                if (!(txt_IDTK.Text.Length == 5 && txt_IDTK.Text.StartsWith("TK") == true && txt_IDTK.Text.Substring(2).All(char.IsDigit) == true))
                {
                    return false;
                }
            }
            return true;
        }
        public void CheckErrorProvider()
        {
            if (string.IsNullOrEmpty(txt_IDTK.Text))
            {
                errorProvider1.SetError(txt_IDTK, "Vui lòng điền thông tin");
            }
            else if (!(txt_IDTK.Text.Length == 5 && txt_IDTK.Text.StartsWith("TK") == true && txt_IDTK.Text.Substring(2).All(char.IsDigit) == true))
            {
                errorProvider1.SetError(txt_IDTK, "ID Tài Khoản không đúng định dạng (VD: TK000)");
            }
            else
            {
                errorProvider1.SetError(txt_IDTK, "");
            }
            if (string.IsNullOrEmpty(txt_TK.Text))
            {
                errorProvider1.SetError(txt_TK, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_TK, "");
            }
            if (string.IsNullOrEmpty(txt_MK.Text))
            {
                errorProvider1.SetError(txt_MK, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_MK, "");
            }
        }
        #endregion

        private void AccountModule_Load(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc muốn thêm thông tin tài khoản này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (KT_KhoaChinh(txt_IDTK.Text))
                        {
                            if (KT_TenTK(acF.dgv_TK.CurrentRow.Cells[1].Value.ToString()))
                            {
                                string sql = string.Format("INSERT INTO TAIKHOAN VALUES ('{0}', '{1}', '{2}')", txt_IDTK.Text, txt_TK.Text, txt_MK.Text);
                                SqlCommand cmd = new SqlCommand(sql, con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                acF.getData();
                            }
                            else
                            {
                                MessageBox.Show("Trùng Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Trùng ID Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_IDTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_TK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa thông tin tài khoản này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = string.Format("UPDATE TAIKHOAN SET TAIKHOAN = '{0}', MATKHAU = '{1}' WHERE IDTAIKHOAN = '{2}'", txt_TK.Text, txt_MK.Text, txt_IDTK.Text);
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        acF.getData();
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
    }
}
