namespace Project_Sportwear_Shop
{
    partial class SanPhamNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.duongthang = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.Label();
            this.picture_AnhSP = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_AnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.duongthang);
            this.panel1.Controls.Add(this.txt_TenSanPham);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 71);
            this.panel1.TabIndex = 0;
            // 
            // duongthang
            // 
            this.duongthang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.duongthang.Location = new System.Drawing.Point(0, 11);
            this.duongthang.Name = "duongthang";
            this.duongthang.Size = new System.Drawing.Size(250, 17);
            this.duongthang.TabIndex = 3;
            this.duongthang.Text = "label2";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(0, 11);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(251, 60);
            this.txt_TenSanPham.TabIndex = 1;
            this.txt_TenSanPham.Text = "Product Name";
            this.txt_TenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_AnhSP
            // 
            this.picture_AnhSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_AnhSP.Location = new System.Drawing.Point(0, 0);
            this.picture_AnhSP.Margin = new System.Windows.Forms.Padding(4);
            this.picture_AnhSP.Name = "picture_AnhSP";
            this.picture_AnhSP.Size = new System.Drawing.Size(251, 161);
            this.picture_AnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_AnhSP.TabIndex = 1;
            this.picture_AnhSP.TabStop = false;
            this.picture_AnhSP.Click += new System.EventHandler(this.picture_AnhSP_Click);
            // 
            // SanPhamNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picture_AnhSP);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SanPhamNhap";
            this.Size = new System.Drawing.Size(249, 223);
            this.Load += new System.EventHandler(this.SanPhamNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_AnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_AnhSP;
        private System.Windows.Forms.Label txt_TenSanPham;
        private System.Windows.Forms.Label duongthang;
    }
}
