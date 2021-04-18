using k_systems.Админка;
using k_systems.Пользовательская_форма;
using k_systems.РегАвт;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_systems
{
    public partial class Авторизация : Form
    {
        private string password = "ntvHA2s1y+ryOZizPQ1WHQ==";

        int counter = 0;

        public Авторизация()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Открытие формы регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRegistration_Click(object sender, EventArgs e)
        {
            var reg = new Регистрация(this.password);
            reg.ShowDialog();
        }

        private void Авторизация_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите выйти?",
                    "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
            else Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.tbLogin.Text == "" && this.tbPassword.Text == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль! Пожалуйста, заполните поля!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.counter++;
            if (string.IsNullOrEmpty(this.tbLogin.Text))
            {
                this.tbLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.tbPassword.Text))
            {
                this.tbPassword.Focus();
                return;
            }

            else if (this.counter >= 3)
            {
                this.tbLogin.Enabled = false;
                this.tbPassword.Enabled = false;
            }

            var user = this.FindUser(this.tbLogin.Text, this.tbPassword.Text);
            if (user != null)
            {
                MessageBox.Show($"Привет, {user.Имя}!");
                if (user.Является_администратором)
                {
                    var формаАдминистратора = new Администратор();
                    this.Hide();
                    формаАдминистратора.Show();
                }
                else
                {
                    var открыть = new Клиент(user.Id);
                    this.Hide();
                    открыть.Show();
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль!Пользователь в базе не найден!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Выполняет поиск пользователя по логину и паролю
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private _k_systemsDataSet.ПользователиRow FindUser(string login, string password)
        {
            var loginCondition = $"логин='{login}' AND пароль='{Регистрация.Encrypt(password, this.password)}'";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            return user;
        }
    }
}
