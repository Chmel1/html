using System.Linq;
using System.Xml.Linq;
using Exam.DB;
using Microsoft.EntityFrameworkCore;

namespace Exam
{
    public partial class MainForm : Form
    {
        private string currentElement { get; set; } = "";

        private List<Button> ProductButtons = new();
        private List<Button> ClientButtons = new();
        private List<Button> OrdersButtons = new();



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Меню - " + Program.applicationName;
            this.toolStripDropDownButton1.Text = $"Пользователь: {Program.CurrentUser.name}";
            this.labWelcome.Text = "Добро пожаловать!\n" + Program.applicationName;
            this.UsersForm.Text = "Список пользователей";
            this.panWelcome.Visible = true;
            this.splitContainer1.Panel2Collapsed = true;
            dataGridView1.Visible = false;

            this.ProductButtons.Add(btnProductAdd);
            
            
            this.OrdersButtons.Add(btnOrdersAdd);
            
            
            
            
            
            this.setAccess();
        }

        private void setAccess()
        {
            if (Program.CurrentUser.group == 2)
            {
                btnProductAdd.Enabled = false;
                
                
                btnOrdersAdd.Enabled = true;
                
                
                
                
                
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ApplicationExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Products_Click(object sender, EventArgs e)
        {
            loadDataGridView("Products");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            loadDataGridView("Clients");
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            loadDataGridView("Orders");
        }


        private void loadButtons()
        {
            switch (currentElement)
            {

                case "Products":
                    foreach (Button button in this.ProductButtons) button.Visible = true;
                    foreach (Button button in this.ClientButtons) button.Visible = false;
                    foreach (Button button in this.OrdersButtons) button.Visible = false;
                    break;
                case "Clients":
                    foreach (Button button in this.ProductButtons) button.Visible = false;
                    foreach (Button button in this.ClientButtons) button.Visible = true;
                    foreach (Button button in this.OrdersButtons) button.Visible = false;
                    break;
                case "Orders":
                    foreach (Button button in this.ProductButtons) button.Visible = false;
                    foreach (Button button in this.ClientButtons) button.Visible = false;
                    foreach (Button button in this.OrdersButtons) button.Visible = true;
                    break;
                default:

                    break;
            }
        }


        private void loadDataGridView(string element)
        {

            currentElement = element;
            loadButtons();
            this.panWelcome.Hide();
            try
            {
                using (var db = new DB.ApplicationContext())
                {
                    dataGridView1.Dock = DockStyle.Fill;

                    switch (element)
                    {
                        
                        case "Products": dataGridView1.DataSource = db.Products.OrderBy(i => i.id).ToList(); break;
                        case "Clients": dataGridView1.DataSource = db.Clients.OrderBy(r => r.id).ToList(); break;
                        case "Orders": dataGridView1.DataSource = db.Orders.OrderBy(r => r.id).ToList(); break;
                    }
                }

                dataGridView1.AutoResizeColumns();
                this.splitContainer1.Panel2Collapsed = false;
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            var Form = new Exam.Forms.Product.ProductAdd();
            Form.ShowDialog();
            this.loadDataGridView(this.currentElement);
        }

       



        private void UsersForm_Click(object sender, EventArgs e)
        {
            var Form = new Forms.User.userList();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form = new Exam.Forms.Order.ordersAdd();
            Form.ShowDialog();
            this.loadDataGridView(this.currentElement);
        }

        
    }
}

