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
    public partial class ChonNhaCungCap : Form
    {
        SqlConnection con;
        NhapHang NH;
        public ChonNhaCungCap( NhapHang nh)
        {
            InitializeComponent();
            NH = nh;
            con = Connection.GetSqlConnection();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HoaDon()
        {
            foreach (DataGridViewRow row in NH.dgv_Inf.Rows)
            {
                if (NH.CheckSanPhamCoTonTaiKhong(row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString()) == true)
                {
                    con.Open();

                    string sqlPN = "select count(*) from phieunhap";
                    SqlCommand cmdPN = new SqlCommand(sqlPN, con);
                    int soPN = (int)cmdPN.ExecuteScalar() + 1;
                    con.Close();
                    string MaPN = "";
                    if (soPN < 10)
                    {
                        MaPN = "PN00" + soPN;
                    }
                    else if (soPN < 100)
                    {
                        MaPN = "PN0" + soPN;
                    }
                    else if (soPN < 1000)
                    {
                        MaPN = "PN" + soPN;
                    }
                    try
                    {
                        // thêm phiếu nhập
                        con.Open();
                        int tong = int.Parse(NH.lblTotal.Text.Replace(".", ""));
                        string sql = "EXEC addPhieuNhap @MaPN, @NgayNhap, @NhaCungCap, @Tong";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        // Assuming MaPN, NgayNhap, NhaCungCap, and Tong are variables with the appropriate values
                        cmd.Parameters.AddWithValue("@MaPN", MaPN);
                        cmd.Parameters.AddWithValue("@NgayNhap", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NhaCungCap", cbo_NhaCungcAP.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Tong", tong);

                        cmd.ExecuteNonQuery();
                        // thêm chi tiết phiếu nhập

                        string sql1 = "EXEC addCT_PhieuNhap '" + MaPN + "',N'" + row.Cells[1].Value.ToString() + "','" +row.Cells[2].Value.ToString() + "','" + row.Cells[3].Value.ToString() + "','" + int.Parse(row.Cells[4].Value.ToString()) + "','" + int.Parse(row.Cells[5].Value.ToString()) + "'";
                        SqlCommand cmd1 = new SqlCommand(sql1, con);
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Tạo Phiếu Nhập Thành Công");
                        this.Close();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Danh Sách Sản Phẩm Trước Khi Đặt Hàng Sản Phẩm Chưa Khởi Tạo");
                }
                NH.TinhTongChiTietHoaDon();
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            cbo_NhaCungcAP.SelectedIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HoaDon();
            NH.dgv_Inf.Rows.Clear();
            NH.TinhTongChiTietHoaDon();
        }


        void nhacungcap()
        {
            con.Open();
            string sql = "select * from NHACUNGCAP";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "NCC");
            con.Close();
            cbo_NhaCungcAP.DataSource = ds.Tables["NCC"];
            cbo_NhaCungcAP.DisplayMember = "TenNhaCungCap";
            cbo_NhaCungcAP.ValueMember = "IDNhaCungCap";
            cbo_NhaCungcAP.SelectedIndex = -1;
        }

        private void ChonNhaCungCap_Load(object sender, EventArgs e)
        {
            nhacungcap();
        }
    }
}
