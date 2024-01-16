using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sportwear_Shop
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(txt_link.Text);
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Connection.constr = txt_link.Text;
                    connection.Close();
                    MessageBox.Show("Kết nối thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm lg = new LoginForm();
                    this.Hide();
                    lg.ShowDialog();
                }
            }
            catch
            {
                {
                    MessageBox.Show("Lỗi link data sql, vui lòng kiểm tra lại!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
