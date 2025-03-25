namespace BaiCuoiKy
{
    partial class FPass
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
            btnDoi = new Button();
            txtMkCu = new TextBox();
            label1 = new Label();
            txtLogIn = new Label();
            txtMkMoi = new TextBox();
            label3 = new Label();
            txtNlaiMk = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnDoi
            // 
            btnDoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoi.Location = new Point(61, 402);
            btnDoi.Name = "btnDoi";
            btnDoi.Size = new Size(667, 47);
            btnDoi.TabIndex = 13;
            btnDoi.Text = "Đổi";
            btnDoi.UseVisualStyleBackColor = true;
            btnDoi.Click += btnDoi_Click;
            // 
            // txtMkCu
            // 
            txtMkCu.Location = new Point(318, 185);
            txtMkCu.Margin = new Padding(4);
            txtMkCu.Name = "txtMkCu";
            txtMkCu.Size = new Size(341, 31);
            txtMkCu.TabIndex = 9;
            txtMkCu.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(130, 185);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 8;
            label1.Text = "Mật khẩu cũ:";
            // 
            // txtLogIn
            // 
            txtLogIn.AutoSize = true;
            txtLogIn.Font = new Font("Segoe UI", 20F);
            txtLogIn.Location = new Point(279, 30);
            txtLogIn.Name = "txtLogIn";
            txtLogIn.Size = new Size(265, 54);
            txtLogIn.TabIndex = 7;
            txtLogIn.Text = "Đổi Mật Khẩu";
            // 
            // txtMkMoi
            // 
            txtMkMoi.Location = new Point(318, 240);
            txtMkMoi.Margin = new Padding(4);
            txtMkMoi.Name = "txtMkMoi";
            txtMkMoi.Size = new Size(341, 31);
            txtMkMoi.TabIndex = 15;
            txtMkMoi.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(130, 246);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 14;
            label3.Text = "Mật khẩu mới:";
            // 
            // txtNlaiMk
            // 
            txtNlaiMk.Location = new Point(318, 304);
            txtNlaiMk.Margin = new Padding(4);
            txtNlaiMk.Name = "txtNlaiMk";
            txtNlaiMk.Size = new Size(341, 31);
            txtNlaiMk.TabIndex = 19;
            txtNlaiMk.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(130, 307);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 18;
            label4.Text = "Nhập lại mật khẩu: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(318, 303);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(341, 31);
            textBox3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(185, 303);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 16;
            label5.Text = "Password:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(318, 126);
            txtUser.Margin = new Padding(4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(341, 31);
            txtUser.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(130, 126);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 20;
            label2.Text = "User:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(341, 470);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 22;
            btnExit.Text = "Trở về";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(506, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(153, 29);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FPass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 552);
            Controls.Add(checkBox1);
            Controls.Add(btnExit);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(txtNlaiMk);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(txtMkMoi);
            Controls.Add(label3);
            Controls.Add(btnDoi);
            Controls.Add(txtMkCu);
            Controls.Add(label1);
            Controls.Add(txtLogIn);
            Name = "FPass";
            Text = "FPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoi;
        private TextBox txtMkCu;
        private Label label1;
        private Label txtLogIn;
        private TextBox txtMkMoi;
        private Label label3;
        private TextBox txtNlaiMk;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox txtUser;
        private Label label2;
        private Button btnExit;
        private CheckBox checkBox1;
    }
}