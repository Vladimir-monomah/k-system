using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k_systems._k_systemsDataSetTableAdapters;
using static k_systems._k_systemsDataSet;
using System.Data.OleDb;
using System.Data;

namespace k_systems
{
    public class EntityManager
    {
        static _k_systemsDataSet _K_Systems = new _k_systemsDataSet();

        private static ПользователиTableAdapter пользователиTableAdapter = new ПользователиTableAdapter();


        public static ПользователиDataTable UserDataTable
        {
            get
            {
                return _K_Systems.Пользователи;
            }
        }

        public static void UpdateUsers()
        {
            пользователиTableAdapter.Adapter.Update(UserDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу пользователей по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ПользователиDataTable FilterUsers(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = пользователиTableAdapter.Connection,
                CommandText = "SELECT Id, Фамилия, Имя, Отчество, Телефон, логин, пароль, " +
                $"[E-mail], [Является администратором] FROM Пользователи {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(пользователиTableAdapter.Adapter, filterUserCommand, UserDataTable);

            return UserDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
                ? new string[] { }
                : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OleDbDataAdapter adapter, OleDbCommand selectCommand, DataTable table)
        {
            var oldSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = oldSelectComand;
        }
    }
}
