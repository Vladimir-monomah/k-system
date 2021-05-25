using k_systems.Email;
using System;
using System.Collections.Generic;
using System.Data;
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
                throw new Exception("Необходимо выбрать пользователя!");
            }

            if (string.IsNullOrEmpty(this.emailMessageTextBox.Text))
            {
                throw new Exception("Необходимо ввести текст сообщения!");
            }

            EmailService.SendEmail(
                null,
                (int)this.userAdresseesComboBox.SelectedValue,
                this.emailSubjectTextBox.Text,
                this.emailMessageTextBox.Text);
        }

        /// <summary>
        /// Запоминает текущее положение курсора для каждого грида,
        /// чтобы при обновлении выделенная строка не сбрасывалась
        /// </summary>
        private void SetCurrentRowPosition(DataGridView mailDataGridView, int rowIndex)
        {
            if (mailDataGridView == null)
            {
                return;
            }

            if (this.dataUpdating)
            {
                return;
            }

            this.currentDataGridViewRowPosition[mailDataGridView] = rowIndex;
        }

        /// <summary>
        /// Запоминает позицию выделенной мышью строки, чтобы восстановить при перезагрузке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SetCurrentRowPosition(sender as DataGridView, e.RowIndex);
        }

        /// <summary>
        /// Устанавливает курсор на сохранённую позицию после перезагрузки всех элементов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var mailDataGridView = sender as DataGridView;
            if (mailDataGridView == null)
            {
                return;
            }

            if (this.currentDataGridViewRowPosition.TryGetValue(mailDataGridView, out var currentRowIndex))
            {
                currentRowIndex = Math.Min(currentRowIndex, mailDataGridView.RowCount - 1);
                if (currentRowIndex > -1)
                {
                    this.dataUpdating = true;
                    mailDataGridView.CurrentCell = mailDataGridView[0, currentRowIndex];
                    this.dataUpdating = false;
                }
            }
        }

        /// <summary>
        /// Запоминает позицию выделенной стрелками строки, чтобы восстановить при перезагрузке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            var direction = e.KeyCode == Keys.Down
                ? 1
                : e.KeyCode == Keys.Up
                    ? -1
                    : 0;

            var mailDataGridView = sender as DataGridView;
            if (mailDataGridView?.CurrentCell == null)
            {
                return;
            }

            this.SetCurrentRowPosition(mailDataGridView, mailDataGridView.CurrentCell.RowIndex + direction);
        }

        /// <summary>
        /// Показывает окно с полным текстом сообщения, помечая его прочитанным, если оно во входящих
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var mailDataGridView = sender as DataGridView;
            if (mailDataGridView?.CurrentCell == null)
            {
                return;
            }

            var message = ((DataRowView)mailDataGridView.CurrentRow.DataBoundItem).Row;
            var subjectMessage = message.GetType().GetProperty("Тема")?.GetValue(message) as string;
            var textMessage = message.GetType().GetProperty("Текст_сообщения")?.GetValue(message) as string;

            if (sender == this.inputMessagesDataGridView)
            {
                // Укажем письмо прочитанным
                var messageCode = message.GetType().GetProperty("Код")?.GetValue(message) as int?
                    ?? message.GetType().GetProperty("Идентификатор_сообщения")?.GetValue(message) as int?;
                if (messageCode.HasValue)
                {
                    EmailService.MarkEmailRed(messageCode.Value);
                }
            }

            (new EmailMessageForm(subjectMessage, textMessage)).ShowDialog();
        }

        /// <summary>
        /// Показывает вопрос об удалении файла
        /// </summary>
        /// <returns>
        /// True - пользователь нажал "Да"
        /// False - пользователь нажал "Нет"
        /// </returns>
        private bool ShowQuestionOnDeleteMessage()
        {
            var pressedButton = MessageBox.Show(
                "Вы действительно хотите удалить сообщение?",
                "Предупреждение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Stop);
            return pressedButton == DialogResult.OK;
        }

        /// <summary>
        /// Удаляет выделенное сообщение на вкладке "Входящие"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMessageButton_Click(object sender, EventArgs e)
        {
            if (this.ShowQuestionOnDeleteMessage())
            {
                var удаляемоеСообщение = (Сообщения_для_администраторовRow)
                    ((DataRowView)this.inputMessagesDataGridView.CurrentRow.DataBoundItem).Row;
                EmailService.DeleteEmail(удаляемоеСообщение.Идентификатор_сообщения, удаленоПолучателем: true);
            }
        }

        /// <summary>
        /// Удаляет выделенное сообщение на вкладке "Отправленные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteOutMessageButton_Click(object sender, EventArgs e)
        {
            if (this.ShowQuestionOnDeleteMessage())
            {
                var удаляемоеСообщение = (Сообщения_для_администраторов_отправленныеRow)
                    ((DataRowView)this.outMessagesDataGridView.CurrentRow.DataBoundItem).Row;
                EmailService.DeleteEmail(удаляемоеСообщение.Идентификатор_сообщения, удаленоОтправителем: true);
            }
        }
    }
}
