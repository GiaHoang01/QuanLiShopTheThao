namespace Project_Sportwear_Shop
{
    partial class NCCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCCForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBox_NCC = new System.Windows.Forms.GroupBox();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_sortsearch = new System.Windows.Forms.ComboBox();
            this.txt_SearchNCC = new System.Windows.Forms.TextBox();
            this.btn_AddNCC = new System.Windows.Forms.Button();
            this.btn_ResetNCC = new System.Windows.Forms.Button();
            this.txt_EmailNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDTNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiaChiNCC = new System.Windows.Forms.TextBox();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_NCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBox_NCC.SuspendLayout();
            this.grpBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_NCC
            // 
            this.grpBox_NCC.Controls.Add(this.grpBox_Search);
            this.grpBox_NCC.Controls.Add(this.btn_AddNCC);
            this.grpBox_NCC.Controls.Add(this.btn_ResetNCC);
            this.grpBox_NCC.Controls.Add(this.txt_EmailNCC);
            this.grpBox_NCC.Controls.Add(this.label5);
            this.grpBox_NCC.Controls.Add(this.txt_SDTNCC);
            this.grpBox_NCC.Controls.Add(this.label4);
            this.grpBox_NCC.Controls.Add(this.txt_DiaChiNCC);
            this.grpBox_NCC.Controls.Add(this.txt_TenNCC);
            this.grpBox_NCC.Controls.Add(this.label3);
            this.grpBox_NCC.Controls.Add(this.label2);
            this.grpBox_NCC.Controls.Add(this.txt_MaNCC);
            this.grpBox_NCC.Controls.Add(this.label1);
            this.grpBox_NCC.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_NCC.Location = new System.Drawing.Point(12, 12);
            this.grpBox_NCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_NCC.Name = "grpBox_NCC";
            this.grpBox_NCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_NCC.Size = new System.Drawing.Size(1147, 191);
            this.grpBox_NCC.TabIndex = 0;
            this.grpBox_NCC.TabStop = false;
            this.grpBox_NCC.Text = "Quản lý nhà cung cấp";
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.label8);
            this.grpBox_Search.Controls.Add(this.label6);
            this.grpBox_Search.Controls.Add(this.cbb_sortsearch);
            this.grpBox_Search.Controls.Add(this.txt_SearchNCC);
            this.grpBox_Search.Location = new System.Drawing.Point(23, 86);
            this.grpBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Size = new System.Drawing.Size(811, 98);
            this.grpBox_Search.TabIndex = 24;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nhập :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm kiếm theo :";
            // 
            // cbb_sortsearch
            // 
            this.cbb_sortsearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbb_sortsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sortsearch.FormattingEnabled = true;
            this.cbb_sortsearch.Location = new System.Drawing.Point(165, 41);
            this.cbb_sortsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_sortsearch.Name = "cbb_sortsearch";
            this.cbb_sortsearch.Size = new System.Drawing.Size(169, 30);
            this.cbb_sortsearch.TabIndex = 12;
            // 
            // txt_SearchNCC
            // 
            this.txt_SearchNCC.Location = new System.Drawing.Point(435, 41);
            this.txt_SearchNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchNCC.Name = "txt_SearchNCC";
            this.txt_SearchNCC.Size = new System.Drawing.Size(353, 29);
            this.txt_SearchNCC.TabIndex = 11;
            this.txt_SearchNCC.TextChanged += new System.EventHandler(this.txt_SearchNCC_TextChanged);
            // 
            // btn_AddNCC
            // 
            this.btn_AddNCC.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNCC.FlatAppearance.BorderSize = 0;
            this.btn_AddNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNCC.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNCC.ForeColor = System.Drawing.Color.White;
            this.btn_AddNCC.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNCC.Image")));
            this.btn_AddNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddNCC.Location = new System.Drawing.Point(855, 130);
            this.btn_AddNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddNCC.Name = "btn_AddNCC";
            this.btn_AddNCC.Size = new System.Drawing.Size(123, 30);
            this.btn_AddNCC.TabIndex = 23;
            this.btn_AddNCC.Text = "Thêm";
            this.btn_AddNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddNCC.UseVisualStyleBackColor = false;
            this.btn_AddNCC.Click += new System.EventHandler(this.btn_AddNCC_Click);
            // 
            // btn_ResetNCC
            // 
            this.btn_ResetNCC.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_ResetNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetNCC.FlatAppearance.BorderSize = 0;
            this.btn_ResetNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetNCC.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetNCC.ForeColor = System.Drawing.Color.White;
            this.btn_ResetNCC.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetNCC.Image")));
            this.btn_ResetNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetNCC.Location = new System.Drawing.Point(1001, 130);
            this.btn_ResetNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ResetNCC.Name = "btn_ResetNCC";
            this.btn_ResetNCC.Size = new System.Drawing.Size(123, 30);
            this.btn_ResetNCC.TabIndex = 20;
            this.btn_ResetNCC.Text = "Làm mới";
            this.btn_ResetNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetNCC.UseVisualStyleBackColor = false;
            this.btn_ResetNCC.Click += new System.EventHandler(this.btn_ResetNCC_Click);
            // 
            // txt_EmailNCC
            // 
            this.txt_EmailNCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_EmailNCC.Location = new System.Drawing.Point(957, 50);
            this.txt_EmailNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmailNCC.Name = "txt_EmailNCC";
            this.txt_EmailNCC.ReadOnly = true;
            this.txt_EmailNCC.Size = new System.Drawing.Size(157, 29);
            this.txt_EmailNCC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(957, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // txt_SDTNCC
            // 
            this.txt_SDTNCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_SDTNCC.Location = new System.Drawing.Point(781, 50);
            this.txt_SDTNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDTNCC.Name = "txt_SDTNCC";
            this.txt_SDTNCC.ReadOnly = true;
            this.txt_SDTNCC.Size = new System.Drawing.Size(133, 29);
            this.txt_SDTNCC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT";
            // 
            // txt_DiaChiNCC
            // 
            this.txt_DiaChiNCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_DiaChiNCC.Location = new System.Drawing.Point(387, 50);
            this.txt_DiaChiNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChiNCC.Name = "txt_DiaChiNCC";
            this.txt_DiaChiNCC.ReadOnly = true;
            this.txt_DiaChiNCC.Size = new System.Drawing.Size(340, 29);
            this.txt_DiaChiNCC.TabIndex = 5;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TenNCC.Location = new System.Drawing.Point(189, 50);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.ReadOnly = true;
            this.txt_TenNCC.Size = new System.Drawing.Size(169, 29);
            this.txt_TenNCC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhà CC";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_MaNCC.Location = new System.Drawing.Point(23, 50);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.ReadOnly = true;
            this.txt_MaNCC.Size = new System.Drawing.Size(124, 29);
            this.txt_MaNCC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà CC";
            // 
            // dgv_NCC
            // 
            this.dgv_NCC.AllowUserToAddRows = false;
            this.dgv_NCC.AllowUserToResizeColumns = false;
            this.dgv_NCC.AllowUserToResizeRows = false;
            this.dgv_NCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NCC.ColumnHeadersHeight = 30;
            this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Edit,
            this.Delete});
            this.dgv_NCC.EnableHeadersVisualStyles = false;
            this.dgv_NCC.Location = new System.Drawing.Point(12, 226);
            this.dgv_NCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NCC.Name = "dgv_NCC";
            this.dgv_NCC.ReadOnly = true;
            this.dgv_NCC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_NCC.RowTemplate.Height = 24;
            this.dgv_NCC.Size = new System.Drawing.Size(1147, 438);
            this.dgv_NCC.TabIndex = 1;
            this.dgv_NCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NCC_CellContentClick);
            this.dgv_NCC.SelectionChanged += new System.EventHandler(this.dgv_NCC_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhà CC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Nhà CC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 401;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SĐT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 230;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 52;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Danh sách nhà cung cấp";
            // 
            // NCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_NCC);
            this.Controls.Add(this.grpBox_NCC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NCCForm";
            this.Text = "NCCForm";
            this.Load += new System.EventHandler(this.NCCForm_Load);
            this.grpBox_NCC.ResumeLayout(false);
            this.grpBox_NCC.PerformLayout();
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_NCC;
        private System.Windows.Forms.TextBox txt_EmailNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SDTNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DiaChiNCC;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchNCC;
        private System.Windows.Forms.Button btn_ResetNCC;
        private System.Windows.Forms.DataGridView dgv_NCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AddNCC;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_sortsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}