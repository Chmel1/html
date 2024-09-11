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
            var login = Login_for_reg.Text;
            var password = Password_for_reg.Text;

            // Проверка на наличие пользователя с таким же логином
            if (checkuser(login))
            {
                MessageBox.Show("Логин уже используется! Пожалуйста, выберите другой.");
                return; // Если пользователь уже существует, прерываем выполнение
            }

            // Если логин уникальный, добавляем пользователя
            string request_for_reg = "INSERT INTO Users(Login, Password) VALUES (@username, @password)";
            SqlCommand command = new SqlCommand(request_for_reg, dataBase.getConnection());
            command.Parameters.AddWithValue("@username", login);
            command.Parameters.AddWithValue("@password", password);

            dataBase.openConnection();

            // Выполняем SQL-запрос
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт зарегистрирован успешно.");
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрировать аккаунт.");
            }

            dataBase.closeConnection();
        }

        // Метод для проверки, существует ли пользователь с таким логином
        private bool checkuser(string login)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_check_user = "SELECT User_Id FROM Users WHERE Login = @username";
            SqlCommand command = new SqlCommand(request_check_user, dataBase.getConnection());
            command.Parameters.AddWithValue("@username", login);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Если найден хотя бы один пользователь, возвращаем true (логин уже существует)
            return table.Rows.Count > 0;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Password_for_reg.PasswordChar = '☯';
        }
    }
}
