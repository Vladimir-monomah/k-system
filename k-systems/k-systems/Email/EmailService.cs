using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace k_systems.Email
{
    public class EmailService
    {
        private static Dictionary<int, Timer> timers = new Dictionary<int, Timer>();
        private static int newIdentifier = 1;

        /// <summary>
        /// Создает таймер, который с указанным периодом будет обновлять сообщения
        /// </summary>
        /// <param name="updatingParameters"></param>
        /// <returns>Идентификатор таймера, с помощью которого можно остановить обновление сообщений</returns>
        public static int StartCheckingNewMessages(
            UpdateTimerParameters updatingParameters)
        {
            if (updatingParameters == null)
            {
                throw new ArgumentNullException(nameof(updatingParameters));
            }

            var newTimer = timers[++newIdentifier] = new Timer();
            newTimer.Interval = updatingParameters.Interval;
            newTimer.Tick += (sender, eventArguments) =>
            {
                // Загружаем из БД строки
                var updatedTable = updatingParameters.UpdatedTable;
                updatedTable.Clear();
                updatingParameters.UpdatingTableAdapter.Fill(updatedTable);

                // Обновляем количество непрочитанных сообщений в заголовке вкладки "Входящие"
                var predicate = updatingParameters.CountingPredicate;
                var control = updatingParameters.ChangingTextControl;
                if (predicate != null && control != null)
                {
                    var countUnreadMessages = 0;
                    foreach (var dataRow in updatingParameters.CountingDataBindingSource)
                    {
                        if (predicate((dataRow as DataRowView).Row))
                        {
                            countUnreadMessages++;
                        }
                    }

                    if (updatingParameters.ChangingTextControl != null)
                    {
                        updatingParameters.ChangingTextControl.Text =
                            $"{updatingParameters.BaseControlText} ({countUnreadMessages})";
                    }
                }
            };
            newTimer.Start();

            return newIdentifier;
        }

        /// <summary>
        /// Останавливает таймер по идентификатору, возвращенному методом <see cref="StartCheckingNewMessages"/>
        /// </summary>
        /// <param name="timerId"></param>
        public static void StopCheckingNewMessages(int timerId)
        {
            if (timers.TryGetValue(timerId, out var stoppingTimer))
            {
                stoppingTimer.Stop();
                timers.Remove(timerId);
            }
        }

        /// <summary>
        /// Отправляет сообщение адресату
        /// </summary>
        /// <param name="addresserUserId">Отправитель письма. Null, если отправляется администратором</param>
        /// <param name="addresseeUserId">Получатель письма. Null, если отправляется администратору</param>
        /// <param name="subject">Тема отправляемого сообщения</param>
        /// <param name="textMessage">Текст сообщения</param>
        public static void SendEmail(int? addresserUserId, int? addresseeUserId, string subject, string textMessage)
        {
            if (!addresserUserId.HasValue && !addresseeUserId.HasValue)
            {
                throw new Exception(
                    "Необходимо указать хотя бы один из параметров: \"Получатель\" или \"Отправитель\"");
            }

            var newMessage = EntityManager.MessageDataTable.NewСообщенияRow();
            if (addresserUserId.HasValue)
            {
                newMessage.Отправитель = addresserUserId.Value;
            }

            if (addresseeUserId.HasValue)
            {
                newMessage.Получатель = addresseeUserId.Value;
            }

            newMessage.Текст_сообщения = textMessage;
            newMessage.Тема = subject;

            EntityManager.MessageDataTable.AddСообщенияRow(newMessage);
            EntityManager.UpdateMessages();
        }

        /// <summary>
        /// Помечает письмо удаленным для отправителя или получателя в зависимости от параметров
        /// </summary>
        /// <param name="кодСообщения"></param>
        /// <param name="удаленоОтправителем"></param>
        /// <param name="удаленоПолучателем"></param>
        public static void DeleteEmail(int кодСообщения, bool удаленоОтправителем = false, bool удаленоПолучателем = false)
        {
            var удаляемоеСообщение = EntityManager.FilterMessages($"Код = {кодСообщения}").FirstOrDefault();
            if (удаляемоеСообщение == null)
            {
                return;
            }

            if (удаленоОтправителем)
            {
                удаляемоеСообщение.Удалено_отправителем = true;
            }

            if (удаленоПолучателем)
            {
                удаляемоеСообщение.Прочитано_получателем = удаляемоеСообщение.Удалено_получателем = true;
            }

            EntityManager.UpdateMessages();
        }

        /// <summary>
        /// Помечает сообщение прочитанным получателем
        /// </summary>
        /// <param name="кодСообщения"></param>
        public static void MarkEmailRed(int кодСообщения)
        {

            var помечаемоеСообщение = EntityManager.FilterMessages($"Код = {кодСообщения}").FirstOrDefault();
            if (помечаемоеСообщение == null || помечаемоеСообщение.Прочитано_получателем)
            {
                return;
            }

            помечаемоеСообщение.Прочитано_получателем = true;

            EntityManager.UpdateMessages();
        }

        /// <summary>
        /// Параметры для запуска таймера по обновлению сообщений
        /// </summary>
        public class UpdateTimerParameters
        {
            /// <summary>
            /// Компонент, которому необходимо обновить заголовок
            /// </summary>
            public Control ChangingTextControl { get; set; }

            /// <summary>
            /// Неизменная часть названия компонента <see cref="ChangingTextControl"/>
            /// </summary>
            public string BaseControlText { get; set; }

            /// <summary>
            /// Таблица хранения обновлённых записей
            /// </summary>
            public DataTable UpdatedTable { get; set; }

            /// <summary>
            /// Адаптер, обновляющий таблицу обновлённых записей
            /// </summary>
            public DbDataAdapter UpdatingTableAdapter { get; set; }

            /// <summary>
            /// Объект типа BindingSource, использующийся для подсчета фильтрованных данных
            /// </summary>
            public BindingSource CountingDataBindingSource { get; set; }

            /// <summary>
            /// Интервал обновления данных (в миллисекундах)
            /// </summary>
            public int Interval { get; set; }

            /// <summary>
            /// Определяет допустимость вхождения строки в подсчитываемое количество
            /// </summary>
            public Func<DataRow, bool> CountingPredicate { get; set; }
        }
    }
}
