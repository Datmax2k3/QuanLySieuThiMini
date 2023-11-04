
namespace QuanLySieuThiMini
{
    partial class Form1
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
            this.toolStrip_thucPham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_doGiaDung = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_khachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.toolStrip_thucPham,
            this.toolStrip_doGiaDung,
            this.toolStrip_khachHang,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            // 
            // toolStrip_thucPham
            // 
            this.toolStrip_thucPham.Name = "toolStrip_thucPham";
            this.toolStrip_thucPham.Size = new System.Drawing.Size(148, 24);
            this.toolStrip_thucPham.Text = "Quản lý thực phẩm";
            this.toolStrip_thucPham.Click += new System.EventHandler(this.quảnLýRauCủToolStripMenuItem_Click);
            // 
            // toolStrip_doGiaDung
            // 
            this.toolStrip_doGiaDung.Name = "toolStrip_doGiaDung";
            this.toolStrip_doGiaDung.Size = new System.Drawing.Size(158, 24);
            this.toolStrip_doGiaDung.Text = "Quản lý đồ gia dụng";
            this.toolStrip_doGiaDung.Click += new System.EventHandler(this.toolStrip_doGiaDung_Click);
            // 
            // toolStrip_khachHang
            // 
            this.toolStrip_khachHang.Name = "toolStrip_khachHang";
            this.toolStrip_khachHang.Size = new System.Drawing.Size(152, 24);
            this.toolStrip_khachHang.Text = "Quản lý khách hàng";
            this.toolStrip_khachHang.Click += new System.EventHandler(this.toolStrip_khachHang_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySieuThiMini.Properties.Resources.zyro_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 654);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_thucPham;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_doGiaDung;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_khachHang;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}

