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

namespace BaiCuoiKy
{
    public partial class Sach : Form
    {
        String sql;
        OleDbConnection conn = new OleDbConnection();

        public Sach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void Sach_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();

            load(sender, e);


        }

        private void load_DanhSach( object sender, EventArgs e)
        {
            string sql = string.Format(@"SELECT Sach.ID_Sach, Sach.TenSach, Sach.ID_NXB, Sach.ID_TacGia, Sach.ID_TheLoai, NXB.TenNXB, TacGia.TenTacGia, TheLoai.TheLoai, Sach.NamXB, Sach.SoBan, Sach.SoTrang, Sach.KhoSach, Sach.GiaSach
                FROM ((Sach INNER JOIN TacGia ON Sach.ID_TacGia = TacGia.ID_TacGia) 
                INNER JOIN TheLoai ON Sach.ID_TheLoai = TheLoai.ID_TheLoai) 
                INNER JOIN NXB ON Sach.ID_NXB = NXB.ID_NXB;
                ");
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSach.AutoGenerateColumns = false;
            dgvSach.DataSource = dt;
        }

        private void load(object sender, EventArgs e)
        {
            /*string sql = string.Format(@"SELECT Sach.ID_Sach, Sach.TenSach, NXB.TenNXB, TacGia.TenTacGia, TheLoai.TheLoai, Sach.NamXB, Sach.SoBan, Sach.SoTrang, Sach.KhoSach, Sach.GiaSach
                    FROM ((Sach INNER JOIN NXB ON Sach.ID_NXB = NXB.ID_NXB) 
                    INNER JOIN TacGia ON Sach.ID_TacGia = TacGia.ID_TacGia) 
                    INNER JOIN TheLoai ON Sach.ID_TheLoai = TheLoai.ID_TheLoai;
                    ");*/
            string sql = string.Format(@"SELECT Sach.ID_Sach, Sach.TenSach, Sach.ID_NXB, Sach.ID_TacGia, Sach.ID_TheLoai, NXB.TenNXB, TacGia.TenTacGia, TheLoai.TheLoai, Sach.NamXB, Sach.SoBan, Sach.SoTrang, Sach.KhoSach, Sach.GiaSach
                FROM ((Sach INNER JOIN TacGia ON Sach.ID_TacGia = TacGia.ID_TacGia) 
                INNER JOIN TheLoai ON Sach.ID_TheLoai = TheLoai.ID_TheLoai) 
                INNER JOIN NXB ON Sach.ID_NXB = NXB.ID_NXB;
                ");
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSach.AutoGenerateColumns = false;
            dgvSach.DataSource = dt;

            cbbID_Sach.DataSource = dt;
            cbbID_Sach.DisplayMember = "TenSach";
            cbbID_Sach.ValueMember = "ID_Sach";

            cbbNXB.DataSource = dt;
            cbbNXB.DisplayMember = "TenNXB";
            cbbNXB.ValueMember = "ID_NXB";

            cbbTL.DataSource = dt;
            cbbTL.DisplayMember = "TheLoai";
            cbbTL.ValueMember = "ID_TheLoai";

            cbbTG.DataSource = dt;
            cbbTG.DisplayMember = "TenTacGia";
            cbbTG.ValueMember = "ID_TacGia";




        }

        private void button1_Click(object sender, EventArgs e)//them sach
        {
            Boolean t = chk_idSach(cbbID_Sach.Text);

            if (t == true)
            {
                string sql = string.Format(@"INSERT INTO Sach(ID_Sach, TenSach, ID_NXB, ID_TacGia, ID_TheLoai, NamXB, SoBan, SoTrang, KhoSach, GiaSach, Status) VALUES('{0}','{1}','{2}', '{3}', '{4}', {5}, {6}, {7}, '{8}', {9}, {10})",
                                            cbbID_Sach.Text, txtTenSach.Text, cbbNXB.SelectedValue, cbbTG.SelectedValue, cbbTL.SelectedValue, txtNamXB.Text, txtSoBan.Text, txtSoTrang.Text, txtKhoSach.Text, txtGia.Text, 1);
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ban co muon them khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                load_DanhSach(sender, e);
                MessageBox.Show("Them sach thanh cong");
            }
            else
            {
                MessageBox.Show("ID cua ban bi trung, hay nhap ID khac");
                cbbID_Sach.Focus();
            }
        }

        private void cbbID_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format(@"SELECT * FROM Sach WHERE ID_Sach='{0}'", cbbID_Sach.SelectedValue);
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                cbbNXB.SelectedValue = tb.Rows[0]["ID_NXB"].ToString();
                cbbTG.SelectedValue = tb.Rows[0]["ID_TacGia"].ToString();
                cbbTL.SelectedValue = tb.Rows[0]["ID_TheLoai"].ToString();
                txtNamXB.Text = tb.Rows[0]["NamXB"].ToString();
                txtTenSach.Text = tb.Rows[0]["TenSach"].ToString();
                txtSoBan.Text = tb.Rows[0]["SoBan"].ToString();
                txtSoTrang.Text = tb.Rows[0]["SoTrang"].ToString();
                txtKhoSach.Text = tb.Rows[0]["KhoSach"].ToString();
                txtGia.Text = tb.Rows[0]["GiaSach"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)// xoa sach 
        {

            string sql = string.Format(@"DELETE FROM Sach WHERE ID_Sach='{0}'", cbbID_Sach.SelectedValue);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            
            MessageBox.Show("Ban co muon xoa khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            cmd.ExecuteNonQuery();
            load_DanhSach(sender, e);
            MessageBox.Show("Xoa sach thanh cong");


        }

        private void button3_Click(object sender, EventArgs e)// Sua sach
        {

            string sql = string.Format(@"UPDATE Sach SET  TenSach = '{1}', ID_NXB = '{2}', ID_TacGia='{3}', ID_TheLoai = '{4}', NamXB = {5}, SoBan = {6}, SoTrang = {7}, KhoSach = '{8}', GiaSach = {9}, Status = {10}
            WHERE ID_Sach='{0}'", cbbID_Sach.SelectedValue, txtTenSach.Text, cbbNXB.SelectedValue, cbbTG.SelectedValue, cbbTL.SelectedValue, txtNamXB.Text, txtSoBan.Text, txtSoTrang.Text, txtKhoSach.Text, txtGia.Text, 0);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            
            MessageBox.Show("Ban co muon sua khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            cmd.ExecuteNonQuery();
            load_DanhSach(sender, e);
            MessageBox.Show("Sua sach thanh cong");
        }

        private void button5_Click(object sender, EventArgs e)// tim kiem 
        {
            string sql = @"SELECT Sach.ID_Sach, Sach.TenSach, NXB.TenNXB, TacGia.TenTacGia, TheLoai.TheLoai, Sach.NamXB, Sach.SoBan, Sach.SoTrang, Sach.KhoSach, Sach.GiaSach
                    FROM ((Sach INNER JOIN NXB ON Sach.ID_NXB = NXB.ID_NXB) 
                    INNER JOIN TacGia ON Sach.ID_TacGia = TacGia.ID_TacGia) 
                    INNER JOIN TheLoai ON Sach.ID_TheLoai = TheLoai.ID_TheLoai";
            string dk = "1=1";
            if (txtTenSach.Text.Trim() != "") dk = dk + string.Format(" and Sach.TenSach='{0}'", txtTenSach.Text);
            if (cbbID_Sach.SelectedValue.ToString().Trim() != "") dk = dk + string.Format(" and Sach.ID_Sach='{0}'", cbbID_Sach.SelectedValue.ToString());
            if (cbbTG.Text.Trim() != "") dk = dk + string.Format(" and TacGia.TenTacGia='{0}'", cbbTG.Text);
            sql = sql + " Where " + dk;
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dgvSach.DataSource = tb;
            //load(sender, e);
        }

        public Boolean chk_idSach(String text) //ham kiem tra trung lap ID
        {
            string t1 = text;
            string sql = string.Format(@"select ID_Sach from Sach where ID_Sach = '{0}'", t1);

            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    // Check if any rows were returned (meaning a matching ID exists)
                    if (reader.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)// Back
        {
            new Home().Show();
            this.Hide();
        }
    }
}
