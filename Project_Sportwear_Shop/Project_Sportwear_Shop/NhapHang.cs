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
using System.Drawing.Drawing2D;
using System.Globalization;

namespace Project_Sportwear_Shop
{
    public partial class NhapHang : Form
    {
        SqlConnection con;
        public NhapHang()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }
        private void AddHang()
        {
            string sql = "SELECT DISTINCT TENHANG FROM HANGSANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            HangSanPham.Controls.Clear();
            Button d = new Button();
            d.BackColor = Color.FromArgb(50, 55, 89);
            d.Size = new Size(158, 45);
            d.Text = "All Categories";
            d.Cursor = Cursors.Hand;
            d.FlatAppearance.BorderSize = 0;
            d.Font = new Font("Tahoma", 12);
            d.ForeColor = Color.White;
            d.FlatStyle = FlatStyle.Flat;

            d.Click += new EventHandler(b_Click);

            HangSanPham.Controls.Add(d);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Button b = new Button();
                    b.BackColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(158, 45);
                    b.Text = row["TENHANG"].ToString();
                    b.Cursor = Cursors.Hand;
                    b.FlatAppearance.BorderSize = 0;
                    b.Font = new Font("Tahoma", 12);
                    b.ForeColor = Color.White;
                    b.FlatStyle = FlatStyle.Flat;

                    b.Click += new EventHandler(b_Click);

                    HangSanPham.Controls.Add(b);
                }
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }
            foreach (var item in NhapHangSanPham.Controls)
            {
                var pro = (SanPhamNhap)item;
                pro.Visible = pro.TenHang.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }
        private void AddItems(string tensp, string cat, Image pimage)
        {
            var w = new SanPhamNhap(this)
            {
                TenSanPham = tensp,
                TenHang = cat,
                AnhSanPham = pimage,
            };
            NhapHangSanPham.Controls.Add(w);
        }
        private void ShowSanPham()
        {
            string sql = @"SELECT SANPHAM.TenSanPham, HANGSANPHAM.TenHang, SANPHAM.GiaBan, SANPHAM.HinhAnh
                            FROM SANPHAM
                            INNER JOIN HANGSANPHAM ON SANPHAM.IDHANGSANPHAM = HANGSANPHAM.IDHANGSANPHAM
                            GROUP BY SANPHAM.TenSanPham, HANGSANPHAM.TenHang, SANPHAM.GiaBan, SANPHAM.HinhAnh";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Image imagePath = Image.FromFile(rd["HinhAnh"].ToString());
                AddItems(rd["TenSanPham"].ToString(), rd["TenHang"].ToString(), imagePath);
            }
            rd.Close();
            con.Close();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            AddHang();
            NhapHangSanPham.Controls.Clear();
            ShowSanPham();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in NhapHangSanPham.Controls)
            {
                var pro = (SanPhamNhap)item;
                pro.Visible = pro.TenSanPham.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }
        public void TinhTongChiTietHoaDon()
        {
            int sum = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow temp in dgv_Inf.Rows)
            {
                string valueString = temp.Cells[5].Value.ToString().Replace(",", ".");

                sum += int.Parse(valueString);
            }
            lblTotal.Text = sum.ToString("N0");
        }
        private void dgv_Inf_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv_Inf.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public bool CheckSanPhamCoTonTaiKhong(string tenSanPham,string size)
        {
            string sql = " select count(*) from SANPHAM WHERE TENSANPHAM=N'"+tenSanPham+"' AND SIZE ='"+size+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int check = (int)cmd.ExecuteScalar();
            if(check==0)
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
          
            if(dgv_Inf.Rows.Count<=0)
            {
                MessageBox.Show("Chưa Thêm Các Sản Phẩm Cần Mua Vào Hóa Đơn Nên Chưa Thể Tạo");
            }
            else
            {
                ChonNhaCungCap temp = new ChonNhaCungCap(this);
                temp.Show();
            }
        }

        public void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Inf.CurrentRow != null)
            {
                dgv_Inf.Rows.Remove(dgv_Inf.CurrentRow);
                TinhTongChiTietHoaDon();
            }
        }
        //Làm Nút Hình tròn
        private void MakeButtonRound(Button button)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(buttonPath);
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            dgv_Inf.Rows.Clear();
            lblTotal.Text = "0.00";
        }

        private void btn_HoaDonNhap_Click(object sender, EventArgs e)
        {
            DanhSachPhieuNhap temp = new DanhSachPhieuNhap();
            temp.ShowDialog();
        }

    }
}
