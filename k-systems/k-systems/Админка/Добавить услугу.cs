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

        public Добавить_услугу()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            this.OnBeforeEvent += isRecordExist => { };
            this.InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        public event OnBefore OnBeforeEvent;

        public void ЗагрузитьУслугу(string услуга)
        {
            this.TypeService.Text = услуга;
        }

        private bool CheckTextBoxes()
        {
            if (this.TypeService.Text == "" || this.TypeRepair.Text == "")
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
            Вид_работRow existingService = null;
            foreach(var works in EntityManager.TypeService)
            {
                if (works.Наименование == TypeService)
                {
                    existingService = works;
                    break;
                }
            }

            var TypeRepair = this.TypeRepair.Text;
            var adap = new Тип_ремонтаTableAdapter();
            adap.Fill(EntityManager.TypeRepair);
            Тип_ремонтаRow existingRepair = null;
            foreach(var rep in EntityManager.TypeRepair)
            {
                if (rep.Наименование == TypeRepair)
                {
                    existingRepair = rep;
                    break;
                }
            }

            if (existingService != null || existingRepair != null)
            {
                this.OnBeforeSaveEvent(existingService);
                MessageBox.Show("Вид услуги или тип ремонта" +
                    "с таким названием уже существует!", "Информация", MessageBoxButtons.OK);
                return;
            }

            var newService = EntityManager.TypeService.NewВид_работRow();
            var newRepair = EntityManager.TypeRepair.NewТип_ремонтаRow();
            newService.Наименование = TypeService;
            newRepair.Наименование = TypeRepair;
            EntityManager.TypeService.AddВид_работRow(newService);
            EntityManager.TypeRepair.AddТип_ремонтаRow(newRepair);
            EntityManager.UpdateTypeService();
            EntityManager.UpdateTypeRepair();
            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }
    }
}
