
namespace QuanLySieuThiMini
{
    partial class QuanLyKhachHang
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.grv_KhachHang = new System.Windows.Forms.DataGridView();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_gioiTinh = new System.Windows.Forms.TextBox();
            this.txt_ngaySinh = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_xmlToSql = new System.Windows.Forms.Button();
            this.btn_sqlToXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Gold;
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(484, 461);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(126, 47);
            this.btn_load.TabIndex = 35;
            this.btn_load.Text = "LÀM MỚI";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gold;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(337, 461);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 47);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "XÓA";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(192, 461);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 47);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "SỬA";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Gold;
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(47, 461);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(115, 47);
            this.btn_insert.TabIndex = 32;
            this.btn_insert.Text = "THÊM";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // grv_KhachHang
            // 
            this.grv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_KhachHang.Location = new System.Drawing.Point(73, 247);
            this.grv_KhachHang.Name = "grv_KhachHang";
            this.grv_KhachHang.RowHeadersWidth = 51;
            this.grv_KhachHang.Size = new System.Drawing.Size(796, 207);
            this.grv_KhachHang.TabIndex = 31;
            this.grv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_KhachHang_CellClick);
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(237, 105);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(212, 30);
            this.txt_tenKH.TabIndex = 28;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(237, 144);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(212, 30);
            this.txt_sdt.TabIndex = 27;
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioiTinh.Location = new System.Drawing.Point(606, 110);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(212, 30);
            this.txt_gioiTinh.TabIndex = 26;
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaySinh.Location = new System.Drawing.Point(606, 147);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(212, 30);
            this.txt_ngaySinh.TabIndex = 25;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.Location = new System.Drawing.Point(237, 66);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(212, 30);
            this.txt_maKH.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(492, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(492, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(104, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(102, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(104, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(324, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(606, 71);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(212, 30);
            this.txt_email.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(493, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 36;
            this.label8.Text = "Email";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(356, 203);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(254, 30);
            this.txt_search.TabIndex = 38;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(623, 194);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(145, 47);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(169, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nhập mã khách hàng";
            // 
            // btn_xmlToSql
            // 
            this.btn_xmlToSql.BackColor = System.Drawing.Color.Gold;
            this.btn_xmlToSql.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xmlToSql.Location = new System.Drawing.Point(796, 461);
            this.btn_xmlToSql.Name = "btn_xmlToSql";
            this.btn_xmlToSql.Size = new System.Drawing.Size(125, 46);
            this.btn_xmlToSql.TabIndex = 42;
            this.btn_xmlToSql.Text = "XML -> SQL";
            this.btn_xmlToSql.UseVisualStyleBackColor = false;
            this.btn_xmlToSql.Click += new System.EventHandler(this.btn_xmlToSql_Click);
            // 
            // btn_sqlToXml
            // 
            this.btn_sqlToXml.BackColor = System.Drawing.Color.Gold;
            this.btn_sqlToXml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqlToXml.Location = new System.Drawing.Point(640, 461);
            this.btn_sqlToXml.Name = "btn_sqlToXml";
            this.btn_sqlToXml.Size = new System.Drawing.Size(125, 46);
            this.btn_sqlToXml.TabIndex = 41;
            this.btn_sqlToXml.Text = "SQL -> XML";
            this.btn_sqlToXml.UseVisualStyleBackColor = false;
            this.btn_sqlToXml.Click += new System.EventHandler(this.btn_sqlToXml_Click);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 519);
            this.Controls.Add(this.btn_xmlToSql);
            this.Controls.Add(this.btn_sqlToXml);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.grv_KhachHang);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_gioiTinh);
            this.Controls.Add(this.txt_ngaySinh);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView grv_KhachHang;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_gioiTinh;
        private System.Windows.Forms.TextBox txt_ngaySinh;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_xmlToSql;
        private System.Windows.Forms.Button btn_sqlToXml;
    }
}