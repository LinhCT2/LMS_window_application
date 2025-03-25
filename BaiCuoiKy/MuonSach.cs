using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BaiCuoiKy
{
    public partial class MuonSach : Form
    {
        String sql;
        int giasach;
        OleDbConnection conn = new OleDbConnection();

        public MuonSach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();

            load(sender, e);
            
        }

        private void load(object sender, EventArgs e)
        {
            string sql = string.Format(@"SELECT DocGia.HoTen, Sach.TenSach, MuonSach.NgayMuon, MuonSach.NgayHenTra, MuonSach.SoLuong, MuonSach.ID_Muon, Sach.GiaSach, Sach.ID_Sach, Sach.ID_NXB, MuonSach.ID_DocGia, MuonSach.Tra, MuonSach.NgayTra, MuonSach.TinhTrang, MuonSach.SoTienPhat
            FROM DocGia INNER JOIN (Sach INNER JOIN MuonSach ON Sach.ID_Sach = MuonSach.ID_Sach) ON DocGia.ID_DocGia = MuonSach.ID_DocGia
            WHERE (((MuonSach.Tra)=No));
                    ");
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvMuonSach.AutoGenerateColumns = false;
            dgvMuonSach.DataSource = dt;
        }

        public Boolean chk_idMuon(String text) //ham kiem tra trung lap ID
        {
            string t1 = text;
            string sql = string.Format(@"select ID_Muon from MuonSach where ID_Muon = '{0}'", t1);
           
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    // Check if any rows were returned (meaning a matching ID exists)
                    if (reader.HasRows)
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                    
                }
            }

        }

        public void updateDLSachM(int SLSachMuon, string id_Sach)
        {
            string sql = string.Format("UPDATE Sach SET SoBan = SoBan - {0} WHERE ID_Sach = '{1}'", SLSachMuon, id_Sach);

            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("So luong sach cap nhat thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Sach khong tim thay hoac khong co thay doi.");
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Loi cap nhat so luong sach: " + ex.Message);
                }
            }
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            Boolean t = chk_idMuon(edtPhieuMuon.Text);

            if(t == true) 
            { 
                String sql = string.Format(@"Insert into MuonSach(ID_Muon, ID_DocGia, ID_Sach, NgayMuon, NgayHenTra, SoLuong, Status) values ({0}, {1}, '{2}', '{3}', '{4}', {5}, {6})",
                edtPhieuMuon.Text, cbbTenDG.SelectedValue, cbbTenSach.SelectedValue, dtpNgayMuon.Value.Date.ToString("dd/MM/yyyy"), dtpNgayTra.Value.Date.ToString("dd/MM/yyyy"), edtSoLuong.Text, 1);
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                int sl =  int.Parse(edtSoLuong.Text);
                string id_sach = cbbTenSach.SelectedValue.ToString();

                updateDLSachM(sl, id_sach);

                cmd.ExecuteNonQuery();
                load(sender, e);

                MessageBox.Show("Muon sach thanh cong");
            } else
            {
                MessageBox.Show("ID cua ban bi trung, hay nhap ID khac");
                edtPhieuMuon.Focus();
            }
        }
        string IDSach;
        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dgvMuonSach.Rows.Count || e.ColumnIndex >= dgvMuonSach.Columns.Count)
            {
                // Xử lý lỗi
                MessageBox.Show("Lỗi: Vị trí chọn không hợp lệ.");
                return;
            }
            else
            {

                string da0 = dgvMuonSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                string da1 = dgvMuonSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                string da2 = dgvMuonSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                string da3 = dgvMuonSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                string da4 = dgvMuonSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                string da5 = dgvMuonSach.Rows[e.RowIndex].Cells[5].Value.ToString();
                string da6 = dgvMuonSach.Rows[e.RowIndex].Cells[6].Value.ToString();
                string da7 = dgvMuonSach.Rows[e.RowIndex].Cells[7].Value.ToString();


                lblTenDG.Text = da0;
                txtTS.Text = da1;
                dtpNM.Text = da2;
                dtpGiaHan.Text = da3;
                lblSoLuong.Text = da4;
                lblID_Muon.Text = da5;
                //giasach = int.Parse(da6);

                if (da6 == "")
                {
                    giasach = 0;
                }
                else
                {
                    giasach = int.Parse(da6);
                }
                IDSach = da7;

            }
           
        }

        private void cbbTenDG_MouseClick(object sender, MouseEventArgs e)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from DocGia", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbbTenDG.DataSource = dt;
            cbbTenDG.DisplayMember = "HoTen";
            cbbTenDG.ValueMember = "ID_DocGia";
        }

        private void cbbTenSach_MouseClick(object sender, MouseEventArgs e)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from Sach", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbbTenSach.DataSource = dt;
            cbbTenSach.DisplayMember = "TenSach";
            cbbTenSach.ValueMember = "ID_Sach";
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            String sql = string.Format(@"UPDATE MuonSach SET NgayHenTra ='{1}' WHERE ID_Muon= '{0}' ", lblID_Muon.Text, dtpGiaHan.Value.Date.ToString("dd/MM/yyyy"));
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            load(sender, e);

            MessageBox.Show("Ban da gia han ngay tra sach thanh cong");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql = string.Format(@"Delete from MuonSach where ID_Muon = '{0}'", lblID_Muon.Text);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            load(sender, e);

            MessageBox.Show("Ban da xoa phieu muon thanh cong");
        }

        public class Data
        {
            public int Name { get; set; }
            public DateTime Age { get; set; }
            public int SLSach { get; set; }
            public string ID_Sach { get; set; }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            string dateString = dtpGiaHan.Value.Date.ToString("dd/MM/yyyy");
            DateTime dateValue = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);


            TraSach f2 = new TraSach();
            f2.Message = lblID_Muon.Text; //Gán dữ liệu từ textBox1 vào thuộc tính Message của Form2

            

            Data d = new Data();
            d.Age = dateValue;
            d.Name = giasach;
            d.SLSach = int.Parse(lblSoLuong.Text);
            d.ID_Sach = IDSach;
            f2.Data = d;

            f2.Show();
            load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e) //quay ve home 
        {
            new Home().Show();
            this.Hide();
        }
    }
}
