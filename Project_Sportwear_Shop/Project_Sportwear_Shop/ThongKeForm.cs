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
    public partial class ThongKeForm : Form
    {
        SqlConnection con;
        public ThongKeForm()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }
        void LoadDgv()
        {
            string sql = "SELECT * FROM HOADON";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dgv_hoadon.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString());
            }
            rd.Close();
            con.Close();
        }
        private void TinhTongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in dgv_hoadon.Rows)
            {
                int thanhTien;
                if (int.TryParse(row.Cells[8].Value.ToString(), out thanhTien))
                {
                    tongTien += thanhTien;
                }
            }
            lb_doanhthu.Text = tongTien.ToString("N0") + " VNĐ";
        }
        private void SoLuongDaBan()
        {
            int tongSoLuong = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT SUM(SoLuong) FROM CHITIETHOADON";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    tongSoLuong = Convert.ToInt32(result);
                }
            }
            con.Close();
            lb_daban.Text = tongSoLuong.ToString();
        }
        private void LocSoLuongDaBan()
        {
            int tongSoLuong = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sql = "DECLARE @TotalQuantity INT; " +
                             "SET @TotalQuantity = dbo.TinhTongSoLuongTheoNgay (@Tu, @Den); " +
                             "SELECT @TotalQuantity AS Tong";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Assuming dTB_Tu and dTB_Den are DateTime objects
                    cmd.Parameters.AddWithValue("@Tu", dTB_Tu.Value.ToString("yyyy-MM-dd"));  // Adjust the format as needed
                    cmd.Parameters.AddWithValue("@Den", dTB_Den.Value.ToString("yyyy-MM-dd"));

                    int result = (int)cmd.ExecuteScalar();
                    tongSoLuong = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log it, or show an error message.
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            lb_daban.Text = tongSoLuong.ToString();
        }
        void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý bán hàng";

                // export header trong DataGridView
                for (int i = 0; i < dgv_hoadon.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv_hoadon.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dgv_hoadon.RowCount; i++)
                {
                    for (int j = 0; j < dgv_hoadon.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv_hoadon.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            dgv_hoadon.ReadOnly = true;
            dgv_hoadon.AllowUserToAddRows = false;
            dgv_hoadon.Rows.Clear();
            LoadDgv();
            TinhTongTien();
            SoLuongDaBan();
        }

        private void btn_xuatExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgv_hoadon, saveFileDialog1.FileName);
            }
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            dgv_hoadon.Rows.Clear();
            // Assuming dTB_Tu and dTB_Den are DateTimePicker controls
            string startDate = dTB_Tu.Value.ToString("yyyy-MM-dd");
            string endDate = dTB_Den.Value.ToString("yyyy-MM-dd");

            string sql = "SELECT * FROM dbo.ThongKeTheoNgay('" + startDate + "', '" + endDate + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dgv_hoadon.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString());
            }
            rd.Close();

            TinhTongTien();
            LocSoLuongDaBan();
        }

    }
}
