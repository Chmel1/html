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

            string request_string = $"Select * From Users";
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

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
