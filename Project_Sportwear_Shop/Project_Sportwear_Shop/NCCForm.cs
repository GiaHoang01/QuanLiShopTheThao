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
    public partial class NCCForm : Form
    {
        SqlConnection con;
        public NCCForm()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }
        #region Method
        public void getData()
        {
            try
            {
                dgv_NCC.Rows.Clear();
                string sql = "SELECT * FROM NHACUNGCAP";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dgv_NCC.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
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
            foreach (DataGridViewColumn col in dgv_NCC.Columns)
            {
                if (col.CellType != typeof(DataGridViewImageCell))
                {
                    cbb_sortsearch.Items.Add(col.HeaderText);
                }
            }
        }
        #endregion

        private void dgv_NCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NCC.SelectedRows.Count > 0)
            {
                txt_MaNCC.Text = dgv_NCC.CurrentRow.Cells[0].Value.ToString();
                txt_TenNCC.Text = dgv_NCC.CurrentRow.Cells[1].Value.ToString();
                txt_DiaChiNCC.Text = dgv_NCC.CurrentRow.Cells[2].Value.ToString();
                txt_SDTNCC.Text = dgv_NCC.CurrentRow.Cells[3].Value.ToString();
                txt_EmailNCC.Text = dgv_NCC.CurrentRow.Cells[4].Value.ToString();
                dgv_NCC.Cursor = Cursors.Hand;
            }
            else
            {
                txt_MaNCC.Clear();
                txt_TenNCC.Clear();
                txt_DiaChiNCC.Clear();
                txt_SDTNCC.Clear();
                txt_EmailNCC.Clear();
                dgv_NCC.Cursor = Cursors.Default;
            }
        }

        private void btn_AddNCC_Click(object sender, EventArgs e)
        {
            NCCModule ncc = new NCCModule(this);
            ncc.isAddMode = true;
            ncc.ShowDialog();
        }

        private void dgv_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_NCC.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                NCCModule module = new NCCModule(this);
                module.txt_MaNCC.Enabled = false;
                module.txt_MaNCC.Text = dgv_NCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TenNCC.Text = dgv_NCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_DiaChiNCC.Text = dgv_NCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_SDTNCC.Text = dgv_NCC.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_EmailNCC.Text = dgv_NCC.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txt_MaNCC.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string sql = "EXEC  DELETENhaCungCap'" + dgv_NCC.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
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
                    getData();
                }
            }
        }

        private void btn_ResetNCC_Click(object sender, EventArgs e)
        {
            txt_SearchNCC.Clear();
        }

        private void NCCForm_Load(object sender, EventArgs e)
        {
            LoadCBBSort();
            getData();
        }

        private void txt_SearchNCC_TextChanged(object sender, EventArgs e)
        {
            string search = txt_SearchNCC.Text.Trim();
            if (cbb_sortsearch.Text != "")
            {
                if (search == "")
                {
                    getData();
                }
                else
                {
                    if (cbb_sortsearch.SelectedItem.ToString() == "Mã Nhà CC")
                    {
                        dgv_NCC.Rows.Clear();
                        string sql = "SELECT * FROM NHACUNGCAP WHERE IDNHACUNGCAP LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NCC.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_sortsearch.SelectedItem.ToString() == "Tên Nhà CC")
                    {
                        dgv_NCC.Rows.Clear();
                        string sql = "SELECT * FROM NHACUNGCAP WHERE TENNHACUNGCAP LIKE N'%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NCC.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_sortsearch.SelectedItem.ToString() == "Địa Chỉ")
                    {
                        dgv_NCC.Rows.Clear();
                        string sql = "SELECT * FROM NHACUNGCAP WHERE DIACHI LIKE N'%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NCC.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_sortsearch.SelectedItem.ToString() == "SĐT")
                    {
                        dgv_NCC.Rows.Clear();
                        string sql = "SELECT * FROM NHACUNGCAP WHERE SDT LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NCC.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                        rd.Close();
                        con.Close();
                    }
                    else if (cbb_sortsearch.SelectedItem.ToString() == "Email")
                    {
                        string sql = "SELECT * FROM NHACUNGCAP WHERE EMAIL LIKE '%" + search + "%'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            dgv_NCC.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
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
