namespace Project_Sportwear_Shop
{
    partial class BanHangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHangForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.chk_Discount = new System.Windows.Forms.CheckBox();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_takeaw = new System.Windows.Forms.Button();
            this.btn_deli = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgv_Inf = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inf)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Controls.Add(this.chk_Discount);
            this.panel2.Controls.Add(this.btn_TaoHoaDon);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 100);
            this.panel2.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(927, 9);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(55, 25);
            this.txtGiamGia.TabIndex = 9;
            this.txtGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // chk_Discount
            // 
            this.chk_Discount.AutoSize = true;
            this.chk_Discount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Discount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Discount.ForeColor = System.Drawing.Color.White;
            this.chk_Discount.Location = new System.Drawing.Point(791, 8);
            this.chk_Discount.Name = "chk_Discount";
            this.chk_Discount.Size = new System.Drawing.Size(153, 28);
            this.chk_Discount.TabIndex = 7;
            this.chk_Discount.Text = "Giảm giá (%)";
            this.chk_Discount.UseVisualStyleBackColor = true;
            this.chk_Discount.CheckedChanged += new System.EventHandler(this.chk_Discount_CheckedChanged);
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
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(1220, 11);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(134, 42);
            this.btn_TaoHoaDon.TabIndex = 6;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(921, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 34);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(785, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bán hàng";
            // 
            // btn_takeaw
            // 
            this.btn_takeaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btn_takeaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_takeaw.FlatAppearance.BorderSize = 0;
            this.btn_takeaw.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_takeaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_takeaw.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_takeaw.ForeColor = System.Drawing.Color.White;
            this.btn_takeaw.Image = ((System.Drawing.Image)(resources.GetObject("btn_takeaw.Image")));
            this.btn_takeaw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_takeaw.Location = new System.Drawing.Point(530, 12);
            this.btn_takeaw.Name = "btn_takeaw";
            this.btn_takeaw.Size = new System.Drawing.Size(110, 73);
            this.btn_takeaw.TabIndex = 3;
            this.btn_takeaw.Text = "Trực tiếp";
            this.btn_takeaw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_takeaw.UseVisualStyleBackColor = false;
            this.btn_takeaw.Click += new System.EventHandler(this.btn_takeaw_Click);
            // 
            // btn_deli
            // 
            this.btn_deli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btn_deli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deli.FlatAppearance.BorderSize = 0;
            this.btn_deli.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_deli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deli.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deli.ForeColor = System.Drawing.Color.White;
            this.btn_deli.Image = ((System.Drawing.Image)(resources.GetObject("btn_deli.Image")));
            this.btn_deli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deli.Location = new System.Drawing.Point(694, 14);
            this.btn_deli.Name = "btn_deli";
            this.btn_deli.Size = new System.Drawing.Size(110, 73);
            this.btn_deli.TabIndex = 4;
            this.btn_deli.Text = "Giao hàng";
            this.btn_deli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_deli.UseVisualStyleBackColor = false;
            this.btn_deli.Click += new System.EventHandler(this.btn_deli_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btn_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Image = ((System.Drawing.Image)(resources.GetObject("btn_bill.Image")));
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bill.Location = new System.Drawing.Point(858, 14);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(110, 73);
            this.btn_bill.TabIndex = 5;
            this.btn_bill.Text = "Hóa đơn";
            this.btn_bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.lblViTri);
            this.panel1.Controls.Add(this.lblTenNV);
            this.panel1.Controls.Add(this.lblIDNV);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_bill);
            this.panel1.Controls.Add(this.btn_deli);
            this.panel1.Controls.Add(this.btn_takeaw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 100);
            this.panel1.TabIndex = 0;
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
            this.btn_new.Location = new System.Drawing.Point(366, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(110, 73);
            this.btn_new.TabIndex = 10;
            this.btn_new.Text = "Làm mới";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTri.ForeColor = System.Drawing.Color.White;
            this.lblViTri.Location = new System.Drawing.Point(1049, 66);
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
            this.lblTenNV.Location = new System.Drawing.Point(1049, 40);
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
            this.lblIDNV.Location = new System.Drawing.Point(1049, 14);
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
            this.btn_exit.Location = new System.Drawing.Point(1328, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 35);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Location = new System.Drawing.Point(12, 140);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(166, 522);
            this.CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Location = new System.Drawing.Point(184, 140);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(601, 522);
            this.ProductPanel.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(321, 106);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(323, 28);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dgv_Inf.ColumnHeadersHeight = 30;
            this.dgv_Inf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Inf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvTenSP,
            this.dgvSL,
            this.Sze,
            this.dgvGia,
            this.dgvTTien,
            this.Delete});
            this.dgv_Inf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_Inf.EnableHeadersVisualStyles = false;
            this.dgv_Inf.Location = new System.Drawing.Point(791, 140);
            this.dgv_Inf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Inf.Name = "dgv_Inf";
            this.dgv_Inf.ReadOnly = true;
            this.dgv_Inf.RowHeadersVisible = false;
            this.dgv_Inf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Inf.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Inf.RowTemplate.Height = 24;
            this.dgv_Inf.Size = new System.Drawing.Size(563, 522);
            this.dgv_Inf.TabIndex = 6;
            this.dgv_Inf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inf_CellContentClick);
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
            this.dgvTenSP.Width = 240;
            // 
            // dgvSL
            // 
            this.dgvSL.HeaderText = "Số lượng";
            this.dgvSL.Name = "dgvSL";
            this.dgvSL.ReadOnly = true;
            this.dgvSL.Width = 80;
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
            this.dgvGia.HeaderText = "Giá bán";
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            this.dgvGia.Width = 200;
            // 
            // dgvTTien
            // 
            this.dgvTTien.HeaderText = "Thành tiền";
            this.dgvTTien.Name = "dgvTTien";
            this.dgvTTien.ReadOnly = true;
            this.dgvTTien.Width = 200;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(200, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm kiếm:";
            // 
            // BanHangForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Inf);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BanHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanHangForm";
            this.Load += new System.EventHandler(this.BanHangForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_takeaw;
        private System.Windows.Forms.Button btn_deli;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label lblViTri;
        public System.Windows.Forms.Label lblTenNV;
        public System.Windows.Forms.Label lblIDNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.DataGridView dgv_Inf;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        public System.Windows.Forms.CheckBox chk_Discount;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sze;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTTien;
        private System.Windows.Forms.DataGridViewImageColumn Delete;

    }
}