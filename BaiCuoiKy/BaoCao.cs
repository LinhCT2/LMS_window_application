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

namespace BaiCuoiKy
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnTkSach_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT Sach.ID_Sach, Sach.TenSach, NXB.TenNXB, TacGia.TenTacGia, TheLoai.TheLoai, Sach.NamXB, Sach.SoBan, Sach.SoTrang, Sach.GiaSach, Sach.Status FROM TheLoai INNER JOIN (TacGia INNER JOIN (NXB INNER JOIN Sach ON NXB.ID_NXB = Sach.ID_NXB) ON TacGia.ID_TacGia = Sach.ID_TacGia) ON TheLoai.ID_TheLoai = Sach.ID_TheLoai", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void btnTkDocGia_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM DocGia", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView2.DataSource = tb;
        }

        private void btnTkMuonSach_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT DocGia.HoTen, Sach.TenSach, MuonSach.NgayMuon, MuonSach.NgayHenTra, MuonSach.NgayTra, MuonSach.SoLuong, MuonSach.Status, MuonSach.Tra, MuonSach.TinhTrang, MuonSach.SoTienPhat FROM (MuonSach INNER JOIN DocGia ON MuonSach.ID_DocGia = DocGia.ID_DocGia) INNER JOIN Sach ON MuonSach.ID_Sach = Sach.ID_Sach;", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView3.DataSource = tb;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT DocGia.HoTen, Sach.TenSach, MuonSach.NgayMuon, MuonSach.NgayHenTra, MuonSach.SoLuong, Sach.GiaSach, Sach.ID_Sach, Sach.ID_NXB, MuonSach.ID_DocGia, MuonSach.Tra, MuonSach.NgayTra, MuonSach.TinhTrang, MuonSach.SoTienPhat FROM DocGia INNER JOIN (Sach INNER JOIN MuonSach ON Sach.ID_Sach = MuonSach.ID_Sach) ON DocGia.ID_DocGia = MuonSach.ID_DocGia WHERE (((MuonSach.Tra)=No))", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView4.DataSource = tb;
        }

        private void btnTkNguoiTra_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT DocGia.HoTen, Sach.TenSach, MuonSach.NgayMuon, MuonSach.NgayHenTra, MuonSach.NgayTra, MuonSach.TinhTrang, MuonSach.SoTienPhat, MuonSach.Tra\r\nFROM (MuonSach INNER JOIN DocGia ON MuonSach.ID_DocGia = DocGia.ID_DocGia) INNER JOIN Sach ON MuonSach.ID_Sach = Sach.ID_Sach WHERE (((MuonSach.Tra)=Yes))", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView5.DataSource = tb;
        }

        private void btnTkQuaHan_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT DocGia.HoTen, Sach.TenSach, MuonSach.NgayMuon, MuonSach.NgayHenTra, MuonSach.NgayTra, MuonSach.SoLuong, MuonSach.Status, MuonSach.Tra, MuonSach.TinhTrang, MuonSach.SoTienPhat\r\nFROM (MuonSach INNER JOIN DocGia ON MuonSach.ID_DocGia = DocGia.ID_DocGia) INNER JOIN Sach ON MuonSach.ID_Sach = Sach.ID_Sach\r\nWHERE MuonSach.NgayTra>MuonSach.NgayHenTra;\r\n", conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dataGridView6.DataSource = tb;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btn6Thang_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();

            DateTime t = DateTime.Now.AddMonths(-6);
            string sql = string.Format(@"SELECT ms.ID_Sach, Count(*) AS SoLanMuon, Sach.TenSach, Sum(ms.SoLuong) AS SLSachMuon
                FROM MuonSach AS ms INNER JOIN Sach ON ms.ID_Sach = Sach.ID_Sach
                WHERE (((ms.NgayMuon)>=#{0}#))
                GROUP BY ms.ID_Sach, Sach.TenSach
                HAVING (((Count(*))>0))
                ORDER BY Count(*) DESC;", t);

            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            dgv6Thang.DataSource = tb;

            string sql1 = string.Format(@"SELECT COUNT(*) AS SoDocGia
                FROM (
                    SELECT ID_DocGia
                    FROM MuonSach ms
                    WHERE ms.NgayMuon >= #{0}#
                    GROUP BY ID_DocGia
                ) AS DocGiaDaMuon;
                ", t);
            OleDbCommand cmd = new OleDbCommand(sql1, conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lblDGMS.Text = reader["SoDocGia"].ToString();
            }
            
            string sql2 = string.Format(@"SELECT Sum(MuonSach.SoTienPhat) as TongSoTienPhat
                FROM MuonSach
                WHERE (((MuonSach.NgayMuon)>=#{0}#));
                ", t);
            OleDbCommand cmd1 = new OleDbCommand(sql2, conn);
            OleDbDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                lblNumTienPhat.Text = reader1["TongSoTienPhat"].ToString() + " vnd";
            }
        }
    }
}
