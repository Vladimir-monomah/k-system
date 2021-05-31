using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static k_systems._k_systemsDataSet;

namespace k_systems.Админка
{
    public partial class Отчётность_по_заказам : Form
    {
        private Заказы_с_клиентамиRow заказы;
        public Отчётность_по_заказам()
        {
            this.InitializeComponent();
        }

        private void Отчётность_по_заказам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Отчётность_по_заказам". При необходимости она может быть перемещена или удалена.
            this.отчётность_по_заказамTableAdapter.Fill(this._k_systemsDataSet.Отчётность_по_заказам, 0);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Заказы_с_клиентами". При необходимости она может быть перемещена или удалена.
            this.заказы_с_клиентамиTableAdapter.Fill(this._k_systemsDataSet.Заказы_с_клиентами);
            this.reportViewer1.RefreshReport();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            var карточкаКлиента = new Карточка_клиентов();
            if (карточкаКлиента.ShowDialog() == DialogResult.OK)
            {
                var выбранныйКлиент = карточкаКлиента.GetCurrentOrder();
                this.textBox9.Text = выбранныйКлиент.ФИО;
                this.заказы = выбранныйКлиент;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            DateTime dateBegin;
            DateTime dateEnd;
            if (string.IsNullOrWhiteSpace(this.textBox9.Text))
            {
                this.заказы = null;
                MessageBox.Show("Выберите клиента!");
                return;
            }

            //if (this.onMonthRadioButton.Checked)
            //{
            //    var choosedDate = DateTime.ParseExact(
            //        this.onMonthDateTimePicker.Value.ToString("dd.MM.yyyy"),
            //        "dd.MM.yyyy",
            //        CultureInfo.InvariantCulture);
            //    dateBegin = choosedDate.AddDays(1 - choosedDate.Day);
            //    dateEnd = choosedDate.AddDays(
            //        DateTime.DaysInMonth(choosedDate.Year, choosedDate.Month) - choosedDate.Day)
            //        .AddHours(23)
            //        .AddMinutes(59)
            //        .AddSeconds(59)
            //        .AddMilliseconds(999);
            //}
            //else if (this.onPeriodRadioButton.Checked)
            //{
            //    dateBegin = DateTime.ParseExact(
            //        this.onPeriodBeginDateTimePicker.Value.ToString("dd.MM.yyyy"),
            //        "dd.MM.yyyy",
            //        CultureInfo.InvariantCulture);
            //    dateEnd = DateTime.ParseExact(
            //            this.onPeriodEndDateTimePicker.Value.ToString("dd.MM.yyyy"),
            //            "dd.MM.yyyy",
            //            CultureInfo.InvariantCulture)
            //        .AddHours(23)
            //        .AddMinutes(59)
            //        .AddSeconds(59)
            //        .AddMilliseconds(999);
            //}
            //else
            //{
            //    MessageBox.Show("Выберите период формирования отчёта!");
            //    return;
            //}
            try
            {
                this.отчётность_по_заказамTableAdapter.Fill(this._k_systemsDataSet.Отчётность_по_заказам, this.заказы.Номер_клиента);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter(
                    "IsDataNull",
                    (this._k_systemsDataSet.Отчётность_по_заказам.Rows.Count == 0).ToString()));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)this._k_systemsDataSet.Отчётность_по_заказам));
                this.reportViewer1.RefreshReport();
            }
            catch
            {

            }
        }
    }
}
