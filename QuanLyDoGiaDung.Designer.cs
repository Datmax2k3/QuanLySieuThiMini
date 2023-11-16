
namespace QuanLySieuThiMini
{
    partial class QuanLyDoGiaDung
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dgv_doGiaDung = new System.Windows.Forms.DataGridView();
            this.txt_baoHanh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tenDoGD = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_nguonGoc = new System.Windows.Forms.TextBox();
            this.txt_maDoGD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sqlToXml = new System.Windows.Forms.Button();
            this.btn_xmlToSql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doGiaDung)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gold;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(320, 484);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 46);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "XÓA";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(190, 484);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(98, 46);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "SỬA";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Gold;
            this.btn_insert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(57, 484);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(98, 46);
            this.btn_insert.TabIndex = 32;
            this.btn_insert.Text = "THÊM";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dgv_doGiaDung
            // 
            this.dgv_doGiaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doGiaDung.Location = new System.Drawing.Point(57, 271);
            this.dgv_doGiaDung.Name = "dgv_doGiaDung";
            this.dgv_doGiaDung.RowHeadersWidth = 51;
            this.dgv_doGiaDung.Size = new System.Drawing.Size(815, 207);
            this.dgv_doGiaDung.TabIndex = 31;
            this.dgv_doGiaDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doGiaDung_CellClick);
            // 
            // txt_baoHanh
            // 
            this.txt_baoHanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baoHanh.Location = new System.Drawing.Point(642, 165);
            this.txt_baoHanh.Name = "txt_baoHanh";
            this.txt_baoHanh.Size = new System.Drawing.Size(212, 30);
            this.txt_baoHanh.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(491, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Bảo hành";
            // 
            // txt_tenDoGD
            // 
            this.txt_tenDoGD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDoGD.Location = new System.Drawing.Point(216, 122);
            this.txt_tenDoGD.Name = "txt_tenDoGD";
            this.txt_tenDoGD.Size = new System.Drawing.Size(212, 30);
            this.txt_tenDoGD.TabIndex = 28;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuong.Location = new System.Drawing.Point(216, 165);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(212, 30);
            this.txt_soLuong.TabIndex = 27;
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(642, 79);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(212, 30);
            this.txt_gia.TabIndex = 26;
            // 
            // txt_nguonGoc
            // 
            this.txt_nguonGoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguonGoc.Location = new System.Drawing.Point(642, 122);
            this.txt_nguonGoc.Name = "txt_nguonGoc";
            this.txt_nguonGoc.Size = new System.Drawing.Size(212, 30);
            this.txt_nguonGoc.TabIndex = 25;
            // 
            // txt_maDoGD
            // 
            this.txt_maDoGD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maDoGD.Location = new System.Drawing.Point(216, 79);
            this.txt_maDoGD.Name = "txt_maDoGD";
            this.txt_maDoGD.Size = new System.Drawing.Size(212, 30);
            this.txt_maDoGD.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(491, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nguồn gốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(491, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(104, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(102, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên đồ GD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(104, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã đồ GD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(316, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ ĐỒ GIA DỤNG";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Gold;
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(451, 484);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(106, 46);
            this.btn_load.TabIndex = 35;
            this.btn_load.Text = "LÀM MỚI";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(307, 225);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(354, 30);
            this.txt_search.TabIndex = 36;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(676, 214);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(109, 51);
            this.btn_search.TabIndex = 37;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(183, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nhập tên đồ";
            // 
            // btn_sqlToXml
            // 
            this.btn_sqlToXml.BackColor = System.Drawing.Color.Gold;
            this.btn_sqlToXml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqlToXml.Location = new System.Drawing.Point(591, 484);
            this.btn_sqlToXml.Name = "btn_sqlToXml";
            this.btn_sqlToXml.Size = new System.Drawing.Size(125, 46);
            this.btn_sqlToXml.TabIndex = 39;
            this.btn_sqlToXml.Text = "SQL -> XML";
            this.btn_sqlToXml.UseVisualStyleBackColor = false;
            this.btn_sqlToXml.Click += new System.EventHandler(this.btn_sqlToXml_Click);
            // 
            // btn_xmlToSql
            // 
            this.btn_xmlToSql.BackColor = System.Drawing.Color.Gold;
            this.btn_xmlToSql.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xmlToSql.Location = new System.Drawing.Point(747, 484);
            this.btn_xmlToSql.Name = "btn_xmlToSql";
            this.btn_xmlToSql.Size = new System.Drawing.Size(125, 46);
            this.btn_xmlToSql.TabIndex = 40;
            this.btn_xmlToSql.Text = "XML -> SQL";
            this.btn_xmlToSql.UseVisualStyleBackColor = false;
            this.btn_xmlToSql.Click += new System.EventHandler(this.btn_xmlToSql_Click);
            // 
            // QuanLyDoGiaDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 542);
            this.Controls.Add(this.btn_xmlToSql);
            this.Controls.Add(this.btn_sqlToXml);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dgv_doGiaDung);
            this.Controls.Add(this.txt_baoHanh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tenDoGD);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_nguonGoc);
            this.Controls.Add(this.txt_maDoGD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyDoGiaDung";
            this.Text = "QuanLyDoGiaDung";
            this.Load += new System.EventHandler(this.QuanLyDoGiaDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doGiaDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dgv_doGiaDung;
        private System.Windows.Forms.TextBox txt_baoHanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tenDoGD;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_nguonGoc;
        private System.Windows.Forms.TextBox txt_maDoGD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sqlToXml;
        private System.Windows.Forms.Button btn_xmlToSql;
    }
}