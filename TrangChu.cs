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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_qlThucPham_Click(object sender, EventArgs e)
        {
            QuanLyThucPham quanLyRauCu = new QuanLyThucPham();
            quanLyRauCu.Show();
        }

        private void btn_qlDoGiaDung_Click(object sender, EventArgs e)
        {
            QuanLyDoGiaDung quanLyDoGiaDung = new QuanLyDoGiaDung();
            quanLyDoGiaDung.Show();
        }

        private void btn_qlKhachHang_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.Show();
        }


        private void btn_signOut_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
        }
    }
}
