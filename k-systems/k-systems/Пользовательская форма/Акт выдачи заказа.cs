using k_systems.Константы;
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
    public partial class Заказ_для_клиента : Form
    {
        public ЗаказыRow заказы;

        private _k_systemsDataSet orderDataSet;

        public Заказ_для_клиента(_k_systemsDataSet k_SystemsDataSet)
        {
            this.InitializeComponent();

            this.orderDataSet = k_SystemsDataSet;
        }

        public void LoadЗаказы(Заказы_с_клиентамиRow заказы)
        {
            this.textBoxFIO.Text = заказы.ФИО;
            this.tbPhone.Text = заказы.Телефон;
            this.tbTypeWork.Text = заказы.Вид_работы;
            this.tbKindWork.Text = заказы.Тип_ремонта;
            this.tbPrice.Text = Convert.ToInt32(заказы.Цена).ToString();

            // Инициализируем статус заказа
            this.SetOrderState(заказы.Статус_заказа);

            this.заказы = EntityManager.FilterOrders("Идентификатор = " + заказы.Номер_заказа).First();
        }

        private void SetOrderState(string stateName)
        {
            this.DisableCheckingEvents();
            this.Work.Checked = false;
            this.Ready.Checked = false;
            this.Postponed.Checked = false;
            switch (stateName)
            {
                case WorkStates.Waiting:
                    this.Work.Enabled = false;
                    this.Ready.Enabled = false;
                    this.Postponed.Enabled = false;
                    break;

                case WorkStates.Working:
                    this.Work.Checked = false;

                    this.Work.Enabled = false;
                    this.Ready.Enabled = false;
                    this.Postponed.Enabled = false;
                    break;

                case WorkStates.Ready:
                    this.Ready.Checked = false;

                    this.Work.Enabled = false;
                    this.Ready.Enabled = false;
                    this.Postponed.Enabled = false;
                    break;

                case WorkStates.Postponed:
                    this.Postponed.Checked = false;

                    this.Work.Enabled = false;
                    this.Ready.Enabled = false;
                    this.Postponed.Enabled = false;

                    break;
                default:
                    MessageBox.Show($"Статус заказа '{stateName}' неправильный!");
                    return;
            }
            this.EnableCheckingEvents();
        }

        private void DisableCheckingEvents()
        {
            this.Work.CheckedChanged -= this.States_CheckedChanged;
            this.Ready.CheckedChanged -= this.States_CheckedChanged;
            this.Postponed.CheckedChanged -= this.States_CheckedChanged;

        }

        private void EnableCheckingEvents()
        {
            this.Work.CheckedChanged += this.States_CheckedChanged;
            this.Ready.CheckedChanged += this.States_CheckedChanged;
            this.Postponed.CheckedChanged += this.States_CheckedChanged;
        }

        private void States_CheckedChanged(object sender, EventArgs e)
        {
            this.DisableCheckingEvents();

            var allStateCheckers = new[] { this.Work, this.Postponed, this.Ready };
            var otherStateCheckers = allStateCheckers.Where(checkBox => checkBox != sender).ToArray();
            foreach (var checkBox in otherStateCheckers)
            {
                checkBox.Checked = false;
            }

            foreach (var checkBox in allStateCheckers)
            {
                checkBox.Enabled = false;
            }

            this.EnableCheckingEvents();
        }
    }
}
