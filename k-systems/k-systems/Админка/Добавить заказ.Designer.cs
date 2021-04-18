namespace k_systems.Админка
{
    partial class Добавить_заказ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавить_заказ));
            this.readyOrdersFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.orderFilterTextBox = new System.Windows.Forms.TextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.orderSearchLabel = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.заказыСКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказы_с_клиентамиTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Заказы_с_клиентамиTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типРемонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказГотовDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // readyOrdersFilterCheckBox
            // 
            this.readyOrdersFilterCheckBox.AutoSize = true;
            this.readyOrdersFilterCheckBox.Checked = true;
            this.readyOrdersFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.readyOrdersFilterCheckBox.Location = new System.Drawing.Point(14, 72);
            this.readyOrdersFilterCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.readyOrdersFilterCheckBox.Name = "readyOrdersFilterCheckBox";
            this.readyOrdersFilterCheckBox.Size = new System.Drawing.Size(206, 21);
            this.readyOrdersFilterCheckBox.TabIndex = 11;
            this.readyOrdersFilterCheckBox.Text = "Отображаются все заказы";
            this.readyOrdersFilterCheckBox.ThreeState = true;
            this.readyOrdersFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // orderFilterTextBox
            // 
            this.orderFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderFilterTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderFilterTextBox.Location = new System.Drawing.Point(10, 27);
            this.orderFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderFilterTextBox.Name = "orderFilterTextBox";
            this.orderFilterTextBox.Size = new System.Drawing.Size(856, 36);
            this.orderFilterTextBox.TabIndex = 8;
            this.orderFilterTextBox.TextChanged += new System.EventHandler(this.orderFilterTextBox_TextChanged);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(59, 100);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(756, 42);
            this.addOrderButton.TabIndex = 10;
            this.addOrderButton.Text = "Добавить новый заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // orderSearchLabel
            // 
            this.orderSearchLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderSearchLabel.Location = new System.Drawing.Point(14, 8);
            this.orderSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderSearchLabel.Name = "orderSearchLabel";
            this.orderSearchLabel.Size = new System.Drawing.Size(172, 28);
            this.orderSearchLabel.TabIndex = 9;
            this.orderSearchLabel.Text = "Поиск заказов";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.видРаботыDataGridViewTextBoxColumn,
            this.типРемонтаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.заказГотовDataGridViewCheckBoxColumn});
            this.dataGridViewOrder.DataSource = this.заказыСКлиентамиBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(6, 150);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(860, 618);
            this.dataGridViewOrder.TabIndex = 12;
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
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видРаботыDataGridViewTextBoxColumn
            // 
            this.видРаботыDataGridViewTextBoxColumn.DataPropertyName = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.HeaderText = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.Name = "видРаботыDataGridViewTextBoxColumn";
            // 
            // типРемонтаDataGridViewTextBoxColumn
            // 
            this.типРемонтаDataGridViewTextBoxColumn.DataPropertyName = "Тип ремонта";
            this.типРемонтаDataGridViewTextBoxColumn.HeaderText = "Тип ремонта";
            this.типРемонтаDataGridViewTextBoxColumn.Name = "типРемонтаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // заказГотовDataGridViewCheckBoxColumn
            // 
            this.заказГотовDataGridViewCheckBoxColumn.DataPropertyName = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn.HeaderText = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn.Name = "заказГотовDataGridViewCheckBoxColumn";
            // 
            // Добавить_заказ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 799);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.readyOrdersFilterCheckBox);
            this.Controls.Add(this.orderFilterTextBox);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.orderSearchLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Добавить_заказ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.Добавить_заказ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox readyOrdersFilterCheckBox;
        private System.Windows.Forms.TextBox orderFilterTextBox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Label orderSearchLabel;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource заказыСКлиентамиBindingSource;
        private _k_systemsDataSetTableAdapters.Заказы_с_клиентамиTableAdapter заказы_с_клиентамиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРемонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn заказГотовDataGridViewCheckBoxColumn;
    }
}