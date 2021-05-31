using k_systems.Email;
using k_systems.Админка;
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

        private long currentUserId;

        private Dictionary<DataGridView, int> currentDataGridViewRowPosition = new Dictionary<DataGridView, int>();
        private bool dataUpdating = false;

        public Почта(long userId)
        {
            // Сообщения
            this.userMessagesFilter = $"([Получатель] = {userId}) AND ([Удалено получателем] = FALSE)";
            this.userOutputMessagesFilter = $"([Отправитель] = {userId}) AND ([Удалено отправителем] = FALSE)";
            this.userDeletedMessagesFilter = $"([Отправитель] = {userId}) OR ([Получатель] = {userId})";
            this.currentUserId = userId;

            InitializeComponent();
        }

        private void Почта_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Сообщения_для_клиентов_удалённые". При необходимости она может быть перемещена или удалена.
            this.сообщения_для_клиентов_удалённыеTableAdapter.Fill(this._k_systemsDataSet.Сообщения_для_клиентов_удалённые);
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

            // Отправленные сообщения
            this.исходящиеСообщенияBindingSource.Filter = this.userOutputMessagesFilter;
            this.outputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.outputMessagesTabPage,
                    BaseControlText = this.outputMessagesTabPage.Text,
                    CountingPredicate = (entity) => !(entity as СообщенияRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this._k_systemsDataSet.Сообщения,
                    UpdatingTableAdapter = this.сообщенияTableAdapter.Adapter,
                    CountingDataBindingSource = this.исходящиеСообщенияBindingSource
                });

            // Удалённые сообщения
            this.удаленныеСообщенияBindingSource.Filter = this.userDeletedMessagesFilter;
            this.сообщения_для_клиентов_удалённыеTableAdapter.Fill(
                this._k_systemsDataSet.Сообщения_для_клиентов_удалённые);
            this.deletedMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    CountingPredicate = (entity) => false,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this._k_systemsDataSet.Сообщения_для_клиентов_удалённые,
                    UpdatingTableAdapter = this.сообщения_для_клиентов_удалённыеTableAdapter.Adapter,
                    CountingDataBindingSource = this.удаленныеСообщенияBindingSource
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

        private void emailSendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.emailMessageTextBox.Text))
            {
                throw new Exception("Необходимо ввести текст сообщения!");
            }

            EmailService.SendEmail(
                this.currentUserId,
                null,
                this.emailSubjectTextBox.Text,
                this.emailMessageTextBox.Text);

            this.сообщенияTableAdapter.Fill(this._k_systemsDataSet.Сообщения);
            MessageBox.Show("Сообщение успешно отправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var messageCode = message.GetType().GetProperty("Код")?.GetValue(message) as int?;
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
        private void inputMessageDeleteButton_Click(object sender, EventArgs e)
        {
            if (this.ShowQuestionOnDeleteMessage())
            {
                var удаляемоеСообщение = (СообщенияRow)
                    ((DataRowView)this.inputMessagesDataGridView.CurrentRow.DataBoundItem).Row;
                EmailService.DeleteEmail(удаляемоеСообщение.Код, удаленоПолучателем: true);
            }
        }

        private void outputMessageDeleteButton_Click(object sender, EventArgs e)
        {
            var удаляемоеСообщение = (СообщенияRow)
                    ((DataRowView)this.outputMessagesDataGridView.CurrentRow.DataBoundItem).Row;
            EmailService.DeleteEmail(удаляемоеСообщение.Код, удаленоОтправителем: true);
        }
    }
}
