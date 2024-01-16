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
using System.IO;

namespace Project_Sportwear_Shop
{
    public partial class BanHangForm : Form
    {
        SqlConnection con;
        public string OderType;
        public BanHangForm()
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Method
        private void AddCategory()
        {
            string sql = "SELECT DISTINCT TENHANG FROM HANGSANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CategoryPanel.Controls.Clear();
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

            CategoryPanel.Controls.Add(d);
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

                    CategoryPanel.Controls.Add(b);
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
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory1.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }
        private void AddItems(string tensp, string cat, int gia, Image pimage)
        {
            var w = new ucProduct(this)
            {
                //IdSP1 = idsp,
                TenSP = tensp,
                PCategory1 = cat,
                GiaBan1 = gia,
                PImage = pimage
            };
            ProductPanel.Controls.Add(w);
        }
        private void LoadProducts()
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
                Image img = Image.FromFile(rd["HinhAnh"].ToString());
                AddItems(rd["TENSANPHAM"].ToString(), rd["TENHANG"].ToString(), int.Parse(rd["GiaBan"].ToString()), img);
            }
            rd.Close();
            con.Close();
        }
        public void GetTotal()
        {
            int sum = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in dgv_Inf.Rows)
            {
                sum += int.Parse(item.Cells[5].Value.ToString());
            }
            lblTotal.Text = sum.ToString("N0");
        }
        public string LoadMaHD()
        {
            string sql = "SELECT TOP 1 IDHOADON FROM HOADON ORDER BY IDHOADON DESC";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            string MaHDAuto = "";
            if (rd.Read())
            {
                int lastID = int.Parse(rd["IDHOADON"].ToString().Substring(2));
                int lastNumber = lastID + 1;
                if (lastID >= 1 && lastID <= 9)
                {
                    MaHDAuto = "HD" + lastNumber.ToString("D3");
                }
                else if (lastID >= 10 && lastID <= 99)
                {
                    MaHDAuto = "HD" + lastNumber.ToString("D3");
                }
                else if (lastID >= 100 && lastID <= 999)
                {
                    MaHDAuto = "HD" + lastNumber.ToString("D3");
                }
            }
            else
            {
                MaHDAuto = "HD001";
            }
            rd.Close();
            con.Close();
            return MaHDAuto;
        }
        public string GetTenKH(string ma)
        {
            return ma;
        }
        public string GetDiaChi(string ma)
        {
            return ma;
        }
        public string GetSDT(string ma)
        {
            return ma;
        }
        public void btnClear()
        {
            btn_takeaw.ForeColor = Color.White;
            btn_deli.ForeColor = Color.White;
        }
        #endregion

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            AddCategory();
            AddCategory();
            ProductPanel.Controls.Clear();
            LoadProducts();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.TenSP.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            dgv_Inf.Rows.Clear();
            OderType = null;
            btnClear();
            lblTotal.Text = "0.00";
            chk_Discount.Checked = false;
        }

        private void btn_takeaw_Click(object sender, EventArgs e)
        {
            if (btn_takeaw.ForeColor == Color.DarkGreen)
            {
                btnClear();
                OderType = null;
            }
            else
            {
                btnClear();
                btn_takeaw.ForeColor = Color.DarkGreen;
                OderType = "Trực Tiếp";
            }
        }

        private void btn_deli_Click(object sender, EventArgs e)
        {
            if (btn_deli.ForeColor == Color.DarkGreen)
            {
                btnClear();
                OderType = null;
            }
            else
            {
                btnClear();
                btn_deli.ForeColor = Color.DarkGreen;
                OderType = "Giao Hàng";
            }
        }

        private void dgv_Inf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Inf.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgv_Inf.Rows.Remove(dgv_Inf.Rows[e.RowIndex]);
                    GetTotal();
                }
            }
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            if (dgv_Inf.RowCount > 0)
            {
                if (OderType != null)
                {
                    if (OderType == "Trực Tiếp")
                    {
                        string id;
                        id = LoadMaHD();
                        if (chk_Discount.Checked)
                        {
                            if (txtGiamGia.Text != "" && int.Parse(txtGiamGia.Text) < 100)
                            {
                                int tong = int.Parse(lblTotal.Text.Replace(".", ""));
                                double discount = (double)tong - ((double)tong * (double.Parse(txtGiamGia.Text) / 100));
                                string sql = "INSERT INTO HOADON(IDHOADON, NGAYLAPHD, IDNHANVIEN, HINHTHUC, GIAMGIA, THANHTIEN) VALUES (@IDHOADON, @NGAYLAPHD, @IDNHANVIEN, @HINHTHUC, @GiamGia, @ThanhTien)";
                                SqlCommand cmd = new SqlCommand(sql, con);

                                cmd.Parameters.AddWithValue("@IDHOADON", LoadMaHD());
                                cmd.Parameters.AddWithValue("@NGAYLAPHD", DateTime.Now);
                                cmd.Parameters.AddWithValue("@IDNHANVIEN", lblIDNV.Text);
                                cmd.Parameters.AddWithValue("@HINHTHUC", OderType);
                                cmd.Parameters.AddWithValue("@GiamGia", txtGiamGia.Text);
                                cmd.Parameters.AddWithValue("@ThanhTien", (int)discount);

                                con.Open();

                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Thêm thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                foreach (DataGridViewRow item in dgv_Inf.Rows)
                                {
                                    string sql2 = string.Format("INSERT INTO CHITIETHOADON VALUES ('{0}', N'{1}', {2}, '{3}', {4})", id, item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[5].Value.ToString());
                                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                                    con.Open();
                                    cmd2.ExecuteNonQuery();
                                    string sql4 = string.Format("SELECT SoLuongTon FROM SANPHAM WHERE TENSANPHAM = N'{0}' AND SIZE = '{1}'", item.Cells[1].Value.ToString(), item.Cells[3].Value.ToString());
                                    SqlCommand cmd4 = new SqlCommand(sql4, con);
                                    SqlDataReader rd = cmd4.ExecuteReader();
                                    int slton = 0;
                                    if (rd.Read())
                                    {
                                        slton += int.Parse(rd["SoLuongTon"].ToString());
                                    }
                                    rd.Close();
                                    string sql3;
                                    if ((slton - int.Parse(item.Cells[2].Value.ToString())) != 0)
                                    {
                                        sql3 = string.Format("UPDATE SANPHAM SET SoLuongTon = {0}, TinhTrang = N'{1}' WHERE TENSANPHAM = N'{2}' AND SIZE = '{3}'", slton - int.Parse(item.Cells[2].Value.ToString()), "Còn Hàng", item.Cells[1].Value.ToString(), item.Cells[3].Value.ToString());
                                    }
                                    else
                                    {
                                        sql3 = string.Format("UPDATE SANPHAM SET SoLuongTon = {0}, TinhTrang = N'{1}' WHERE TENSANPHAM = N'{2}' AND SIZE = '{3}'", slton - int.Parse(item.Cells[2].Value.ToString()), "Hết Hàng", item.Cells[1].Value.ToString(), item.Cells[3].Value.ToString());
                                    }
                                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                                    cmd3.ExecuteNonQuery();
                                    con.Close();
                                }
                                btn_new_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập giảm giá và trong khoảng (1-100)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            int tong = int.Parse(lblTotal.Text.Replace(".", ""));
                            string sql = "INSERT INTO HOADON(IDHOADON, NGAYLAPHD, IDNHANVIEN, HINHTHUC, GIAMGIA, THANHTIEN) VALUES (@IDHOADON, @NGAYLAPHD, @IDNHANVIEN, @HINHTHUC, @GiamGia, @ThanhTien)";
                            SqlCommand cmd = new SqlCommand(sql, con);

                            cmd.Parameters.AddWithValue("@IDHOADON", LoadMaHD());
                            cmd.Parameters.AddWithValue("@NGAYLAPHD", DateTime.Now);
                            cmd.Parameters.AddWithValue("@IDNHANVIEN", lblIDNV.Text);
                            cmd.Parameters.AddWithValue("@HINHTHUC", OderType);
                            cmd.Parameters.AddWithValue("@GiamGia", txtGiamGia.Text);
                            cmd.Parameters.AddWithValue("@ThanhTien", tong);

                            con.Open();

                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Thêm thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            foreach (DataGridViewRow item in dgv_Inf.Rows)
                            {
                                string sql2 = string.Format("INSERT INTO CHITIETHOADON VALUES ('{0}', N'{1}', {2}, '{3}', {4})", id, item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[5].Value.ToString());
                                SqlCommand cmd2 = new SqlCommand(sql2, con);
                                con.Open();
                                cmd2.ExecuteNonQuery();
                                string sql4 = string.Format("SELECT SoLuongTon FROM SANPHAM WHERE TENSANPHAM = N'{0}' AND SIZE = '{1}'", item.Cells[1].Value.ToString(), item.Cells[3].Value.ToString());
                                SqlCommand cmd4 = new SqlCommand(sql4, con);
                                SqlDataReader rd = cmd4.ExecuteReader();
                                int slton = 0;
                                if (rd.Read())
                                {
                                    slton += int.Parse(rd["SoLuongTon"].ToString());
                                }
                                rd.Close();
                                string sql3;
                                if ((slton - int.Parse(item.Cells[2].Value.ToString())) != 0)
                                {
                                    sql3 = string.Format("UPDATE SANPHAM SET SoLuongTon = {0}, TinhTrang = N'{1}' WHERE TENSANPHAM = N'{2}' AND SIZE = '{3}'", slton - int.Parse(item.Cells[2].Value.ToString()), "Còn Hàng", item.Cells[1].Value.ToString(), item.Cells[3].Value.ToString());
                                }
                                else
                                {
                                    sql3 = string.Format("UPDATE SANPHAM SET SoLuongTon = {0}, TinhTrang = N'{1}' WHERE TENSANPHAM = N'{2}' AND SIZE = '{3}'", slton - int.Parse(item.Cells[2].Value.ToString()), "Hết Hàng", item.Cells[1].Value.ToString(), item.Cells[3].Value.ToString());
                                }
                                SqlCommand cmd3 = new SqlCommand(sql3, con);
                                cmd3.ExecuteNonQuery();
                                con.Close();
                            }
                            btn_new_Click(sender, e);
                        }
                    }
                    else
                    {
                        OderDelivery odd = new OderDelivery(this);
                        odd.ShowDialog();
                        btn_new_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hình thức trực tiếp hoặc giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void chk_Discount_CheckedChanged(object sender, EventArgs e)
        {
            txtGiamGia.Enabled = chk_Discount.Checked;
            if (!chk_Discount.Checked)
            {
                txtGiamGia.Clear();
            }
            else
            {
                txtGiamGia.Text = "1";
                txtGiamGia.Focus();
            }
        }
        private void btn_bill_Click(object sender, EventArgs e)
        {
            BillList bl = new BillList();
            bl.ShowDialog();
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }
    }
}
