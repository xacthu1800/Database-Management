using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab4
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ROG-STRIX-G512;Initial Catalog=Lab4;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtManhanvien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtSDTnv.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtMaphongban.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into NhanVien Values ('"+txtManhanvien.Text+"', '"+txtHoten.Text+"', '"+txtDiachi.Text+"', '"+txtSDTnv.Text+"', '"+txtMaphongban.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete From NhanVien Where maNhanVien = '"+txtManhanvien.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Update NhanVien set hoTen = '"+txtHoten.Text+"', diaChi = '"+txtDiachi.Text+"', soDT = '"+txtSDTnv.Text+"', maPhongBan = '"+txtMaphongban.Text+"' where maNhanVien = '"+txtManhanvien.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtManhanvien.Text = "";
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtSDTnv.Text = "";
            txtMaphongban.Text = "";
        }
    }
}
