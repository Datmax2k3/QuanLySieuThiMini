using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLySieuThiMini
{
    public partial class QuanLyThucPham : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        string path = Application.StartupPath + "\\data\\quanlythucpham.xml";
        private void showFileXml_Click(object sender, EventArgs e)
        {
            xuly.ViewXML(path);
        }

        public QuanLyThucPham()
        {
            InitializeComponent();
        }

        public void reset()
        {
            txt_maRauCu.Text = "";
            txt_tenRauCu.Text = "";
            txt_soLuong.Text = "";
            txt_gia.Text = "";
            txt_nguonGoc.Text = "";

            txt_maRauCu.Enabled = true;
            sql = "select * from ThucPham";
            grv_thucPham.DataSource = xuly.getTable(sql);
        }

        private void ViewXML(string path)
        {
            // Thử nghiệm mở tệp HTML, XML với browser
            //string path = "../data/student.xml";
            var fullpath = Path.GetFullPath(path);
            //Process.Start("IExplore.exe",fullpath);
            //Process.Start("firefox.exe", fullpath);
            Process.Start("Explorer.exe", fullpath);
        }


        private void QuanLyThucPham_Load(object sender, EventArgs e)
        {
            sql = "select * from ThucPham";
            grv_thucPham.DataSource = xuly.getTable(sql);
            grv_thucPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sql = "select maThucPham from ThucPham ";
            DataTable dt = xuly.getTable(sql);
            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                object item = row[index];
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            sql = "insert into ThucPham values('" + txt_maRauCu.Text + "',N'" + txt_tenRauCu.Text + "',N'" + txt_soLuong.Text + "','" + txt_gia.Text + "',N'" + txt_nguonGoc.Text + "')";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "update ThucPham set tenThucPham = N'" + txt_tenRauCu.Text + "', soLuong = '" + txt_soLuong.Text + "', gia = '" + txt_gia.Text + "', nguonGoc = N'" + txt_nguonGoc.Text + "' where maThucPham = '" + txt_maRauCu.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "delete from ThucPham where maThucPham = '" + txt_maRauCu.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            sql = "select * from ThucPham where tenThucPham like N'%" + txt_search.Text + "%'";
            grv_thucPham.DataSource = xuly.getTable(sql);
        }

        

        private void btn_sqlToXml_Click(object sender, EventArgs e)
        {
            sql = "Select * from ThucPham for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><thucpham>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</thucpham>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);
        }

        private void grv_thucPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ok");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grv_thucPham.Rows[e.RowIndex];
                txt_maRauCu.Text = row.Cells[0].Value.ToString();
                txt_tenRauCu.Text = row.Cells[1].Value.ToString();
                txt_soLuong.Text = row.Cells[2].Value.ToString();
                txt_gia.Text = row.Cells[3].Value.ToString();
                txt_nguonGoc.Text = row.Cells[4].Value.ToString();
                txt_maRauCu.Enabled = false;
            }
        }

        private void btn_xmlToSql_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from ThucPham");

                xuly.capNhatTungBang(path, "ThucPham");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
