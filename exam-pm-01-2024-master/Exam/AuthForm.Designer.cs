namespace Exam
{
    partial class AuthForm
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
            btnAuth = new Button();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            labLogin = new Label();
            labPassword = new Label();
            SuspendLayout();
            // 
            // btnAuth
            // 
            btnAuth.BackColor = SystemColors.HighlightText;
            btnAuth.Location = new Point(184, 141);
            btnAuth.Name = "btnAuth";
            btnAuth.Size = new Size(116, 31);
            btnAuth.TabIndex = 0;
            btnAuth.Text = "Войти в систему";
            btnAuth.UseVisualStyleBackColor = false;
            btnAuth.Click += btnAuth_Click;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(115, 46);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(185, 23);
            tbLogin.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(115, 91);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '#';
            tbPassword.Size = new Size(185, 23);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // labLogin
            // 
            labLogin.AutoSize = true;
            labLogin.Location = new Point(58, 49);
            labLogin.Name = "labLogin";
            labLogin.Size = new Size(41, 15);
            labLogin.TabIndex = 3;
            labLogin.Text = "Логин";
            // 
            // labPassword
            // 
            labPassword.AutoSize = true;
            labPassword.Location = new Point(50, 92);
            labPassword.Name = "labPassword";
            labPassword.Size = new Size(49, 15);
            labPassword.TabIndex = 4;
            labPassword.Text = "Пароль";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 197);
            Controls.Add(btnAuth);
            Controls.Add(tbLogin);
            Controls.Add(tbPassword);
            Controls.Add(labLogin);
            Controls.Add(labPassword);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAuth;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Label labLogin;
        private Label labPassword;
    }
}