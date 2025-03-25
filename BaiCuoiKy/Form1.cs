using System.Data;
using System.Data.OleDb;

namespace BaiCuoiKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT ID_TheLoai, TheLoai, Status FROM TheLoai", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
            comboBox1.DataSource = tb;
            //comboBox1.DisplayMember = "TheLoai";
            comboBox1.ValueMember = "ID_TheLoai";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"INSERT INTO TheLoai(ID_TheLoai, TheLoai, Status) VALUES('{0}','{1}','{2}')",
                                        comboBox1.Text, textBox1.Text, textBox2.Text);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT ID_TheLoai, TheLoai, Status FROM TheLoai", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"SELECT ID_TheLoai, TheLoai, Status FROM TheLoai WHERE ID_TheLoai='{0}'", comboBox1.SelectedValue);
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                textBox1.Text = tb.Rows[0]["TheLoai"].ToString();
                textBox2.Text = tb.Rows[0]["Status"].ToString();
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"UPDATE TheLoai SET TheLoai='{0}', Status='{1}' WHERE ID_TheLoai='{2}'",
                             textBox1.Text, textBox2.Text, comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã sửa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT ID_TheLoai, TheLoai, Status FROM TheLoai", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = string.Format(@"DELETE FROM TheLoai WHERE ID_TheLoai='{0}'", comboBox1.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa thành công");

            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT ID_TheLoai, TheLoai, Status FROM TheLoai", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            string sql = @"SELECT ID_TheLoai, TheLoai, Status FROM TheLoai";
            string dk = "1=1";
            if (textBox1.Text.Trim() != "") dk = dk + string.Format(" and TheLoai='{0}'", textBox1.Text);
            sql = sql + " Where " + dk;
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string da0 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string da1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string da2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


            comboBox1.Text = da0;
            textBox1.Text = da1;
            textBox2.Text = da2;
        }
    }
}
