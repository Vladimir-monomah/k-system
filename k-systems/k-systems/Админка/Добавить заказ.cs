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
    public partial class Добавить_заказ : Form
    {
        private string textBoxOrdersFilter;
        private string readyOrNotReadyOrdersFilter;

        public Добавить_заказ()
        {
            this.InitializeComponent();
        }

        private void Добавить_заказ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_с_клиентами". При необходимости она может быть перемещена или удалена.
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);

        }

        /// <summary>
        /// Фильтрует заказы по строке поиска, учитывая фильтрацию по готовности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "ФИО", "[Вид работы]", "[Тип ремонта]" };
            this.textBoxOrdersFilter =
                EntityManager.GetFilterStringByFields(findFields, this.orderFilterTextBox.Text).Trim();

            this.заказыСКлиентамиBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        /// <summary>
        /// Добавление заказов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            (new Заказ()).ShowDialog();
            this.заказы_с_клиентамиTableAdapter.Fill(
                this._k_systemsDataSet.Заказы_с_клиентами);
        }
    }
}
