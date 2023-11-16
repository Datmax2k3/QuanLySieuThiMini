
namespace QuanLySieuThiMini
{
    partial class TrangChu
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_qlThucPham = new System.Windows.Forms.Button();
            this.btn_qlDoGiaDung = new System.Windows.Forms.Button();
            this.btn_qlKhachHang = new System.Windows.Forms.Button();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // btn_qlThucPham
            // 
            this.btn_qlThucPham.BackColor = System.Drawing.Color.Orange;
            this.btn_qlThucPham.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlThucPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_qlThucPham.Location = new System.Drawing.Point(55, 114);
            this.btn_qlThucPham.Name = "btn_qlThucPham";
            this.btn_qlThucPham.Size = new System.Drawing.Size(273, 69);
            this.btn_qlThucPham.TabIndex = 1;
            this.btn_qlThucPham.Text = "QUẢN LÝ THỰC PHẨM";
            this.btn_qlThucPham.UseVisualStyleBackColor = false;
            this.btn_qlThucPham.Click += new System.EventHandler(this.btn_qlThucPham_Click);
            // 
            // btn_qlDoGiaDung
            // 
            this.btn_qlDoGiaDung.BackColor = System.Drawing.Color.Orange;
            this.btn_qlDoGiaDung.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlDoGiaDung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_qlDoGiaDung.Location = new System.Drawing.Point(419, 114);
            this.btn_qlDoGiaDung.Name = "btn_qlDoGiaDung";
            this.btn_qlDoGiaDung.Size = new System.Drawing.Size(290, 69);
            this.btn_qlDoGiaDung.TabIndex = 2;
            this.btn_qlDoGiaDung.Text = "QUẢN LÝ ĐỒ GIA DỤNG";
            this.btn_qlDoGiaDung.UseVisualStyleBackColor = false;
            this.btn_qlDoGiaDung.Click += new System.EventHandler(this.btn_qlDoGiaDung_Click);
            // 
            // btn_qlKhachHang
            // 
            this.btn_qlKhachHang.BackColor = System.Drawing.Color.Orange;
            this.btn_qlKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlKhachHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_qlKhachHang.Location = new System.Drawing.Point(787, 114);
            this.btn_qlKhachHang.Name = "btn_qlKhachHang";
            this.btn_qlKhachHang.Size = new System.Drawing.Size(264, 69);
            this.btn_qlKhachHang.TabIndex = 3;
            this.btn_qlKhachHang.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.btn_qlKhachHang.UseVisualStyleBackColor = false;
            this.btn_qlKhachHang.Click += new System.EventHandler(this.btn_qlKhachHang_Click);
            // 
            // btn_signOut
            // 
            this.btn_signOut.BackColor = System.Drawing.Color.Orange;
            this.btn_signOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signOut.Location = new System.Drawing.Point(984, 40);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(108, 39);
            this.btn_signOut.TabIndex = 7;
            this.btn_signOut.Text = "Đăng xuất";
            this.btn_signOut.UseVisualStyleBackColor = false;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySieuThiMini.Properties.Resources.zyro_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 654);
            this.Controls.Add(this.btn_signOut);
            this.Controls.Add(this.btn_qlKhachHang);
            this.Controls.Add(this.btn_qlDoGiaDung);
            this.Controls.Add(this.btn_qlThucPham);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.Text = "TRANG CHỦ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Button btn_qlThucPham;
        private System.Windows.Forms.Button btn_qlDoGiaDung;
        private System.Windows.Forms.Button btn_qlKhachHang;
        private System.Windows.Forms.Button btn_signOut;
    }
}

