namespace BaiCuoiKy
{
    partial class TraSach
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
            button2 = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            dtpTraSach = new DateTimePicker();
            btnTraSach = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            rtbTinhTrangSach = new RichTextBox();
            txtPhatSach = new TextBox();
            label1 = new Label();
            dgvTraSach = new DataGridView();
            ID_Muon = new DataGridViewTextBoxColumn();
            NgayMuon = new DataGridViewTextBoxColumn();
            NgayHenTra = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            SoTienPhat = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTraSach).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(108, 33);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtpTraSach);
            groupBox2.Controls.Add(btnTraSach);
            groupBox2.Location = new Point(626, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 206);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thong tin tra sach";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 33);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 33);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 7;
            label3.Text = "ID_Muon";
            // 
            // dtpTraSach
            // 
            dtpTraSach.Format = DateTimePickerFormat.Short;
            dtpTraSach.Location = new Point(173, 112);
            dtpTraSach.Name = "dtpTraSach";
            dtpTraSach.Size = new Size(148, 27);
            dtpTraSach.TabIndex = 2;
            // 
            // btnTraSach
            // 
            btnTraSach.Location = new Point(50, 110);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(94, 29);
            btnTraSach.TabIndex = 0;
            btnTraSach.Text = "TraSach";
            btnTraSach.UseVisualStyleBackColor = true;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rtbTinhTrangSach);
            groupBox1.Controls.Add(txtPhatSach);
            groupBox1.Location = new Point(108, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 206);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 47);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "Tinh trang sach";
            // 
            // rtbTinhTrangSach
            // 
            rtbTinhTrangSach.Location = new Point(169, 42);
            rtbTinhTrangSach.Name = "rtbTinhTrangSach";
            rtbTinhTrangSach.Size = new Size(185, 52);
            rtbTinhTrangSach.TabIndex = 0;
            rtbTinhTrangSach.Text = "";
            // 
            // txtPhatSach
            // 
            txtPhatSach.Location = new Point(169, 110);
            txtPhatSach.Name = "txtPhatSach";
            txtPhatSach.PlaceholderText = "0";
            txtPhatSach.Size = new Size(125, 27);
            txtPhatSach.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(442, 16);
            label1.Name = "label1";
            label1.Size = new Size(277, 46);
            label1.TabIndex = 0;
            label1.Text = "Theo dõi trả sách";
            // 
            // dgvTraSach
            // 
            dgvTraSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTraSach.Columns.AddRange(new DataGridViewColumn[] { ID_Muon, NgayMuon, NgayHenTra, NgayTra, TinhTrang, SoTienPhat });
            dgvTraSach.Location = new Point(147, 427);
            dgvTraSach.Name = "dgvTraSach";
            dgvTraSach.RowHeadersWidth = 51;
            dgvTraSach.Size = new Size(818, 301);
            dgvTraSach.TabIndex = 7;
            dgvTraSach.CellClick += dgvTraSach_CellClick;
            // 
            // ID_Muon
            // 
            ID_Muon.DataPropertyName = "ID_Muon";
            ID_Muon.HeaderText = "ID_Muon";
            ID_Muon.MinimumWidth = 6;
            ID_Muon.Name = "ID_Muon";
            ID_Muon.Width = 125;
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
            // NgayTra
            // 
            NgayTra.DataPropertyName = "NgayTra";
            NgayTra.HeaderText = "NgayTra";
            NgayTra.MinimumWidth = 6;
            NgayTra.Name = "NgayTra";
            NgayTra.Width = 125;
            // 
            // TinhTrang
            // 
            TinhTrang.DataPropertyName = "TinhTrang";
            TinhTrang.HeaderText = "TinhTrang";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.Width = 125;
            // 
            // SoTienPhat
            // 
            SoTienPhat.DataPropertyName = "SoTienPhat";
            SoTienPhat.HeaderText = "PhatTraSachMuon (vnd)";
            SoTienPhat.MinimumWidth = 6;
            SoTienPhat.Name = "SoTienPhat";
            SoTienPhat.Width = 140;
            // 
            // TraSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 785);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvTraSach);
            Margin = new Padding(2);
            Name = "TraSach";
            Text = "TraSach";
            Load += TraSach_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTraSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpTraSach;
        private Button btnTraSach;
        private GroupBox groupBox1;
        private Label label2;
        private RichTextBox rtbTinhTrangSach;
        private TextBox txtPhatSach;
        private Label label1;
        private DataGridView dgvTraSach;
        private DataGridViewTextBoxColumn ID_Muon;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn NgayHenTra;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn SoTienPhat;
    }
}