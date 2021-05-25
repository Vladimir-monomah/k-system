using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k_systems._k_systemsDataSetTableAdapters;
using static k_systems._k_systemsDataSet;

namespace k_systems.Админка
{
    public partial class Добавить_услугу : Form
    {
        public delegate void OnSave();

        public delegate void OnBeforeSave(Вид_работRow isRecordExists);

        public delegate void OnBefore(Тип_ремонтаRow isRecordExist);

        public delegate void OnBeforePrice(Цены_работRow isRecEx);

        public Добавить_услугу()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            this.OnBeforeEvent += isRecordExist => { };
            this.OnBeforePriceEvent += isRecEx => { };
            this.InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        public event OnBefore OnBeforeEvent;

        public event OnBeforePrice OnBeforePriceEvent;

        public void ЗагрузитьУслугу(string услуга)
        {
            this.TypeService.Text = услуга;
        }

        private bool CheckTextBoxes()
        {
            if (this.TypeService.Text == "" || this.TypeRepair.Text == "" || this.Price.Text == "")
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Названия элементов справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var TypeService = this.TypeService.Text;
            var adapter = new Вид_работTableAdapter();
            adapter.Fill(EntityManager.TypeService);
            foreach (var works in EntityManager.TypeService)
            {
                if (works.Наименование == TypeService)
                {
                    MessageBox.Show("Вид услуги " +
                        "с таким названием уже существует!", "Информация", MessageBoxButtons.OK);
                    return;
                }
            }

            var TypeRepair = this.TypeRepair.Text;
            var adap = new Тип_ремонтаTableAdapter();
            adap.Fill(EntityManager.TypeRepair);
            foreach (var rep in EntityManager.TypeRepair)
            {
                if (rep.Наименование == TypeRepair)
                {
                    MessageBox.Show("Тип ремонта " +
                        "с таким названием уже существует!", "Информация", MessageBoxButtons.OK);
                    return;
                }
            }

            var newService = EntityManager.TypeService.NewВид_работRow();
            var newRepair = EntityManager.TypeRepair.NewТип_ремонтаRow();
            var newPrice = EntityManager.WorkPrices.NewЦены_работRow();
            newService.Наименование = TypeService;
            newRepair.Наименование = TypeRepair;
            EntityManager.TypeService.AddВид_работRow(newService);
            EntityManager.TypeRepair.AddТип_ремонтаRow(newRepair);
            EntityManager.UpdateTypeService();
            EntityManager.UpdateTypeRepair();

            newService = EntityManager.FilterTypeService(
                    $"Наименование = '{newService.Наименование}'")
                .First();

            newRepair = EntityManager.FilterTypeRepair(
                    $"Наименование = '{newRepair.Наименование}'")
                .First();

            newPrice.Цена = Convert.ToInt32(Price.Text);
            newPrice.Вид_работы = newService.Идентификатор;
            newPrice.Тип_ремонта = newRepair.Идентификатор;
            EntityManager.WorkPrices.AddЦены_работRow(newPrice);
            EntityManager.UpdateWorkPrices();

            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
        }
    }
}
