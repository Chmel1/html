namespace Matan
{
    partial class Registration
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
            Login_for_reg = new TextBox();
            Password_for_reg = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(45, 25);
            label1.Name = "label1";
            label1.Size = new Size(215, 45);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(34, 113);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(34, 162);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            label3.Click += label3_Click;
            // 
            // Login_for_reg
            // 
            Login_for_reg.Location = new Point(108, 111);
            Login_for_reg.Name = "Login_for_reg";
            Login_for_reg.Size = new Size(152, 23);
            Login_for_reg.TabIndex = 4;
            // 
            // Password_for_reg
            // 
            Password_for_reg.Location = new Point(108, 164);
            Password_for_reg.Name = "Password_for_reg";
            Password_for_reg.Size = new Size(152, 23);
            Password_for_reg.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.Location = new Point(45, 223);
            button1.Name = "button1";
            button1.Size = new Size(213, 45);
            button1.TabIndex = 7;
            button1.Text = "Зарегестрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 290);
            Controls.Add(button1);
            Controls.Add(Password_for_reg);
            Controls.Add(Login_for_reg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Text = "/";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Login_for_reg;
        private TextBox Password_for_reg;
        private Button button1;
    }
}