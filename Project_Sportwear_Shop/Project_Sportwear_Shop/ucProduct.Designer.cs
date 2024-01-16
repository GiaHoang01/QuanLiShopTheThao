namespace Project_Sportwear_Shop
{
    partial class ucProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.duongthang = new System.Windows.Forms.Label();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.pBImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pBImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 183);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.duongthang);
            this.panel2.Controls.Add(this.lbl_TenSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 47);
            this.panel2.TabIndex = 1;
            // 
            // duongthang
            // 
            this.duongthang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.duongthang.Location = new System.Drawing.Point(2, 0);
            this.duongthang.Name = "duongthang";
            this.duongthang.Size = new System.Drawing.Size(186, 18);
            this.duongthang.TabIndex = 2;
            this.duongthang.Text = "label2";
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSP.Location = new System.Drawing.Point(5, 1);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(178, 46);
            this.lbl_TenSP.TabIndex = 0;
            this.lbl_TenSP.Text = "Product Name";
            this.lbl_TenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBImage
            // 
            this.pBImage.Image = ((System.Drawing.Image)(resources.GetObject("pBImage.Image")));
            this.pBImage.Location = new System.Drawing.Point(-1, -2);
            this.pBImage.Name = "pBImage";
            this.pBImage.Size = new System.Drawing.Size(189, 136);
            this.pBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBImage.TabIndex = 0;
            this.pBImage.TabStop = false;
            this.pBImage.Click += new System.EventHandler(this.pBImage_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(186, 181);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_TenSP;
        private System.Windows.Forms.PictureBox pBImage;
        private System.Windows.Forms.Label duongthang;
    }
}
