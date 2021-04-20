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
using static k_systems._k_systemsDataSet;

namespace k_systems.Админка
{
    public partial class Администратор : Form
    {
        private string password = "ntvHA2s1y+ryOZizPQ1WHQ==";

        const string FilterNinAdministrator = "([Является администратором]=False)";

        public Администратор()
        {
            this.InitializeComponent();
        }

        private void Администратор_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this._k_systemsDataSet.Пользователи);

        }

        /// <summary>
        /// Фильтрация пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void masterFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "Телефон", "Фамилия", "Имя", "Отчество" };
            var filterString = EntityManager.GetFilterStringByFields(findFields, this.masterFilterTextBox.Text).Trim();

            this.пользователиBindingSource.Filter = FilterNinAdministrator;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.пользователиBindingSource.Filter += $"And ({filterString})";
            }
        }

        private void Администратор_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AddOrder_Click(object sender, EventArgs e)
        {
            var открыть = new Добавить_заказ();
            открыть.ShowDialog();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedRow = (ПользователиRow)((DataRowView)((DataGridView)sender).CurrentRow.DataBoundItem).Row;
            var userTable = EntityManager.FilterUsers($"Id = {changedRow.Id}");

            userTable[0].Id = changedRow.Id;
            userTable[0].Фамилия = changedRow.Фамилия;
            userTable[0].Имя = changedRow.Имя;
            userTable[0].Отчество = changedRow.Отчество;
            userTable[0].Телефон = changedRow.Телефон;
            userTable[0]._E_mail = changedRow._E_mail;

            EntityManager.UpdateUsers();

        }

        private void СhangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var открыть = new Авторизация();
            открыть.ShowDialog();
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            var открыть = new Регистрация(this.password);
            открыть.ShowDialog();
        }
    }
}
