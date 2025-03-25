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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM TacGia", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;

            comboBox1.DataSource = tb;
            comboBox1.DisplayMember = "TenTacGia";
            comboBox1.ValueMember = "ID_TacGia";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"INSERT INTO TacGia(ID_TacGia, TenTacGia, ChucDanh, NoiLamViec, Status ) VALUES('{0}','{1}','{2}', '{3}', '{4}')",
                                        comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM TacGia", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"SELECT * FROM TacGia WHERE ID_TacGia='{0}'", comboBox1.SelectedValue);
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                textBox1.Text = tb.Rows[0]["TenTacGia"].ToString();
                textBox2.Text = tb.Rows[0]["ChucDanh"].ToString();
                textBox3.Text = tb.Rows[0]["NoiLamViec"].ToString();
                textBox4.Text = tb.Rows[0]["Status"].ToString();
            }
            //conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"UPDATE TacGia SET TenTacGia='{0}', ChucDanh='{1}', NoiLamViec='{2}', Status='{3}' WHERE ID_TacGia='{4}'",
                             textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã sửa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM TacGia", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"DELETE FROM TacGia WHERE ID_TacGia='{0}'", comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM TacGia", conn);
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

            string sql = @"SELECT * FROM TacGia";
            string dk = "1=1";
            if (textBox1.Text.Trim() != "") dk = dk + string.Format(" and TenTacGia='{0}'", textBox1.Text);
            if (textBox2.Text.Trim() != "") dk = dk + string.Format(" and ChucDanh='{0}'", textBox2.Text);
            if (textBox3.Text.Trim() != "") dk = dk + string.Format(" and NoiLamViec='{0}'", textBox3.Text);
            sql = sql + " Where " + dk;
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }
    }
}
