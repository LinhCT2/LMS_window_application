namespace BaiCuoiKy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ID_TheLoai = new DataGridViewTextBoxColumn();
            TheLoai = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(503, 30);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 0;
            label1.Text = "THỂ LOẠI SÁCH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 107);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Thể Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 145);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Thể Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 187);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(246, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(373, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 27);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(698, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(848, 108);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1017, 108);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Location = new Point(125, 47);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 11;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_TheLoai, TheLoai, Status });
            dataGridView1.Location = new Point(125, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(986, 352);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ID_TheLoai
            // 
            ID_TheLoai.DataPropertyName = "ID_TheLoai";
            ID_TheLoai.HeaderText = "ID Thể Loại";
            ID_TheLoai.MinimumWidth = 6;
            ID_TheLoai.Name = "ID_TheLoai";
            ID_TheLoai.Width = 200;
            // 
            // TheLoai
            // 
            TheLoai.DataPropertyName = "TheLoai";
            TheLoai.HeaderText = "Thể Loại";
            TheLoai.MinimumWidth = 6;
            TheLoai.Name = "TheLoai";
            TheLoai.Width = 450;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 282;
            // 
            // button4
            // 
            button4.Location = new Point(698, 178);
            button4.Name = "button4";
            button4.Size = new Size(244, 29);
            button4.TabIndex = 13;
            button4.Text = "Tìm Kiếm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 753);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tìm Kiêm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_TheLoai;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn Status;
        private Button button4;
    }
}
