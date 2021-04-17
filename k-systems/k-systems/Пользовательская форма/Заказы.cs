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
    public partial class Заказы : Form
    {
        private readonly string orderFilter;

        private string textBoxOrderFilter;
        private string readyOrNotReadyOrdersFilter;

        public Заказы()
        {
            this.orderFilter = $"([Номер клиента])";
            InitializeComponent();
        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            this.заказыДляКлиентаBindingSource.Filter = this.textBoxOrderFilter = this.orderFilter;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_для_клиента". При необходимости она может быть перемещена или удалена.
            this.заказы_для_клиентаTableAdapter.Fill(this._k_systemsDataSet.Заказы_для_клиента);

        }

        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[Вид работы]", "[Тип работы]" };
            var filterString =
                EntityManager.GetFilterStringByFields(findFields,this.orderFilterTextBox.Text).Trim();

            this.textBoxOrderFilter = this.orderFilter;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.textBoxOrderFilter += $"And ({filterString})";
            }

            this.заказыДляКлиентаBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrderFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void clientOrdersFilterCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            switch (this.clientOrdersFilterCheckBox.CheckState)
            {
                case CheckState.Checked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов]=True";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются готовые заказы";
                    break;

                case CheckState.Indeterminate:
                    this.readyOrNotReadyOrdersFilter = string.Empty;
                    this.clientOrdersFilterCheckBox.Text = "Отображаются все заказы";
                    break;

                case CheckState.Unchecked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = FALSE";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются неготовые заказы";
                    break;
            }

            this.заказыДляКлиентаBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrderFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void updateOrdersButton_Click(object sender, EventArgs e)
        {
            this.заказы_для_клиентаTableAdapter.Fill(this._k_systemsDataSet.Заказы_для_клиента);
        }
    }
}
