using k_systems.Константы;
using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static k_systems._k_systemsDataSet;
using Word = Microsoft.Office.Interop.Word;

namespace k_systems.Админка
{
    public partial class Акт_приёмки_заказа : Form
    {
        public ЗаказыRow заказы;

        private _k_systemsDataSet orderDataSet;

        public Акт_приёмки_заказа(_k_systemsDataSet k_SystemsDataSet)
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.Work.Checked
                && !this.Ready.Checked
                && !this.Postponed.Checked)
            {
                this.заказы.Статус_заказа = WorkStates.Waiting;
            }
            else if (this.Work.Checked
                && !this.Ready.Checked
                && !this.Postponed.Checked)
            {
                this.заказы.Статус_заказа = WorkStates.Working;
            }
            else if (!this.Work.Checked
                && this.Ready.Checked
                && !this.Postponed.Checked)
            {
                this.заказы.Статус_заказа = WorkStates.Ready;
            }
            else if (!this.Work.Checked
                && !this.Ready.Checked
                && this.Postponed.Checked)
            {
                this.заказы.Статус_заказа = WorkStates.Postponed;
            }
            else
            {
                MessageBox.Show("Статус заказа указан неверно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EntityManager.UpdateOrder(
                $"[Статус заказа] = '{this.заказы.Статус_заказа}'",
                $"Идентификатор = {this.заказы.Идентификатор}");
            this.SetOrderState(this.заказы.Статус_заказа);

            MessageBox.Show("Заказ успешно обновлён", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
                    this.Work.Enabled = true;
                    this.Ready.Enabled = false;
                    this.Postponed.Enabled = true;
                    break;

                case WorkStates.Working:
                    this.Work.Checked = true;

                    this.Work.Enabled = false;
                    this.Ready.Enabled = true;
                    this.Postponed.Enabled = true;
                    break;

                case WorkStates.Ready:
                    this.Ready.Checked = true;

                    this.Work.Enabled = false;
                    this.Ready.Enabled = false;
                    this.Postponed.Enabled = false;
                    break;

                case WorkStates.Postponed:
                    this.Postponed.Checked = true;

                    this.Work.Enabled = true;
                    this.Ready.Enabled = false;
                    this.Postponed.Enabled = false;

                    break;
                default:
                    MessageBox.Show($"Статус заказа '{stateName}' неправильный!");
                    return;
            }

            this.Save.Enabled = false;
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

            this.Save.Enabled = true;

            this.EnableCheckingEvents();
        }

        /// <summary>
        /// Печать акта приёмки заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var templateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "акт приёма оборудования.dotx");
            if (!File.Exists(templateFile))
            {
                throw new Exception("Не найден файл " + templateFile);
            }
            var oWord = new Word.Application();
            _Document oDoc = null;
            var newTemplateFile = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    $"Акты приёма\\акт_приёма_оборудования_{DateTime.Now:dd.MM.yyyy_HH.mm.ss}_{this.textBoxFIO.Text}.docx");

            try
            {
                oDoc = oWord.Documents.Add(templateFile);
                this.SetTemplate(oDoc);

                oDoc.SaveAs2(FileName: newTemplateFile);
            }
            finally
            {
                oDoc?.Close();
                oWord.Quit();
            }
            MessageBox.Show("Сохранение прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(newTemplateFile);
        }

        private void SetTemplate(_Document oDoc)
        {
            var tableInfo = oDoc.Tables[1];
            tableInfo.Cell(3, 2).Range.Text = this.textBoxFIO.Text;
            tableInfo.Cell(4,2).Range.Text = this.tbPhone.Text;
            tableInfo.Cell(5, 2).Range.Text = this.tbTypeWork.Text;
            tableInfo.Cell(6, 2).Range.Text = this.tbKindWork.Text;
            tableInfo.Cell(7, 2).Range.Text = this.tbPrice.Text;
        }
    }
}