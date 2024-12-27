using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            using (var db = new DB.ApplicationContext() )
            {
                NpgsqlParameter login = new NpgsqlParameter("@login", tbLogin.Text);
                NpgsqlParameter password = new NpgsqlParameter("@password", DB.User.CreateHashPassword(tbPassword.Text));

                var dbname=db.Database.GetDbConnection().Database;
                var users = db.Users.FromSqlRaw($"SELECT * FROM \"{dbname}\".public.\"Users\" WHERE login LIKE @login AND password=@password", [login, password]).ToList();
                if (users.Count == 1)
                {
                    foreach (var user in users)
                    {
                        Program.CurrentUser=user;
                        MainForm MainForm = new MainForm();
                        MainForm.Show(); 
                        MainForm.Activate();
                        this.Hide();

                    }
                }
                else if (users.Count == 0)
                {
                    DialogResult dbexept = MessageBox.Show("Пользователь не неайден в системе", "Ошибка авторизации", MessageBoxButtons.OK);
                    if (dbexept == System.Windows.Forms.DialogResult.OK)
                    {
                     
                    }

                }
            }
        }
    }
}
