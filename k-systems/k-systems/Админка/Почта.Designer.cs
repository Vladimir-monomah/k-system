﻿namespace k_systems.Админка
{
    partial class Почта
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Почта));
            this.deletedMessagesTabControl = new System.Windows.Forms.TabControl();
            this.WriteLetter = new System.Windows.Forms.TabPage();
            this.userAdresseesComboBox = new System.Windows.Forms.ComboBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.emailMessageTextBox = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelWhom = new System.Windows.Forms.Label();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.incomingMessagesTabPanel = new System.Windows.Forms.TabPage();
            this.deleteMessageButton = new System.Windows.Forms.Button();
            this.outcommingMessagesTabPanel = new System.Windows.Forms.TabPage();
            this.deleteOutMessageButton = new System.Windows.Forms.Button();
            this.Basket = new System.Windows.Forms.TabPage();
            this.inputMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.outMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.сообщенияДляАдминистраторовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сообщения_для_администраторовTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Сообщения_для_администраторовTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сообщенияДляАдминистраторовОтправленныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сообщения_для_администраторов_отправленныеTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Сообщения_для_администраторов_отправленныеTableAdapter();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сообщенияДляАдминистраторовУдалённыеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сообщения_для_администраторов_удалённыеTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Сообщения_для_администраторов_удалённыеTableAdapter();
            this.фИОПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИООтправителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиДляЗаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователи_для_заказовTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Пользователи_для_заказовTableAdapter();
            this.deletedMessagesTabControl.SuspendLayout();
            this.WriteLetter.SuspendLayout();
            this.incomingMessagesTabPanel.SuspendLayout();
            this.outcommingMessagesTabPanel.SuspendLayout();
            this.Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outMessagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовОтправленныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовУдалённыеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deletedMessagesTabControl
            // 
            this.deletedMessagesTabControl.Controls.Add(this.WriteLetter);
            this.deletedMessagesTabControl.Controls.Add(this.incomingMessagesTabPanel);
            this.deletedMessagesTabControl.Controls.Add(this.outcommingMessagesTabPanel);
            this.deletedMessagesTabControl.Controls.Add(this.Basket);
            this.deletedMessagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedMessagesTabControl.Location = new System.Drawing.Point(0, 0);
            this.deletedMessagesTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.deletedMessagesTabControl.Name = "deletedMessagesTabControl";
            this.deletedMessagesTabControl.SelectedIndex = 0;
            this.deletedMessagesTabControl.Size = new System.Drawing.Size(879, 799);
            this.deletedMessagesTabControl.TabIndex = 1;
            // 
            // WriteLetter
            // 
            this.WriteLetter.Controls.Add(this.userAdresseesComboBox);
            this.WriteLetter.Controls.Add(this.sendEmailButton);
            this.WriteLetter.Controls.Add(this.emailMessageTextBox);
            this.WriteLetter.Controls.Add(this.labelSubject);
            this.WriteLetter.Controls.Add(this.labelWhom);
            this.WriteLetter.Controls.Add(this.emailSubjectTextBox);
            this.WriteLetter.Location = new System.Drawing.Point(4, 25);
            this.WriteLetter.Margin = new System.Windows.Forms.Padding(4);
            this.WriteLetter.Name = "WriteLetter";
            this.WriteLetter.Size = new System.Drawing.Size(871, 770);
            this.WriteLetter.TabIndex = 4;
            this.WriteLetter.Text = "Написать письмо";
            this.WriteLetter.UseVisualStyleBackColor = true;
            // 
            // userAdresseesComboBox
            // 
            this.userAdresseesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userAdresseesComboBox.DataSource = this.пользователиДляЗаказовBindingSource;
            this.userAdresseesComboBox.DisplayMember = "ФИО";
            this.userAdresseesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAdresseesComboBox.FormattingEnabled = true;
            this.userAdresseesComboBox.Location = new System.Drawing.Point(9, 20);
            this.userAdresseesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.userAdresseesComboBox.Name = "userAdresseesComboBox";
            this.userAdresseesComboBox.Size = new System.Drawing.Size(852, 24);
            this.userAdresseesComboBox.TabIndex = 4;
            this.userAdresseesComboBox.ValueMember = "Идентификатор";
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendEmailButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendEmailButton.Location = new System.Drawing.Point(347, 704);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(199, 43);
            this.sendEmailButton.TabIndex = 3;
            this.sendEmailButton.Text = "Отправить";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            // 
            // emailMessageTextBox
            // 
            this.emailMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailMessageTextBox.Location = new System.Drawing.Point(4, 113);
            this.emailMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailMessageTextBox.Multiline = true;
            this.emailMessageTextBox.Name = "emailMessageTextBox";
            this.emailMessageTextBox.Size = new System.Drawing.Size(858, 583);
            this.emailMessageTextBox.TabIndex = 2;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(5, 53);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(49, 17);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "Тема:";
            // 
            // labelWhom
            // 
            this.labelWhom.AutoSize = true;
            this.labelWhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhom.Location = new System.Drawing.Point(5, 0);
            this.labelWhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhom.Name = "labelWhom";
            this.labelWhom.Size = new System.Drawing.Size(51, 17);
            this.labelWhom.TabIndex = 1;
            this.labelWhom.Text = "Кому:";
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailSubjectTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailSubjectTextBox.Location = new System.Drawing.Point(5, 73);
            this.emailSubjectTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailSubjectTextBox.Multiline = true;
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(858, 33);
            this.emailSubjectTextBox.TabIndex = 0;
            // 
            // incomingMessagesTabPanel
            // 
            this.incomingMessagesTabPanel.Controls.Add(this.inputMessagesDataGridView);
            this.incomingMessagesTabPanel.Controls.Add(this.deleteMessageButton);
            this.incomingMessagesTabPanel.Location = new System.Drawing.Point(4, 25);
            this.incomingMessagesTabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.incomingMessagesTabPanel.Name = "incomingMessagesTabPanel";
            this.incomingMessagesTabPanel.Padding = new System.Windows.Forms.Padding(4);
            this.incomingMessagesTabPanel.Size = new System.Drawing.Size(871, 770);
            this.incomingMessagesTabPanel.TabIndex = 0;
            this.incomingMessagesTabPanel.Text = "Входящие";
            this.incomingMessagesTabPanel.UseVisualStyleBackColor = true;
            // 
            // deleteMessageButton
            // 
            this.deleteMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteMessageButton.Location = new System.Drawing.Point(687, 50);
            this.deleteMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteMessageButton.Name = "deleteMessageButton";
            this.deleteMessageButton.Size = new System.Drawing.Size(176, 28);
            this.deleteMessageButton.TabIndex = 1;
            this.deleteMessageButton.Text = "Удалить сообщение";
            this.deleteMessageButton.UseVisualStyleBackColor = true;
            // 
            // outcommingMessagesTabPanel
            // 
            this.outcommingMessagesTabPanel.Controls.Add(this.outMessagesDataGridView);
            this.outcommingMessagesTabPanel.Controls.Add(this.deleteOutMessageButton);
            this.outcommingMessagesTabPanel.Location = new System.Drawing.Point(4, 25);
            this.outcommingMessagesTabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.outcommingMessagesTabPanel.Name = "outcommingMessagesTabPanel";
            this.outcommingMessagesTabPanel.Size = new System.Drawing.Size(871, 770);
            this.outcommingMessagesTabPanel.TabIndex = 2;
            this.outcommingMessagesTabPanel.Text = "Отправленные";
            this.outcommingMessagesTabPanel.UseVisualStyleBackColor = true;
            // 
            // deleteOutMessageButton
            // 
            this.deleteOutMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOutMessageButton.Location = new System.Drawing.Point(687, 50);
            this.deleteOutMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteOutMessageButton.Name = "deleteOutMessageButton";
            this.deleteOutMessageButton.Size = new System.Drawing.Size(176, 28);
            this.deleteOutMessageButton.TabIndex = 2;
            this.deleteOutMessageButton.Text = "Удалить сообщение";
            this.deleteOutMessageButton.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            this.Basket.Controls.Add(this.dataGridView1);
            this.Basket.Location = new System.Drawing.Point(4, 25);
            this.Basket.Margin = new System.Windows.Forms.Padding(4);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(871, 770);
            this.Basket.TabIndex = 3;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // inputMessagesDataGridView
            // 
            this.inputMessagesDataGridView.AutoGenerateColumns = false;
            this.inputMessagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.inputMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn,
            this.текстСообщенияDataGridViewTextBoxColumn});
            this.inputMessagesDataGridView.DataSource = this.сообщенияДляАдминистраторовBindingSource;
            this.inputMessagesDataGridView.Location = new System.Drawing.Point(8, 85);
            this.inputMessagesDataGridView.Name = "inputMessagesDataGridView";
            this.inputMessagesDataGridView.RowTemplate.Height = 24;
            this.inputMessagesDataGridView.Size = new System.Drawing.Size(855, 677);
            this.inputMessagesDataGridView.TabIndex = 2;
            // 
            // outMessagesDataGridView
            // 
            this.outMessagesDataGridView.AutoGenerateColumns = false;
            this.outMessagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.outMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn1,
            this.темаDataGridViewTextBoxColumn1,
            this.текстСообщенияDataGridViewTextBoxColumn1});
            this.outMessagesDataGridView.DataSource = this.сообщенияДляАдминистраторовОтправленныеBindingSource;
            this.outMessagesDataGridView.Location = new System.Drawing.Point(8, 85);
            this.outMessagesDataGridView.Name = "outMessagesDataGridView";
            this.outMessagesDataGridView.RowTemplate.Height = 24;
            this.outMessagesDataGridView.Size = new System.Drawing.Size(855, 677);
            this.outMessagesDataGridView.TabIndex = 3;
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сообщенияДляАдминистраторовBindingSource
            // 
            this.сообщенияДляАдминистраторовBindingSource.DataMember = "Сообщения для администраторов";
            this.сообщенияДляАдминистраторовBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // сообщения_для_администраторовTableAdapter
            // 
            this.сообщения_для_администраторовTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn
            // 
            this.темаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.темаDataGridViewTextBoxColumn.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn.Name = "темаDataGridViewTextBoxColumn";
            this.темаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // текстСообщенияDataGridViewTextBoxColumn
            // 
            this.текстСообщенияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.текстСообщенияDataGridViewTextBoxColumn.DataPropertyName = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn.HeaderText = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn.Name = "текстСообщенияDataGridViewTextBoxColumn";
            this.текстСообщенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сообщенияДляАдминистраторовОтправленныеBindingSource
            // 
            this.сообщенияДляАдминистраторовОтправленныеBindingSource.DataMember = "Сообщения для администраторов отправленные";
            this.сообщенияДляАдминистраторовОтправленныеBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // сообщения_для_администраторов_отправленныеTableAdapter
            // 
            this.сообщения_для_администраторов_отправленныеTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn1
            // 
            this.темаDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.темаDataGridViewTextBoxColumn1.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn1.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn1.Name = "темаDataGridViewTextBoxColumn1";
            this.темаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // текстСообщенияDataGridViewTextBoxColumn1
            // 
            this.текстСообщенияDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.текстСообщенияDataGridViewTextBoxColumn1.DataPropertyName = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn1.HeaderText = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn1.Name = "текстСообщенияDataGridViewTextBoxColumn1";
            this.текстСообщенияDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОПолучателяDataGridViewTextBoxColumn,
            this.фИООтправителяDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn2,
            this.текстСообщенияDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.сообщенияДляАдминистраторовУдалённыеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 759);
            this.dataGridView1.TabIndex = 0;
            // 
            // сообщенияДляАдминистраторовУдалённыеBindingSource
            // 
            this.сообщенияДляАдминистраторовУдалённыеBindingSource.DataMember = "Сообщения для администраторов удалённые";
            this.сообщенияДляАдминистраторовУдалённыеBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // сообщения_для_администраторов_удалённыеTableAdapter
            // 
            this.сообщения_для_администраторов_удалённыеTableAdapter.ClearBeforeFill = true;
            // 
            // фИОПолучателяDataGridViewTextBoxColumn
            // 
            this.фИОПолучателяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОПолучателяDataGridViewTextBoxColumn.DataPropertyName = "ФИО получателя";
            this.фИОПолучателяDataGridViewTextBoxColumn.HeaderText = "ФИО получателя";
            this.фИОПолучателяDataGridViewTextBoxColumn.Name = "фИОПолучателяDataGridViewTextBoxColumn";
            this.фИОПолучателяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИООтправителяDataGridViewTextBoxColumn
            // 
            this.фИООтправителяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИООтправителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО отправителя";
            this.фИООтправителяDataGridViewTextBoxColumn.HeaderText = "ФИО отправителя";
            this.фИООтправителяDataGridViewTextBoxColumn.Name = "фИООтправителяDataGridViewTextBoxColumn";
            this.фИООтправителяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn2
            // 
            this.темаDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.темаDataGridViewTextBoxColumn2.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn2.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn2.Name = "темаDataGridViewTextBoxColumn2";
            this.темаDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // текстСообщенияDataGridViewTextBoxColumn2
            // 
            this.текстСообщенияDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.текстСообщенияDataGridViewTextBoxColumn2.DataPropertyName = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn2.HeaderText = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn2.Name = "текстСообщенияDataGridViewTextBoxColumn2";
            this.текстСообщенияDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // пользователиДляЗаказовBindingSource
            // 
            this.пользователиДляЗаказовBindingSource.DataMember = "Пользователи для заказов";
            this.пользователиДляЗаказовBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // пользователи_для_заказовTableAdapter
            // 
            this.пользователи_для_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // Почта
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 799);
            this.Controls.Add(this.deletedMessagesTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Почта";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почта";
            this.Load += new System.EventHandler(this.Почта_Load);
            this.deletedMessagesTabControl.ResumeLayout(false);
            this.WriteLetter.ResumeLayout(false);
            this.WriteLetter.PerformLayout();
            this.incomingMessagesTabPanel.ResumeLayout(false);
            this.outcommingMessagesTabPanel.ResumeLayout(false);
            this.Basket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outMessagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовОтправленныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовУдалённыеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl deletedMessagesTabControl;
        private System.Windows.Forms.TabPage WriteLetter;
        private System.Windows.Forms.ComboBox userAdresseesComboBox;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.TextBox emailMessageTextBox;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelWhom;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.TabPage incomingMessagesTabPanel;
        private System.Windows.Forms.Button deleteMessageButton;
        private System.Windows.Forms.TabPage outcommingMessagesTabPanel;
        private System.Windows.Forms.Button deleteOutMessageButton;
        private System.Windows.Forms.TabPage Basket;
        private System.Windows.Forms.DataGridView inputMessagesDataGridView;
        private System.Windows.Forms.DataGridView outMessagesDataGridView;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource сообщенияДляАдминистраторовBindingSource;
        private _k_systemsDataSetTableAdapters.Сообщения_для_администраторовTableAdapter сообщения_для_администраторовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сообщенияДляАдминистраторовОтправленныеBindingSource;
        private _k_systemsDataSetTableAdapters.Сообщения_для_администраторов_отправленныеTableAdapter сообщения_для_администраторов_отправленныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource сообщенияДляАдминистраторовУдалённыеBindingSource;
        private _k_systemsDataSetTableAdapters.Сообщения_для_администраторов_удалённыеTableAdapter сообщения_для_администраторов_удалённыеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИООтправителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource пользователиДляЗаказовBindingSource;
        private _k_systemsDataSetTableAdapters.Пользователи_для_заказовTableAdapter пользователи_для_заказовTableAdapter;
    }
}