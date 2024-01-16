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
    public partial class OderDelivery : Form
    {
        SqlConnection con;
        BanHangForm BHF;
        public OderDelivery(BanHangForm bf)
        {
            InitializeComponent();
            con = Connection.GetSqlConnection();
            BHF = bf;
        }

        private void txt_TenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_TenKH.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            errorProvider1.Clear();
        }
        public void CheckErrorProvider()
        {
            if (string.IsNullOrEmpty(txt_TenKH.Text))
            {
                errorProvider1.SetError(txt_TenKH, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_TenKH, "");
            }
            if (string.IsNullOrEmpty(txt_DiaChi.Text))
            {
                errorProvider1.SetError(txt_DiaChi, "Vui lòng điền thông tin");
            }
            else
            {
                errorProvider1.SetError(txt_DiaChi, "");
            }
            if (txt_SDT.Text.ToArray().Length < 10 || txt_SDT.Text.ToArray().Length > 10)
            {
                errorProvider1.SetError(txt_SDT, "Yêu cầu SĐT phải 10 chữ số");
            }
            else
            {
                errorProvider1.SetError(txt_SDT, "");
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TenKH.Text) && !string.IsNullOrEmpty(txt_DiaChi.Text) && !string.IsNullOrEmpty(txt_SDT.Text) && txt_SDT.Text.ToArray().Length == 10)
            {
                string id;
                id = BHF.LoadMaHD();
                if (BHF.chk_Discount.Checked)
                {
                    if (BHF.txtGiamGia.Text != "" && int.Parse(BHF.txtGiamGia.Text) < 100)
                    {
                        int tong = int.Parse(BHF.lblTotal.Text.Replace(",", ""));
                        double discount = (double)tong - ((double)tong * (double.Parse(BHF.txtGiamGia.Text) / 100));
                        string sql = "INSERT INTO HOADON VALUES (@IDHOADON, @NGAYLAPHD, @IDNHANVIEN, @TENKHACHHANG, @DIACHI, @SDT, @HINHTHUC, @GiamGia, @ThanhTien)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        id = BHF.LoadMaHD();
                        cmd.Parameters.AddWithValue("@IDHOADON", BHF.LoadMaHD());
                        cmd.Parameters.AddWithValue("@NGAYLAPHD", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IDNHANVIEN", BHF.lblIDNV.Text);
                        cmd.Parameters.AddWithValue("@TENKHACHHANG", txt_TenKH.Text);
                        cmd.Parameters.AddWithValue("@DIACHI", txt_DiaChi.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@HINHTHUC", BHF.OderType);
                        cmd.Parameters.AddWithValue("@GiamGia", BHF.txtGiamGia.Text);
                        cmd.Parameters.AddWithValue("@ThanhTien", (int)discount + 100000);

                        con.Open();

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Thêm thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (DataGridViewRow item in BHF.dgv_Inf.Rows)
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
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập giảm giá và trong khoảng (1-100)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    int tong = int.Parse(BHF.lblTotal.Text.Replace(".", ""));
                    string sql = "INSERT INTO HOADON VALUES (@IDHOADON, @NGAYLAPHD, @IDNHANVIEN, @TENKHACHHANG, @DIACHI, @SDT, @HINHTHUC, @GiamGia, @ThanhTien)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    id = BHF.LoadMaHD();
                    cmd.Parameters.AddWithValue("@IDHOADON", BHF.LoadMaHD());
                    cmd.Parameters.AddWithValue("@NGAYLAPHD", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IDNHANVIEN", BHF.lblIDNV.Text);
                    cmd.Parameters.AddWithValue("@TENKHACHHANG", txt_TenKH.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txt_DiaChi.Text);
                    cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                    cmd.Parameters.AddWithValue("@HINHTHUC", BHF.OderType);
                    cmd.Parameters.AddWithValue("@GiamGia", BHF.txtGiamGia.Text);
                    cmd.Parameters.AddWithValue("@ThanhTien", tong + 100000);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataGridViewRow item in BHF.dgv_Inf.Rows)
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
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CheckErrorProvider();
                return;
            }
        }

        private void OderDelivery_Load(object sender, EventArgs e)
        {
            txt_TenKH.Focus();
        }
    }
}
