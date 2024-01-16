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
    public partial class AccountForm : Form
    {
        SqlConnection con;
        public AccountForm()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }
        #region Method
        public void getData()
        {
            try
            {
                dgv_TK.Rows.Clear();
                string sql = "SELECT * FROM TAIKHOAN";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dgv_TK.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
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
            cbb_sortsearch.Items.Clear();
            foreach (DataGridViewColumn col in dgv_TK.Columns)
            {
                if (col.CellType != typeof(DataGridViewImageCell))
                {
                    cbb_sortsearch.Items.Add(col.HeaderText);
                }
            }
        }
        #endregion

        private void AccountForm_Load(object sender, EventArgs e)
        {
            getData();
            LoadCBBSort();
        }

        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            txt_SearchTK.Clear();
        }

        private void dgv_TK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_TK.SelectedRows.Count > 0)
            {
                txt_IDTK.Text = dgv_TK.CurrentRow.Cells[0].Value.ToString();
                txt_TK.Text = dgv_TK.CurrentRow.Cells[1].Value.ToString();
                txt_MK.Text = dgv_TK.CurrentRow.Cells[2].Value.ToString();
                dgv_TK.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDTK.Clear();
                txt_TK.Clear();
                txt_MK.Clear();
                dgv_TK.Cursor = Cursors.Default;
            }
        }

        private void btn_AddTK_Click(object sender, EventArgs e)
        {
            AccountModule acc = new AccountModule(this);
            acc.isAddMode = true;
            acc.ShowDialog();
        }

        private void dgv_TK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_TK.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AccountModule module = new AccountModule(this);
                module.txt_IDTK.Enabled = false;
                module.txt_IDTK.Text = dgv_TK.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TK.Text = dgv_TK.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_MK.Text = dgv_TK.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_TK.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sql = string.Format("DELETE FROM TAIKHOAN WHERE IDTAIKHOAN = '{0}'", dgv_TK.Rows[e.RowIndex].Cells[0].Value.ToString());
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
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
                    getData();
                }
            }
        }

        private void txt_SearchTK_TextChanged(object sender, EventArgs e)
        {
            string search = txt_SearchTK.Text.Trim();
            if (cbb_sortsearch.Text != "")
            {
                if (search == "")
                {
                    getData();
                }
                else
                {
                    if (cbb_sortsearch.SelectedItem.ToString() == "ID Tài Khoản")
                    {
                        dgv_TK.Rows.Clear();
                        string sql = "SELECT * FROM TAIKHOAN WHERE IDTAIKHOAN LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while(rd.Read())
                        {
                            dgv_TK.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_sortsearch.SelectedItem.ToString() == "Tài Khoản")
                    {
                        dgv_TK.Rows.Clear();
                        string sql = "SELECT * FROM TAIKHOAN WHERE TAIKHOAN LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_TK.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_sortsearch.SelectedItem.ToString() == "Mật Khẩu")
                    {
                        dgv_TK.Rows.Clear();
                        string sql = "SELECT * FROM TAIKHOAN WHERE MATKHAU LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_TK.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
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
