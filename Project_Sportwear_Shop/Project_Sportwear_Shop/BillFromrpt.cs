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
    public partial class BillFromrpt : Form
    {
        SqlConnection con;
        BillList bsl;
        public BillFromrpt(BillList bl)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            bsl = bl;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        string Srr = "", TenSP = "", SL = "", Sz = "", Gban = "", TT = "";
        private void BillFromrpt_Load(object sender, EventArgs e)
        {
            Srr = "";
            TenSP = "";
            SL = "";
            Sz = "";
            Gban = "";
            TT = "";
            string idhd = bsl.dgv_Bills.CurrentRow.Cells[1].Value.ToString();
            string sql = "SELECT * FROM HOADON WHERE IDHOADON = '" + idhd + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            List<Microsoft.Reporting.WinForms.ReportParameter> parameterList = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            if (rd.Read())
            {
                if (rd[6].ToString() == "Trực Tiếp")
                {
                    double tong = double.Parse(rd[8].ToString()) / (1 - (double.Parse(rd[7].ToString()) / 100));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("IDHoaDon", rd[0].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TenNhanVien", rd[2].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TenKhachHang", " "));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("SDT", " "));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("DiaChi", " "));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("NgayLapHD", rd[1].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("HinhThuc", rd[6].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TongTien", string.Format("{0:N0} VNĐ", (int)tong)));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("GiamGia", rd[7].ToString() + "%"));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("PhiShip", "0 VNĐ"));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TTienHD", string.Format("{0:N0} VNĐ", int.Parse(rd[8].ToString()))));
                }
                else
                {
                    double tong = (double.Parse(rd[8].ToString()) - 100000) / (1 - (double.Parse(rd[7].ToString()) / 100));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("IDHoaDon", rd[0].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TenNhanVien", rd[2].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TenKhachHang", rd[3].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("SDT", rd[5].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("DiaChi", rd[4].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("NgayLapHD", rd[1].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("HinhThuc", rd[6].ToString()));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TongTien", string.Format("{0:N0} VNĐ", (int)tong)));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("GiamGia", rd[7].ToString() + "%"));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("PhiShip", "100.000 VNĐ"));
                    parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TTienHD", string.Format("{0:N0} VNĐ", int.Parse(rd[8].ToString()))));
                }
            }
            rd.Close();
            string sql2 = "SELECT CHITIETHOADON.TENSANPHAM, CHITIETHOADON.SOLUONG, CHITIETHOADON.SIZE, SANPHAM.GIABAN, CHITIETHOADON.THANHTIEN FROM CHITIETHOADON, SANPHAM WHERE CHITIETHOADON.TENSANPHAM = SANPHAM.TENSANPHAM AND CHITIETHOADON.Size = SANPHAM.Size AND CHITIETHOADON.IDHOADON = '" + idhd + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            int count = 1;
            while (rd2.Read())
            {
                Srr += count.ToString() + "\n";
                TenSP += rd2[0].ToString() + "\n";
                SL += rd2[1].ToString() + "\n";
                Sz += rd2[2].ToString() + "\n";
                Gban += rd2[3].ToString() + "\n";
                TT += rd2[4].ToString() + "\n";
                count++;
            }
            rd2.Close();
            con.Close();
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("SR", Srr));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TenSanPham", TenSP));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("SoLuong", SL));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Size", Sz));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("GiaBan", Gban));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("ThanhTien", TT));
            Microsoft.Reporting.WinForms.ReportParameter[] p = parameterList.ToArray();
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Refresh();
        }
    }
}
