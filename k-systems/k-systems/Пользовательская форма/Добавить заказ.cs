using k_systems.Properties;
using k_systems.Константы;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using static k_systems._k_systemsDataSet;

namespace k_systems.Пользовательская_форма
{
    public partial class Добавить_заказ : Form
    {
        private long idClient;

        public Добавить_заказ(long idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
            заказыСКлиентамиBindingSource.Filter = "[Номер клиента] = " + idClient;
        }

        private void Добавить_заказ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_с_клиентами". При необходимости она может быть перемещена или удалена.
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            (new Заказ(this.idClient)).ShowDialog();
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
            this.заказыСКлиентамиBindingSource.Filter = this.BuildWorkerCardFilter();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var orderClientRow = ((Заказы_с_клиентамиRow)((DataRowView)this.dataGridViewOrder.CurrentRow?.DataBoundItem)?.Row);
            var orderId = orderClientRow?.Номер_заказа;
            if (!orderId.HasValue)
            {
                return;
            }

            var deleteUser = MessageBox.Show("Вы действительно хотите удалить данный заказ клиента? ", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteUser != DialogResult.Yes)
            {
                return;
            }

            var orderRow = EntityManager.FilterOrders("Идентификатор = " + orderId).FirstOrDefault();
            if (orderRow?.Статус_заказа != WorkStates.Waiting)
            {
                MessageBox.Show("Заказ нельзя удалить!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new OleDbConnection(Settings.Default.k_systemsConnectionString))
            {
                connection.Open();
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"DELETE FROM [Заказы] WHERE [Идентификатор]={orderId.Value}";
                    sqlCommand.ExecuteNonQuery();
                }
            }

            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
        }
    }
}