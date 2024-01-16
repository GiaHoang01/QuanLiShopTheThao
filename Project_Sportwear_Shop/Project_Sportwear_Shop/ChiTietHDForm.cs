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
    public partial class ChiTietHDForm : Form
    {
        SqlConnection con;
        BillList bsl;
        public ChiTietHDForm(BillList bl)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            bsl = bl;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region Method
        private void LoadCTHD()
        {
            string idhd = bsl.dgv_Bills.CurrentRow.Cells[1].Value.ToString();
            string sql = "SELECT * FROM HOADON WHERE IDHOADON = '" + idhd + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                if (rd[6].ToString() == "Trực Tiếp")
                {
                    double tong = double.Parse(rd[8].ToString()) / (1 - (double.Parse(rd[7].ToString()) / 100));
                    lblMaHD.Text = rd[0].ToString();
                    lblIDNV.Text = rd[2].ToString();
                    lblTenKH.Text = "";
                    lblSDT.Text = "";
                    lblDiaChi.Text = "";
                    lblNgayMua.Text = rd[1].ToString();
                    lblHinhThuc.Text = rd[6].ToString();
                    lblTongTien.Text = string.Format("{0:N0} VNĐ", (int)tong);
                    lblGiamGia.Text = rd[7].ToString() + "%";
                    lblShip.Text = "0 VNĐ";
                    lblThanhTien.Text = string.Format("{0:N0} VNĐ", int.Parse(rd[8].ToString()));
                }
                else
                {
                    double tong = (double.Parse(rd[8].ToString()) - 100000) / (1 - (double.Parse(rd[7].ToString()) / 100));
                    lblMaHD.Text = rd[0].ToString();
                    lblIDNV.Text = rd[2].ToString();
                    lblTenKH.Text = rd[3].ToString();
                    lblSDT.Text = rd[5].ToString();
                    lblDiaChi.Text = rd[4].ToString();
                    lblNgayMua.Text = rd[1].ToString();
                    lblHinhThuc.Text = rd[6].ToString();
                    lblTongTien.Text = string.Format("{0:N0} VNĐ", (int)tong);
                    lblGiamGia.Text = rd[7].ToString() + "%";
                    lblShip.Text = "100.000 VNĐ";
                    lblThanhTien.Text = string.Format("{0:N0} VNĐ", int.Parse(rd[8].ToString()));
                }
            }
            rd.Close();
            string sql2 = "SELECT CHITIETHOADON.TENSANPHAM, CHITIETHOADON.SOLUONG, CHITIETHOADON.SIZE, SANPHAM.GIABAN, CHITIETHOADON.THANHTIEN FROM CHITIETHOADON, SANPHAM WHERE CHITIETHOADON.TENSANPHAM = SANPHAM.TENSANPHAM AND CHITIETHOADON.Size = SANPHAM.Size AND CHITIETHOADON.IDHOADON = '" + idhd + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            int count = 0;
            while(rd2.Read())
            {
                count++;
                dgv_Bills.Rows.Add(count, rd2[0].ToString(), rd2[1].ToString(), rd2[2].ToString(), rd2[3].ToString(), rd2[4].ToString());
            }
            rd2.Close();
            con.Close();
        }
        #endregion

        private void ChiTietHDForm_Load(object sender, EventArgs e)
        {
            dgv_Bills.Rows.Clear();
            LoadCTHD();
        }
    }
}