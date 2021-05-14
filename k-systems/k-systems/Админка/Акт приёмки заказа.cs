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

namespace k_systems.Админка
{
    public partial class Акт_приёмки_заказа : Form
    {
        public Заказы_с_клиентамиRow заказы;

        private _k_systemsDataSet orderDataSet;

        public Акт_приёмки_заказа(_k_systemsDataSet k_SystemsDataSet)
        {
            this.InitializeComponent();

            this.orderDataSet = k_SystemsDataSet;
        }

        public void LoadЗаказы(Заказы_с_клиентамиRow заказы)
        {
            this.textBoxFIO.Text = заказы.ФИО;
            this.tbTypeWork.Text = заказы.Вид_работы;
            this.tbKindWork.Text = заказы.Тип_ремонта;
            this.tbPrice.Text = Convert.ToInt32(заказы.Цена).ToString();
        }
    }
}
