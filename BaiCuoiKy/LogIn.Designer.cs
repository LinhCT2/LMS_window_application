namespace BaiCuoiKy
{
    partial class LogIn
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
            txtLogIn = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtpassword = new TextBox();
            label2 = new Label();
            btnFPass = new Label();
            btnDN = new Button();
            CbMk = new CheckBox();
            SuspendLayout();
            // 
            // txtLogIn
            // 
            txtLogIn.AutoSize = true;
            txtLogIn.Font = new Font("Segoe UI", 28F);
            txtLogIn.Location = new Point(126, 46);
            txtLogIn.Name = "txtLogIn";
            txtLogIn.Size = new Size(351, 74);
            txtLogIn.TabIndex = 0;
            txtLogIn.Text = "ĐĂNG NHẬP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(59, 157);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 1;
            label1.Text = "User:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(192, 157);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(192, 228);
            txtpassword.Margin = new Padding(4);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(310, 31);
            txtpassword.TabIndex = 4;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(59, 228);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnFPass
            // 
            btnFPass.AutoSize = true;
            btnFPass.Location = new Point(59, 322);
            btnFPass.Name = "btnFPass";
            btnFPass.Size = new Size(142, 25);
            btnFPass.TabIndex = 5;
            btnFPass.Text = "Quên mật khẩu?";
            btnFPass.Click += btnFPass_Click;
            // 
            // btnDN
            // 
            btnDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDN.Location = new Point(58, 361);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(499, 47);
            btnDN.TabIndex = 6;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = true;
            btnDN.Click += button1_Click;
            // 
            // CbMk
            // 
            CbMk.AutoSize = true;
            CbMk.Location = new Point(349, 276);
            CbMk.Name = "CbMk";
            CbMk.Size = new Size(153, 29);
            CbMk.TabIndex = 7;
            CbMk.Text = "Hiện mật khẩu";
            CbMk.UseVisualStyleBackColor = true;
            CbMk.CheckedChanged += CbMk_CheckedChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 480);
            Controls.Add(CbMk);
            Controls.Add(btnDN);
            Controls.Add(btnFPass);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtLogIn);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtLogIn;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtpassword;
        private Label label2;
        private Label btnFPass;
        private Button btnDN;
        private CheckBox CbMk;
    }
}