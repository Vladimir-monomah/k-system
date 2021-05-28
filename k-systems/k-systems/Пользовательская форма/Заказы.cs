using k_systems.Константы;
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
    public partial class Заказы : Form
    {
        private readonly string orderFilter;

        private string textBoxOrderFilter;
        private string readyOrNotReadyOrdersFilter;

        public Заказы(long userId)
        {
            this.orderFilter = $"([Номер клиента]= {userId})";
            this.InitializeComponent();
        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_с_клиентами". При необходимости она может быть перемещена или удалена.
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
            this.заказыСКлиентамиBindingSource.Filter = this.textBoxOrderFilter = this.orderFilter;

        }

        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[Вид работы]", "[Тип ремонта]" };
            var filterString =
                EntityManager.GetFilterStringByFields(findFields,this.orderFilterTextBox.Text).Trim();

            this.textBoxOrderFilter = this.orderFilter;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.textBoxOrderFilter += $"And ({filterString})";
            }

            this.заказыСКлиентамиBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrderFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void clientOrdersFilterCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            switch (this.clientOrdersFilterCheckBox.CheckState)
            {
                case CheckState.Checked:
                    this.readyOrNotReadyOrdersFilter = $"[Статус заказа] = '{WorkStates.Ready}'";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются готовые заказы";
                    break;

                case CheckState.Indeterminate:
                    this.readyOrNotReadyOrdersFilter = string.Empty;
                    this.clientOrdersFilterCheckBox.Text = "Отображаются все заказы";
                    break;

                case CheckState.Unchecked:
                    this.readyOrNotReadyOrdersFilter = $"[Статус заказа] = '{WorkStates.Working}'";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются неготовые заказы";
                    break;
            }

            this.заказыСКлиентамиBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrderFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void updateOrdersButton_Click(object sender, EventArgs e)
        {
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var открыть = new Заказ_для_клиента(this._k_systemsDataSet);
            открыть.LoadЗаказы(
                (Заказы_с_клиентамиRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row);
            открыть.ShowDialog();

            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
        }
    }
}
