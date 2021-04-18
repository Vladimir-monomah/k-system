using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_systems.Админка
{
    public partial class Администратор : Form
    {
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
    }
}
