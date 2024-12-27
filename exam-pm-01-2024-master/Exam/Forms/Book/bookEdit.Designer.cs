namespace Exam.Forms.Product
{
    partial class ProductEdit
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
            gbProductName = new GroupBox();
            tbProductName = new TextBox();
            btnSave = new Button();
            labMainForm = new Label();
            gbProductAuthor = new GroupBox();
            tbProductAuthor = new TextBox();
            gbProductISBN = new GroupBox();
            tbProductIsbn = new TextBox();
            gbProductCountPages = new GroupBox();
            tbProductCountPages = new TextBox();
            gbProductName.SuspendLayout();
            gbProductAuthor.SuspendLayout();
            gbProductISBN.SuspendLayout();
            gbProductCountPages.SuspendLayout();
            SuspendLayout();
            // 
            // gbProductName
            // 
            gbProductName.Controls.Add(tbProductName);
            gbProductName.Location = new Point(12, 55);
            gbProductName.Name = "gbProductName";
            gbProductName.Size = new Size(275, 57);
            gbProductName.TabIndex = 0;
            gbProductName.TabStop = false;
            gbProductName.Text = "Наименование";
            // 
            // tbProductName
            // 
            tbProductName.BackColor = SystemColors.Window;
            tbProductName.Location = new Point(6, 22);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(263, 23);
            tbProductName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientInactiveCaption;
            btnSave.Location = new Point(187, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // labMainForm
            // 
            labMainForm.AutoSize = true;
            labMainForm.Font = new Font("Segoe UI", 14F);
            labMainForm.Location = new Point(12, 9);
            labMainForm.Name = "labMainForm";
            labMainForm.Size = new Size(236, 25);
            labMainForm.TabIndex = 2;
            labMainForm.Text = "Продукт: Редактирование";
            labMainForm.Click += label1_Click;
            // 
            // gbProductAuthor
            // 
            gbProductAuthor.Controls.Add(tbProductAuthor);
            gbProductAuthor.Location = new Point(12, 118);
            gbProductAuthor.Name = "gbProductAuthor";
            gbProductAuthor.Size = new Size(275, 57);
            gbProductAuthor.TabIndex = 0;
            gbProductAuthor.TabStop = false;
            gbProductAuthor.Text = "Категория";
            // 
            // tbProductAuthor
            // 
            tbProductAuthor.Location = new Point(6, 22);
            tbProductAuthor.Name = "tbProductAuthor";
            tbProductAuthor.Size = new Size(263, 23);
            tbProductAuthor.TabIndex = 0;
            // 
            // gbProductISBN
            // 
            gbProductISBN.Controls.Add(tbProductIsbn);
            gbProductISBN.Location = new Point(12, 181);
            gbProductISBN.Name = "gbProductISBN";
            gbProductISBN.RightToLeft = RightToLeft.No;
            gbProductISBN.Size = new Size(275, 57);
            gbProductISBN.TabIndex = 0;
            gbProductISBN.TabStop = false;
            gbProductISBN.Text = "Цена";
            gbProductISBN.Enter += gbProductISBN_Enter;
            // 
            // tbProductIsbn
            // 
            tbProductIsbn.Location = new Point(6, 22);
            tbProductIsbn.Name = "tbProductIsbn";
            tbProductIsbn.Size = new Size(263, 23);
            tbProductIsbn.TabIndex = 0;
            // 
            // gbProductCountPages
            // 
            gbProductCountPages.Controls.Add(tbProductCountPages);
            gbProductCountPages.Location = new Point(6, 244);
            gbProductCountPages.Name = "gbProductCountPages";
            gbProductCountPages.Size = new Size(275, 57);
            gbProductCountPages.TabIndex = 0;
            gbProductCountPages.TabStop = false;
            gbProductCountPages.Text = "Количество в наличие";
            // 
            // tbProductCountPages
            // 
            tbProductCountPages.Location = new Point(6, 22);
            tbProductCountPages.Name = "tbProductCountPages";
            tbProductCountPages.Size = new Size(263, 23);
            tbProductCountPages.TabIndex = 0;
            // 
            // ProductEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 450);
            Controls.Add(labMainForm);
            Controls.Add(btnSave);
            Controls.Add(gbProductCountPages);
            Controls.Add(gbProductISBN);
            Controls.Add(gbProductAuthor);
            Controls.Add(gbProductName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать запись";
            TopMost = true;
            gbProductName.ResumeLayout(false);
            gbProductName.PerformLayout();
            gbProductAuthor.ResumeLayout(false);
            gbProductAuthor.PerformLayout();
            gbProductISBN.ResumeLayout(false);
            gbProductISBN.PerformLayout();
            gbProductCountPages.ResumeLayout(false);
            gbProductCountPages.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbProductName;
        private TextBox tbProductName;
        private Button btnSave;
        private Label labMainForm;
        private GroupBox gbProductAuthor;
        private TextBox tbProductAuthor;
        private GroupBox gbProductISBN;
        private TextBox tbProductIsbn;
        private GroupBox gbProductCountPages;
        private TextBox tbProductCountPages;
    }
}