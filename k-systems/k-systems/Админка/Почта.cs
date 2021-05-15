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
    public partial class Почта : Form
    {
        private const int UpdateMessagePeriod = 1000;

        const string FilterNonDeletedMessagesByReciver = "([Удалено получателем] = FALSE)";
        const string FilterSendedMessages = "([Удалено отправителем] = FALSE)";

        private int inputMessagesTimerId;
        private int outputMessagesTimerId;
        private int deletedMessagesTimerId;

        private Dictionary<DataGridView, int> currentDataGridViewRowPosition = new Dictionary<DataGridView, int>();
        private bool dataUpdating = false;

        public Почта()
        {
            InitializeComponent();
        }

        private void Почта_Load(object sender, EventArgs e)
        {
            this.пользователи_для_заказовTableAdapter.Fill(this._k_systemsDataSet.Пользователи_для_заказов);

            this.сообщения_для_администраторов_удалённыеTableAdapter.Fill(this._k_systemsDataSet.Сообщения_для_администраторов_удалённые);
            
            //Отправленные сообщения
            this.сообщения_для_администраторов_отправленныеTableAdapter.Fill(
                this._k_systemsDataSet.Сообщения_для_администраторов_отправленные);
            this.сообщенияДляАдминистраторовОтправленныеBindingSource.Filter = FilterSendedMessages;
            this.outputMessagesTimerId=Em

            this.сообщения_для_администраторовTableAdapter.Fill(this._k_systemsDataSet.Сообщения_для_администраторов);
        }
    }
}
