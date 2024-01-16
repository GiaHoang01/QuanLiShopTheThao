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
    public partial class ChiTietPN : Form
    {

        SqlConnection con;
        DanhSachPhieuNhap temp;
        public ChiTietPN(DanhSachPhieuNhap dsPN)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            temp = dsPN;
        }


        public void loadChiTietPhieuNhap()
        {
            string idPN = temp.dgv_PhieuNhap.CurrentRow.Cells[1].Value.ToString();
            string sql = "select * FROM PHIEUNHAP INNER JOIN NHACUNGCAP ON NHACUNGCAP.IDNhaCungCap=PHIEUNHAP.IDNhaCungCap inner join ChiTiet_PN on ChiTiet_PN.IDPhieuNhap=PHIEUNHAP.IDPhieuNhap where PHIEUNHAP.IDPhieuNhap='" + idPN + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            double tong=0;
            if (rd.Read())
            {
                tong += double.Parse(rd["THANHTIEN"].ToString());
                lblMaPN.Text = rd["IDPhieuNhap"].ToString();
                lblTenNCC.Text = rd["TenNhaCungCap"].ToString();
                lbl_SDT.Text = rd["SDT"].ToString();
                lbl_Email.Text = rd["EMAIL"].ToString();
                lblNgayNhap.Text = rd["NGAYNHAP"].ToString();
                lbl_DiaChi.Text = rd["DIACHI"].ToString();
            }
            con.Close();
            lblTongTien.Text = string.Format("{0:N0} VNĐ", (int)tong);
            // Chi tiết phiếu nhập 
            string sqlCT = "SELECT * FROM ChiTiet_PN  where IDPhieuNhap='" + idPN + "'";
            SqlCommand cmdCT = new SqlCommand(sqlCT, con);
            con.Open();
            SqlDataReader rdCT = cmd.ExecuteReader();
            int count = 0;
            while(rdCT.Read())
            {
                count++;
                dgv_Bills.Rows.Add(count,rdCT["TenSanPham"].ToString(),rdCT["SOLUONG"].ToString(),rdCT["Size"].ToString(),rdCT["GIANHAP"].ToString(),rdCT["THANHTIEN"].ToString());
            }
            rdCT.Close();
            con.Close();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ChiTietPN_Load(object sender, EventArgs e)
        {
            dgv_Bills.Rows.Clear();
            loadChiTietPhieuNhap();
        }
    }
}
