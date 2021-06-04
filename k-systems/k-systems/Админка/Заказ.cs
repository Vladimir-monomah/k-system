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

namespace k_systems.Админка
{
    public partial class Заказ : Form
    {
        public Заказ()
        {
            this.InitializeComponent();
        }

        private void Заказ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Вид_работ". При необходимости она может быть перемещена или удалена.
            this.вид_работTableAdapter.Fill(this._k_systemsDataSet.Вид_работ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Пользователи_для_заказов". При необходимости она может быть перемещена или удалена.
            this.пользователи_для_заказовTableAdapter.Fill(this._k_systemsDataSet.Пользователи_для_заказов);

            this.Phone.Mask = "+7(000)-000-0000";
        }

        /// <summary>
        /// Добавляет заказ в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            var orderState = this.GetOrderState();
            if (string.IsNullOrEmpty(orderState))
            {
                MessageBox.Show("Выберите статус заказа");
                return;
            }

            var newOrder = EntityManager.OrderDataTable.NewЗаказыRow();

            newOrder.Номер_клиента = (int)this.clientComboBox.SelectedValue;
            newOrder.Вид_работы = (int)this.workKindComboBox.SelectedValue;
            newOrder.Тип_ремонта = (int)this.dressTypeComboBox.SelectedValue;
            newOrder.Цена = this.priceNumericUpDown.Value;
            newOrder.Статус_заказа = orderState;
            newOrder.Телефон = this.Phone.Text;
            newOrder.Дата_заказа=this.OrderDateTimePicker.Value
                .AddHours(-this.OrderDateTimePicker.Value.Hour)
                    .AddMinutes(-this.OrderDateTimePicker.Value.Minute)
                    .AddSeconds(-this.OrderDateTimePicker.Value.Second)
                    .AddMilliseconds(-this.OrderDateTimePicker.Value.Millisecond);
            EntityManager.OrderDataTable.AddЗаказыRow(newOrder);
            EntityManager.UpdateOrders();

            MessageBox.Show("Заказ успешно добавлен","Информация",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private string GetOrderState()
        {

            if (this.Work.Checked)
            {
                return WorkStates.Working;
            }

            return WorkStates.Waiting;
        }

        /// <summary>
        /// Загружает цену из таблицы "Цены работ", если выбранная пара значений "Тип ремонта" и "Вид работы"
        /// найдена в соответствующих полях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderPriceComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.workKindComboBox.SelectedItem == null || this.dressTypeComboBox.SelectedItem == null)
            {
                return;
            }

            var filterCondition = $"[Вид работы] = {this.workKindComboBox.SelectedValue} AND [Тип ремонта] = {this.dressTypeComboBox.SelectedValue}";
            var foundRowWorkPrices = EntityManager.FilterWorkPrices(filterCondition).FirstOrDefault();
            this.priceNumericUpDown.Value = foundRowWorkPrices?.Цена as decimal? ?? 0m;
        }

        private void workKindComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.workKindComboBox.SelectedItem == null)
            {
                return;
            }

            var typeServiceIds = EntityManager.FilterWorkPrices($"[Цены работ].[Вид работы] = {this.workKindComboBox.SelectedValue}")
                .Select(x => x.Field<int>("Тип ремонта"))
                .ToArray();
            if(typeServiceIds.Length == 0)
            {
                this.типРемонтаBindingSource.Filter = $"False";
            }
            else
            {
                this.типРемонтаBindingSource.Filter = $"[Идентификатор] in ({string.Join(", ", typeServiceIds)})";
            }

            this.тип_ремонтаTableAdapter.Fill(this._k_systemsDataSet.Тип_ремонта);
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '.' || c == ',' || c == '\b');
        }

        private void OrderDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date
                    || dateTimePicker.Value > DateTime.Now.Date.AddDays(1).AddMilliseconds(-1)))
            {
                MessageBox.Show("Нельзя выбрать предыдующую или последующую даты", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }
    }
}