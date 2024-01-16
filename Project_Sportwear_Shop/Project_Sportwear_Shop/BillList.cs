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
    public partial class BillList : Form
    {
        SqlConnection con;
        public BillList()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region Method
        private void LoadBills()
        {
            string sql = "SELECT IDHOADON, NGAYLAPHD, IDNHANVIEN, HINHTHUC, THANHTIEN FROM HOADON";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dgv_Bills.Rows.Add(0, rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
            }
            rd.Close();
            con.Close();
        }
        #endregion

        private void BillList_Load(object sender, EventArgs e)
        {
            dgv_Bills.Rows.Clear();
            LoadBills();
        }

        private void dgv_Bills_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv_Bills.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void dgv_Bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Bills.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM CHITIETHOADON WHERE IDHOADON = '" + dgv_Bills.CurrentRow.Cells[1].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    string sql2 = "DELETE FROM HOADON WHERE IDHOADON = '" + dgv_Bills.CurrentRow.Cells[1].Value.ToString() + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    dgv_Bills.Rows.Remove(dgv_Bills.CurrentRow);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Details")
            {
                ChiTietHDForm ct = new ChiTietHDForm(this);
                ct.ShowDialog();
            }
            else if (colName == "Print")
            {
                BillFromrpt frm = new BillFromrpt(this);
                frm.ShowDialog();
            }
        }
    }
}
