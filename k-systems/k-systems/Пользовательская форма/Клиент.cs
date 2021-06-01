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
        private readonly Авторизация авторизация;

        public Клиент(Int64 userId, Авторизация авторизация)
        {
            this.idClient = userId;
            this.авторизация = авторизация;
            this.InitializeComponent();
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
            this.авторизация.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var открыть = new О_программе();
            открыть.ShowDialog();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var открыть = new Почта(this.idClient);
            открыть.ShowDialog();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Справка.chm");
        }
    }
}
