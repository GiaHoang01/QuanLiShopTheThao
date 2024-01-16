namespace Project_Sportwear_Shop
{
    partial class ThongKeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeForm));
            this.lb_doanhthu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_daban = new System.Windows.Forms.Label();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_xuatExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dTB_Den = new System.Windows.Forms.DateTimePicker();
            this.dTB_Tu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_loc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_doanhthu
            // 
            this.lb_doanhthu.AutoSize = true;
            this.lb_doanhthu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doanhthu.ForeColor = System.Drawing.Color.Red;
            this.lb_doanhthu.Location = new System.Drawing.Point(984, 625);
            this.lb_doanhthu.Name = "lb_doanhthu";
            this.lb_doanhthu.Size = new System.Drawing.Size(62, 21);
            this.lb_doanhthu.TabIndex = 17;
            this.lb_doanhthu.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(837, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đã bán: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(837, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tổng doanh thu: ";
            // 
            // lb_daban
            // 
            this.lb_daban.AutoSize = true;
            this.lb_daban.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_daban.ForeColor = System.Drawing.Color.Red;
            this.lb_daban.Location = new System.Drawing.Point(984, 588);
            this.lb_daban.Name = "lb_daban";
            this.lb_daban.Size = new System.Drawing.Size(62, 21);
            this.lb_daban.TabIndex = 18;
            this.lb_daban.Text = "label3";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.AllowUserToAddRows = false;
            this.dgv_hoadon.AllowUserToDeleteRows = false;
            this.dgv_hoadon.AllowUserToResizeColumns = false;
            this.dgv_hoadon.AllowUserToResizeRows = false;
            this.dgv_hoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_hoadon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hoadon.ColumnHeadersHeight = 50;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_hoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_hoadon.EnableHeadersVisualStyles = false;
            this.dgv_hoadon.Location = new System.Drawing.Point(12, 57);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.ReadOnly = true;
            this.dgv_hoadon.RowHeadersVisible = false;
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hoadon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(1124, 420);
            this.dgv_hoadon.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã HD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã NV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên khách hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 174;
            // 
            // column6
            // 
            this.column6.HeaderText = "Điện thoại";
            this.column6.MinimumWidth = 6;
            this.column6.Name = "column6";
            this.column6.ReadOnly = true;
            this.column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hình Thức";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giảm giá";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Thành Tiền";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // btn_xuatExcel
            // 
            this.btn_xuatExcel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_xuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xuatExcel.Location = new System.Drawing.Point(14, 607);
            this.btn_xuatExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xuatExcel.Name = "btn_xuatExcel";
            this.btn_xuatExcel.Size = new System.Drawing.Size(207, 39);
            this.btn_xuatExcel.TabIndex = 13;
            this.btn_xuatExcel.Text = "Xuất ra Excel";
            this.btn_xuatExcel.UseVisualStyleBackColor = false;
            this.btn_xuatExcel.Click += new System.EventHandler(this.btn_xuatExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÔNG KÊ BÁN HÀNG";
            // 
            // dTB_Den
            // 
            this.dTB_Den.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTB_Den.Location = new System.Drawing.Point(304, 32);
            this.dTB_Den.Name = "dTB_Den";
            this.dTB_Den.Size = new System.Drawing.Size(200, 24);
            this.dTB_Den.TabIndex = 19;
            // 
            // dTB_Tu
            // 
            this.dTB_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTB_Tu.Location = new System.Drawing.Point(44, 32);
            this.dTB_Tu.Name = "dTB_Tu";
            this.dTB_Tu.Size = new System.Drawing.Size(200, 24);
            this.dTB_Tu.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Đến";
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loc.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_loc.Location = new System.Drawing.Point(510, 25);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(105, 32);
            this.btn_loc.TabIndex = 21;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = false;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTB_Den);
            this.groupBox1.Controls.Add(this.btn_loc);
            this.groupBox1.Controls.Add(this.dTB_Tu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 84);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_doanhthu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_daban);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.btn_xuatExcel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_doanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_daban;
        public System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_xuatExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTB_Den;
        private System.Windows.Forms.DateTimePicker dTB_Tu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}