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
using System.Globalization;
using static BaiCuoiKy.MuonSach;

namespace BaiCuoiKy
{
    public partial class TraSach : Form
    {

        String sql;
        OleDbConnection conn = new OleDbConnection();

        public TraSach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string Message { get; set; }

        public Data Data { get; set; }

        private void TraSach_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Management_3rd_Ses2.accdb";
            conn.Open();


            /* cbbTenDG.DataSource = dt;
             cbbTenDG.DisplayMember = "HoTen";
             cbbTenDG.ValueMember = "ID_DocGia";*/

            load(sender, e);
            // conn.Close();
        }

        private void load(object sender, EventArgs e)
        {
            label4.Text = Message;
            string sql = string.Format(@"SELECT MuonSach.ID_Muon, MuonSach.NgayMuon, MuonSach.NgayHenTra, MuonSach.NgayTra, MuonSach.TinhTrang, MuonSach.SoTienPhat, MuonSach.Tra
            FROM MuonSach
            WHERE (((MuonSach.Tra)=Yes));");
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvTraSach.AutoGenerateColumns = false;
            dgvTraSach.DataSource = dt;

            //(((MuonSach.ID_Muon)='{0}') AND
        }

        public void updateDLSachT(int SLSachMuon, string id_Sach)
        {
            string sql = string.Format("UPDATE Sach SET SoBan = SoBan + {0} WHERE ID_Sach = '{1}'", SLSachMuon, id_Sach);

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

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            int giasach = Data.Name;
            int num = 0;

            string dateString = dtpTraSach.Value.Date.ToString("dd/MM/yyyy");
            DateTime dval = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            TimeSpan t = dval - Data.Age;
            int p = 0;

            if (txtPhatSach.Text == "")
            {
                p = 0;
            }
            
            if (t.Days > 0)
            {
                num = ((int)(giasach * 0.1) * t.Days) + p;

            }
            

            string demo = "Yes";
            String sql = string.Format(@"UPDATE MuonSach SET SoTienPhat = {4}, TinhTrang = '{3}', NgayTra = '{2}' ,Tra ={1} WHERE ID_Muon= '{0}'",
                label4.Text, demo, dtpTraSach.Value.Date.ToString("dd/MM/yyyy"), rtbTinhTrangSach.Text, num);

            OleDbCommand cmd = new OleDbCommand(sql, conn);

            updateDLSachT(Data.SLSach, Data.ID_Sach);

            cmd.ExecuteNonQuery();
            load(sender, e);
            MessageBox.Show("Ban da tra sach thanh cong");
        }

        private void dgvTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string da0 = dgvTraSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            string da1 = dgvTraSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            string da2 = dgvTraSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            string da3 = dgvTraSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            string da4 = dgvTraSach.Rows[e.RowIndex].Cells[4].Value.ToString();


            rtbTinhTrangSach.Text = da4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
