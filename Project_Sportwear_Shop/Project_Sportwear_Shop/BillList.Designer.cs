namespace Project_Sportwear_Shop
{
    partial class BillList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Bills = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNLHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Print = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 35);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(788, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 35);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // dgv_Bills
            // 
            this.dgv_Bills.AllowUserToAddRows = false;
            this.dgv_Bills.AllowUserToDeleteRows = false;
            this.dgv_Bills.AllowUserToResizeColumns = false;
            this.dgv_Bills.AllowUserToResizeRows = false;
            this.dgv_Bills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Bills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Bills.ColumnHeadersHeight = 50;
            this.dgv_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Bills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvIDHD,
            this.dgvNLHD,
            this.dgvIDNV,
            this.dgvHT,
            this.dgvTT,
            this.Details,
            this.Print,
            this.Delete});
            this.dgv_Bills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_Bills.EnableHeadersVisualStyles = false;
            this.dgv_Bills.Location = new System.Drawing.Point(16, 86);
            this.dgv_Bills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Bills.Name = "dgv_Bills";
            this.dgv_Bills.ReadOnly = true;
            this.dgv_Bills.RowHeadersVisible = false;
            this.dgv_Bills.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Bills.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Bills.RowTemplate.Height = 24;
            this.dgv_Bills.Size = new System.Drawing.Size(798, 339);
            this.dgv_Bills.TabIndex = 7;
            this.dgv_Bills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bills_CellContentClick);
            this.dgv_Bills.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Bills_CellFormatting);
            // 
            // dgvSTT
            // 
            this.dgvSTT.HeaderText = "STT";
            this.dgvSTT.Name = "dgvSTT";
            this.dgvSTT.ReadOnly = true;
            this.dgvSTT.Width = 58;
            // 
            // dgvIDHD
            // 
            this.dgvIDHD.HeaderText = "ID Hóa Đơn";
            this.dgvIDHD.Name = "dgvIDHD";
            this.dgvIDHD.ReadOnly = true;
            this.dgvIDHD.Width = 90;
            // 
            // dgvNLHD
            // 
            this.dgvNLHD.HeaderText = "Ngày Lập HD";
            this.dgvNLHD.Name = "dgvNLHD";
            this.dgvNLHD.ReadOnly = true;
            this.dgvNLHD.Width = 170;
            // 
            // dgvIDNV
            // 
            this.dgvIDNV.HeaderText = "NV Tiếp Nhận";
            this.dgvIDNV.Name = "dgvIDNV";
            this.dgvIDNV.ReadOnly = true;
            this.dgvIDNV.Width = 90;
            // 
            // dgvHT
            // 
            this.dgvHT.HeaderText = "Hình Thức";
            this.dgvHT.Name = "dgvHT";
            this.dgvHT.ReadOnly = true;
            this.dgvHT.Width = 90;
            // 
            // dgvTT
            // 
            this.dgvTT.HeaderText = "Thành Tiền";
            this.dgvTT.Name = "dgvTT";
            this.dgvTT.ReadOnly = true;
            this.dgvTT.Width = 152;
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 49;
            // 
            // Print
            // 
            this.Print.HeaderText = "";
            this.Print.Image = ((System.Drawing.Image)(resources.GetObject("Print.Image")));
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Width = 49;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // BillList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(826, 436);
            this.Controls.Add(this.dgv_Bills);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillList";
            this.Load += new System.EventHandler(this.BillList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_Bills;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNLHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTT;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn Print;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}