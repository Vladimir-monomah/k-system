using k_systems.Email;
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
    public partial class Почта : Form
    {
        private const int UpdateMessagePeriod = 1000;

        private readonly string userMessagesFilter;
        private readonly string userOutputMessagesFilter;

        private string userDeletedMessagesFilter;

        private int inputMessagesTimerId;
        private int outputMessagesTimerId;
        private int deletedMessagesTimerId;

        private Dictionary<DataGridView, int> currentDataGridViewRowPosition = new Dictionary<DataGridView, int>();
        private bool dataUpdating = false;

        public Почта(int userId)
        {
            // Сообщения
            this.userMessagesFilter = $"([Получатель] = {userId}) AND ([Удалено получателем] = FALSE)";
            this.userOutputMessagesFilter = $"([Отправитель] = {userId}) AND ([Удалено отправителем] = FALSE)";
            this.userDeletedMessagesFilter = $"([Отправитель] = {userId}) OR ([Получатель] = {userId})";

            InitializeComponent();
        }

        private void Почта_Load(object sender, EventArgs e)
        {
            this.сообщенияBindingSource.Filter = this.userMessagesFilter;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Сообщения". При необходимости она может быть перемещена или удалена.
            this.сообщенияTableAdapter.Fill(this._k_systemsDataSet.Сообщения);

            // Полученные сообщения
            this.inputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.EmailTabPage,
                    BaseControlText = this.EmailTabPage.Text,
                    CountingPredicate = (entity) => !(entity as СообщенияRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this._k_systemsDataSet.Сообщения,
                    UpdatingTableAdapter = this.сообщенияTableAdapter.Adapter,
                    CountingDataBindingSource = this.сообщенияBindingSource
                });

            /*// Отправленные сообщения
            this.исходящиеСообщенияBindingSource.Filter = this.userOutputMessagesFilter;
            this.outputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.outputMessagesTabPage,
                    BaseControlText = this.outputMessagesTabPage.Text,
                    CountingPredicate = (entity) => !(entity as СообщенияRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения,
                    UpdatingTableAdapter = this.сообщенияTableAdapter.Adapter,
                    CountingDataBindingSource = this.исходящиеСообщенияBindingSource
                });

            // Удалённые сообщения
            this.удаленныеСообщенияBindingSource.Filter = this.userDeletedMessagesFilter;
            this.сообщенияДляКлиентовУдаленныеTableAdapter.Fill(
                this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_клиентов_удаленные);
            this.deletedMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    CountingPredicate = (entity) => false,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_клиентов_удаленные,
                    UpdatingTableAdapter = this.сообщенияДляКлиентовУдаленныеTableAdapter.Adapter,
                    CountingDataBindingSource = this.удаленныеСообщенияBindingSource
                });*/
        }
    }
}
