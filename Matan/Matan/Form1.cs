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
            string log1n = login.Text;
            string password = Password.Text;

            // Проверяем учетные данные
            string role = AuthenticateUser(log1n, password);

            if (role != null)
            {
                // Если авторизация успешна, открываем новую форму и передаем роль
                MainForm mainForm = new MainForm(role,log1n);
                mainForm.Show();
                this.Hide();  // Скрываем форму авторизации
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

        }
        private string AuthenticateUser(string login, string password)
        {
  
            string query = "SELECT Role FROM Users WHERE Login = @Login AND Password = @Password";

            
                try
                {
                    dataBase.openConnection();
                    using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();  // Возвращаем роль, если логин и пароль верны
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            

            return null;  // Возвращаем null, если авторизация не удалась
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';

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
