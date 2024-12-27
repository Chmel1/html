using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Forms.User
{
    public partial class userList : Form
    {
        public userList()
        {
            InitializeComponent();
            this.loadDataGridViewData();
     
        }


        private void loadDataGridViewData()
        {
            using (DB.ApplicationContext db = new DB.ApplicationContext())
            {
                dataGridView1.DataSource = db.Users.ToList();
                dataGridView1.AutoResizeColumns();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Form = new Forms.User.userAdd();
            Form.ShowDialog();  
            loadDataGridViewData();
        }
    }
}
