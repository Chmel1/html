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
using System.Drawing.Text;

namespace Matan
{

    public partial class MainForm : Form
    {
        ClassDataBase dataBase = new ClassDataBase();
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private string _userRole;
        private string _userLogin;
        private int? _patientId;
        public MainForm(string role,string log1n)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _userRole = role;
            _userLogin = log1n;
            GetPatientId();
        }
        private void GetPatientId()
        {
            if (_userRole == "User")
            {
                string query = "SELECT patient_id FROM Users WHERE Login = @Login";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                command.Parameters.AddWithValue("@Login", _userLogin);

                dataBase.openConnection();
                var result = command.ExecuteScalar();
                dataBase.closeConnection();

                if (result != null)
                {
                    _patientId = Convert.ToInt32(result);
                }
                else
                {
                    _patientId = null;
                }
            }
        }
        // Пример вызова метода, например, по нажатию кнопки
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select Login,Password,Role From Users";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            label1.Text = "Ваша роль: " + _userRole;

            if (_userRole == "User")
            {
                toolStripButton8.Enabled = false; // Отключаем кнопку для ввода данных
                                                  // Отключаем доступ к другим данным, если это необходимо
                toolStripButton1.Enabled = false; // Отключаем доступ к просмотру пользователей
                toolStripButton3.Enabled = false; // Отключаем доступ к медицинской истории
                                                  // Добавьте аналогично для других кнопок, если требуется
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            // Если роль User, то показываем только свои данные
            string request_string;
            if (_userRole == "User")
            {
                request_string = $"SELECT patient_id, first_name, last_name, middle_name, date_of_birth, gender, contact_number, email, address, insurance_policy_number, insurance_company FROM Patients WHERE patient_id = @PatientID";
            }
            else
            {
                request_string = $"SELECT patient_id, first_name, last_name, middle_name, date_of_birth, gender, contact_number, email, address, insurance_policy_number, insurance_company FROM Patients";
            }

            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            if (_userRole == "User")
            {
                command.Parameters.AddWithValue("@PatientID", _patientId); // CurrentUserLogin — это логин авторизованного пользователя
            }

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select patient_id,chronic_diseases, previous_operations, allergies, current_medications, diagnoses, lab_results From Medical_History";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            // Если роль User, то показываем только свои данные
            string request_string;
            if (_userRole == "User")
            {
                request_string = $"Select patient_id, examination_date, complaints, physical_examination_results, additional_tests From Examinations WHERE patient_id = @PatientID";
            }
            else
            {
                request_string = $"Select patient_id, examination_date, complaints, physical_examination_results, additional_tests From Examinations";
            }

            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            if (_userRole == "User")
            {
                command.Parameters.AddWithValue("@PatientID", _patientId); // CurrentUserLogin — это логин авторизованного пользователя
            }

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {     
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            // Если роль User, то показываем только свои данные
            string request_string;
            if (_userRole == "User")
            {
                request_string = $"Select patient_id, payment_date, amount, payment_method, invoice_number From Payments WHERE patient_id = @PatientID";
            }
            else
            {
                request_string = $"Select patient_id, payment_date, amount, payment_method, invoice_number From Payments";
            }

            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            if (_userRole == "User")
            {
                command.Parameters.AddWithValue("@PatientID", _patientId); // CurrentUserLogin — это логин авторизованного пользователя
            }

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            // Если роль User, то показываем только свои данные
            string request_string;
            if (_userRole == "User")
            {
                request_string = $"Select patient_id, date, medications, dosage, recommendations From Prescriptions WHERE patient_id = @PatientID";
            }
            else
            {
                request_string = $"Select patient_id, date, medications, dosage, recommendations From Prescriptions";
            }

            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            if (_userRole == "User")
            {
                command.Parameters.AddWithValue("@PatientID", _patientId); // CurrentUserLogin — это логин авторизованного пользователя
            }

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            // Если роль User, то показываем только свои данные
            string request_string;
            if (_userRole == "User")
            {
                request_string = $"Select patient_id, date_of_surgery, type_of_surgery, surgeon, anesthesiologist,surgery_description, complications, outcome From Surgeries WHERE patient_id = @PatientID";
            }
            else
            {
                request_string = $"Select patient_id, date_of_surgery, type_of_surgery, surgeon, anesthesiologist,surgery_description, complications, outcome From Surgeries";
            }

            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            if (_userRole == "User")
            {
                command.Parameters.AddWithValue("@PatientID", _patientId); // CurrentUserLogin — это логин авторизованного пользователя
            }

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (_userRole == "User")
            {
                MessageBox.Show("У вас нет прав для ввода данных.");
                return;
            }

            Enter_Data frm1 = new Enter_Data();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
