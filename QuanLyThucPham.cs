using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMini
{
    public partial class QuanLyThucPham : Form
    {


        public QuanLyThucPham()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            grv_thucPham.DataSource = GetAllThucPham().Tables[0];
        }

        string query = "select * from ThucPham";
        DataSet GetAllThucPham()
        {
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            } 
            return data;
        }
    }
}
