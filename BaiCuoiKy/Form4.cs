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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM DocGia", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
            comboBox1.DataSource = tb;
            comboBox1.DisplayMember = "HoTen";
            comboBox1.ValueMember = "ID_DocGia";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"INSERT INTO DocGia(ID_DocGia, HoTen, NgaySinh, CongViec, DiaChi, CCCD, NgayCap, NgayHetHan, SoSachDuocMuon, Status) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                        comboBox1.Text, textBox1.Text, dateTimePicker1.Value.ToString(), textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker2.Value.ToString(), dateTimePicker3.Value.ToString(), textBox5.Text, textBox6.Text);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM DocGia", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"SELECT * FROM DocGia WHERE ID_DocGia='{0}'", comboBox1.SelectedValue);
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                textBox1.Text = tb.Rows[0]["HoTen"].ToString();
                dateTimePicker1.Text = tb.Rows[0]["NgaySinh"].ToString();
                textBox2.Text = tb.Rows[0]["CongViec"].ToString();
                textBox3.Text = tb.Rows[0]["DiaChi"].ToString();
                textBox4.Text = tb.Rows[0]["CCCD"].ToString();
                dateTimePicker2.Text = tb.Rows[0]["NgayCap"].ToString();
                dateTimePicker3.Text = tb.Rows[0]["NgayHetHan"].ToString();
                textBox5.Text = tb.Rows[0]["SoSachDuocMuon"].ToString();
                textBox6.Text = tb.Rows[0]["Status"].ToString();
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"UPDATE DocGia SET HoTen='{0}', NgaySinh='{1}',  CongViec='{2}',  DiaChi='{3}',  CCCD='{4}',  NgayCap='{5}',  NgayHetHan='{6}',  SoSachDuocMuon='{7}',  Status='{8}'  WHERE ID_DocGia='{9}'",
                             textBox1.Text, dateTimePicker1.Value, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker2.Value, dateTimePicker3.Value, textBox5.Text, textBox6.Text, comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã sửa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM DocGia", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"DELETE FROM DocGia WHERE ID_DocGia='{0}'", comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM DocGia", conn);
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
            string sql = @"SELECT * FROM DocGia";
            string dk = "1=1";
            if (textBox1.Text.Trim() != "") dk = dk + string.Format(" and HoTen='{0}'", textBox1.Text);
            dk = dk + string.Format(" and NgaySinh >= #{0:MM/dd/yyyy}# ", dateTimePicker1.Value);
            if (textBox2.Text.Trim() != "") dk = dk + string.Format(" and CongViec='{0}'", textBox2.Text);
            if (textBox3.Text.Trim() != "") dk = dk + string.Format(" and DiaChi='{0}'", textBox3.Text);
            if (textBox4.Text.Trim() != "") dk = dk + string.Format(" and CCCD='{0}'", textBox4.Text);
            dk = dk + string.Format(" and NgayCap >= #{0:MM/dd/yyyy}# ", dateTimePicker2.Value);
            dk = dk + string.Format(" and NgayHetHan >= #{0:MM/dd/yyyy}# ", dateTimePicker3.Value);
            if (textBox5.Text.Trim() != "") dk = dk + string.Format(" and SoSachDuocMuon='{0}'", textBox5.Text);
            sql = sql + " Where " + dk;
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }
    }
}
