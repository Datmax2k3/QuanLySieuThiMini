using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýRauCủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThucPham quanLyRauCu = new QuanLyThucPham();
            quanLyRauCu.Show();
        }

        private void toolStrip_doGiaDung_Click(object sender, EventArgs e)
        {
            QuanLyDoGiaDung quanLyDoGiaDung = new QuanLyDoGiaDung();
            quanLyDoGiaDung.Show();
        }

        private void toolStrip_khachHang_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.Show();
        }
    }
}
