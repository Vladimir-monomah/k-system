using k_systems.Properties;
using k_systems.Админка;
using k_systems.Пользовательская_форма;
using k_systems.РегАвт;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            if (!CheckDBConnect())
            {
                this.Close();
            }

            this.InitializeComponent();
        }

        /// <summary>
        /// Проверяет возможность соединения с БД СИЗ,
        /// при необходимости, заменяет путь к резервной копии по указанию пользователя
        /// </summary>
        private bool CheckDBConnect()
        {
            while (true)
            {
                try
                {
                    using (var connection = new OleDbConnection(Settings.Default.k_systemsConnectionString))
                    {
                        connection.Open();
                        return true;
                    }
                }
                catch
                {
                    var reservDBFileQuestionResult = MessageBox.Show(
                        "Не найдена база данных k-system!\r\nХотите указать файл из резервной копии?",
                        "Информация",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (reservDBFileQuestionResult != DialogResult.Yes)
                    {
                        return false;
                    }

                    var openDialog = new OpenFileDialog
                    {
                        Title = "Укажите файл базы данных k-system",
                        Filter = "База данных k-system|*.mdb",
                        InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                    };
                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        Settings.Default["k_systemsConnectionString"] = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openDialog.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
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
                this.counter = 0;
                this.tbLogin.Focus();
                this.tbLogin.Clear();
                this.tbPassword.Clear();

                MessageBox.Show($"Привет, {user.Имя}!");
                if (user.Является_администратором)
                {
                    var формаАдминистратора = new Администратор(this);
                    формаАдминистратора.Show();
                }
                else
                {
                    var открыть = new Клиент(user.Id, this);
                    открыть.Show();
                }

                this.Hide();
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

        private _k_systemsDataSet.ПользователиRow User(string login)
        {
            var loginCondition = $"Логин='{login}'";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            return user;
        }

        private void PasswordChangeLabel_Click(object sender, EventArgs e)
        {
            var открыть = new Смена_пароля();
            открыть.OnValidateUser += (login, newPassword) =>
            {
                var user = this.User(открыть.GetLogin());
                if (user == null)
                {
                    MessageBox.Show("Не найден пользователь с таким логином и паролем");
                    return false;
                }

                user.пароль = Регистрация.Encrypt(открыть.GetNewPassword(), this.password);
                EntityManager.UpdateUsers();
                MessageBox.Show("Пароль изменён!");
                return true;
            };
            открыть.ShowDialog();
        }
    }
}
