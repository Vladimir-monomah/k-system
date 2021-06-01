namespace k_systems.Админка
{
    partial class Заказ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Заказ));
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.dressTypeLabel = new System.Windows.Forms.Label();
            this.dressTypeComboBox = new System.Windows.Forms.ComboBox();
            this.типРемонтаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.workKindLabel = new System.Windows.Forms.Label();
            this.workKindComboBox = new System.Windows.Forms.ComboBox();
            this.видРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.пользователиДляЗаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователи_для_заказовTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Пользователи_для_заказовTableAdapter();
            this.вид_работTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Вид_работTableAdapter();
            this.тип_ремонтаTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Тип_ремонтаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Work = new System.Windows.Forms.CheckBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типРемонтаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(277, 282);
            this.priceNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(273, 22);
            this.priceNumericUpDown.TabIndex = 18;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(164, 282);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(76, 29);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "Цена";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(454, 399);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(240, 64);
            this.addOrderButton.TabIndex = 16;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // dressTypeLabel
            // 
            this.dressTypeLabel.AutoSize = true;
            this.dressTypeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeLabel.Location = new System.Drawing.Point(71, 222);
            this.dressTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dressTypeLabel.Name = "dressTypeLabel";
            this.dressTypeLabel.Size = new System.Drawing.Size(172, 29);
            this.dressTypeLabel.TabIndex = 15;
            this.dressTypeLabel.Text = "Тип ремонта";
            // 
            // dressTypeComboBox
            // 
            this.dressTypeComboBox.DataSource = this.типРемонтаBindingSource;
            this.dressTypeComboBox.DisplayMember = "Наименование";
            this.dressTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dressTypeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeComboBox.FormattingEnabled = true;
            this.dressTypeComboBox.Location = new System.Drawing.Point(277, 223);
            this.dressTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dressTypeComboBox.Name = "dressTypeComboBox";
            this.dressTypeComboBox.Size = new System.Drawing.Size(714, 32);
            this.dressTypeComboBox.TabIndex = 14;
            this.dressTypeComboBox.ValueMember = "Идентификатор";
            this.dressTypeComboBox.SelectedValueChanged += new System.EventHandler(this.orderPriceComboBox_SelectedValueChanged);
            // 
            // типРемонтаBindingSource
            // 
            this.типРемонтаBindingSource.DataMember = "Тип ремонта";
            this.типРемонтаBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workKindLabel
            // 
            this.workKindLabel.AutoSize = true;
            this.workKindLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindLabel.Location = new System.Drawing.Point(81, 159);
            this.workKindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workKindLabel.Name = "workKindLabel";
            this.workKindLabel.Size = new System.Drawing.Size(160, 29);
            this.workKindLabel.TabIndex = 13;
            this.workKindLabel.Text = "Вид работы";
            // 
            // workKindComboBox
            // 
            this.workKindComboBox.DataSource = this.видРаботBindingSource;
            this.workKindComboBox.DisplayMember = "Наименование";
            this.workKindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workKindComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindComboBox.FormattingEnabled = true;
            this.workKindComboBox.Location = new System.Drawing.Point(277, 159);
            this.workKindComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.workKindComboBox.Name = "workKindComboBox";
            this.workKindComboBox.Size = new System.Drawing.Size(714, 32);
            this.workKindComboBox.TabIndex = 12;
            this.workKindComboBox.ValueMember = "Идентификатор";
            this.workKindComboBox.SelectedValueChanged += new System.EventHandler(this.workKindComboBox_SelectedValueChanged);
            // 
            // видРаботBindingSource
            // 
            this.видРаботBindingSource.DataMember = "Вид работ";
            this.видРаботBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(138, 43);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(105, 29);
            this.clientLabel.TabIndex = 11;
            this.clientLabel.Text = "Клиент";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.пользователиДляЗаказовBindingSource;
            this.clientComboBox.DisplayMember = "ФИО";
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(277, 43);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(273, 32);
            this.clientComboBox.TabIndex = 10;
            this.clientComboBox.ValueMember = "Id";
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
            // вид_работTableAdapter
            // 
            this.вид_работTableAdapter.ClearBeforeFill = true;
            // 
            // тип_ремонтаTableAdapter
            // 
            this.тип_ремонтаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Статус заказа";
            // 
            // Work
            // 
            this.Work.AutoSize = true;
            this.Work.Location = new System.Drawing.Point(277, 335);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(90, 21);
            this.Work.TabIndex = 22;
            this.Work.Text = "В работе";
            this.Work.UseVisualStyleBackColor = true;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Phone.Location = new System.Drawing.Point(276, 104);
            this.Phone.Mask = "+7(***) ***-****";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(274, 32);
            this.Phone.TabIndex = 38;
            this.Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(120, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 39;
            this.label2.Text = "Телефон";
            // 
            // Заказ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 476);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Work);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.dressTypeLabel);
            this.Controls.Add(this.dressTypeComboBox);
            this.Controls.Add(this.workKindLabel);
            this.Controls.Add(this.workKindComboBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Заказ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Заказ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типРемонтаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Label dressTypeLabel;
        private System.Windows.Forms.ComboBox dressTypeComboBox;
        private System.Windows.Forms.Label workKindLabel;
        private System.Windows.Forms.ComboBox workKindComboBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.ComboBox clientComboBox;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource пользователиДляЗаказовBindingSource;
        private _k_systemsDataSetTableAdapters.Пользователи_для_заказовTableAdapter пользователи_для_заказовTableAdapter;
        private System.Windows.Forms.BindingSource видРаботBindingSource;
        private _k_systemsDataSetTableAdapters.Вид_работTableAdapter вид_работTableAdapter;
        private System.Windows.Forms.BindingSource типРемонтаBindingSource;
        private _k_systemsDataSetTableAdapters.Тип_ремонтаTableAdapter тип_ремонтаTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Work;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.Label label2;
    }
}