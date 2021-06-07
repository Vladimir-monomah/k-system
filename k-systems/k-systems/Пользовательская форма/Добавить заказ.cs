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

namespace k_systems.Пользовательская_форма
{
    public partial class Добавить_заказ : Form
    {
        private string textBoxOrdersFilter;
        private string readyOrNotReadyOrdersFilter;

        public Добавить_заказ()
        {
            InitializeComponent();
        }

        private void Добавить_заказ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_с_клиентами". При необходимости она может быть перемещена или удалена.
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);

        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            (new Заказ()).ShowDialog();
            this.заказы_с_клиентамиTableAdapter.Fill(
                this._k_systemsDataSet.Заказы_с_клиентами);
        }

        /// <summary>
        /// Фильтрует заказы по строке поиска, учитывая фильтрацию по готовности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.заказыСКлиентамиBindingSource.Filter=this.BuildWorkerCardFilter();
        }

        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.orderFilterTextBox.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([ФИО] Like '%{0}%') OR ([Вид работы] Like '%{0}%'))", fieldFilter));
            }
            return string.Join(" AND ", filterExpressionList);
        }

        /// <summary>
        /// Обновляет информацию в бд об отредактированном заказе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedRow = (Заказы_с_клиентамиRow)((DataRowView)((DataGridView)sender).CurrentRow.DataBoundItem).Row;
            var orderTable = EntityManager.FilterOrders($"Id={changedRow.Номер_заказа}");

            orderTable[0].Статус_заказа = changedRow.Статус_заказа;
            orderTable[0].Цена = changedRow.Цена;
            EntityManager.UpdateOrders();

            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
        }
    }
}
