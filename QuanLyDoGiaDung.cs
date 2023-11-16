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
    public partial class QuanLyDoGiaDung : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        string path = Application.StartupPath + "\\data\\quanlydogiadung.xml";
        public QuanLyDoGiaDung()
        {
            InitializeComponent();
        }

        private void showFileXml_Click(object sender, EventArgs e)
        {
            xuly.ViewXML(path);
        }

        public void reset()
        {
            txt_maDoGD.Text = "";
            txt_tenDoGD.Text = "";
            txt_soLuong.Text = "";
            txt_gia.Text = "";
            txt_nguonGoc.Text = "";
            txt_baoHanh.Text = "";

            txt_maDoGD.Enabled = true;
            sql = "select * from DoGiaDung";
            dgv_doGiaDung.DataSource = xuly.getTable(sql);
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


        private void QuanLyDoGiaDung_Load(object sender, EventArgs e)
        {
            sql = "select * from DoGiaDung";
            dgv_doGiaDung.DataSource = xuly.getTable(sql);
            dgv_doGiaDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sql = "select maDoGD from DoGiaDung ";
            DataTable dt = xuly.getTable(sql);
            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                object item = row[index];
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            sql = "insert into DoGiaDung values('" + txt_maDoGD.Text + "',N'" + txt_tenDoGD.Text + "',N'" + txt_soLuong.Text + "','" + txt_gia.Text + "',N'" + txt_nguonGoc.Text + "',N'" + txt_baoHanh.Text + "')";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "update DoGiaDung set tenDoGD = N'" + txt_tenDoGD.Text + "', soLuong = '" + txt_soLuong.Text + "', gia = '" + txt_gia.Text + "', nguonGoc = N'" + txt_nguonGoc.Text + "', baoHanh = N'" + txt_baoHanh.Text + "' where maDoGD = '" + txt_maDoGD.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "delete from DoGiaDung where maDoGD = '" + txt_maDoGD.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            sql = "select * from DoGiaDung where tenDoGD like N'%" + txt_search.Text + "%'";
            dgv_doGiaDung.DataSource = xuly.getTable(sql);
        }


        private void btn_sqlToXml_Click(object sender, EventArgs e)
        {
            sql = "Select * from DoGiaDung for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><dogiadung>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</dogiadung>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);
        }
        private void btn_xmlToSql_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from DoGiaDung");

                xuly.capNhatTungBang(path, "DoGiaDung");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_doGiaDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ok");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_doGiaDung.Rows[e.RowIndex];
                txt_maDoGD.Text = row.Cells[0].Value.ToString();
                txt_tenDoGD.Text = row.Cells[1].Value.ToString();
                txt_soLuong.Text = row.Cells[2].Value.ToString();
                txt_gia.Text = row.Cells[3].Value.ToString();
                txt_nguonGoc.Text = row.Cells[4].Value.ToString();
                txt_baoHanh.Text = row.Cells[5].Value.ToString();
                txt_maDoGD.Enabled = false;
            }
        }
    }
}
