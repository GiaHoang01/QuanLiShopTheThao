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
    public partial class BillsPhieuNhap : Form
    {
        SqlConnection con;
        DanhSachPhieuNhap bPN;
        public BillsPhieuNhap(DanhSachPhieuNhap pn)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            bPN = pn;
        }
        string Srr = "", TenSP = "", SL = "", Sz = "", Gnhap = "", TT = "";
        private void BillsPhieuNhap_Load(object sender, EventArgs e)
        {
            string idPN = bPN.dgv_PhieuNhap.CurrentRow.Cells[1].Value.ToString();
            string sql = "select * from phieunhap join NHACUNGCAP on PHIEUNHAP.IDNhaCungCap=NHACUNGCAP.IDNhaCungCap WHERE IDPHIEUNHAP = '" + idPN + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            List<Microsoft.Reporting.WinForms.ReportParameter> parameterList = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            if (rd.Read())
            {
                parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("IDPhieuNhap", rd["IDPhieuNhap"].ToString()));
                parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("NgayNhap", rd["NGAYNHAP"].ToString()));
                parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TenNhaCungCap", rd["TenNhaCungCap"].ToString()));
                parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("ThanhToan", string.Format("{0:N0} VNĐ", int.Parse(rd["TIENNHAP"].ToString()))));
                parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("DiaChi", rd["DiaChi"].ToString()));
                parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("SDT", rd["SDT"].ToString()));
                parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Email", rd["EMAIL"].ToString()));
            }

            rd.Close();
            string sql2 = "SELECT * FROM ChiTiet_PN join SANPHAM on ChiTiet_PN.TenSanPham=SANPHAM.TenSanPham and ChiTiet_PN.Size=SANPHAM.Size WHERE  ChiTiet_PN.IDPhieuNhap = '" + idPN + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            int count = 1;
            while (rd2.Read())
            {
                Srr += count.ToString() + "\n";
                TenSP += rd2["TenSanPham"].ToString() + "\n";
                SL += rd2["SOLUONG"].ToString() + "\n";
                Sz += rd2["Size"].ToString() + "\n";
                Gnhap += rd2["GIANHAP"].ToString() + "\n";
                TT += rd2["THANHTIEN"].ToString() + "\n";
                count++;
            }
            rd2.Close();
            con.Close();
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("SR", Srr));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("TenSanPham", TenSP));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("SoLuong", SL));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("Size", Sz));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("GiaNhap", Gnhap));
            parameterList.Add(new Microsoft.Reporting.WinForms.ReportParameter("ThanhTien", TT));
            Microsoft.Reporting.WinForms.ReportParameter[] p = parameterList.ToArray();
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Refresh();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
