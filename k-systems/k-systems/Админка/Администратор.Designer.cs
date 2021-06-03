namespace k_systems.Админка
{
    partial class Администратор
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Администратор));
            this.masterFilterTextBox = new System.Windows.Forms.TextBox();
            this.labelSortingCustomers = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddService = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporting = new System.Windows.Forms.ToolStripMenuItem();
            this.почтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Email = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDB = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.СhangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.заказыСКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказы_с_клиентамиTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Заказы_с_клиентамиTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masterFilterTextBox
            // 
            this.masterFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterFilterTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterFilterTextBox.Location = new System.Drawing.Point(13, 54);
            this.masterFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.masterFilterTextBox.MaxLength = 30;
            this.masterFilterTextBox.Multiline = true;
            this.masterFilterTextBox.Name = "masterFilterTextBox";
            this.masterFilterTextBox.Size = new System.Drawing.Size(1620, 46);
            this.masterFilterTextBox.TabIndex = 18;
            this.masterFilterTextBox.TextChanged += new System.EventHandler(this.masterFilterTextBox_TextChanged);
            // 
            // labelSortingCustomers
            // 
            this.labelSortingCustomers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortingCustomers.Location = new System.Drawing.Point(10, 31);
            this.labelSortingCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortingCustomers.Name = "labelSortingCustomers";
            this.labelSortingCustomers.Size = new System.Drawing.Size(246, 28);
            this.labelSortingCustomers.TabIndex = 19;
            this.labelSortingCustomers.Text = "Поиск клиента";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.видРаботыDataGridViewTextBoxColumn,
            this.типРемонтаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.статусЗаказаDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView.DataSource = this.заказыСКлиентамиBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(13, 162);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1621, 539);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(182, 107);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 49);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Удалить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.Location = new System.Drawing.Point(13, 107);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(163, 49);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "Сброс";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.отчётностьToolStripMenuItem,
            this.почтаToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1646, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewClient});
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.клиентToolStripMenuItem.Text = "Клиент";
            // 
            // NewClient
            // 
            this.NewClient.Name = "NewClient";
            this.NewClient.Size = new System.Drawing.Size(183, 26);
            this.NewClient.Text = "Новый клиент";
            this.NewClient.Click += new System.EventHandler(this.NewClient_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOrder});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // AddOrder
            // 
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(192, 26);
            this.AddOrder.Text = "Список заказов";
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddService});
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // AddService
            // 
            this.AddService.Name = "AddService";
            this.AddService.Size = new System.Drawing.Size(197, 26);
            this.AddService.Text = "Добавить услугу";
            this.AddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // отчётностьToolStripMenuItem
            // 
            this.отчётностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reporting});
            this.отчётностьToolStripMenuItem.Name = "отчётностьToolStripMenuItem";
            this.отчётностьToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.отчётностьToolStripMenuItem.Text = "Отчётность";
            // 
            // Reporting
            // 
            this.Reporting.Name = "Reporting";
            this.Reporting.Size = new System.Drawing.Size(230, 26);
            this.Reporting.Text = "Сформировать отчёт";
            this.Reporting.Click += new System.EventHandler(this.Reporting_Click);
            // 
            // почтаToolStripMenuItem
            // 
            this.почтаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Email});
            this.почтаToolStripMenuItem.Name = "почтаToolStripMenuItem";
            this.почтаToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.почтаToolStripMenuItem.Text = "Почта";
            // 
            // Email
            // 
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(121, 26);
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveDB,
            this.RestoreDB,
            this.toolStripMenuItem1,
            this.СhangeUser});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // SaveDB
            // 
            this.SaveDB.Name = "SaveDB";
            this.SaveDB.Size = new System.Drawing.Size(229, 26);
            this.SaveDB.Text = "Сохранить БД";
            this.SaveDB.Click += new System.EventHandler(this.SaveDB_Click);
            // 
            // RestoreDB
            // 
            this.RestoreDB.Name = "RestoreDB";
            this.RestoreDB.Size = new System.Drawing.Size(229, 26);
            this.RestoreDB.Text = "Восстановить БД";
            this.RestoreDB.Click += new System.EventHandler(this.RestoreDB_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // СhangeUser
            // 
            this.СhangeUser.Name = "СhangeUser";
            this.СhangeUser.Size = new System.Drawing.Size(229, 26);
            this.СhangeUser.Text = "Смена пользователя";
            this.СhangeUser.Click += new System.EventHandler(this.СhangeUser_Click);
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыСКлиентамиBindingSource
            // 
            this.заказыСКлиентамиBindingSource.DataMember = "Заказы с клиентами";
            this.заказыСКлиентамиBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // заказы_с_клиентамиTableAdapter
            // 
            this.заказы_с_клиентамиTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видРаботыDataGridViewTextBoxColumn
            // 
            this.видРаботыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.видРаботыDataGridViewTextBoxColumn.DataPropertyName = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.HeaderText = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.Name = "видРаботыDataGridViewTextBoxColumn";
            this.видРаботыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типРемонтаDataGridViewTextBoxColumn
            // 
            this.типРемонтаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.типРемонтаDataGridViewTextBoxColumn.DataPropertyName = "Тип ремонта";
            this.типРемонтаDataGridViewTextBoxColumn.HeaderText = "Тип ремонта";
            this.типРемонтаDataGridViewTextBoxColumn.Name = "типРемонтаDataGridViewTextBoxColumn";
            this.типРемонтаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусЗаказаDataGridViewTextBoxColumn
            // 
            this.статусЗаказаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.статусЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Статус заказа";
            this.статусЗаказаDataGridViewTextBoxColumn.HeaderText = "Статус заказа";
            this.статусЗаказаDataGridViewTextBoxColumn.Name = "статусЗаказаDataGridViewTextBoxColumn";
            this.статусЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Администратор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 713);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.masterFilterTextBox);
            this.Controls.Add(this.labelSortingCustomers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Администратор";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастер";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Администратор_FormClosing);
            this.Load += new System.EventHandler(this.Администратор_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox masterFilterTextBox;
        private System.Windows.Forms.Label labelSortingCustomers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewClient;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddOrder;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddService;
        private System.Windows.Forms.ToolStripMenuItem отчётностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reporting;
        private System.Windows.Forms.ToolStripMenuItem почтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Email;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDB;
        private System.Windows.Forms.ToolStripMenuItem RestoreDB;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem СhangeUser;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource заказыСКлиентамиBindingSource;
        private _k_systemsDataSetTableAdapters.Заказы_с_клиентамиTableAdapter заказы_с_клиентамиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}