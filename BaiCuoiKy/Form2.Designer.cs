namespace BaiCuoiKy
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ID_TacGia = new DataGridViewTextBoxColumn();
            TenTacGia = new DataGridViewTextBoxColumn();
            ChucDanh = new DataGridViewTextBoxColumn();
            NoiLamViec = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(540, 19);
            label1.Name = "label1";
            label1.Size = new Size(151, 46);
            label1.TabIndex = 0;
            label1.Text = "TÁC GIẢ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 90);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Tác Giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 137);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Tác Giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 90);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Nơi Làm Việc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 137);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 189);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Chức Danh";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(209, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(588, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(588, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 27);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(880, 90);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1017, 90);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(880, 147);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Location = new Point(105, 36);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_TacGia, TenTacGia, ChucDanh, NoiLamViec, Status });
            dataGridView1.Location = new Point(105, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 381);
            dataGridView1.TabIndex = 16;
            // 
            // ID_TacGia
            // 
            ID_TacGia.DataPropertyName = "ID_TacGia";
            ID_TacGia.HeaderText = "ID Tác Giả";
            ID_TacGia.MinimumWidth = 6;
            ID_TacGia.Name = "ID_TacGia";
            ID_TacGia.Width = 125;
            // 
            // TenTacGia
            // 
            TenTacGia.DataPropertyName = "TenTacGia";
            TenTacGia.HeaderText = "Tên Tác Giả";
            TenTacGia.MinimumWidth = 6;
            TenTacGia.Name = "TenTacGia";
            TenTacGia.Width = 290;
            // 
            // ChucDanh
            // 
            ChucDanh.DataPropertyName = "ChucDanh";
            ChucDanh.HeaderText = "Chức Danh";
            ChucDanh.MinimumWidth = 6;
            ChucDanh.Name = "ChucDanh";
            ChucDanh.Width = 160;
            // 
            // NoiLamViec
            // 
            NoiLamViec.DataPropertyName = "NoiLamViec";
            NoiLamViec.HeaderText = "Nơi Làm Việc";
            NoiLamViec.MinimumWidth = 6;
            NoiLamViec.Name = "NoiLamViec";
            NoiLamViec.Width = 300;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // button5
            // 
            button5.Location = new Point(588, 189);
            button5.Name = "button5";
            button5.Size = new Size(221, 29);
            button5.TabIndex = 17;
            button5.Text = "Tìm Kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_TacGia;
        private DataGridViewTextBoxColumn TenTacGia;
        private DataGridViewTextBoxColumn ChucDanh;
        private DataGridViewTextBoxColumn NoiLamViec;
        private DataGridViewTextBoxColumn Status;
        private Button button5;
    }
}