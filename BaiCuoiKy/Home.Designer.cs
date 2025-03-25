namespace BaiCuoiKy
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDoiMk = new Button();
            btnDx = new Button();
            btnTheLoai = new Button();
            btnTacGia = new Button();
            btnNhaXb = new Button();
            btnTraSach = new Button();
            btnMuonS = new Button();
            btnDocGia = new Button();
            label1 = new Label();
            btnBaoCao = new Button();
            btnSach = new Button();
            SuspendLayout();
            // 
            // btnDoiMk
            // 
            btnDoiMk.Location = new Point(196, 10);
            btnDoiMk.Margin = new Padding(2);
            btnDoiMk.Name = "btnDoiMk";
            btnDoiMk.Size = new Size(106, 27);
            btnDoiMk.TabIndex = 0;
            btnDoiMk.Text = "Đổi Mật Khẩu";
            btnDoiMk.UseVisualStyleBackColor = true;
            btnDoiMk.Click += btnDoiMk_Click;
            // 
            // btnDx
            // 
            btnDx.Location = new Point(343, 10);
            btnDx.Margin = new Padding(2);
            btnDx.Name = "btnDx";
            btnDx.Size = new Size(106, 27);
            btnDx.TabIndex = 1;
            btnDx.Text = "Đăng Xuất";
            btnDx.UseVisualStyleBackColor = true;
            btnDx.Click += btnDx_Click;
            // 
            // btnTheLoai
            // 
            btnTheLoai.Location = new Point(35, 82);
            btnTheLoai.Margin = new Padding(2);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(106, 30);
            btnTheLoai.TabIndex = 2;
            btnTheLoai.Text = "Thể Loại";
            btnTheLoai.UseVisualStyleBackColor = true;
            btnTheLoai.Click += btnTheLoai_Click;
            // 
            // btnTacGia
            // 
            btnTacGia.Location = new Point(35, 143);
            btnTacGia.Margin = new Padding(2);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Size = new Size(106, 30);
            btnTacGia.TabIndex = 3;
            btnTacGia.Text = "Tác Giả";
            btnTacGia.UseVisualStyleBackColor = true;
            btnTacGia.Click += btnTacGia_Click;
            // 
            // btnNhaXb
            // 
            btnNhaXb.Location = new Point(35, 202);
            btnNhaXb.Margin = new Padding(2);
            btnNhaXb.Name = "btnNhaXb";
            btnNhaXb.Size = new Size(106, 30);
            btnNhaXb.TabIndex = 4;
            btnNhaXb.Text = "Nhà Xuất Bản";
            btnNhaXb.UseVisualStyleBackColor = true;
            btnNhaXb.Click += btnNhaXb_Click;
            // 
            // btnTraSach
            // 
            btnTraSach.Location = new Point(196, 202);
            btnTraSach.Margin = new Padding(2);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(106, 30);
            btnTraSach.TabIndex = 7;
            btnTraSach.Text = "Trả Sách";
            btnTraSach.UseVisualStyleBackColor = true;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // btnMuonS
            // 
            btnMuonS.Location = new Point(196, 143);
            btnMuonS.Margin = new Padding(2);
            btnMuonS.Name = "btnMuonS";
            btnMuonS.Size = new Size(106, 30);
            btnMuonS.TabIndex = 6;
            btnMuonS.Text = "Mượn Sách";
            btnMuonS.UseVisualStyleBackColor = true;
            btnMuonS.Click += btnMuonS_Click;
            // 
            // btnDocGia
            // 
            btnDocGia.Location = new Point(196, 82);
            btnDocGia.Margin = new Padding(2);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Size = new Size(106, 30);
            btnDocGia.TabIndex = 5;
            btnDocGia.Text = "Độc Giả";
            btnDocGia.UseVisualStyleBackColor = true;
            btnDocGia.Click += btnDocGia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(35, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 8;
            label1.Text = "Hi, Admin";
            // 
            // btnBaoCao
            // 
            btnBaoCao.Location = new Point(343, 82);
            btnBaoCao.Margin = new Padding(2);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(106, 30);
            btnBaoCao.TabIndex = 9;
            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnSach
            // 
            btnSach.Location = new Point(343, 144);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(106, 29);
            btnSach.TabIndex = 10;
            btnSach.Text = "Sách";
            btnSach.UseVisualStyleBackColor = true;
            btnSach.Click += btnSach_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 363);
            Controls.Add(btnSach);
            Controls.Add(btnBaoCao);
            Controls.Add(label1);
            Controls.Add(btnTraSach);
            Controls.Add(btnMuonS);
            Controls.Add(btnDocGia);
            Controls.Add(btnNhaXb);
            Controls.Add(btnTacGia);
            Controls.Add(btnTheLoai);
            Controls.Add(btnDx);
            Controls.Add(btnDoiMk);
            Margin = new Padding(2);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoiMk;
        private Button btnDx;
        private Button btnTheLoai;
        private Button btnTacGia;
        private Button btnNhaXb;
        private Button btnTraSach;
        private Button btnMuonS;
        private Button btnDocGia;
        private Label label1;
        private Button btnBaoCao;
        private Button btnSach;
    }
}