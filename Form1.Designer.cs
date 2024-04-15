namespace LoginSignUp
{
    partial class RegisterForm
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
            UsernameTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            label3 = new Label();
            CFPassTxtBox = new TextBox();
            label4 = new Label();
            ShowPassCBox = new CheckBox();
            RegisterBtn = new Button();
            LPasswordTxtBox = new TextBox();
            label5 = new Label();
            LUsernameTxtBox = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            LShowPassCBox = new CheckBox();
            LoginBtn = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(216, 6, 33);
            label1.Location = new Point(106, 42);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(10, 109);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.BackColor = Color.LightGray;
            UsernameTxtBox.BorderStyle = BorderStyle.None;
            UsernameTxtBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTxtBox.Location = new Point(85, 106);
            UsernameTxtBox.Multiline = true;
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(237, 23);
            UsernameTxtBox.TabIndex = 2;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = Color.LightGray;
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTxtBox.Location = new Point(85, 149);
            PasswordTxtBox.MaxLength = 8;
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '•';
            PasswordTxtBox.Size = new Size(237, 23);
            PasswordTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(10, 152);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // CFPassTxtBox
            // 
            CFPassTxtBox.BackColor = Color.LightGray;
            CFPassTxtBox.BorderStyle = BorderStyle.None;
            CFPassTxtBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CFPassTxtBox.Location = new Point(136, 189);
            CFPassTxtBox.MaxLength = 8;
            CFPassTxtBox.Multiline = true;
            CFPassTxtBox.Name = "CFPassTxtBox";
            CFPassTxtBox.PasswordChar = '•';
            CFPassTxtBox.Size = new Size(186, 23);
            CFPassTxtBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(10, 192);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // ShowPassCBox
            // 
            ShowPassCBox.AutoSize = true;
            ShowPassCBox.FlatStyle = FlatStyle.Flat;
            ShowPassCBox.ForeColor = Color.DimGray;
            ShowPassCBox.Location = new Point(200, 218);
            ShowPassCBox.Name = "ShowPassCBox";
            ShowPassCBox.Size = new Size(119, 21);
            ShowPassCBox.TabIndex = 7;
            ShowPassCBox.Text = "Show Password";
            ShowPassCBox.UseVisualStyleBackColor = true;
            ShowPassCBox.CheckedChanged += ShowPassCBox_CheckedChanged;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(216, 6, 33);
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(125, 256);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(81, 42);
            RegisterBtn.TabIndex = 8;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // LPasswordTxtBox
            // 
            LPasswordTxtBox.BackColor = Color.LightGray;
            LPasswordTxtBox.BorderStyle = BorderStyle.None;
            LPasswordTxtBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LPasswordTxtBox.Location = new Point(483, 149);
            LPasswordTxtBox.MaxLength = 8;
            LPasswordTxtBox.Multiline = true;
            LPasswordTxtBox.Name = "LPasswordTxtBox";
            LPasswordTxtBox.PasswordChar = '•';
            LPasswordTxtBox.Size = new Size(237, 23);
            LPasswordTxtBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(216, 6, 33);
            label5.ForeColor = Color.White;
            label5.Location = new Point(408, 152);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // LUsernameTxtBox
            // 
            LUsernameTxtBox.BackColor = Color.LightGray;
            LUsernameTxtBox.BorderStyle = BorderStyle.None;
            LUsernameTxtBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LUsernameTxtBox.Location = new Point(483, 106);
            LUsernameTxtBox.Multiline = true;
            LUsernameTxtBox.Name = "LUsernameTxtBox";
            LUsernameTxtBox.Size = new Size(237, 23);
            LUsernameTxtBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(216, 6, 33);
            label6.ForeColor = Color.White;
            label6.Location = new Point(408, 109);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 9;
            label6.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(216, 6, 33);
            panel1.Controls.Add(LShowPassCBox);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(label7);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(365, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 312);
            panel1.TabIndex = 13;
            // 
            // LShowPassCBox
            // 
            LShowPassCBox.AutoSize = true;
            LShowPassCBox.FlatStyle = FlatStyle.Flat;
            LShowPassCBox.ForeColor = Color.White;
            LShowPassCBox.Location = new Point(236, 191);
            LShowPassCBox.Name = "LShowPassCBox";
            LShowPassCBox.Size = new Size(119, 21);
            LShowPassCBox.TabIndex = 14;
            LShowPassCBox.Text = "Show Password";
            LShowPassCBox.UseVisualStyleBackColor = true;
            LShowPassCBox.CheckedChanged += LShowPassCBox_CheckedChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.ForeColor = Color.FromArgb(216, 6, 33);
            LoginBtn.Location = new Point(162, 257);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(81, 42);
            LoginBtn.TabIndex = 14;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(216, 6, 33);
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(160, 43);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 14;
            label7.Text = "Login";
            // 
            // RegisterForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(745, 310);
            Controls.Add(LPasswordTxtBox);
            Controls.Add(label5);
            Controls.Add(LUsernameTxtBox);
            Controls.Add(label6);
            Controls.Add(RegisterBtn);
            Controls.Add(ShowPassCBox);
            Controls.Add(CFPassTxtBox);
            Controls.Add(label4);
            Controls.Add(PasswordTxtBox);
            Controls.Add(label3);
            Controls.Add(UsernameTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameTxtBox;
        private TextBox PasswordTxtBox;
        private Label label3;
        private TextBox CFPassTxtBox;
        private Label label4;
        private CheckBox ShowPassCBox;
        private Button RegisterBtn;
        private TextBox LPasswordTxtBox;
        private Label label5;
        private TextBox LUsernameTxtBox;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Button LoginBtn;
        private CheckBox LShowPassCBox;
    }
}
