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
        DataTable table2 = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        void loaddata2()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From PhongBan";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dataGridView2.DataSource = table2;
        }

        public Form1()
        {
            InitializeComponent();
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab4DataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.lab4DataSet.PhongBan);
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
            txtMaphongban1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into NhanVien Values ('"+txtManhanvien.Text+"', '"+txtHoten.Text+"', '"+txtDiachi.Text+"', '"+txtSDTnv.Text+"', '"+txtMaphongban1.Text+"')";
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
            command.CommandText = "Update NhanVien set hoTen = '"+txtHoten.Text+"', diaChi = '"+txtDiachi.Text+"', soDT = '"+txtSDTnv.Text+"', maPhongBan = '"+txtMaphongban1.Text+"' where maNhanVien = '"+txtManhanvien.Text+"'";
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
            txtMaphongban1.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtMaphongban2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtSDTpb.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txtDiadiem.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThempb_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into PhongBan Values ('" + txtMaphongban2.Text + "', '" + txtSDTpb.Text + "', '" + txtDiadiem.Text + "')";
            command.ExecuteNonQuery();
            loaddata2();
        }

        private void btnXoaphongban_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete From NhanVien Where maPhongBan = '" + txtMaphongban2.Text + "'";
            command.ExecuteNonQuery();
            command.CommandText = "Delete From PhongBan Where maPhongBan = '" + txtMaphongban2.Text + "'";
            command.ExecuteNonQuery();
            loaddata2();
            loaddata();
        }

        private void btnCapnhatpb_Click(object sender, EventArgs e)
        {
            txtMaphongban2.Text = "";
            txtSDTpb.Text = "";
            txtDiadiem.Text = "";
            loaddata2();
        }
    }
}
