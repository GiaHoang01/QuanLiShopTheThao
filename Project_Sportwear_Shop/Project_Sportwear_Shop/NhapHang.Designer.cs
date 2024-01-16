namespace Project_Sportwear_Shop
{
    partial class NhapHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Inf = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Menu_ChiTiet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.NhapHangSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.HangSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_HoaDonNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inf)).BeginInit();
            this.Menu_ChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(195, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tìm kiếm:";
            // 
            // dgv_Inf
            // 
            this.dgv_Inf.AllowUserToAddRows = false;
            this.dgv_Inf.AllowUserToDeleteRows = false;
            this.dgv_Inf.AllowUserToResizeColumns = false;
            this.dgv_Inf.AllowUserToResizeRows = false;
            this.dgv_Inf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Inf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Inf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Inf.ColumnHeadersHeight = 50;
            this.dgv_Inf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Inf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvTenSP,
            this.dgvSL,
            this.Sze,
            this.dgvGia,
            this.dgvTTien,
            this.Delete});
            this.dgv_Inf.ContextMenuStrip = this.Menu_ChiTiet;
            this.dgv_Inf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_Inf.EnableHeadersVisualStyles = false;
            this.dgv_Inf.Location = new System.Drawing.Point(791, 135);
            this.dgv_Inf.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_Inf.Name = "dgv_Inf";
            this.dgv_Inf.ReadOnly = true;
            this.dgv_Inf.RowHeadersVisible = false;
            this.dgv_Inf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Inf.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Inf.RowTemplate.Height = 100;
            this.dgv_Inf.Size = new System.Drawing.Size(575, 522);
            this.dgv_Inf.TabIndex = 13;
            this.dgv_Inf.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Inf_CellFormatting);
            // 
            // dgvSTT
            // 
            this.dgvSTT.HeaderText = "STT";
            this.dgvSTT.Name = "dgvSTT";
            this.dgvSTT.ReadOnly = true;
            this.dgvSTT.Width = 70;
            // 
            // dgvTenSP
            // 
            this.dgvTenSP.HeaderText = "Tên SP";
            this.dgvTenSP.Name = "dgvTenSP";
            this.dgvTenSP.ReadOnly = true;
            this.dgvTenSP.Width = 200;
            // 
            // dgvSL
            // 
            this.dgvSL.HeaderText = "Số lượng";
            this.dgvSL.Name = "dgvSL";
            this.dgvSL.ReadOnly = true;
            // 
            // Sze
            // 
            this.Sze.HeaderText = "Size";
            this.Sze.Name = "Sze";
            this.Sze.ReadOnly = true;
            this.Sze.Width = 70;
            // 
            // dgvGia
            // 
            this.dgvGia.HeaderText = "Giá Nhập";
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            // 
            // dgvTTien
            // 
            this.dgvTTien.HeaderText = "Thành tiền";
            this.dgvTTien.Name = "dgvTTien";
            this.dgvTTien.ReadOnly = true;
            this.dgvTTien.Width = 130;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Hình Ảnh";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 200;
            // 
            // Menu_ChiTiet
            // 
            this.Menu_ChiTiet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ChiTiet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.Menu_ChiTiet.Name = "Menu_ChiTiet";
            this.Menu_ChiTiet.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(303, 98);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(429, 29);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // NhapHangSanPham
            // 
            this.NhapHangSanPham.AutoScroll = true;
            this.NhapHangSanPham.Location = new System.Drawing.Point(185, 135);
            this.NhapHangSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.NhapHangSanPham.Name = "NhapHangSanPham";
            this.NhapHangSanPham.Size = new System.Drawing.Size(603, 520);
            this.NhapHangSanPham.TabIndex = 11;
            // 
            // HangSanPham
            // 
            this.HangSanPham.Location = new System.Drawing.Point(13, 135);
            this.HangSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.HangSanPham.Name = "HangSanPham";
            this.HangSanPham.Size = new System.Drawing.Size(164, 520);
            this.HangSanPham.TabIndex = 10;
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTri.ForeColor = System.Drawing.Color.White;
            this.lblViTri.Location = new System.Drawing.Point(1047, 69);
            this.lblViTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(127, 21);
            this.lblViTri.TabIndex = 9;
            this.lblViTri.Text = "ViTriCongViec";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.White;
            this.lblTenNV.Location = new System.Drawing.Point(1047, 37);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(65, 21);
            this.lblTenNV.TabIndex = 8;
            this.lblTenNV.Text = "TenNV";
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNV.ForeColor = System.Drawing.Color.White;
            this.lblIDNV.Location = new System.Drawing.Point(1047, 5);
            this.lblIDNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(55, 21);
            this.lblIDNV.TabIndex = 7;
            this.lblIDNV.Text = "IDNV";
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1321, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 39);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_HoaDonNhap
            // 
            this.btn_HoaDonNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btn_HoaDonNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HoaDonNhap.FlatAppearance.BorderSize = 0;
            this.btn_HoaDonNhap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_HoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDonNhap.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDonNhap.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDonNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDonNhap.Image")));
            this.btn_HoaDonNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HoaDonNhap.Location = new System.Drawing.Point(588, 12);
            this.btn_HoaDonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HoaDonNhap.Name = "btn_HoaDonNhap";
            this.btn_HoaDonNhap.Size = new System.Drawing.Size(110, 73);
            this.btn_HoaDonNhap.TabIndex = 5;
            this.btn_HoaDonNhap.Text = "Phiếu Nhập";
            this.btn_HoaDonNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HoaDonNhap.UseVisualStyleBackColor = false;
            this.btn_HoaDonNhap.Click += new System.EventHandler(this.btn_HoaDonNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_TaoHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 663);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 105);
            this.panel2.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(921, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 34);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(785, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng tiền:";
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btn_TaoHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TaoHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_TaoHoaDon.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_TaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHoaDon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_TaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(1201, 13);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(153, 42);
            this.btn_TaoHoaDon.TabIndex = 7;
            this.btn_TaoHoaDon.Text = "Tạo phiếu nhập";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.lblViTri);
            this.panel1.Controls.Add(this.lblTenNV);
            this.panel1.Controls.Add(this.lblIDNV);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_HoaDonNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 93);
            this.panel1.TabIndex = 8;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_new.Location = new System.Drawing.Point(412, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(110, 73);
            this.btn_new.TabIndex = 11;
            this.btn_new.Text = "Làm mới";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Inf);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.NhapHangSanPham);
            this.Controls.Add(this.HangSanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inf)).EndInit();
            this.Menu_ChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgv_Inf;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel NhapHangSanPham;
        private System.Windows.Forms.FlowLayoutPanel HangSanPham;
        public System.Windows.Forms.Label lblViTri;
        public System.Windows.Forms.Label lblTenNV;
        public System.Windows.Forms.Label lblIDNV;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_HoaDonNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sze;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTTien;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ContextMenuStrip Menu_ChiTiet;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
    }
}