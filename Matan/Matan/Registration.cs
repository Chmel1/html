using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Matan
{
    public partial class Registration : Form
    {

        ClassDataBase dataBase = new ClassDataBase();
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassDataBase dataBase = new ClassDataBase();

            var login = Login_for_reg.Text;
            var password = Password_for_reg.Text;

            string request_for_reg = $"Insert into Users(Login,Password) values ('{login}','{password}')";

            SqlCommand command = new SqlCommand(request_for_reg, dataBase.getConnection());

            dataBase.openConnection();
            if(command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Аккаунт зарегестрирован");
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не удалось зарегестрировать аккаунт");
            }
            dataBase.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = Login_for_reg.Text;
            var passwordUser = Password_for_reg.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_check_user = $"Select User_Id,Login,Password From Users where Login = '{loginUser}' and Password = '{passwordUser}'";
            SqlCommand command = new SqlCommand(request_check_user, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count >0)
            {
                MessageBox.Show("Логин уже используется");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Password_for_reg.PasswordChar = '☯';
        }
    }
}
