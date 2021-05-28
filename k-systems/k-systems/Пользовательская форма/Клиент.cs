using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_systems.Пользовательская_форма
{
    public partial class Клиент : Form
    {
        private long idClient;
        private _k_systemsDataSet.ПользователиRow user;

        public Клиент(Int64 userId)
        {
            this.idClient = userId;
            this.InitializeComponent();
        }

        public Клиент(_k_systemsDataSet.ПользователиRow user)
        {
            this.user = user;
        }

        private void Клиент_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Цены_работ_для_клиента". При необходимости она может быть перемещена или удалена.
            this.цены_работ_для_клиентаTableAdapter.Fill(this._k_systemsDataSet.Цены_работ_для_клиента);
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Клиент_FormClosing(object sender, FormClosingEventArgs e)
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

        private void priceListFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[Вид работы]", "[Тип ремонта]" };
            var filterString =
                EntityManager.GetFilterStringByFields(findFields, this.priceListFilterTextBox.Text).Trim();

            this.ценыРаботДляКлиентаBindingSource.Filter = filterString;
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var открыть = new Заказы(this.idClient);
            открыть.ShowDialog();
        }

        private void сменаПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var открыть = new Авторизация();
            открыть.ShowDialog();
        }
    }
}
