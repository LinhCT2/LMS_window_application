using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BaiCuoiKy
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Library_Management_3rd_Ses2.accdb";

            try
            {
                conn.Open();
                string sql = "SELECT Ten_User, Password FROM Users WHERE Ten_User = ? AND Password = ?";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.Add(new OleDbParameter("Ten_User", OleDbType.VarChar)).Value = txtUsername.Text;
                cmd.Parameters.Add(new OleDbParameter("Password", OleDbType.VarChar)).Value = txtpassword.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu bạn vừa nhập không chính xác, hãy thử lại");
                    txtUsername.Clear();
                    txtpassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnFPass_Click(object sender, EventArgs e)
        {

        }

        private void CbMk_CheckedChanged(object sender, EventArgs e)
        {
            if (CbMk.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
