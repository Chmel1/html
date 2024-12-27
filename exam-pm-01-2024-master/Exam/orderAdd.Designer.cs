namespace Exam.Forms.Order

{
    partial class ordersAdd : Form
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
            btnSave = new Button();
            labMainForm = new Label();
            gbOrderAuthor = new GroupBox();
            tbOrderAuthor = new TextBox();
            gbOrderCountPages = new GroupBox();
            tbOrderCountPages = new TextBox();
            gbOrderName = new GroupBox();
            tbOrderName = new TextBox();
            gbOrderAuthor.SuspendLayout();
            gbOrderCountPages.SuspendLayout();
            gbOrderName.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientInactiveCaption;
            btnSave.Location = new Point(187, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Добавить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // labMainForm
            // 
            labMainForm.AutoSize = true;
            labMainForm.Font = new Font("Segoe UI", 14F);
            labMainForm.Location = new Point(12, 9);
            labMainForm.Name = "labMainForm";
            labMainForm.Size = new Size(152, 25);
            labMainForm.TabIndex = 2;
            labMainForm.Text = "Заказ: Добавить";
            // 
            // gbOrderAuthor
            // 
            gbOrderAuthor.Controls.Add(tbOrderAuthor);
            gbOrderAuthor.Location = new Point(12, 118);
            gbOrderAuthor.Name = "gbOrderAuthor";
            gbOrderAuthor.Size = new Size(275, 57);
            gbOrderAuthor.TabIndex = 0;
            gbOrderAuthor.TabStop = false;
            gbOrderAuthor.Text = "ID Клиента";
            // 
            // tbOrderAuthor
            // 
            tbOrderAuthor.Location = new Point(6, 22);
            tbOrderAuthor.Name = "tbOrderAuthor";
            tbOrderAuthor.Size = new Size(263, 23);
            tbOrderAuthor.TabIndex = 0;
            // 
            // gbOrderCountPages
            // 
            gbOrderCountPages.Controls.Add(tbOrderCountPages);
            gbOrderCountPages.Location = new Point(12, 190);
            gbOrderCountPages.Name = "gbOrderCountPages";
            gbOrderCountPages.Size = new Size(275, 57);
            gbOrderCountPages.TabIndex = 0;
            gbOrderCountPages.TabStop = false;
            gbOrderCountPages.Text = "Статус";
            // 
            // tbOrderCountPages
            // 
            tbOrderCountPages.Location = new Point(6, 22);
            tbOrderCountPages.Name = "tbOrderCountPages";
            tbOrderCountPages.Size = new Size(263, 23);
            tbOrderCountPages.TabIndex = 0;
            // 
            // gbOrderName
            // 
            gbOrderName.Controls.Add(tbOrderName);
            gbOrderName.Location = new Point(12, 55);
            gbOrderName.Name = "gbOrderName";
            gbOrderName.Size = new Size(275, 57);
            gbOrderName.TabIndex = 1;
            gbOrderName.TabStop = false;
            gbOrderName.Text = "ID Заказа";
            // 
            // tbOrderName
            // 
            tbOrderName.Location = new Point(6, 22);
            tbOrderName.Name = "tbOrderName";
            tbOrderName.Size = new Size(263, 23);
            tbOrderName.TabIndex = 0;
            // 
            // ordersAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 450);
            Controls.Add(gbOrderName);
            Controls.Add(labMainForm);
            Controls.Add(btnSave);
            Controls.Add(gbOrderCountPages);
            Controls.Add(gbOrderAuthor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ordersAdd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить запись";
            TopMost = true;
            gbOrderAuthor.ResumeLayout(false);
            gbOrderAuthor.PerformLayout();
            gbOrderCountPages.ResumeLayout(false);
            gbOrderCountPages.PerformLayout();
            gbOrderName.ResumeLayout(false);
            gbOrderName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label labMainForm;
        private GroupBox gbOrderAuthor;
        private TextBox tbOrderAuthor;
        private GroupBox gbOrderCountPages;
        private TextBox tbOrderCountPages;
        private GroupBox gbOrderName;
        private TextBox tbOrderName;
    }
}