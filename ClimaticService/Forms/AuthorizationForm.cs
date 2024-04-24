using ClimaticService.Context.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimaticService
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Проверка логина и пароля пользователя
        /// </summary>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxLogin.Text))
            {
                using(var db = new ClimaticServiceContext())
                {
                    var user = db.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
                    if(user != null)
                    {
                        WorkToUser.User = user;
                        DialogResult = DialogResult.OK;
                        MessageBox.Show($"Приветствую {WorkToUser.User.FullName}!", "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Неправильное имя пользователя или пароль! Попробуйте ещё раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPassword.Clear();
                    }
                }
            }
            else
                MessageBox.Show("Заполните все поля перед входом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = checkBoxPassword.Checked;
        }
    }
}
