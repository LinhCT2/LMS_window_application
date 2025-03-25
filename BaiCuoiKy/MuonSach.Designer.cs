namespace BaiCuoiKy
{
    partial class MuonSach
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
            btnTraSach = new Button();
            groupBox2 = new GroupBox();
            edtSoLuong = new TextBox();
            dtpNgayTra = new DateTimePicker();
            label2 = new Label();
            dtpNgayMuon = new DateTimePicker();
            edtPhieuMuon = new TextBox();
            label6 = new Label();
            btnMuonSach = new Button();
            cbbTenSach = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            cbbTenDG = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button6 = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button5 = new Button();
            textBox5 = new TextBox();
            btnXoa = new Button();
            btnGiaHan = new Button();
            groupBox1 = new GroupBox();
            txtTS = new TextBox();
            dtpNM = new DateTimePicker();
            label18 = new Label();
            lblID_Muon = new Label();
            dtpGiaHan = new DateTimePicker();
            label17 = new Label();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            lblSoLuong = new Label();
            lblTenDG = new Label();
            label1 = new Label();
            dgvMuonSach = new DataGridView();
            HoTen = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            NgayMuon = new DataGridViewTextBoxColumn();
            NgayHenTra = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ID_Muon = new DataGridViewTextBoxColumn();
            Gs = new DataGridViewTextBoxColumn();
            ID_Sach = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).BeginInit();
            SuspendLayout();
            // 
            // btnTraSach
            // 
            btnTraSach.BackColor = SystemColors.ControlLightLight;
            btnTraSach.Location = new Point(429, 187);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(94, 29);
            btnTraSach.TabIndex = 28;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseVisualStyleBackColor = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(edtSoLuong);
            groupBox2.Controls.Add(dtpNgayTra);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtpNgayMuon);
            groupBox2.Controls.Add(edtPhieuMuon);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnMuonSach);
            groupBox2.Controls.Add(cbbTenSach);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbbTenDG);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(611, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(564, 286);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phiếu mượn";
            // 
            // edtSoLuong
            // 
            edtSoLuong.Location = new Point(91, 191);
            edtSoLuong.Name = "edtSoLuong";
            edtSoLuong.Size = new Size(152, 27);
            edtSoLuong.TabIndex = 1;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(369, 99);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(163, 27);
            dtpNgayTra.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 194);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "SoLuong";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(369, 49);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(163, 27);
            dtpNgayMuon.TabIndex = 6;
            // 
            // edtPhieuMuon
            // 
            edtPhieuMuon.Location = new Point(91, 50);
            edtPhieuMuon.Name = "edtPhieuMuon";
            edtPhieuMuon.Size = new Size(152, 27);
            edtPhieuMuon.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 103);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 2;
            label6.Text = "NgayHenTra";
            // 
            // btnMuonSach
            // 
            btnMuonSach.BackColor = SystemColors.ControlLightLight;
            btnMuonSach.Location = new Point(326, 157);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(94, 29);
            btnMuonSach.TabIndex = 8;
            btnMuonSach.Text = "Mượn";
            btnMuonSach.UseVisualStyleBackColor = false;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // cbbTenSach
            // 
            cbbTenSach.FormattingEnabled = true;
            cbbTenSach.Location = new Point(91, 143);
            cbbTenSach.Name = "cbbTenSach";
            cbbTenSach.Size = new Size(152, 28);
            cbbTenSach.TabIndex = 5;
            cbbTenSach.MouseClick += cbbTenSach_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 50);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 8;
            label7.Text = "ID_Muon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 53);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 2;
            label5.Text = "NgayMuon";
            // 
            // cbbTenDG
            // 
            cbbTenDG.FormattingEnabled = true;
            cbbTenDG.Location = new Point(91, 95);
            cbbTenDG.Name = "cbbTenDG";
            cbbTenDG.Size = new Size(152, 28);
            cbbTenDG.TabIndex = 4;
            cbbTenDG.MouseClick += cbbTenDG_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 96);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "TenDocGia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 146);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "TenSach";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Location = new Point(90, 34);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 26;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(853, 118);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 24);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "TacGia";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(734, 118);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(85, 24);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "TenSach";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.Location = new Point(1049, 83);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 23;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(736, 85);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(307, 27);
            textBox5.TabIndex = 22;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ControlLightLight;
            btnXoa.Location = new Point(429, 290);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnGiaHan
            // 
            btnGiaHan.BackColor = SystemColors.ControlLightLight;
            btnGiaHan.Location = new Point(429, 240);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(94, 29);
            btnGiaHan.TabIndex = 20;
            btnGiaHan.Text = "Gia hạn";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTS);
            groupBox1.Controls.Add(dtpNM);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lblID_Muon);
            groupBox1.Controls.Add(dtpGiaHan);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblSoLuong);
            groupBox1.Controls.Add(lblTenDG);
            groupBox1.Location = new Point(90, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 299);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtTS
            // 
            txtTS.BackColor = SystemColors.Control;
            txtTS.BorderStyle = BorderStyle.None;
            txtTS.Location = new Point(137, 104);
            txtTS.Name = "txtTS";
            txtTS.Size = new Size(125, 20);
            txtTS.TabIndex = 7;
            // 
            // dtpNM
            // 
            dtpNM.CalendarMonthBackground = SystemColors.ControlLightLight;
            dtpNM.Format = DateTimePickerFormat.Short;
            dtpNM.Location = new Point(137, 146);
            dtpNM.Name = "dtpNM";
            dtpNM.Size = new Size(133, 27);
            dtpNM.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ActiveCaption;
            label18.Location = new Point(22, 28);
            label18.Name = "label18";
            label18.Size = new Size(68, 20);
            label18.TabIndex = 5;
            label18.Text = "ID_Muon";
            // 
            // lblID_Muon
            // 
            lblID_Muon.AutoSize = true;
            lblID_Muon.BackColor = Color.Transparent;
            lblID_Muon.Location = new Point(137, 28);
            lblID_Muon.Name = "lblID_Muon";
            lblID_Muon.Size = new Size(0, 20);
            lblID_Muon.TabIndex = 4;
            // 
            // dtpGiaHan
            // 
            dtpGiaHan.Format = DateTimePickerFormat.Short;
            dtpGiaHan.Location = new Point(136, 196);
            dtpGiaHan.Name = "dtpGiaHan";
            dtpGiaHan.Size = new Size(134, 27);
            dtpGiaHan.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaption;
            label17.Location = new Point(22, 248);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(67, 20);
            label17.TabIndex = 2;
            label17.Text = "SoLuong";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaption;
            label15.Location = new Point(22, 197);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(91, 20);
            label15.TabIndex = 2;
            label15.Text = "NgayHenTra";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Location = new Point(22, 148);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(82, 20);
            label13.TabIndex = 2;
            label13.Text = "NgayMuon";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Location = new Point(22, 105);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(63, 20);
            label11.TabIndex = 2;
            label11.Text = "TenSach";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Location = new Point(22, 64);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(81, 20);
            label9.TabIndex = 2;
            label9.Text = "TenDocGia";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.BackColor = Color.Transparent;
            lblSoLuong.Location = new Point(137, 248);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(0, 20);
            lblSoLuong.TabIndex = 1;
            // 
            // lblTenDG
            // 
            lblTenDG.AutoSize = true;
            lblTenDG.BackColor = Color.Transparent;
            lblTenDG.Location = new Point(137, 64);
            lblTenDG.Name = "lblTenDG";
            lblTenDG.Size = new Size(0, 20);
            lblTenDG.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(511, 17);
            label1.Name = "label1";
            label1.Size = new Size(196, 46);
            label1.TabIndex = 18;
            label1.Text = "Mượn sách";
            // 
            // dgvMuonSach
            // 
            dgvMuonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuonSach.Columns.AddRange(new DataGridViewColumn[] { HoTen, TenSach, NgayMuon, NgayHenTra, SoLuong, ID_Muon, Gs, ID_Sach });
            dgvMuonSach.Location = new Point(182, 486);
            dgvMuonSach.Name = "dgvMuonSach";
            dgvMuonSach.RowHeadersWidth = 51;
            dgvMuonSach.Size = new Size(861, 301);
            dgvMuonSach.TabIndex = 17;
            dgvMuonSach.CellClick += dgvMuonSach_CellClick;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "TenDocGia";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "TenSach";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.Width = 180;
            // 
            // NgayMuon
            // 
            NgayMuon.DataPropertyName = "NgayMuon";
            NgayMuon.HeaderText = "NgayMuon";
            NgayMuon.MinimumWidth = 6;
            NgayMuon.Name = "NgayMuon";
            NgayMuon.Width = 125;
            // 
            // NgayHenTra
            // 
            NgayHenTra.DataPropertyName = "NgayHenTra";
            NgayHenTra.HeaderText = "NgayHenTra";
            NgayHenTra.MinimumWidth = 6;
            NgayHenTra.Name = "NgayHenTra";
            NgayHenTra.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "SoLuong";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // ID_Muon
            // 
            ID_Muon.DataPropertyName = "ID_Muon";
            ID_Muon.HeaderText = "ID_Muon";
            ID_Muon.MinimumWidth = 6;
            ID_Muon.Name = "ID_Muon";
            ID_Muon.Width = 125;
            // 
            // Gs
            // 
            Gs.DataPropertyName = "GiaSach";
            Gs.HeaderText = "GiaSach";
            Gs.MinimumWidth = 6;
            Gs.Name = "Gs";
            Gs.Width = 125;
            // 
            // ID_Sach
            // 
            ID_Sach.DataPropertyName = "ID_Sach";
            ID_Sach.HeaderText = "ID_Sach";
            ID_Sach.MinimumWidth = 6;
            ID_Sach.Name = "ID_Sach";
            ID_Sach.Width = 125;
            // 
            // MuonSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 825);
            Controls.Add(btnTraSach);
            Controls.Add(groupBox2);
            Controls.Add(button6);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(btnXoa);
            Controls.Add(btnGiaHan);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvMuonSach);
            Margin = new Padding(2);
            Name = "MuonSach";
            Text = "MuonSach";
            Load += MuonSach_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTraSach;
        private GroupBox groupBox2;
        private TextBox edtSoLuong;
        private DateTimePicker dtpNgayTra;
        private Label label2;
        private DateTimePicker dtpNgayMuon;
        private TextBox edtPhieuMuon;
        private Label label6;
        private Button btnMuonSach;
        private ComboBox cbbTenSach;
        private Label label7;
        private Label label5;
        private ComboBox cbbTenDG;
        private Label label3;
        private Label label4;
        private Button button6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button5;
        private TextBox textBox5;
        private Button btnXoa;
        private Button btnGiaHan;
        private GroupBox groupBox1;
        private TextBox txtTS;
        private DateTimePicker dtpNM;
        private Label label18;
        private Label lblID_Muon;
        private DateTimePicker dtpGiaHan;
        private Label label17;
        private Label label15;
        private Label label13;
        private Label label11;
        private Label label9;
        private Label lblSoLuong;
        private Label lblTenDG;
        private Label label1;
        private DataGridView dgvMuonSach;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn NgayHenTra;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ID_Muon;
        private DataGridViewTextBoxColumn Gs;
        private DataGridViewTextBoxColumn ID_Sach;
    }
}