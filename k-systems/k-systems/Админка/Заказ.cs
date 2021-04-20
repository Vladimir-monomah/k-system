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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Тип_ремонта". При необходимости она может быть перемещена или удалена.
            this.тип_ремонтаTableAdapter.Fill(this._k_systemsDataSet.Тип_ремонта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Вид_работ". При необходимости она может быть перемещена или удалена.
            this.вид_работTableAdapter.Fill(this._k_systemsDataSet.Вид_работ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Пользователи_для_заказов". При необходимости она может быть перемещена или удалена.
            this.пользователи_для_заказовTableAdapter.Fill(this._k_systemsDataSet.Пользователи_для_заказов);

            
        }

        /// <summary>
        /// Добавляет заказ в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            var newOrder = EntityManager.OrderDataTable.NewЗаказыRow();

            newOrder.Номер_клиента = (int)this.clientComboBox.SelectedValue;
            newOrder.Вид_работы = (int)this.workKindComboBox.SelectedValue;
            newOrder.Тип_ремонта = (int)this.dressTypeComboBox.SelectedValue;
            newOrder.Цена = this.priceNumericUpDown.Value;

            EntityManager.OrderDataTable.AddЗаказыRow(newOrder);
            EntityManager.UpdateOrders();

            MessageBox.Show("Заказ успешно добавлен","Информация",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
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
    }
}
