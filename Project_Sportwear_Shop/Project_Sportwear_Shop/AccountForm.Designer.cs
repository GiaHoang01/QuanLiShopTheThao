namespace Project_Sportwear_Shop
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_sortsearch = new System.Windows.Forms.ComboBox();
            this.txt_SearchTK = new System.Windows.Forms.TextBox();
            this.btn_ResetSearch = new System.Windows.Forms.Button();
            this.btn_AddTK = new System.Windows.Forms.Button();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_TK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpBox_Search.SuspendLayout();
            this.grpBox_TK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TK)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MK
            // 
            this.txt_MK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_MK.Location = new System.Drawing.Point(399, 50);
            this.txt_MK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.ReadOnly = true;
            this.txt_MK.Size = new System.Drawing.Size(340, 29);
            this.txt_MK.TabIndex = 33;
            // 
            // txt_TK
            // 
            this.txt_TK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TK.Location = new System.Drawing.Point(189, 50);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.ReadOnly = true;
            this.txt_TK.Size = new System.Drawing.Size(169, 29);
            this.txt_TK.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tài Khoản";
            // 
            // txt_IDTK
            // 
            this.txt_IDTK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDTK.Location = new System.Drawing.Point(23, 50);
            this.txt_IDTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDTK.Name = "txt_IDTK";
            this.txt_IDTK.ReadOnly = true;
            this.txt_IDTK.Size = new System.Drawing.Size(124, 29);
            this.txt_IDTK.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Tài Khoản";
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.label8);
            this.grpBox_Search.Controls.Add(this.label6);
            this.grpBox_Search.Controls.Add(this.cbb_sortsearch);
            this.grpBox_Search.Controls.Add(this.txt_SearchTK);
            this.grpBox_Search.Location = new System.Drawing.Point(23, 88);
            this.grpBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_Search.Size = new System.Drawing.Size(811, 98);
            this.grpBox_Search.TabIndex = 25;
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
            // txt_SearchTK
            // 
            this.txt_SearchTK.Location = new System.Drawing.Point(435, 41);
            this.txt_SearchTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchTK.Name = "txt_SearchTK";
            this.txt_SearchTK.Size = new System.Drawing.Size(353, 29);
            this.txt_SearchTK.TabIndex = 11;
            this.txt_SearchTK.TextChanged += new System.EventHandler(this.txt_SearchTK_TextChanged);
            // 
            // btn_ResetSearch
            // 
            this.btn_ResetSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_ResetSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetSearch.FlatAppearance.BorderSize = 0;
            this.btn_ResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetSearch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetSearch.ForeColor = System.Drawing.Color.White;
            this.btn_ResetSearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetSearch.Image")));
            this.btn_ResetSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetSearch.Location = new System.Drawing.Point(1004, 129);
            this.btn_ResetSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ResetSearch.Name = "btn_ResetSearch";
            this.btn_ResetSearch.Size = new System.Drawing.Size(123, 30);
            this.btn_ResetSearch.TabIndex = 26;
            this.btn_ResetSearch.Text = "Làm mới";
            this.btn_ResetSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetSearch.UseVisualStyleBackColor = false;
            this.btn_ResetSearch.Click += new System.EventHandler(this.btn_ResetSearch_Click);
            // 
            // btn_AddTK
            // 
            this.btn_AddTK.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddTK.FlatAppearance.BorderSize = 0;
            this.btn_AddTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTK.ForeColor = System.Drawing.Color.White;
            this.btn_AddTK.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddTK.Image")));
            this.btn_AddTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddTK.Location = new System.Drawing.Point(858, 129);
            this.btn_AddTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddTK.Name = "btn_AddTK";
            this.btn_AddTK.Size = new System.Drawing.Size(123, 30);
            this.btn_AddTK.TabIndex = 27;
            this.btn_AddTK.Text = "Thêm";
            this.btn_AddTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddTK.UseVisualStyleBackColor = false;
            this.btn_AddTK.Click += new System.EventHandler(this.btn_AddTK_Click);
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_MK);
            this.grpBox_TK.Controls.Add(this.btn_AddTK);
            this.grpBox_TK.Controls.Add(this.btn_ResetSearch);
            this.grpBox_TK.Controls.Add(this.txt_TK);
            this.grpBox_TK.Controls.Add(this.grpBox_Search);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.label3);
            this.grpBox_TK.Controls.Add(this.txt_IDTK);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(12, 12);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Size = new System.Drawing.Size(1147, 191);
            this.grpBox_TK.TabIndex = 0;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Danh sách tài khoản";
            // 
            // dgv_TK
            // 
            this.dgv_TK.AllowUserToAddRows = false;
            this.dgv_TK.AllowUserToResizeColumns = false;
            this.dgv_TK.AllowUserToResizeRows = false;
            this.dgv_TK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TK.ColumnHeadersHeight = 30;
            this.dgv_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            this.dgv_TK.EnableHeadersVisualStyles = false;
            this.dgv_TK.Location = new System.Drawing.Point(12, 225);
            this.dgv_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TK.Name = "dgv_TK";
            this.dgv_TK.ReadOnly = true;
            this.dgv_TK.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_TK.RowTemplate.Height = 24;
            this.dgv_TK.Size = new System.Drawing.Size(1147, 439);
            this.dgv_TK.TabIndex = 4;
            this.dgv_TK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TK_CellContentClick);
            this.dgv_TK.SelectionChanged += new System.EventHandler(this.dgv_TK_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Tài Khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tài Khoản";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mật Khẩu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 188;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.dgv_TK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpBox_TK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_sortsearch;
        private System.Windows.Forms.TextBox txt_SearchTK;
        private System.Windows.Forms.Button btn_ResetSearch;
        private System.Windows.Forms.Button btn_AddTK;
        private System.Windows.Forms.GroupBox grpBox_TK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.DataGridView dgv_TK;
    }
}