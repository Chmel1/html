namespace Exam
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            ApplicationExitButton = new ToolStripMenuItem();
            UsersForm = new ToolStripMenuItem();
            Products = new ToolStripButton();
            btnClients = new ToolStripButton();
            btnOrders = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            panWelcome = new Panel();
            labWelcome = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labToolMenu = new Label();
            btnProductAdd = new Button();
            btnOrdersAdd = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panWelcome.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.PeachPuff;
            toolStrip1.CanOverflow = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, Products, btnClients, btnOrders });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1334, 25);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { ApplicationExitButton, UsersForm });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(164, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ApplicationExitButton
            // 
            ApplicationExitButton.Name = "ApplicationExitButton";
            ApplicationExitButton.Size = new Size(197, 22);
            ApplicationExitButton.Text = "Выйти из приложения";
            ApplicationExitButton.Click += ApplicationExitButton_Click;
            // 
            // UsersForm
            // 
            UsersForm.Name = "UsersForm";
            UsersForm.Size = new Size(197, 22);
            UsersForm.Text = "toolStripMenuItem1";
            UsersForm.Click += UsersForm_Click;
            // 
            // Products
            // 
            Products.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Products.ImageTransparentColor = Color.Magenta;
            Products.Name = "Products";
            Products.Size = new Size(116, 22);
            Products.Text = "Каталог продукция";
            Products.Click += Products_Click;
            // 
            // btnClients
            // 
            btnClients.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClients.ImageTransparentColor = Color.Magenta;
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(59, 22);
            btnClients.Text = "Клиенты";
            btnClients.Click += btnClients_Click;
            // 
            // btnOrders
            // 
            btnOrders.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnOrders.ImageTransparentColor = Color.Magenta;
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(50, 22);
            btnOrders.Text = "Заказы";
            btnOrders.Click += btnOrders_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(panWelcome);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ScrollBar;
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(1334, 705);
            splitContainer1.SplitterDistance = 1120;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            // 
            // panWelcome
            // 
            panWelcome.AutoSize = true;
            panWelcome.Controls.Add(labWelcome);
            panWelcome.Dock = DockStyle.Top;
            panWelcome.Location = new Point(0, 0);
            panWelcome.Name = "panWelcome";
            panWelcome.Size = new Size(1120, 69);
            panWelcome.TabIndex = 0;
            // 
            // labWelcome
            // 
            labWelcome.AutoSize = true;
            labWelcome.Font = new Font("Segoe UI", 30F);
            labWelcome.Location = new Point(14, 15);
            labWelcome.Name = "labWelcome";
            labWelcome.Size = new Size(130, 54);
            labWelcome.TabIndex = 0;
            labWelcome.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labToolMenu);
            flowLayoutPanel1.Controls.Add(btnProductAdd);
            flowLayoutPanel1.Controls.Add(btnOrdersAdd);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(210, 705);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // labToolMenu
            // 
            labToolMenu.AutoSize = true;
            labToolMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labToolMenu.Location = new Point(3, 0);
            labToolMenu.Name = "labToolMenu";
            labToolMenu.Size = new Size(94, 25);
            labToolMenu.TabIndex = 0;
            labToolMenu.Text = "Действия";
            // 
            // btnProductAdd
            // 
            btnProductAdd.AutoSize = true;
            btnProductAdd.Location = new Point(3, 28);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Padding = new Padding(10);
            btnProductAdd.Size = new Size(204, 45);
            btnProductAdd.TabIndex = 1;
            btnProductAdd.Tag = "Product";
            btnProductAdd.Text = "Add Product";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // btnOrdersAdd
            // 
            btnOrdersAdd.AutoSize = true;
            btnOrdersAdd.Location = new Point(3, 79);
            btnOrdersAdd.Name = "btnOrdersAdd";
            btnOrdersAdd.Padding = new Padding(10);
            btnOrdersAdd.Size = new Size(204, 45);
            btnOrdersAdd.TabIndex = 5;
            btnOrdersAdd.Tag = "Client";
            btnOrdersAdd.Text = "Add Order";
            btnOrdersAdd.UseVisualStyleBackColor = true;
            btnOrdersAdd.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 730);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "Form1";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panWelcome.ResumeLayout(false);
            panWelcome.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel labUserName;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem ApplicationExitButton;
        private ToolStripButton Products;
        private ToolStripButton btnClients;
        private ToolStripButton btnOrders;
        private SplitContainer splitContainer1;
        private Panel panWelcome;
        private Label labWelcome;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labToolMenu;
        private Button btnProductAdd;
        private ToolStripMenuItem UsersForm;
        private Button btnOrdersAdd;
    }
}
