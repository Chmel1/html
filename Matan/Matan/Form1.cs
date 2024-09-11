using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Matan
{
    public partial class Form1 : Form
    {
        ClassDataBase dataBase = new ClassDataBase();

        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var password_user = Password.Text;
            var login_user = login.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select Login,Password From Users where Login = '{login_user}' and Password ='{password_user}'";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command; 
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MainForm frm1 = new MainForm();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ошибка в логине или пароле");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password.PasswordChar = '☯';

        }
            private void button2_Click(object sender, EventArgs e)
        {
            Registration frm1 = new Registration();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }
    }
}
