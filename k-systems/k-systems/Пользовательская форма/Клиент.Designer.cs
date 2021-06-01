namespace k_systems.Пользовательская_форма
{
    partial class Клиент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Клиент));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.сменитьАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.почтаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.видРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценыРаботДляКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.priceListFilterTextBox = new System.Windows.Forms.TextBox();
            this.labelSortingCustomers = new System.Windows.Forms.Label();
            this.цены_работ_для_клиентаTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Цены_работ_для_клиентаTableAdapter();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценыРаботДляКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьАккаунтToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.почтаToolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1164, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // сменитьАккаунтToolStripMenuItem
            // 
            this.сменитьАккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПользователяToolStripMenuItem});
            this.сменитьАккаунтToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сменитьАккаунтToolStripMenuItem.Image")));
            this.сменитьАккаунтToolStripMenuItem.Name = "сменитьАккаунтToolStripMenuItem";
            this.сменитьАккаунтToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.сменитьАккаунтToolStripMenuItem.Text = "Сменить аккаунт";
            // 
            // сменаПользователяToolStripMenuItem
            // 
            this.сменаПользователяToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сменаПользователяToolStripMenuItem.Image")));
            this.сменаПользователяToolStripMenuItem.Name = "сменаПользователяToolStripMenuItem";
            this.сменаПользователяToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.сменаПользователяToolStripMenuItem.Text = "Смена пользователя";
            this.сменаПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменаПользователяToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справочникиToolStripMenuItem.Image")));
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыToolStripMenuItem.Image")));
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // почтаToolStripMenuItem1
            // 
            this.почтаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem});
            this.почтаToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("почтаToolStripMenuItem1.Image")));
            this.почтаToolStripMenuItem1.Name = "почтаToolStripMenuItem1";
            this.почтаToolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.почтаToolStripMenuItem1.Text = "Почта";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emailToolStripMenuItem.Image")));
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.toolStripMenuItem3,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("помощьToolStripMenuItem.Image")));
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(233, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
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
            this.видРаботыDataGridViewTextBoxColumn,
            this.типРемонтаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.ценыРаботДляКлиентаBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 108);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1140, 528);
            this.dataGridView.TabIndex = 1;
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
            // ценыРаботДляКлиентаBindingSource
            // 
            this.ценыРаботДляКлиентаBindingSource.DataMember = "Цены работ для клиента";
            this.ценыРаботДляКлиентаBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceListFilterTextBox
            // 
            this.priceListFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceListFilterTextBox.Location = new System.Drawing.Point(13, 69);
            this.priceListFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceListFilterTextBox.Multiline = true;
            this.priceListFilterTextBox.Name = "priceListFilterTextBox";
            this.priceListFilterTextBox.Size = new System.Drawing.Size(1140, 32);
            this.priceListFilterTextBox.TabIndex = 4;
            this.priceListFilterTextBox.TextChanged += new System.EventHandler(this.priceListFilterTextBox_TextChanged);
            // 
            // labelSortingCustomers
            // 
            this.labelSortingCustomers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortingCustomers.Location = new System.Drawing.Point(10, 37);
            this.labelSortingCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortingCustomers.Name = "labelSortingCustomers";
            this.labelSortingCustomers.Size = new System.Drawing.Size(246, 28);
            this.labelSortingCustomers.TabIndex = 20;
            this.labelSortingCustomers.Text = "Поиск цены за услуги";
            // 
            // цены_работ_для_клиентаTableAdapter
            // 
            this.цены_работ_для_клиентаTableAdapter.ClearBeforeFill = true;
            // 
            // Клиент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 648);
            this.Controls.Add(this.labelSortingCustomers);
            this.Controls.Add(this.priceListFilterTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Клиент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Клиент_FormClosing);
            this.Load += new System.EventHandler(this.Клиент_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценыРаботДляКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem сменитьАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox priceListFilterTextBox;
        private System.Windows.Forms.Label labelSortingCustomers;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource ценыРаботДляКлиентаBindingSource;
        private _k_systemsDataSetTableAdapters.Цены_работ_для_клиентаTableAdapter цены_работ_для_клиентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem почтаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
    }
}