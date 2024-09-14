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

    public partial class MainForm : Form
    {
        ClassDataBase dataBase = new ClassDataBase();
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select Login, Password From Users";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select patient_id,first_name, last_name, middle_name, date_of_birth, gender, contact_number, email, address, insurance_policy_number, insurance_company  From Patients";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
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
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select patient_id, examination_date, complaints, physical_examination_results, additional_tests From Examinations";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select patient_id, payment_date, amount, payment_method, invoice_number From Payments";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select patient_id, date, medications, dosage, recommendations From Prescriptions";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Удаляем текущий источник данных
            dataGridView1.Rows.Clear(); // Очищаем строки, если источник был не привязан к DataSource
            dataGridView1.Columns.Clear(); // Очищаем столбцы (по необходимости)


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string request_string = $"Select patient_id, date_of_surgery, type_of_surgery, surgeon, anesthesiologist,surgery_description, complications, outcome From Surgeries";
            SqlCommand command = new SqlCommand(request_string, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Enter_Data frm1 = new Enter_Data();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }
    }
}
