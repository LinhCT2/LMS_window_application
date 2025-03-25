using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiCuoiKy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btnNhaXb_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void btnMuonS_Click(object sender, EventArgs e)
        {
            new MuonSach().Show();
            this.Hide();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            new TraSach().Show();
            this.Hide();
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            new FPass().Show();
            this.Hide();
        }

        private void btnDx_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            new BaoCao().Show();
            this.Hide();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            new Sach().Show();
            this.Hide();
        }
    }
}
