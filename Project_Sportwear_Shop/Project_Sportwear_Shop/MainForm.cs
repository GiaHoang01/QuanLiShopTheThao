using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sportwear_Shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            duongthang1.Height = 2;
            duongthang2.Height = 2;
            btn_TrangChu_Click(sender, e);
            DateTime currentTime = DateTime.Now;
            string formattedTime = string.Format("{0}, ngày {1:D2}/{2:D2}/{3}", GetDayOfWeekInVietnamese(currentTime.DayOfWeek), currentTime.Day, currentTime.Month, currentTime.Year);
            lbl_Time.Text = formattedTime;
            if (lblRole.Text != "Chức Vụ: Quản Lý Cửa Hàng")
            {
                btn_ThongKe.Hide();
                btn_Account.Hide();
                btn_NV.Hide();
            }
        }


        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new TrangChuForm());
            btn_TrangChu.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new SanPhamForm(this));
            btn_SanPham.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new NCCForm());
            btn_NCC.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            btnClear();
            BanHangForm bnF = new BanHangForm();
            bnF.lblIDNV.Text = lblID_NV.Text;
            bnF.lblTenNV.Text = lblUsername.Text;
            bnF.lblViTri.Text = lblRole.Text;
            bnF.ShowDialog();
            btn_BanHang.ForeColor = Color.DarkGreen;
            btn_TrangChu_Click(sender, e);
        }

        private void btn_KhoHang_Click(object sender, EventArgs e)
        {
            btnClear();
            NhapHang bnF = new NhapHang();
            bnF.lblIDNV.Text = lblID_NV.Text;
            bnF.lblTenNV.Text = lblUsername.Text;
            bnF.lblViTri.Text = lblRole.Text;
            bnF.ShowDialog();
            btn_BanHang.ForeColor = Color.DarkGreen;
            btn_TrangChu_Click(sender, e);
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new NhanVienForm());
            btn_NV.ForeColor = Color.DarkGreen;
            activeForm = null;
        }
        private void btn_Account_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new AccountForm());
            btn_Account.ForeColor = Color.DarkGreen;
            activeForm = null;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            btnClear();
            openChildForm(new ThongKeForm());
            btn_ThongKe.ForeColor = Color.DarkGreen;
            activeForm = null;
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        #region Method
        private Form activeForm = null;
        public void openChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                activeForm = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                panelChild.Controls.Add(childform);
                panelChild.Tag = childform;
                childform.BringToFront();
                childform.Show();
            }
        }

        public void btnClear()
        {
            btn_TrangChu.ForeColor = Color.White;
            btn_SanPham.ForeColor = Color.White;
            btn_NCC.ForeColor = Color.White;
            btn_BanHang.ForeColor = Color.White;
            btn_KhoHang.ForeColor = Color.White;
            btn_NV.ForeColor = Color.White;
            btn_ThongKe.ForeColor = Color.White;
            btn_Account.ForeColor = Color.White;
        }
        public string GetDayOfWeekInVietnamese(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Chủ nhật";
                case DayOfWeek.Monday:
                    return "Thứ hai";
                case DayOfWeek.Tuesday:
                    return "Thứ ba";
                case DayOfWeek.Wednesday:
                    return "Thứ tư";
                case DayOfWeek.Thursday:
                    return "Thứ năm";
                case DayOfWeek.Friday:
                    return "Thứ sáu";
                case DayOfWeek.Saturday:
                    return "Thứ bảy";
                default:
                    return "";
            }
        }
        public void SetIDNV(string id)
        {
            lblID_NV.Text = id;
        }
        public void SetUserName(string username)
        {
            lblUsername.Text = username;
        }
        public void SetRole(string role)
        {
            lblRole.Text = "Chức Vụ: " + role;
        }
        #endregion Method
    }
}
