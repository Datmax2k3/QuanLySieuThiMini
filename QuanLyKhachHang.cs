using System;
using System.Collections;
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
    public partial class QuanLyKhachHang : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        string path = Application.StartupPath + "\\data\\quanlykhachhang.xml";
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void showFileXml_Click(object sender, EventArgs e)
        {
            xuly.ViewXML(path);
        }


        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            sql = "select * from KhachHang";
            grv_KhachHang.DataSource = xuly.getTable(sql);
            grv_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sql = "select maKH from KhachHang ";
            DataTable dt = xuly.getTable(sql);
            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                object item = row[index];
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            sql = "insert into KhachHang values('" + txt_maKH.Text + "',N'" + txt_tenKH.Text + "',N'" + txt_sdt.Text + "','" + txt_email.Text + "',N'" + txt_gioiTinh.Text + "',N'" + txt_ngaySinh.Text + "')";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "update KhachHang set tenKH = N'" + txt_tenKH.Text + "', sdt = N'" + txt_sdt.Text + "', email = '" + txt_email.Text + "', gioiTinh = '" + txt_gioiTinh.Text + "', ngaySinh = '" + txt_ngaySinh.Text + "' where maKH = '" + txt_maKH.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "delete from KhachHang where maKh = '" + txt_maKH.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        public void reset()
        {
            txt_maKH.Text = "";
            txt_tenKH.Text = "";
            txt_sdt.Text = "";
            txt_email.Text = "";
            txt_gioiTinh.Text = "";
            txt_ngaySinh.Text = "";

            txt_maKH.Enabled = true;
            sql = "select * from KhachHang";
            grv_KhachHang.DataSource = xuly.getTable(sql);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            sql = "select * from KhachHang where tenKH like N'%" + txt_search.Text + "%'";
            grv_KhachHang.DataSource = xuly.getTable(sql);
        }

        private void btn_sqlToXml_Click(object sender, EventArgs e)
        {
            sql = "Select * from KhachHang for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><khachhang>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</khachhang>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);
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

        private void grv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ok");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grv_KhachHang.Rows[e.RowIndex];
                txt_maKH.Text = row.Cells[0].Value.ToString();
                txt_tenKH.Text = row.Cells[1].Value.ToString();
                txt_sdt.Text = row.Cells[2].Value.ToString();
                txt_email.Text = row.Cells[3].Value.ToString();
                txt_gioiTinh.Text = row.Cells[4].Value.ToString();
                txt_ngaySinh.Text = row.Cells[5].Value.ToString();
                txt_maKH.Enabled = false;
            }
        }

        private void btn_xmlToSql_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from KhachHang");

                xuly.capNhatTungBang(path, "KhachHang");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
