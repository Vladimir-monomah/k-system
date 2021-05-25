using k_systems.Email;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static k_systems._k_systemsDataSet;

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

            //Удалённые сообщения
            this.сообщения_для_администраторов_удалённыеTableAdapter.Fill(
                this._k_systemsDataSet.Сообщения_для_администраторов_удалённые);
            this.deletedMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    CountingPredicate = (entity) => false,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this._k_systemsDataSet.Сообщения_для_администраторов_удалённые,
                    UpdatingTableAdapter = this.сообщения_для_администраторов_удалённыеTableAdapter.Adapter,
                    CountingDataBindingSource = this.сообщенияДляАдминистраторовУдалённыеBindingSource
                });

            //Отправленные сообщения
            this.сообщения_для_администраторов_отправленныеTableAdapter.Fill(
                this._k_systemsDataSet.Сообщения_для_администраторов_отправленные);
            this.сообщенияДляАдминистраторовОтправленныеBindingSource.Filter = FilterSendedMessages;
            this.outputMessagesTimerId = EmailService.StartCheckingNewMessages(
                 new EmailService.UpdateTimerParameters
                 {
                     ChangingTextControl = this.outcommingMessagesTabPanel,
                     BaseControlText = this.outcommingMessagesTabPanel.Text,
                     CountingPredicate = (entity) =>
                         !(entity as Сообщения_для_администраторов_отправленныеRow).Прочитано_получателем,
                     Interval = UpdateMessagePeriod,
                     UpdatedTable = this._k_systemsDataSet.Сообщения_для_администраторов_отправленные,
                     UpdatingTableAdapter = this.сообщения_для_администраторов_отправленныеTableAdapter.Adapter,
                     CountingDataBindingSource = this.сообщенияДляАдминистраторовОтправленныеBindingSource
                 });

            //Полученные сообщения
            this.сообщения_для_администраторовTableAdapter.Fill(
                this._k_systemsDataSet.Сообщения_для_администраторов);
            this.сообщенияДляАдминистраторовBindingSource.Filter = FilterNonDeletedMessagesByReciver;
            this.inputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.incomingMessagesTabPanel,
                    BaseControlText = this.incomingMessagesTabPanel.Text,
                    CountingPredicate = (entity) =>
                        !(entity as Сообщения_для_администраторовRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this._k_systemsDataSet.Сообщения_для_администраторов,
                    UpdatingTableAdapter = this.сообщения_для_администраторовTableAdapter.Adapter,
                    CountingDataBindingSource = this.сообщенияДляАдминистраторовBindingSource
                });
        }

        /// <summary>
        /// Останавливает все запущенные таймеры
        /// </summary>
        private void StopUpdateTimers()
        {
            EmailService.StopCheckingNewMessages(this.inputMessagesTimerId);
            EmailService.StopCheckingNewMessages(this.outputMessagesTimerId);
            EmailService.StopCheckingNewMessages(this.deletedMessagesTimerId);
        }

        /// <summary>
        /// Отправка сообщений выбранному пользователю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (this.userAdresseesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать пользователя!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrEmpty(this.emailMessageTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести текст сообщения!",
                  "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            EmailService.SendEmail(
                null,
                (int)this.userAdresseesComboBox.SelectedValue,
                this.emailSubjectTextBox.Text,
                this.emailMessageTextBox.Text);
        }
    }
}
