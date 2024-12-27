namespace Exam.Forms.User
{
    partial class userAdd
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
            labMain = new Label();
            gbLogin = new GroupBox();
            tbLogin = new TextBox();
            gbEmain = new GroupBox();
            tbEmail = new TextBox();
            gbName = new GroupBox();
            tbName = new TextBox();
            gbPassword = new GroupBox();
            tbPassword = new TextBox();
            groupBox5 = new GroupBox();
            isUser = new RadioButton();
            isAdmin = new RadioButton();
            btnSave = new Button();
            gbLogin.SuspendLayout();
            gbEmain.SuspendLayout();
            gbName.SuspendLayout();
            gbPassword.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // labMain
            // 
            labMain.AutoSize = true;
            labMain.Font = new Font("Segoe UI", 14F);
            labMain.Location = new Point(12, 9);
            labMain.Name = "labMain";
            labMain.Size = new Size(63, 25);
            labMain.TabIndex = 0;
            labMain.Text = "label1";
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(tbLogin);
            gbLogin.Location = new Point(12, 48);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(291, 56);
            gbLogin.TabIndex = 1;
            gbLogin.TabStop = false;
            gbLogin.Text = "Логин";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(6, 22);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(279, 23);
            tbLogin.TabIndex = 0;
            // 
            // gbEmain
            // 
            gbEmain.Controls.Add(tbEmail);
            gbEmain.Location = new Point(12, 110);
            gbEmain.Name = "gbEmain";
            gbEmain.Size = new Size(291, 56);
            gbEmain.TabIndex = 2;
            gbEmain.TabStop = false;
            gbEmain.Text = "E-mail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(6, 22);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(279, 23);
            tbEmail.TabIndex = 0;
            // 
            // gbName
            // 
            gbName.Controls.Add(tbName);
            gbName.Location = new Point(12, 172);
            gbName.Name = "gbName";
            gbName.Size = new Size(291, 56);
            gbName.TabIndex = 2;
            gbName.TabStop = false;
            gbName.Text = "Имя";
            // 
            // tbName
            // 
            tbName.Location = new Point(6, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(279, 23);
            tbName.TabIndex = 0;
            // 
            // gbPassword
            // 
            gbPassword.Controls.Add(tbPassword);
            gbPassword.Location = new Point(12, 234);
            gbPassword.Name = "gbPassword";
            gbPassword.Size = new Size(291, 56);
            gbPassword.TabIndex = 2;
            gbPassword.TabStop = false;
            gbPassword.Text = "Пароль";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(6, 22);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(279, 23);
            tbPassword.TabIndex = 0;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(isUser);
            groupBox5.Controls.Add(isAdmin);
            groupBox5.Location = new Point(12, 296);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(291, 56);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox2";
            // 
            // isUser
            // 
            isUser.AutoSize = true;
            isUser.Location = new Point(183, 22);
            isUser.Name = "isUser";
            isUser.Size = new Size(102, 19);
            isUser.TabIndex = 1;
            isUser.TabStop = true;
            isUser.Text = "Пользователь";
            isUser.UseVisualStyleBackColor = true;
            // 
            // isAdmin
            // 
            isAdmin.AutoSize = true;
            isAdmin.Location = new Point(14, 24);
            isAdmin.Name = "isAdmin";
            isAdmin.Size = new Size(112, 19);
            isAdmin.TabIndex = 0;
            isAdmin.TabStop = true;
            isAdmin.Text = "Администратор";
            isAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(195, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 42);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // userAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 412);
            Controls.Add(btnSave);
            Controls.Add(groupBox5);
            Controls.Add(gbPassword);
            Controls.Add(gbName);
            Controls.Add(gbEmain);
            Controls.Add(gbLogin);
            Controls.Add(labMain);
            Name = "userAdd";
            Text = "userAdd";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            gbEmain.ResumeLayout(false);
            gbEmain.PerformLayout();
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            gbPassword.ResumeLayout(false);
            gbPassword.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labMain;
        private GroupBox gbLogin;
        private TextBox tbLogin;
        private GroupBox gbEmain;
        private TextBox tbEmail;
        private GroupBox gbName;
        private TextBox tbName;
        private GroupBox gbPassword;
        private TextBox tbPassword;
        private GroupBox groupBox5;
        private RadioButton isUser;
        private RadioButton isAdmin;
        private Button btnSave;
    }
}