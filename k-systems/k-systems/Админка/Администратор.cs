using k_systems.Properties;
using k_systems.РегАвт;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static k_systems._k_systemsDataSet;

namespace k_systems.Админка
{
    public partial class Администратор : Form
    {
        private string password = "ntvHA2s1y+ryOZizPQ1WHQ==";

        private readonly Авторизация авторизация;

        public Администратор(Авторизация авторизация)
        {
            this.InitializeComponent();
            this.Администратор_Load();
            this.авторизация = авторизация;
        }

        private void Администратор_Load()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_с_клиентами". При необходимости она может быть перемещена или удалена.
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
        }

        /// <summary>
        /// Фильтрация пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void masterFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] {"ФИО" };
            var filterStringByFiels = EntityManager.GetFilterStringByFields(findFields, this.masterFilterTextBox.Text).Trim();

            if (!string.IsNullOrEmpty(filterStringByFiels))
            {
                filterStringByFiels = $"({filterStringByFiels})";
            }

            this.заказыСКлиентамиBindingSource.Filter = filterStringByFiels;
        }

        private void Администратор_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AddOrder_Click(object sender, EventArgs e)
        {
            var открыть = new Добавить_заказ();
            открыть.ShowDialog();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedRow = (ПользователиRow)((DataRowView)((DataGridView)sender).CurrentRow.DataBoundItem).Row;
            var userTable = EntityManager.FilterUsers($"Id = {changedRow.Id}");

            userTable[0].Id = changedRow.Id;
            userTable[0].Фамилия = changedRow.Фамилия;
            userTable[0].Имя = changedRow.Имя;
            userTable[0].Отчество = changedRow.Отчество;
            userTable[0]._E_mail = changedRow._E_mail;

            EntityManager.UpdateUsers();

        }

        private void СhangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.авторизация.Show();
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            var открыть = new Клиенты(this.password);
            открыть.ShowDialog();
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            var открыть = new Добавить_услугу();
            открыть.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.masterFilterTextBox.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //int ind = this.dataGridView.SelectedCells[0].RowIndex;
            //this.dataGridView.Rows.RemoveAt(ind);

            var idUser= ((Заказы_с_клиентамиRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Номер_заказа;
            if (!idUser.HasValue)
            {
                return;
            }

            var deleteUser = MessageBox.Show("Вы действительно хотите удалить данный заказ клиента? ", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteUser != DialogResult.Yes)
            {
                return;
            }

            using(var connection=new OleDbConnection(Settings.Default.k_systemsConnectionString))
            {
                connection.Open();
                using(var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"DELETE FROM [Заказы с клиентами] WHERE [Номер заказа]={idUser.Value}";
                    sqlCommand.ExecuteNonQuery();
                }
            }

            this.Администратор_Load();
        }

        private void SaveDB_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\k-systems.mdb";
            var saveDialog = new SaveFileDialog
            {
                Filter="AccessDB files|*.mdb"
            };
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(dataBasePath, saveDialog.FileName, true);
                    MessageBox.Show("Резервное копирование прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удаётся скопировать файл из-за исключения: " + ex.Message);
            }
        }

        private void RestoreDB_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\k-systems.mdb";
            var openDialog = new OpenFileDialog
            {
                Filter = "AccessDB files|*.mdb"
            };
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openDialog.FileName, dataBasePath, true);
                    MessageBox.Show("Восстановление прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.заказы_с_клиентамиTableAdapter.Adapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
                this.заказы_с_клиентамиTableAdapter.Adapter.Update(this._k_systemsDataSet.Заказы_с_клиентами);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            var открыть = new Почта();
            открыть.ShowDialog();
        }

        private void Reporting_Click(object sender, EventArgs e)
        {
            var открыть = new Отчётность_по_заказам();
            открыть.ShowDialog();
        }

        private void Администратор_Load(object sender, EventArgs e)
        {

        }
    }
}
