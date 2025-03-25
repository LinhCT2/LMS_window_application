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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BaiCuoiKy
{
    public partial class FPass : Form
    {
        public FPass()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtMkCu.Text) ||
                string.IsNullOrWhiteSpace(txtMkMoi.Text) ||
                string.IsNullOrWhiteSpace(txtNlaiMk.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (txtMkMoi.Text != txtNlaiMk.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp, vui lòng nhập lại.");
                txtMkCu.Clear();
                txtMkMoi.Clear();
                txtNlaiMk.Clear();
                txtUser.Clear();
                txtUser.Focus();
                return;
            }

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Library_Management_3rd_Ses2.accdb";

            try
            {
                conn.Open();
                string sql = "UPDATE Users SET [Password]=? WHERE Ten_User=? And [Password]=?";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.AddWithValue("?", txtMkMoi.Text);
                cmd.Parameters.AddWithValue("?", txtUser.Text);
                cmd.Parameters.AddWithValue("?", txtMkCu.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Mật khẩu đã được thay đổi.");
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu cũ không chính xác, vui lòng nhập lại.");
                    txtMkCu.Clear();
                    txtMkMoi.Clear();
                    txtNlaiMk.Clear();
                    txtUser.Clear();
                    txtUser.Focus();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMkCu.UseSystemPasswordChar = false;
                txtMkMoi.UseSystemPasswordChar=false;
                txtNlaiMk.UseSystemPasswordChar = false;
            }
            else
            {
                txtMkCu.UseSystemPasswordChar = true;
                txtMkMoi.UseSystemPasswordChar = true;
                txtNlaiMk.UseSystemPasswordChar = true;
            }
        }
    }
}
