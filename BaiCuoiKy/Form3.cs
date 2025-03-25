using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BaiCuoiKy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM NXB", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
            comboBox1.DataSource = tb;
            comboBox1.DisplayMember = "TenNXB";
            comboBox1.ValueMember = "ID_NXB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"INSERT INTO NXB(ID_NXB, TenNXB, DiaChi, NgayThanhLap, Status) VALUES('{0}','{1}','{2}','{3}','{4}')",
                                        comboBox1.Text, textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), textBox3.Text);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM NXB", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"SELECT * FROM NXB WHERE ID_NXB='{0}'", comboBox1.SelectedValue);
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                textBox1.Text = tb.Rows[0]["TenNXB"].ToString();
                textBox2.Text = tb.Rows[0]["DiaChi"].ToString();
                dateTimePicker1.Text = tb.Rows[0]["NgayThanhLap"].ToString();
                textBox3.Text = tb.Rows[0]["Status"].ToString();
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"UPDATE NXB SET TenNXB='{0}', DiaChi='{1}',  NgayThanhLap='{2}',  Status='{3}'  WHERE ID_NXB='{4}'",
                             textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBox3.Text, comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã sửa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM NXB", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"DELETE FROM NXB WHERE ID_NXB='{0}'", comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM NXB", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = @"SELECT * FROM NXB";
            string dk = "1=1";
            if (textBox1.Text.Trim() != "") dk = dk + string.Format(" and TenNXB='{0}'", textBox1.Text);
            if (textBox2.Text.Trim() != "") dk = dk + string.Format(" and DiaChi='{0}'", textBox2.Text);
            dk = dk + string.Format(" and NgayThanhLap >= #{0:MM/dd/yyyy}# ", dateTimePicker1.Value);
            sql = sql + " Where " + dk;
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }
    }
}
