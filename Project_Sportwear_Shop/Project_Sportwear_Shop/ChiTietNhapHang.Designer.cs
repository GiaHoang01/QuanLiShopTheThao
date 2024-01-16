namespace Project_Sportwear_Shop
{
    partial class ChiTietNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietNhapHang));
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.Label();
            this.AnhSanPham = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoS = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.rdoL = new System.Windows.Forms.RadioButton();
            this.rdoXL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SLTon = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.grB_SizeSL = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AnhSanPham)).BeginInit();
            this.grB_SizeSL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_GiaNhap.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaNhap.Location = new System.Drawing.Point(503, 356);
            this.txt_GiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(343, 29);
            this.txt_GiaNhap.TabIndex = 37;
            this.txt_GiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_GiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaNhap_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Giá Nhập Môt Sản Phẩm :";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.AutoSize = true;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.ForeColor = System.Drawing.Color.Black;
            this.txt_TenSanPham.Location = new System.Drawing.Point(16, 97);
            this.txt_TenSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(133, 23);
            this.txt_TenSanPham.TabIndex = 40;
            this.txt_TenSanPham.Text = "Tên Sản Phẩm";
            // 
            // AnhSanPham
            // 
            this.AnhSanPham.Location = new System.Drawing.Point(16, 129);
            this.AnhSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.AnhSanPham.Name = "AnhSanPham";
            this.AnhSanPham.Size = new System.Drawing.Size(344, 150);
            this.AnhSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnhSanPham.TabIndex = 42;
            this.AnhSanPham.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nhập Số Lượng Bạn Muốn Nhập Hàng :";
            // 
            // txt_SL
            // 
            this.txt_SL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_SL.Enabled = false;
            this.txt_SL.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(16, 356);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(343, 29);
            this.txt_SL.TabIndex = 37;
            this.txt_SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SL_KeyPress);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Silver;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.FlatAppearance.BorderSize = 0;
            this.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huy.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(503, 416);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(109, 50);
            this.btn_huy.TabIndex = 38;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(44)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(251, 416);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 50);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "Nhập";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Chọn Số Lượng Và Size Cho Sản Phẩm :";
            // 
            // rdoS
            // 
            this.rdoS.AutoSize = true;
            this.rdoS.Location = new System.Drawing.Point(27, 41);
            this.rdoS.Margin = new System.Windows.Forms.Padding(4);
            this.rdoS.Name = "rdoS";
            this.rdoS.Size = new System.Drawing.Size(42, 27);
            this.rdoS.TabIndex = 0;
            this.rdoS.TabStop = true;
            this.rdoS.Text = "S";
            this.rdoS.UseVisualStyleBackColor = true;
            this.rdoS.CheckedChanged += new System.EventHandler(this.rdoS_CheckedChanged_1);
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(105, 41);
            this.rdoM.Margin = new System.Windows.Forms.Padding(4);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(46, 27);
            this.rdoM.TabIndex = 1;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "M";
            this.rdoM.UseVisualStyleBackColor = true;
            this.rdoM.CheckedChanged += new System.EventHandler(this.rdoM_CheckedChanged_1);
            // 
            // rdoL
            // 
            this.rdoL.AutoSize = true;
            this.rdoL.Location = new System.Drawing.Point(189, 41);
            this.rdoL.Margin = new System.Windows.Forms.Padding(4);
            this.rdoL.Name = "rdoL";
            this.rdoL.Size = new System.Drawing.Size(40, 27);
            this.rdoL.TabIndex = 2;
            this.rdoL.TabStop = true;
            this.rdoL.Text = "L";
            this.rdoL.UseVisualStyleBackColor = true;
            this.rdoL.CheckedChanged += new System.EventHandler(this.rdoL_CheckedChanged_1);
            // 
            // rdoXL
            // 
            this.rdoXL.AutoSize = true;
            this.rdoXL.Location = new System.Drawing.Point(265, 41);
            this.rdoXL.Margin = new System.Windows.Forms.Padding(4);
            this.rdoXL.Name = "rdoXL";
            this.rdoXL.Size = new System.Drawing.Size(51, 27);
            this.rdoXL.TabIndex = 3;
            this.rdoXL.TabStop = true;
            this.rdoXL.Text = "XL";
            this.rdoXL.UseVisualStyleBackColor = true;
            this.rdoXL.CheckedChanged += new System.EventHandler(this.rdoXL_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Lượng Sản Phẩm Hiện Có:";
            // 
            // txt_SLTon
            // 
            this.txt_SLTon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_SLTon.Enabled = false;
            this.txt_SLTon.Location = new System.Drawing.Point(12, 110);
            this.txt_SLTon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SLTon.Name = "txt_SLTon";
            this.txt_SLTon.ReadOnly = true;
            this.txt_SLTon.Size = new System.Drawing.Size(308, 29);
            this.txt_SLTon.TabIndex = 5;
            this.txt_SLTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(11, 156);
            this.lblTinhTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(194, 23);
            this.lblTinhTrang.TabIndex = 6;
            this.lblTinhTrang.Text = "Trạng Thái Sản phẩm";
            this.lblTinhTrang.Visible = false;
            // 
            // grB_SizeSL
            // 
            this.grB_SizeSL.BackColor = System.Drawing.Color.Linen;
            this.grB_SizeSL.Controls.Add(this.lblTinhTrang);
            this.grB_SizeSL.Controls.Add(this.txt_SLTon);
            this.grB_SizeSL.Controls.Add(this.label1);
            this.grB_SizeSL.Controls.Add(this.rdoXL);
            this.grB_SizeSL.Controls.Add(this.rdoL);
            this.grB_SizeSL.Controls.Add(this.rdoM);
            this.grB_SizeSL.Controls.Add(this.rdoS);
            this.grB_SizeSL.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB_SizeSL.Location = new System.Drawing.Point(503, 97);
            this.grB_SizeSL.Margin = new System.Windows.Forms.Padding(4);
            this.grB_SizeSL.Name = "grB_SizeSL";
            this.grB_SizeSL.Padding = new System.Windows.Forms.Padding(4);
            this.grB_SizeSL.Size = new System.Drawing.Size(344, 182);
            this.grB_SizeSL.TabIndex = 35;
            this.grB_SizeSL.TabStop = false;
            this.grB_SizeSL.Text = "Size - SL";
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(813, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(51, 37);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 37);
            this.panel1.TabIndex = 34;
            // 
            // ChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(864, 498);
            this.Controls.Add(this.AnhSanPham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grB_SizeSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenSanPham);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txt_GiaNhap);
            this.Controls.Add(this.txt_SL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietNhapHang";
            this.Load += new System.EventHandler(this.ChiTietNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnhSanPham)).EndInit();
            this.grB_SizeSL.ResumeLayout(false);
            this.grB_SizeSL.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label txt_TenSanPham;
        public System.Windows.Forms.PictureBox AnhSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rdoS;
        public System.Windows.Forms.RadioButton rdoM;
        public System.Windows.Forms.RadioButton rdoL;
        public System.Windows.Forms.RadioButton rdoXL;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_SLTon;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.GroupBox grB_SizeSL;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;

    }
}