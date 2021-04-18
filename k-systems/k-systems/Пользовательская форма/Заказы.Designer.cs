namespace k_systems.Пользовательская_форма
{
    partial class Заказы
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Заказы));
            this.updateOrdersButton = new System.Windows.Forms.Button();
            this.clientOrdersFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.orderFilterTextBox = new System.Windows.Forms.TextBox();
            this.labelSortingCustomers = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.видРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказГотовDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.заказыДляКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.заказы_для_клиентаTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Заказы_для_клиентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыДляКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // updateOrdersButton
            // 
            this.updateOrdersButton.Location = new System.Drawing.Point(713, 95);
            this.updateOrdersButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateOrdersButton.Name = "updateOrdersButton";
            this.updateOrdersButton.Size = new System.Drawing.Size(100, 28);
            this.updateOrdersButton.TabIndex = 12;
            this.updateOrdersButton.Text = "Обновить";
            this.updateOrdersButton.UseVisualStyleBackColor = true;
            this.updateOrdersButton.Click += new System.EventHandler(this.updateOrdersButton_Click);
            // 
            // clientOrdersFilterCheckBox
            // 
            this.clientOrdersFilterCheckBox.AutoSize = true;
            this.clientOrdersFilterCheckBox.Checked = true;
            this.clientOrdersFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.clientOrdersFilterCheckBox.Location = new System.Drawing.Point(13, 102);
            this.clientOrdersFilterCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientOrdersFilterCheckBox.Name = "clientOrdersFilterCheckBox";
            this.clientOrdersFilterCheckBox.Size = new System.Drawing.Size(206, 21);
            this.clientOrdersFilterCheckBox.TabIndex = 11;
            this.clientOrdersFilterCheckBox.Text = "Отображаются все заказы";
            this.clientOrdersFilterCheckBox.ThreeState = true;
            this.clientOrdersFilterCheckBox.UseVisualStyleBackColor = true;
            this.clientOrdersFilterCheckBox.CheckStateChanged += new System.EventHandler(this.clientOrdersFilterCheckBox_CheckStateChanged);
            // 
            // orderFilterTextBox
            // 
            this.orderFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderFilterTextBox.Location = new System.Drawing.Point(13, 40);
            this.orderFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderFilterTextBox.Multiline = true;
            this.orderFilterTextBox.Name = "orderFilterTextBox";
            this.orderFilterTextBox.Size = new System.Drawing.Size(799, 54);
            this.orderFilterTextBox.TabIndex = 10;
            this.orderFilterTextBox.TextChanged += new System.EventHandler(this.orderFilterTextBox_TextChanged);
            // 
            // labelSortingCustomers
            // 
            this.labelSortingCustomers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortingCustomers.Location = new System.Drawing.Point(13, 9);
            this.labelSortingCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortingCustomers.Name = "labelSortingCustomers";
            this.labelSortingCustomers.Size = new System.Drawing.Size(246, 28);
            this.labelSortingCustomers.TabIndex = 21;
            this.labelSortingCustomers.Text = "Поиск заказов";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.видРаботыDataGridViewTextBoxColumn,
            this.типРемонтаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.заказГотовDataGridViewCheckBoxColumn});
            this.dataGridView.DataSource = this.заказыДляКлиентаBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 130);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(800, 643);
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
            // заказГотовDataGridViewCheckBoxColumn
            // 
            this.заказГотовDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.заказГотовDataGridViewCheckBoxColumn.DataPropertyName = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn.HeaderText = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn.Name = "заказГотовDataGridViewCheckBoxColumn";
            this.заказГотовDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // заказыДляКлиентаBindingSource
            // 
            this.заказыДляКлиентаBindingSource.DataMember = "Заказы для клиента";
            this.заказыДляКлиентаBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказы_для_клиентаTableAdapter
            // 
            this.заказы_для_клиентаTableAdapter.ClearBeforeFill = true;
            // 
            // Заказы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 785);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelSortingCustomers);
            this.Controls.Add(this.updateOrdersButton);
            this.Controls.Add(this.clientOrdersFilterCheckBox);
            this.Controls.Add(this.orderFilterTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Заказы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Заказы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыДляКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateOrdersButton;
        private System.Windows.Forms.CheckBox clientOrdersFilterCheckBox;
        private System.Windows.Forms.TextBox orderFilterTextBox;
        private System.Windows.Forms.Label labelSortingCustomers;
        private System.Windows.Forms.DataGridView dataGridView;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource заказыДляКлиентаBindingSource;
        private _k_systemsDataSetTableAdapters.Заказы_для_клиентаTableAdapter заказы_для_клиентаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn заказГотовDataGridViewCheckBoxColumn;
    }
}