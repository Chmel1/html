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
    public partial class userAdd : Form
    {
        public userAdd()
        {

            InitializeComponent();
            this.labMain.Text = "Пользователь: Создание";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.formValidate();
        }

        private bool formValidate()
        {
            bool isValid = true;
            isValid = Helpers.formValidator.validateTextBoxToString(tbLogin) &&
                      Helpers.formValidator.validateTextBoxToString(tbName) &&
                      Helpers.formValidator.validateTextBoxToString(tbPassword) &&
                      Helpers.formValidator.validateTextBoxToEmail(tbEmail);

            return isValid;

        }
    }
}
