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

namespace Project_Sportwear_Shop
{
    public partial class DanhSachPhieuNhap : Form
    {
        SqlConnection con;
        public DanhSachPhieuNhap()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }

        private void DanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            string sql = "select * from PHIEUNHAP";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            int i = 0;
            while(rd.Read())
            {
                i++;
                dgv_PhieuNhap.Rows.Add(i,rd["IDPhieuNhap"].ToString(), rd["NGAYNHAP"].ToString(), rd["IDNhaCungCap"].ToString(), rd["TIENNHAP"].ToString());
            }
            dgv_PhieuNhap.AllowUserToAddRows = false;
            con.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_PhieuNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv_PhieuNhap.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void dgv_PhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_PhieuNhap.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM ChiTiet_PN WHERE IDPhieuNhap = '" + dgv_PhieuNhap.CurrentRow.Cells[1].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    string sql2 = "DELETE FROM PHIEUNHAP WHERE IDPhieuNhap = '" + dgv_PhieuNhap.CurrentRow.Cells[1].Value.ToString() + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    dgv_PhieuNhap.Rows.Remove(dgv_PhieuNhap.CurrentRow);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Details")
            {
                ChiTietPN ct = new ChiTietPN(this);
                ct.ShowDialog();
            }
            else if (colName == "Print")
            {
                BillsPhieuNhap frm = new BillsPhieuNhap(this);
                frm.ShowDialog();
            }
        }
    }
}
