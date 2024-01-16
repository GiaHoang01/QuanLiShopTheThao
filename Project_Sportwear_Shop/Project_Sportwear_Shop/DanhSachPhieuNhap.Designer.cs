namespace Project_Sportwear_Shop
{
    partial class DanhSachPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPhieuNhap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Print = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 37);
            this.panel1.TabIndex = 43;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1057, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(51, 37);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Danh Sách Phiếu Nhập";
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.AllowUserToAddRows = false;
            this.dgv_PhieuNhap.AllowUserToDeleteRows = false;
            this.dgv_PhieuNhap.AllowUserToResizeColumns = false;
            this.dgv_PhieuNhap.AllowUserToResizeRows = false;
            this.dgv_PhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PhieuNhap.ColumnHeadersHeight = 50;
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvSTT,
            this.dgvTenSP,
            this.dgvSL,
            this.Sze,
            this.Details,
            this.Print,
            this.Delete});
            this.dgv_PhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_PhieuNhap.EnableHeadersVisualStyles = false;
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(20, 102);
            this.dgv_PhieuNhap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.ReadOnly = true;
            this.dgv_PhieuNhap.RowHeadersVisible = false;
            this.dgv_PhieuNhap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_PhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PhieuNhap.RowTemplate.Height = 100;
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(1075, 396);
            this.dgv_PhieuNhap.TabIndex = 53;
            this.dgv_PhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuNhap_CellContentClick);
            this.dgv_PhieuNhap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_PhieuNhap_CellFormatting);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 1.441924F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_Sportwear_Shop.Properties.Resources.Eye1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 108;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.FillWeight = 1.441924F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Project_Sportwear_Shop.Properties.Resources.Print;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Project_Sportwear_Shop.Properties.Resources.icons8_trash_can_26;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // dgvSTT
            // 
            this.dgvSTT.FillWeight = 34.11434F;
            this.dgvSTT.HeaderText = "ID Phiếu Nhập";
            this.dgvSTT.Name = "dgvSTT";
            this.dgvSTT.ReadOnly = true;
            this.dgvSTT.Width = 110;
            // 
            // dgvTenSP
            // 
            this.dgvTenSP.FillWeight = 67.79724F;
            this.dgvTenSP.HeaderText = "Ngày Nhập";
            this.dgvTenSP.Name = "dgvTenSP";
            this.dgvTenSP.ReadOnly = true;
            this.dgvTenSP.Width = 180;
            // 
            // dgvSL
            // 
            this.dgvSL.FillWeight = 190.636F;
            this.dgvSL.HeaderText = "ID Nhà CC";
            this.dgvSL.Name = "dgvSL";
            this.dgvSL.ReadOnly = true;
            // 
            // Sze
            // 
            this.Sze.FillWeight = 304.5685F;
            this.Sze.HeaderText = "Tổng Giá Nhập";
            this.Sze.Name = "Sze";
            this.Sze.ReadOnly = true;
            this.Sze.Width = 183;
            // 
            // Details
            // 
            this.Details.FillWeight = 1.441924F;
            this.Details.HeaderText = "";
            this.Details.Image = global::Project_Sportwear_Shop.Properties.Resources.Eye1;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 50;
            // 
            // Print
            // 
            this.Print.FillWeight = 1.441924F;
            this.Print.HeaderText = "";
            this.Print.Image = global::Project_Sportwear_Shop.Properties.Resources.Print;
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Width = 50;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Project_Sportwear_Shop.Properties.Resources.icons8_trash_can_26;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // DanhSachPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 512);
            this.Controls.Add(this.dgv_PhieuNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachPhieuNhap";
            this.Load += new System.EventHandler(this.DanhSachPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sze;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn Print;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}