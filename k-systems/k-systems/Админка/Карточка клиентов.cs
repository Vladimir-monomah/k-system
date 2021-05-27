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
    public partial class Карточка_клиентов : Form
    {
        public Карточка_клиентов()
        {
            InitializeComponent();
        }

        public Заказы_с_клиентамиRow GetCurrentOrder()
        {
            return (Заказы_с_клиентамиRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row;
        }

        private void Карточка_клиентов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_с_клиентами". При необходимости она может быть перемещена или удалена.
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.заказыСКлиентамиBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox3.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([ФИО] Like '%{0}%'))", fieldFilter));
            }

            return string.Join(" AND ", filterExpressionList);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }
    }
}
